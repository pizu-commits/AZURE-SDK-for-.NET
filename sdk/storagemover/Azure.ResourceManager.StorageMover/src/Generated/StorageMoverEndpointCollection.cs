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

namespace Azure.ResourceManager.StorageMover
{
    /// <summary>
    /// A class representing a collection of <see cref="StorageMoverEndpointResource" /> and their operations.
    /// Each <see cref="StorageMoverEndpointResource" /> in the collection will belong to the same instance of <see cref="StorageMoverResource" />.
    /// To get a <see cref="StorageMoverEndpointCollection" /> instance call the GetStorageMoverEndpoints method from an instance of <see cref="StorageMoverResource" />.
    /// </summary>
    public partial class StorageMoverEndpointCollection : ArmCollection, IEnumerable<StorageMoverEndpointResource>, IAsyncEnumerable<StorageMoverEndpointResource>
    {
        private readonly ClientDiagnostics _storageMoverEndpointEndpointsClientDiagnostics;
        private readonly EndpointsRestOperations _storageMoverEndpointEndpointsRestClient;

        /// <summary> Initializes a new instance of the <see cref="StorageMoverEndpointCollection"/> class for mocking. </summary>
        protected StorageMoverEndpointCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StorageMoverEndpointCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal StorageMoverEndpointCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _storageMoverEndpointEndpointsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.StorageMover", StorageMoverEndpointResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(StorageMoverEndpointResource.ResourceType, out string storageMoverEndpointEndpointsApiVersion);
            _storageMoverEndpointEndpointsRestClient = new EndpointsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, storageMoverEndpointEndpointsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != StorageMoverResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, StorageMoverResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an Endpoint resource, which represents a data transfer source or destination.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/endpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="endpointName"> The name of the Endpoint resource. </param>
        /// <param name="data"> The StorageMoverEndpointData to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<StorageMoverEndpointResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string endpointName, StorageMoverEndpointData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _storageMoverEndpointEndpointsClientDiagnostics.CreateScope("StorageMoverEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _storageMoverEndpointEndpointsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, data, cancellationToken).ConfigureAwait(false);
                var operation = new StorageMoverArmOperation<StorageMoverEndpointResource>(Response.FromValue(new StorageMoverEndpointResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates an Endpoint resource, which represents a data transfer source or destination.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/endpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="endpointName"> The name of the Endpoint resource. </param>
        /// <param name="data"> The StorageMoverEndpointData to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<StorageMoverEndpointResource> CreateOrUpdate(WaitUntil waitUntil, string endpointName, StorageMoverEndpointData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _storageMoverEndpointEndpointsClientDiagnostics.CreateScope("StorageMoverEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _storageMoverEndpointEndpointsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, data, cancellationToken);
                var operation = new StorageMoverArmOperation<StorageMoverEndpointResource>(Response.FromValue(new StorageMoverEndpointResource(Client, response), response.GetRawResponse()));
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
        /// Gets an Endpoint resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/endpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="endpointName"> The name of the Endpoint resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        public virtual async Task<Response<StorageMoverEndpointResource>> GetAsync(string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));

            using var scope = _storageMoverEndpointEndpointsClientDiagnostics.CreateScope("StorageMoverEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = await _storageMoverEndpointEndpointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageMoverEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an Endpoint resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/endpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="endpointName"> The name of the Endpoint resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        public virtual Response<StorageMoverEndpointResource> Get(string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));

            using var scope = _storageMoverEndpointEndpointsClientDiagnostics.CreateScope("StorageMoverEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = _storageMoverEndpointEndpointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageMoverEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all Endpoints in a Storage Mover.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/endpoints</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageMoverEndpointResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StorageMoverEndpointResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _storageMoverEndpointEndpointsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _storageMoverEndpointEndpointsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new StorageMoverEndpointResource(Client, StorageMoverEndpointData.DeserializeStorageMoverEndpointData(e)), _storageMoverEndpointEndpointsClientDiagnostics, Pipeline, "StorageMoverEndpointCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all Endpoints in a Storage Mover.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/endpoints</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageMoverEndpointResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StorageMoverEndpointResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _storageMoverEndpointEndpointsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _storageMoverEndpointEndpointsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new StorageMoverEndpointResource(Client, StorageMoverEndpointData.DeserializeStorageMoverEndpointData(e)), _storageMoverEndpointEndpointsClientDiagnostics, Pipeline, "StorageMoverEndpointCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/endpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="endpointName"> The name of the Endpoint resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));

            using var scope = _storageMoverEndpointEndpointsClientDiagnostics.CreateScope("StorageMoverEndpointCollection.Exists");
            scope.Start();
            try
            {
                var response = await _storageMoverEndpointEndpointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/endpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="endpointName"> The name of the Endpoint resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        public virtual Response<bool> Exists(string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));

            using var scope = _storageMoverEndpointEndpointsClientDiagnostics.CreateScope("StorageMoverEndpointCollection.Exists");
            scope.Start();
            try
            {
                var response = _storageMoverEndpointEndpointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/endpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="endpointName"> The name of the Endpoint resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        public virtual async Task<NullableResponse<StorageMoverEndpointResource>> GetIfExistsAsync(string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));

            using var scope = _storageMoverEndpointEndpointsClientDiagnostics.CreateScope("StorageMoverEndpointCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _storageMoverEndpointEndpointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<StorageMoverEndpointResource>(response.GetRawResponse());
                return Response.FromValue(new StorageMoverEndpointResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/endpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="endpointName"> The name of the Endpoint resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        public virtual NullableResponse<StorageMoverEndpointResource> GetIfExists(string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));

            using var scope = _storageMoverEndpointEndpointsClientDiagnostics.CreateScope("StorageMoverEndpointCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _storageMoverEndpointEndpointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<StorageMoverEndpointResource>(response.GetRawResponse());
                return Response.FromValue(new StorageMoverEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<StorageMoverEndpointResource> IEnumerable<StorageMoverEndpointResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<StorageMoverEndpointResource> IAsyncEnumerable<StorageMoverEndpointResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
