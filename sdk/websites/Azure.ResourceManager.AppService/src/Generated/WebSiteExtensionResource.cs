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
    /// A Class representing a WebSiteExtension along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="WebSiteExtensionResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetWebSiteExtensionResource method.
    /// Otherwise you can get one from its parent resource <see cref="WebSiteResource" /> using the GetWebSiteExtension method.
    /// </summary>
    public partial class WebSiteExtensionResource : SiteExtensionInfoResource
    {
        /// <summary> Generate the resource identifier of a <see cref="WebSiteExtensionResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string siteExtensionId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/siteextensions/{siteExtensionId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _webSiteExtensionWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _webSiteExtensionWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="WebSiteExtensionResource"/> class for mocking. </summary>
        protected WebSiteExtensionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "WebSiteExtensionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal WebSiteExtensionResource(ArmClient client, SiteExtensionInfoData data) : base(client, data)
        {
            _webSiteExtensionWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string webSiteExtensionWebAppsApiVersion);
            _webSiteExtensionWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, webSiteExtensionWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="WebSiteExtensionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal WebSiteExtensionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _webSiteExtensionWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string webSiteExtensionWebAppsApiVersion);
            _webSiteExtensionWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, webSiteExtensionWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/siteextensions";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Description for Get site extension information by its ID for a web site, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/siteextensions/{siteExtensionId}
        /// Operation Id: WebApps_GetSiteExtension
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<SiteExtensionInfoResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _webSiteExtensionWebAppsClientDiagnostics.CreateScope("WebSiteExtensionResource.GetCore");
            scope.Start();
            try
            {
                var response = await _webSiteExtensionWebAppsRestClient.GetSiteExtensionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// Description for Get site extension information by its ID for a web site, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/siteextensions/{siteExtensionId}
        /// Operation Id: WebApps_GetSiteExtension
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new async Task<Response<WebSiteExtensionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var result = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((WebSiteExtensionResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Description for Get site extension information by its ID for a web site, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/siteextensions/{siteExtensionId}
        /// Operation Id: WebApps_GetSiteExtension
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<SiteExtensionInfoResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _webSiteExtensionWebAppsClientDiagnostics.CreateScope("WebSiteExtensionResource.GetCore");
            scope.Start();
            try
            {
                var response = _webSiteExtensionWebAppsRestClient.GetSiteExtension(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
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
        /// Description for Get site extension information by its ID for a web site, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/siteextensions/{siteExtensionId}
        /// Operation Id: WebApps_GetSiteExtension
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new Response<WebSiteExtensionResource> Get(CancellationToken cancellationToken = default)
        {
            var result = GetCore(cancellationToken);
            return Response.FromValue((WebSiteExtensionResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation Delete
        /// Description for Remove a site extension from a web site, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/siteextensions/{siteExtensionId}
        /// Operation Id: WebApps_DeleteSiteExtension
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<ArmOperation> DeleteCoreAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _webSiteExtensionWebAppsClientDiagnostics.CreateScope("WebSiteExtensionResource.DeleteCore");
            scope.Start();
            try
            {
                var response = await _webSiteExtensionWebAppsRestClient.DeleteSiteExtensionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// Description for Remove a site extension from a web site, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/siteextensions/{siteExtensionId}
        /// Operation Id: WebApps_DeleteSiteExtension
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override ArmOperation DeleteCore(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _webSiteExtensionWebAppsClientDiagnostics.CreateScope("WebSiteExtensionResource.DeleteCore");
            scope.Start();
            try
            {
                var response = _webSiteExtensionWebAppsRestClient.DeleteSiteExtension(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
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
        /// Description for Install site extension on a web site, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/siteextensions/{siteExtensionId}
        /// Operation Id: WebApps_InstallSiteExtension
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<ArmOperation<SiteExtensionInfoResource>> UpdateCoreAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _webSiteExtensionWebAppsClientDiagnostics.CreateScope("WebSiteExtensionResource.UpdateCore");
            scope.Start();
            try
            {
                var response = await _webSiteExtensionWebAppsRestClient.InstallSiteExtensionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<SiteExtensionInfoResource>(new SiteExtensionInfoOperationSource(Client), _webSiteExtensionWebAppsClientDiagnostics, Pipeline, _webSiteExtensionWebAppsRestClient.CreateInstallSiteExtensionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Install site extension on a web site, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/siteextensions/{siteExtensionId}
        /// Operation Id: WebApps_InstallSiteExtension
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new async Task<ArmOperation<WebSiteExtensionResource>> UpdateAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            var result = await UpdateCoreAsync(waitUntil, cancellationToken).ConfigureAwait(false);
            if (waitUntil == WaitUntil.Completed)
            {
                return new AppServiceArmOperation<WebSiteExtensionResource>(Response.FromValue((WebSiteExtensionResource)result.Value, result.GetRawResponse()));
            }
            var operation = new AppServiceArmOperation<WebSiteExtensionResource>(new WebSiteExtensionOperationSource(Client), _webSiteExtensionWebAppsClientDiagnostics, Pipeline, _webSiteExtensionWebAppsRestClient.CreateInstallSiteExtensionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, result.GetRawResponse(), OperationFinalStateVia.Location);
            return operation;
        }

        /// <summary>
        /// The core implementation for operation Update
        /// Description for Install site extension on a web site, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/siteextensions/{siteExtensionId}
        /// Operation Id: WebApps_InstallSiteExtension
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override ArmOperation<SiteExtensionInfoResource> UpdateCore(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _webSiteExtensionWebAppsClientDiagnostics.CreateScope("WebSiteExtensionResource.UpdateCore");
            scope.Start();
            try
            {
                var response = _webSiteExtensionWebAppsRestClient.InstallSiteExtension(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new AppServiceArmOperation<SiteExtensionInfoResource>(new SiteExtensionInfoOperationSource(Client), _webSiteExtensionWebAppsClientDiagnostics, Pipeline, _webSiteExtensionWebAppsRestClient.CreateInstallSiteExtensionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Install site extension on a web site, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/siteextensions/{siteExtensionId}
        /// Operation Id: WebApps_InstallSiteExtension
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new ArmOperation<WebSiteExtensionResource> Update(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            var result = UpdateCore(waitUntil, cancellationToken);
            if (waitUntil == WaitUntil.Completed)
            {
                return new AppServiceArmOperation<WebSiteExtensionResource>(Response.FromValue((WebSiteExtensionResource)result.Value, result.GetRawResponse()));
            }
            var operation = new AppServiceArmOperation<WebSiteExtensionResource>(new WebSiteExtensionOperationSource(Client), _webSiteExtensionWebAppsClientDiagnostics, Pipeline, _webSiteExtensionWebAppsRestClient.CreateInstallSiteExtensionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, result.GetRawResponse(), OperationFinalStateVia.Location);
            return operation;
        }
    }
}
