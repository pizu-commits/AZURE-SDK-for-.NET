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

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    /// <summary>
    /// A class representing a collection of <see cref="NetworkFabricNeighborGroupResource"/> and their operations.
    /// Each <see cref="NetworkFabricNeighborGroupResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="NetworkFabricNeighborGroupCollection"/> instance call the GetNetworkFabricNeighborGroups method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class NetworkFabricNeighborGroupCollection : ArmCollection, IEnumerable<NetworkFabricNeighborGroupResource>, IAsyncEnumerable<NetworkFabricNeighborGroupResource>
    {
        private readonly ClientDiagnostics _networkFabricNeighborGroupNeighborGroupsClientDiagnostics;
        private readonly NeighborGroupsRestOperations _networkFabricNeighborGroupNeighborGroupsRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkFabricNeighborGroupCollection"/> class for mocking. </summary>
        protected NetworkFabricNeighborGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkFabricNeighborGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkFabricNeighborGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkFabricNeighborGroupNeighborGroupsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ManagedNetworkFabric", NetworkFabricNeighborGroupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkFabricNeighborGroupResource.ResourceType, out string networkFabricNeighborGroupNeighborGroupsApiVersion);
            _networkFabricNeighborGroupNeighborGroupsRestClient = new NeighborGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkFabricNeighborGroupNeighborGroupsApiVersion);
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
        /// Implements the Neighbor Group PUT method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/neighborGroups/{neighborGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NeighborGroups_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkFabricNeighborGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="neighborGroupName"> Name of the Neighbor Group. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="neighborGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="neighborGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetworkFabricNeighborGroupResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string neighborGroupName, NetworkFabricNeighborGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(neighborGroupName, nameof(neighborGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkFabricNeighborGroupNeighborGroupsClientDiagnostics.CreateScope("NetworkFabricNeighborGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkFabricNeighborGroupNeighborGroupsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, neighborGroupName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ManagedNetworkFabricArmOperation<NetworkFabricNeighborGroupResource>(new NetworkFabricNeighborGroupOperationSource(Client), _networkFabricNeighborGroupNeighborGroupsClientDiagnostics, Pipeline, _networkFabricNeighborGroupNeighborGroupsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, neighborGroupName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Implements the Neighbor Group PUT method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/neighborGroups/{neighborGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NeighborGroups_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkFabricNeighborGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="neighborGroupName"> Name of the Neighbor Group. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="neighborGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="neighborGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetworkFabricNeighborGroupResource> CreateOrUpdate(WaitUntil waitUntil, string neighborGroupName, NetworkFabricNeighborGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(neighborGroupName, nameof(neighborGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkFabricNeighborGroupNeighborGroupsClientDiagnostics.CreateScope("NetworkFabricNeighborGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkFabricNeighborGroupNeighborGroupsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, neighborGroupName, data, cancellationToken);
                var operation = new ManagedNetworkFabricArmOperation<NetworkFabricNeighborGroupResource>(new NetworkFabricNeighborGroupOperationSource(Client), _networkFabricNeighborGroupNeighborGroupsClientDiagnostics, Pipeline, _networkFabricNeighborGroupNeighborGroupsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, neighborGroupName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the Neighbor Group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/neighborGroups/{neighborGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NeighborGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkFabricNeighborGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="neighborGroupName"> Name of the Neighbor Group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="neighborGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="neighborGroupName"/> is null. </exception>
        public virtual async Task<Response<NetworkFabricNeighborGroupResource>> GetAsync(string neighborGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(neighborGroupName, nameof(neighborGroupName));

            using var scope = _networkFabricNeighborGroupNeighborGroupsClientDiagnostics.CreateScope("NetworkFabricNeighborGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkFabricNeighborGroupNeighborGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, neighborGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkFabricNeighborGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the Neighbor Group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/neighborGroups/{neighborGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NeighborGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkFabricNeighborGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="neighborGroupName"> Name of the Neighbor Group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="neighborGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="neighborGroupName"/> is null. </exception>
        public virtual Response<NetworkFabricNeighborGroupResource> Get(string neighborGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(neighborGroupName, nameof(neighborGroupName));

            using var scope = _networkFabricNeighborGroupNeighborGroupsClientDiagnostics.CreateScope("NetworkFabricNeighborGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _networkFabricNeighborGroupNeighborGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, neighborGroupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkFabricNeighborGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Displays NeighborGroups list by resource group GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/neighborGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NeighborGroups_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkFabricNeighborGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkFabricNeighborGroupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkFabricNeighborGroupResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkFabricNeighborGroupNeighborGroupsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkFabricNeighborGroupNeighborGroupsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetworkFabricNeighborGroupResource(Client, NetworkFabricNeighborGroupData.DeserializeNetworkFabricNeighborGroupData(e)), _networkFabricNeighborGroupNeighborGroupsClientDiagnostics, Pipeline, "NetworkFabricNeighborGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Displays NeighborGroups list by resource group GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/neighborGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NeighborGroups_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkFabricNeighborGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkFabricNeighborGroupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkFabricNeighborGroupResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkFabricNeighborGroupNeighborGroupsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkFabricNeighborGroupNeighborGroupsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetworkFabricNeighborGroupResource(Client, NetworkFabricNeighborGroupData.DeserializeNetworkFabricNeighborGroupData(e)), _networkFabricNeighborGroupNeighborGroupsClientDiagnostics, Pipeline, "NetworkFabricNeighborGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/neighborGroups/{neighborGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NeighborGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkFabricNeighborGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="neighborGroupName"> Name of the Neighbor Group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="neighborGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="neighborGroupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string neighborGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(neighborGroupName, nameof(neighborGroupName));

            using var scope = _networkFabricNeighborGroupNeighborGroupsClientDiagnostics.CreateScope("NetworkFabricNeighborGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkFabricNeighborGroupNeighborGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, neighborGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/neighborGroups/{neighborGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NeighborGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkFabricNeighborGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="neighborGroupName"> Name of the Neighbor Group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="neighborGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="neighborGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string neighborGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(neighborGroupName, nameof(neighborGroupName));

            using var scope = _networkFabricNeighborGroupNeighborGroupsClientDiagnostics.CreateScope("NetworkFabricNeighborGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkFabricNeighborGroupNeighborGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, neighborGroupName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/neighborGroups/{neighborGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NeighborGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkFabricNeighborGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="neighborGroupName"> Name of the Neighbor Group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="neighborGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="neighborGroupName"/> is null. </exception>
        public virtual async Task<NullableResponse<NetworkFabricNeighborGroupResource>> GetIfExistsAsync(string neighborGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(neighborGroupName, nameof(neighborGroupName));

            using var scope = _networkFabricNeighborGroupNeighborGroupsClientDiagnostics.CreateScope("NetworkFabricNeighborGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _networkFabricNeighborGroupNeighborGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, neighborGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<NetworkFabricNeighborGroupResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkFabricNeighborGroupResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/neighborGroups/{neighborGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NeighborGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkFabricNeighborGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="neighborGroupName"> Name of the Neighbor Group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="neighborGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="neighborGroupName"/> is null. </exception>
        public virtual NullableResponse<NetworkFabricNeighborGroupResource> GetIfExists(string neighborGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(neighborGroupName, nameof(neighborGroupName));

            using var scope = _networkFabricNeighborGroupNeighborGroupsClientDiagnostics.CreateScope("NetworkFabricNeighborGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _networkFabricNeighborGroupNeighborGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, neighborGroupName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<NetworkFabricNeighborGroupResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkFabricNeighborGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkFabricNeighborGroupResource> IEnumerable<NetworkFabricNeighborGroupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkFabricNeighborGroupResource> IAsyncEnumerable<NetworkFabricNeighborGroupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
