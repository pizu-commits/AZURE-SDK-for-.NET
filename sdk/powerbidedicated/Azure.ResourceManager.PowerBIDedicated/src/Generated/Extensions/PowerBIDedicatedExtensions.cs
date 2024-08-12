// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.PowerBIDedicated.Mocking;
using Azure.ResourceManager.PowerBIDedicated.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.PowerBIDedicated
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.PowerBIDedicated. </summary>
    public static partial class PowerBIDedicatedExtensions
    {
        private static MockablePowerBIDedicatedArmClient GetMockablePowerBIDedicatedArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockablePowerBIDedicatedArmClient(client0));
        }

        private static MockablePowerBIDedicatedResourceGroupResource GetMockablePowerBIDedicatedResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockablePowerBIDedicatedResourceGroupResource(client, resource.Id));
        }

        private static MockablePowerBIDedicatedSubscriptionResource GetMockablePowerBIDedicatedSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockablePowerBIDedicatedSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="DedicatedCapacityResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DedicatedCapacityResource.CreateResourceIdentifier" /> to create a <see cref="DedicatedCapacityResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePowerBIDedicatedArmClient.GetDedicatedCapacityResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="DedicatedCapacityResource"/> object. </returns>
        public static DedicatedCapacityResource GetDedicatedCapacityResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockablePowerBIDedicatedArmClient(client).GetDedicatedCapacityResource(id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AutoScaleVCoreResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AutoScaleVCoreResource.CreateResourceIdentifier" /> to create an <see cref="AutoScaleVCoreResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePowerBIDedicatedArmClient.GetAutoScaleVCoreResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="AutoScaleVCoreResource"/> object. </returns>
        public static AutoScaleVCoreResource GetAutoScaleVCoreResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockablePowerBIDedicatedArmClient(client).GetAutoScaleVCoreResource(id);
        }

        /// <summary>
        /// Gets a collection of DedicatedCapacityResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePowerBIDedicatedResourceGroupResource.GetDedicatedCapacities()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of DedicatedCapacityResources and their operations over a DedicatedCapacityResource. </returns>
        public static DedicatedCapacityCollection GetDedicatedCapacities(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockablePowerBIDedicatedResourceGroupResource(resourceGroupResource).GetDedicatedCapacities();
        }

        /// <summary>
        /// Gets details about the specified dedicated capacity.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.PowerBIDedicated/capacities/{dedicatedCapacityName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Capacities_GetDetails</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DedicatedCapacityResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePowerBIDedicatedResourceGroupResource.GetDedicatedCapacityAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="dedicatedCapacityName"> The name of the dedicated capacity. It must be a minimum of 3 characters, and a maximum of 63. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="dedicatedCapacityName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="dedicatedCapacityName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<DedicatedCapacityResource>> GetDedicatedCapacityAsync(this ResourceGroupResource resourceGroupResource, string dedicatedCapacityName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockablePowerBIDedicatedResourceGroupResource(resourceGroupResource).GetDedicatedCapacityAsync(dedicatedCapacityName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets details about the specified dedicated capacity.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.PowerBIDedicated/capacities/{dedicatedCapacityName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Capacities_GetDetails</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DedicatedCapacityResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePowerBIDedicatedResourceGroupResource.GetDedicatedCapacity(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="dedicatedCapacityName"> The name of the dedicated capacity. It must be a minimum of 3 characters, and a maximum of 63. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="dedicatedCapacityName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="dedicatedCapacityName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<DedicatedCapacityResource> GetDedicatedCapacity(this ResourceGroupResource resourceGroupResource, string dedicatedCapacityName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockablePowerBIDedicatedResourceGroupResource(resourceGroupResource).GetDedicatedCapacity(dedicatedCapacityName, cancellationToken);
        }

        /// <summary>
        /// Gets a collection of AutoScaleVCoreResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePowerBIDedicatedResourceGroupResource.GetAutoScaleVCores()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of AutoScaleVCoreResources and their operations over a AutoScaleVCoreResource. </returns>
        public static AutoScaleVCoreCollection GetAutoScaleVCores(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockablePowerBIDedicatedResourceGroupResource(resourceGroupResource).GetAutoScaleVCores();
        }

        /// <summary>
        /// Gets details about the specified auto scale v-core.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.PowerBIDedicated/autoScaleVCores/{vcoreName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutoScaleVCores_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutoScaleVCoreResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePowerBIDedicatedResourceGroupResource.GetAutoScaleVCoreAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="vcoreName"> The name of the auto scale v-core. It must be a minimum of 3 characters, and a maximum of 63. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="vcoreName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="vcoreName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<AutoScaleVCoreResource>> GetAutoScaleVCoreAsync(this ResourceGroupResource resourceGroupResource, string vcoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockablePowerBIDedicatedResourceGroupResource(resourceGroupResource).GetAutoScaleVCoreAsync(vcoreName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets details about the specified auto scale v-core.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.PowerBIDedicated/autoScaleVCores/{vcoreName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutoScaleVCores_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutoScaleVCoreResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePowerBIDedicatedResourceGroupResource.GetAutoScaleVCore(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="vcoreName"> The name of the auto scale v-core. It must be a minimum of 3 characters, and a maximum of 63. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="vcoreName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="vcoreName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<AutoScaleVCoreResource> GetAutoScaleVCore(this ResourceGroupResource resourceGroupResource, string vcoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockablePowerBIDedicatedResourceGroupResource(resourceGroupResource).GetAutoScaleVCore(vcoreName, cancellationToken);
        }

        /// <summary>
        /// Lists all the Dedicated capacities for the given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.PowerBIDedicated/capacities</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Capacities_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DedicatedCapacityResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePowerBIDedicatedSubscriptionResource.GetDedicatedCapacities(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="DedicatedCapacityResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DedicatedCapacityResource> GetDedicatedCapacitiesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockablePowerBIDedicatedSubscriptionResource(subscriptionResource).GetDedicatedCapacitiesAsync(cancellationToken);
        }

        /// <summary>
        /// Lists all the Dedicated capacities for the given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.PowerBIDedicated/capacities</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Capacities_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DedicatedCapacityResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePowerBIDedicatedSubscriptionResource.GetDedicatedCapacities(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="DedicatedCapacityResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<DedicatedCapacityResource> GetDedicatedCapacities(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockablePowerBIDedicatedSubscriptionResource(subscriptionResource).GetDedicatedCapacities(cancellationToken);
        }

        /// <summary>
        /// Lists eligible SKUs for PowerBI Dedicated resource provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.PowerBIDedicated/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Capacities_ListSkus</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DedicatedCapacityResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePowerBIDedicatedSubscriptionResource.GetSkusCapacities(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="CapacitySku"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<CapacitySku> GetSkusCapacitiesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockablePowerBIDedicatedSubscriptionResource(subscriptionResource).GetSkusCapacitiesAsync(cancellationToken);
        }

        /// <summary>
        /// Lists eligible SKUs for PowerBI Dedicated resource provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.PowerBIDedicated/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Capacities_ListSkus</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DedicatedCapacityResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePowerBIDedicatedSubscriptionResource.GetSkusCapacities(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="CapacitySku"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<CapacitySku> GetSkusCapacities(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockablePowerBIDedicatedSubscriptionResource(subscriptionResource).GetSkusCapacities(cancellationToken);
        }

        /// <summary>
        /// Check the name availability in the target location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.PowerBIDedicated/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Capacities_CheckNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DedicatedCapacityResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePowerBIDedicatedSubscriptionResource.CheckNameAvailabilityCapacity(AzureLocation,CheckCapacityNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The region name which the operation will lookup into. </param>
        /// <param name="content"> The name of the capacity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="content"/> is null. </exception>
        public static async Task<Response<CheckCapacityNameAvailabilityResult>> CheckNameAvailabilityCapacityAsync(this SubscriptionResource subscriptionResource, AzureLocation location, CheckCapacityNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return await GetMockablePowerBIDedicatedSubscriptionResource(subscriptionResource).CheckNameAvailabilityCapacityAsync(location, content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Check the name availability in the target location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.PowerBIDedicated/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Capacities_CheckNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DedicatedCapacityResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePowerBIDedicatedSubscriptionResource.CheckNameAvailabilityCapacity(AzureLocation,CheckCapacityNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The region name which the operation will lookup into. </param>
        /// <param name="content"> The name of the capacity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="content"/> is null. </exception>
        public static Response<CheckCapacityNameAvailabilityResult> CheckNameAvailabilityCapacity(this SubscriptionResource subscriptionResource, AzureLocation location, CheckCapacityNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockablePowerBIDedicatedSubscriptionResource(subscriptionResource).CheckNameAvailabilityCapacity(location, content, cancellationToken);
        }

        /// <summary>
        /// Lists all the auto scale v-cores for the given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.PowerBIDedicated/autoScaleVCores</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutoScaleVCores_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutoScaleVCoreResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePowerBIDedicatedSubscriptionResource.GetAutoScaleVCores(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="AutoScaleVCoreResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<AutoScaleVCoreResource> GetAutoScaleVCoresAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockablePowerBIDedicatedSubscriptionResource(subscriptionResource).GetAutoScaleVCoresAsync(cancellationToken);
        }

        /// <summary>
        /// Lists all the auto scale v-cores for the given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.PowerBIDedicated/autoScaleVCores</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutoScaleVCores_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutoScaleVCoreResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePowerBIDedicatedSubscriptionResource.GetAutoScaleVCores(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="AutoScaleVCoreResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<AutoScaleVCoreResource> GetAutoScaleVCores(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockablePowerBIDedicatedSubscriptionResource(subscriptionResource).GetAutoScaleVCores(cancellationToken);
        }
    }
}
