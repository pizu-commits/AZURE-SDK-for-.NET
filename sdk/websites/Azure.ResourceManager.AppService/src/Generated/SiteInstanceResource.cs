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
    /// A Class representing a SiteInstance along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SiteInstanceResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSiteInstanceResource method.
    /// Otherwise you can get one from its parent resource <see cref="WebSiteResource" /> using the GetSiteInstance method.
    /// </summary>
    public partial class SiteInstanceResource : WebSiteInstanceStatusResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteInstanceResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string instanceId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteInstanceWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteInstanceWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteInstanceResource"/> class for mocking. </summary>
        protected SiteInstanceResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SiteInstanceResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteInstanceResource(ArmClient client, WebSiteInstanceStatusData data) : base(client, data)
        {
            _siteInstanceWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string siteInstanceWebAppsApiVersion);
            _siteInstanceWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteInstanceWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="SiteInstanceResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteInstanceResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteInstanceWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string siteInstanceWebAppsApiVersion);
            _siteInstanceWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteInstanceWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/instances";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets an object representing a SiteInstanceExtensionResource along with the instance operations that can be performed on it in the SiteInstance. </summary>
        /// <returns> Returns a <see cref="SiteInstanceExtensionResource" /> object. </returns>
        public virtual SiteInstanceExtensionResource GetSiteInstanceExtension()
        {
            return new SiteInstanceExtensionResource(Client, new ResourceIdentifier(Id.ToString() + "/extensions/MSDeploy"));
        }

        /// <summary> Gets a collection of SiteInstanceProcessResources in the SiteInstance. </summary>
        /// <returns> An object representing collection of SiteInstanceProcessResources and their operations over a SiteInstanceProcessResource. </returns>
        public virtual SiteInstanceProcessCollection GetSiteInstanceProcesses()
        {
            return GetCachedClient(Client => new SiteInstanceProcessCollection(Client, Id));
        }

        /// <summary>
        /// Description for Get process information by its ID for a specific scaled-out instance in a web site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}/processes/{processId}
        /// Operation Id: WebApps_GetInstanceProcess
        /// </summary>
        /// <param name="processId"> PID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="processId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="processId"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SiteInstanceProcessResource>> GetSiteInstanceProcessAsync(string processId, CancellationToken cancellationToken = default)
        {
            return await GetSiteInstanceProcesses().GetAsync(processId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Description for Get process information by its ID for a specific scaled-out instance in a web site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}/processes/{processId}
        /// Operation Id: WebApps_GetInstanceProcess
        /// </summary>
        /// <param name="processId"> PID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="processId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="processId"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<SiteInstanceProcessResource> GetSiteInstanceProcess(string processId, CancellationToken cancellationToken = default)
        {
            return GetSiteInstanceProcesses().Get(processId, cancellationToken);
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Description for Gets all scale-out instances of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}
        /// Operation Id: WebApps_GetInstanceInfo
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<WebSiteInstanceStatusResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteInstanceWebAppsClientDiagnostics.CreateScope("SiteInstanceResource.GetCore");
            scope.Start();
            try
            {
                var response = await _siteInstanceWebAppsRestClient.GetInstanceInfoAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// Description for Gets all scale-out instances of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}
        /// Operation Id: WebApps_GetInstanceInfo
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new async Task<Response<SiteInstanceResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var result = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((SiteInstanceResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Description for Gets all scale-out instances of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}
        /// Operation Id: WebApps_GetInstanceInfo
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<WebSiteInstanceStatusResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _siteInstanceWebAppsClientDiagnostics.CreateScope("SiteInstanceResource.GetCore");
            scope.Start();
            try
            {
                var response = _siteInstanceWebAppsRestClient.GetInstanceInfo(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
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
        /// Description for Gets all scale-out instances of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}
        /// Operation Id: WebApps_GetInstanceInfo
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new Response<SiteInstanceResource> Get(CancellationToken cancellationToken = default)
        {
            var result = GetCore(cancellationToken);
            return Response.FromValue((SiteInstanceResource)result.Value, result.GetRawResponse());
        }
    }
}
