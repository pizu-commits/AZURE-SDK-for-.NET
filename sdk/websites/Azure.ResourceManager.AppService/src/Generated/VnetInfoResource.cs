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

namespace Azure.ResourceManager.AppService
{
    /// <summary> TODO. </summary>
    public abstract partial class VnetInfoResource : ArmResource
    {
        internal static VnetInfoResource GetResource(ArmClient client, VnetInfoResourceData data)
        {
            if (IsAppServicePlanVirtualNetworkConnectionResource(data.Id))
            {
                return new AppServicePlanVirtualNetworkConnectionResource(client, data);
            }
            if (IsSiteSlotVirtualNetworkConnectionResource(data.Id))
            {
                return new SiteSlotVirtualNetworkConnectionResource(client, data);
            }
            if (IsSiteVirtualNetworkConnectionResource(data.Id))
            {
                return new SiteVirtualNetworkConnectionResource(client, data);
            }
            // TODO -- should we throw or return an UnknownResource?
            throw new InvalidOperationException();
        }

        internal static bool IsAppServicePlanVirtualNetworkConnectionResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != AppServicePlanVirtualNetworkConnectionResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.Parent.ResourceType != "Microsoft.Resources/resourceGroups")
            {
                return false;
            }
            return true;
        }

        internal static bool IsSiteSlotVirtualNetworkConnectionResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != SiteSlotVirtualNetworkConnectionResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.Parent.Parent.ResourceType != "Microsoft.Resources/resourceGroups")
            {
                return false;
            }
            return true;
        }

        internal static bool IsSiteVirtualNetworkConnectionResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != SiteVirtualNetworkConnectionResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.Parent.ResourceType != "Microsoft.Resources/resourceGroups")
            {
                return false;
            }
            return true;
        }

        private readonly VnetInfoResourceData _data;

        /// <summary> Initializes a new instance of the <see cref="VnetInfoResource"/> class for mocking. </summary>
        protected VnetInfoResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "VnetInfoResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal VnetInfoResource(ArmClient client, VnetInfoResourceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="VnetInfoResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal VnetInfoResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual VnetInfoResourceData Data
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
        protected abstract Task<Response<VnetInfoResource>> GetCoreAsync(CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public async Task<Response<VnetInfoResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            return await GetCoreAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> The core implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected abstract Response<VnetInfoResource> GetCore(CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public Response<VnetInfoResource> Get(CancellationToken cancellationToken = default)
        {
            return GetCore(cancellationToken);
        }
    }
}
