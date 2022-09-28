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
    /// A Class representing a HostingEnvironmentPrivateEndpointConnection along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="HostingEnvironmentPrivateEndpointConnectionResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetHostingEnvironmentPrivateEndpointConnectionResource method.
    /// Otherwise you can get one from its parent resource <see cref="AppServiceEnvironmentResource" /> using the GetHostingEnvironmentPrivateEndpointConnection method.
    /// </summary>
    public partial class HostingEnvironmentPrivateEndpointConnectionResource : RemotePrivateEndpointConnectionARMResource
    {
        /// <summary> Generate the resource identifier of a <see cref="HostingEnvironmentPrivateEndpointConnectionResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string privateEndpointConnectionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/privateEndpointConnections/{privateEndpointConnectionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsClientDiagnostics;
        private readonly AppServiceEnvironmentsRestOperations _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsRestClient;

        /// <summary> Initializes a new instance of the <see cref="HostingEnvironmentPrivateEndpointConnectionResource"/> class for mocking. </summary>
        protected HostingEnvironmentPrivateEndpointConnectionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "HostingEnvironmentPrivateEndpointConnectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal HostingEnvironmentPrivateEndpointConnectionResource(ArmClient client, RemotePrivateEndpointConnectionARMResourceData data) : base(client, data)
        {
            _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsApiVersion);
            _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsRestClient = new AppServiceEnvironmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="HostingEnvironmentPrivateEndpointConnectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal HostingEnvironmentPrivateEndpointConnectionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsApiVersion);
            _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsRestClient = new AppServiceEnvironmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/hostingEnvironments/privateEndpointConnections";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Gets a private endpoint connection
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: AppServiceEnvironments_GetPrivateEndpointConnection
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<RemotePrivateEndpointConnectionARMResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentPrivateEndpointConnectionResource.Get");
            scope.Start();
            try
            {
                var response = await _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsRestClient.GetPrivateEndpointConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: AppServiceEnvironments_GetPrivateEndpointConnection
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new async Task<Response<HostingEnvironmentPrivateEndpointConnectionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var result = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((HostingEnvironmentPrivateEndpointConnectionResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// Description for Gets a private endpoint connection
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: AppServiceEnvironments_GetPrivateEndpointConnection
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<RemotePrivateEndpointConnectionARMResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentPrivateEndpointConnectionResource.Get");
            scope.Start();
            try
            {
                var response = _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsRestClient.GetPrivateEndpointConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: AppServiceEnvironments_GetPrivateEndpointConnection
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new Response<HostingEnvironmentPrivateEndpointConnectionResource> Get(CancellationToken cancellationToken = default)
        {
            var result = GetCore(cancellationToken);
            return Response.FromValue((HostingEnvironmentPrivateEndpointConnectionResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// Description for Deletes a private endpoint connection
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: AppServiceEnvironments_DeletePrivateEndpointConnection
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<ArmOperation<BinaryData>> DeleteCoreAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentPrivateEndpointConnectionResource.Delete");
            scope.Start();
            try
            {
                var response = await _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsRestClient.DeletePrivateEndpointConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<BinaryData>(new BinaryDataOperationSource(), _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsClientDiagnostics, Pipeline, _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsRestClient.CreateDeletePrivateEndpointConnectionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Deletes a private endpoint connection
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: AppServiceEnvironments_DeletePrivateEndpointConnection
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override ArmOperation<BinaryData> DeleteCore(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentPrivateEndpointConnectionResource.Delete");
            scope.Start();
            try
            {
                var response = _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsRestClient.DeletePrivateEndpointConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new AppServiceArmOperation<BinaryData>(new BinaryDataOperationSource(), _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsClientDiagnostics, Pipeline, _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsRestClient.CreateDeletePrivateEndpointConnectionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: AppServiceEnvironments_ApproveOrRejectPrivateEndpointConnection
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="info"> The PrivateLinkConnectionApprovalRequestInfo to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="info"/> is null. </exception>
        protected override async Task<ArmOperation<RemotePrivateEndpointConnectionARMResource>> UpdateCoreAsync(WaitUntil waitUntil, PrivateLinkConnectionApprovalRequestInfo info, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(info, nameof(info));

            using var scope = _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentPrivateEndpointConnectionResource.Update");
            scope.Start();
            try
            {
                var response = await _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsRestClient.ApproveOrRejectPrivateEndpointConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, info, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<RemotePrivateEndpointConnectionARMResource>(new RemotePrivateEndpointConnectionARMResourceOperationSource(Client), _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsClientDiagnostics, Pipeline, _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsRestClient.CreateApproveOrRejectPrivateEndpointConnectionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, info).Request, response, OperationFinalStateVia.Location);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: AppServiceEnvironments_ApproveOrRejectPrivateEndpointConnection
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="info"> The PrivateLinkConnectionApprovalRequestInfo to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="info"/> is null. </exception>
        [ForwardsClientCalls]
        public new async Task<ArmOperation<HostingEnvironmentPrivateEndpointConnectionResource>> UpdateAsync(WaitUntil waitUntil, PrivateLinkConnectionApprovalRequestInfo info, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(info, nameof(info));

            var result = await UpdateCoreAsync(waitUntil, info, cancellationToken).ConfigureAwait(false);
            if (waitUntil == WaitUntil.Completed)
            {
                return new AppServiceArmOperation<HostingEnvironmentPrivateEndpointConnectionResource>(Response.FromValue((HostingEnvironmentPrivateEndpointConnectionResource)result.Value, result.GetRawResponse()));
            }
            var operation = new AppServiceArmOperation<HostingEnvironmentPrivateEndpointConnectionResource>(new HostingEnvironmentPrivateEndpointConnectionOperationSource(Client), _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsClientDiagnostics, Pipeline, _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsRestClient.CreateApproveOrRejectPrivateEndpointConnectionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, info).Request, result.GetRawResponse(), OperationFinalStateVia.Location);
            return operation;
        }

        /// <summary>
        /// Description for Approves or rejects a private endpoint connection
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: AppServiceEnvironments_ApproveOrRejectPrivateEndpointConnection
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="info"> The PrivateLinkConnectionApprovalRequestInfo to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="info"/> is null. </exception>
        protected override ArmOperation<RemotePrivateEndpointConnectionARMResource> UpdateCore(WaitUntil waitUntil, PrivateLinkConnectionApprovalRequestInfo info, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(info, nameof(info));

            using var scope = _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentPrivateEndpointConnectionResource.Update");
            scope.Start();
            try
            {
                var response = _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsRestClient.ApproveOrRejectPrivateEndpointConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, info, cancellationToken);
                var operation = new AppServiceArmOperation<RemotePrivateEndpointConnectionARMResource>(new RemotePrivateEndpointConnectionARMResourceOperationSource(Client), _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsClientDiagnostics, Pipeline, _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsRestClient.CreateApproveOrRejectPrivateEndpointConnectionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, info).Request, response, OperationFinalStateVia.Location);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: AppServiceEnvironments_ApproveOrRejectPrivateEndpointConnection
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="info"> The PrivateLinkConnectionApprovalRequestInfo to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="info"/> is null. </exception>
        [ForwardsClientCalls]
        public new ArmOperation<HostingEnvironmentPrivateEndpointConnectionResource> Update(WaitUntil waitUntil, PrivateLinkConnectionApprovalRequestInfo info, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(info, nameof(info));

            var result = UpdateCore(waitUntil, info, cancellationToken);
            if (waitUntil == WaitUntil.Completed)
            {
                return new AppServiceArmOperation<HostingEnvironmentPrivateEndpointConnectionResource>(Response.FromValue((HostingEnvironmentPrivateEndpointConnectionResource)result.Value, result.GetRawResponse()));
            }
            var operation = new AppServiceArmOperation<HostingEnvironmentPrivateEndpointConnectionResource>(new HostingEnvironmentPrivateEndpointConnectionOperationSource(Client), _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsClientDiagnostics, Pipeline, _hostingEnvironmentPrivateEndpointConnectionAppServiceEnvironmentsRestClient.CreateApproveOrRejectPrivateEndpointConnectionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, info).Request, result.GetRawResponse(), OperationFinalStateVia.Location);
            return operation;
        }
    }
}
