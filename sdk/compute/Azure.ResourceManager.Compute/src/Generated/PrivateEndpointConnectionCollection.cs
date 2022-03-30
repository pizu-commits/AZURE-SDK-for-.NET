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

namespace Azure.ResourceManager.Compute
{
    /// <summary>
    /// A class representing a collection of <see cref="PrivateEndpointConnectionResource" /> and their operations.
    /// Each <see cref="PrivateEndpointConnectionResource" /> in the collection will belong to the same instance of <see cref="DiskAccessResource" />.
    /// To get a <see cref="PrivateEndpointConnectionCollection" /> instance call the GetPrivateEndpointConnections method from an instance of <see cref="DiskAccessResource" />.
    /// </summary>
    public partial class PrivateEndpointConnectionCollection : ArmCollection, IEnumerable<PrivateEndpointConnectionResource>, IAsyncEnumerable<PrivateEndpointConnectionResource>
    {
        private readonly ClientDiagnostics _privateEndpointConnectionDiskAccessesClientDiagnostics;
        private readonly DiskAccessesRestOperations _privateEndpointConnectionDiskAccessesRestClient;

        /// <summary> Initializes a new instance of the <see cref="PrivateEndpointConnectionCollection"/> class for mocking. </summary>
        protected PrivateEndpointConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PrivateEndpointConnectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PrivateEndpointConnectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _privateEndpointConnectionDiskAccessesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", PrivateEndpointConnectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PrivateEndpointConnectionResource.ResourceType, out string privateEndpointConnectionDiskAccessesApiVersion);
            _privateEndpointConnectionDiskAccessesRestClient = new DiskAccessesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, privateEndpointConnectionDiskAccessesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DiskAccessResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DiskAccessResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Approve or reject a private endpoint connection under disk access resource, this can&apos;t be used to create a new private endpoint connection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskAccesses/{diskAccessName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: DiskAccesses_UpdateAPrivateEndpointConnection
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection. </param>
        /// <param name="data"> private endpoint connection object supplied in the body of the Put private endpoint connection operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PrivateEndpointConnectionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string privateEndpointConnectionName, PrivateEndpointConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _privateEndpointConnectionDiskAccessesClientDiagnostics.CreateScope("PrivateEndpointConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _privateEndpointConnectionDiskAccessesRestClient.UpdateAPrivateEndpointConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ComputeArmOperation<PrivateEndpointConnectionResource>(new PrivateEndpointConnectionOperationSource(Client), _privateEndpointConnectionDiskAccessesClientDiagnostics, Pipeline, _privateEndpointConnectionDiskAccessesRestClient.CreateUpdateAPrivateEndpointConnectionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Approve or reject a private endpoint connection under disk access resource, this can&apos;t be used to create a new private endpoint connection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskAccesses/{diskAccessName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: DiskAccesses_UpdateAPrivateEndpointConnection
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection. </param>
        /// <param name="data"> private endpoint connection object supplied in the body of the Put private endpoint connection operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PrivateEndpointConnectionResource> CreateOrUpdate(WaitUntil waitUntil, string privateEndpointConnectionName, PrivateEndpointConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _privateEndpointConnectionDiskAccessesClientDiagnostics.CreateScope("PrivateEndpointConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _privateEndpointConnectionDiskAccessesRestClient.UpdateAPrivateEndpointConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, data, cancellationToken);
                var operation = new ComputeArmOperation<PrivateEndpointConnectionResource>(new PrivateEndpointConnectionOperationSource(Client), _privateEndpointConnectionDiskAccessesClientDiagnostics, Pipeline, _privateEndpointConnectionDiskAccessesRestClient.CreateUpdateAPrivateEndpointConnectionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets information about a private endpoint connection under a disk access resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskAccesses/{diskAccessName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: DiskAccesses_GetAPrivateEndpointConnection
        /// </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual async Task<Response<PrivateEndpointConnectionResource>> GetAsync(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _privateEndpointConnectionDiskAccessesClientDiagnostics.CreateScope("PrivateEndpointConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _privateEndpointConnectionDiskAccessesRestClient.GetAPrivateEndpointConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about a private endpoint connection under a disk access resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskAccesses/{diskAccessName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: DiskAccesses_GetAPrivateEndpointConnection
        /// </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual Response<PrivateEndpointConnectionResource> Get(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _privateEndpointConnectionDiskAccessesClientDiagnostics.CreateScope("PrivateEndpointConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _privateEndpointConnectionDiskAccessesRestClient.GetAPrivateEndpointConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List information about private endpoint connections under a disk access resource
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskAccesses/{diskAccessName}/privateEndpointConnections
        /// Operation Id: DiskAccesses_ListPrivateEndpointConnections
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PrivateEndpointConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PrivateEndpointConnectionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<PrivateEndpointConnectionResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _privateEndpointConnectionDiskAccessesClientDiagnostics.CreateScope("PrivateEndpointConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _privateEndpointConnectionDiskAccessesRestClient.ListPrivateEndpointConnectionsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PrivateEndpointConnectionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<PrivateEndpointConnectionResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _privateEndpointConnectionDiskAccessesClientDiagnostics.CreateScope("PrivateEndpointConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _privateEndpointConnectionDiskAccessesRestClient.ListPrivateEndpointConnectionsNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PrivateEndpointConnectionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List information about private endpoint connections under a disk access resource
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskAccesses/{diskAccessName}/privateEndpointConnections
        /// Operation Id: DiskAccesses_ListPrivateEndpointConnections
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PrivateEndpointConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PrivateEndpointConnectionResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<PrivateEndpointConnectionResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _privateEndpointConnectionDiskAccessesClientDiagnostics.CreateScope("PrivateEndpointConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _privateEndpointConnectionDiskAccessesRestClient.ListPrivateEndpointConnections(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PrivateEndpointConnectionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<PrivateEndpointConnectionResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _privateEndpointConnectionDiskAccessesClientDiagnostics.CreateScope("PrivateEndpointConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _privateEndpointConnectionDiskAccessesRestClient.ListPrivateEndpointConnectionsNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PrivateEndpointConnectionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskAccesses/{diskAccessName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: DiskAccesses_GetAPrivateEndpointConnection
        /// </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _privateEndpointConnectionDiskAccessesClientDiagnostics.CreateScope("PrivateEndpointConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(privateEndpointConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskAccesses/{diskAccessName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: DiskAccesses_GetAPrivateEndpointConnection
        /// </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _privateEndpointConnectionDiskAccessesClientDiagnostics.CreateScope("PrivateEndpointConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(privateEndpointConnectionName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskAccesses/{diskAccessName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: DiskAccesses_GetAPrivateEndpointConnection
        /// </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual async Task<Response<PrivateEndpointConnectionResource>> GetIfExistsAsync(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _privateEndpointConnectionDiskAccessesClientDiagnostics.CreateScope("PrivateEndpointConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _privateEndpointConnectionDiskAccessesRestClient.GetAPrivateEndpointConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<PrivateEndpointConnectionResource>(null, response.GetRawResponse());
                return Response.FromValue(new PrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskAccesses/{diskAccessName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: DiskAccesses_GetAPrivateEndpointConnection
        /// </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual Response<PrivateEndpointConnectionResource> GetIfExists(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _privateEndpointConnectionDiskAccessesClientDiagnostics.CreateScope("PrivateEndpointConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _privateEndpointConnectionDiskAccessesRestClient.GetAPrivateEndpointConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<PrivateEndpointConnectionResource>(null, response.GetRawResponse());
                return Response.FromValue(new PrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PrivateEndpointConnectionResource> IEnumerable<PrivateEndpointConnectionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PrivateEndpointConnectionResource> IAsyncEnumerable<PrivateEndpointConnectionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
