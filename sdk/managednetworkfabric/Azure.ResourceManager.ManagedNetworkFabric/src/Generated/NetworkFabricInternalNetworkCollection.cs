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

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    /// <summary>
    /// A class representing a collection of <see cref="NetworkFabricInternalNetworkResource" /> and their operations.
    /// Each <see cref="NetworkFabricInternalNetworkResource" /> in the collection will belong to the same instance of <see cref="NetworkFabricL3IsolationDomainResource" />.
    /// To get a <see cref="NetworkFabricInternalNetworkCollection" /> instance call the GetNetworkFabricInternalNetworks method from an instance of <see cref="NetworkFabricL3IsolationDomainResource" />.
    /// </summary>
    public partial class NetworkFabricInternalNetworkCollection : ArmCollection, IEnumerable<NetworkFabricInternalNetworkResource>, IAsyncEnumerable<NetworkFabricInternalNetworkResource>
    {
        private readonly ClientDiagnostics _networkFabricInternalNetworkInternalNetworksClientDiagnostics;
        private readonly InternalNetworksRestOperations _networkFabricInternalNetworkInternalNetworksRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkFabricInternalNetworkCollection"/> class for mocking. </summary>
        protected NetworkFabricInternalNetworkCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkFabricInternalNetworkCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkFabricInternalNetworkCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkFabricInternalNetworkInternalNetworksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ManagedNetworkFabric", NetworkFabricInternalNetworkResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkFabricInternalNetworkResource.ResourceType, out string networkFabricInternalNetworkInternalNetworksApiVersion);
            _networkFabricInternalNetworkInternalNetworksRestClient = new InternalNetworksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkFabricInternalNetworkInternalNetworksApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NetworkFabricL3IsolationDomainResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NetworkFabricL3IsolationDomainResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates InternalNetwork PUT method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/l3IsolationDomains/{l3IsolationDomainName}/internalNetworks/{internalNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InternalNetworks_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="internalNetworkName"> Name of the Internal Network. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="internalNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="internalNetworkName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetworkFabricInternalNetworkResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string internalNetworkName, NetworkFabricInternalNetworkData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(internalNetworkName, nameof(internalNetworkName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkFabricInternalNetworkInternalNetworksClientDiagnostics.CreateScope("NetworkFabricInternalNetworkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkFabricInternalNetworkInternalNetworksRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, internalNetworkName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ManagedNetworkFabricArmOperation<NetworkFabricInternalNetworkResource>(new NetworkFabricInternalNetworkOperationSource(Client), _networkFabricInternalNetworkInternalNetworksClientDiagnostics, Pipeline, _networkFabricInternalNetworkInternalNetworksRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, internalNetworkName, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates InternalNetwork PUT method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/l3IsolationDomains/{l3IsolationDomainName}/internalNetworks/{internalNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InternalNetworks_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="internalNetworkName"> Name of the Internal Network. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="internalNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="internalNetworkName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetworkFabricInternalNetworkResource> CreateOrUpdate(WaitUntil waitUntil, string internalNetworkName, NetworkFabricInternalNetworkData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(internalNetworkName, nameof(internalNetworkName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkFabricInternalNetworkInternalNetworksClientDiagnostics.CreateScope("NetworkFabricInternalNetworkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkFabricInternalNetworkInternalNetworksRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, internalNetworkName, data, cancellationToken);
                var operation = new ManagedNetworkFabricArmOperation<NetworkFabricInternalNetworkResource>(new NetworkFabricInternalNetworkOperationSource(Client), _networkFabricInternalNetworkInternalNetworksClientDiagnostics, Pipeline, _networkFabricInternalNetworkInternalNetworksRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, internalNetworkName, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets a InternalNetworks.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/l3IsolationDomains/{l3IsolationDomainName}/internalNetworks/{internalNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InternalNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="internalNetworkName"> Name of the Internal Network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="internalNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="internalNetworkName"/> is null. </exception>
        public virtual async Task<Response<NetworkFabricInternalNetworkResource>> GetAsync(string internalNetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(internalNetworkName, nameof(internalNetworkName));

            using var scope = _networkFabricInternalNetworkInternalNetworksClientDiagnostics.CreateScope("NetworkFabricInternalNetworkCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkFabricInternalNetworkInternalNetworksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, internalNetworkName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkFabricInternalNetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a InternalNetworks.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/l3IsolationDomains/{l3IsolationDomainName}/internalNetworks/{internalNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InternalNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="internalNetworkName"> Name of the Internal Network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="internalNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="internalNetworkName"/> is null. </exception>
        public virtual Response<NetworkFabricInternalNetworkResource> Get(string internalNetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(internalNetworkName, nameof(internalNetworkName));

            using var scope = _networkFabricInternalNetworkInternalNetworksClientDiagnostics.CreateScope("NetworkFabricInternalNetworkCollection.Get");
            scope.Start();
            try
            {
                var response = _networkFabricInternalNetworkInternalNetworksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, internalNetworkName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkFabricInternalNetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Displays InternalNetworks list by resource group GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/l3IsolationDomains/{l3IsolationDomainName}/internalNetworks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InternalNetworks_ListByL3IsolationDomain</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkFabricInternalNetworkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkFabricInternalNetworkResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkFabricInternalNetworkInternalNetworksRestClient.CreateListByL3IsolationDomainRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkFabricInternalNetworkInternalNetworksRestClient.CreateListByL3IsolationDomainNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetworkFabricInternalNetworkResource(Client, NetworkFabricInternalNetworkData.DeserializeNetworkFabricInternalNetworkData(e)), _networkFabricInternalNetworkInternalNetworksClientDiagnostics, Pipeline, "NetworkFabricInternalNetworkCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Displays InternalNetworks list by resource group GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/l3IsolationDomains/{l3IsolationDomainName}/internalNetworks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InternalNetworks_ListByL3IsolationDomain</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkFabricInternalNetworkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkFabricInternalNetworkResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkFabricInternalNetworkInternalNetworksRestClient.CreateListByL3IsolationDomainRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkFabricInternalNetworkInternalNetworksRestClient.CreateListByL3IsolationDomainNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetworkFabricInternalNetworkResource(Client, NetworkFabricInternalNetworkData.DeserializeNetworkFabricInternalNetworkData(e)), _networkFabricInternalNetworkInternalNetworksClientDiagnostics, Pipeline, "NetworkFabricInternalNetworkCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/l3IsolationDomains/{l3IsolationDomainName}/internalNetworks/{internalNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InternalNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="internalNetworkName"> Name of the Internal Network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="internalNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="internalNetworkName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string internalNetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(internalNetworkName, nameof(internalNetworkName));

            using var scope = _networkFabricInternalNetworkInternalNetworksClientDiagnostics.CreateScope("NetworkFabricInternalNetworkCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkFabricInternalNetworkInternalNetworksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, internalNetworkName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/l3IsolationDomains/{l3IsolationDomainName}/internalNetworks/{internalNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InternalNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="internalNetworkName"> Name of the Internal Network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="internalNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="internalNetworkName"/> is null. </exception>
        public virtual Response<bool> Exists(string internalNetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(internalNetworkName, nameof(internalNetworkName));

            using var scope = _networkFabricInternalNetworkInternalNetworksClientDiagnostics.CreateScope("NetworkFabricInternalNetworkCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkFabricInternalNetworkInternalNetworksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, internalNetworkName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkFabricInternalNetworkResource> IEnumerable<NetworkFabricInternalNetworkResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkFabricInternalNetworkResource> IAsyncEnumerable<NetworkFabricInternalNetworkResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
