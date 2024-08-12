// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.PrivateDns.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockablePrivateDnsResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockablePrivateDnsResourceGroupResource"/> class for mocking. </summary>
        protected MockablePrivateDnsResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockablePrivateDnsResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockablePrivateDnsResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of PrivateDnsZoneResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of PrivateDnsZoneResources and their operations over a PrivateDnsZoneResource. </returns>
        public virtual PrivateDnsZoneCollection GetPrivateDnsZones()
        {
            return GetCachedClient(client => new PrivateDnsZoneCollection(client, Id));
        }

        /// <summary>
        /// Gets a Private DNS zone. Retrieves the zone properties, but not the virtual networks links or the record sets within the zone.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateDnsZones/{privateZoneName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateZones_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PrivateDnsZoneResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateZoneName"> The name of the Private DNS zone (without a terminating dot). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="privateZoneName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="privateZoneName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<PrivateDnsZoneResource>> GetPrivateDnsZoneAsync(string privateZoneName, CancellationToken cancellationToken = default)
        {
            return await GetPrivateDnsZones().GetAsync(privateZoneName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a Private DNS zone. Retrieves the zone properties, but not the virtual networks links or the record sets within the zone.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateDnsZones/{privateZoneName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateZones_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PrivateDnsZoneResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateZoneName"> The name of the Private DNS zone (without a terminating dot). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="privateZoneName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="privateZoneName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<PrivateDnsZoneResource> GetPrivateDnsZone(string privateZoneName, CancellationToken cancellationToken = default)
        {
            return GetPrivateDnsZones().Get(privateZoneName, cancellationToken);
        }
    }
}
