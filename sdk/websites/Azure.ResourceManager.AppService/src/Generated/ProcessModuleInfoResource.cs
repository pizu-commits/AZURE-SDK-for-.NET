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

namespace Azure.ResourceManager.AppService
{
    /// <summary> This is the base client representation of the following resources <see cref="SiteInstanceProcessModuleResource" />, <see cref="SiteProcessModuleResource" />, <see cref="SiteSlotInstanceProcessModuleResource" /> or <see cref="SiteSlotProcessModuleResource" />. </summary>
    public abstract partial class ProcessModuleInfoResource : ArmResource
    {
        internal static ProcessModuleInfoResource GetResource(ArmClient client, ProcessModuleInfoData data)
        {
            if (IsSiteInstanceProcessModuleResource(data.Id))
            {
                return new SiteInstanceProcessModuleResource(client, data);
            }
            if (IsSiteProcessModuleResource(data.Id))
            {
                return new SiteProcessModuleResource(client, data);
            }
            if (IsSiteSlotInstanceProcessModuleResource(data.Id))
            {
                return new SiteSlotInstanceProcessModuleResource(client, data);
            }
            if (IsSiteSlotProcessModuleResource(data.Id))
            {
                return new SiteSlotProcessModuleResource(client, data);
            }
            throw new InvalidOperationException($"The resource identifier {data.Id} cannot be recognized as one of the following resource candidates: SiteInstanceProcessModuleResource, SiteProcessModuleResource, SiteSlotInstanceProcessModuleResource or SiteSlotProcessModuleResource");
        }

        private static bool IsSiteInstanceProcessModuleResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != SiteInstanceProcessModuleResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.Parent.Parent.Parent.ResourceType != ResourceGroupResource.ResourceType)
            {
                return false;
            }
            return true;
        }

        private static bool IsSiteProcessModuleResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != SiteProcessModuleResource.ResourceType)
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

        private static bool IsSiteSlotInstanceProcessModuleResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != SiteSlotInstanceProcessModuleResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.Parent.Parent.Parent.Parent.ResourceType != ResourceGroupResource.ResourceType)
            {
                return false;
            }
            return true;
        }

        private static bool IsSiteSlotProcessModuleResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != SiteSlotProcessModuleResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.Parent.Parent.Parent.ResourceType != ResourceGroupResource.ResourceType)
            {
                return false;
            }
            return true;
        }

        private readonly ProcessModuleInfoData _data;

        /// <summary> Initializes a new instance of the <see cref="ProcessModuleInfoResource"/> class for mocking. </summary>
        protected ProcessModuleInfoResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ProcessModuleInfoResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ProcessModuleInfoResource(ArmClient client, ProcessModuleInfoData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ProcessModuleInfoResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ProcessModuleInfoResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ProcessModuleInfoData Data
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
        protected abstract Task<Response<ProcessModuleInfoResource>> GetCoreAsync(CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public async Task<Response<ProcessModuleInfoResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            return await GetCoreAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> The core implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected abstract Response<ProcessModuleInfoResource> GetCore(CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public Response<ProcessModuleInfoResource> Get(CancellationToken cancellationToken = default)
        {
            return GetCore(cancellationToken);
        }
    }
}
