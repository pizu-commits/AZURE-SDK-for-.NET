// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Analytics.Synapse.Artifacts.Models;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Synapse.Artifacts
{
    /// <summary> The BigDataPools service client. </summary>
    public partial class BigDataPoolsClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal BigDataPoolsRestClient RestClient { get; }

        /// <summary> Initializes a new instance of BigDataPoolsClient for mocking. </summary>
        protected BigDataPoolsClient()
        {
        }

        /// <summary> Initializes a new instance of BigDataPoolsClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal BigDataPoolsClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint, string apiVersion = "2019-06-01-preview")
        {
            RestClient = new BigDataPoolsRestClient(clientDiagnostics, pipeline, endpoint, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> List Big Data Pools. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<BigDataPoolResourceInfoListResult>> ListAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BigDataPoolsClient.List");
            scope.Start();
            try
            {
                return await RestClient.ListAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List Big Data Pools. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<BigDataPoolResourceInfoListResult> List(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BigDataPoolsClient.List");
            scope.Start();
            try
            {
                return RestClient.List(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get Big Data Pool. </summary>
        /// <param name="bigDataPoolName"> The Big Data Pool name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<BigDataPoolResourceInfo>> GetAsync(string bigDataPoolName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BigDataPoolsClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(bigDataPoolName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get Big Data Pool. </summary>
        /// <param name="bigDataPoolName"> The Big Data Pool name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<BigDataPoolResourceInfo> Get(string bigDataPoolName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BigDataPoolsClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(bigDataPoolName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
