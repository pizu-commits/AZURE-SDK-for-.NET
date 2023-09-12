// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Azure.Communication.JobRouter;
using Azure.Communication.JobRouter.Models;
using Azure.Communication.Pipeline;
using Azure.Communication.SkillsRegistry.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Communication.SkillsRegistry
{
    /// <summary>
    /// The Azure Communication Services Skills Registry Administration client.
    /// </summary>
    public class SkillsRegistryAdministrationClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        internal SkillsRegistryRestClient RestClient { get; }

        #region public constructors

        /// <summary> Initializes a new instance of <see cref="SkillsRegistryAdministrationClient"/>.</summary>
        /// <param name="connectionString">Connection string acquired from the Azure Communication Services resource.</param>
        public SkillsRegistryAdministrationClient(string connectionString)
            : this(
                ConnectionString.Parse(Argument.CheckNotNullOrEmpty(connectionString, nameof(connectionString))),
                new JobRouterClientOptions())
        {
        }

        /// <summary> Initializes a new instance of <see cref="SkillsRegistryAdministrationClient"/>.</summary>
        /// <param name="connectionString">Connection string acquired from the Azure Communication Services resource.</param>
        /// <param name="options">Client option exposing <see cref="ClientOptions.Diagnostics"/>, <see cref="ClientOptions.Retry"/>, <see cref="ClientOptions.Transport"/>, etc.</param>
        public SkillsRegistryAdministrationClient(string connectionString, JobRouterClientOptions options)
            : this(
                ConnectionString.Parse(Argument.CheckNotNullOrEmpty(connectionString, nameof(connectionString))),
                options ?? new JobRouterClientOptions())
        {
        }

        /// <summary> Initializes a new instance of <see cref="SkillsRegistryAdministrationClient"/>.</summary>
        /// <param name="endpoint">The URI of the Azure Communication Services resource.</param>
        /// <param name="credential">The <see cref="AzureKeyCredential"/> used to authenticate requests.</param>
        /// <param name="options">Client option exposing <see cref="ClientOptions.Diagnostics"/>, <see cref="ClientOptions.Retry"/>, <see cref="ClientOptions.Transport"/>, etc.</param>
        public SkillsRegistryAdministrationClient(Uri endpoint, AzureKeyCredential credential, JobRouterClientOptions options = default)
            : this(
                Argument.CheckNotNull(endpoint, nameof(endpoint)).AbsoluteUri,
                Argument.CheckNotNull(credential, nameof(credential)),
                options ?? new JobRouterClientOptions())
        {
        }

        /// <summary> Initializes a new instance of <see cref="SkillsRegistryAdministrationClient"/>.</summary>
        /// <param name="endpoint">The URI of the Azure Communication Services resource.</param>
        /// <param name="credential">The TokenCredential used to authenticate requests, such as DefaultAzureCredential.</param>
        /// <param name="options">Client option exposing <see cref="ClientOptions.Diagnostics"/>, <see cref="ClientOptions.Retry"/>, <see cref="ClientOptions.Transport"/>, etc.</param>
        public SkillsRegistryAdministrationClient(Uri endpoint, TokenCredential credential, JobRouterClientOptions options = default)
            : this(
                Argument.CheckNotNull(endpoint, nameof(endpoint)).AbsoluteUri,
                Argument.CheckNotNull(credential, nameof(credential)),
                options ?? new JobRouterClientOptions())
        {
        }

        #endregion public constructors

        #region private constructors

        private SkillsRegistryAdministrationClient(ConnectionString connectionString, JobRouterClientOptions options)
            : this(connectionString.GetRequired("endpoint"), options.BuildHttpPipeline(connectionString), options)
        {
        }

        private SkillsRegistryAdministrationClient(string endpoint, TokenCredential tokenCredential, JobRouterClientOptions options)
            : this(endpoint, options.BuildHttpPipeline(tokenCredential), options)
        {
        }

        private SkillsRegistryAdministrationClient(string endpoint, AzureKeyCredential keyCredential, JobRouterClientOptions options)
            : this(endpoint, options.BuildHttpPipeline(keyCredential), options)
        {
        }

        private SkillsRegistryAdministrationClient(string endpoint, HttpPipeline httpPipeline, JobRouterClientOptions options)
        {
            _clientDiagnostics = new ClientDiagnostics(options);
            RestClient = new SkillsRegistryRestClient(_clientDiagnostics, httpPipeline, endpoint, options.ApiVersion);
        }

        /// <summary>Initializes a new instance of <see cref="SkillsRegistryAdministrationClient"/> for mocking.</summary>
        protected SkillsRegistryAdministrationClient()
        {
            _clientDiagnostics = null;
            RestClient = null;
        }

        #endregion private constructors

        #region Intents

        /// <summary> Creates an intent. </summary>
        /// <param name="options"> (Optional) Options for creating intent. Uses merge-patch semantics: https://datatracker.ietf.org/doc/html/rfc7386. </param>
        /// <param name="cancellationToken"> (Optional) The cancellation token to use. </param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        public virtual async Task<Response<RouterIntent>> CreateIntentAsync(
            CreateIntentOptions options,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SkillsRegistryAdministrationClient)}.{nameof(CreateIntent)}");
            scope.Start();
            try
            {
                var request = new RouterIntent
                {
                    Description = options.Description,
                    EscalationQueueId = options.EscalationQueueId,
                    AnalyzeSentiment = options.AnalyzeSentiment,
                    SummarizeConversation = options.SummarizeConversation,
                    DetectEscalation = options.DetectEscalation,
                };

                request.Parameters.Append(options.Parameters);

                return await RestClient.UpsertIntentAsync(
                        id: options.IntentId,
                        patch: request,
                        cancellationToken: cancellationToken)
                    .ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary> Creates or updates a intent. </summary>
        /// <param name="options"> (Optional) Options for creating intent.. </param>
        /// <param name="cancellationToken"> (Optional) The cancellation token to use. </param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        public virtual Response<RouterIntent> CreateIntent(
            CreateIntentOptions options,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SkillsRegistryAdministrationClient)}.{nameof(CreateIntent)}");
            scope.Start();
            try
            {
                var request = new RouterIntent
                {
                    Description = options.Description,
                    EscalationQueueId = options.EscalationQueueId,
                    AnalyzeSentiment = options.AnalyzeSentiment,
                    SummarizeConversation = options.SummarizeConversation,
                    DetectEscalation = options.DetectEscalation,
                };

                request.Parameters.Append(options.Parameters);

                return RestClient.UpsertIntent(
                        id: options.IntentId,
                        patch: request,
                        cancellationToken: cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary> Creates or updates intent. </summary>
        /// <param name="options"> (Optional) Options for updating intent. Uses merge-patch semantics: https://datatracker.ietf.org/doc/html/rfc7386. </param>
        /// <param name="cancellationToken"> (Optional) The cancellation token to use. </param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        public virtual async Task<Response<RouterIntent>> UpdateIntentAsync(
            UpdateIntentOptions options,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SkillsRegistryAdministrationClient)}.{nameof(UpdateIntent)}");
            scope.Start();
            try
            {
                var request = new RouterIntent
                {
                    Description = options.Description,
                    EscalationQueueId = options.EscalationQueueId,
                    AnalyzeSentiment = options.AnalyzeSentiment,
                    SummarizeConversation = options.SummarizeConversation,
                    DetectEscalation = options.DetectEscalation,
                };

                request.Parameters.Append(options.Parameters);

                return await RestClient.UpsertIntentAsync(
                        id: options.IntentId,
                        patch: request,
                        cancellationToken: cancellationToken)
                    .ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary> Creates or updates a intent. </summary>
        /// <param name="options"> (Optional) Options for updating intent. Uses merge-patch semantics: https://datatracker.ietf.org/doc/html/rfc7386. </param>
        /// <param name="cancellationToken"> (Optional) The cancellation token to use. </param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        public virtual Response<RouterIntent> UpdateIntent(
            UpdateIntentOptions options,
            CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SkillsRegistryAdministrationClient)}.{nameof(UpdateIntent)}");
            scope.Start();
            try
            {
                var request = new RouterIntent
                {
                    Description = options.Description,
                    EscalationQueueId = options.EscalationQueueId,
                    AnalyzeSentiment = options.AnalyzeSentiment,
                    SummarizeConversation = options.SummarizeConversation,
                    DetectEscalation = options.DetectEscalation,
                };

                request.Parameters.Append(options.Parameters);

                return RestClient.UpsertIntent(
                        id: options.IntentId,
                        patch: request,
                        cancellationToken: cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary> Protocol method to use to remove properties from intent. </summary>
        /// <param name="intentId"> Id of the intent. </param>
        /// <param name="content"> Request content payload. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        public virtual async Task<Response> UpdateIntentAsync(
            string intentId,
            RequestContent content,
            RequestContext context = null)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SkillsRegistryAdministrationClient)}.{nameof(UpdateIntent)}");
            scope.Start();
            try
            {
                return await RestClient.UpsertIntentAsync(
                        id: intentId,
                        content: content,
                        context: context)
                    .ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary> Protocol method to use to remove properties from intent. </summary>
        /// <param name="intentId"> Id of the intent. </param>
        /// <param name="content"> Request content payload. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        public virtual Response UpdateIntent(
            string intentId,
            RequestContent content,
            RequestContext context = null)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SkillsRegistryAdministrationClient)}.{nameof(UpdateIntent)}");
            scope.Start();
            try
            {
                return RestClient.UpsertIntent(
                    id: intentId,
                    content: content,
                    context: context);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary> Retrieves existing intents. </summary>
        /// <param name="cancellationToken"> (Optional) The cancellation token to use. </param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        public virtual AsyncPageable<IntentItem> GetIntentsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<IntentItem>> FirstPageFunc(int? maxPageSize)
            {
                using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SkillsRegistryAdministrationClient)}.{nameof(GetIntents)}");
                scope.Start();
                try
                {
                    Response<IntentCollection> response = await RestClient
                        .ListIntentsAsync(maxPageSize, cancellationToken)
                        .ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value,
                        response.Value.NextLink,
                        response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }

            async Task<Page<IntentItem>> NextPageFunc(string nextLink, int? maxPageSize)
            {
                using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SkillsRegistryAdministrationClient)}.{nameof(GetIntents)}");
                scope.Start();
                try
                {
                    Response<IntentCollection> response = await RestClient
                        .ListIntentsNextPageAsync(nextLink, maxPageSize, cancellationToken)
                        .ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value,
                        response.Value.NextLink,
                        response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }

            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Retrieves existing intents. </summary>
        /// <param name="cancellationToken"> (Optional) The cancellation token to use. </param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        public virtual Pageable<IntentItem> GetIntents(CancellationToken cancellationToken = default)
        {
            Page<IntentItem> FirstPageFunc(int? maxPageSize)
            {
                using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SkillsRegistryAdministrationClient)}.{nameof(GetIntents)}");
                scope.Start();
                try
                {
                    Response<IntentCollection> response = RestClient
                        .ListIntents(maxPageSize, cancellationToken);
                    return Page.FromValues(response.Value.Value,
                        response.Value.NextLink,
                        response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }

            Page<IntentItem> NextPageFunc(string nextLink, int? maxPageSize)
            {
                using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SkillsRegistryAdministrationClient)}.{nameof(GetIntents)}");
                scope.Start();
                try
                {
                    Response<IntentCollection> response = RestClient
                        .ListIntentsNextPage(nextLink, maxPageSize, cancellationToken);
                    return Page.FromValues(response.Value.Value,
                        response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }

            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Retrieves an existing intent by Id. </summary>
        /// <param name="intentId"> The Id of the intent </param>
        /// <param name="cancellationToken"> (Optional) The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="intentId"/> is null. </exception>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        public virtual async Task<Response<RouterIntent>> GetIntentAsync(string intentId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrWhiteSpace(intentId, nameof(intentId));

            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SkillsRegistryAdministrationClient)}.{nameof(GetIntent)}");
            scope.Start();
            try
            {
                return await RestClient.GetIntentAsync(intentId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary> Retrieves an existing intent by Id. </summary>
        /// <param name="intentId"> The Id of the intent. </param>
        /// <param name="cancellationToken"> (Optional) The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="intentId"/> is null. </exception>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        public virtual Response<RouterIntent> GetIntent(string intentId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrWhiteSpace(intentId, nameof(intentId));

            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SkillsRegistryAdministrationClient)}.{nameof(GetIntent)}");
            scope.Start();
            try
            {
                return RestClient.GetIntent(intentId, cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary> Deletes a Intent by Id. </summary>
        /// <param name="intentId"> Id of the channel to delete. </param>
        /// <param name="cancellationToken"> (Optional) The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="intentId"/> is null. </exception>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        public virtual async Task<Response> DeleteIntentAsync(string intentId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrWhiteSpace(intentId, nameof(intentId));
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SkillsRegistryAdministrationClient)}.{nameof(DeleteIntent)}");
            scope.Start();
            try
            {
                return await RestClient.DeleteIntentAsync(intentId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary> Deletes a Intent by Id. </summary>
        /// <param name="intentId"> Id of the channel to delete. </param>
        /// <param name="cancellationToken"> (Optional) The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="intentId"/> is null. </exception>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        public virtual Response DeleteIntent(string intentId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrWhiteSpace(intentId, nameof(intentId));
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SkillsRegistryAdministrationClient)}.{nameof(DeleteIntent)}");
            scope.Start();
            try
            {
                return RestClient.DeleteIntent(intentId, cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        #endregion Intents
    }
}
