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
    /// A class representing a collection of <see cref="SiteInstanceResource" /> and their operations.
    /// Each <see cref="SiteInstanceResource" /> in the collection will belong to the same instance of <see cref="WebSiteResource" />.
    /// To get a <see cref="SiteInstanceCollection" /> instance call the GetSiteInstances method from an instance of <see cref="WebSiteResource" />.
    /// </summary>
    public partial class SiteInstanceCollection : ArmCollection, IEnumerable<SiteInstanceResource>, IAsyncEnumerable<SiteInstanceResource>
    {
        private readonly ClientDiagnostics _siteInstanceWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteInstanceWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteInstanceCollection"/> class for mocking. </summary>
        protected SiteInstanceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteInstanceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteInstanceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteInstanceWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteInstanceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteInstanceResource.ResourceType, out string siteInstanceWebAppsApiVersion);
            _siteInstanceWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteInstanceWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WebSiteResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WebSiteResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets all scale-out instances of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}
        /// Operation Id: WebApps_GetInstanceInfo
        /// </summary>
        /// <param name="instanceId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        public virtual async Task<Response<SiteInstanceResource>> GetAsync(string instanceId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceId, nameof(instanceId));

            using var scope = _siteInstanceWebAppsClientDiagnostics.CreateScope("SiteInstanceCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteInstanceWebAppsRestClient.GetInstanceInfoAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, instanceId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteInstanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all scale-out instances of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}
        /// Operation Id: WebApps_GetInstanceInfo
        /// </summary>
        /// <param name="instanceId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        public virtual Response<SiteInstanceResource> Get(string instanceId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceId, nameof(instanceId));

            using var scope = _siteInstanceWebAppsClientDiagnostics.CreateScope("SiteInstanceCollection.Get");
            scope.Start();
            try
            {
                var response = _siteInstanceWebAppsRestClient.GetInstanceInfo(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, instanceId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteInstanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all scale-out instances of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances
        /// Operation Id: WebApps_ListInstanceIdentifiers
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteInstanceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteInstanceResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteInstanceResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteInstanceWebAppsClientDiagnostics.CreateScope("SiteInstanceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteInstanceWebAppsRestClient.ListInstanceIdentifiersAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteInstanceResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteInstanceResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteInstanceWebAppsClientDiagnostics.CreateScope("SiteInstanceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteInstanceWebAppsRestClient.ListInstanceIdentifiersNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteInstanceResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets all scale-out instances of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances
        /// Operation Id: WebApps_ListInstanceIdentifiers
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteInstanceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteInstanceResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteInstanceResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteInstanceWebAppsClientDiagnostics.CreateScope("SiteInstanceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteInstanceWebAppsRestClient.ListInstanceIdentifiers(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteInstanceResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteInstanceResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteInstanceWebAppsClientDiagnostics.CreateScope("SiteInstanceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteInstanceWebAppsRestClient.ListInstanceIdentifiersNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteInstanceResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}
        /// Operation Id: WebApps_GetInstanceInfo
        /// </summary>
        /// <param name="instanceId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string instanceId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceId, nameof(instanceId));

            using var scope = _siteInstanceWebAppsClientDiagnostics.CreateScope("SiteInstanceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _siteInstanceWebAppsRestClient.GetInstanceInfoAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, instanceId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}
        /// Operation Id: WebApps_GetInstanceInfo
        /// </summary>
        /// <param name="instanceId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        public virtual Response<bool> Exists(string instanceId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceId, nameof(instanceId));

            using var scope = _siteInstanceWebAppsClientDiagnostics.CreateScope("SiteInstanceCollection.Exists");
            scope.Start();
            try
            {
                var response = _siteInstanceWebAppsRestClient.GetInstanceInfo(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, instanceId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteInstanceResource> IEnumerable<SiteInstanceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteInstanceResource> IAsyncEnumerable<SiteInstanceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
