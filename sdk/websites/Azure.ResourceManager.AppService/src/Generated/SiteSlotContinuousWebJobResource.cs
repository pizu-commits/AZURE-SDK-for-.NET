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
    /// A Class representing a SiteSlotContinuousWebJob along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SiteSlotContinuousWebJobResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSiteSlotContinuousWebJobResource method.
    /// Otherwise you can get one from its parent resource <see cref="SiteSlotResource" /> using the GetSiteSlotContinuousWebJob method.
    /// </summary>
    public partial class SiteSlotContinuousWebJobResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteSlotContinuousWebJobResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot, string webJobName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/continuouswebjobs/{webJobName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteSlotContinuousWebJobWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteSlotContinuousWebJobWebAppsRestClient;
        private readonly ContinuousWebJobData _data;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotContinuousWebJobResource"/> class for mocking. </summary>
        protected SiteSlotContinuousWebJobResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SiteSlotContinuousWebJobResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteSlotContinuousWebJobResource(ArmClient client, ContinuousWebJobData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotContinuousWebJobResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteSlotContinuousWebJobResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSlotContinuousWebJobWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string siteSlotContinuousWebJobWebAppsApiVersion);
            _siteSlotContinuousWebJobWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteSlotContinuousWebJobWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/slots/continuouswebjobs";

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

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a continuous web job by its ID for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/continuouswebjobs/{webJobName}
        /// Operation Id: WebApps_GetContinuousWebJobSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SiteSlotContinuousWebJobResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotContinuousWebJobWebAppsClientDiagnostics.CreateScope("SiteSlotContinuousWebJobResource.Get");
            scope.Start();
            try
            {
                var response = await _siteSlotContinuousWebJobWebAppsRestClient.GetContinuousWebJobSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotContinuousWebJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a continuous web job by its ID for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/continuouswebjobs/{webJobName}
        /// Operation Id: WebApps_GetContinuousWebJobSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SiteSlotContinuousWebJobResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotContinuousWebJobWebAppsClientDiagnostics.CreateScope("SiteSlotContinuousWebJobResource.Get");
            scope.Start();
            try
            {
                var response = _siteSlotContinuousWebJobWebAppsRestClient.GetContinuousWebJobSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotContinuousWebJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a continuous web job by its ID for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/continuouswebjobs/{webJobName}
        /// Operation Id: WebApps_DeleteContinuousWebJobSlot
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotContinuousWebJobWebAppsClientDiagnostics.CreateScope("SiteSlotContinuousWebJobResource.Delete");
            scope.Start();
            try
            {
                var response = await _siteSlotContinuousWebJobWebAppsRestClient.DeleteContinuousWebJobSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// Delete a continuous web job by its ID for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/continuouswebjobs/{webJobName}
        /// Operation Id: WebApps_DeleteContinuousWebJobSlot
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotContinuousWebJobWebAppsClientDiagnostics.CreateScope("SiteSlotContinuousWebJobResource.Delete");
            scope.Start();
            try
            {
                var response = _siteSlotContinuousWebJobWebAppsRestClient.DeleteContinuousWebJobSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
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
        /// Start a continuous web job for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/continuouswebjobs/{webJobName}/start
        /// Operation Id: WebApps_StartContinuousWebJobSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> StartContinuousWebJobSlotAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotContinuousWebJobWebAppsClientDiagnostics.CreateScope("SiteSlotContinuousWebJobResource.StartContinuousWebJobSlot");
            scope.Start();
            try
            {
                var response = await _siteSlotContinuousWebJobWebAppsRestClient.StartContinuousWebJobSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Start a continuous web job for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/continuouswebjobs/{webJobName}/start
        /// Operation Id: WebApps_StartContinuousWebJobSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response StartContinuousWebJobSlot(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotContinuousWebJobWebAppsClientDiagnostics.CreateScope("SiteSlotContinuousWebJobResource.StartContinuousWebJobSlot");
            scope.Start();
            try
            {
                var response = _siteSlotContinuousWebJobWebAppsRestClient.StartContinuousWebJobSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Stop a continuous web job for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/continuouswebjobs/{webJobName}/stop
        /// Operation Id: WebApps_StopContinuousWebJobSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> StopContinuousWebJobSlotAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotContinuousWebJobWebAppsClientDiagnostics.CreateScope("SiteSlotContinuousWebJobResource.StopContinuousWebJobSlot");
            scope.Start();
            try
            {
                var response = await _siteSlotContinuousWebJobWebAppsRestClient.StopContinuousWebJobSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Stop a continuous web job for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/continuouswebjobs/{webJobName}/stop
        /// Operation Id: WebApps_StopContinuousWebJobSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response StopContinuousWebJobSlot(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotContinuousWebJobWebAppsClientDiagnostics.CreateScope("SiteSlotContinuousWebJobResource.StopContinuousWebJobSlot");
            scope.Start();
            try
            {
                var response = _siteSlotContinuousWebJobWebAppsRestClient.StopContinuousWebJobSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
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
