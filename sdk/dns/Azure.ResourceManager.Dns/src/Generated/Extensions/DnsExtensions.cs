// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.Dns.Mocking;
using Azure.ResourceManager.Dns.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Dns
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.Dns. </summary>
    public static partial class DnsExtensions
    {
        private static MockableDnsArmClient GetMockableDnsArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableDnsArmClient(client0));
        }

        private static MockableDnsResourceGroupResource GetMockableDnsResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableDnsResourceGroupResource(client, resource.Id));
        }

        private static MockableDnsSubscriptionResource GetMockableDnsSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableDnsSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="DnsARecordResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DnsARecordResource.CreateResourceIdentifier" /> to create a <see cref="DnsARecordResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDnsArmClient.GetDnsARecordResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="DnsARecordResource"/> object. </returns>
        public static DnsARecordResource GetDnsARecordResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableDnsArmClient(client).GetDnsARecordResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DnsAaaaRecordResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DnsAaaaRecordResource.CreateResourceIdentifier" /> to create a <see cref="DnsAaaaRecordResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDnsArmClient.GetDnsAaaaRecordResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="DnsAaaaRecordResource"/> object. </returns>
        public static DnsAaaaRecordResource GetDnsAaaaRecordResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableDnsArmClient(client).GetDnsAaaaRecordResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DnsCaaRecordResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DnsCaaRecordResource.CreateResourceIdentifier" /> to create a <see cref="DnsCaaRecordResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDnsArmClient.GetDnsCaaRecordResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="DnsCaaRecordResource"/> object. </returns>
        public static DnsCaaRecordResource GetDnsCaaRecordResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableDnsArmClient(client).GetDnsCaaRecordResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DnsCnameRecordResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DnsCnameRecordResource.CreateResourceIdentifier" /> to create a <see cref="DnsCnameRecordResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDnsArmClient.GetDnsCnameRecordResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="DnsCnameRecordResource"/> object. </returns>
        public static DnsCnameRecordResource GetDnsCnameRecordResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableDnsArmClient(client).GetDnsCnameRecordResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DnsMXRecordResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DnsMXRecordResource.CreateResourceIdentifier" /> to create a <see cref="DnsMXRecordResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDnsArmClient.GetDnsMXRecordResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="DnsMXRecordResource"/> object. </returns>
        public static DnsMXRecordResource GetDnsMXRecordResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableDnsArmClient(client).GetDnsMXRecordResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DnsNSRecordResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DnsNSRecordResource.CreateResourceIdentifier" /> to create a <see cref="DnsNSRecordResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDnsArmClient.GetDnsNSRecordResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="DnsNSRecordResource"/> object. </returns>
        public static DnsNSRecordResource GetDnsNSRecordResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableDnsArmClient(client).GetDnsNSRecordResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DnsPtrRecordResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DnsPtrRecordResource.CreateResourceIdentifier" /> to create a <see cref="DnsPtrRecordResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDnsArmClient.GetDnsPtrRecordResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="DnsPtrRecordResource"/> object. </returns>
        public static DnsPtrRecordResource GetDnsPtrRecordResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableDnsArmClient(client).GetDnsPtrRecordResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DnsSoaRecordResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DnsSoaRecordResource.CreateResourceIdentifier" /> to create a <see cref="DnsSoaRecordResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDnsArmClient.GetDnsSoaRecordResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="DnsSoaRecordResource"/> object. </returns>
        public static DnsSoaRecordResource GetDnsSoaRecordResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableDnsArmClient(client).GetDnsSoaRecordResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DnsSrvRecordResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DnsSrvRecordResource.CreateResourceIdentifier" /> to create a <see cref="DnsSrvRecordResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDnsArmClient.GetDnsSrvRecordResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="DnsSrvRecordResource"/> object. </returns>
        public static DnsSrvRecordResource GetDnsSrvRecordResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableDnsArmClient(client).GetDnsSrvRecordResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DnsTxtRecordResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DnsTxtRecordResource.CreateResourceIdentifier" /> to create a <see cref="DnsTxtRecordResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDnsArmClient.GetDnsTxtRecordResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="DnsTxtRecordResource"/> object. </returns>
        public static DnsTxtRecordResource GetDnsTxtRecordResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableDnsArmClient(client).GetDnsTxtRecordResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DnsZoneResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DnsZoneResource.CreateResourceIdentifier" /> to create a <see cref="DnsZoneResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDnsArmClient.GetDnsZoneResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="DnsZoneResource"/> object. </returns>
        public static DnsZoneResource GetDnsZoneResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableDnsArmClient(client).GetDnsZoneResource(id);
        }

        /// <summary>
        /// Gets a collection of DnsZoneResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDnsResourceGroupResource.GetDnsZones()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of DnsZoneResources and their operations over a DnsZoneResource. </returns>
        public static DnsZoneCollection GetDnsZones(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableDnsResourceGroupResource(resourceGroupResource).GetDnsZones();
        }

        /// <summary>
        /// Gets a DNS zone. Retrieves the zone properties, but not the record sets within the zone.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Zones_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsZoneResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDnsResourceGroupResource.GetDnsZoneAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="zoneName"> The name of the DNS zone (without a terminating dot). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="zoneName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="zoneName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<DnsZoneResource>> GetDnsZoneAsync(this ResourceGroupResource resourceGroupResource, string zoneName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableDnsResourceGroupResource(resourceGroupResource).GetDnsZoneAsync(zoneName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a DNS zone. Retrieves the zone properties, but not the record sets within the zone.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Zones_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsZoneResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDnsResourceGroupResource.GetDnsZone(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="zoneName"> The name of the DNS zone (without a terminating dot). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="zoneName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="zoneName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<DnsZoneResource> GetDnsZone(this ResourceGroupResource resourceGroupResource, string zoneName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableDnsResourceGroupResource(resourceGroupResource).GetDnsZone(zoneName, cancellationToken);
        }

        /// <summary>
        /// Lists the DNS zones in all resource groups in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/dnszones</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Zones_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsZoneResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDnsSubscriptionResource.GetDnsZones(int?,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="top"> The maximum number of DNS zones to return. If not specified, returns up to 100 zones. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="DnsZoneResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DnsZoneResource> GetDnsZonesAsync(this SubscriptionResource subscriptionResource, int? top = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableDnsSubscriptionResource(subscriptionResource).GetDnsZonesAsync(top, cancellationToken);
        }

        /// <summary>
        /// Lists the DNS zones in all resource groups in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/dnszones</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Zones_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsZoneResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDnsSubscriptionResource.GetDnsZones(int?,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="top"> The maximum number of DNS zones to return. If not specified, returns up to 100 zones. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="DnsZoneResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<DnsZoneResource> GetDnsZones(this SubscriptionResource subscriptionResource, int? top = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableDnsSubscriptionResource(subscriptionResource).GetDnsZones(top, cancellationToken);
        }

        /// <summary>
        /// Returns the DNS records specified by the referencing targetResourceIds.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/getDnsResourceReference</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DnsResourceReference_GetByTargetResources</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-05-01</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDnsSubscriptionResource.GetDnsResourceReferencesByTargetResources(DnsResourceReferenceContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Properties for dns resource reference request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="content"/> is null. </exception>
        public static async Task<Response<DnsResourceReferenceResult>> GetDnsResourceReferencesByTargetResourcesAsync(this SubscriptionResource subscriptionResource, DnsResourceReferenceContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return await GetMockableDnsSubscriptionResource(subscriptionResource).GetDnsResourceReferencesByTargetResourcesAsync(content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns the DNS records specified by the referencing targetResourceIds.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/getDnsResourceReference</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DnsResourceReference_GetByTargetResources</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-05-01</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDnsSubscriptionResource.GetDnsResourceReferencesByTargetResources(DnsResourceReferenceContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Properties for dns resource reference request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="content"/> is null. </exception>
        public static Response<DnsResourceReferenceResult> GetDnsResourceReferencesByTargetResources(this SubscriptionResource subscriptionResource, DnsResourceReferenceContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableDnsSubscriptionResource(subscriptionResource).GetDnsResourceReferencesByTargetResources(content, cancellationToken);
        }
    }
}
