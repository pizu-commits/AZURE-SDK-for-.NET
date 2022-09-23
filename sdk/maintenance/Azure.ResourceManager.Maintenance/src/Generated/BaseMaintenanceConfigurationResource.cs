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

namespace Azure.ResourceManager.Maintenance
{
    /// <summary> TODO. </summary>
    public abstract partial class BaseMaintenanceConfigurationResource : ArmResource
    {
        internal static BaseMaintenanceConfigurationResource GetResource(ArmClient client, MaintenanceConfigurationData data)
        {
            if (IsPublicMaintenanceConfigurationResource(data.Id))
            {
                return new PublicMaintenanceConfigurationResource(client, data);
            }
            if (IsMaintenanceConfigurationResource(data.Id))
            {
                return new MaintenanceConfigurationResource(client, data);
            }
            throw new InvalidOperationException($"The resource identifier {data.Id} cannot be recognized as one of the following resource candidates: PublicMaintenanceConfigurationResource or MaintenanceConfigurationResource");
        }

        private static bool IsPublicMaintenanceConfigurationResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != PublicMaintenanceConfigurationResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.ResourceType != SubscriptionResource.ResourceType)
            {
                return false;
            }
            return true;
        }

        private static bool IsMaintenanceConfigurationResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != MaintenanceConfigurationResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.ResourceType != ResourceGroupResource.ResourceType)
            {
                return false;
            }
            return true;
        }

        private readonly MaintenanceConfigurationData _data;

        /// <summary> Initializes a new instance of the <see cref="BaseMaintenanceConfigurationResource"/> class for mocking. </summary>
        protected BaseMaintenanceConfigurationResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "BaseMaintenanceConfigurationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal BaseMaintenanceConfigurationResource(ArmClient client, MaintenanceConfigurationData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="BaseMaintenanceConfigurationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal BaseMaintenanceConfigurationResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual MaintenanceConfigurationData Data
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
        protected abstract Task<Response<BaseMaintenanceConfigurationResource>> GetCoreAsync(CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public async Task<Response<BaseMaintenanceConfigurationResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            return await GetCoreAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> The core implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected abstract Response<BaseMaintenanceConfigurationResource> GetCore(CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public Response<BaseMaintenanceConfigurationResource> Get(CancellationToken cancellationToken = default)
        {
            return GetCore(cancellationToken);
        }
    }
}
