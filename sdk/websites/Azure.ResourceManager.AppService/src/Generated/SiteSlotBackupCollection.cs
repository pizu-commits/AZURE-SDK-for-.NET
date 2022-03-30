// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="SiteSlotBackupResource" /> and their operations.
    /// Each <see cref="SiteSlotBackupResource" /> in the collection will belong to the same instance of <see cref="SiteSlotResource" />.
    /// To get a <see cref="SiteSlotBackupCollection" /> instance call the GetSiteSlotBackups method from an instance of <see cref="SiteSlotResource" />.
    /// </summary>
    public partial class SiteSlotBackupCollection : ArmCollection, IEnumerable<SiteSlotBackupResource>, IAsyncEnumerable<SiteSlotBackupResource>
    {
        private readonly ClientDiagnostics _siteSlotBackupWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteSlotBackupWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotBackupCollection"/> class for mocking. </summary>
        protected SiteSlotBackupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotBackupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteSlotBackupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSlotBackupWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteSlotBackupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteSlotBackupResource.ResourceType, out string siteSlotBackupWebAppsApiVersion);
            _siteSlotBackupWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteSlotBackupWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SiteSlotResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SiteSlotResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Gets a backup of an app by its ID.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/backups/{backupId}
        /// Operation Id: WebApps_GetBackupStatusSlot
        /// </summary>
        /// <param name="backupId"> ID of the backup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupId"/> is null. </exception>
        public virtual async Task<Response<SiteSlotBackupResource>> GetAsync(string backupId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupId, nameof(backupId));

            using var scope = _siteSlotBackupWebAppsClientDiagnostics.CreateScope("SiteSlotBackupCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteSlotBackupWebAppsRestClient.GetBackupStatusSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, backupId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotBackupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets a backup of an app by its ID.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/backups/{backupId}
        /// Operation Id: WebApps_GetBackupStatusSlot
        /// </summary>
        /// <param name="backupId"> ID of the backup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupId"/> is null. </exception>
        public virtual Response<SiteSlotBackupResource> Get(string backupId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupId, nameof(backupId));

            using var scope = _siteSlotBackupWebAppsClientDiagnostics.CreateScope("SiteSlotBackupCollection.Get");
            scope.Start();
            try
            {
                var response = _siteSlotBackupWebAppsRestClient.GetBackupStatusSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, backupId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotBackupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets existing backups of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/backups
        /// Operation Id: WebApps_ListBackupsSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteSlotBackupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteSlotBackupResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteSlotBackupResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteSlotBackupWebAppsClientDiagnostics.CreateScope("SiteSlotBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteSlotBackupWebAppsRestClient.ListBackupsSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotBackupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteSlotBackupResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteSlotBackupWebAppsClientDiagnostics.CreateScope("SiteSlotBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteSlotBackupWebAppsRestClient.ListBackupsSlotNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotBackupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Description for Gets existing backups of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/backups
        /// Operation Id: WebApps_ListBackupsSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteSlotBackupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteSlotBackupResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteSlotBackupResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteSlotBackupWebAppsClientDiagnostics.CreateScope("SiteSlotBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteSlotBackupWebAppsRestClient.ListBackupsSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotBackupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteSlotBackupResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteSlotBackupWebAppsClientDiagnostics.CreateScope("SiteSlotBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteSlotBackupWebAppsRestClient.ListBackupsSlotNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotBackupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/backups/{backupId}
        /// Operation Id: WebApps_GetBackupStatusSlot
        /// </summary>
        /// <param name="backupId"> ID of the backup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string backupId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupId, nameof(backupId));

            using var scope = _siteSlotBackupWebAppsClientDiagnostics.CreateScope("SiteSlotBackupCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(backupId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/backups/{backupId}
        /// Operation Id: WebApps_GetBackupStatusSlot
        /// </summary>
        /// <param name="backupId"> ID of the backup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupId"/> is null. </exception>
        public virtual Response<bool> Exists(string backupId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupId, nameof(backupId));

            using var scope = _siteSlotBackupWebAppsClientDiagnostics.CreateScope("SiteSlotBackupCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(backupId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/backups/{backupId}
        /// Operation Id: WebApps_GetBackupStatusSlot
        /// </summary>
        /// <param name="backupId"> ID of the backup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupId"/> is null. </exception>
        public virtual async Task<Response<SiteSlotBackupResource>> GetIfExistsAsync(string backupId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupId, nameof(backupId));

            using var scope = _siteSlotBackupWebAppsClientDiagnostics.CreateScope("SiteSlotBackupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _siteSlotBackupWebAppsRestClient.GetBackupStatusSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, backupId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SiteSlotBackupResource>(null, response.GetRawResponse());
                return Response.FromValue(new SiteSlotBackupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/backups/{backupId}
        /// Operation Id: WebApps_GetBackupStatusSlot
        /// </summary>
        /// <param name="backupId"> ID of the backup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupId"/> is null. </exception>
        public virtual Response<SiteSlotBackupResource> GetIfExists(string backupId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupId, nameof(backupId));

            using var scope = _siteSlotBackupWebAppsClientDiagnostics.CreateScope("SiteSlotBackupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _siteSlotBackupWebAppsRestClient.GetBackupStatusSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, backupId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SiteSlotBackupResource>(null, response.GetRawResponse());
                return Response.FromValue(new SiteSlotBackupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteSlotBackupResource> IEnumerable<SiteSlotBackupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteSlotBackupResource> IAsyncEnumerable<SiteSlotBackupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
