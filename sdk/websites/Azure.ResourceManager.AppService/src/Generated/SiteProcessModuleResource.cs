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
    /// A Class representing a SiteProcessModule along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SiteProcessModuleResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSiteProcessModuleResource method.
    /// Otherwise you can get one from its parent resource <see cref="SiteProcessResource" /> using the GetSiteProcessModule method.
    /// </summary>
    public partial class SiteProcessModuleResource : ProcessModuleInfoResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteProcessModuleResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string processId, string baseAddress)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/processes/{processId}/modules/{baseAddress}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteProcessModuleWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteProcessModuleWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteProcessModuleResource"/> class for mocking. </summary>
        protected SiteProcessModuleResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SiteProcessModuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteProcessModuleResource(ArmClient client, ProcessModuleInfoData data) : base(client, data)
        {
            _siteProcessModuleWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string siteProcessModuleWebAppsApiVersion);
            _siteProcessModuleWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteProcessModuleWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="SiteProcessModuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteProcessModuleResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteProcessModuleWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string siteProcessModuleWebAppsApiVersion);
            _siteProcessModuleWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteProcessModuleWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/processes/modules";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Description for Get process information by its ID for a specific scaled-out instance in a web site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/processes/{processId}/modules/{baseAddress}
        /// Operation Id: WebApps_GetProcessModule
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<ProcessModuleInfoResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteProcessModuleWebAppsClientDiagnostics.CreateScope("SiteProcessModuleResource.GetCore");
            scope.Start();
            try
            {
                var response = await _siteProcessModuleWebAppsRestClient.GetProcessModuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/processes/{processId}/modules/{baseAddress}
        /// Operation Id: WebApps_GetProcessModule
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new async Task<Response<SiteProcessModuleResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var result = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((SiteProcessModuleResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Description for Get process information by its ID for a specific scaled-out instance in a web site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/processes/{processId}/modules/{baseAddress}
        /// Operation Id: WebApps_GetProcessModule
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<ProcessModuleInfoResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _siteProcessModuleWebAppsClientDiagnostics.CreateScope("SiteProcessModuleResource.GetCore");
            scope.Start();
            try
            {
                var response = _siteProcessModuleWebAppsRestClient.GetProcessModule(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/processes/{processId}/modules/{baseAddress}
        /// Operation Id: WebApps_GetProcessModule
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new Response<SiteProcessModuleResource> Get(CancellationToken cancellationToken = default)
        {
            var result = GetCore(cancellationToken);
            return Response.FromValue((SiteProcessModuleResource)result.Value, result.GetRawResponse());
        }
    }
}
