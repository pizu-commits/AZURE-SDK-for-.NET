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

namespace Azure.ResourceManager.HybridContainerService
{
    /// <summary>
    /// A class representing a collection of <see cref="HybridContainerServiceVirtualNetworkResource" /> and their operations.
    /// Each <see cref="HybridContainerServiceVirtualNetworkResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="HybridContainerServiceVirtualNetworkCollection" /> instance call the GetHybridContainerServiceVirtualNetworks method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class HybridContainerServiceVirtualNetworkCollection : ArmCollection, IEnumerable<HybridContainerServiceVirtualNetworkResource>, IAsyncEnumerable<HybridContainerServiceVirtualNetworkResource>
    {
        private readonly ClientDiagnostics _hybridContainerServiceVirtualNetworkvirtualNetworksClientDiagnostics;
        private readonly VirtualNetworksRestOperations _hybridContainerServiceVirtualNetworkvirtualNetworksRestClient;

        /// <summary> Initializes a new instance of the <see cref="HybridContainerServiceVirtualNetworkCollection"/> class for mocking. </summary>
        protected HybridContainerServiceVirtualNetworkCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HybridContainerServiceVirtualNetworkCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal HybridContainerServiceVirtualNetworkCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _hybridContainerServiceVirtualNetworkvirtualNetworksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HybridContainerService", HybridContainerServiceVirtualNetworkResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(HybridContainerServiceVirtualNetworkResource.ResourceType, out string hybridContainerServiceVirtualNetworkvirtualNetworksApiVersion);
            _hybridContainerServiceVirtualNetworkvirtualNetworksRestClient = new VirtualNetworksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, hybridContainerServiceVirtualNetworkvirtualNetworksApiVersion);
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
        /// Puts the Hybrid AKS virtual network
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridContainerService/virtualNetworks/{virtualNetworksName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>virtualNetworks_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="virtualNetworksName"> Parameter for the name of the virtual network. </param>
        /// <param name="data"> The HybridContainerServiceVirtualNetwork to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworksName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworksName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<HybridContainerServiceVirtualNetworkResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string virtualNetworksName, HybridContainerServiceVirtualNetworkData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworksName, nameof(virtualNetworksName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hybridContainerServiceVirtualNetworkvirtualNetworksClientDiagnostics.CreateScope("HybridContainerServiceVirtualNetworkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _hybridContainerServiceVirtualNetworkvirtualNetworksRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworksName, data, cancellationToken).ConfigureAwait(false);
                var operation = new HybridContainerServiceArmOperation<HybridContainerServiceVirtualNetworkResource>(new HybridContainerServiceVirtualNetworkOperationSource(Client), _hybridContainerServiceVirtualNetworkvirtualNetworksClientDiagnostics, Pipeline, _hybridContainerServiceVirtualNetworkvirtualNetworksRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworksName, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Puts the Hybrid AKS virtual network
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridContainerService/virtualNetworks/{virtualNetworksName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>virtualNetworks_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="virtualNetworksName"> Parameter for the name of the virtual network. </param>
        /// <param name="data"> The HybridContainerServiceVirtualNetwork to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworksName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworksName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<HybridContainerServiceVirtualNetworkResource> CreateOrUpdate(WaitUntil waitUntil, string virtualNetworksName, HybridContainerServiceVirtualNetworkData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworksName, nameof(virtualNetworksName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hybridContainerServiceVirtualNetworkvirtualNetworksClientDiagnostics.CreateScope("HybridContainerServiceVirtualNetworkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _hybridContainerServiceVirtualNetworkvirtualNetworksRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworksName, data, cancellationToken);
                var operation = new HybridContainerServiceArmOperation<HybridContainerServiceVirtualNetworkResource>(new HybridContainerServiceVirtualNetworkOperationSource(Client), _hybridContainerServiceVirtualNetworkvirtualNetworksClientDiagnostics, Pipeline, _hybridContainerServiceVirtualNetworkvirtualNetworksRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworksName, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the Hybrid AKS virtual network
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridContainerService/virtualNetworks/{virtualNetworksName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>virtualNetworks_Retrieve</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworksName"> Parameter for the name of the virtual network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworksName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworksName"/> is null. </exception>
        public virtual async Task<Response<HybridContainerServiceVirtualNetworkResource>> GetAsync(string virtualNetworksName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworksName, nameof(virtualNetworksName));

            using var scope = _hybridContainerServiceVirtualNetworkvirtualNetworksClientDiagnostics.CreateScope("HybridContainerServiceVirtualNetworkCollection.Get");
            scope.Start();
            try
            {
                var response = await _hybridContainerServiceVirtualNetworkvirtualNetworksRestClient.RetrieveAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworksName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HybridContainerServiceVirtualNetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the Hybrid AKS virtual network
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridContainerService/virtualNetworks/{virtualNetworksName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>virtualNetworks_Retrieve</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworksName"> Parameter for the name of the virtual network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworksName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworksName"/> is null. </exception>
        public virtual Response<HybridContainerServiceVirtualNetworkResource> Get(string virtualNetworksName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworksName, nameof(virtualNetworksName));

            using var scope = _hybridContainerServiceVirtualNetworkvirtualNetworksClientDiagnostics.CreateScope("HybridContainerServiceVirtualNetworkCollection.Get");
            scope.Start();
            try
            {
                var response = _hybridContainerServiceVirtualNetworkvirtualNetworksRestClient.Retrieve(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworksName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HybridContainerServiceVirtualNetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the Hybrid AKS virtual networks by resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridContainerService/virtualNetworks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>virtualNetworks_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HybridContainerServiceVirtualNetworkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HybridContainerServiceVirtualNetworkResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hybridContainerServiceVirtualNetworkvirtualNetworksRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hybridContainerServiceVirtualNetworkvirtualNetworksRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new HybridContainerServiceVirtualNetworkResource(Client, HybridContainerServiceVirtualNetworkData.DeserializeHybridContainerServiceVirtualNetworkData(e)), _hybridContainerServiceVirtualNetworkvirtualNetworksClientDiagnostics, Pipeline, "HybridContainerServiceVirtualNetworkCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the Hybrid AKS virtual networks by resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridContainerService/virtualNetworks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>virtualNetworks_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HybridContainerServiceVirtualNetworkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HybridContainerServiceVirtualNetworkResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hybridContainerServiceVirtualNetworkvirtualNetworksRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hybridContainerServiceVirtualNetworkvirtualNetworksRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new HybridContainerServiceVirtualNetworkResource(Client, HybridContainerServiceVirtualNetworkData.DeserializeHybridContainerServiceVirtualNetworkData(e)), _hybridContainerServiceVirtualNetworkvirtualNetworksClientDiagnostics, Pipeline, "HybridContainerServiceVirtualNetworkCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridContainerService/virtualNetworks/{virtualNetworksName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>virtualNetworks_Retrieve</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworksName"> Parameter for the name of the virtual network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworksName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworksName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string virtualNetworksName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworksName, nameof(virtualNetworksName));

            using var scope = _hybridContainerServiceVirtualNetworkvirtualNetworksClientDiagnostics.CreateScope("HybridContainerServiceVirtualNetworkCollection.Exists");
            scope.Start();
            try
            {
                var response = await _hybridContainerServiceVirtualNetworkvirtualNetworksRestClient.RetrieveAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworksName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridContainerService/virtualNetworks/{virtualNetworksName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>virtualNetworks_Retrieve</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworksName"> Parameter for the name of the virtual network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworksName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworksName"/> is null. </exception>
        public virtual Response<bool> Exists(string virtualNetworksName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworksName, nameof(virtualNetworksName));

            using var scope = _hybridContainerServiceVirtualNetworkvirtualNetworksClientDiagnostics.CreateScope("HybridContainerServiceVirtualNetworkCollection.Exists");
            scope.Start();
            try
            {
                var response = _hybridContainerServiceVirtualNetworkvirtualNetworksRestClient.Retrieve(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworksName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<HybridContainerServiceVirtualNetworkResource> IEnumerable<HybridContainerServiceVirtualNetworkResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<HybridContainerServiceVirtualNetworkResource> IAsyncEnumerable<HybridContainerServiceVirtualNetworkResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
