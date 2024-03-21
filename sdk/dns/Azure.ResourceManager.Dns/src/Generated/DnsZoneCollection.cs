// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Dns
{
    /// <summary>
    /// A class representing a collection of <see cref="DnsZoneResource"/> and their operations.
    /// Each <see cref="DnsZoneResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="DnsZoneCollection"/> instance call the GetDnsZones method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class DnsZoneCollection : ArmCollection, IEnumerable<DnsZoneResource>, IAsyncEnumerable<DnsZoneResource>
    {
        private readonly ClientDiagnostics _dnsZoneZonesClientDiagnostics;
        private readonly ZonesRestOperations _dnsZoneZonesRestClient;

        /// <summary> Initializes a new instance of the <see cref="DnsZoneCollection"/> class for mocking. </summary>
        protected DnsZoneCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DnsZoneCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DnsZoneCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dnsZoneZonesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Dns", DnsZoneResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DnsZoneResource.ResourceType, out string dnsZoneZonesApiVersion);
            _dnsZoneZonesRestClient = new ZonesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dnsZoneZonesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a DNS zone. Does not modify DNS records within the zone.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Zones_CreateOrUpdate</description>
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
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="zoneName"> The name of the DNS zone (without a terminating dot). </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate operation. </param>
        /// <param name="ifMatch"> The etag of the DNS zone. Omit this value to always overwrite the current zone. Specify the last-seen etag value to prevent accidentally overwriting any concurrent changes. </param>
        /// <param name="ifNoneMatch"> Set to '*' to allow a new DNS zone to be created, but to prevent updating an existing zone. Other values will be ignored. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="zoneName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="zoneName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DnsZoneResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string zoneName, DnsZoneData data, ETag? ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(zoneName, nameof(zoneName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dnsZoneZonesClientDiagnostics.CreateScope("DnsZoneCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dnsZoneZonesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, zoneName, data, ifMatch, ifNoneMatch, cancellationToken).ConfigureAwait(false);
                var operation = new DnsArmOperation<DnsZoneResource>(Response.FromValue(new DnsZoneResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a DNS zone. Does not modify DNS records within the zone.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Zones_CreateOrUpdate</description>
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
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="zoneName"> The name of the DNS zone (without a terminating dot). </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate operation. </param>
        /// <param name="ifMatch"> The etag of the DNS zone. Omit this value to always overwrite the current zone. Specify the last-seen etag value to prevent accidentally overwriting any concurrent changes. </param>
        /// <param name="ifNoneMatch"> Set to '*' to allow a new DNS zone to be created, but to prevent updating an existing zone. Other values will be ignored. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="zoneName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="zoneName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DnsZoneResource> CreateOrUpdate(WaitUntil waitUntil, string zoneName, DnsZoneData data, ETag? ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(zoneName, nameof(zoneName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dnsZoneZonesClientDiagnostics.CreateScope("DnsZoneCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dnsZoneZonesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, zoneName, data, ifMatch, ifNoneMatch, cancellationToken);
                var operation = new DnsArmOperation<DnsZoneResource>(Response.FromValue(new DnsZoneResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
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
        /// </summary>
        /// <param name="zoneName"> The name of the DNS zone (without a terminating dot). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="zoneName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="zoneName"/> is null. </exception>
        public virtual async Task<Response<DnsZoneResource>> GetAsync(string zoneName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(zoneName, nameof(zoneName));

            using var scope = _dnsZoneZonesClientDiagnostics.CreateScope("DnsZoneCollection.Get");
            scope.Start();
            try
            {
                var response = await _dnsZoneZonesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, zoneName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DnsZoneResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
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
        /// </summary>
        /// <param name="zoneName"> The name of the DNS zone (without a terminating dot). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="zoneName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="zoneName"/> is null. </exception>
        public virtual Response<DnsZoneResource> Get(string zoneName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(zoneName, nameof(zoneName));

            using var scope = _dnsZoneZonesClientDiagnostics.CreateScope("DnsZoneCollection.Get");
            scope.Start();
            try
            {
                var response = _dnsZoneZonesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, zoneName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DnsZoneResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the DNS zones within a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Zones_ListByResourceGroup</description>
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
        /// </summary>
        /// <param name="top"> The maximum number of record sets to return. If not specified, returns up to 100 record sets. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DnsZoneResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DnsZoneResource> GetAllAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dnsZoneZonesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dnsZoneZonesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DnsZoneResource(Client, DnsZoneData.DeserializeDnsZoneData(e)), _dnsZoneZonesClientDiagnostics, Pipeline, "DnsZoneCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the DNS zones within a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Zones_ListByResourceGroup</description>
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
        /// </summary>
        /// <param name="top"> The maximum number of record sets to return. If not specified, returns up to 100 record sets. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DnsZoneResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DnsZoneResource> GetAll(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dnsZoneZonesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dnsZoneZonesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DnsZoneResource(Client, DnsZoneData.DeserializeDnsZoneData(e)), _dnsZoneZonesClientDiagnostics, Pipeline, "DnsZoneCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
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
        /// </summary>
        /// <param name="zoneName"> The name of the DNS zone (without a terminating dot). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="zoneName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="zoneName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string zoneName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(zoneName, nameof(zoneName));

            using var scope = _dnsZoneZonesClientDiagnostics.CreateScope("DnsZoneCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dnsZoneZonesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, zoneName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
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
        /// </summary>
        /// <param name="zoneName"> The name of the DNS zone (without a terminating dot). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="zoneName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="zoneName"/> is null. </exception>
        public virtual Response<bool> Exists(string zoneName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(zoneName, nameof(zoneName));

            using var scope = _dnsZoneZonesClientDiagnostics.CreateScope("DnsZoneCollection.Exists");
            scope.Start();
            try
            {
                var response = _dnsZoneZonesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, zoneName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
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
        /// </summary>
        /// <param name="zoneName"> The name of the DNS zone (without a terminating dot). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="zoneName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="zoneName"/> is null. </exception>
        public virtual async Task<NullableResponse<DnsZoneResource>> GetIfExistsAsync(string zoneName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(zoneName, nameof(zoneName));

            using var scope = _dnsZoneZonesClientDiagnostics.CreateScope("DnsZoneCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _dnsZoneZonesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, zoneName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DnsZoneResource>(response.GetRawResponse());
                return Response.FromValue(new DnsZoneResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
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
        /// </summary>
        /// <param name="zoneName"> The name of the DNS zone (without a terminating dot). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="zoneName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="zoneName"/> is null. </exception>
        public virtual NullableResponse<DnsZoneResource> GetIfExists(string zoneName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(zoneName, nameof(zoneName));

            using var scope = _dnsZoneZonesClientDiagnostics.CreateScope("DnsZoneCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _dnsZoneZonesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, zoneName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DnsZoneResource>(response.GetRawResponse());
                return Response.FromValue(new DnsZoneResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DnsZoneResource> IEnumerable<DnsZoneResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DnsZoneResource> IAsyncEnumerable<DnsZoneResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
