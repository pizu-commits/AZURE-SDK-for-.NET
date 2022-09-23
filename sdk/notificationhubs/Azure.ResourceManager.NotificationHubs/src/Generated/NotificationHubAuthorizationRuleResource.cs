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
using Azure.ResourceManager.NotificationHubs.Models;

namespace Azure.ResourceManager.NotificationHubs
{
    /// <summary>
    /// A Class representing a NotificationHubAuthorizationRule along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="NotificationHubAuthorizationRuleResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetNotificationHubAuthorizationRuleResource method.
    /// Otherwise you can get one from its parent resource <see cref="NotificationHubResource" /> using the GetNotificationHubAuthorizationRule method.
    /// </summary>
    public partial class NotificationHubAuthorizationRuleResource : BaseNotificationHubAuthorizationRuleResource
    {
        /// <summary> Generate the resource identifier of a <see cref="NotificationHubAuthorizationRuleResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string namespaceName, string notificationHubName, string authorizationRuleName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}/notificationHubs/{notificationHubName}/AuthorizationRules/{authorizationRuleName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _notificationHubAuthorizationRuleNotificationHubsClientDiagnostics;
        private readonly NotificationHubsRestOperations _notificationHubAuthorizationRuleNotificationHubsRestClient;

        /// <summary> Initializes a new instance of the <see cref="NotificationHubAuthorizationRuleResource"/> class for mocking. </summary>
        protected NotificationHubAuthorizationRuleResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "NotificationHubAuthorizationRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal NotificationHubAuthorizationRuleResource(ArmClient client, NotificationHubAuthorizationRuleData data) : base(client, data)
        {
            _notificationHubAuthorizationRuleNotificationHubsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.NotificationHubs", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string notificationHubAuthorizationRuleNotificationHubsApiVersion);
            _notificationHubAuthorizationRuleNotificationHubsRestClient = new NotificationHubsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, notificationHubAuthorizationRuleNotificationHubsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="NotificationHubAuthorizationRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal NotificationHubAuthorizationRuleResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _notificationHubAuthorizationRuleNotificationHubsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.NotificationHubs", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string notificationHubAuthorizationRuleNotificationHubsApiVersion);
            _notificationHubAuthorizationRuleNotificationHubsRestClient = new NotificationHubsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, notificationHubAuthorizationRuleNotificationHubsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.NotificationHubs/namespaces/notificationHubs/AuthorizationRules";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Gets an authorization rule for a NotificationHub by name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}/notificationHubs/{notificationHubName}/AuthorizationRules/{authorizationRuleName}
        /// Operation Id: NotificationHubs_GetAuthorizationRule
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<BaseNotificationHubAuthorizationRuleResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _notificationHubAuthorizationRuleNotificationHubsClientDiagnostics.CreateScope("NotificationHubAuthorizationRuleResource.Get");
            scope.Start();
            try
            {
                var response = await _notificationHubAuthorizationRuleNotificationHubsRestClient.GetAuthorizationRuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// Gets an authorization rule for a NotificationHub by name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}/notificationHubs/{notificationHubName}/AuthorizationRules/{authorizationRuleName}
        /// Operation Id: NotificationHubs_GetAuthorizationRule
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new async Task<Response<NotificationHubAuthorizationRuleResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var result = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((NotificationHubAuthorizationRuleResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Gets an authorization rule for a NotificationHub by name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}/notificationHubs/{notificationHubName}/AuthorizationRules/{authorizationRuleName}
        /// Operation Id: NotificationHubs_GetAuthorizationRule
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<BaseNotificationHubAuthorizationRuleResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _notificationHubAuthorizationRuleNotificationHubsClientDiagnostics.CreateScope("NotificationHubAuthorizationRuleResource.Get");
            scope.Start();
            try
            {
                var response = _notificationHubAuthorizationRuleNotificationHubsRestClient.GetAuthorizationRule(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
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
        /// Gets an authorization rule for a NotificationHub by name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}/notificationHubs/{notificationHubName}/AuthorizationRules/{authorizationRuleName}
        /// Operation Id: NotificationHubs_GetAuthorizationRule
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new Response<NotificationHubAuthorizationRuleResource> Get(CancellationToken cancellationToken = default)
        {
            var result = GetCore(cancellationToken);
            return Response.FromValue((NotificationHubAuthorizationRuleResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation Delete
        /// Deletes a notificationHub authorization rule
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}/notificationHubs/{notificationHubName}/AuthorizationRules/{authorizationRuleName}
        /// Operation Id: NotificationHubs_DeleteAuthorizationRule
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<ArmOperation> DeleteCoreAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _notificationHubAuthorizationRuleNotificationHubsClientDiagnostics.CreateScope("NotificationHubAuthorizationRuleResource.Delete");
            scope.Start();
            try
            {
                var response = await _notificationHubAuthorizationRuleNotificationHubsRestClient.DeleteAuthorizationRuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new NotificationHubsArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The core implementation for operation Delete
        /// Deletes a notificationHub authorization rule
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}/notificationHubs/{notificationHubName}/AuthorizationRules/{authorizationRuleName}
        /// Operation Id: NotificationHubs_DeleteAuthorizationRule
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override ArmOperation DeleteCore(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _notificationHubAuthorizationRuleNotificationHubsClientDiagnostics.CreateScope("NotificationHubAuthorizationRuleResource.Delete");
            scope.Start();
            try
            {
                var response = _notificationHubAuthorizationRuleNotificationHubsRestClient.DeleteAuthorizationRule(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new NotificationHubsArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The core implementation for operation Update
        /// Creates/Updates an authorization rule for a NotificationHub
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}/notificationHubs/{notificationHubName}/AuthorizationRules/{authorizationRuleName}
        /// Operation Id: NotificationHubs_CreateOrUpdateAuthorizationRule
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The shared access authorization rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        protected override async Task<ArmOperation<BaseNotificationHubAuthorizationRuleResource>> UpdateCoreAsync(WaitUntil waitUntil, SharedAccessAuthorizationRuleCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _notificationHubAuthorizationRuleNotificationHubsClientDiagnostics.CreateScope("NotificationHubAuthorizationRuleResource.Update");
            scope.Start();
            try
            {
                var response = await _notificationHubAuthorizationRuleNotificationHubsRestClient.CreateOrUpdateAuthorizationRuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content, cancellationToken).ConfigureAwait(false);
                var operation = new NotificationHubsArmOperation<BaseNotificationHubAuthorizationRuleResource>(Response.FromValue(GetResource(Client, response), response.GetRawResponse()));
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
        /// Creates/Updates an authorization rule for a NotificationHub
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}/notificationHubs/{notificationHubName}/AuthorizationRules/{authorizationRuleName}
        /// Operation Id: NotificationHubs_CreateOrUpdateAuthorizationRule
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The shared access authorization rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        [ForwardsClientCalls]
        public new async Task<ArmOperation<NotificationHubAuthorizationRuleResource>> UpdateAsync(WaitUntil waitUntil, SharedAccessAuthorizationRuleCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            var result = await UpdateCoreAsync(waitUntil, content, cancellationToken).ConfigureAwait(false);
            return new NotificationHubsArmOperation<NotificationHubAuthorizationRuleResource>(Response.FromValue((NotificationHubAuthorizationRuleResource)result.Value, result.GetRawResponse()));
        }

        /// <summary>
        /// The core implementation for operation Update
        /// Creates/Updates an authorization rule for a NotificationHub
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}/notificationHubs/{notificationHubName}/AuthorizationRules/{authorizationRuleName}
        /// Operation Id: NotificationHubs_CreateOrUpdateAuthorizationRule
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The shared access authorization rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        protected override ArmOperation<BaseNotificationHubAuthorizationRuleResource> UpdateCore(WaitUntil waitUntil, SharedAccessAuthorizationRuleCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _notificationHubAuthorizationRuleNotificationHubsClientDiagnostics.CreateScope("NotificationHubAuthorizationRuleResource.Update");
            scope.Start();
            try
            {
                var response = _notificationHubAuthorizationRuleNotificationHubsRestClient.CreateOrUpdateAuthorizationRule(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content, cancellationToken);
                var operation = new NotificationHubsArmOperation<BaseNotificationHubAuthorizationRuleResource>(Response.FromValue(GetResource(Client, response), response.GetRawResponse()));
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
        /// Creates/Updates an authorization rule for a NotificationHub
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}/notificationHubs/{notificationHubName}/AuthorizationRules/{authorizationRuleName}
        /// Operation Id: NotificationHubs_CreateOrUpdateAuthorizationRule
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The shared access authorization rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        [ForwardsClientCalls]
        public new ArmOperation<NotificationHubAuthorizationRuleResource> Update(WaitUntil waitUntil, SharedAccessAuthorizationRuleCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            var result = UpdateCore(waitUntil, content, cancellationToken);
            return new NotificationHubsArmOperation<NotificationHubAuthorizationRuleResource>(Response.FromValue((NotificationHubAuthorizationRuleResource)result.Value, result.GetRawResponse()));
        }

        /// <summary>
        /// The core implementation for operation GetKeys
        /// Gets the Primary and Secondary ConnectionStrings to the NotificationHub 
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}/notificationHubs/{notificationHubName}/AuthorizationRules/{authorizationRuleName}/listKeys
        /// Operation Id: NotificationHubs_ListKeys
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<NotificationHubResourceKeys>> GetKeysCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _notificationHubAuthorizationRuleNotificationHubsClientDiagnostics.CreateScope("NotificationHubAuthorizationRuleResource.GetKeys");
            scope.Start();
            try
            {
                var response = await _notificationHubAuthorizationRuleNotificationHubsRestClient.ListKeysAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// Gets the Primary and Secondary ConnectionStrings to the NotificationHub 
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}/notificationHubs/{notificationHubName}/AuthorizationRules/{authorizationRuleName}/listKeys
        /// Operation Id: NotificationHubs_ListKeys
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<NotificationHubResourceKeys> GetKeysCore(CancellationToken cancellationToken = default)
        {
            using var scope = _notificationHubAuthorizationRuleNotificationHubsClientDiagnostics.CreateScope("NotificationHubAuthorizationRuleResource.GetKeys");
            scope.Start();
            try
            {
                var response = _notificationHubAuthorizationRuleNotificationHubsRestClient.ListKeys(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The core implementation for operation RegenerateKeys
        /// Regenerates the Primary/Secondary Keys to the NotificationHub Authorization Rule
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}/notificationHubs/{notificationHubName}/AuthorizationRules/{authorizationRuleName}/regenerateKeys
        /// Operation Id: NotificationHubs_RegenerateKeys
        /// </summary>
        /// <param name="notificationHubPolicyKey"> Parameters supplied to regenerate the NotificationHub Authorization Rule Key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="notificationHubPolicyKey"/> is null. </exception>
        protected override async Task<Response<NotificationHubResourceKeys>> RegenerateKeysCoreAsync(NotificationHubPolicyKey notificationHubPolicyKey, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(notificationHubPolicyKey, nameof(notificationHubPolicyKey));

            using var scope = _notificationHubAuthorizationRuleNotificationHubsClientDiagnostics.CreateScope("NotificationHubAuthorizationRuleResource.RegenerateKeys");
            scope.Start();
            try
            {
                var response = await _notificationHubAuthorizationRuleNotificationHubsRestClient.RegenerateKeysAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, notificationHubPolicyKey, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The core implementation for operation RegenerateKeys
        /// Regenerates the Primary/Secondary Keys to the NotificationHub Authorization Rule
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}/notificationHubs/{notificationHubName}/AuthorizationRules/{authorizationRuleName}/regenerateKeys
        /// Operation Id: NotificationHubs_RegenerateKeys
        /// </summary>
        /// <param name="notificationHubPolicyKey"> Parameters supplied to regenerate the NotificationHub Authorization Rule Key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="notificationHubPolicyKey"/> is null. </exception>
        protected override Response<NotificationHubResourceKeys> RegenerateKeysCore(NotificationHubPolicyKey notificationHubPolicyKey, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(notificationHubPolicyKey, nameof(notificationHubPolicyKey));

            using var scope = _notificationHubAuthorizationRuleNotificationHubsClientDiagnostics.CreateScope("NotificationHubAuthorizationRuleResource.RegenerateKeys");
            scope.Start();
            try
            {
                var response = _notificationHubAuthorizationRuleNotificationHubsRestClient.RegenerateKeys(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, notificationHubPolicyKey, cancellationToken);
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
