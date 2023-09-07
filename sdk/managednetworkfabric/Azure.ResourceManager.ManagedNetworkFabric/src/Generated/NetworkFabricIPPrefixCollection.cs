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
    /// A class representing a collection of <see cref="NetworkFabricIPPrefixResource" /> and their operations.
    /// Each <see cref="NetworkFabricIPPrefixResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="NetworkFabricIPPrefixCollection" /> instance call the GetNetworkFabricIPPrefixes method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class NetworkFabricIPPrefixCollection : ArmCollection, IEnumerable<NetworkFabricIPPrefixResource>, IAsyncEnumerable<NetworkFabricIPPrefixResource>
    {
        private readonly ClientDiagnostics _networkFabricIPPrefixIPPrefixesClientDiagnostics;
        private readonly IpPrefixesRestOperations _networkFabricIPPrefixIPPrefixesRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkFabricIPPrefixCollection"/> class for mocking. </summary>
        protected NetworkFabricIPPrefixCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkFabricIPPrefixCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkFabricIPPrefixCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkFabricIPPrefixIPPrefixesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ManagedNetworkFabric", NetworkFabricIPPrefixResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkFabricIPPrefixResource.ResourceType, out string networkFabricIPPrefixIPPrefixesApiVersion);
            _networkFabricIPPrefixIPPrefixesRestClient = new IpPrefixesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkFabricIPPrefixIPPrefixesApiVersion);
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
        /// Implements IP Prefix PUT method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/ipPrefixes/{ipPrefixName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpPrefixes_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ipPrefixName"> Name of the IP Prefix. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipPrefixName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipPrefixName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetworkFabricIPPrefixResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string ipPrefixName, NetworkFabricIPPrefixData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipPrefixName, nameof(ipPrefixName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkFabricIPPrefixIPPrefixesClientDiagnostics.CreateScope("NetworkFabricIPPrefixCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkFabricIPPrefixIPPrefixesRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, ipPrefixName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ManagedNetworkFabricArmOperation<NetworkFabricIPPrefixResource>(new NetworkFabricIPPrefixOperationSource(Client), _networkFabricIPPrefixIPPrefixesClientDiagnostics, Pipeline, _networkFabricIPPrefixIPPrefixesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, ipPrefixName, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Implements IP Prefix PUT method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/ipPrefixes/{ipPrefixName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpPrefixes_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ipPrefixName"> Name of the IP Prefix. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipPrefixName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipPrefixName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetworkFabricIPPrefixResource> CreateOrUpdate(WaitUntil waitUntil, string ipPrefixName, NetworkFabricIPPrefixData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipPrefixName, nameof(ipPrefixName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkFabricIPPrefixIPPrefixesClientDiagnostics.CreateScope("NetworkFabricIPPrefixCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkFabricIPPrefixIPPrefixesRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, ipPrefixName, data, cancellationToken);
                var operation = new ManagedNetworkFabricArmOperation<NetworkFabricIPPrefixResource>(new NetworkFabricIPPrefixOperationSource(Client), _networkFabricIPPrefixIPPrefixesClientDiagnostics, Pipeline, _networkFabricIPPrefixIPPrefixesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, ipPrefixName, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Implements IP Prefix GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/ipPrefixes/{ipPrefixName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpPrefixes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ipPrefixName"> Name of the IP Prefix. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipPrefixName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipPrefixName"/> is null. </exception>
        public virtual async Task<Response<NetworkFabricIPPrefixResource>> GetAsync(string ipPrefixName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipPrefixName, nameof(ipPrefixName));

            using var scope = _networkFabricIPPrefixIPPrefixesClientDiagnostics.CreateScope("NetworkFabricIPPrefixCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkFabricIPPrefixIPPrefixesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, ipPrefixName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkFabricIPPrefixResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Implements IP Prefix GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/ipPrefixes/{ipPrefixName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpPrefixes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ipPrefixName"> Name of the IP Prefix. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipPrefixName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipPrefixName"/> is null. </exception>
        public virtual Response<NetworkFabricIPPrefixResource> Get(string ipPrefixName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipPrefixName, nameof(ipPrefixName));

            using var scope = _networkFabricIPPrefixIPPrefixesClientDiagnostics.CreateScope("NetworkFabricIPPrefixCollection.Get");
            scope.Start();
            try
            {
                var response = _networkFabricIPPrefixIPPrefixesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, ipPrefixName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkFabricIPPrefixResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Implements IpPrefixes list by resource group GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/ipPrefixes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpPrefixes_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkFabricIPPrefixResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkFabricIPPrefixResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkFabricIPPrefixIPPrefixesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkFabricIPPrefixIPPrefixesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetworkFabricIPPrefixResource(Client, NetworkFabricIPPrefixData.DeserializeNetworkFabricIPPrefixData(e)), _networkFabricIPPrefixIPPrefixesClientDiagnostics, Pipeline, "NetworkFabricIPPrefixCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Implements IpPrefixes list by resource group GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/ipPrefixes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpPrefixes_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkFabricIPPrefixResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkFabricIPPrefixResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkFabricIPPrefixIPPrefixesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkFabricIPPrefixIPPrefixesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetworkFabricIPPrefixResource(Client, NetworkFabricIPPrefixData.DeserializeNetworkFabricIPPrefixData(e)), _networkFabricIPPrefixIPPrefixesClientDiagnostics, Pipeline, "NetworkFabricIPPrefixCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/ipPrefixes/{ipPrefixName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpPrefixes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ipPrefixName"> Name of the IP Prefix. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipPrefixName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipPrefixName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string ipPrefixName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipPrefixName, nameof(ipPrefixName));

            using var scope = _networkFabricIPPrefixIPPrefixesClientDiagnostics.CreateScope("NetworkFabricIPPrefixCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkFabricIPPrefixIPPrefixesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, ipPrefixName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/ipPrefixes/{ipPrefixName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpPrefixes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ipPrefixName"> Name of the IP Prefix. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipPrefixName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipPrefixName"/> is null. </exception>
        public virtual Response<bool> Exists(string ipPrefixName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipPrefixName, nameof(ipPrefixName));

            using var scope = _networkFabricIPPrefixIPPrefixesClientDiagnostics.CreateScope("NetworkFabricIPPrefixCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkFabricIPPrefixIPPrefixesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, ipPrefixName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkFabricIPPrefixResource> IEnumerable<NetworkFabricIPPrefixResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkFabricIPPrefixResource> IAsyncEnumerable<NetworkFabricIPPrefixResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
