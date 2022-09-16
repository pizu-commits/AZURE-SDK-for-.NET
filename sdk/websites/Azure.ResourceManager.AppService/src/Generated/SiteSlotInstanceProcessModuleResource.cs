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
    /// A Class representing a SiteSlotInstanceProcessModule along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SiteSlotInstanceProcessModuleResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSiteSlotInstanceProcessModuleResource method.
    /// Otherwise you can get one from its parent resource <see cref="SiteSlotInstanceProcessResource" /> using the GetSiteSlotInstanceProcessModule method.
    /// </summary>
    public partial class SiteSlotInstanceProcessModuleResource : ProcessModuleInfoResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteSlotInstanceProcessModuleResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot, string instanceId, string processId, string baseAddress)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/instances/{instanceId}/processes/{processId}/modules/{baseAddress}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteSlotInstanceProcessModuleWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteSlotInstanceProcessModuleWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotInstanceProcessModuleResource"/> class for mocking. </summary>
        protected SiteSlotInstanceProcessModuleResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SiteSlotInstanceProcessModuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteSlotInstanceProcessModuleResource(ArmClient client, ProcessModuleInfoData data) : base(client, data)
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotInstanceProcessModuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteSlotInstanceProcessModuleResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSlotInstanceProcessModuleWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string siteSlotInstanceProcessModuleWebAppsApiVersion);
            _siteSlotInstanceProcessModuleWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteSlotInstanceProcessModuleWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/slots/instances/processes/modules";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> The core implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<ProcessModuleInfoResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotInstanceProcessModuleWebAppsClientDiagnostics.CreateScope("SiteSlotInstanceProcessModuleResource.Get");
            scope.Start();
            try
            {
                var response = await _siteSlotInstanceProcessModuleWebAppsRestClient.GetInstanceProcessModuleSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// Description for Get process information by its ID for a specific scaled-out instance in a web site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/instances/{instanceId}/processes/{processId}/modules/{baseAddress}
        /// Operation Id: WebApps_GetInstanceProcessModuleSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new virtual async Task<Response<SiteSlotInstanceProcessModuleResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var value = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((SiteSlotInstanceProcessModuleResource)value.Value, value.GetRawResponse());
        }

        /// <summary> The core implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<ProcessModuleInfoResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotInstanceProcessModuleWebAppsClientDiagnostics.CreateScope("SiteSlotInstanceProcessModuleResource.Get");
            scope.Start();
            try
            {
                var response = _siteSlotInstanceProcessModuleWebAppsRestClient.GetInstanceProcessModuleSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
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
        /// Description for Get process information by its ID for a specific scaled-out instance in a web site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/instances/{instanceId}/processes/{processId}/modules/{baseAddress}
        /// Operation Id: WebApps_GetInstanceProcessModuleSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new virtual Response<SiteSlotInstanceProcessModuleResource> Get(CancellationToken cancellationToken = default)
        {
            var value = GetCore(cancellationToken);
            return Response.FromValue((SiteSlotInstanceProcessModuleResource)value.Value, value.GetRawResponse());
        }
    }
}
