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
    /// A class representing a collection of <see cref="SiteSlotTriggeredWebJobHistoryResource" /> and their operations.
    /// Each <see cref="SiteSlotTriggeredWebJobHistoryResource" /> in the collection will belong to the same instance of <see cref="SiteSlotTriggeredWebJobResource" />.
    /// To get a <see cref="SiteSlotTriggeredWebJobHistoryCollection" /> instance call the GetSiteSlotTriggeredWebJobHistories method from an instance of <see cref="SiteSlotTriggeredWebJobResource" />.
    /// </summary>
    public partial class SiteSlotTriggeredWebJobHistoryCollection : ArmCollection, IEnumerable<SiteSlotTriggeredWebJobHistoryResource>, IAsyncEnumerable<SiteSlotTriggeredWebJobHistoryResource>
    {
        private readonly ClientDiagnostics _siteSlotTriggeredWebJobHistoryWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteSlotTriggeredWebJobHistoryWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotTriggeredWebJobHistoryCollection"/> class for mocking. </summary>
        protected SiteSlotTriggeredWebJobHistoryCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotTriggeredWebJobHistoryCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteSlotTriggeredWebJobHistoryCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSlotTriggeredWebJobHistoryWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteSlotTriggeredWebJobHistoryResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteSlotTriggeredWebJobHistoryResource.ResourceType, out string siteSlotTriggeredWebJobHistoryWebAppsApiVersion);
            _siteSlotTriggeredWebJobHistoryWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteSlotTriggeredWebJobHistoryWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SiteSlotTriggeredWebJobResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SiteSlotTriggeredWebJobResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a triggered web job&apos;s history by its ID for an app, , or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs/{webJobName}/history/{id}
        /// Operation Id: WebApps_GetTriggeredWebJobHistory
        /// </summary>
        /// <param name="id"> History ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual async Task<Response<SiteSlotTriggeredWebJobHistoryResource>> GetAsync(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _siteSlotTriggeredWebJobHistoryWebAppsClientDiagnostics.CreateScope("SiteSlotTriggeredWebJobHistoryCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteSlotTriggeredWebJobHistoryWebAppsRestClient.GetTriggeredWebJobHistoryAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, id, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotTriggeredWebJobHistoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a triggered web job&apos;s history by its ID for an app, , or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs/{webJobName}/history/{id}
        /// Operation Id: WebApps_GetTriggeredWebJobHistory
        /// </summary>
        /// <param name="id"> History ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual Response<SiteSlotTriggeredWebJobHistoryResource> Get(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _siteSlotTriggeredWebJobHistoryWebAppsClientDiagnostics.CreateScope("SiteSlotTriggeredWebJobHistoryCollection.Get");
            scope.Start();
            try
            {
                var response = _siteSlotTriggeredWebJobHistoryWebAppsRestClient.GetTriggeredWebJobHistory(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, id, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotTriggeredWebJobHistoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List a triggered web job&apos;s history for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs/{webJobName}/history
        /// Operation Id: WebApps_ListTriggeredWebJobHistory
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteSlotTriggeredWebJobHistoryResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteSlotTriggeredWebJobHistoryResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteSlotTriggeredWebJobHistoryResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteSlotTriggeredWebJobHistoryWebAppsClientDiagnostics.CreateScope("SiteSlotTriggeredWebJobHistoryCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteSlotTriggeredWebJobHistoryWebAppsRestClient.ListTriggeredWebJobHistoryAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotTriggeredWebJobHistoryResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteSlotTriggeredWebJobHistoryResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteSlotTriggeredWebJobHistoryWebAppsClientDiagnostics.CreateScope("SiteSlotTriggeredWebJobHistoryCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteSlotTriggeredWebJobHistoryWebAppsRestClient.ListTriggeredWebJobHistoryNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotTriggeredWebJobHistoryResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List a triggered web job&apos;s history for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs/{webJobName}/history
        /// Operation Id: WebApps_ListTriggeredWebJobHistory
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteSlotTriggeredWebJobHistoryResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteSlotTriggeredWebJobHistoryResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteSlotTriggeredWebJobHistoryResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteSlotTriggeredWebJobHistoryWebAppsClientDiagnostics.CreateScope("SiteSlotTriggeredWebJobHistoryCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteSlotTriggeredWebJobHistoryWebAppsRestClient.ListTriggeredWebJobHistory(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotTriggeredWebJobHistoryResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteSlotTriggeredWebJobHistoryResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteSlotTriggeredWebJobHistoryWebAppsClientDiagnostics.CreateScope("SiteSlotTriggeredWebJobHistoryCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteSlotTriggeredWebJobHistoryWebAppsRestClient.ListTriggeredWebJobHistoryNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotTriggeredWebJobHistoryResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs/{webJobName}/history/{id}
        /// Operation Id: WebApps_GetTriggeredWebJobHistory
        /// </summary>
        /// <param name="id"> History ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _siteSlotTriggeredWebJobHistoryWebAppsClientDiagnostics.CreateScope("SiteSlotTriggeredWebJobHistoryCollection.Exists");
            scope.Start();
            try
            {
                var response = await _siteSlotTriggeredWebJobHistoryWebAppsRestClient.GetTriggeredWebJobHistoryAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, id, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs/{webJobName}/history/{id}
        /// Operation Id: WebApps_GetTriggeredWebJobHistory
        /// </summary>
        /// <param name="id"> History ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual Response<bool> Exists(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _siteSlotTriggeredWebJobHistoryWebAppsClientDiagnostics.CreateScope("SiteSlotTriggeredWebJobHistoryCollection.Exists");
            scope.Start();
            try
            {
                var response = _siteSlotTriggeredWebJobHistoryWebAppsRestClient.GetTriggeredWebJobHistory(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, id, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteSlotTriggeredWebJobHistoryResource> IEnumerable<SiteSlotTriggeredWebJobHistoryResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteSlotTriggeredWebJobHistoryResource> IAsyncEnumerable<SiteSlotTriggeredWebJobHistoryResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
