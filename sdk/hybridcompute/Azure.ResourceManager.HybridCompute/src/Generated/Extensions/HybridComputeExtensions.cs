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
using Azure.ResourceManager.HybridCompute.Mocking;
using Azure.ResourceManager.HybridCompute.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.HybridCompute
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.HybridCompute. </summary>
    public static partial class HybridComputeExtensions
    {
        private static HybridComputeArmClientMockingExtension GetHybridComputeArmClientMockingExtension(ArmClient client)
        {
            return client.GetCachedClient(client =>
            {
                return new HybridComputeArmClientMockingExtension(client);
            });
        }

        private static HybridComputeResourceGroupMockingExtension GetHybridComputeResourceGroupMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new HybridComputeResourceGroupMockingExtension(client, resource.Id);
            });
        }

        private static HybridComputeSubscriptionMockingExtension GetHybridComputeSubscriptionMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new HybridComputeSubscriptionMockingExtension(client, resource.Id);
            });
        }

        #region HybridComputeMachineResource
        /// <summary>
        /// Gets an object representing a <see cref="HybridComputeMachineResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HybridComputeMachineResource.CreateResourceIdentifier" /> to create a <see cref="HybridComputeMachineResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HybridComputeMachineResource" /> object. </returns>
        public static HybridComputeMachineResource GetHybridComputeMachineResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetHybridComputeArmClientMockingExtension(client).GetHybridComputeMachineResource(id);
        }
        #endregion

        #region HybridComputeMachineExtensionResource
        /// <summary>
        /// Gets an object representing a <see cref="HybridComputeMachineExtensionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HybridComputeMachineExtensionResource.CreateResourceIdentifier" /> to create a <see cref="HybridComputeMachineExtensionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HybridComputeMachineExtensionResource" /> object. </returns>
        public static HybridComputeMachineExtensionResource GetHybridComputeMachineExtensionResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetHybridComputeArmClientMockingExtension(client).GetHybridComputeMachineExtensionResource(id);
        }
        #endregion

        #region HybridComputePrivateLinkScopeResource
        /// <summary>
        /// Gets an object representing a <see cref="HybridComputePrivateLinkScopeResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HybridComputePrivateLinkScopeResource.CreateResourceIdentifier" /> to create a <see cref="HybridComputePrivateLinkScopeResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HybridComputePrivateLinkScopeResource" /> object. </returns>
        public static HybridComputePrivateLinkScopeResource GetHybridComputePrivateLinkScopeResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetHybridComputeArmClientMockingExtension(client).GetHybridComputePrivateLinkScopeResource(id);
        }
        #endregion

        #region HybridComputePrivateLinkResource
        /// <summary>
        /// Gets an object representing a <see cref="HybridComputePrivateLinkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HybridComputePrivateLinkResource.CreateResourceIdentifier" /> to create a <see cref="HybridComputePrivateLinkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HybridComputePrivateLinkResource" /> object. </returns>
        public static HybridComputePrivateLinkResource GetHybridComputePrivateLinkResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetHybridComputeArmClientMockingExtension(client).GetHybridComputePrivateLinkResource(id);
        }
        #endregion

        #region HybridComputePrivateEndpointConnectionResource
        /// <summary>
        /// Gets an object representing a <see cref="HybridComputePrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HybridComputePrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="HybridComputePrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HybridComputePrivateEndpointConnectionResource" /> object. </returns>
        public static HybridComputePrivateEndpointConnectionResource GetHybridComputePrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetHybridComputeArmClientMockingExtension(client).GetHybridComputePrivateEndpointConnectionResource(id);
        }
        #endregion

        /// <summary> Gets a collection of HybridComputeMachineResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of HybridComputeMachineResources and their operations over a HybridComputeMachineResource. </returns>
        public static HybridComputeMachineCollection GetHybridComputeMachines(this ResourceGroupResource resourceGroupResource)
        {
            return GetHybridComputeResourceGroupMockingExtension(resourceGroupResource).GetHybridComputeMachines();
        }

        /// <summary>
        /// Retrieves information about the model view or the instance view of a hybrid machine.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Machines_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="machineName"> The name of the hybrid machine. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="machineName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="machineName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<HybridComputeMachineResource>> GetHybridComputeMachineAsync(this ResourceGroupResource resourceGroupResource, string machineName, InstanceViewType? expand = null, CancellationToken cancellationToken = default)
        {
            return await GetHybridComputeResourceGroupMockingExtension(resourceGroupResource).GetHybridComputeMachineAsync(machineName, expand, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieves information about the model view or the instance view of a hybrid machine.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Machines_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="machineName"> The name of the hybrid machine. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="machineName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="machineName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<HybridComputeMachineResource> GetHybridComputeMachine(this ResourceGroupResource resourceGroupResource, string machineName, InstanceViewType? expand = null, CancellationToken cancellationToken = default)
        {
            return GetHybridComputeResourceGroupMockingExtension(resourceGroupResource).GetHybridComputeMachine(machineName, expand, cancellationToken);
        }

        /// <summary> Gets a collection of HybridComputePrivateLinkScopeResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of HybridComputePrivateLinkScopeResources and their operations over a HybridComputePrivateLinkScopeResource. </returns>
        public static HybridComputePrivateLinkScopeCollection GetHybridComputePrivateLinkScopes(this ResourceGroupResource resourceGroupResource)
        {
            return GetHybridComputeResourceGroupMockingExtension(resourceGroupResource).GetHybridComputePrivateLinkScopes();
        }

        /// <summary>
        /// Returns a Azure Arc PrivateLinkScope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/privateLinkScopes/{scopeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkScopes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="scopeName"> The name of the Azure Arc PrivateLinkScope resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scopeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scopeName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<HybridComputePrivateLinkScopeResource>> GetHybridComputePrivateLinkScopeAsync(this ResourceGroupResource resourceGroupResource, string scopeName, CancellationToken cancellationToken = default)
        {
            return await GetHybridComputeResourceGroupMockingExtension(resourceGroupResource).GetHybridComputePrivateLinkScopeAsync(scopeName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns a Azure Arc PrivateLinkScope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/privateLinkScopes/{scopeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkScopes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="scopeName"> The name of the Azure Arc PrivateLinkScope resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scopeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scopeName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<HybridComputePrivateLinkScopeResource> GetHybridComputePrivateLinkScope(this ResourceGroupResource resourceGroupResource, string scopeName, CancellationToken cancellationToken = default)
        {
            return GetHybridComputeResourceGroupMockingExtension(resourceGroupResource).GetHybridComputePrivateLinkScope(scopeName, cancellationToken);
        }

        /// <summary>
        /// Lists all the hybrid machines in the specified subscription. Use the nextLink property in the response to get the next page of hybrid machines.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridCompute/machines</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Machines_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HybridComputeMachineResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<HybridComputeMachineResource> GetHybridComputeMachinesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetHybridComputeSubscriptionMockingExtension(subscriptionResource).GetHybridComputeMachinesAsync(cancellationToken);
        }

        /// <summary>
        /// Lists all the hybrid machines in the specified subscription. Use the nextLink property in the response to get the next page of hybrid machines.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridCompute/machines</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Machines_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HybridComputeMachineResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<HybridComputeMachineResource> GetHybridComputeMachines(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetHybridComputeSubscriptionMockingExtension(subscriptionResource).GetHybridComputeMachines(cancellationToken);
        }

        /// <summary>
        /// Gets a list of all Azure Arc PrivateLinkScopes within a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridCompute/privateLinkScopes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkScopes_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HybridComputePrivateLinkScopeResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<HybridComputePrivateLinkScopeResource> GetHybridComputePrivateLinkScopesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetHybridComputeSubscriptionMockingExtension(subscriptionResource).GetHybridComputePrivateLinkScopesAsync(cancellationToken);
        }

        /// <summary>
        /// Gets a list of all Azure Arc PrivateLinkScopes within a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridCompute/privateLinkScopes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkScopes_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HybridComputePrivateLinkScopeResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<HybridComputePrivateLinkScopeResource> GetHybridComputePrivateLinkScopes(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetHybridComputeSubscriptionMockingExtension(subscriptionResource).GetHybridComputePrivateLinkScopes(cancellationToken);
        }

        /// <summary>
        /// Returns a Azure Arc PrivateLinkScope's validation details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridCompute/locations/{location}/privateLinkScopes/{privateLinkScopeId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkScopes_GetValidationDetails</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the target resource. </param>
        /// <param name="privateLinkScopeId"> The id (Guid) of the Azure Arc PrivateLinkScope resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateLinkScopeId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateLinkScopeId"/> is null. </exception>
        public static async Task<Response<PrivateLinkScopeValidationDetails>> GetValidationDetailsPrivateLinkScopeAsync(this SubscriptionResource subscriptionResource, AzureLocation location, string privateLinkScopeId, CancellationToken cancellationToken = default)
        {
            return await GetHybridComputeSubscriptionMockingExtension(subscriptionResource).GetValidationDetailsPrivateLinkScopeAsync(location, privateLinkScopeId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns a Azure Arc PrivateLinkScope's validation details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridCompute/locations/{location}/privateLinkScopes/{privateLinkScopeId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkScopes_GetValidationDetails</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the target resource. </param>
        /// <param name="privateLinkScopeId"> The id (Guid) of the Azure Arc PrivateLinkScope resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateLinkScopeId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateLinkScopeId"/> is null. </exception>
        public static Response<PrivateLinkScopeValidationDetails> GetValidationDetailsPrivateLinkScope(this SubscriptionResource subscriptionResource, AzureLocation location, string privateLinkScopeId, CancellationToken cancellationToken = default)
        {
            return GetHybridComputeSubscriptionMockingExtension(subscriptionResource).GetValidationDetailsPrivateLinkScope(location, privateLinkScopeId, cancellationToken);
        }
    }
}
