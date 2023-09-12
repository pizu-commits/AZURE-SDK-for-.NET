﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure.Communication.JobRouter.Models;
using Azure.Communication.Pipeline;
using Azure.Communication.SkillsRegistry;
using Azure.Core;
using Azure.Core.Pipeline;

 namespace Azure.Communication.JobRouter
{
    /// <summary>
    /// The Azure Communication Services Skills Registry client.
    /// </summary>
    public class SkillsRegistryClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        internal SkillsRegistryRestClient RestClient { get; }

        #region public constructors - all arguments need null check

        /// <summary> Initializes a new instance of <see cref="SkillsRegistryClient"/>.</summary>
        /// <param name="connectionString">Connection string acquired from the Azure Communication Services resource.</param>
        public SkillsRegistryClient(string connectionString)
            : this(
                ConnectionString.Parse(Argument.CheckNotNullOrEmpty(connectionString, nameof(connectionString))),
                new SkillsRegistryClientOptions())
        {
        }

        /// <summary> Initializes a new instance of <see cref="SkillsRegistryClient"/>.</summary>
        /// <param name="connectionString">Connection string acquired from the Azure Communication Services resource.</param>
        /// <param name="options">Client option exposing <see cref="ClientOptions.Diagnostics"/>, <see cref="ClientOptions.Retry"/>, <see cref="ClientOptions.Transport"/>, etc.</param>
        public SkillsRegistryClient(string connectionString, SkillsRegistryClientOptions options)
            : this(
                ConnectionString.Parse(Argument.CheckNotNullOrEmpty(connectionString, nameof(connectionString))),
                options ?? new SkillsRegistryClientOptions())
        {
        }

        /// <summary> Initializes a new instance of <see cref="SkillsRegistryClient"/>.</summary>
        /// <param name="endpoint">The URI of the Azure Communication Services resource.</param>
        /// <param name="credential">The <see cref="AzureKeyCredential"/> used to authenticate requests.</param>
        /// <param name="options">Client option exposing <see cref="ClientOptions.Diagnostics"/>, <see cref="ClientOptions.Retry"/>, <see cref="ClientOptions.Transport"/>, etc.</param>
        public SkillsRegistryClient(Uri endpoint, AzureKeyCredential credential, SkillsRegistryClientOptions options = default)
            : this(
                Argument.CheckNotNull(endpoint, nameof(endpoint)).AbsoluteUri,
                Argument.CheckNotNull(credential, nameof(credential)),
                options ?? new SkillsRegistryClientOptions())
        {
        }

        /// <summary> Initializes a new instance of <see cref="SkillsRegistryClient"/>.</summary>
        /// <param name="endpoint">The URI of the Azure Communication Services resource.</param>
        /// <param name="credential">The TokenCredential used to authenticate requests, such as DefaultAzureCredential.</param>
        /// <param name="options">Client option exposing <see cref="ClientOptions.Diagnostics"/>, <see cref="ClientOptions.Retry"/>, <see cref="ClientOptions.Transport"/>, etc.</param>
        public SkillsRegistryClient(Uri endpoint, TokenCredential credential, SkillsRegistryClientOptions options = default)
            : this(
                Argument.CheckNotNull(endpoint, nameof(endpoint)).AbsoluteUri,
                Argument.CheckNotNull(credential, nameof(credential)),
                options ?? new SkillsRegistryClientOptions())
        {
        }

        #endregion

        #region private constructors

        private SkillsRegistryClient(ConnectionString connectionString, SkillsRegistryClientOptions options)
            : this(connectionString.GetRequired("endpoint"), options.BuildHttpPipeline(connectionString), options)
        {
        }

        private SkillsRegistryClient(string endpoint, TokenCredential tokenCredential, SkillsRegistryClientOptions options)
            : this(endpoint, options.BuildHttpPipeline(tokenCredential), options)
        {
        }

        private SkillsRegistryClient(string endpoint, AzureKeyCredential keyCredential, SkillsRegistryClientOptions options)
            : this(endpoint, options.BuildHttpPipeline(keyCredential), options)
        {
        }

        private SkillsRegistryClient(string endpoint, HttpPipeline httpPipeline, SkillsRegistryClientOptions options)
        {
            _clientDiagnostics = new ClientDiagnostics(options);
            RestClient = new SkillsRegistryRestClient(_clientDiagnostics, httpPipeline, endpoint, options.ApiVersion);
        }

        /// <summary>Initializes a new instance of <see cref="JobRouterClient"/> for mocking.</summary>
        protected SkillsRegistryClient()
        {
            _clientDiagnostics = null;
            RestClient = null;
        }

        #endregion

        #region Skills

        /// <summary> Escalating a job from an intent. </summary>
        /// <param name="options"> The options for escalating a job. </param>
        /// <param name="cancellationToken"> (Optional) The cancellation token to use. </param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        public virtual async Task<Response<RouterJob>> EscalateAsync(EscalateOptions options, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SkillsRegistryClient)}.{nameof(Escalate)}");
            scope.Start();

            var request = new EscalateRequest
            {
                ChannelId = options.ChannelId,
                IntentId = options.IntentId,
                JobId = options.JobId
            };

            foreach (var parameter in options.Parameters)
            {
                request.Parameters[parameter.Key] = parameter.Value.Value;
            }

            try
            {
                return await RestClient.EscalateAsync(request, cancellationToken: cancellationToken)
                    .ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary> Escalating a job from an intent. </summary>
        /// <param name="options"> The options for escalating a job. </param>
        /// <param name="cancellationToken"> (Optional) The cancellation token to use. </param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        public virtual Response<RouterJob> Escalate(EscalateOptions options, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SkillsRegistryClient)}.{nameof(Escalate)}");
            scope.Start();

            var request = new EscalateRequest
            {
                ChannelId = options.ChannelId,
                IntentId = options.IntentId,
                JobId = options.JobId
            };

            foreach (var parameter in options.Parameters)
            {
                request.Parameters[parameter.Key] = parameter.Value.Value;
            }

            try
            {
                return RestClient.Escalate(request, cancellationToken: cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        #endregion Skills
    }
}
