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
using Azure.ResourceManager.Elastic.Mocking;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Elastic
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.Elastic. </summary>
    public static partial class ElasticExtensions
    {
        private static MockableElasticArmClient GetMockableElasticArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableElasticArmClient(client0));
        }

        private static MockableElasticResourceGroupResource GetMockableElasticResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableElasticResourceGroupResource(client, resource.Id));
        }

        private static MockableElasticSubscriptionResource GetMockableElasticSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableElasticSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing an <see cref="ElasticMonitorResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ElasticMonitorResource.CreateResourceIdentifier" /> to create an <see cref="ElasticMonitorResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableElasticArmClient.GetElasticMonitorResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="ElasticMonitorResource"/> object. </returns>
        public static ElasticMonitorResource GetElasticMonitorResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableElasticArmClient(client).GetElasticMonitorResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MonitoringTagRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MonitoringTagRuleResource.CreateResourceIdentifier" /> to create a <see cref="MonitoringTagRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableElasticArmClient.GetMonitoringTagRuleResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="MonitoringTagRuleResource"/> object. </returns>
        public static MonitoringTagRuleResource GetMonitoringTagRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableElasticArmClient(client).GetMonitoringTagRuleResource(id);
        }

        /// <summary>
        /// Gets a collection of ElasticMonitorResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableElasticResourceGroupResource.GetElasticMonitorResources()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of ElasticMonitorResources and their operations over a ElasticMonitorResource. </returns>
        public static ElasticMonitorResourceCollection GetElasticMonitorResources(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableElasticResourceGroupResource(resourceGroupResource).GetElasticMonitorResources();
        }

        /// <summary>
        /// Get the properties of a specific monitor resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Elastic/monitors/{monitorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Monitors_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ElasticMonitorResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableElasticResourceGroupResource.GetElasticMonitorResourceAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="monitorName"> Monitor resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="monitorName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="monitorName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<ElasticMonitorResource>> GetElasticMonitorResourceAsync(this ResourceGroupResource resourceGroupResource, string monitorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableElasticResourceGroupResource(resourceGroupResource).GetElasticMonitorResourceAsync(monitorName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the properties of a specific monitor resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Elastic/monitors/{monitorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Monitors_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ElasticMonitorResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableElasticResourceGroupResource.GetElasticMonitorResource(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="monitorName"> Monitor resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="monitorName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="monitorName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<ElasticMonitorResource> GetElasticMonitorResource(this ResourceGroupResource resourceGroupResource, string monitorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableElasticResourceGroupResource(resourceGroupResource).GetElasticMonitorResource(monitorName, cancellationToken);
        }

        /// <summary>
        /// List all monitors under the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Elastic/monitors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Monitors_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ElasticMonitorResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableElasticSubscriptionResource.GetElasticMonitorResources(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="ElasticMonitorResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ElasticMonitorResource> GetElasticMonitorResourcesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableElasticSubscriptionResource(subscriptionResource).GetElasticMonitorResourcesAsync(cancellationToken);
        }

        /// <summary>
        /// List all monitors under the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Elastic/monitors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Monitors_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ElasticMonitorResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableElasticSubscriptionResource.GetElasticMonitorResources(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="ElasticMonitorResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ElasticMonitorResource> GetElasticMonitorResources(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableElasticSubscriptionResource(subscriptionResource).GetElasticMonitorResources(cancellationToken);
        }
    }
}
