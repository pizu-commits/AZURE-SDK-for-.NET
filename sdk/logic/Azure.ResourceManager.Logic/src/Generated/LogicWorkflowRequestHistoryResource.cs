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
    public abstract partial class LogicWorkflowRequestHistoryResource : ArmResource
    {
        internal static LogicWorkflowRequestHistoryResource GetResource(ArmClient client, LogicWorkflowRequestHistoryData data)
        {
            if (IsLogicWorkflowRunActionRepetitionRequestHistoryResource(data.Id))
            {
                return new LogicWorkflowRunActionRepetitionRequestHistoryResource(client, data);
            }
            if (IsLogicWorkflowRunActionRequestHistoryResource(data.Id))
            {
                return new LogicWorkflowRunActionRequestHistoryResource(client, data);
            }
            throw new InvalidOperationException($"The resource identifier {data.Id} cannot be recognized as one of the following resource candidates: LogicWorkflowRunActionRepetitionRequestHistoryResource or LogicWorkflowRunActionRequestHistoryResource");
        }

        private static bool IsLogicWorkflowRunActionRepetitionRequestHistoryResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != LogicWorkflowRunActionRepetitionRequestHistoryResource.ResourceType)
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

        private static bool IsLogicWorkflowRunActionRequestHistoryResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != LogicWorkflowRunActionRequestHistoryResource.ResourceType)
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

        private readonly LogicWorkflowRequestHistoryData _data;

        /// <summary> Initializes a new instance of the <see cref="LogicWorkflowRequestHistoryResource"/> class for mocking. </summary>
        protected LogicWorkflowRequestHistoryResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "LogicWorkflowRequestHistoryResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal LogicWorkflowRequestHistoryResource(ArmClient client, LogicWorkflowRequestHistoryData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="LogicWorkflowRequestHistoryResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal LogicWorkflowRequestHistoryResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual LogicWorkflowRequestHistoryData Data
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
        protected abstract Task<Response<LogicWorkflowRequestHistoryResource>> GetCoreAsync(CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public async Task<Response<LogicWorkflowRequestHistoryResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            return await GetCoreAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> The core implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected abstract Response<LogicWorkflowRequestHistoryResource> GetCore(CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public Response<LogicWorkflowRequestHistoryResource> Get(CancellationToken cancellationToken = default)
        {
            return GetCore(cancellationToken);
        }
    }
}
