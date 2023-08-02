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
using Azure.ResourceManager;
using Azure.ResourceManager.EdgeOrder;

namespace Azure.ResourceManager.EdgeOrder.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class EdgeOrderResourceGroupMockingExtension : ArmResource
    {
        private ClientDiagnostics _defaultClientDiagnostics;
        private EdgeOrderManagementRestOperations _defaultRestClient;

        /// <summary> Initializes a new instance of the <see cref="EdgeOrderResourceGroupMockingExtension"/> class for mocking. </summary>
        protected EdgeOrderResourceGroupMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="EdgeOrderResourceGroupMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal EdgeOrderResourceGroupMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics DefaultClientDiagnostics => _defaultClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.EdgeOrder", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private EdgeOrderManagementRestOperations DefaultRestClient => _defaultRestClient ??= new EdgeOrderManagementRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of EdgeOrderAddressResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of EdgeOrderAddressResources and their operations over a EdgeOrderAddressResource. </returns>
        public virtual EdgeOrderAddressCollection GetEdgeOrderAddresses()
        {
            return GetCachedClient(Client => new EdgeOrderAddressCollection(Client, Id));
        }

        /// <summary>
        /// Gets information about the specified address.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/addresses/{addressName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetAddressByName</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="addressName"> The name of the address Resource within the specified resource group. address names must be between 3 and 24 characters in length and use any alphanumeric and underscore only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="addressName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="addressName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<EdgeOrderAddressResource>> GetEdgeOrderAddressAsync(string addressName, CancellationToken cancellationToken = default)
        {
            return await GetEdgeOrderAddresses().GetAsync(addressName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets information about the specified address.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/addresses/{addressName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetAddressByName</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="addressName"> The name of the address Resource within the specified resource group. address names must be between 3 and 24 characters in length and use any alphanumeric and underscore only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="addressName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="addressName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<EdgeOrderAddressResource> GetEdgeOrderAddress(string addressName, CancellationToken cancellationToken = default)
        {
            return GetEdgeOrderAddresses().Get(addressName, cancellationToken);
        }

        /// <summary> Gets a collection of EdgeOrderResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of EdgeOrderResources and their operations over a EdgeOrderResource. </returns>
        public virtual EdgeOrderCollection GetEdgeOrders()
        {
            return GetCachedClient(Client => new EdgeOrderCollection(Client, Id));
        }

        /// <summary>
        /// Gets an order.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/locations/{location}/orders/{orderName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetOrderByName</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="orderName"> The name of the order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="orderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="orderName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<EdgeOrderResource>> GetEdgeOrderAsync(AzureLocation location, string orderName, CancellationToken cancellationToken = default)
        {
            return await GetEdgeOrders().GetAsync(location, orderName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets an order.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/locations/{location}/orders/{orderName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetOrderByName</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="orderName"> The name of the order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="orderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="orderName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<EdgeOrderResource> GetEdgeOrder(AzureLocation location, string orderName, CancellationToken cancellationToken = default)
        {
            return GetEdgeOrders().Get(location, orderName, cancellationToken);
        }

        /// <summary> Gets a collection of EdgeOrderItemResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of EdgeOrderItemResources and their operations over a EdgeOrderItemResource. </returns>
        public virtual EdgeOrderItemCollection GetEdgeOrderItems()
        {
            return GetCachedClient(Client => new EdgeOrderItemCollection(Client, Id));
        }

        /// <summary>
        /// Gets an order item.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/orderItems/{orderItemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetOrderItemByName</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="orderItemName"> The name of the order item. </param>
        /// <param name="expand"> $expand is supported on device details, forward shipping details and reverse shipping details parameters. Each of these can be provided as a comma separated list. Device Details for order item provides details on the devices of the product, Forward and Reverse Shipping details provide forward and reverse shipping details respectively. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="orderItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="orderItemName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<EdgeOrderItemResource>> GetEdgeOrderItemAsync(string orderItemName, string expand = null, CancellationToken cancellationToken = default)
        {
            return await GetEdgeOrderItems().GetAsync(orderItemName, expand, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets an order item.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/orderItems/{orderItemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetOrderItemByName</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="orderItemName"> The name of the order item. </param>
        /// <param name="expand"> $expand is supported on device details, forward shipping details and reverse shipping details parameters. Each of these can be provided as a comma separated list. Device Details for order item provides details on the devices of the product, Forward and Reverse Shipping details provide forward and reverse shipping details respectively. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="orderItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="orderItemName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<EdgeOrderItemResource> GetEdgeOrderItem(string orderItemName, string expand = null, CancellationToken cancellationToken = default)
        {
            return GetEdgeOrderItems().Get(orderItemName, expand, cancellationToken);
        }

        /// <summary>
        /// Lists order at resource group level.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/orders</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ListOrderAtResourceGroupLevel</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> $skipToken is supported on Get list of order, which provides the next page in the list of order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EdgeOrderResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EdgeOrderResource> GetEdgeOrdersAsync(string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DefaultRestClient.CreateListOrderAtResourceGroupLevelRequest(Id.SubscriptionId, Id.ResourceGroupName, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DefaultRestClient.CreateListOrderAtResourceGroupLevelNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, skipToken);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new EdgeOrderResource(Client, EdgeOrderData.DeserializeEdgeOrderData(e)), DefaultClientDiagnostics, Pipeline, "EdgeOrderResourceGroupMockingExtension.GetEdgeOrders", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists order at resource group level.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/orders</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ListOrderAtResourceGroupLevel</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> $skipToken is supported on Get list of order, which provides the next page in the list of order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EdgeOrderResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EdgeOrderResource> GetEdgeOrders(string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DefaultRestClient.CreateListOrderAtResourceGroupLevelRequest(Id.SubscriptionId, Id.ResourceGroupName, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DefaultRestClient.CreateListOrderAtResourceGroupLevelNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, skipToken);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new EdgeOrderResource(Client, EdgeOrderData.DeserializeEdgeOrderData(e)), DefaultClientDiagnostics, Pipeline, "EdgeOrderResourceGroupMockingExtension.GetEdgeOrders", "value", "nextLink", cancellationToken);
        }
    }
}
