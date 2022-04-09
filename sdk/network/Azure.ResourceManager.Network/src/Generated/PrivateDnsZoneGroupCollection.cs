// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="PrivateDnsZoneGroupResource" /> and their operations.
    /// Each <see cref="PrivateDnsZoneGroupResource" /> in the collection will belong to the same instance of <see cref="PrivateEndpointResource" />.
    /// To get a <see cref="PrivateDnsZoneGroupCollection" /> instance call the GetPrivateDnsZoneGroups method from an instance of <see cref="PrivateEndpointResource" />.
    /// </summary>
    public partial class PrivateDnsZoneGroupCollection : ArmCollection, IEnumerable<PrivateDnsZoneGroupResource>, IAsyncEnumerable<PrivateDnsZoneGroupResource>
    {
        private readonly ClientDiagnostics _privateDnsZoneGroupClientDiagnostics;
        private readonly PrivateDnsZoneGroupsRestOperations _privateDnsZoneGroupRestClient;

        /// <summary> Initializes a new instance of the <see cref="PrivateDnsZoneGroupCollection"/> class for mocking. </summary>
        protected PrivateDnsZoneGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PrivateDnsZoneGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PrivateDnsZoneGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _privateDnsZoneGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", PrivateDnsZoneGroupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PrivateDnsZoneGroupResource.ResourceType, out string privateDnsZoneGroupApiVersion);
            _privateDnsZoneGroupRestClient = new PrivateDnsZoneGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, privateDnsZoneGroupApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != PrivateEndpointResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, PrivateEndpointResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a private dns zone group in the specified private endpoint.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateEndpoints/{privateEndpointName}/privateDnsZoneGroups/{privateDnsZoneGroupName}
        /// Operation Id: PrivateDnsZoneGroups_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="privateDnsZoneGroupName"> The name of the private dns zone group. </param>
        /// <param name="data"> Parameters supplied to the create or update private dns zone group operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateDnsZoneGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateDnsZoneGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PrivateDnsZoneGroupResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string privateDnsZoneGroupName, PrivateDnsZoneGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateDnsZoneGroupName, nameof(privateDnsZoneGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _privateDnsZoneGroupClientDiagnostics.CreateScope("PrivateDnsZoneGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _privateDnsZoneGroupRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateDnsZoneGroupName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<PrivateDnsZoneGroupResource>(new PrivateDnsZoneGroupOperationSource(Client), _privateDnsZoneGroupClientDiagnostics, Pipeline, _privateDnsZoneGroupRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateDnsZoneGroupName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a private dns zone group in the specified private endpoint.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateEndpoints/{privateEndpointName}/privateDnsZoneGroups/{privateDnsZoneGroupName}
        /// Operation Id: PrivateDnsZoneGroups_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="privateDnsZoneGroupName"> The name of the private dns zone group. </param>
        /// <param name="data"> Parameters supplied to the create or update private dns zone group operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateDnsZoneGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateDnsZoneGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PrivateDnsZoneGroupResource> CreateOrUpdate(WaitUntil waitUntil, string privateDnsZoneGroupName, PrivateDnsZoneGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateDnsZoneGroupName, nameof(privateDnsZoneGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _privateDnsZoneGroupClientDiagnostics.CreateScope("PrivateDnsZoneGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _privateDnsZoneGroupRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateDnsZoneGroupName, data, cancellationToken);
                var operation = new NetworkArmOperation<PrivateDnsZoneGroupResource>(new PrivateDnsZoneGroupOperationSource(Client), _privateDnsZoneGroupClientDiagnostics, Pipeline, _privateDnsZoneGroupRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateDnsZoneGroupName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the private dns zone group resource by specified private dns zone group name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateEndpoints/{privateEndpointName}/privateDnsZoneGroups/{privateDnsZoneGroupName}
        /// Operation Id: PrivateDnsZoneGroups_Get
        /// </summary>
        /// <param name="privateDnsZoneGroupName"> The name of the private dns zone group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateDnsZoneGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateDnsZoneGroupName"/> is null. </exception>
        public virtual async Task<Response<PrivateDnsZoneGroupResource>> GetAsync(string privateDnsZoneGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateDnsZoneGroupName, nameof(privateDnsZoneGroupName));

            using var scope = _privateDnsZoneGroupClientDiagnostics.CreateScope("PrivateDnsZoneGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _privateDnsZoneGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateDnsZoneGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PrivateDnsZoneGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the private dns zone group resource by specified private dns zone group name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateEndpoints/{privateEndpointName}/privateDnsZoneGroups/{privateDnsZoneGroupName}
        /// Operation Id: PrivateDnsZoneGroups_Get
        /// </summary>
        /// <param name="privateDnsZoneGroupName"> The name of the private dns zone group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateDnsZoneGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateDnsZoneGroupName"/> is null. </exception>
        public virtual Response<PrivateDnsZoneGroupResource> Get(string privateDnsZoneGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateDnsZoneGroupName, nameof(privateDnsZoneGroupName));

            using var scope = _privateDnsZoneGroupClientDiagnostics.CreateScope("PrivateDnsZoneGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _privateDnsZoneGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateDnsZoneGroupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PrivateDnsZoneGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all private dns zone groups in a private endpoint.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateEndpoints/{privateEndpointName}/privateDnsZoneGroups
        /// Operation Id: PrivateDnsZoneGroups_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PrivateDnsZoneGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PrivateDnsZoneGroupResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<PrivateDnsZoneGroupResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _privateDnsZoneGroupClientDiagnostics.CreateScope("PrivateDnsZoneGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _privateDnsZoneGroupRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PrivateDnsZoneGroupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<PrivateDnsZoneGroupResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _privateDnsZoneGroupClientDiagnostics.CreateScope("PrivateDnsZoneGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _privateDnsZoneGroupRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PrivateDnsZoneGroupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets all private dns zone groups in a private endpoint.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateEndpoints/{privateEndpointName}/privateDnsZoneGroups
        /// Operation Id: PrivateDnsZoneGroups_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PrivateDnsZoneGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PrivateDnsZoneGroupResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<PrivateDnsZoneGroupResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _privateDnsZoneGroupClientDiagnostics.CreateScope("PrivateDnsZoneGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _privateDnsZoneGroupRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PrivateDnsZoneGroupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<PrivateDnsZoneGroupResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _privateDnsZoneGroupClientDiagnostics.CreateScope("PrivateDnsZoneGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _privateDnsZoneGroupRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PrivateDnsZoneGroupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateEndpoints/{privateEndpointName}/privateDnsZoneGroups/{privateDnsZoneGroupName}
        /// Operation Id: PrivateDnsZoneGroups_Get
        /// </summary>
        /// <param name="privateDnsZoneGroupName"> The name of the private dns zone group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateDnsZoneGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateDnsZoneGroupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string privateDnsZoneGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateDnsZoneGroupName, nameof(privateDnsZoneGroupName));

            using var scope = _privateDnsZoneGroupClientDiagnostics.CreateScope("PrivateDnsZoneGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _privateDnsZoneGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateDnsZoneGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateEndpoints/{privateEndpointName}/privateDnsZoneGroups/{privateDnsZoneGroupName}
        /// Operation Id: PrivateDnsZoneGroups_Get
        /// </summary>
        /// <param name="privateDnsZoneGroupName"> The name of the private dns zone group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateDnsZoneGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateDnsZoneGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string privateDnsZoneGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateDnsZoneGroupName, nameof(privateDnsZoneGroupName));

            using var scope = _privateDnsZoneGroupClientDiagnostics.CreateScope("PrivateDnsZoneGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = _privateDnsZoneGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateDnsZoneGroupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PrivateDnsZoneGroupResource> IEnumerable<PrivateDnsZoneGroupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PrivateDnsZoneGroupResource> IAsyncEnumerable<PrivateDnsZoneGroupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
