// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Analytics.Synapse.Artifacts.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Synapse.Artifacts
{
    /// <summary> The RunNotebook service client. </summary>
    public partial class RunNotebookClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal RunNotebookRestClient RestClient { get; }

        /// <summary> Initializes a new instance of RunNotebookClient for mocking. </summary>
        protected RunNotebookClient()
        {
        }

        /// <summary> Initializes a new instance of RunNotebookClient. </summary>
        /// <param name="endpoint"> The workspace development endpoint, for example `https://myworkspace.dev.azuresynapse.net`. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public RunNotebookClient(Uri endpoint, TokenCredential credential, ArtifactsClientOptions options = null)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }

            options ??= new ArtifactsClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            string[] scopes = { "https://dev.azuresynapse.net/.default" };
            _pipeline = HttpPipelineBuilder.Build(options, new BearerTokenAuthenticationPolicy(credential, scopes));
            RestClient = new RunNotebookRestClient(_clientDiagnostics, _pipeline, endpoint);
        }

        /// <summary> Initializes a new instance of RunNotebookClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The workspace development endpoint, for example `https://myworkspace.dev.azuresynapse.net`. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/> or <paramref name="endpoint"/> is null. </exception>
        internal RunNotebookClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint)
        {
            RestClient = new RunNotebookRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Get RunNotebook Status for run id. </summary>
        /// <param name="runId"> Notebook run id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<RunNotebookResponse>> GetStatusAsync(string runId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RunNotebookClient.GetStatus");
            scope.Start();
            try
            {
                return await RestClient.GetStatusAsync(runId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get RunNotebook Status for run id. </summary>
        /// <param name="runId"> Notebook run id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RunNotebookResponse> GetStatus(string runId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RunNotebookClient.GetStatus");
            scope.Start();
            try
            {
                return RestClient.GetStatus(runId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Cancel notebook run. </summary>
        /// <param name="runId"> Notebook run id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<RunNotebookResponse>> CancelRunAsync(string runId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RunNotebookClient.CancelRun");
            scope.Start();
            try
            {
                return await RestClient.CancelRunAsync(runId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Cancel notebook run. </summary>
        /// <param name="runId"> Notebook run id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RunNotebookResponse> CancelRun(string runId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RunNotebookClient.CancelRun");
            scope.Start();
            try
            {
                return RestClient.CancelRun(runId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get RunNotebook Snapshot for run id. </summary>
        /// <param name="runId"> Notebook run id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<RunNotebookSnapshotResponse>> GetSnapshotAsync(string runId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RunNotebookClient.GetSnapshot");
            scope.Start();
            try
            {
                return await RestClient.GetSnapshotAsync(runId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get RunNotebook Snapshot for run id. </summary>
        /// <param name="runId"> Notebook run id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RunNotebookSnapshotResponse> GetSnapshot(string runId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RunNotebookClient.GetSnapshot");
            scope.Start();
            try
            {
                return RestClient.GetSnapshot(runId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Run notebook. </summary>
        /// <param name="runId"> Notebook run id. </param>
        /// <param name="runNotebookRequest"> Run notebook request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="runId"/> or <paramref name="runNotebookRequest"/> is null. </exception>
        public virtual async Task<RunNotebookCreateRunOperation> StartCreateRunAsync(string runId, RunNotebookRequest runNotebookRequest, CancellationToken cancellationToken = default)
        {
            if (runId == null)
            {
                throw new ArgumentNullException(nameof(runId));
            }
            if (runNotebookRequest == null)
            {
                throw new ArgumentNullException(nameof(runNotebookRequest));
            }

            using var scope = _clientDiagnostics.CreateScope("RunNotebookClient.StartCreateRun");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateRunAsync(runId, runNotebookRequest, cancellationToken).ConfigureAwait(false);
                return new RunNotebookCreateRunOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateRunRequest(runId, runNotebookRequest).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Run notebook. </summary>
        /// <param name="runId"> Notebook run id. </param>
        /// <param name="runNotebookRequest"> Run notebook request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="runId"/> or <paramref name="runNotebookRequest"/> is null. </exception>
        public virtual RunNotebookCreateRunOperation StartCreateRun(string runId, RunNotebookRequest runNotebookRequest, CancellationToken cancellationToken = default)
        {
            if (runId == null)
            {
                throw new ArgumentNullException(nameof(runId));
            }
            if (runNotebookRequest == null)
            {
                throw new ArgumentNullException(nameof(runNotebookRequest));
            }

            using var scope = _clientDiagnostics.CreateScope("RunNotebookClient.StartCreateRun");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateRun(runId, runNotebookRequest, cancellationToken);
                return new RunNotebookCreateRunOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateRunRequest(runId, runNotebookRequest).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
