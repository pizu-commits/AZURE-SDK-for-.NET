// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.EventHubs.Models;

namespace Azure.ResourceManager.EventHubs
{
    /// <summary> The Regions service client. </summary>
    public partial class RegionsOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal RegionsRestOperations RestClient { get; }
        /// <summary> Initializes a new instance of RegionsOperations for mocking. </summary>
        protected RegionsOperations()
        {
        }
        /// <summary> Initializes a new instance of RegionsOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> Subscription credentials that uniquely identify a Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal RegionsOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new RegionsRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets the available Regions for a given sku. </summary>
        /// <param name="sku"> The sku type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<MessagingRegions> ListBySkuAsync(string sku, CancellationToken cancellationToken = default)
        {
            if (sku == null)
            {
                throw new ArgumentNullException(nameof(sku));
            }

            async Task<Page<MessagingRegions>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RegionsOperations.ListBySku");
                scope.Start();
                try
                {
                    var response = await RestClient.ListBySkuAsync(sku, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<MessagingRegions>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RegionsOperations.ListBySku");
                scope.Start();
                try
                {
                    var response = await RestClient.ListBySkuNextPageAsync(nextLink, sku, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets the available Regions for a given sku. </summary>
        /// <param name="sku"> The sku type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<MessagingRegions> ListBySku(string sku, CancellationToken cancellationToken = default)
        {
            if (sku == null)
            {
                throw new ArgumentNullException(nameof(sku));
            }

            Page<MessagingRegions> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RegionsOperations.ListBySku");
                scope.Start();
                try
                {
                    var response = RestClient.ListBySku(sku, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<MessagingRegions> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RegionsOperations.ListBySku");
                scope.Start();
                try
                {
                    var response = RestClient.ListBySkuNextPage(nextLink, sku, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
