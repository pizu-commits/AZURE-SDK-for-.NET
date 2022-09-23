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
    /// A Class representing a WebSiteSourceControl along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="WebSiteSourceControlResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetWebSiteSourceControlResource method.
    /// Otherwise you can get one from its parent resource <see cref="WebSiteResource" /> using the GetWebSiteSourceControl method.
    /// </summary>
    public partial class WebSiteSourceControlResource : SiteSourceControlResource
    {
        /// <summary> Generate the resource identifier of a <see cref="WebSiteSourceControlResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/sourcecontrols/web";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _webSiteSourceControlWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _webSiteSourceControlWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="WebSiteSourceControlResource"/> class for mocking. </summary>
        protected WebSiteSourceControlResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "WebSiteSourceControlResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal WebSiteSourceControlResource(ArmClient client, SiteSourceControlData data) : base(client, data)
        {
            _webSiteSourceControlWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string webSiteSourceControlWebAppsApiVersion);
            _webSiteSourceControlWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, webSiteSourceControlWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="WebSiteSourceControlResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal WebSiteSourceControlResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _webSiteSourceControlWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string webSiteSourceControlWebAppsApiVersion);
            _webSiteSourceControlWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, webSiteSourceControlWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/sourcecontrols";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Description for Gets the source control configuration of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/sourcecontrols/web
        /// Operation Id: WebApps_GetSourceControl
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<SiteSourceControlResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _webSiteSourceControlWebAppsClientDiagnostics.CreateScope("WebSiteSourceControlResource.GetCore");
            scope.Start();
            try
            {
                var response = await _webSiteSourceControlWebAppsRestClient.GetSourceControlAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
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
        /// Description for Gets the source control configuration of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/sourcecontrols/web
        /// Operation Id: WebApps_GetSourceControl
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new async Task<Response<WebSiteSourceControlResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var result = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((WebSiteSourceControlResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Description for Gets the source control configuration of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/sourcecontrols/web
        /// Operation Id: WebApps_GetSourceControl
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<SiteSourceControlResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _webSiteSourceControlWebAppsClientDiagnostics.CreateScope("WebSiteSourceControlResource.GetCore");
            scope.Start();
            try
            {
                var response = _webSiteSourceControlWebAppsRestClient.GetSourceControl(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken);
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
        /// Description for Gets the source control configuration of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/sourcecontrols/web
        /// Operation Id: WebApps_GetSourceControl
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new Response<WebSiteSourceControlResource> Get(CancellationToken cancellationToken = default)
        {
            var result = GetCore(cancellationToken);
            return Response.FromValue((WebSiteSourceControlResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation Delete
        /// Description for Deletes the source control configuration of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/sourcecontrols/web
        /// Operation Id: WebApps_DeleteSourceControl
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="additionalFlags"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<ArmOperation> DeleteCoreAsync(WaitUntil waitUntil, string additionalFlags = null, CancellationToken cancellationToken = default)
        {
            using var scope = _webSiteSourceControlWebAppsClientDiagnostics.CreateScope("WebSiteSourceControlResource.DeleteCore");
            scope.Start();
            try
            {
                var response = await _webSiteSourceControlWebAppsRestClient.DeleteSourceControlAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, additionalFlags, cancellationToken).ConfigureAwait(false);
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
        /// The core implementation for operation Delete
        /// Description for Deletes the source control configuration of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/sourcecontrols/web
        /// Operation Id: WebApps_DeleteSourceControl
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="additionalFlags"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override ArmOperation DeleteCore(WaitUntil waitUntil, string additionalFlags = null, CancellationToken cancellationToken = default)
        {
            using var scope = _webSiteSourceControlWebAppsClientDiagnostics.CreateScope("WebSiteSourceControlResource.DeleteCore");
            scope.Start();
            try
            {
                var response = _webSiteSourceControlWebAppsRestClient.DeleteSourceControl(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, additionalFlags, cancellationToken);
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
        /// The core implementation for operation Update
        /// Description for Updates the source control configuration of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/sourcecontrols/web
        /// Operation Id: WebApps_UpdateSourceControl
        /// </summary>
        /// <param name="data"> JSON representation of a SiteSourceControl object. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        protected override async Task<Response<SiteSourceControlResource>> UpdateCoreAsync(SiteSourceControlData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _webSiteSourceControlWebAppsClientDiagnostics.CreateScope("WebSiteSourceControlResource.UpdateCore");
            scope.Start();
            try
            {
                var response = await _webSiteSourceControlWebAppsRestClient.UpdateSourceControlAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Updates the source control configuration of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/sourcecontrols/web
        /// Operation Id: WebApps_UpdateSourceControl
        /// </summary>
        /// <param name="data"> JSON representation of a SiteSourceControl object. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        [ForwardsClientCalls]
        public new async Task<Response<WebSiteSourceControlResource>> UpdateAsync(SiteSourceControlData data, CancellationToken cancellationToken = default)
        {
            var result = await UpdateCoreAsync(data, cancellationToken).ConfigureAwait(false);
            return Response.FromValue((WebSiteSourceControlResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation Update
        /// Description for Updates the source control configuration of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/sourcecontrols/web
        /// Operation Id: WebApps_UpdateSourceControl
        /// </summary>
        /// <param name="data"> JSON representation of a SiteSourceControl object. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        protected override Response<SiteSourceControlResource> UpdateCore(SiteSourceControlData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _webSiteSourceControlWebAppsClientDiagnostics.CreateScope("WebSiteSourceControlResource.UpdateCore");
            scope.Start();
            try
            {
                var response = _webSiteSourceControlWebAppsRestClient.UpdateSourceControl(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, cancellationToken);
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Updates the source control configuration of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/sourcecontrols/web
        /// Operation Id: WebApps_UpdateSourceControl
        /// </summary>
        /// <param name="data"> JSON representation of a SiteSourceControl object. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        [ForwardsClientCalls]
        public new Response<WebSiteSourceControlResource> Update(SiteSourceControlData data, CancellationToken cancellationToken = default)
        {
            var result = UpdateCore(data, cancellationToken);
            return Response.FromValue((WebSiteSourceControlResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation CreateOrUpdate
        /// Description for Updates the source control configuration of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/sourcecontrols/web
        /// Operation Id: WebApps_CreateOrUpdateSourceControl
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> JSON representation of a SiteSourceControl object. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        protected override async Task<ArmOperation<SiteSourceControlResource>> CreateOrUpdateCoreAsync(WaitUntil waitUntil, SiteSourceControlData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _webSiteSourceControlWebAppsClientDiagnostics.CreateScope("WebSiteSourceControlResource.CreateOrUpdateCore");
            scope.Start();
            try
            {
                var response = await _webSiteSourceControlWebAppsRestClient.CreateOrUpdateSourceControlAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<SiteSourceControlResource>(new SiteSourceControlOperationSource(Client), _webSiteSourceControlWebAppsClientDiagnostics, Pipeline, _webSiteSourceControlWebAppsRestClient.CreateCreateOrUpdateSourceControlRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Updates the source control configuration of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/sourcecontrols/web
        /// Operation Id: WebApps_CreateOrUpdateSourceControl
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> JSON representation of a SiteSourceControl object. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        [ForwardsClientCalls]
        public new async Task<ArmOperation<WebSiteSourceControlResource>> CreateOrUpdateAsync(WaitUntil waitUntil, SiteSourceControlData data, CancellationToken cancellationToken = default)
        {
            var result = await CreateOrUpdateCoreAsync(waitUntil, data, cancellationToken).ConfigureAwait(false);
            if (waitUntil == WaitUntil.Completed)
            {
                return new AppServiceArmOperation<WebSiteSourceControlResource>(Response.FromValue((WebSiteSourceControlResource)result.Value, result.GetRawResponse()));
            }
            var operation = new AppServiceArmOperation<WebSiteSourceControlResource>(new WebSiteSourceControlOperationSource(Client), _webSiteSourceControlWebAppsClientDiagnostics, Pipeline, _webSiteSourceControlWebAppsRestClient.CreateCreateOrUpdateSourceControlRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data).Request, result.GetRawResponse(), OperationFinalStateVia.Location);
            return operation;
        }

        /// <summary>
        /// The core implementation for operation CreateOrUpdate
        /// Description for Updates the source control configuration of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/sourcecontrols/web
        /// Operation Id: WebApps_CreateOrUpdateSourceControl
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> JSON representation of a SiteSourceControl object. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        protected override ArmOperation<SiteSourceControlResource> CreateOrUpdateCore(WaitUntil waitUntil, SiteSourceControlData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _webSiteSourceControlWebAppsClientDiagnostics.CreateScope("WebSiteSourceControlResource.CreateOrUpdateCore");
            scope.Start();
            try
            {
                var response = _webSiteSourceControlWebAppsRestClient.CreateOrUpdateSourceControl(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, cancellationToken);
                var operation = new AppServiceArmOperation<SiteSourceControlResource>(new SiteSourceControlOperationSource(Client), _webSiteSourceControlWebAppsClientDiagnostics, Pipeline, _webSiteSourceControlWebAppsRestClient.CreateCreateOrUpdateSourceControlRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Updates the source control configuration of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/sourcecontrols/web
        /// Operation Id: WebApps_CreateOrUpdateSourceControl
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> JSON representation of a SiteSourceControl object. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        [ForwardsClientCalls]
        public new ArmOperation<WebSiteSourceControlResource> CreateOrUpdate(WaitUntil waitUntil, SiteSourceControlData data, CancellationToken cancellationToken = default)
        {
            var result = CreateOrUpdateCore(waitUntil, data, cancellationToken);
            if (waitUntil == WaitUntil.Completed)
            {
                return new AppServiceArmOperation<WebSiteSourceControlResource>(Response.FromValue((WebSiteSourceControlResource)result.Value, result.GetRawResponse()));
            }
            var operation = new AppServiceArmOperation<WebSiteSourceControlResource>(new WebSiteSourceControlOperationSource(Client), _webSiteSourceControlWebAppsClientDiagnostics, Pipeline, _webSiteSourceControlWebAppsRestClient.CreateCreateOrUpdateSourceControlRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data).Request, result.GetRawResponse(), OperationFinalStateVia.Location);
            return operation;
        }
    }
}
