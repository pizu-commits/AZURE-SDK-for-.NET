// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.NotificationHubs.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.NotificationHubs
{
    /// <summary> This is the base client representation of the following resources <see cref="NotificationHubNamespaceAuthorizationRuleResource" /> or <see cref="NotificationHubAuthorizationRuleResource" />. </summary>
    public abstract partial class BaseNotificationHubAuthorizationRuleResource : ArmResource
    {
        internal static BaseNotificationHubAuthorizationRuleResource GetResource(ArmClient client, NotificationHubAuthorizationRuleData data)
        {
            if (IsNotificationHubNamespaceAuthorizationRuleResource(data.Id))
            {
                return new NotificationHubNamespaceAuthorizationRuleResource(client, data);
            }
            if (IsNotificationHubAuthorizationRuleResource(data.Id))
            {
                return new NotificationHubAuthorizationRuleResource(client, data);
            }
            throw new InvalidOperationException($"The resource identifier {data.Id} cannot be recognized as one of the following resource candidates: NotificationHubNamespaceAuthorizationRuleResource or NotificationHubAuthorizationRuleResource");
        }

        private static bool IsNotificationHubNamespaceAuthorizationRuleResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != NotificationHubNamespaceAuthorizationRuleResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.Parent.ResourceType != ResourceGroupResource.ResourceType)
            {
                return false;
            }
            return true;
        }

        private static bool IsNotificationHubAuthorizationRuleResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != NotificationHubAuthorizationRuleResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.Parent.Parent.ResourceType != ResourceGroupResource.ResourceType)
            {
                return false;
            }
            return true;
        }

        private readonly NotificationHubAuthorizationRuleData _data;

        /// <summary> Initializes a new instance of the <see cref="BaseNotificationHubAuthorizationRuleResource"/> class for mocking. </summary>
        protected BaseNotificationHubAuthorizationRuleResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "BaseNotificationHubAuthorizationRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal BaseNotificationHubAuthorizationRuleResource(ArmClient client, NotificationHubAuthorizationRuleData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="BaseNotificationHubAuthorizationRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal BaseNotificationHubAuthorizationRuleResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual NotificationHubAuthorizationRuleData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        /// <summary> The core implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected abstract Task<Response<BaseNotificationHubAuthorizationRuleResource>> GetCoreAsync(CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public async Task<Response<BaseNotificationHubAuthorizationRuleResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            return await GetCoreAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> The core implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected abstract Response<BaseNotificationHubAuthorizationRuleResource> GetCore(CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public Response<BaseNotificationHubAuthorizationRuleResource> Get(CancellationToken cancellationToken = default)
        {
            return GetCore(cancellationToken);
        }

        /// <summary> The core implementation for operation Delete. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected abstract Task<ArmOperation> DeleteCoreAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Delete. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            return await DeleteCoreAsync(waitUntil, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> The core implementation for operation Delete. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected abstract ArmOperation DeleteCore(WaitUntil waitUntil, CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Delete. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            return DeleteCore(waitUntil, cancellationToken);
        }

        /// <summary> The core implementation for operation Update. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The shared access authorization rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        protected abstract Task<ArmOperation<BaseNotificationHubAuthorizationRuleResource>> UpdateCoreAsync(WaitUntil waitUntil, SharedAccessAuthorizationRuleCreateOrUpdateContent content, CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Update. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The shared access authorization rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        [ForwardsClientCalls]
        public async Task<ArmOperation<BaseNotificationHubAuthorizationRuleResource>> UpdateAsync(WaitUntil waitUntil, SharedAccessAuthorizationRuleCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return await UpdateCoreAsync(waitUntil, content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> The core implementation for operation Update. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The shared access authorization rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        protected abstract ArmOperation<BaseNotificationHubAuthorizationRuleResource> UpdateCore(WaitUntil waitUntil, SharedAccessAuthorizationRuleCreateOrUpdateContent content, CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Update. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The shared access authorization rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        [ForwardsClientCalls]
        public ArmOperation<BaseNotificationHubAuthorizationRuleResource> Update(WaitUntil waitUntil, SharedAccessAuthorizationRuleCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return UpdateCore(waitUntil, content, cancellationToken);
        }

        /// <summary> The core implementation for operation GetKeys. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected abstract Task<Response<NotificationHubResourceKeys>> GetKeysCoreAsync(CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation GetKeys. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public async Task<Response<NotificationHubResourceKeys>> GetKeysAsync(CancellationToken cancellationToken = default)
        {
            return await GetKeysCoreAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> The core implementation for operation GetKeys. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected abstract Response<NotificationHubResourceKeys> GetKeysCore(CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation GetKeys. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public Response<NotificationHubResourceKeys> GetKeys(CancellationToken cancellationToken = default)
        {
            return GetKeysCore(cancellationToken);
        }

        /// <summary> The core implementation for operation RegenerateKeys. </summary>
        /// <param name="notificationHubPolicyKey"> Parameters supplied to regenerate the Namespace Authorization Rule Key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="notificationHubPolicyKey"/> is null. </exception>
        protected abstract Task<Response<NotificationHubResourceKeys>> RegenerateKeysCoreAsync(NotificationHubPolicyKey notificationHubPolicyKey, CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation RegenerateKeys. </summary>
        /// <param name="notificationHubPolicyKey"> Parameters supplied to regenerate the Namespace Authorization Rule Key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="notificationHubPolicyKey"/> is null. </exception>
        [ForwardsClientCalls]
        public async Task<Response<NotificationHubResourceKeys>> RegenerateKeysAsync(NotificationHubPolicyKey notificationHubPolicyKey, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(notificationHubPolicyKey, nameof(notificationHubPolicyKey));

            return await RegenerateKeysCoreAsync(notificationHubPolicyKey, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> The core implementation for operation RegenerateKeys. </summary>
        /// <param name="notificationHubPolicyKey"> Parameters supplied to regenerate the Namespace Authorization Rule Key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="notificationHubPolicyKey"/> is null. </exception>
        protected abstract Response<NotificationHubResourceKeys> RegenerateKeysCore(NotificationHubPolicyKey notificationHubPolicyKey, CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation RegenerateKeys. </summary>
        /// <param name="notificationHubPolicyKey"> Parameters supplied to regenerate the Namespace Authorization Rule Key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="notificationHubPolicyKey"/> is null. </exception>
        [ForwardsClientCalls]
        public Response<NotificationHubResourceKeys> RegenerateKeys(NotificationHubPolicyKey notificationHubPolicyKey, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(notificationHubPolicyKey, nameof(notificationHubPolicyKey));

            return RegenerateKeysCore(notificationHubPolicyKey, cancellationToken);
        }
    }
}
