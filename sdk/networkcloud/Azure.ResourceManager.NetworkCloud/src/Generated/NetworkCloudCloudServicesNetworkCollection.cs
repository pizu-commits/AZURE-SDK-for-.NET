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
    /// A class representing a collection of <see cref="NetworkCloudCloudServicesNetworkResource" /> and their operations.
    /// Each <see cref="NetworkCloudCloudServicesNetworkResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="NetworkCloudCloudServicesNetworkCollection" /> instance call the GetNetworkCloudCloudServicesNetworks method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class NetworkCloudCloudServicesNetworkCollection : ArmCollection, IEnumerable<NetworkCloudCloudServicesNetworkResource>, IAsyncEnumerable<NetworkCloudCloudServicesNetworkResource>
    {
        private readonly ClientDiagnostics _networkCloudCloudServicesNetworkCloudServicesNetworksClientDiagnostics;
        private readonly CloudServicesNetworksRestOperations _networkCloudCloudServicesNetworkCloudServicesNetworksRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkCloudCloudServicesNetworkCollection"/> class for mocking. </summary>
        protected NetworkCloudCloudServicesNetworkCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkCloudCloudServicesNetworkCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkCloudCloudServicesNetworkCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkCloudCloudServicesNetworkCloudServicesNetworksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.NetworkCloud", NetworkCloudCloudServicesNetworkResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkCloudCloudServicesNetworkResource.ResourceType, out string networkCloudCloudServicesNetworkCloudServicesNetworksApiVersion);
            _networkCloudCloudServicesNetworkCloudServicesNetworksRestClient = new CloudServicesNetworksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkCloudCloudServicesNetworkCloudServicesNetworksApiVersion);
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
        /// Create a new cloud services network or update the properties of the existing cloud services network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/cloudServicesNetworks/{cloudServicesNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudServicesNetworks_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cloudServicesNetworkName"> The name of the cloud services network. </param>
        /// <param name="data"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudServicesNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudServicesNetworkName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetworkCloudCloudServicesNetworkResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string cloudServicesNetworkName, NetworkCloudCloudServicesNetworkData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudServicesNetworkName, nameof(cloudServicesNetworkName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkCloudCloudServicesNetworkCloudServicesNetworksClientDiagnostics.CreateScope("NetworkCloudCloudServicesNetworkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkCloudCloudServicesNetworkCloudServicesNetworksRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, cloudServicesNetworkName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkCloudArmOperation<NetworkCloudCloudServicesNetworkResource>(new NetworkCloudCloudServicesNetworkOperationSource(Client), _networkCloudCloudServicesNetworkCloudServicesNetworksClientDiagnostics, Pipeline, _networkCloudCloudServicesNetworkCloudServicesNetworksRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, cloudServicesNetworkName, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a new cloud services network or update the properties of the existing cloud services network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/cloudServicesNetworks/{cloudServicesNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudServicesNetworks_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cloudServicesNetworkName"> The name of the cloud services network. </param>
        /// <param name="data"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudServicesNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudServicesNetworkName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetworkCloudCloudServicesNetworkResource> CreateOrUpdate(WaitUntil waitUntil, string cloudServicesNetworkName, NetworkCloudCloudServicesNetworkData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudServicesNetworkName, nameof(cloudServicesNetworkName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkCloudCloudServicesNetworkCloudServicesNetworksClientDiagnostics.CreateScope("NetworkCloudCloudServicesNetworkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkCloudCloudServicesNetworkCloudServicesNetworksRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, cloudServicesNetworkName, data, cancellationToken);
                var operation = new NetworkCloudArmOperation<NetworkCloudCloudServicesNetworkResource>(new NetworkCloudCloudServicesNetworkOperationSource(Client), _networkCloudCloudServicesNetworkCloudServicesNetworksClientDiagnostics, Pipeline, _networkCloudCloudServicesNetworkCloudServicesNetworksRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, cloudServicesNetworkName, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get properties of the provided cloud services network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/cloudServicesNetworks/{cloudServicesNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudServicesNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cloudServicesNetworkName"> The name of the cloud services network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudServicesNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudServicesNetworkName"/> is null. </exception>
        public virtual async Task<Response<NetworkCloudCloudServicesNetworkResource>> GetAsync(string cloudServicesNetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudServicesNetworkName, nameof(cloudServicesNetworkName));

            using var scope = _networkCloudCloudServicesNetworkCloudServicesNetworksClientDiagnostics.CreateScope("NetworkCloudCloudServicesNetworkCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkCloudCloudServicesNetworkCloudServicesNetworksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, cloudServicesNetworkName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkCloudCloudServicesNetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get properties of the provided cloud services network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/cloudServicesNetworks/{cloudServicesNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudServicesNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cloudServicesNetworkName"> The name of the cloud services network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudServicesNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudServicesNetworkName"/> is null. </exception>
        public virtual Response<NetworkCloudCloudServicesNetworkResource> Get(string cloudServicesNetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudServicesNetworkName, nameof(cloudServicesNetworkName));

            using var scope = _networkCloudCloudServicesNetworkCloudServicesNetworksClientDiagnostics.CreateScope("NetworkCloudCloudServicesNetworkCollection.Get");
            scope.Start();
            try
            {
                var response = _networkCloudCloudServicesNetworkCloudServicesNetworksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, cloudServicesNetworkName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkCloudCloudServicesNetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a list of cloud services networks in the provided resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/cloudServicesNetworks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudServicesNetworks_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkCloudCloudServicesNetworkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkCloudCloudServicesNetworkResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkCloudCloudServicesNetworkCloudServicesNetworksRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkCloudCloudServicesNetworkCloudServicesNetworksRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetworkCloudCloudServicesNetworkResource(Client, NetworkCloudCloudServicesNetworkData.DeserializeNetworkCloudCloudServicesNetworkData(e)), _networkCloudCloudServicesNetworkCloudServicesNetworksClientDiagnostics, Pipeline, "NetworkCloudCloudServicesNetworkCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get a list of cloud services networks in the provided resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/cloudServicesNetworks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudServicesNetworks_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkCloudCloudServicesNetworkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkCloudCloudServicesNetworkResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkCloudCloudServicesNetworkCloudServicesNetworksRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkCloudCloudServicesNetworkCloudServicesNetworksRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetworkCloudCloudServicesNetworkResource(Client, NetworkCloudCloudServicesNetworkData.DeserializeNetworkCloudCloudServicesNetworkData(e)), _networkCloudCloudServicesNetworkCloudServicesNetworksClientDiagnostics, Pipeline, "NetworkCloudCloudServicesNetworkCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/cloudServicesNetworks/{cloudServicesNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudServicesNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cloudServicesNetworkName"> The name of the cloud services network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudServicesNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudServicesNetworkName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string cloudServicesNetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudServicesNetworkName, nameof(cloudServicesNetworkName));

            using var scope = _networkCloudCloudServicesNetworkCloudServicesNetworksClientDiagnostics.CreateScope("NetworkCloudCloudServicesNetworkCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkCloudCloudServicesNetworkCloudServicesNetworksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, cloudServicesNetworkName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/cloudServicesNetworks/{cloudServicesNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudServicesNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cloudServicesNetworkName"> The name of the cloud services network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudServicesNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudServicesNetworkName"/> is null. </exception>
        public virtual Response<bool> Exists(string cloudServicesNetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudServicesNetworkName, nameof(cloudServicesNetworkName));

            using var scope = _networkCloudCloudServicesNetworkCloudServicesNetworksClientDiagnostics.CreateScope("NetworkCloudCloudServicesNetworkCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkCloudCloudServicesNetworkCloudServicesNetworksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, cloudServicesNetworkName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkCloudCloudServicesNetworkResource> IEnumerable<NetworkCloudCloudServicesNetworkResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkCloudCloudServicesNetworkResource> IAsyncEnumerable<NetworkCloudCloudServicesNetworkResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
