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

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    /// <summary>
    /// A class representing a collection of <see cref="NetworkTapResource" /> and their operations.
    /// Each <see cref="NetworkTapResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="NetworkTapCollection" /> instance call the GetNetworkTaps method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class NetworkTapCollection : ArmCollection, IEnumerable<NetworkTapResource>, IAsyncEnumerable<NetworkTapResource>
    {
        private readonly ClientDiagnostics _networkTapClientDiagnostics;
        private readonly NetworkTapsRestOperations _networkTapRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkTapCollection"/> class for mocking. </summary>
        protected NetworkTapCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkTapCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkTapCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkTapClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ManagedNetworkFabric", NetworkTapResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkTapResource.ResourceType, out string networkTapApiVersion);
            _networkTapRestClient = new NetworkTapsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkTapApiVersion);
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
        /// Creates a Network Tap.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkTaps/{networkTapName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkTaps_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="networkTapName"> Name of the Network Tap. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkTapName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkTapName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetworkTapResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string networkTapName, NetworkTapData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkTapName, nameof(networkTapName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkTapClientDiagnostics.CreateScope("NetworkTapCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkTapRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, networkTapName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ManagedNetworkFabricArmOperation<NetworkTapResource>(new NetworkTapOperationSource(Client), _networkTapClientDiagnostics, Pipeline, _networkTapRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, networkTapName, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates a Network Tap.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkTaps/{networkTapName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkTaps_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="networkTapName"> Name of the Network Tap. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkTapName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkTapName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetworkTapResource> CreateOrUpdate(WaitUntil waitUntil, string networkTapName, NetworkTapData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkTapName, nameof(networkTapName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkTapClientDiagnostics.CreateScope("NetworkTapCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkTapRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, networkTapName, data, cancellationToken);
                var operation = new ManagedNetworkFabricArmOperation<NetworkTapResource>(new NetworkTapOperationSource(Client), _networkTapClientDiagnostics, Pipeline, _networkTapRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, networkTapName, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Retrieves details of this Network Tap.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkTaps/{networkTapName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkTaps_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkTapName"> Name of the Network Tap. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkTapName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkTapName"/> is null. </exception>
        public virtual async Task<Response<NetworkTapResource>> GetAsync(string networkTapName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkTapName, nameof(networkTapName));

            using var scope = _networkTapClientDiagnostics.CreateScope("NetworkTapCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkTapRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, networkTapName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkTapResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves details of this Network Tap.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkTaps/{networkTapName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkTaps_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkTapName"> Name of the Network Tap. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkTapName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkTapName"/> is null. </exception>
        public virtual Response<NetworkTapResource> Get(string networkTapName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkTapName, nameof(networkTapName));

            using var scope = _networkTapClientDiagnostics.CreateScope("NetworkTapCollection.Get");
            scope.Start();
            try
            {
                var response = _networkTapRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, networkTapName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkTapResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Displays Network Taps list by resource group GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkTaps</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkTaps_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkTapResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkTapResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkTapRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkTapRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetworkTapResource(Client, NetworkTapData.DeserializeNetworkTapData(e)), _networkTapClientDiagnostics, Pipeline, "NetworkTapCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Displays Network Taps list by resource group GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkTaps</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkTaps_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkTapResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkTapResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkTapRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkTapRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetworkTapResource(Client, NetworkTapData.DeserializeNetworkTapData(e)), _networkTapClientDiagnostics, Pipeline, "NetworkTapCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkTaps/{networkTapName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkTaps_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkTapName"> Name of the Network Tap. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkTapName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkTapName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string networkTapName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkTapName, nameof(networkTapName));

            using var scope = _networkTapClientDiagnostics.CreateScope("NetworkTapCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkTapRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, networkTapName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkTaps/{networkTapName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkTaps_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkTapName"> Name of the Network Tap. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkTapName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkTapName"/> is null. </exception>
        public virtual Response<bool> Exists(string networkTapName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkTapName, nameof(networkTapName));

            using var scope = _networkTapClientDiagnostics.CreateScope("NetworkTapCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkTapRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, networkTapName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkTapResource> IEnumerable<NetworkTapResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkTapResource> IAsyncEnumerable<NetworkTapResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
