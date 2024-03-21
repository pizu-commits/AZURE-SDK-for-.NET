// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.HybridContainerService.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableHybridContainerServiceSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _hybridContainerServiceVirtualNetworkvirtualNetworksClientDiagnostics;
        private VirtualNetworksRestOperations _hybridContainerServiceVirtualNetworkvirtualNetworksRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableHybridContainerServiceSubscriptionResource"/> class for mocking. </summary>
        protected MockableHybridContainerServiceSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableHybridContainerServiceSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableHybridContainerServiceSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics HybridContainerServiceVirtualNetworkvirtualNetworksClientDiagnostics => _hybridContainerServiceVirtualNetworkvirtualNetworksClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.HybridContainerService", HybridContainerServiceVirtualNetworkResource.ResourceType.Namespace, Diagnostics);
        private VirtualNetworksRestOperations HybridContainerServiceVirtualNetworkvirtualNetworksRestClient => _hybridContainerServiceVirtualNetworkvirtualNetworksRestClient ??= new VirtualNetworksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(HybridContainerServiceVirtualNetworkResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Lists the virtual networks in the specified subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridContainerService/virtualNetworks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>virtualNetworks_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridContainerServiceVirtualNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HybridContainerServiceVirtualNetworkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HybridContainerServiceVirtualNetworkResource> GetHybridContainerServiceVirtualNetworksAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => HybridContainerServiceVirtualNetworkvirtualNetworksRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => HybridContainerServiceVirtualNetworkvirtualNetworksRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new HybridContainerServiceVirtualNetworkResource(Client, HybridContainerServiceVirtualNetworkData.DeserializeHybridContainerServiceVirtualNetworkData(e)), HybridContainerServiceVirtualNetworkvirtualNetworksClientDiagnostics, Pipeline, "MockableHybridContainerServiceSubscriptionResource.GetHybridContainerServiceVirtualNetworks", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the virtual networks in the specified subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridContainerService/virtualNetworks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>virtualNetworks_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridContainerServiceVirtualNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HybridContainerServiceVirtualNetworkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HybridContainerServiceVirtualNetworkResource> GetHybridContainerServiceVirtualNetworks(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => HybridContainerServiceVirtualNetworkvirtualNetworksRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => HybridContainerServiceVirtualNetworkvirtualNetworksRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new HybridContainerServiceVirtualNetworkResource(Client, HybridContainerServiceVirtualNetworkData.DeserializeHybridContainerServiceVirtualNetworkData(e)), HybridContainerServiceVirtualNetworkvirtualNetworksClientDiagnostics, Pipeline, "MockableHybridContainerServiceSubscriptionResource.GetHybridContainerServiceVirtualNetworks", "value", "nextLink", cancellationToken);
        }
    }
}
