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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.PrivateDns
{
    /// <summary>
    /// A class representing a collection of <see cref="VirtualNetworkLinkResource" /> and their operations.
    /// Each <see cref="VirtualNetworkLinkResource" /> in the collection will belong to the same instance of <see cref="PrivateDnsZoneResource" />.
    /// To get a <see cref="VirtualNetworkLinkCollection" /> instance call the GetVirtualNetworkLinks method from an instance of <see cref="PrivateDnsZoneResource" />.
    /// </summary>
    public partial class VirtualNetworkLinkCollection : ArmCollection, IEnumerable<VirtualNetworkLinkResource>, IAsyncEnumerable<VirtualNetworkLinkResource>
    {
        private readonly ClientDiagnostics _virtualNetworkLinkClientDiagnostics;
        private readonly VirtualNetworkLinksRestOperations _virtualNetworkLinkRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualNetworkLinkCollection"/> class for mocking. </summary>
        protected VirtualNetworkLinkCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualNetworkLinkCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VirtualNetworkLinkCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _virtualNetworkLinkClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.PrivateDns", VirtualNetworkLinkResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(VirtualNetworkLinkResource.ResourceType, out string virtualNetworkLinkApiVersion);
            _virtualNetworkLinkRestClient = new VirtualNetworkLinksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, virtualNetworkLinkApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != PrivateDnsZoneResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, PrivateDnsZoneResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a virtual network link to the specified Private DNS zone.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateDnsZones/{privateZoneName}/virtualNetworkLinks/{virtualNetworkLinkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkLinks_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="virtualNetworkLinkName"> The name of the virtual network link. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate operation. </param>
        /// <param name="ifMatch"> The ETag of the virtual network link to the Private DNS zone. Omit this value to always overwrite the current virtual network link. Specify the last-seen ETag value to prevent accidentally overwriting any concurrent changes. </param>
        /// <param name="ifNoneMatch"> Set to '*' to allow a new virtual network link to the Private DNS zone to be created, but to prevent updating an existing link. Other values will be ignored. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkLinkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkLinkName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<VirtualNetworkLinkResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string virtualNetworkLinkName, VirtualNetworkLinkData data, ETag? ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkLinkName, nameof(virtualNetworkLinkName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _virtualNetworkLinkClientDiagnostics.CreateScope("VirtualNetworkLinkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _virtualNetworkLinkRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkLinkName, data, ifMatch, ifNoneMatch, cancellationToken).ConfigureAwait(false);
                var operation = new PrivateDnsArmOperation<VirtualNetworkLinkResource>(new VirtualNetworkLinkOperationSource(Client), _virtualNetworkLinkClientDiagnostics, Pipeline, _virtualNetworkLinkRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkLinkName, data, ifMatch, ifNoneMatch).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a virtual network link to the specified Private DNS zone.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateDnsZones/{privateZoneName}/virtualNetworkLinks/{virtualNetworkLinkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkLinks_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="virtualNetworkLinkName"> The name of the virtual network link. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate operation. </param>
        /// <param name="ifMatch"> The ETag of the virtual network link to the Private DNS zone. Omit this value to always overwrite the current virtual network link. Specify the last-seen ETag value to prevent accidentally overwriting any concurrent changes. </param>
        /// <param name="ifNoneMatch"> Set to '*' to allow a new virtual network link to the Private DNS zone to be created, but to prevent updating an existing link. Other values will be ignored. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkLinkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkLinkName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<VirtualNetworkLinkResource> CreateOrUpdate(WaitUntil waitUntil, string virtualNetworkLinkName, VirtualNetworkLinkData data, ETag? ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkLinkName, nameof(virtualNetworkLinkName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _virtualNetworkLinkClientDiagnostics.CreateScope("VirtualNetworkLinkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _virtualNetworkLinkRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkLinkName, data, ifMatch, ifNoneMatch, cancellationToken);
                var operation = new PrivateDnsArmOperation<VirtualNetworkLinkResource>(new VirtualNetworkLinkOperationSource(Client), _virtualNetworkLinkClientDiagnostics, Pipeline, _virtualNetworkLinkRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkLinkName, data, ifMatch, ifNoneMatch).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a virtual network link to the specified Private DNS zone.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateDnsZones/{privateZoneName}/virtualNetworkLinks/{virtualNetworkLinkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkLinks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkLinkName"> The name of the virtual network link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkLinkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkLinkName"/> is null. </exception>
        public virtual async Task<Response<VirtualNetworkLinkResource>> GetAsync(string virtualNetworkLinkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkLinkName, nameof(virtualNetworkLinkName));

            using var scope = _virtualNetworkLinkClientDiagnostics.CreateScope("VirtualNetworkLinkCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualNetworkLinkRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkLinkName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a virtual network link to the specified Private DNS zone.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateDnsZones/{privateZoneName}/virtualNetworkLinks/{virtualNetworkLinkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkLinks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkLinkName"> The name of the virtual network link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkLinkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkLinkName"/> is null. </exception>
        public virtual Response<VirtualNetworkLinkResource> Get(string virtualNetworkLinkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkLinkName, nameof(virtualNetworkLinkName));

            using var scope = _virtualNetworkLinkClientDiagnostics.CreateScope("VirtualNetworkLinkCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualNetworkLinkRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkLinkName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the virtual network links to the specified Private DNS zone.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateDnsZones/{privateZoneName}/virtualNetworkLinks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkLinks_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The maximum number of virtual network links to return. If not specified, returns up to 100 virtual network links. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualNetworkLinkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualNetworkLinkResource> GetAllAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _virtualNetworkLinkRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _virtualNetworkLinkRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new VirtualNetworkLinkResource(Client, VirtualNetworkLinkData.DeserializeVirtualNetworkLinkData(e)), _virtualNetworkLinkClientDiagnostics, Pipeline, "VirtualNetworkLinkCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the virtual network links to the specified Private DNS zone.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateDnsZones/{privateZoneName}/virtualNetworkLinks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkLinks_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The maximum number of virtual network links to return. If not specified, returns up to 100 virtual network links. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualNetworkLinkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualNetworkLinkResource> GetAll(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _virtualNetworkLinkRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _virtualNetworkLinkRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new VirtualNetworkLinkResource(Client, VirtualNetworkLinkData.DeserializeVirtualNetworkLinkData(e)), _virtualNetworkLinkClientDiagnostics, Pipeline, "VirtualNetworkLinkCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateDnsZones/{privateZoneName}/virtualNetworkLinks/{virtualNetworkLinkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkLinks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkLinkName"> The name of the virtual network link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkLinkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkLinkName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string virtualNetworkLinkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkLinkName, nameof(virtualNetworkLinkName));

            using var scope = _virtualNetworkLinkClientDiagnostics.CreateScope("VirtualNetworkLinkCollection.Exists");
            scope.Start();
            try
            {
                var response = await _virtualNetworkLinkRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkLinkName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateDnsZones/{privateZoneName}/virtualNetworkLinks/{virtualNetworkLinkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkLinks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkLinkName"> The name of the virtual network link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkLinkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkLinkName"/> is null. </exception>
        public virtual Response<bool> Exists(string virtualNetworkLinkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkLinkName, nameof(virtualNetworkLinkName));

            using var scope = _virtualNetworkLinkClientDiagnostics.CreateScope("VirtualNetworkLinkCollection.Exists");
            scope.Start();
            try
            {
                var response = _virtualNetworkLinkRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkLinkName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateDnsZones/{privateZoneName}/virtualNetworkLinks/{virtualNetworkLinkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkLinks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkLinkName"> The name of the virtual network link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkLinkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkLinkName"/> is null. </exception>
        public virtual async Task<NullableResponse<VirtualNetworkLinkResource>> GetIfExistsAsync(string virtualNetworkLinkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkLinkName, nameof(virtualNetworkLinkName));

            using var scope = _virtualNetworkLinkClientDiagnostics.CreateScope("VirtualNetworkLinkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _virtualNetworkLinkRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkLinkName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<VirtualNetworkLinkResource>(response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkLinkResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateDnsZones/{privateZoneName}/virtualNetworkLinks/{virtualNetworkLinkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkLinks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkLinkName"> The name of the virtual network link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkLinkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkLinkName"/> is null. </exception>
        public virtual NullableResponse<VirtualNetworkLinkResource> GetIfExists(string virtualNetworkLinkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkLinkName, nameof(virtualNetworkLinkName));

            using var scope = _virtualNetworkLinkClientDiagnostics.CreateScope("VirtualNetworkLinkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualNetworkLinkRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkLinkName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<VirtualNetworkLinkResource>(response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VirtualNetworkLinkResource> IEnumerable<VirtualNetworkLinkResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualNetworkLinkResource> IAsyncEnumerable<VirtualNetworkLinkResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
