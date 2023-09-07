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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.NetworkCloud
{
    /// <summary>
    /// A class representing a collection of <see cref="NetworkCloudL2NetworkResource" /> and their operations.
    /// Each <see cref="NetworkCloudL2NetworkResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="NetworkCloudL2NetworkCollection" /> instance call the GetNetworkCloudL2Networks method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class NetworkCloudL2NetworkCollection : ArmCollection, IEnumerable<NetworkCloudL2NetworkResource>, IAsyncEnumerable<NetworkCloudL2NetworkResource>
    {
        private readonly ClientDiagnostics _networkCloudL2NetworkL2NetworksClientDiagnostics;
        private readonly L2NetworksRestOperations _networkCloudL2NetworkL2NetworksRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkCloudL2NetworkCollection"/> class for mocking. </summary>
        protected NetworkCloudL2NetworkCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkCloudL2NetworkCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkCloudL2NetworkCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkCloudL2NetworkL2NetworksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.NetworkCloud", NetworkCloudL2NetworkResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkCloudL2NetworkResource.ResourceType, out string networkCloudL2NetworkL2NetworksApiVersion);
            _networkCloudL2NetworkL2NetworksRestClient = new L2NetworksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkCloudL2NetworkL2NetworksApiVersion);
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
        /// Create a new layer 2 (L2) network or update the properties of the existing network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/l2Networks/{l2NetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>L2Networks_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="l2NetworkName"> The name of the L2 network. </param>
        /// <param name="data"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="l2NetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="l2NetworkName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetworkCloudL2NetworkResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string l2NetworkName, NetworkCloudL2NetworkData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(l2NetworkName, nameof(l2NetworkName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkCloudL2NetworkL2NetworksClientDiagnostics.CreateScope("NetworkCloudL2NetworkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkCloudL2NetworkL2NetworksRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, l2NetworkName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkCloudArmOperation<NetworkCloudL2NetworkResource>(new NetworkCloudL2NetworkOperationSource(Client), _networkCloudL2NetworkL2NetworksClientDiagnostics, Pipeline, _networkCloudL2NetworkL2NetworksRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, l2NetworkName, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a new layer 2 (L2) network or update the properties of the existing network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/l2Networks/{l2NetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>L2Networks_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="l2NetworkName"> The name of the L2 network. </param>
        /// <param name="data"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="l2NetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="l2NetworkName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetworkCloudL2NetworkResource> CreateOrUpdate(WaitUntil waitUntil, string l2NetworkName, NetworkCloudL2NetworkData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(l2NetworkName, nameof(l2NetworkName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkCloudL2NetworkL2NetworksClientDiagnostics.CreateScope("NetworkCloudL2NetworkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkCloudL2NetworkL2NetworksRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, l2NetworkName, data, cancellationToken);
                var operation = new NetworkCloudArmOperation<NetworkCloudL2NetworkResource>(new NetworkCloudL2NetworkOperationSource(Client), _networkCloudL2NetworkL2NetworksClientDiagnostics, Pipeline, _networkCloudL2NetworkL2NetworksRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, l2NetworkName, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get properties of the provided layer 2 (L2) network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/l2Networks/{l2NetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>L2Networks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="l2NetworkName"> The name of the L2 network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="l2NetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="l2NetworkName"/> is null. </exception>
        public virtual async Task<Response<NetworkCloudL2NetworkResource>> GetAsync(string l2NetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(l2NetworkName, nameof(l2NetworkName));

            using var scope = _networkCloudL2NetworkL2NetworksClientDiagnostics.CreateScope("NetworkCloudL2NetworkCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkCloudL2NetworkL2NetworksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, l2NetworkName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkCloudL2NetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get properties of the provided layer 2 (L2) network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/l2Networks/{l2NetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>L2Networks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="l2NetworkName"> The name of the L2 network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="l2NetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="l2NetworkName"/> is null. </exception>
        public virtual Response<NetworkCloudL2NetworkResource> Get(string l2NetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(l2NetworkName, nameof(l2NetworkName));

            using var scope = _networkCloudL2NetworkL2NetworksClientDiagnostics.CreateScope("NetworkCloudL2NetworkCollection.Get");
            scope.Start();
            try
            {
                var response = _networkCloudL2NetworkL2NetworksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, l2NetworkName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkCloudL2NetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a list of layer 2 (L2) networks in the provided resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/l2Networks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>L2Networks_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkCloudL2NetworkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkCloudL2NetworkResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkCloudL2NetworkL2NetworksRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkCloudL2NetworkL2NetworksRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetworkCloudL2NetworkResource(Client, NetworkCloudL2NetworkData.DeserializeNetworkCloudL2NetworkData(e)), _networkCloudL2NetworkL2NetworksClientDiagnostics, Pipeline, "NetworkCloudL2NetworkCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get a list of layer 2 (L2) networks in the provided resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/l2Networks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>L2Networks_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkCloudL2NetworkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkCloudL2NetworkResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkCloudL2NetworkL2NetworksRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkCloudL2NetworkL2NetworksRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetworkCloudL2NetworkResource(Client, NetworkCloudL2NetworkData.DeserializeNetworkCloudL2NetworkData(e)), _networkCloudL2NetworkL2NetworksClientDiagnostics, Pipeline, "NetworkCloudL2NetworkCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/l2Networks/{l2NetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>L2Networks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="l2NetworkName"> The name of the L2 network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="l2NetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="l2NetworkName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string l2NetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(l2NetworkName, nameof(l2NetworkName));

            using var scope = _networkCloudL2NetworkL2NetworksClientDiagnostics.CreateScope("NetworkCloudL2NetworkCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkCloudL2NetworkL2NetworksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, l2NetworkName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/l2Networks/{l2NetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>L2Networks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="l2NetworkName"> The name of the L2 network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="l2NetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="l2NetworkName"/> is null. </exception>
        public virtual Response<bool> Exists(string l2NetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(l2NetworkName, nameof(l2NetworkName));

            using var scope = _networkCloudL2NetworkL2NetworksClientDiagnostics.CreateScope("NetworkCloudL2NetworkCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkCloudL2NetworkL2NetworksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, l2NetworkName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkCloudL2NetworkResource> IEnumerable<NetworkCloudL2NetworkResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkCloudL2NetworkResource> IAsyncEnumerable<NetworkCloudL2NetworkResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
