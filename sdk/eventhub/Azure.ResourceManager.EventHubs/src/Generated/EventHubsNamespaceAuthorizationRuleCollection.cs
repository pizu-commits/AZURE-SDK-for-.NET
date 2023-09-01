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

namespace Azure.ResourceManager.EventHubs
{
    /// <summary>
    /// A class representing a collection of <see cref="EventHubsNamespaceAuthorizationRuleResource" /> and their operations.
    /// Each <see cref="EventHubsNamespaceAuthorizationRuleResource" /> in the collection will belong to the same instance of <see cref="EventHubsNamespaceResource" />.
    /// To get an <see cref="EventHubsNamespaceAuthorizationRuleCollection" /> instance call the GetEventHubsNamespaceAuthorizationRules method from an instance of <see cref="EventHubsNamespaceResource" />.
    /// </summary>
    public partial class EventHubsNamespaceAuthorizationRuleCollection : ArmCollection, IEnumerable<EventHubsNamespaceAuthorizationRuleResource>, IAsyncEnumerable<EventHubsNamespaceAuthorizationRuleResource>
    {
        private readonly ClientDiagnostics _eventHubsNamespaceAuthorizationRuleNamespacesClientDiagnostics;
        private readonly NamespacesRestOperations _eventHubsNamespaceAuthorizationRuleNamespacesRestClient;

        /// <summary> Initializes a new instance of the <see cref="EventHubsNamespaceAuthorizationRuleCollection"/> class for mocking. </summary>
        protected EventHubsNamespaceAuthorizationRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="EventHubsNamespaceAuthorizationRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal EventHubsNamespaceAuthorizationRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _eventHubsNamespaceAuthorizationRuleNamespacesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventHubs", EventHubsNamespaceAuthorizationRuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(EventHubsNamespaceAuthorizationRuleResource.ResourceType, out string eventHubsNamespaceAuthorizationRuleNamespacesApiVersion);
            _eventHubsNamespaceAuthorizationRuleNamespacesRestClient = new NamespacesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, eventHubsNamespaceAuthorizationRuleNamespacesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != EventHubsNamespaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, EventHubsNamespaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an AuthorizationRule for a Namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/authorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_CreateOrUpdateAuthorizationRule</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="data"> The shared access AuthorizationRule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<EventHubsNamespaceAuthorizationRuleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string authorizationRuleName, EventHubsAuthorizationRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _eventHubsNamespaceAuthorizationRuleNamespacesClientDiagnostics.CreateScope("EventHubsNamespaceAuthorizationRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _eventHubsNamespaceAuthorizationRuleNamespacesRestClient.CreateOrUpdateAuthorizationRuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationRuleName, data, cancellationToken).ConfigureAwait(false);
                var operation = new EventHubsArmOperation<EventHubsNamespaceAuthorizationRuleResource>(Response.FromValue(new EventHubsNamespaceAuthorizationRuleResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates an AuthorizationRule for a Namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/authorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_CreateOrUpdateAuthorizationRule</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="data"> The shared access AuthorizationRule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<EventHubsNamespaceAuthorizationRuleResource> CreateOrUpdate(WaitUntil waitUntil, string authorizationRuleName, EventHubsAuthorizationRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _eventHubsNamespaceAuthorizationRuleNamespacesClientDiagnostics.CreateScope("EventHubsNamespaceAuthorizationRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _eventHubsNamespaceAuthorizationRuleNamespacesRestClient.CreateOrUpdateAuthorizationRule(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationRuleName, data, cancellationToken);
                var operation = new EventHubsArmOperation<EventHubsNamespaceAuthorizationRuleResource>(Response.FromValue(new EventHubsNamespaceAuthorizationRuleResource(Client, response), response.GetRawResponse()));
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
        /// Gets an AuthorizationRule for a Namespace by rule name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/authorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_GetAuthorizationRule</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual async Task<Response<EventHubsNamespaceAuthorizationRuleResource>> GetAsync(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _eventHubsNamespaceAuthorizationRuleNamespacesClientDiagnostics.CreateScope("EventHubsNamespaceAuthorizationRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _eventHubsNamespaceAuthorizationRuleNamespacesRestClient.GetAuthorizationRuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationRuleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EventHubsNamespaceAuthorizationRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an AuthorizationRule for a Namespace by rule name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/authorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_GetAuthorizationRule</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual Response<EventHubsNamespaceAuthorizationRuleResource> Get(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _eventHubsNamespaceAuthorizationRuleNamespacesClientDiagnostics.CreateScope("EventHubsNamespaceAuthorizationRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _eventHubsNamespaceAuthorizationRuleNamespacesRestClient.GetAuthorizationRule(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationRuleName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EventHubsNamespaceAuthorizationRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of authorization rules for a Namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/authorizationRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_ListAuthorizationRules</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EventHubsNamespaceAuthorizationRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EventHubsNamespaceAuthorizationRuleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _eventHubsNamespaceAuthorizationRuleNamespacesRestClient.CreateListAuthorizationRulesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _eventHubsNamespaceAuthorizationRuleNamespacesRestClient.CreateListAuthorizationRulesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new EventHubsNamespaceAuthorizationRuleResource(Client, EventHubsAuthorizationRuleData.DeserializeEventHubsAuthorizationRuleData(e)), _eventHubsNamespaceAuthorizationRuleNamespacesClientDiagnostics, Pipeline, "EventHubsNamespaceAuthorizationRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of authorization rules for a Namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/authorizationRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_ListAuthorizationRules</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EventHubsNamespaceAuthorizationRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EventHubsNamespaceAuthorizationRuleResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _eventHubsNamespaceAuthorizationRuleNamespacesRestClient.CreateListAuthorizationRulesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _eventHubsNamespaceAuthorizationRuleNamespacesRestClient.CreateListAuthorizationRulesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new EventHubsNamespaceAuthorizationRuleResource(Client, EventHubsAuthorizationRuleData.DeserializeEventHubsAuthorizationRuleData(e)), _eventHubsNamespaceAuthorizationRuleNamespacesClientDiagnostics, Pipeline, "EventHubsNamespaceAuthorizationRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/authorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_GetAuthorizationRule</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _eventHubsNamespaceAuthorizationRuleNamespacesClientDiagnostics.CreateScope("EventHubsNamespaceAuthorizationRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _eventHubsNamespaceAuthorizationRuleNamespacesRestClient.GetAuthorizationRuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/authorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_GetAuthorizationRule</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual Response<bool> Exists(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _eventHubsNamespaceAuthorizationRuleNamespacesClientDiagnostics.CreateScope("EventHubsNamespaceAuthorizationRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = _eventHubsNamespaceAuthorizationRuleNamespacesRestClient.GetAuthorizationRule(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationRuleName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<EventHubsNamespaceAuthorizationRuleResource> IEnumerable<EventHubsNamespaceAuthorizationRuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<EventHubsNamespaceAuthorizationRuleResource> IAsyncEnumerable<EventHubsNamespaceAuthorizationRuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
