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
    /// A class representing a collection of <see cref="NetworkTapRuleResource" /> and their operations.
    /// Each <see cref="NetworkTapRuleResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="NetworkTapRuleCollection" /> instance call the GetNetworkTapRules method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class NetworkTapRuleCollection : ArmCollection, IEnumerable<NetworkTapRuleResource>, IAsyncEnumerable<NetworkTapRuleResource>
    {
        private readonly ClientDiagnostics _networkTapRuleClientDiagnostics;
        private readonly NetworkTapRulesRestOperations _networkTapRuleRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkTapRuleCollection"/> class for mocking. </summary>
        protected NetworkTapRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkTapRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkTapRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkTapRuleClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ManagedNetworkFabric", NetworkTapRuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkTapRuleResource.ResourceType, out string networkTapRuleApiVersion);
            _networkTapRuleRestClient = new NetworkTapRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkTapRuleApiVersion);
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
        /// Create Network Tap Rule resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkTapRules/{networkTapRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkTapRules_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="networkTapRuleName"> Name of the Network Tap Rule. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkTapRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkTapRuleName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetworkTapRuleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string networkTapRuleName, NetworkTapRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkTapRuleName, nameof(networkTapRuleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkTapRuleClientDiagnostics.CreateScope("NetworkTapRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkTapRuleRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, networkTapRuleName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ManagedNetworkFabricArmOperation<NetworkTapRuleResource>(new NetworkTapRuleOperationSource(Client), _networkTapRuleClientDiagnostics, Pipeline, _networkTapRuleRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, networkTapRuleName, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create Network Tap Rule resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkTapRules/{networkTapRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkTapRules_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="networkTapRuleName"> Name of the Network Tap Rule. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkTapRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkTapRuleName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetworkTapRuleResource> CreateOrUpdate(WaitUntil waitUntil, string networkTapRuleName, NetworkTapRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkTapRuleName, nameof(networkTapRuleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkTapRuleClientDiagnostics.CreateScope("NetworkTapRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkTapRuleRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, networkTapRuleName, data, cancellationToken);
                var operation = new ManagedNetworkFabricArmOperation<NetworkTapRuleResource>(new NetworkTapRuleOperationSource(Client), _networkTapRuleClientDiagnostics, Pipeline, _networkTapRuleRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, networkTapRuleName, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get Network Tap Rule resource details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkTapRules/{networkTapRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkTapRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkTapRuleName"> Name of the Network Tap Rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkTapRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkTapRuleName"/> is null. </exception>
        public virtual async Task<Response<NetworkTapRuleResource>> GetAsync(string networkTapRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkTapRuleName, nameof(networkTapRuleName));

            using var scope = _networkTapRuleClientDiagnostics.CreateScope("NetworkTapRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkTapRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, networkTapRuleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkTapRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get Network Tap Rule resource details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkTapRules/{networkTapRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkTapRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkTapRuleName"> Name of the Network Tap Rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkTapRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkTapRuleName"/> is null. </exception>
        public virtual Response<NetworkTapRuleResource> Get(string networkTapRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkTapRuleName, nameof(networkTapRuleName));

            using var scope = _networkTapRuleClientDiagnostics.CreateScope("NetworkTapRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _networkTapRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, networkTapRuleName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkTapRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all the Network Tap Rule resources in the given resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkTapRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkTapRules_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkTapRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkTapRuleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkTapRuleRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkTapRuleRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetworkTapRuleResource(Client, NetworkTapRuleData.DeserializeNetworkTapRuleData(e)), _networkTapRuleClientDiagnostics, Pipeline, "NetworkTapRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all the Network Tap Rule resources in the given resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkTapRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkTapRules_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkTapRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkTapRuleResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkTapRuleRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkTapRuleRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetworkTapRuleResource(Client, NetworkTapRuleData.DeserializeNetworkTapRuleData(e)), _networkTapRuleClientDiagnostics, Pipeline, "NetworkTapRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkTapRules/{networkTapRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkTapRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkTapRuleName"> Name of the Network Tap Rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkTapRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkTapRuleName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string networkTapRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkTapRuleName, nameof(networkTapRuleName));

            using var scope = _networkTapRuleClientDiagnostics.CreateScope("NetworkTapRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkTapRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, networkTapRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkTapRules/{networkTapRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkTapRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkTapRuleName"> Name of the Network Tap Rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkTapRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkTapRuleName"/> is null. </exception>
        public virtual Response<bool> Exists(string networkTapRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkTapRuleName, nameof(networkTapRuleName));

            using var scope = _networkTapRuleClientDiagnostics.CreateScope("NetworkTapRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkTapRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, networkTapRuleName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkTapRuleResource> IEnumerable<NetworkTapRuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkTapRuleResource> IAsyncEnumerable<NetworkTapRuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
