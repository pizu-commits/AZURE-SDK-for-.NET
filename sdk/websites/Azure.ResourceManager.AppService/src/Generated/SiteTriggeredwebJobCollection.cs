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
    /// A class representing a collection of <see cref="SiteTriggeredwebJobResource" /> and their operations.
    /// Each <see cref="SiteTriggeredwebJobResource" /> in the collection will belong to the same instance of <see cref="SiteSlotResource" />.
    /// To get a <see cref="SiteTriggeredwebJobCollection" /> instance call the GetSiteTriggeredwebJobs method from an instance of <see cref="SiteSlotResource" />.
    /// </summary>
    public partial class SiteTriggeredwebJobCollection : ArmCollection, IEnumerable<SiteTriggeredwebJobResource>, IAsyncEnumerable<SiteTriggeredwebJobResource>
    {
        private readonly ClientDiagnostics _siteTriggeredwebJobWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteTriggeredwebJobWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteTriggeredwebJobCollection"/> class for mocking. </summary>
        protected SiteTriggeredwebJobCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteTriggeredwebJobCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteTriggeredwebJobCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteTriggeredwebJobWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteTriggeredwebJobResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteTriggeredwebJobResource.ResourceType, out string siteTriggeredwebJobWebAppsApiVersion);
            _siteTriggeredwebJobWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteTriggeredwebJobWebAppsApiVersion);
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
        /// Gets a triggered web job by its ID for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/triggeredwebjobs/{webJobName}
        /// Operation Id: WebApps_GetTriggeredWebJobSlot
        /// </summary>
        /// <param name="webJobName"> Name of Web Job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webJobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webJobName"/> is null. </exception>
        public virtual async Task<Response<SiteTriggeredwebJobResource>> GetAsync(string webJobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webJobName, nameof(webJobName));

            using var scope = _siteTriggeredwebJobWebAppsClientDiagnostics.CreateScope("SiteTriggeredwebJobCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteTriggeredwebJobWebAppsRestClient.GetTriggeredWebJobSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, webJobName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteTriggeredwebJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a triggered web job by its ID for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/triggeredwebjobs/{webJobName}
        /// Operation Id: WebApps_GetTriggeredWebJobSlot
        /// </summary>
        /// <param name="webJobName"> Name of Web Job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webJobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webJobName"/> is null. </exception>
        public virtual Response<SiteTriggeredwebJobResource> Get(string webJobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webJobName, nameof(webJobName));

            using var scope = _siteTriggeredwebJobWebAppsClientDiagnostics.CreateScope("SiteTriggeredwebJobCollection.Get");
            scope.Start();
            try
            {
                var response = _siteTriggeredwebJobWebAppsRestClient.GetTriggeredWebJobSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, webJobName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteTriggeredwebJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List triggered web jobs for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/triggeredwebjobs
        /// Operation Id: WebApps_ListTriggeredWebJobsSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteTriggeredwebJobResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteTriggeredwebJobResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteTriggeredwebJobResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteTriggeredwebJobWebAppsClientDiagnostics.CreateScope("SiteTriggeredwebJobCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteTriggeredwebJobWebAppsRestClient.ListTriggeredWebJobsSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteTriggeredwebJobResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteTriggeredwebJobResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteTriggeredwebJobWebAppsClientDiagnostics.CreateScope("SiteTriggeredwebJobCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteTriggeredwebJobWebAppsRestClient.ListTriggeredWebJobsSlotNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteTriggeredwebJobResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List triggered web jobs for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/triggeredwebjobs
        /// Operation Id: WebApps_ListTriggeredWebJobsSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteTriggeredwebJobResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteTriggeredwebJobResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteTriggeredwebJobResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteTriggeredwebJobWebAppsClientDiagnostics.CreateScope("SiteTriggeredwebJobCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteTriggeredwebJobWebAppsRestClient.ListTriggeredWebJobsSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteTriggeredwebJobResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteTriggeredwebJobResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteTriggeredwebJobWebAppsClientDiagnostics.CreateScope("SiteTriggeredwebJobCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteTriggeredwebJobWebAppsRestClient.ListTriggeredWebJobsSlotNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteTriggeredwebJobResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/triggeredwebjobs/{webJobName}
        /// Operation Id: WebApps_GetTriggeredWebJobSlot
        /// </summary>
        /// <param name="webJobName"> Name of Web Job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webJobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webJobName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string webJobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webJobName, nameof(webJobName));

            using var scope = _siteTriggeredwebJobWebAppsClientDiagnostics.CreateScope("SiteTriggeredwebJobCollection.Exists");
            scope.Start();
            try
            {
                var response = await _siteTriggeredwebJobWebAppsRestClient.GetTriggeredWebJobSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, webJobName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/triggeredwebjobs/{webJobName}
        /// Operation Id: WebApps_GetTriggeredWebJobSlot
        /// </summary>
        /// <param name="webJobName"> Name of Web Job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webJobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webJobName"/> is null. </exception>
        public virtual Response<bool> Exists(string webJobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webJobName, nameof(webJobName));

            using var scope = _siteTriggeredwebJobWebAppsClientDiagnostics.CreateScope("SiteTriggeredwebJobCollection.Exists");
            scope.Start();
            try
            {
                var response = _siteTriggeredwebJobWebAppsRestClient.GetTriggeredWebJobSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, webJobName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteTriggeredwebJobResource> IEnumerable<SiteTriggeredwebJobResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteTriggeredwebJobResource> IAsyncEnumerable<SiteTriggeredwebJobResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
