// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.CustomerInsights
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _hubClientDiagnostics;
        private HubsRestOperations _hubRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics HubClientDiagnostics => _hubClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.CustomerInsights", HubResource.ResourceType.Namespace, Diagnostics);
        private HubsRestOperations HubRestClient => _hubRestClient ??= new HubsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(HubResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets all hubs in the specified subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.CustomerInsights/hubs
        /// Operation Id: Hubs_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HubResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HubResource> GetHubsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<HubResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = HubClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetHubs");
                scope.Start();
                try
                {
                    var response = await HubRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new HubResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<HubResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = HubClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetHubs");
                scope.Start();
                try
                {
                    var response = await HubRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new HubResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets all hubs in the specified subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.CustomerInsights/hubs
        /// Operation Id: Hubs_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HubResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HubResource> GetHubs(CancellationToken cancellationToken = default)
        {
            Page<HubResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = HubClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetHubs");
                scope.Start();
                try
                {
                    var response = HubRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new HubResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<HubResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = HubClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetHubs");
                scope.Start();
                try
                {
                    var response = HubRestClient.ListNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new HubResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
