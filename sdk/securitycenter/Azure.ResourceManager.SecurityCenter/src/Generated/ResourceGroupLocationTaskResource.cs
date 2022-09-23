// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A Class representing a ResourceGroupLocationTask along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="ResourceGroupLocationTaskResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetResourceGroupLocationTaskResource method.
    /// Otherwise you can get one from its parent resource <see cref="ResourceGroupResource" /> using the GetResourceGroupLocationTask method.
    /// </summary>
    public partial class ResourceGroupLocationTaskResource : SecurityTaskResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ResourceGroupLocationTaskResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string ascLocation, string taskName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/locations/{ascLocation}/tasks/{taskName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _resourceGroupLocationTaskTasksClientDiagnostics;
        private readonly TasksRestOperations _resourceGroupLocationTaskTasksRestClient;

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupLocationTaskResource"/> class for mocking. </summary>
        protected ResourceGroupLocationTaskResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ResourceGroupLocationTaskResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ResourceGroupLocationTaskResource(ArmClient client, SecurityTaskData data) : base(client, data)
        {
            _resourceGroupLocationTaskTasksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string resourceGroupLocationTaskTasksApiVersion);
            _resourceGroupLocationTaskTasksRestClient = new TasksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, resourceGroupLocationTaskTasksApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupLocationTaskResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceGroupLocationTaskResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _resourceGroupLocationTaskTasksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string resourceGroupLocationTaskTasksApiVersion);
            _resourceGroupLocationTaskTasksRestClient = new TasksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, resourceGroupLocationTaskTasksApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Security/locations/tasks";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Recommended tasks that will help improve the security of the subscription proactively
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/locations/{ascLocation}/tasks/{taskName}
        /// Operation Id: Tasks_GetResourceGroupLevelTask
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<SecurityTaskResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _resourceGroupLocationTaskTasksClientDiagnostics.CreateScope("ResourceGroupLocationTaskResource.GetCore");
            scope.Start();
            try
            {
                var response = await _resourceGroupLocationTaskTasksRestClient.GetResourceGroupLevelTaskAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Recommended tasks that will help improve the security of the subscription proactively
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/locations/{ascLocation}/tasks/{taskName}
        /// Operation Id: Tasks_GetResourceGroupLevelTask
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new async Task<Response<ResourceGroupLocationTaskResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var result = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((ResourceGroupLocationTaskResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Recommended tasks that will help improve the security of the subscription proactively
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/locations/{ascLocation}/tasks/{taskName}
        /// Operation Id: Tasks_GetResourceGroupLevelTask
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<SecurityTaskResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _resourceGroupLocationTaskTasksClientDiagnostics.CreateScope("ResourceGroupLocationTaskResource.GetCore");
            scope.Start();
            try
            {
                var response = _resourceGroupLocationTaskTasksRestClient.GetResourceGroupLevelTask(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Recommended tasks that will help improve the security of the subscription proactively
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/locations/{ascLocation}/tasks/{taskName}
        /// Operation Id: Tasks_GetResourceGroupLevelTask
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new Response<ResourceGroupLocationTaskResource> Get(CancellationToken cancellationToken = default)
        {
            var result = GetCore(cancellationToken);
            return Response.FromValue((ResourceGroupLocationTaskResource)result.Value, result.GetRawResponse());
        }
    }
}
