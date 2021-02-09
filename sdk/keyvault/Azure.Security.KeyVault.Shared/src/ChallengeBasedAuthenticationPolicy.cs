﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;
using Azure.Core.Pipeline;
using System;
using System.Collections.Concurrent;
using System.Globalization;
using System.Threading.Tasks;

namespace Azure.Security.KeyVault
{
    internal class ChallengeBasedAuthenticationPolicy : BearerTokenChallengeAuthenticationPolicy
    {
        private static ConcurrentDictionary<string, AuthorityScope> _scopeCache = new ConcurrentDictionary<string, AuthorityScope>();
        private AuthorityScope _scope;

        public ChallengeBasedAuthenticationPolicy(TokenCredential credential) : base(credential, Array.Empty<string>())
        { }

        public override void Process(HttpMessage message, ReadOnlyMemory<HttpPipelinePolicy> pipeline)
        {
            PreProcessAsync(message, pipeline, false).EnsureCompleted();
            base.Process(message, pipeline);
        }

        public override async ValueTask ProcessAsync(HttpMessage message, ReadOnlyMemory<HttpPipelinePolicy> pipeline)
        {
            await PreProcessAsync(message, pipeline, true).ConfigureAwait(false);
            await base.ProcessAsync(message, pipeline).ConfigureAwait(false);
        }

        protected async Task PreProcessAsync(HttpMessage message, ReadOnlyMemory<HttpPipelinePolicy> pipeline, bool async)
        {
            if (message.Request.Uri.Scheme != Uri.UriSchemeHttps)
            {
                throw new InvalidOperationException("Bearer token authentication is not permitted for non TLS protected (https) endpoints.");
            }

            // if this policy doesn't have _scope cached try to get it from the static challenge cache.
            if (_scope != null)
            {
                return;
            }

            string authority = GetRequestAuthority(message.Request);
            _scopeCache.TryGetValue(authority, out _scope);

            if (_scope == null)
            {
                RequestContent originalContent = message.Request.Content;
                message.Request.Content = null;

                if (async)
                {
                    await ProcessNextAsync(message, pipeline).ConfigureAwait(false);
                }
                else
                {
                    ProcessNext(message, pipeline);
                }

                // set the content to the original content.
                message.Request.Content = originalContent;
            }
        }

        protected override bool TryGetTokenRequestContextFromChallenge(HttpMessage message, out TokenRequestContext context)
        {
            string authority = GetChallengeFromResponse(message.Response, "Bearer", "authorization");
            string scope = GetChallengeFromResponse(message.Response, "Bearer", "resource");
            if (scope != null)
            {
                scope = scope + "/.default";
            }
            else
            {
                scope = GetChallengeFromResponse(message.Response, "Bearer", "scope");
            }

            if (scope is null)
            {
                authority = GetRequestAuthority(message.Request);
                if (_scopeCache.TryGetValue(authority, out _scope))
                {
                    return false;
                }
            }
            else
            {
                _scope = new AuthorityScope(authority, new string[] { scope });
            }

            context = new TokenRequestContext(_scope.Scopes, message.Request.ClientRequestId);
            return true;
        }

        internal class AuthorityScope
        {
            internal AuthorityScope(string authrority, string[] scopes)
            {
                Authority = authrority;
                Scopes = scopes;
            }
            public string Authority { get; }

            public string[] Scopes { get; }
        }

        internal static void ClearCache()
        {
            _scopeCache.Clear();
        }

        private static string GetRequestAuthority(Request request)
        {
            Uri uri = request.Uri.ToUri();

            string authority = uri.Authority;

            if (!authority.Contains(":") && uri.Port > 0)
            {
                // Append port for complete authority
                authority = uri.Authority + ":" + uri.Port.ToString(CultureInfo.InvariantCulture);
            }

            return authority;
        }
    }
}
