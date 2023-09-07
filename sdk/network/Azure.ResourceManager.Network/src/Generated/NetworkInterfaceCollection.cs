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

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="NetworkInterfaceResource" /> and their operations.
    /// Each <see cref="NetworkInterfaceResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="NetworkInterfaceCollection" /> instance call the GetNetworkInterfaces method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class NetworkInterfaceCollection : ArmCollection, IEnumerable<NetworkInterfaceResource>, IAsyncEnumerable<NetworkInterfaceResource>
    {
        private readonly ClientDiagnostics _networkInterfaceClientDiagnostics;
        private readonly NetworkInterfacesRestOperations _networkInterfaceRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkInterfaceCollection"/> class for mocking. </summary>
        protected NetworkInterfaceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkInterfaceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkInterfaceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkInterfaceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", NetworkInterfaceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkInterfaceResource.ResourceType, out string networkInterfaceApiVersion);
            _networkInterfaceRestClient = new NetworkInterfacesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkInterfaceApiVersion);
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
        /// Creates or updates a network interface.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkInterfaces_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="networkInterfaceName"> The name of the network interface. </param>
        /// <param name="data"> Parameters supplied to the create or update network interface operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkInterfaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkInterfaceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetworkInterfaceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string networkInterfaceName, NetworkInterfaceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkInterfaceName, nameof(networkInterfaceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkInterfaceClientDiagnostics.CreateScope("NetworkInterfaceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkInterfaceRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, networkInterfaceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<NetworkInterfaceResource>(new NetworkInterfaceOperationSource(Client), _networkInterfaceClientDiagnostics, Pipeline, _networkInterfaceRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, networkInterfaceName, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a network interface.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkInterfaces_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="networkInterfaceName"> The name of the network interface. </param>
        /// <param name="data"> Parameters supplied to the create or update network interface operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkInterfaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkInterfaceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetworkInterfaceResource> CreateOrUpdate(WaitUntil waitUntil, string networkInterfaceName, NetworkInterfaceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkInterfaceName, nameof(networkInterfaceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkInterfaceClientDiagnostics.CreateScope("NetworkInterfaceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkInterfaceRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, networkInterfaceName, data, cancellationToken);
                var operation = new NetworkArmOperation<NetworkInterfaceResource>(new NetworkInterfaceOperationSource(Client), _networkInterfaceClientDiagnostics, Pipeline, _networkInterfaceRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, networkInterfaceName, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets information about the specified network interface.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkInterfaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkInterfaceName"> The name of the network interface. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkInterfaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkInterfaceName"/> is null. </exception>
        public virtual async Task<Response<NetworkInterfaceResource>> GetAsync(string networkInterfaceName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkInterfaceName, nameof(networkInterfaceName));

            using var scope = _networkInterfaceClientDiagnostics.CreateScope("NetworkInterfaceCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkInterfaceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, networkInterfaceName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkInterfaceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified network interface.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkInterfaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkInterfaceName"> The name of the network interface. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkInterfaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkInterfaceName"/> is null. </exception>
        public virtual Response<NetworkInterfaceResource> Get(string networkInterfaceName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkInterfaceName, nameof(networkInterfaceName));

            using var scope = _networkInterfaceClientDiagnostics.CreateScope("NetworkInterfaceCollection.Get");
            scope.Start();
            try
            {
                var response = _networkInterfaceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, networkInterfaceName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkInterfaceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all network interfaces in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkInterfaces_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkInterfaceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkInterfaceResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkInterfaceRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkInterfaceRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetworkInterfaceResource(Client, NetworkInterfaceData.DeserializeNetworkInterfaceData(e)), _networkInterfaceClientDiagnostics, Pipeline, "NetworkInterfaceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all network interfaces in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkInterfaces_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkInterfaceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkInterfaceResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkInterfaceRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkInterfaceRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetworkInterfaceResource(Client, NetworkInterfaceData.DeserializeNetworkInterfaceData(e)), _networkInterfaceClientDiagnostics, Pipeline, "NetworkInterfaceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkInterfaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkInterfaceName"> The name of the network interface. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkInterfaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkInterfaceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string networkInterfaceName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkInterfaceName, nameof(networkInterfaceName));

            using var scope = _networkInterfaceClientDiagnostics.CreateScope("NetworkInterfaceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkInterfaceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, networkInterfaceName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkInterfaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkInterfaceName"> The name of the network interface. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkInterfaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkInterfaceName"/> is null. </exception>
        public virtual Response<bool> Exists(string networkInterfaceName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkInterfaceName, nameof(networkInterfaceName));

            using var scope = _networkInterfaceClientDiagnostics.CreateScope("NetworkInterfaceCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkInterfaceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, networkInterfaceName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkInterfaceResource> IEnumerable<NetworkInterfaceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkInterfaceResource> IAsyncEnumerable<NetworkInterfaceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
