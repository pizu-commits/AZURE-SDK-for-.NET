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
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of StaticSiteBuildARMResource and their operations over its parent. </summary>
    public partial class StaticSiteBuildARMResourceCollection : ArmCollection, IEnumerable<StaticSiteBuildARMResource>, IAsyncEnumerable<StaticSiteBuildARMResource>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly StaticSitesRestOperations _staticSitesRestClient;

        /// <summary> Initializes a new instance of the <see cref="StaticSiteBuildARMResourceCollection"/> class for mocking. </summary>
        protected StaticSiteBuildARMResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StaticSiteBuildARMResourceCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal StaticSiteBuildARMResourceCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _staticSitesRestClient = new StaticSitesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != StaticSiteARMResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, StaticSiteARMResource.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}
        /// OperationId: StaticSites_GetStaticSiteBuild
        /// <summary> Description for Gets the details of a static site build. </summary>
        /// <param name="environmentName"> The stage site identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="environmentName"/> is null. </exception>
        public virtual Response<StaticSiteBuildARMResource> Get(string environmentName, CancellationToken cancellationToken = default)
        {
            if (environmentName == null)
            {
                throw new ArgumentNullException(nameof(environmentName));
            }

            using var scope = _clientDiagnostics.CreateScope("StaticSiteBuildARMResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _staticSitesRestClient.GetStaticSiteBuild(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, environmentName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StaticSiteBuildARMResource(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}
        /// OperationId: StaticSites_GetStaticSiteBuild
        /// <summary> Description for Gets the details of a static site build. </summary>
        /// <param name="environmentName"> The stage site identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="environmentName"/> is null. </exception>
        public async virtual Task<Response<StaticSiteBuildARMResource>> GetAsync(string environmentName, CancellationToken cancellationToken = default)
        {
            if (environmentName == null)
            {
                throw new ArgumentNullException(nameof(environmentName));
            }

            using var scope = _clientDiagnostics.CreateScope("StaticSiteBuildARMResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _staticSitesRestClient.GetStaticSiteBuildAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, environmentName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new StaticSiteBuildARMResource(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="environmentName"> The stage site identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="environmentName"/> is null. </exception>
        public virtual Response<StaticSiteBuildARMResource> GetIfExists(string environmentName, CancellationToken cancellationToken = default)
        {
            if (environmentName == null)
            {
                throw new ArgumentNullException(nameof(environmentName));
            }

            using var scope = _clientDiagnostics.CreateScope("StaticSiteBuildARMResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _staticSitesRestClient.GetStaticSiteBuild(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, environmentName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<StaticSiteBuildARMResource>(null, response.GetRawResponse());
                return Response.FromValue(new StaticSiteBuildARMResource(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="environmentName"> The stage site identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="environmentName"/> is null. </exception>
        public async virtual Task<Response<StaticSiteBuildARMResource>> GetIfExistsAsync(string environmentName, CancellationToken cancellationToken = default)
        {
            if (environmentName == null)
            {
                throw new ArgumentNullException(nameof(environmentName));
            }

            using var scope = _clientDiagnostics.CreateScope("StaticSiteBuildARMResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _staticSitesRestClient.GetStaticSiteBuildAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, environmentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<StaticSiteBuildARMResource>(null, response.GetRawResponse());
                return Response.FromValue(new StaticSiteBuildARMResource(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="environmentName"> The stage site identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="environmentName"/> is null. </exception>
        public virtual Response<bool> Exists(string environmentName, CancellationToken cancellationToken = default)
        {
            if (environmentName == null)
            {
                throw new ArgumentNullException(nameof(environmentName));
            }

            using var scope = _clientDiagnostics.CreateScope("StaticSiteBuildARMResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(environmentName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="environmentName"> The stage site identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="environmentName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string environmentName, CancellationToken cancellationToken = default)
        {
            if (environmentName == null)
            {
                throw new ArgumentNullException(nameof(environmentName));
            }

            using var scope = _clientDiagnostics.CreateScope("StaticSiteBuildARMResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(environmentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}
        /// OperationId: StaticSites_GetStaticSiteBuilds
        /// <summary> Description for Gets all static site builds for a particular static site. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StaticSiteBuildARMResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StaticSiteBuildARMResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<StaticSiteBuildARMResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("StaticSiteBuildARMResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _staticSitesRestClient.GetStaticSiteBuilds(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new StaticSiteBuildARMResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<StaticSiteBuildARMResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("StaticSiteBuildARMResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _staticSitesRestClient.GetStaticSiteBuildsNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new StaticSiteBuildARMResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}
        /// OperationId: StaticSites_GetStaticSiteBuilds
        /// <summary> Description for Gets all static site builds for a particular static site. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StaticSiteBuildARMResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StaticSiteBuildARMResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<StaticSiteBuildARMResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("StaticSiteBuildARMResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _staticSitesRestClient.GetStaticSiteBuildsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new StaticSiteBuildARMResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<StaticSiteBuildARMResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("StaticSiteBuildARMResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _staticSitesRestClient.GetStaticSiteBuildsNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new StaticSiteBuildARMResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<StaticSiteBuildARMResource> IEnumerable<StaticSiteBuildARMResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<StaticSiteBuildARMResource> IAsyncEnumerable<StaticSiteBuildARMResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, StaticSiteBuildARMResource, StaticSiteBuildARMResourceData> Construct() { }
    }
}
