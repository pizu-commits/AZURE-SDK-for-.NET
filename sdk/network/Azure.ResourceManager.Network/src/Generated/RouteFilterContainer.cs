// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of RouteFilter and their operations over a ResourceGroup. </summary>
    public partial class RouteFilterContainer : ResourceContainer
    {
        /// <summary> Initializes a new instance of the <see cref="RouteFilterContainer"/> class for mocking. </summary>
        protected RouteFilterContainer()
        {
        }

        /// <summary> Initializes a new instance of RouteFilterContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal RouteFilterContainer(ResourceOperations parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private RouteFiltersRestOperations _restClient => new RouteFiltersRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroupOperations.ResourceType;

        // Container level operations.

        /// <summary> Creates or updates a route filter in a specified resource group. </summary>
        /// <param name="routeFilterName"> The name of the route filter. </param>
        /// <param name="routeFilterParameters"> Parameters supplied to the create or update route filter operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeFilterName"/> or <paramref name="routeFilterParameters"/> is null. </exception>
        public virtual Response<RouteFilter> CreateOrUpdate(string routeFilterName, RouteFilterData routeFilterParameters, CancellationToken cancellationToken = default)
        {
            if (routeFilterName == null)
            {
                throw new ArgumentNullException(nameof(routeFilterName));
            }
            if (routeFilterParameters == null)
            {
                throw new ArgumentNullException(nameof(routeFilterParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("RouteFilterContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(routeFilterName, routeFilterParameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a route filter in a specified resource group. </summary>
        /// <param name="routeFilterName"> The name of the route filter. </param>
        /// <param name="routeFilterParameters"> Parameters supplied to the create or update route filter operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeFilterName"/> or <paramref name="routeFilterParameters"/> is null. </exception>
        public async virtual Task<Response<RouteFilter>> CreateOrUpdateAsync(string routeFilterName, RouteFilterData routeFilterParameters, CancellationToken cancellationToken = default)
        {
            if (routeFilterName == null)
            {
                throw new ArgumentNullException(nameof(routeFilterName));
            }
            if (routeFilterParameters == null)
            {
                throw new ArgumentNullException(nameof(routeFilterParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("RouteFilterContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(routeFilterName, routeFilterParameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a route filter in a specified resource group. </summary>
        /// <param name="routeFilterName"> The name of the route filter. </param>
        /// <param name="routeFilterParameters"> Parameters supplied to the create or update route filter operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeFilterName"/> or <paramref name="routeFilterParameters"/> is null. </exception>
        public virtual RouteFiltersCreateOrUpdateOperation StartCreateOrUpdate(string routeFilterName, RouteFilterData routeFilterParameters, CancellationToken cancellationToken = default)
        {
            if (routeFilterName == null)
            {
                throw new ArgumentNullException(nameof(routeFilterName));
            }
            if (routeFilterParameters == null)
            {
                throw new ArgumentNullException(nameof(routeFilterParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("RouteFilterContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, routeFilterName, routeFilterParameters, cancellationToken);
                return new RouteFiltersCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, routeFilterName, routeFilterParameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a route filter in a specified resource group. </summary>
        /// <param name="routeFilterName"> The name of the route filter. </param>
        /// <param name="routeFilterParameters"> Parameters supplied to the create or update route filter operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeFilterName"/> or <paramref name="routeFilterParameters"/> is null. </exception>
        public async virtual Task<RouteFiltersCreateOrUpdateOperation> StartCreateOrUpdateAsync(string routeFilterName, RouteFilterData routeFilterParameters, CancellationToken cancellationToken = default)
        {
            if (routeFilterName == null)
            {
                throw new ArgumentNullException(nameof(routeFilterName));
            }
            if (routeFilterParameters == null)
            {
                throw new ArgumentNullException(nameof(routeFilterParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("RouteFilterContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, routeFilterName, routeFilterParameters, cancellationToken).ConfigureAwait(false);
                return new RouteFiltersCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, routeFilterName, routeFilterParameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="routeFilterName"> The name of the route filter. </param>
        /// <param name="expand"> Expands referenced express route bgp peering resources. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<RouteFilter> Get(string routeFilterName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RouteFilterContainer.Get");
            scope.Start();
            try
            {
                if (routeFilterName == null)
                {
                    throw new ArgumentNullException(nameof(routeFilterName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, routeFilterName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(new RouteFilter(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="routeFilterName"> The name of the route filter. </param>
        /// <param name="expand"> Expands referenced express route bgp peering resources. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<RouteFilter>> GetAsync(string routeFilterName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RouteFilterContainer.Get");
            scope.Start();
            try
            {
                if (routeFilterName == null)
                {
                    throw new ArgumentNullException(nameof(routeFilterName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, routeFilterName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new RouteFilter(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="routeFilterName"> The name of the route filter. </param>
        /// <param name="expand"> Expands referenced express route bgp peering resources. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual RouteFilter TryGet(string routeFilterName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RouteFilterContainer.TryGet");
            scope.Start();
            try
            {
                if (routeFilterName == null)
                {
                    throw new ArgumentNullException(nameof(routeFilterName));
                }

                return Get(routeFilterName, expand, cancellationToken: cancellationToken).Value;
            }
            catch (RequestFailedException e) when (e.Status == 404)
            {
                return null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="routeFilterName"> The name of the route filter. </param>
        /// <param name="expand"> Expands referenced express route bgp peering resources. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<RouteFilter> TryGetAsync(string routeFilterName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RouteFilterContainer.TryGet");
            scope.Start();
            try
            {
                if (routeFilterName == null)
                {
                    throw new ArgumentNullException(nameof(routeFilterName));
                }

                return await GetAsync(routeFilterName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            catch (RequestFailedException e) when (e.Status == 404)
            {
                return null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="routeFilterName"> The name of the route filter. </param>
        /// <param name="expand"> Expands referenced express route bgp peering resources. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual bool CheckIfExists(string routeFilterName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RouteFilterContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (routeFilterName == null)
                {
                    throw new ArgumentNullException(nameof(routeFilterName));
                }

                return TryGet(routeFilterName, expand, cancellationToken: cancellationToken) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="routeFilterName"> The name of the route filter. </param>
        /// <param name="expand"> Expands referenced express route bgp peering resources. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<bool> CheckIfExistsAsync(string routeFilterName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RouteFilterContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (routeFilterName == null)
                {
                    throw new ArgumentNullException(nameof(routeFilterName));
                }

                return await TryGetAsync(routeFilterName, expand, cancellationToken: cancellationToken).ConfigureAwait(false) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all route filters in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RouteFilter" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<RouteFilter> GetAll(CancellationToken cancellationToken = default)
        {
            Page<RouteFilter> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RouteFilterContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetByResourceGroup(Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new RouteFilter(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<RouteFilter> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RouteFilterContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetByResourceGroupNextPage(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new RouteFilter(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all route filters in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RouteFilter" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<RouteFilter> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<RouteFilter>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RouteFilterContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetByResourceGroupAsync(Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new RouteFilter(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<RouteFilter>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RouteFilterContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetByResourceGroupNextPageAsync(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new RouteFilter(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="RouteFilter" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> GetAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RouteFilterContainer.GetAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(RouteFilterOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="RouteFilter" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> GetAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RouteFilterContainer.GetAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(RouteFilterOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, RouteFilter, RouteFilterData> Construct() { }
    }
}
