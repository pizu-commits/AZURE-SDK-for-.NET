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
    /// <summary> This is the base client representation of the following resources <see cref="SiteDiagnosticResource" /> or <see cref="SiteSlotDiagnosticResource" />. </summary>
    public abstract partial class DiagnosticCategoryResource : ArmResource
    {
        internal static DiagnosticCategoryResource GetResource(ArmClient client, DiagnosticCategoryData data)
        {
            if (IsSiteDiagnosticResource(data.Id))
            {
                return new SiteDiagnosticResource(client, data);
            }
            if (IsSiteSlotDiagnosticResource(data.Id))
            {
                return new SiteSlotDiagnosticResource(client, data);
            }
            throw new InvalidOperationException($"The resource identifier {data.Id} cannot be recognized as one of the following resource candidates: SiteDiagnosticResource or SiteSlotDiagnosticResource");
        }

        private static bool IsSiteDiagnosticResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != SiteDiagnosticResource.ResourceType)
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

        private static bool IsSiteSlotDiagnosticResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != SiteSlotDiagnosticResource.ResourceType)
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

        private readonly DiagnosticCategoryData _data;

        /// <summary> Initializes a new instance of the <see cref="DiagnosticCategoryResource"/> class for mocking. </summary>
        protected DiagnosticCategoryResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DiagnosticCategoryResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DiagnosticCategoryResource(ArmClient client, DiagnosticCategoryData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DiagnosticCategoryResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DiagnosticCategoryResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DiagnosticCategoryData Data
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
        protected abstract Task<Response<DiagnosticCategoryResource>> GetCoreAsync(CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public async Task<Response<DiagnosticCategoryResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            return await GetCoreAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> The core implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected abstract Response<DiagnosticCategoryResource> GetCore(CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public Response<DiagnosticCategoryResource> Get(CancellationToken cancellationToken = default)
        {
            return GetCore(cancellationToken);
        }
    }
}
