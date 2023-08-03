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
using Azure.ResourceManager.Relay.Mocking;
using Azure.ResourceManager.Relay.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Relay
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.Relay. </summary>
    public static partial class RelayExtensions
    {
        private static RelayArmClientMockingExtension GetRelayArmClientMockingExtension(ArmClient client)
        {
            return client.GetCachedClient(client =>
            {
                return new RelayArmClientMockingExtension(client);
            });
        }

        private static RelayResourceGroupMockingExtension GetRelayResourceGroupMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new RelayResourceGroupMockingExtension(client, resource.Id);
            });
        }

        private static RelaySubscriptionMockingExtension GetRelaySubscriptionMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new RelaySubscriptionMockingExtension(client, resource.Id);
            });
        }

        #region RelayNamespaceAuthorizationRuleResource
        /// <summary>
        /// Gets an object representing a <see cref="RelayNamespaceAuthorizationRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RelayNamespaceAuthorizationRuleResource.CreateResourceIdentifier" /> to create a <see cref="RelayNamespaceAuthorizationRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RelayNamespaceAuthorizationRuleResource" /> object. </returns>
        public static RelayNamespaceAuthorizationRuleResource GetRelayNamespaceAuthorizationRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetRelayArmClientMockingExtension(client).GetRelayNamespaceAuthorizationRuleResource(id);
        }
        #endregion

        #region RelayHybridConnectionAuthorizationRuleResource
        /// <summary>
        /// Gets an object representing a <see cref="RelayHybridConnectionAuthorizationRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RelayHybridConnectionAuthorizationRuleResource.CreateResourceIdentifier" /> to create a <see cref="RelayHybridConnectionAuthorizationRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RelayHybridConnectionAuthorizationRuleResource" /> object. </returns>
        public static RelayHybridConnectionAuthorizationRuleResource GetRelayHybridConnectionAuthorizationRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetRelayArmClientMockingExtension(client).GetRelayHybridConnectionAuthorizationRuleResource(id);
        }
        #endregion

        #region WcfRelayAuthorizationRuleResource
        /// <summary>
        /// Gets an object representing a <see cref="WcfRelayAuthorizationRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="WcfRelayAuthorizationRuleResource.CreateResourceIdentifier" /> to create a <see cref="WcfRelayAuthorizationRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="WcfRelayAuthorizationRuleResource" /> object. </returns>
        public static WcfRelayAuthorizationRuleResource GetWcfRelayAuthorizationRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetRelayArmClientMockingExtension(client).GetWcfRelayAuthorizationRuleResource(id);
        }
        #endregion

        #region RelayNamespaceResource
        /// <summary>
        /// Gets an object representing a <see cref="RelayNamespaceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RelayNamespaceResource.CreateResourceIdentifier" /> to create a <see cref="RelayNamespaceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RelayNamespaceResource" /> object. </returns>
        public static RelayNamespaceResource GetRelayNamespaceResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetRelayArmClientMockingExtension(client).GetRelayNamespaceResource(id);
        }
        #endregion

        #region RelayNetworkRuleSetResource
        /// <summary>
        /// Gets an object representing a <see cref="RelayNetworkRuleSetResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RelayNetworkRuleSetResource.CreateResourceIdentifier" /> to create a <see cref="RelayNetworkRuleSetResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RelayNetworkRuleSetResource" /> object. </returns>
        public static RelayNetworkRuleSetResource GetRelayNetworkRuleSetResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetRelayArmClientMockingExtension(client).GetRelayNetworkRuleSetResource(id);
        }
        #endregion

        #region RelayHybridConnectionResource
        /// <summary>
        /// Gets an object representing a <see cref="RelayHybridConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RelayHybridConnectionResource.CreateResourceIdentifier" /> to create a <see cref="RelayHybridConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RelayHybridConnectionResource" /> object. </returns>
        public static RelayHybridConnectionResource GetRelayHybridConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetRelayArmClientMockingExtension(client).GetRelayHybridConnectionResource(id);
        }
        #endregion

        #region WcfRelayResource
        /// <summary>
        /// Gets an object representing a <see cref="WcfRelayResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="WcfRelayResource.CreateResourceIdentifier" /> to create a <see cref="WcfRelayResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="WcfRelayResource" /> object. </returns>
        public static WcfRelayResource GetWcfRelayResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetRelayArmClientMockingExtension(client).GetWcfRelayResource(id);
        }
        #endregion

        #region RelayPrivateEndpointConnectionResource
        /// <summary>
        /// Gets an object representing a <see cref="RelayPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RelayPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="RelayPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RelayPrivateEndpointConnectionResource" /> object. </returns>
        public static RelayPrivateEndpointConnectionResource GetRelayPrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetRelayArmClientMockingExtension(client).GetRelayPrivateEndpointConnectionResource(id);
        }
        #endregion

        #region RelayPrivateLinkResource
        /// <summary>
        /// Gets an object representing a <see cref="RelayPrivateLinkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RelayPrivateLinkResource.CreateResourceIdentifier" /> to create a <see cref="RelayPrivateLinkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RelayPrivateLinkResource" /> object. </returns>
        public static RelayPrivateLinkResource GetRelayPrivateLinkResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetRelayArmClientMockingExtension(client).GetRelayPrivateLinkResource(id);
        }
        #endregion

        /// <summary> Gets a collection of RelayNamespaceResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of RelayNamespaceResources and their operations over a RelayNamespaceResource. </returns>
        public static RelayNamespaceCollection GetRelayNamespaces(this ResourceGroupResource resourceGroupResource)
        {
            return GetRelayResourceGroupMockingExtension(resourceGroupResource).GetRelayNamespaces();
        }

        /// <summary>
        /// Returns the description for the specified namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<RelayNamespaceResource>> GetRelayNamespaceAsync(this ResourceGroupResource resourceGroupResource, string namespaceName, CancellationToken cancellationToken = default)
        {
            return await GetRelayResourceGroupMockingExtension(resourceGroupResource).GetRelayNamespaceAsync(namespaceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns the description for the specified namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<RelayNamespaceResource> GetRelayNamespace(this ResourceGroupResource resourceGroupResource, string namespaceName, CancellationToken cancellationToken = default)
        {
            return GetRelayResourceGroupMockingExtension(resourceGroupResource).GetRelayNamespace(namespaceName, cancellationToken);
        }

        /// <summary>
        /// Check the specified namespace name availability.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Relay/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Parameters to check availability of the specified namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<RelayNameAvailabilityResult>> CheckRelayNamespaceNameAvailabilityAsync(this SubscriptionResource subscriptionResource, RelayNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            return await GetRelaySubscriptionMockingExtension(subscriptionResource).CheckRelayNamespaceNameAvailabilityAsync(content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Check the specified namespace name availability.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Relay/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Parameters to check availability of the specified namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<RelayNameAvailabilityResult> CheckRelayNamespaceNameAvailability(this SubscriptionResource subscriptionResource, RelayNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            return GetRelaySubscriptionMockingExtension(subscriptionResource).CheckRelayNamespaceNameAvailability(content, cancellationToken);
        }

        /// <summary>
        /// Lists all the available namespaces within the subscription regardless of the resourceGroups.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Relay/namespaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RelayNamespaceResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<RelayNamespaceResource> GetRelayNamespacesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetRelaySubscriptionMockingExtension(subscriptionResource).GetRelayNamespacesAsync(cancellationToken);
        }

        /// <summary>
        /// Lists all the available namespaces within the subscription regardless of the resourceGroups.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Relay/namespaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RelayNamespaceResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<RelayNamespaceResource> GetRelayNamespaces(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetRelaySubscriptionMockingExtension(subscriptionResource).GetRelayNamespaces(cancellationToken);
        }
    }
}
