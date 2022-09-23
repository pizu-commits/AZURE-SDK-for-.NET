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
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.ServiceBus.Models;

namespace Azure.ResourceManager.ServiceBus
{
    /// <summary> TODO. </summary>
    public abstract partial class ServiceBusAuthorizationRuleResource : ArmResource
    {
        internal static ServiceBusAuthorizationRuleResource GetResource(ArmClient client, ServiceBusAuthorizationRuleData data)
        {
            if (IsServiceBusNamespaceAuthorizationRuleResource(data.Id))
            {
                return new ServiceBusNamespaceAuthorizationRuleResource(client, data);
            }
            if (IsServiceBusQueueAuthorizationRuleResource(data.Id))
            {
                return new ServiceBusQueueAuthorizationRuleResource(client, data);
            }
            if (IsServiceBusTopicAuthorizationRuleResource(data.Id))
            {
                return new ServiceBusTopicAuthorizationRuleResource(client, data);
            }
            if (IsServiceBusDisasterRecoveryAuthorizationRuleResource(data.Id))
            {
                return new ServiceBusDisasterRecoveryAuthorizationRuleResource(client, data);
            }
            throw new InvalidOperationException($"The resource identifier {data.Id} cannot be recognized as one of the following resource candidates: ServiceBusNamespaceAuthorizationRuleResource, ServiceBusQueueAuthorizationRuleResource, ServiceBusTopicAuthorizationRuleResource or ServiceBusDisasterRecoveryAuthorizationRuleResource");
        }

        private static bool IsServiceBusNamespaceAuthorizationRuleResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != ServiceBusNamespaceAuthorizationRuleResource.ResourceType)
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

        private static bool IsServiceBusQueueAuthorizationRuleResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != ServiceBusQueueAuthorizationRuleResource.ResourceType)
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

        private static bool IsServiceBusTopicAuthorizationRuleResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != ServiceBusTopicAuthorizationRuleResource.ResourceType)
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

        private static bool IsServiceBusDisasterRecoveryAuthorizationRuleResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != ServiceBusDisasterRecoveryAuthorizationRuleResource.ResourceType)
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

        private readonly ServiceBusAuthorizationRuleData _data;

        /// <summary> Initializes a new instance of the <see cref="ServiceBusAuthorizationRuleResource"/> class for mocking. </summary>
        protected ServiceBusAuthorizationRuleResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ServiceBusAuthorizationRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ServiceBusAuthorizationRuleResource(ArmClient client, ServiceBusAuthorizationRuleData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceBusAuthorizationRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ServiceBusAuthorizationRuleResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ServiceBusAuthorizationRuleData Data
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
        protected abstract Task<Response<ServiceBusAuthorizationRuleResource>> GetCoreAsync(CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public async Task<Response<ServiceBusAuthorizationRuleResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            return await GetCoreAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> The core implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected abstract Response<ServiceBusAuthorizationRuleResource> GetCore(CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public Response<ServiceBusAuthorizationRuleResource> Get(CancellationToken cancellationToken = default)
        {
            return GetCore(cancellationToken);
        }

        /// <summary> The core implementation for operation GetKeys. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected abstract Task<Response<ServiceBusAccessKeys>> GetKeysCoreAsync(CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation GetKeys. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public async Task<Response<ServiceBusAccessKeys>> GetKeysAsync(CancellationToken cancellationToken = default)
        {
            return await GetKeysCoreAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> The core implementation for operation GetKeys. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected abstract Response<ServiceBusAccessKeys> GetKeysCore(CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation GetKeys. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public Response<ServiceBusAccessKeys> GetKeys(CancellationToken cancellationToken = default)
        {
            return GetKeysCore(cancellationToken);
        }
    }
}
