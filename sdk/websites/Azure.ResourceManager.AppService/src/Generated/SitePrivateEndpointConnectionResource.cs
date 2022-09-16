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
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A Class representing a SitePrivateEndpointConnection along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SitePrivateEndpointConnectionResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSitePrivateEndpointConnectionResource method.
    /// Otherwise you can get one from its parent resource <see cref="WebSiteResource" /> using the GetSitePrivateEndpointConnection method.
    /// </summary>
    public partial class SitePrivateEndpointConnectionResource : RemotePrivateEndpointConnectionARMResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SitePrivateEndpointConnectionResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string privateEndpointConnectionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/privateEndpointConnections/{privateEndpointConnectionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _sitePrivateEndpointConnectionWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _sitePrivateEndpointConnectionWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SitePrivateEndpointConnectionResource"/> class for mocking. </summary>
        protected SitePrivateEndpointConnectionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SitePrivateEndpointConnectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SitePrivateEndpointConnectionResource(ArmClient client, RemotePrivateEndpointConnectionARMResourceData data) : base(client, data)
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SitePrivateEndpointConnectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SitePrivateEndpointConnectionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sitePrivateEndpointConnectionWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string sitePrivateEndpointConnectionWebAppsApiVersion);
            _sitePrivateEndpointConnectionWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sitePrivateEndpointConnectionWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/privateEndpointConnections";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> The core implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<RemotePrivateEndpointConnectionARMResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _sitePrivateEndpointConnectionWebAppsClientDiagnostics.CreateScope("SitePrivateEndpointConnectionResource.Get");
            scope.Start();
            try
            {
                var response = await _sitePrivateEndpointConnectionWebAppsRestClient.GetPrivateEndpointConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// Description for Gets a private endpoint connection
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: WebApps_GetPrivateEndpointConnection
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new virtual async Task<Response<SitePrivateEndpointConnectionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var value = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((SitePrivateEndpointConnectionResource)value.Value, value.GetRawResponse());
        }

        /// <summary> The core implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<RemotePrivateEndpointConnectionARMResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _sitePrivateEndpointConnectionWebAppsClientDiagnostics.CreateScope("SitePrivateEndpointConnectionResource.Get");
            scope.Start();
            try
            {
                var response = _sitePrivateEndpointConnectionWebAppsRestClient.GetPrivateEndpointConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
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
        /// Description for Gets a private endpoint connection
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: WebApps_GetPrivateEndpointConnection
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new virtual Response<SitePrivateEndpointConnectionResource> Get(CancellationToken cancellationToken = default)
        {
            var value = GetCore(cancellationToken);
            return Response.FromValue((SitePrivateEndpointConnectionResource)value.Value, value.GetRawResponse());
        }

        /// <summary> The core implementation for operation Delete. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<ArmOperation<BinaryData>> DeleteCoreAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _sitePrivateEndpointConnectionWebAppsClientDiagnostics.CreateScope("SitePrivateEndpointConnectionResource.Delete");
            scope.Start();
            try
            {
                var response = await _sitePrivateEndpointConnectionWebAppsRestClient.DeletePrivateEndpointConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<BinaryData>(new RemotePrivateEndpointConnectionARMResourceOperationSource(Client), _sitePrivateEndpointConnectionWebAppsClientDiagnostics, Pipeline, _sitePrivateEndpointConnectionWebAppsRestClient.CreateDeletePrivateEndpointConnectionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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

        /// <summary> The core implementation for operation Delete. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override ArmOperation<BinaryData> DeleteCore(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _sitePrivateEndpointConnectionWebAppsClientDiagnostics.CreateScope("SitePrivateEndpointConnectionResource.Delete");
            scope.Start();
            try
            {
                var response = _sitePrivateEndpointConnectionWebAppsRestClient.DeletePrivateEndpointConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new AppServiceArmOperation<BinaryData>(new RemotePrivateEndpointConnectionARMResourceOperationSource(Client), _sitePrivateEndpointConnectionWebAppsClientDiagnostics, Pipeline, _sitePrivateEndpointConnectionWebAppsRestClient.CreateDeletePrivateEndpointConnectionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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

        /// <summary> The core implementation for operation Update. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="info"> The PrivateLinkConnectionApprovalRequestInfo to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="info"/> is null. </exception>
        protected override async Task<ArmOperation<RemotePrivateEndpointConnectionARMResource>> UpdateCoreAsync(WaitUntil waitUntil, PrivateLinkConnectionApprovalRequestInfo info, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(info, nameof(info));

            using var scope = _sitePrivateEndpointConnectionWebAppsClientDiagnostics.CreateScope("SitePrivateEndpointConnectionResource.Update");
            scope.Start();
            try
            {
                var response = await _sitePrivateEndpointConnectionWebAppsRestClient.ApproveOrRejectPrivateEndpointConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, info, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<RemotePrivateEndpointConnectionARMResource>(new RemotePrivateEndpointConnectionARMResourceOperationSource(Client), _sitePrivateEndpointConnectionWebAppsClientDiagnostics, Pipeline, _sitePrivateEndpointConnectionWebAppsRestClient.CreateApproveOrRejectPrivateEndpointConnectionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, info).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Approves or rejects a private endpoint connection
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: WebApps_ApproveOrRejectPrivateEndpointConnection
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="info"> The PrivateLinkConnectionApprovalRequestInfo to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="info"/> is null. </exception>
        [ForwardsClientCalls]
        public new virtual async Task<ArmOperation<SitePrivateEndpointConnectionResource>> UpdateAsync(WaitUntil waitUntil, PrivateLinkConnectionApprovalRequestInfo info, CancellationToken cancellationToken = default)
        {
            var value = await UpdateCoreAsync(waitUntil, info, cancellationToken).ConfigureAwait(false);
            if (waitUntil == WaitUntil.Completed)
            {
                return new AppServiceArmOperation<SitePrivateEndpointConnectionResource>(Response.FromValue((SitePrivateEndpointConnectionResource)value.Value, value.GetRawResponse()));
            }
            var operation = new AppServiceArmOperation<SitePrivateEndpointConnectionResource>(new SitePrivateEndpointConnectionOperationSource(Client), _sitePrivateEndpointConnectionWebAppsClientDiagnostics, Pipeline, _sitePrivateEndpointConnectionWebAppsRestClient.CreateApproveOrRejectPrivateEndpointConnectionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, info).Request, value.GetRawResponse(), OperationFinalStateVia.Location);
            return operation;
        }

        /// <summary> The core implementation for operation Update. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="info"> The PrivateLinkConnectionApprovalRequestInfo to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="info"/> is null. </exception>
        protected override ArmOperation<RemotePrivateEndpointConnectionARMResource> UpdateCore(WaitUntil waitUntil, PrivateLinkConnectionApprovalRequestInfo info, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(info, nameof(info));

            using var scope = _sitePrivateEndpointConnectionWebAppsClientDiagnostics.CreateScope("SitePrivateEndpointConnectionResource.Update");
            scope.Start();
            try
            {
                var response = _sitePrivateEndpointConnectionWebAppsRestClient.ApproveOrRejectPrivateEndpointConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, info, cancellationToken);
                var operation = new AppServiceArmOperation<RemotePrivateEndpointConnectionARMResource>(new RemotePrivateEndpointConnectionARMResourceOperationSource(Client), _sitePrivateEndpointConnectionWebAppsClientDiagnostics, Pipeline, _sitePrivateEndpointConnectionWebAppsRestClient.CreateApproveOrRejectPrivateEndpointConnectionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, info).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Approves or rejects a private endpoint connection
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: WebApps_ApproveOrRejectPrivateEndpointConnection
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="info"> The PrivateLinkConnectionApprovalRequestInfo to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="info"/> is null. </exception>
        [ForwardsClientCalls]
        public new virtual ArmOperation<SitePrivateEndpointConnectionResource> Update(WaitUntil waitUntil, PrivateLinkConnectionApprovalRequestInfo info, CancellationToken cancellationToken = default)
        {
            var value = UpdateCore(waitUntil, info, cancellationToken);
            if (waitUntil == WaitUntil.Completed)
            {
                return new AppServiceArmOperation<SitePrivateEndpointConnectionResource>(Response.FromValue((SitePrivateEndpointConnectionResource)value.Value, value.GetRawResponse()));
            }
            var operation = new AppServiceArmOperation<SitePrivateEndpointConnectionResource>(new SitePrivateEndpointConnectionOperationSource(Client), _sitePrivateEndpointConnectionWebAppsClientDiagnostics, Pipeline, _sitePrivateEndpointConnectionWebAppsRestClient.CreateApproveOrRejectPrivateEndpointConnectionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, info).Request, value.GetRawResponse(), OperationFinalStateVia.Location);
            return operation;
        }
    }
}
