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
    /// <summary> This is the base client representation of the following resources <see cref="WebSiteContinuousWebJobResource" /> or <see cref="WebSiteSlotContinuousWebJobResource" />. </summary>
    public abstract partial class ContinuousWebJobResource : ArmResource
    {
        internal static ContinuousWebJobResource GetResource(ArmClient client, ContinuousWebJobData data)
        {
            if (IsWebSiteContinuousWebJobResource(data.Id))
            {
                return new WebSiteContinuousWebJobResource(client, data);
            }
            if (IsWebSiteSlotContinuousWebJobResource(data.Id))
            {
                return new WebSiteSlotContinuousWebJobResource(client, data);
            }
            throw new InvalidOperationException($"The resource identifier {data.Id} cannot be recognized as one of the following resource candidates: WebSiteContinuousWebJobResource or WebSiteSlotContinuousWebJobResource");
        }

        private static bool IsWebSiteContinuousWebJobResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != WebSiteContinuousWebJobResource.ResourceType)
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

        private static bool IsWebSiteSlotContinuousWebJobResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != WebSiteSlotContinuousWebJobResource.ResourceType)
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

        private readonly ContinuousWebJobData _data;

        /// <summary> Initializes a new instance of the <see cref="ContinuousWebJobResource"/> class for mocking. </summary>
        protected ContinuousWebJobResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ContinuousWebJobResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ContinuousWebJobResource(ArmClient client, ContinuousWebJobData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ContinuousWebJobResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ContinuousWebJobResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ContinuousWebJobData Data
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
        protected abstract Task<Response<ContinuousWebJobResource>> GetCoreAsync(CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public async Task<Response<ContinuousWebJobResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            return await GetCoreAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> The core implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected abstract Response<ContinuousWebJobResource> GetCore(CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public Response<ContinuousWebJobResource> Get(CancellationToken cancellationToken = default)
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
    }
}
