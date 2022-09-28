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

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A Class representing a WebSiteContinuousWebJob along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="WebSiteContinuousWebJobResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetWebSiteContinuousWebJobResource method.
    /// Otherwise you can get one from its parent resource <see cref="WebSiteResource" /> using the GetWebSiteContinuousWebJob method.
    /// </summary>
    public partial class WebSiteContinuousWebJobResource : ContinuousWebJobResource
    {
        /// <summary> Generate the resource identifier of a <see cref="WebSiteContinuousWebJobResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string webJobName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/continuouswebjobs/{webJobName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _webSiteContinuousWebJobWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _webSiteContinuousWebJobWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="WebSiteContinuousWebJobResource"/> class for mocking. </summary>
        protected WebSiteContinuousWebJobResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "WebSiteContinuousWebJobResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal WebSiteContinuousWebJobResource(ArmClient client, ContinuousWebJobData data) : base(client, data)
        {
            _webSiteContinuousWebJobWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string webSiteContinuousWebJobWebAppsApiVersion);
            _webSiteContinuousWebJobWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, webSiteContinuousWebJobWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="WebSiteContinuousWebJobResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal WebSiteContinuousWebJobResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _webSiteContinuousWebJobWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string webSiteContinuousWebJobWebAppsApiVersion);
            _webSiteContinuousWebJobWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, webSiteContinuousWebJobWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/continuouswebjobs";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Gets a continuous web job by its ID for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/continuouswebjobs/{webJobName}
        /// Operation Id: WebApps_GetContinuousWebJob
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<ContinuousWebJobResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _webSiteContinuousWebJobWebAppsClientDiagnostics.CreateScope("WebSiteContinuousWebJobResource.Get");
            scope.Start();
            try
            {
                var response = await _webSiteContinuousWebJobWebAppsRestClient.GetContinuousWebJobAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// Description for Gets a continuous web job by its ID for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/continuouswebjobs/{webJobName}
        /// Operation Id: WebApps_GetContinuousWebJob
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new async Task<Response<WebSiteContinuousWebJobResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var result = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((WebSiteContinuousWebJobResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// Description for Gets a continuous web job by its ID for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/continuouswebjobs/{webJobName}
        /// Operation Id: WebApps_GetContinuousWebJob
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<ContinuousWebJobResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _webSiteContinuousWebJobWebAppsClientDiagnostics.CreateScope("WebSiteContinuousWebJobResource.Get");
            scope.Start();
            try
            {
                var response = _webSiteContinuousWebJobWebAppsRestClient.GetContinuousWebJob(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
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
        /// Description for Gets a continuous web job by its ID for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/continuouswebjobs/{webJobName}
        /// Operation Id: WebApps_GetContinuousWebJob
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new Response<WebSiteContinuousWebJobResource> Get(CancellationToken cancellationToken = default)
        {
            var result = GetCore(cancellationToken);
            return Response.FromValue((WebSiteContinuousWebJobResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// Description for Delete a continuous web job by its ID for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/continuouswebjobs/{webJobName}
        /// Operation Id: WebApps_DeleteContinuousWebJob
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<ArmOperation> DeleteCoreAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _webSiteContinuousWebJobWebAppsClientDiagnostics.CreateScope("WebSiteContinuousWebJobResource.Delete");
            scope.Start();
            try
            {
                var response = await _webSiteContinuousWebJobWebAppsRestClient.DeleteContinuousWebJobAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Delete a continuous web job by its ID for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/continuouswebjobs/{webJobName}
        /// Operation Id: WebApps_DeleteContinuousWebJob
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override ArmOperation DeleteCore(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _webSiteContinuousWebJobWebAppsClientDiagnostics.CreateScope("WebSiteContinuousWebJobResource.Delete");
            scope.Start();
            try
            {
                var response = _webSiteContinuousWebJobWebAppsRestClient.DeleteContinuousWebJob(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new AppServiceArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Start a continuous web job for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/continuouswebjobs/{webJobName}/start
        /// Operation Id: WebApps_StartContinuousWebJob
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> StartContinuousWebJobAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _webSiteContinuousWebJobWebAppsClientDiagnostics.CreateScope("WebSiteContinuousWebJobResource.StartContinuousWebJob");
            scope.Start();
            try
            {
                var response = await _webSiteContinuousWebJobWebAppsRestClient.StartContinuousWebJobAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Start a continuous web job for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/continuouswebjobs/{webJobName}/start
        /// Operation Id: WebApps_StartContinuousWebJob
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response StartContinuousWebJob(CancellationToken cancellationToken = default)
        {
            using var scope = _webSiteContinuousWebJobWebAppsClientDiagnostics.CreateScope("WebSiteContinuousWebJobResource.StartContinuousWebJob");
            scope.Start();
            try
            {
                var response = _webSiteContinuousWebJobWebAppsRestClient.StartContinuousWebJob(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Stop a continuous web job for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/continuouswebjobs/{webJobName}/stop
        /// Operation Id: WebApps_StopContinuousWebJob
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> StopContinuousWebJobAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _webSiteContinuousWebJobWebAppsClientDiagnostics.CreateScope("WebSiteContinuousWebJobResource.StopContinuousWebJob");
            scope.Start();
            try
            {
                var response = await _webSiteContinuousWebJobWebAppsRestClient.StopContinuousWebJobAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Stop a continuous web job for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/continuouswebjobs/{webJobName}/stop
        /// Operation Id: WebApps_StopContinuousWebJob
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response StopContinuousWebJob(CancellationToken cancellationToken = default)
        {
            using var scope = _webSiteContinuousWebJobWebAppsClientDiagnostics.CreateScope("WebSiteContinuousWebJobResource.StopContinuousWebJob");
            scope.Start();
            try
            {
                var response = _webSiteContinuousWebJobWebAppsRestClient.StopContinuousWebJob(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
