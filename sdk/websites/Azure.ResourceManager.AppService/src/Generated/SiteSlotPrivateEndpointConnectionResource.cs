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
    /// A Class representing a SiteSlotPrivateEndpointConnection along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SiteSlotPrivateEndpointConnectionResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSiteSlotPrivateEndpointConnectionResource method.
    /// Otherwise you can get one from its parent resource <see cref="SiteSlotResource" /> using the GetSiteSlotPrivateEndpointConnection method.
    /// </summary>
    public partial class SiteSlotPrivateEndpointConnectionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteSlotPrivateEndpointConnectionResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot, string privateEndpointConnectionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/privateEndpointConnections/{privateEndpointConnectionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteSlotPrivateEndpointConnectionWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteSlotPrivateEndpointConnectionWebAppsRestClient;
        private readonly RemotePrivateEndpointConnectionARMResourceData _data;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotPrivateEndpointConnectionResource"/> class for mocking. </summary>
        protected SiteSlotPrivateEndpointConnectionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SiteSlotPrivateEndpointConnectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteSlotPrivateEndpointConnectionResource(ArmClient client, RemotePrivateEndpointConnectionARMResourceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotPrivateEndpointConnectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteSlotPrivateEndpointConnectionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSlotPrivateEndpointConnectionWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string siteSlotPrivateEndpointConnectionWebAppsApiVersion);
            _siteSlotPrivateEndpointConnectionWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteSlotPrivateEndpointConnectionWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/slots/privateEndpointConnections";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual RemotePrivateEndpointConnectionARMResourceData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a private endpoint connection
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: WebApps_GetPrivateEndpointConnectionSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SiteSlotPrivateEndpointConnectionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotPrivateEndpointConnectionWebAppsClientDiagnostics.CreateScope("SiteSlotPrivateEndpointConnectionResource.Get");
            scope.Start();
            try
            {
                var response = await _siteSlotPrivateEndpointConnectionWebAppsRestClient.GetPrivateEndpointConnectionSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotPrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a private endpoint connection
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: WebApps_GetPrivateEndpointConnectionSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SiteSlotPrivateEndpointConnectionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotPrivateEndpointConnectionWebAppsClientDiagnostics.CreateScope("SiteSlotPrivateEndpointConnectionResource.Get");
            scope.Start();
            try
            {
                var response = _siteSlotPrivateEndpointConnectionWebAppsRestClient.GetPrivateEndpointConnectionSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotPrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a private endpoint connection
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: WebApps_DeletePrivateEndpointConnectionSlot
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation<BinaryData>> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotPrivateEndpointConnectionWebAppsClientDiagnostics.CreateScope("SiteSlotPrivateEndpointConnectionResource.Delete");
            scope.Start();
            try
            {
                var response = await _siteSlotPrivateEndpointConnectionWebAppsRestClient.DeletePrivateEndpointConnectionSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<BinaryData>(new BinaryDataOperationSource(), _siteSlotPrivateEndpointConnectionWebAppsClientDiagnostics, Pipeline, _siteSlotPrivateEndpointConnectionWebAppsRestClient.CreateDeletePrivateEndpointConnectionSlotRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Deletes a private endpoint connection
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: WebApps_DeletePrivateEndpointConnectionSlot
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<BinaryData> Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotPrivateEndpointConnectionWebAppsClientDiagnostics.CreateScope("SiteSlotPrivateEndpointConnectionResource.Delete");
            scope.Start();
            try
            {
                var response = _siteSlotPrivateEndpointConnectionWebAppsRestClient.DeletePrivateEndpointConnectionSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new AppServiceArmOperation<BinaryData>(new BinaryDataOperationSource(), _siteSlotPrivateEndpointConnectionWebAppsClientDiagnostics, Pipeline, _siteSlotPrivateEndpointConnectionWebAppsRestClient.CreateDeletePrivateEndpointConnectionSlotRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Approves or rejects a private endpoint connection
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: WebApps_ApproveOrRejectPrivateEndpointConnectionSlot
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="privateEndpointWrapper"> The PrivateLinkConnectionApprovalRequestResource to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointWrapper"/> is null. </exception>
        public virtual async Task<ArmOperation<SiteSlotPrivateEndpointConnectionResource>> UpdateAsync(WaitUntil waitUntil, PrivateLinkConnectionApprovalRequestResource privateEndpointWrapper, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(privateEndpointWrapper, nameof(privateEndpointWrapper));

            using var scope = _siteSlotPrivateEndpointConnectionWebAppsClientDiagnostics.CreateScope("SiteSlotPrivateEndpointConnectionResource.Update");
            scope.Start();
            try
            {
                var response = await _siteSlotPrivateEndpointConnectionWebAppsRestClient.ApproveOrRejectPrivateEndpointConnectionSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, privateEndpointWrapper, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<SiteSlotPrivateEndpointConnectionResource>(new SiteSlotPrivateEndpointConnectionOperationSource(Client), _siteSlotPrivateEndpointConnectionWebAppsClientDiagnostics, Pipeline, _siteSlotPrivateEndpointConnectionWebAppsRestClient.CreateApproveOrRejectPrivateEndpointConnectionSlotRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, privateEndpointWrapper).Request, response, OperationFinalStateVia.Location);
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
        /// Approves or rejects a private endpoint connection
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: WebApps_ApproveOrRejectPrivateEndpointConnectionSlot
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="privateEndpointWrapper"> The PrivateLinkConnectionApprovalRequestResource to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointWrapper"/> is null. </exception>
        public virtual ArmOperation<SiteSlotPrivateEndpointConnectionResource> Update(WaitUntil waitUntil, PrivateLinkConnectionApprovalRequestResource privateEndpointWrapper, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(privateEndpointWrapper, nameof(privateEndpointWrapper));

            using var scope = _siteSlotPrivateEndpointConnectionWebAppsClientDiagnostics.CreateScope("SiteSlotPrivateEndpointConnectionResource.Update");
            scope.Start();
            try
            {
                var response = _siteSlotPrivateEndpointConnectionWebAppsRestClient.ApproveOrRejectPrivateEndpointConnectionSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, privateEndpointWrapper, cancellationToken);
                var operation = new AppServiceArmOperation<SiteSlotPrivateEndpointConnectionResource>(new SiteSlotPrivateEndpointConnectionOperationSource(Client), _siteSlotPrivateEndpointConnectionWebAppsClientDiagnostics, Pipeline, _siteSlotPrivateEndpointConnectionWebAppsRestClient.CreateApproveOrRejectPrivateEndpointConnectionSlotRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, privateEndpointWrapper).Request, response, OperationFinalStateVia.Location);
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
    }
}
