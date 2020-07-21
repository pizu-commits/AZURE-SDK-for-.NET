﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Azure.Core.Pipeline
{
    /// <summary>
    /// A policy that sends an <see cref="AccessToken"/> provided by a <see cref="TokenCredential"/> as an Authentication header.
    /// </summary>
    public class BearerTokenAuthenticationPolicy : HttpPipelinePolicy
    {
        private readonly AccessTokenCache _accessTokenCache;

        /// <summary>
        /// Creates a new instance of <see cref="BearerTokenAuthenticationPolicy"/> using provided token credential and scope to authenticate for.
        /// </summary>
        /// <param name="credential">The token credential to use for authentication.</param>
        /// <param name="scope">The scope to authenticate for.</param>
        public BearerTokenAuthenticationPolicy(TokenCredential credential, string scope) : this(credential, new[] { scope }) { }

        /// <summary>
        /// Creates a new instance of <see cref="BearerTokenAuthenticationPolicy"/> using provided token credential and scopes to authenticate for.
        /// </summary>
        /// <param name="credential">The token credential to use for authentication.</param>
        /// <param name="scopes">Scopes to authenticate for.</param>
        public BearerTokenAuthenticationPolicy(TokenCredential credential, IEnumerable<string> scopes)
            : this(credential, scopes, TimeSpan.FromMinutes(5), TimeSpan.FromSeconds(30)) { }

        internal BearerTokenAuthenticationPolicy(TokenCredential credential, IEnumerable<string> scopes, TimeSpan tokenRefreshOffset, TimeSpan tokenRefreshRetryTimeout) {
            Argument.AssertNotNull(credential, nameof(credential));
            Argument.AssertNotNull(scopes, nameof(scopes));

            _accessTokenCache = new AccessTokenCache(credential, scopes.ToArray(), tokenRefreshOffset, tokenRefreshRetryTimeout);
        }

        /// <inheritdoc />
        public override ValueTask ProcessAsync(HttpMessage message, ReadOnlyMemory<HttpPipelinePolicy> pipeline)
        {
            return ProcessAsync(message, pipeline, true);
        }

        /// <inheritdoc />
        public override void Process(HttpMessage message, ReadOnlyMemory<HttpPipelinePolicy> pipeline)
        {
            ProcessAsync(message, pipeline, false).EnsureCompleted();
        }

        private async ValueTask ProcessAsync(HttpMessage message, ReadOnlyMemory<HttpPipelinePolicy> pipeline, bool async)
        {
            if (message.Request.Uri.Scheme != Uri.UriSchemeHttps)
            {
                throw new InvalidOperationException("Bearer token authentication is not permitted for non TLS protected (https) endpoints.");
            }

            string headerValue = await _accessTokenCache.GetHeaderValueAsync(message, async);
            message.Request.SetHeader(HttpHeader.Names.Authorization, headerValue);

            if (async)
            {
                await ProcessNextAsync(message, pipeline).ConfigureAwait(false);
            }
            else
            {
                ProcessNext(message, pipeline);
            }
        }

        private class AccessTokenCache
        {
            private readonly object _syncObj = new object();
            private readonly TokenCredential _credential;
            private readonly string[] _scopes;
            private readonly TimeSpan _tokenRefreshOffset;
            private readonly TimeSpan _tokenRefreshRetryTimeout;

            private TaskCompletionSource<HeaderValueInfo>? _infoTcs;
            private TaskCompletionSource<HeaderValueInfo>? _backgroundUpdateTcs;
            public AccessTokenCache(TokenCredential credential, string[] scopes, TimeSpan tokenRefreshOffset, TimeSpan tokenRefreshRetryTimeout)
            {
                _credential = credential;
                _scopes = scopes;
                _tokenRefreshOffset = tokenRefreshOffset;
                _tokenRefreshRetryTimeout = tokenRefreshRetryTimeout;
            }

            public async ValueTask<string> GetHeaderValueAsync(HttpMessage message, bool async)
            {
                bool getTokenFromCredential;
                TaskCompletionSource<HeaderValueInfo> headerValueTcs;
                TaskCompletionSource<HeaderValueInfo>? backgroundUpdateTcs;
                (headerValueTcs, backgroundUpdateTcs, getTokenFromCredential) = GetTaskCompletionSources();

                if (getTokenFromCredential)
                {
                    if (backgroundUpdateTcs != null)
                    {
                        HeaderValueInfo info = headerValueTcs.Task.EnsureCompleted();
                        _ = Task.Run(() => GetHeaderValueFromCredentialInBackgroundAsync(backgroundUpdateTcs, info, message, async));
                        return info.HeaderValue;
                    }

                    try
                    {
                        HeaderValueInfo info = await GetHeaderValueFromCredentialAsync(message, async);
                        headerValueTcs.SetResult(info);
                    }
                    catch (Exception exception)
                    {
                        headerValueTcs.SetException(exception);
                        throw;
                    }
                }

                var headerValueTask = headerValueTcs.Task;
                if (!headerValueTask.IsCompleted)
                {
                    if (async)
                    {
                        await headerValueTask.AwaitWithCancellation(message.CancellationToken);
                    }
                    else
                    {
                        try
                        {
                            headerValueTask.Wait(message.CancellationToken);
                        }
                        catch (AggregateException) { } // ignore exception here to rethrow it with EnsureCompleted
                    }
                }

                return headerValueTcs.Task.EnsureCompleted().HeaderValue;
            }

            private (TaskCompletionSource<HeaderValueInfo> tcs, TaskCompletionSource<HeaderValueInfo>? backgroundUpdateTcs, bool getTokenFromCredential) GetTaskCompletionSources()
            {
                lock (_syncObj)
                {
                    if (_infoTcs == null)
                    {
                        _infoTcs = new TaskCompletionSource<HeaderValueInfo>(TaskCreationOptions.RunContinuationsAsynchronously);
                        return (_infoTcs, default, true);
                    }

                    if (!_infoTcs.Task.IsCompleted)
                    {
                        _backgroundUpdateTcs = default;
                        return (_infoTcs, _backgroundUpdateTcs, false);
                    }

                    DateTimeOffset now = DateTimeOffset.UtcNow;
                    if (_backgroundUpdateTcs != null && _backgroundUpdateTcs.Task.Status == TaskStatus.RanToCompletion && _backgroundUpdateTcs.Task.Result.ExpiresOn > now)
                    {
                        _infoTcs = _backgroundUpdateTcs;
                        _backgroundUpdateTcs = default;
                    }

                    if (_infoTcs.Task.Status != TaskStatus.RanToCompletion || now >= _infoTcs.Task.Result.ExpiresOn)
                    {
                        _infoTcs = new TaskCompletionSource<HeaderValueInfo>(TaskCreationOptions.RunContinuationsAsynchronously);
                        return (_infoTcs, default, true);
                    }

                    if (now >= _infoTcs.Task.Result.RefreshOn && _backgroundUpdateTcs == null)
                    {
                        _backgroundUpdateTcs = new TaskCompletionSource<HeaderValueInfo>(TaskCreationOptions.RunContinuationsAsynchronously);
                        return (_infoTcs, _backgroundUpdateTcs, true);
                    }

                    return (_infoTcs, default, false);
                }
            }

            private async ValueTask GetHeaderValueFromCredentialInBackgroundAsync(TaskCompletionSource<HeaderValueInfo> backgroundUpdateTcs, HeaderValueInfo info, HttpMessage httpMessage, bool async)
            {
                try
                {
                    HeaderValueInfo newInfo = await GetHeaderValueFromCredentialAsync(httpMessage, async);
                    backgroundUpdateTcs.SetResult(newInfo);
                }
                catch (Exception)
                {
                    backgroundUpdateTcs.SetResult(new HeaderValueInfo(info.HeaderValue, info.ExpiresOn, DateTimeOffset.UtcNow + _tokenRefreshRetryTimeout));
                }
            }

            private async ValueTask<HeaderValueInfo> GetHeaderValueFromCredentialAsync(HttpMessage message, bool async)
            {
                var requestContext = new TokenRequestContext(_scopes, message.Request.ClientRequestId);
                AccessToken token = async
                    ? await _credential.GetTokenAsync(requestContext, message.CancellationToken).ConfigureAwait(false)
                    : _credential.GetToken(requestContext, message.CancellationToken);

                return new HeaderValueInfo("Bearer " + token.Token, token.ExpiresOn, token.ExpiresOn - _tokenRefreshOffset);
            }

            private readonly struct HeaderValueInfo
            {
                public string HeaderValue { get; }
                public DateTimeOffset ExpiresOn { get; }
                public DateTimeOffset RefreshOn { get; }

                public HeaderValueInfo(string headerValue, DateTimeOffset expiresOn, DateTimeOffset refreshOn)
                {
                    HeaderValue = headerValue;
                    ExpiresOn = expiresOn;
                    RefreshOn = refreshOn;
                }
            }
        }
    }
}
