// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.EdgeOrder.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.EdgeOrder
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.EdgeOrder. </summary>
    public static partial class EdgeOrderExtensions
    {
        private static SubscriptionExtensionClient GetExtensionClient(Subscription subscription)
        {
            return subscription.GetCachedClient((client) =>
            {
                return new SubscriptionExtensionClient(client, subscription.Id);
            }
            );
        }

        /// <summary>
        /// Lists all the addresses available under the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/addresses
        /// Operation Id: ListAddressesAtSubscriptionLevel
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="filter"> $filter is supported to filter based on shipping address properties. Filter supports only equals operation. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of addresses, which provides the next page in the list of addresses. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AddressResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<AddressResource> GetAddressResourcesAsync(this Subscription subscription, string filter = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetAddressResourcesAsync(filter, skipToken, cancellationToken);
        }

        /// <summary>
        /// Lists all the addresses available under the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/addresses
        /// Operation Id: ListAddressesAtSubscriptionLevel
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="filter"> $filter is supported to filter based on shipping address properties. Filter supports only equals operation. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of addresses, which provides the next page in the list of addresses. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AddressResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<AddressResource> GetAddressResources(this Subscription subscription, string filter = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetAddressResources(filter, skipToken, cancellationToken);
        }

        /// <summary>
        /// This method provides the list of product families for the given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/listProductFamilies
        /// Operation Id: ListProductFamilies
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="productFamiliesRequest"> Filters for showing the product families. </param>
        /// <param name="expand"> $expand is supported on configurations parameter for product, which provides details on the configurations for the product. </param>
        /// <param name="skipToken"> $skipToken is supported on list of product families, which provides the next page in the list of product families. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="productFamiliesRequest"/> is null. </exception>
        /// <returns> An async collection of <see cref="ProductFamily" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ProductFamily> GetProductFamiliesAsync(this Subscription subscription, ProductFamiliesRequest productFamiliesRequest, string expand = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(productFamiliesRequest, nameof(productFamiliesRequest));

            return GetExtensionClient(subscription).GetProductFamiliesAsync(productFamiliesRequest, expand, skipToken, cancellationToken);
        }

        /// <summary>
        /// This method provides the list of product families for the given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/listProductFamilies
        /// Operation Id: ListProductFamilies
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="productFamiliesRequest"> Filters for showing the product families. </param>
        /// <param name="expand"> $expand is supported on configurations parameter for product, which provides details on the configurations for the product. </param>
        /// <param name="skipToken"> $skipToken is supported on list of product families, which provides the next page in the list of product families. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="productFamiliesRequest"/> is null. </exception>
        /// <returns> A collection of <see cref="ProductFamily" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ProductFamily> GetProductFamilies(this Subscription subscription, ProductFamiliesRequest productFamiliesRequest, string expand = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(productFamiliesRequest, nameof(productFamiliesRequest));

            return GetExtensionClient(subscription).GetProductFamilies(productFamiliesRequest, expand, skipToken, cancellationToken);
        }

        /// <summary>
        /// This method provides the list of configurations for the given product family, product line and product under subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/listConfigurations
        /// Operation Id: ListConfigurations
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="configurationsRequest"> Filters for showing the configurations. </param>
        /// <param name="skipToken"> $skipToken is supported on list of configurations, which provides the next page in the list of configurations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationsRequest"/> is null. </exception>
        /// <returns> An async collection of <see cref="ProductConfiguration" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ProductConfiguration> GetConfigurationsAsync(this Subscription subscription, ConfigurationsRequest configurationsRequest, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(configurationsRequest, nameof(configurationsRequest));

            return GetExtensionClient(subscription).GetConfigurationsAsync(configurationsRequest, skipToken, cancellationToken);
        }

        /// <summary>
        /// This method provides the list of configurations for the given product family, product line and product under subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/listConfigurations
        /// Operation Id: ListConfigurations
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="configurationsRequest"> Filters for showing the configurations. </param>
        /// <param name="skipToken"> $skipToken is supported on list of configurations, which provides the next page in the list of configurations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationsRequest"/> is null. </exception>
        /// <returns> A collection of <see cref="ProductConfiguration" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ProductConfiguration> GetConfigurations(this Subscription subscription, ConfigurationsRequest configurationsRequest, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(configurationsRequest, nameof(configurationsRequest));

            return GetExtensionClient(subscription).GetConfigurations(configurationsRequest, skipToken, cancellationToken);
        }

        /// <summary>
        /// This method provides the list of product families metadata for the given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/productFamiliesMetadata
        /// Operation Id: ListProductFamiliesMetadata
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="skipToken"> $skipToken is supported on list of product families metadata, which provides the next page in the list of product families metadata. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ProductFamiliesMetadataDetails" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ProductFamiliesMetadataDetails> GetProductFamiliesMetadataAsync(this Subscription subscription, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetProductFamiliesMetadataAsync(skipToken, cancellationToken);
        }

        /// <summary>
        /// This method provides the list of product families metadata for the given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/productFamiliesMetadata
        /// Operation Id: ListProductFamiliesMetadata
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="skipToken"> $skipToken is supported on list of product families metadata, which provides the next page in the list of product families metadata. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ProductFamiliesMetadataDetails" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ProductFamiliesMetadataDetails> GetProductFamiliesMetadata(this Subscription subscription, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetProductFamiliesMetadata(skipToken, cancellationToken);
        }

        /// <summary>
        /// Lists order at subscription level.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/orders
        /// Operation Id: ListOrderAtSubscriptionLevel
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of order, which provides the next page in the list of order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OrderResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<OrderResource> GetOrderResourcesAsync(this Subscription subscription, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetOrderResourcesAsync(skipToken, cancellationToken);
        }

        /// <summary>
        /// Lists order at subscription level.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/orders
        /// Operation Id: ListOrderAtSubscriptionLevel
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of order, which provides the next page in the list of order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OrderResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<OrderResource> GetOrderResources(this Subscription subscription, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetOrderResources(skipToken, cancellationToken);
        }

        /// <summary>
        /// Lists order item at subscription level.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/orderItems
        /// Operation Id: ListOrderItemsAtSubscriptionLevel
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="filter"> $filter is supported to filter based on order id. Filter supports only equals operation. </param>
        /// <param name="expand"> $expand is supported on device details, forward shipping details and reverse shipping details parameters. Each of these can be provided as a comma separated list. Device Details for order item provides details on the devices of the product, Forward and Reverse Shipping details provide forward and reverse shipping details respectively. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of order items, which provides the next page in the list of order items. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OrderItemResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<OrderItemResource> GetOrderItemResourcesAsync(this Subscription subscription, string filter = null, string expand = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetOrderItemResourcesAsync(filter, expand, skipToken, cancellationToken);
        }

        /// <summary>
        /// Lists order item at subscription level.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/orderItems
        /// Operation Id: ListOrderItemsAtSubscriptionLevel
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="filter"> $filter is supported to filter based on order id. Filter supports only equals operation. </param>
        /// <param name="expand"> $expand is supported on device details, forward shipping details and reverse shipping details parameters. Each of these can be provided as a comma separated list. Device Details for order item provides details on the devices of the product, Forward and Reverse Shipping details provide forward and reverse shipping details respectively. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of order items, which provides the next page in the list of order items. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OrderItemResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<OrderItemResource> GetOrderItemResources(this Subscription subscription, string filter = null, string expand = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetOrderItemResources(filter, expand, skipToken, cancellationToken);
        }

        private static ResourceGroupExtensionClient GetExtensionClient(ResourceGroup resourceGroup)
        {
            return resourceGroup.GetCachedClient((client) =>
            {
                return new ResourceGroupExtensionClient(client, resourceGroup.Id);
            }
            );
        }

        /// <summary> Gets a collection of AddressResources in the AddressResource. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of AddressResources and their operations over a AddressResource. </returns>
        public static AddressResourceCollection GetAddressResources(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetAddressResources();
        }

        /// <summary>
        /// Gets information about the specified address.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/addresses/{addressName}
        /// Operation Id: GetAddressByName
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="addressName"> The name of the address Resource within the specified resource group. address names must be between 3 and 24 characters in length and use any alphanumeric and underscore only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="addressName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="addressName"/> is null. </exception>
        public static async Task<Response<AddressResource>> GetAddressResourceAsync(this ResourceGroup resourceGroup, string addressName, CancellationToken cancellationToken = default)
        {
            return await resourceGroup.GetAddressResources().GetAsync(addressName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets information about the specified address.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/addresses/{addressName}
        /// Operation Id: GetAddressByName
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="addressName"> The name of the address Resource within the specified resource group. address names must be between 3 and 24 characters in length and use any alphanumeric and underscore only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="addressName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="addressName"/> is null. </exception>
        public static Response<AddressResource> GetAddressResource(this ResourceGroup resourceGroup, string addressName, CancellationToken cancellationToken = default)
        {
            return resourceGroup.GetAddressResources().Get(addressName, cancellationToken);
        }

        /// <summary> Gets a collection of OrderResources in the OrderResource. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of OrderResources and their operations over a OrderResource. </returns>
        public static OrderResourceCollection GetOrderResources(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetOrderResources();
        }

        /// <summary>
        /// Gets an order.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/locations/{location}/orders/{orderName}
        /// Operation Id: GetOrderByName
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="orderName"> The name of the order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> or <paramref name="orderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="orderName"/> is null. </exception>
        public static async Task<Response<OrderResource>> GetOrderResourceAsync(this ResourceGroup resourceGroup, string location, string orderName, CancellationToken cancellationToken = default)
        {
            return await resourceGroup.GetOrderResources().GetAsync(location, orderName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets an order.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/locations/{location}/orders/{orderName}
        /// Operation Id: GetOrderByName
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="orderName"> The name of the order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> or <paramref name="orderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="orderName"/> is null. </exception>
        public static Response<OrderResource> GetOrderResource(this ResourceGroup resourceGroup, string location, string orderName, CancellationToken cancellationToken = default)
        {
            return resourceGroup.GetOrderResources().Get(location, orderName, cancellationToken);
        }

        /// <summary> Gets a collection of OrderItemResources in the OrderItemResource. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of OrderItemResources and their operations over a OrderItemResource. </returns>
        public static OrderItemResourceCollection GetOrderItemResources(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetOrderItemResources();
        }

        /// <summary>
        /// Gets an order item.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/orderItems/{orderItemName}
        /// Operation Id: GetOrderItemByName
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="orderItemName"> The name of the order item. </param>
        /// <param name="expand"> $expand is supported on device details, forward shipping details and reverse shipping details parameters. Each of these can be provided as a comma separated list. Device Details for order item provides details on the devices of the product, Forward and Reverse Shipping details provide forward and reverse shipping details respectively. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="orderItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="orderItemName"/> is null. </exception>
        public static async Task<Response<OrderItemResource>> GetOrderItemResourceAsync(this ResourceGroup resourceGroup, string orderItemName, string expand = null, CancellationToken cancellationToken = default)
        {
            return await resourceGroup.GetOrderItemResources().GetAsync(orderItemName, expand, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets an order item.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/orderItems/{orderItemName}
        /// Operation Id: GetOrderItemByName
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="orderItemName"> The name of the order item. </param>
        /// <param name="expand"> $expand is supported on device details, forward shipping details and reverse shipping details parameters. Each of these can be provided as a comma separated list. Device Details for order item provides details on the devices of the product, Forward and Reverse Shipping details provide forward and reverse shipping details respectively. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="orderItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="orderItemName"/> is null. </exception>
        public static Response<OrderItemResource> GetOrderItemResource(this ResourceGroup resourceGroup, string orderItemName, string expand = null, CancellationToken cancellationToken = default)
        {
            return resourceGroup.GetOrderItemResources().Get(orderItemName, expand, cancellationToken);
        }

        /// <summary>
        /// Lists order at resource group level.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/orders
        /// Operation Id: ListOrderAtResourceGroupLevel
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of order, which provides the next page in the list of order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OrderResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<OrderResource> GetOrderResourcesAsync(this ResourceGroup resourceGroup, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(resourceGroup).GetOrderResourcesAsync(skipToken, cancellationToken);
        }

        /// <summary>
        /// Lists order at resource group level.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/orders
        /// Operation Id: ListOrderAtResourceGroupLevel
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of order, which provides the next page in the list of order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OrderResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<OrderResource> GetOrderResources(this ResourceGroup resourceGroup, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(resourceGroup).GetOrderResources(skipToken, cancellationToken);
        }

        #region AddressResource
        /// <summary> Gets an object representing a AddressResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AddressResource" /> object. </returns>
        public static AddressResource GetAddressResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                AddressResource.ValidateResourceId(id);
                return new AddressResource(client, id);
            }
            );
        }
        #endregion

        #region OrderResource
        /// <summary> Gets an object representing a OrderResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="OrderResource" /> object. </returns>
        public static OrderResource GetOrderResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                OrderResource.ValidateResourceId(id);
                return new OrderResource(client, id);
            }
            );
        }
        #endregion

        #region OrderItemResource
        /// <summary> Gets an object representing a OrderItemResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="OrderItemResource" /> object. </returns>
        public static OrderItemResource GetOrderItemResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                OrderItemResource.ValidateResourceId(id);
                return new OrderItemResource(client, id);
            }
            );
        }
        #endregion
    }
}
