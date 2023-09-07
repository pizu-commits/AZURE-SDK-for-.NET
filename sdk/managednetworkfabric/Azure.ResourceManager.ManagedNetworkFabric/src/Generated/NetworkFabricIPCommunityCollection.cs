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
    /// A class representing a collection of <see cref="NetworkFabricIPCommunityResource" /> and their operations.
    /// Each <see cref="NetworkFabricIPCommunityResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="NetworkFabricIPCommunityCollection" /> instance call the GetNetworkFabricIPCommunities method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class NetworkFabricIPCommunityCollection : ArmCollection, IEnumerable<NetworkFabricIPCommunityResource>, IAsyncEnumerable<NetworkFabricIPCommunityResource>
    {
        private readonly ClientDiagnostics _networkFabricIPCommunityIPCommunitiesClientDiagnostics;
        private readonly IpCommunitiesRestOperations _networkFabricIPCommunityIPCommunitiesRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkFabricIPCommunityCollection"/> class for mocking. </summary>
        protected NetworkFabricIPCommunityCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkFabricIPCommunityCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkFabricIPCommunityCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkFabricIPCommunityIPCommunitiesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ManagedNetworkFabric", NetworkFabricIPCommunityResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkFabricIPCommunityResource.ResourceType, out string networkFabricIPCommunityIPCommunitiesApiVersion);
            _networkFabricIPCommunityIPCommunitiesRestClient = new IpCommunitiesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkFabricIPCommunityIPCommunitiesApiVersion);
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
        /// Implements an IP Community PUT method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/ipCommunities/{ipCommunityName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpCommunities_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ipCommunityName"> Name of the IP Community. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipCommunityName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipCommunityName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetworkFabricIPCommunityResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string ipCommunityName, NetworkFabricIPCommunityData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipCommunityName, nameof(ipCommunityName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkFabricIPCommunityIPCommunitiesClientDiagnostics.CreateScope("NetworkFabricIPCommunityCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkFabricIPCommunityIPCommunitiesRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, ipCommunityName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ManagedNetworkFabricArmOperation<NetworkFabricIPCommunityResource>(new NetworkFabricIPCommunityOperationSource(Client), _networkFabricIPCommunityIPCommunitiesClientDiagnostics, Pipeline, _networkFabricIPCommunityIPCommunitiesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, ipCommunityName, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Implements an IP Community PUT method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/ipCommunities/{ipCommunityName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpCommunities_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ipCommunityName"> Name of the IP Community. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipCommunityName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipCommunityName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetworkFabricIPCommunityResource> CreateOrUpdate(WaitUntil waitUntil, string ipCommunityName, NetworkFabricIPCommunityData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipCommunityName, nameof(ipCommunityName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkFabricIPCommunityIPCommunitiesClientDiagnostics.CreateScope("NetworkFabricIPCommunityCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkFabricIPCommunityIPCommunitiesRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, ipCommunityName, data, cancellationToken);
                var operation = new ManagedNetworkFabricArmOperation<NetworkFabricIPCommunityResource>(new NetworkFabricIPCommunityOperationSource(Client), _networkFabricIPCommunityIPCommunitiesClientDiagnostics, Pipeline, _networkFabricIPCommunityIPCommunitiesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, ipCommunityName, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Implements an IP Community GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/ipCommunities/{ipCommunityName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpCommunities_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ipCommunityName"> Name of the IP Community. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipCommunityName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipCommunityName"/> is null. </exception>
        public virtual async Task<Response<NetworkFabricIPCommunityResource>> GetAsync(string ipCommunityName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipCommunityName, nameof(ipCommunityName));

            using var scope = _networkFabricIPCommunityIPCommunitiesClientDiagnostics.CreateScope("NetworkFabricIPCommunityCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkFabricIPCommunityIPCommunitiesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, ipCommunityName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkFabricIPCommunityResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Implements an IP Community GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/ipCommunities/{ipCommunityName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpCommunities_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ipCommunityName"> Name of the IP Community. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipCommunityName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipCommunityName"/> is null. </exception>
        public virtual Response<NetworkFabricIPCommunityResource> Get(string ipCommunityName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipCommunityName, nameof(ipCommunityName));

            using var scope = _networkFabricIPCommunityIPCommunitiesClientDiagnostics.CreateScope("NetworkFabricIPCommunityCollection.Get");
            scope.Start();
            try
            {
                var response = _networkFabricIPCommunityIPCommunitiesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, ipCommunityName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkFabricIPCommunityResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Implements IP Communities list by resource group GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/ipCommunities</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpCommunities_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkFabricIPCommunityResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkFabricIPCommunityResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkFabricIPCommunityIPCommunitiesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkFabricIPCommunityIPCommunitiesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetworkFabricIPCommunityResource(Client, NetworkFabricIPCommunityData.DeserializeNetworkFabricIPCommunityData(e)), _networkFabricIPCommunityIPCommunitiesClientDiagnostics, Pipeline, "NetworkFabricIPCommunityCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Implements IP Communities list by resource group GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/ipCommunities</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpCommunities_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkFabricIPCommunityResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkFabricIPCommunityResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkFabricIPCommunityIPCommunitiesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkFabricIPCommunityIPCommunitiesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetworkFabricIPCommunityResource(Client, NetworkFabricIPCommunityData.DeserializeNetworkFabricIPCommunityData(e)), _networkFabricIPCommunityIPCommunitiesClientDiagnostics, Pipeline, "NetworkFabricIPCommunityCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/ipCommunities/{ipCommunityName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpCommunities_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ipCommunityName"> Name of the IP Community. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipCommunityName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipCommunityName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string ipCommunityName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipCommunityName, nameof(ipCommunityName));

            using var scope = _networkFabricIPCommunityIPCommunitiesClientDiagnostics.CreateScope("NetworkFabricIPCommunityCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkFabricIPCommunityIPCommunitiesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, ipCommunityName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/ipCommunities/{ipCommunityName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpCommunities_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ipCommunityName"> Name of the IP Community. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipCommunityName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipCommunityName"/> is null. </exception>
        public virtual Response<bool> Exists(string ipCommunityName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipCommunityName, nameof(ipCommunityName));

            using var scope = _networkFabricIPCommunityIPCommunitiesClientDiagnostics.CreateScope("NetworkFabricIPCommunityCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkFabricIPCommunityIPCommunitiesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, ipCommunityName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkFabricIPCommunityResource> IEnumerable<NetworkFabricIPCommunityResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkFabricIPCommunityResource> IAsyncEnumerable<NetworkFabricIPCommunityResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
