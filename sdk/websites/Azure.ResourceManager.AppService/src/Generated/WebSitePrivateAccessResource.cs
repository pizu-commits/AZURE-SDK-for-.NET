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
    /// A Class representing a WebSitePrivateAccess along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="WebSitePrivateAccessResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetWebSitePrivateAccessResource method.
    /// Otherwise you can get one from its parent resource <see cref="WebSiteResource" /> using the GetWebSitePrivateAccess method.
    /// </summary>
    public partial class WebSitePrivateAccessResource : PrivateAccessResource
    {
        /// <summary> Generate the resource identifier of a <see cref="WebSitePrivateAccessResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/privateAccess/virtualNetworks";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _webSitePrivateAccessWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _webSitePrivateAccessWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="WebSitePrivateAccessResource"/> class for mocking. </summary>
        protected WebSitePrivateAccessResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "WebSitePrivateAccessResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal WebSitePrivateAccessResource(ArmClient client, PrivateAccessData data) : base(client, data)
        {
            _webSitePrivateAccessWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string webSitePrivateAccessWebAppsApiVersion);
            _webSitePrivateAccessWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, webSitePrivateAccessWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="WebSitePrivateAccessResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal WebSitePrivateAccessResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _webSitePrivateAccessWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string webSitePrivateAccessWebAppsApiVersion);
            _webSitePrivateAccessWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, webSitePrivateAccessWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/privateAccess";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Description for Gets data around private site access enablement and authorized Virtual Networks that can access the site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/privateAccess/virtualNetworks
        /// Operation Id: WebApps_GetPrivateAccess
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<PrivateAccessResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _webSitePrivateAccessWebAppsClientDiagnostics.CreateScope("WebSitePrivateAccessResource.GetCore");
            scope.Start();
            try
            {
                var response = await _webSitePrivateAccessWebAppsRestClient.GetPrivateAccessAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
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
        /// Description for Gets data around private site access enablement and authorized Virtual Networks that can access the site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/privateAccess/virtualNetworks
        /// Operation Id: WebApps_GetPrivateAccess
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new async Task<Response<WebSitePrivateAccessResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var result = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((WebSitePrivateAccessResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Description for Gets data around private site access enablement and authorized Virtual Networks that can access the site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/privateAccess/virtualNetworks
        /// Operation Id: WebApps_GetPrivateAccess
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<PrivateAccessResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _webSitePrivateAccessWebAppsClientDiagnostics.CreateScope("WebSitePrivateAccessResource.GetCore");
            scope.Start();
            try
            {
                var response = _webSitePrivateAccessWebAppsRestClient.GetPrivateAccess(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken);
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
        /// Description for Gets data around private site access enablement and authorized Virtual Networks that can access the site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/privateAccess/virtualNetworks
        /// Operation Id: WebApps_GetPrivateAccess
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new Response<WebSitePrivateAccessResource> Get(CancellationToken cancellationToken = default)
        {
            var result = GetCore(cancellationToken);
            return Response.FromValue((WebSitePrivateAccessResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation CreateOrUpdate
        /// Description for Sets data around private site access enablement and authorized Virtual Networks that can access the site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/privateAccess/virtualNetworks
        /// Operation Id: WebApps_PutPrivateAccessVnet
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The information for the private access. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        protected override async Task<ArmOperation<PrivateAccessResource>> CreateOrUpdateCoreAsync(WaitUntil waitUntil, PrivateAccessData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _webSitePrivateAccessWebAppsClientDiagnostics.CreateScope("WebSitePrivateAccessResource.CreateOrUpdateCore");
            scope.Start();
            try
            {
                var response = await _webSitePrivateAccessWebAppsRestClient.PutPrivateAccessVnetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<PrivateAccessResource>(Response.FromValue(GetResource(Client, response), response.GetRawResponse()));
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
        /// Description for Sets data around private site access enablement and authorized Virtual Networks that can access the site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/privateAccess/virtualNetworks
        /// Operation Id: WebApps_PutPrivateAccessVnet
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The information for the private access. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        [ForwardsClientCalls]
        public new async Task<ArmOperation<WebSitePrivateAccessResource>> CreateOrUpdateAsync(WaitUntil waitUntil, PrivateAccessData data, CancellationToken cancellationToken = default)
        {
            var result = await CreateOrUpdateCoreAsync(waitUntil, data, cancellationToken).ConfigureAwait(false);
            return new AppServiceArmOperation<WebSitePrivateAccessResource>(Response.FromValue((WebSitePrivateAccessResource)result.Value, result.GetRawResponse()));
        }

        /// <summary>
        /// The core implementation for operation CreateOrUpdate
        /// Description for Sets data around private site access enablement and authorized Virtual Networks that can access the site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/privateAccess/virtualNetworks
        /// Operation Id: WebApps_PutPrivateAccessVnet
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The information for the private access. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        protected override ArmOperation<PrivateAccessResource> CreateOrUpdateCore(WaitUntil waitUntil, PrivateAccessData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _webSitePrivateAccessWebAppsClientDiagnostics.CreateScope("WebSitePrivateAccessResource.CreateOrUpdateCore");
            scope.Start();
            try
            {
                var response = _webSitePrivateAccessWebAppsRestClient.PutPrivateAccessVnet(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, cancellationToken);
                var operation = new AppServiceArmOperation<PrivateAccessResource>(Response.FromValue(GetResource(Client, response), response.GetRawResponse()));
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
        /// Description for Sets data around private site access enablement and authorized Virtual Networks that can access the site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/privateAccess/virtualNetworks
        /// Operation Id: WebApps_PutPrivateAccessVnet
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The information for the private access. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        [ForwardsClientCalls]
        public new ArmOperation<WebSitePrivateAccessResource> CreateOrUpdate(WaitUntil waitUntil, PrivateAccessData data, CancellationToken cancellationToken = default)
        {
            var result = CreateOrUpdateCore(waitUntil, data, cancellationToken);
            return new AppServiceArmOperation<WebSitePrivateAccessResource>(Response.FromValue((WebSitePrivateAccessResource)result.Value, result.GetRawResponse()));
        }
    }
}
