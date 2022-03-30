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
    /// A Class representing a SiteConfigSnapshot along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SiteConfigSnapshotResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSiteConfigSnapshotResource method.
    /// Otherwise you can get one from its parent resource <see cref="WebSiteConfigResource" /> using the GetSiteConfigSnapshot method.
    /// </summary>
    public partial class SiteConfigSnapshotResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteConfigSnapshotResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string snapshotId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web/snapshots/{snapshotId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteConfigSnapshotWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteConfigSnapshotWebAppsRestClient;
        private readonly SiteConfigData _data;

        /// <summary> Initializes a new instance of the <see cref="SiteConfigSnapshotResource"/> class for mocking. </summary>
        protected SiteConfigSnapshotResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SiteConfigSnapshotResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteConfigSnapshotResource(ArmClient client, SiteConfigData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SiteConfigSnapshotResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteConfigSnapshotResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteConfigSnapshotWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string siteConfigSnapshotWebAppsApiVersion);
            _siteConfigSnapshotWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteConfigSnapshotWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/config/snapshots";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SiteConfigData Data
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
        /// Description for Gets a snapshot of the configuration of an app at a previous point in time.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web/snapshots/{snapshotId}
        /// Operation Id: WebApps_GetConfigurationSnapshot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SiteConfigSnapshotResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteConfigSnapshotWebAppsClientDiagnostics.CreateScope("SiteConfigSnapshotResource.Get");
            scope.Start();
            try
            {
                var response = await _siteConfigSnapshotWebAppsRestClient.GetConfigurationSnapshotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteConfigSnapshotResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets a snapshot of the configuration of an app at a previous point in time.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web/snapshots/{snapshotId}
        /// Operation Id: WebApps_GetConfigurationSnapshot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SiteConfigSnapshotResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _siteConfigSnapshotWebAppsClientDiagnostics.CreateScope("SiteConfigSnapshotResource.Get");
            scope.Start();
            try
            {
                var response = _siteConfigSnapshotWebAppsRestClient.GetConfigurationSnapshot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteConfigSnapshotResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Reverts the configuration of an app to a previous snapshot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web/snapshots/{snapshotId}/recover
        /// Operation Id: WebApps_RecoverSiteConfigurationSnapshot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> RecoverSiteConfigurationSnapshotAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteConfigSnapshotWebAppsClientDiagnostics.CreateScope("SiteConfigSnapshotResource.RecoverSiteConfigurationSnapshot");
            scope.Start();
            try
            {
                var response = await _siteConfigSnapshotWebAppsRestClient.RecoverSiteConfigurationSnapshotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Reverts the configuration of an app to a previous snapshot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/web/snapshots/{snapshotId}/recover
        /// Operation Id: WebApps_RecoverSiteConfigurationSnapshot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response RecoverSiteConfigurationSnapshot(CancellationToken cancellationToken = default)
        {
            using var scope = _siteConfigSnapshotWebAppsClientDiagnostics.CreateScope("SiteConfigSnapshotResource.RecoverSiteConfigurationSnapshot");
            scope.Start();
            try
            {
                var response = _siteConfigSnapshotWebAppsRestClient.RecoverSiteConfigurationSnapshot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, cancellationToken);
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
