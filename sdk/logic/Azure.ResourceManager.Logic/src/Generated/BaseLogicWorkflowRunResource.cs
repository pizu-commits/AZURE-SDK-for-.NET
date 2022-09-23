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

namespace Azure.ResourceManager.Logic
{
    /// <summary> TODO. </summary>
    public abstract partial class BaseLogicWorkflowRunResource : ArmResource
    {
        internal static BaseLogicWorkflowRunResource GetResource(ArmClient client, LogicWorkflowRunData data)
        {
            if (IsLogicWorkflowRunResource(data.Id))
            {
                return new LogicWorkflowRunResource(client, data);
            }
            if (IsLogicWorkflowRunOperationResource(data.Id))
            {
                return new LogicWorkflowRunOperationResource(client, data);
            }
            throw new InvalidOperationException($"The resource identifier {data.Id} cannot be recognized as one of the following resource candidates: LogicWorkflowRunResource or LogicWorkflowRunOperationResource");
        }

        private static bool IsLogicWorkflowRunResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != LogicWorkflowRunResource.ResourceType)
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

        private static bool IsLogicWorkflowRunOperationResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != LogicWorkflowRunOperationResource.ResourceType)
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

        private readonly LogicWorkflowRunData _data;

        /// <summary> Initializes a new instance of the <see cref="BaseLogicWorkflowRunResource"/> class for mocking. </summary>
        protected BaseLogicWorkflowRunResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "BaseLogicWorkflowRunResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal BaseLogicWorkflowRunResource(ArmClient client, LogicWorkflowRunData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="BaseLogicWorkflowRunResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal BaseLogicWorkflowRunResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual LogicWorkflowRunData Data
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
        protected abstract Task<Response<BaseLogicWorkflowRunResource>> GetCoreAsync(CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public async Task<Response<BaseLogicWorkflowRunResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            return await GetCoreAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> The core implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected abstract Response<BaseLogicWorkflowRunResource> GetCore(CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public Response<BaseLogicWorkflowRunResource> Get(CancellationToken cancellationToken = default)
        {
            return GetCore(cancellationToken);
        }
    }
}
