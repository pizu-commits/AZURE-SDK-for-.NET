// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.EventHubs.Models;

namespace Azure.ResourceManager.EventHubs
{
    /// <summary>
    /// A Class representing an EventHubsDisasterRecoveryAuthorizationRule along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct an <see cref="EventHubsDisasterRecoveryAuthorizationRuleResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetEventHubsDisasterRecoveryAuthorizationRuleResource method.
    /// Otherwise you can get one from its parent resource <see cref="EventHubsDisasterRecoveryResource" /> using the GetEventHubsDisasterRecoveryAuthorizationRule method.
    /// </summary>
    public partial class EventHubsDisasterRecoveryAuthorizationRuleResource : EventHubsAuthorizationRuleResource
    {
        /// <summary> Generate the resource identifier of a <see cref="EventHubsDisasterRecoveryAuthorizationRuleResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string namespaceName, string @alias, string authorizationRuleName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/disasterRecoveryConfigs/{@alias}/authorizationRules/{authorizationRuleName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsClientDiagnostics;
        private readonly DisasterRecoveryConfigsRestOperations _eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsRestClient;

        /// <summary> Initializes a new instance of the <see cref="EventHubsDisasterRecoveryAuthorizationRuleResource"/> class for mocking. </summary>
        protected EventHubsDisasterRecoveryAuthorizationRuleResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "EventHubsDisasterRecoveryAuthorizationRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal EventHubsDisasterRecoveryAuthorizationRuleResource(ArmClient client, EventHubsAuthorizationRuleData data) : base(client, data)
        {
            _eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventHubs", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsApiVersion);
            _eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsRestClient = new DisasterRecoveryConfigsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="EventHubsDisasterRecoveryAuthorizationRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal EventHubsDisasterRecoveryAuthorizationRuleResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventHubs", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsApiVersion);
            _eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsRestClient = new DisasterRecoveryConfigsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.EventHub/namespaces/disasterRecoveryConfigs/authorizationRules";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Gets an AuthorizationRule for a Namespace by rule name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}/authorizationRules/{authorizationRuleName}
        /// Operation Id: DisasterRecoveryConfigs_GetAuthorizationRule
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<EventHubsAuthorizationRuleResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsClientDiagnostics.CreateScope("EventHubsDisasterRecoveryAuthorizationRuleResource.GetCore");
            scope.Start();
            try
            {
                var response = await _eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsRestClient.GetAuthorizationRuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an AuthorizationRule for a Namespace by rule name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}/authorizationRules/{authorizationRuleName}
        /// Operation Id: DisasterRecoveryConfigs_GetAuthorizationRule
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new async Task<Response<EventHubsDisasterRecoveryAuthorizationRuleResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var result = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((EventHubsDisasterRecoveryAuthorizationRuleResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Gets an AuthorizationRule for a Namespace by rule name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}/authorizationRules/{authorizationRuleName}
        /// Operation Id: DisasterRecoveryConfigs_GetAuthorizationRule
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<EventHubsAuthorizationRuleResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsClientDiagnostics.CreateScope("EventHubsDisasterRecoveryAuthorizationRuleResource.GetCore");
            scope.Start();
            try
            {
                var response = _eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsRestClient.GetAuthorizationRule(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an AuthorizationRule for a Namespace by rule name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}/authorizationRules/{authorizationRuleName}
        /// Operation Id: DisasterRecoveryConfigs_GetAuthorizationRule
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new Response<EventHubsDisasterRecoveryAuthorizationRuleResource> Get(CancellationToken cancellationToken = default)
        {
            var result = GetCore(cancellationToken);
            return Response.FromValue((EventHubsDisasterRecoveryAuthorizationRuleResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation GetKeys
        /// Gets the primary and secondary connection strings for the Namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}/authorizationRules/{authorizationRuleName}/listKeys
        /// Operation Id: DisasterRecoveryConfigs_ListKeys
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<EventHubsAccessKeys>> GetKeysCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsClientDiagnostics.CreateScope("EventHubsDisasterRecoveryAuthorizationRuleResource.GetKeysCore");
            scope.Start();
            try
            {
                var response = await _eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsRestClient.ListKeysAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The core implementation for operation GetKeys
        /// Gets the primary and secondary connection strings for the Namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}/authorizationRules/{authorizationRuleName}/listKeys
        /// Operation Id: DisasterRecoveryConfigs_ListKeys
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<EventHubsAccessKeys> GetKeysCore(CancellationToken cancellationToken = default)
        {
            using var scope = _eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsClientDiagnostics.CreateScope("EventHubsDisasterRecoveryAuthorizationRuleResource.GetKeysCore");
            scope.Start();
            try
            {
                var response = _eventHubsDisasterRecoveryAuthorizationRuleDisasterRecoveryConfigsRestClient.ListKeys(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
