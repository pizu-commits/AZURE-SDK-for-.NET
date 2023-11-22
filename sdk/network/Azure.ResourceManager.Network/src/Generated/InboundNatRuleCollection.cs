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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="InboundNatRuleResource"/> and their operations.
    /// Each <see cref="InboundNatRuleResource"/> in the collection will belong to the same instance of <see cref="LoadBalancerResource"/>.
    /// To get an <see cref="InboundNatRuleCollection"/> instance call the GetInboundNatRules method from an instance of <see cref="LoadBalancerResource"/>.
    /// </summary>
    public partial class InboundNatRuleCollection : ArmCollection, IEnumerable<InboundNatRuleResource>, IAsyncEnumerable<InboundNatRuleResource>
    {
        private readonly ClientDiagnostics _inboundNatRuleClientDiagnostics;
        private readonly InboundNatRulesRestOperations _inboundNatRuleRestClient;

        /// <summary> Initializes a new instance of the <see cref="InboundNatRuleCollection"/> class for mocking. </summary>
        protected InboundNatRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="InboundNatRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal InboundNatRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _inboundNatRuleClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", InboundNatRuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(InboundNatRuleResource.ResourceType, out string inboundNatRuleApiVersion);
            _inboundNatRuleRestClient = new InboundNatRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, inboundNatRuleApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != LoadBalancerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, LoadBalancerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a load balancer inbound NAT rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/inboundNatRules/{inboundNatRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InboundNatRules_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="inboundNatRuleName"> The name of the inbound NAT rule. </param>
        /// <param name="data"> Parameters supplied to the create or update inbound NAT rule operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inboundNatRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inboundNatRuleName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<InboundNatRuleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string inboundNatRuleName, InboundNatRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inboundNatRuleName, nameof(inboundNatRuleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _inboundNatRuleClientDiagnostics.CreateScope("InboundNatRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _inboundNatRuleRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inboundNatRuleName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<InboundNatRuleResource>(new InboundNatRuleOperationSource(Client), _inboundNatRuleClientDiagnostics, Pipeline, _inboundNatRuleRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inboundNatRuleName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a load balancer inbound NAT rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/inboundNatRules/{inboundNatRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InboundNatRules_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="inboundNatRuleName"> The name of the inbound NAT rule. </param>
        /// <param name="data"> Parameters supplied to the create or update inbound NAT rule operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inboundNatRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inboundNatRuleName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<InboundNatRuleResource> CreateOrUpdate(WaitUntil waitUntil, string inboundNatRuleName, InboundNatRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inboundNatRuleName, nameof(inboundNatRuleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _inboundNatRuleClientDiagnostics.CreateScope("InboundNatRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _inboundNatRuleRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inboundNatRuleName, data, cancellationToken);
                var operation = new NetworkArmOperation<InboundNatRuleResource>(new InboundNatRuleOperationSource(Client), _inboundNatRuleClientDiagnostics, Pipeline, _inboundNatRuleRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inboundNatRuleName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the specified load balancer inbound NAT rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/inboundNatRules/{inboundNatRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InboundNatRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="inboundNatRuleName"> The name of the inbound NAT rule. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inboundNatRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inboundNatRuleName"/> is null. </exception>
        public virtual async Task<Response<InboundNatRuleResource>> GetAsync(string inboundNatRuleName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inboundNatRuleName, nameof(inboundNatRuleName));

            using var scope = _inboundNatRuleClientDiagnostics.CreateScope("InboundNatRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _inboundNatRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inboundNatRuleName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new InboundNatRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified load balancer inbound NAT rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/inboundNatRules/{inboundNatRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InboundNatRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="inboundNatRuleName"> The name of the inbound NAT rule. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inboundNatRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inboundNatRuleName"/> is null. </exception>
        public virtual Response<InboundNatRuleResource> Get(string inboundNatRuleName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inboundNatRuleName, nameof(inboundNatRuleName));

            using var scope = _inboundNatRuleClientDiagnostics.CreateScope("InboundNatRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _inboundNatRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inboundNatRuleName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new InboundNatRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all the inbound NAT rules in a load balancer.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/inboundNatRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InboundNatRules_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="InboundNatRuleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<InboundNatRuleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _inboundNatRuleRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _inboundNatRuleRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new InboundNatRuleResource(Client, InboundNatRuleData.DeserializeInboundNatRuleData(e)), _inboundNatRuleClientDiagnostics, Pipeline, "InboundNatRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all the inbound NAT rules in a load balancer.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/inboundNatRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InboundNatRules_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="InboundNatRuleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<InboundNatRuleResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _inboundNatRuleRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _inboundNatRuleRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new InboundNatRuleResource(Client, InboundNatRuleData.DeserializeInboundNatRuleData(e)), _inboundNatRuleClientDiagnostics, Pipeline, "InboundNatRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/inboundNatRules/{inboundNatRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InboundNatRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="inboundNatRuleName"> The name of the inbound NAT rule. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inboundNatRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inboundNatRuleName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string inboundNatRuleName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inboundNatRuleName, nameof(inboundNatRuleName));

            using var scope = _inboundNatRuleClientDiagnostics.CreateScope("InboundNatRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _inboundNatRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inboundNatRuleName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/inboundNatRules/{inboundNatRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InboundNatRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="inboundNatRuleName"> The name of the inbound NAT rule. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inboundNatRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inboundNatRuleName"/> is null. </exception>
        public virtual Response<bool> Exists(string inboundNatRuleName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inboundNatRuleName, nameof(inboundNatRuleName));

            using var scope = _inboundNatRuleClientDiagnostics.CreateScope("InboundNatRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = _inboundNatRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inboundNatRuleName, expand, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/inboundNatRules/{inboundNatRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InboundNatRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="inboundNatRuleName"> The name of the inbound NAT rule. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inboundNatRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inboundNatRuleName"/> is null. </exception>
        public virtual async Task<NullableResponse<InboundNatRuleResource>> GetIfExistsAsync(string inboundNatRuleName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inboundNatRuleName, nameof(inboundNatRuleName));

            using var scope = _inboundNatRuleClientDiagnostics.CreateScope("InboundNatRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _inboundNatRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inboundNatRuleName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<InboundNatRuleResource>(response.GetRawResponse());
                return Response.FromValue(new InboundNatRuleResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/inboundNatRules/{inboundNatRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InboundNatRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="inboundNatRuleName"> The name of the inbound NAT rule. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inboundNatRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inboundNatRuleName"/> is null. </exception>
        public virtual NullableResponse<InboundNatRuleResource> GetIfExists(string inboundNatRuleName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inboundNatRuleName, nameof(inboundNatRuleName));

            using var scope = _inboundNatRuleClientDiagnostics.CreateScope("InboundNatRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _inboundNatRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inboundNatRuleName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<InboundNatRuleResource>(response.GetRawResponse());
                return Response.FromValue(new InboundNatRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<InboundNatRuleResource> IEnumerable<InboundNatRuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<InboundNatRuleResource> IAsyncEnumerable<InboundNatRuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
