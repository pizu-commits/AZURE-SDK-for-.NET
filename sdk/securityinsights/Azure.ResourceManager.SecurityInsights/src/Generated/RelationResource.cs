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

namespace Azure.ResourceManager.SecurityInsights
{
    /// <summary> This is the base client representation of the following resources <see cref="BookmarkRelationResource" />, <see cref="EntityRelationResource" /> or <see cref="IncidentRelationResource" />. </summary>
    public abstract partial class RelationResource : ArmResource
    {
        internal static RelationResource GetResource(ArmClient client, RelationData data)
        {
            if (IsBookmarkRelationResource(data.Id))
            {
                return new BookmarkRelationResource(client, data);
            }
            if (IsEntityRelationResource(data.Id))
            {
                return new EntityRelationResource(client, data);
            }
            if (IsIncidentRelationResource(data.Id))
            {
                return new IncidentRelationResource(client, data);
            }
            throw new InvalidOperationException($"The resource identifier {data.Id} cannot be recognized as one of the following resource candidates: BookmarkRelationResource, EntityRelationResource or IncidentRelationResource");
        }

        private static bool IsBookmarkRelationResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != BookmarkRelationResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.Parent.ResourceType != "Microsoft.OperationalInsights/workspaces")
            {
                return false;
            }
            return true;
        }

        private static bool IsEntityRelationResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != EntityRelationResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.Parent.ResourceType != "Microsoft.OperationalInsights/workspaces")
            {
                return false;
            }
            return true;
        }

        private static bool IsIncidentRelationResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != IncidentRelationResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.Parent.ResourceType != "Microsoft.OperationalInsights/workspaces")
            {
                return false;
            }
            return true;
        }

        private readonly RelationData _data;

        /// <summary> Initializes a new instance of the <see cref="RelationResource"/> class for mocking. </summary>
        protected RelationResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "RelationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal RelationResource(ArmClient client, RelationData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="RelationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal RelationResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual RelationData Data
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
        protected abstract Task<Response<RelationResource>> GetCoreAsync(CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public async Task<Response<RelationResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            return await GetCoreAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> The core implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected abstract Response<RelationResource> GetCore(CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public Response<RelationResource> Get(CancellationToken cancellationToken = default)
        {
            return GetCore(cancellationToken);
        }
    }
}
