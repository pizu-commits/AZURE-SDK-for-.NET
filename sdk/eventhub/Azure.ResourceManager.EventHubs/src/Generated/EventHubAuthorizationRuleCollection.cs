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
    /// A class representing a collection of <see cref="EventHubAuthorizationRuleResource"/> and their operations.
    /// Each <see cref="EventHubAuthorizationRuleResource"/> in the collection will belong to the same instance of <see cref="EventHubResource"/>.
    /// To get an <see cref="EventHubAuthorizationRuleCollection"/> instance call the GetEventHubAuthorizationRules method from an instance of <see cref="EventHubResource"/>.
    /// </summary>
    public partial class EventHubAuthorizationRuleCollection : ArmCollection, IEnumerable<EventHubAuthorizationRuleResource>, IAsyncEnumerable<EventHubAuthorizationRuleResource>
    {
        private readonly ClientDiagnostics _eventHubAuthorizationRuleEventHubsClientDiagnostics;
        private readonly EventHubsRestOperations _eventHubAuthorizationRuleEventHubsRestClient;

        /// <summary> Initializes a new instance of the <see cref="EventHubAuthorizationRuleCollection"/> class for mocking. </summary>
        protected EventHubAuthorizationRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="EventHubAuthorizationRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal EventHubAuthorizationRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _eventHubAuthorizationRuleEventHubsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventHubs", EventHubAuthorizationRuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(EventHubAuthorizationRuleResource.ResourceType, out string eventHubAuthorizationRuleEventHubsApiVersion);
            _eventHubAuthorizationRuleEventHubsRestClient = new EventHubsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, eventHubAuthorizationRuleEventHubsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != EventHubResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, EventHubResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an AuthorizationRule for the specified Event Hub. Creation/update of the AuthorizationRule will take a few seconds to take effect.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}/authorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EventHubs_CreateOrUpdateAuthorizationRule</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubAuthorizationRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="data"> The shared access AuthorizationRule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<EventHubAuthorizationRuleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string authorizationRuleName, EventHubsAuthorizationRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _eventHubAuthorizationRuleEventHubsClientDiagnostics.CreateScope("EventHubAuthorizationRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _eventHubAuthorizationRuleEventHubsRestClient.CreateOrUpdateAuthorizationRuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, data, cancellationToken).ConfigureAwait(false);
                var uri = _eventHubAuthorizationRuleEventHubsRestClient.CreateCreateOrUpdateAuthorizationRuleRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new EventHubsArmOperation<EventHubAuthorizationRuleResource>(Response.FromValue(new EventHubAuthorizationRuleResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Creates or updates an AuthorizationRule for the specified Event Hub. Creation/update of the AuthorizationRule will take a few seconds to take effect.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}/authorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EventHubs_CreateOrUpdateAuthorizationRule</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubAuthorizationRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="data"> The shared access AuthorizationRule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<EventHubAuthorizationRuleResource> CreateOrUpdate(WaitUntil waitUntil, string authorizationRuleName, EventHubsAuthorizationRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _eventHubAuthorizationRuleEventHubsClientDiagnostics.CreateScope("EventHubAuthorizationRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _eventHubAuthorizationRuleEventHubsRestClient.CreateOrUpdateAuthorizationRule(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, data, cancellationToken);
                var uri = _eventHubAuthorizationRuleEventHubsRestClient.CreateCreateOrUpdateAuthorizationRuleRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new EventHubsArmOperation<EventHubAuthorizationRuleResource>(Response.FromValue(new EventHubAuthorizationRuleResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Gets an AuthorizationRule for an Event Hub by rule name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}/authorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EventHubs_GetAuthorizationRule</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubAuthorizationRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual async Task<Response<EventHubAuthorizationRuleResource>> GetAsync(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _eventHubAuthorizationRuleEventHubsClientDiagnostics.CreateScope("EventHubAuthorizationRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _eventHubAuthorizationRuleEventHubsRestClient.GetAuthorizationRuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EventHubAuthorizationRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an AuthorizationRule for an Event Hub by rule name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}/authorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EventHubs_GetAuthorizationRule</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubAuthorizationRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual Response<EventHubAuthorizationRuleResource> Get(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _eventHubAuthorizationRuleEventHubsClientDiagnostics.CreateScope("EventHubAuthorizationRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _eventHubAuthorizationRuleEventHubsRestClient.GetAuthorizationRule(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EventHubAuthorizationRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the authorization rules for an Event Hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}/authorizationRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EventHubs_ListAuthorizationRules</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubAuthorizationRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EventHubAuthorizationRuleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EventHubAuthorizationRuleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _eventHubAuthorizationRuleEventHubsRestClient.CreateListAuthorizationRulesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _eventHubAuthorizationRuleEventHubsRestClient.CreateListAuthorizationRulesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new EventHubAuthorizationRuleResource(Client, EventHubsAuthorizationRuleData.DeserializeEventHubsAuthorizationRuleData(e)), _eventHubAuthorizationRuleEventHubsClientDiagnostics, Pipeline, "EventHubAuthorizationRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the authorization rules for an Event Hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}/authorizationRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EventHubs_ListAuthorizationRules</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubAuthorizationRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EventHubAuthorizationRuleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EventHubAuthorizationRuleResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _eventHubAuthorizationRuleEventHubsRestClient.CreateListAuthorizationRulesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _eventHubAuthorizationRuleEventHubsRestClient.CreateListAuthorizationRulesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new EventHubAuthorizationRuleResource(Client, EventHubsAuthorizationRuleData.DeserializeEventHubsAuthorizationRuleData(e)), _eventHubAuthorizationRuleEventHubsClientDiagnostics, Pipeline, "EventHubAuthorizationRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}/authorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EventHubs_GetAuthorizationRule</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubAuthorizationRuleResource"/></description>
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

            using var scope = _eventHubAuthorizationRuleEventHubsClientDiagnostics.CreateScope("EventHubAuthorizationRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _eventHubAuthorizationRuleEventHubsRestClient.GetAuthorizationRuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}/authorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EventHubs_GetAuthorizationRule</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubAuthorizationRuleResource"/></description>
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

            using var scope = _eventHubAuthorizationRuleEventHubsClientDiagnostics.CreateScope("EventHubAuthorizationRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = _eventHubAuthorizationRuleEventHubsRestClient.GetAuthorizationRule(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}/authorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EventHubs_GetAuthorizationRule</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubAuthorizationRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual async Task<NullableResponse<EventHubAuthorizationRuleResource>> GetIfExistsAsync(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _eventHubAuthorizationRuleEventHubsClientDiagnostics.CreateScope("EventHubAuthorizationRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _eventHubAuthorizationRuleEventHubsRestClient.GetAuthorizationRuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<EventHubAuthorizationRuleResource>(response.GetRawResponse());
                return Response.FromValue(new EventHubAuthorizationRuleResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}/authorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EventHubs_GetAuthorizationRule</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubAuthorizationRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual NullableResponse<EventHubAuthorizationRuleResource> GetIfExists(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _eventHubAuthorizationRuleEventHubsClientDiagnostics.CreateScope("EventHubAuthorizationRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _eventHubAuthorizationRuleEventHubsRestClient.GetAuthorizationRule(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<EventHubAuthorizationRuleResource>(response.GetRawResponse());
                return Response.FromValue(new EventHubAuthorizationRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<EventHubAuthorizationRuleResource> IEnumerable<EventHubAuthorizationRuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<EventHubAuthorizationRuleResource> IAsyncEnumerable<EventHubAuthorizationRuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
