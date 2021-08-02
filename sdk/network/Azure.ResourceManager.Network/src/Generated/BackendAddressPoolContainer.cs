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
    /// <summary> A class representing collection of BackendAddressPool and their operations over a LoadBalancer. </summary>
    public partial class BackendAddressPoolContainer : ResourceContainer
    {
        /// <summary> Initializes a new instance of the <see cref="BackendAddressPoolContainer"/> class for mocking. </summary>
        protected BackendAddressPoolContainer()
        {
        }

        /// <summary> Initializes a new instance of BackendAddressPoolContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal BackendAddressPoolContainer(ResourceOperations parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private LoadBalancerBackendAddressPoolsRestOperations _restClient => new LoadBalancerBackendAddressPoolsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => LoadBalancerOperations.ResourceType;

        // Container level operations.

        /// <summary> Creates or updates a load balancer backend address pool. </summary>
        /// <param name="backendAddressPoolName"> The name of the backend address pool. </param>
        /// <param name="parameters"> Parameters supplied to the create or update load balancer backend address pool operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="backendAddressPoolName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual Response<BackendAddressPool> CreateOrUpdate(string backendAddressPoolName, BackendAddressPoolData parameters, CancellationToken cancellationToken = default)
        {
            if (backendAddressPoolName == null)
            {
                throw new ArgumentNullException(nameof(backendAddressPoolName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("BackendAddressPoolContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(backendAddressPoolName, parameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a load balancer backend address pool. </summary>
        /// <param name="backendAddressPoolName"> The name of the backend address pool. </param>
        /// <param name="parameters"> Parameters supplied to the create or update load balancer backend address pool operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="backendAddressPoolName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<BackendAddressPool>> CreateOrUpdateAsync(string backendAddressPoolName, BackendAddressPoolData parameters, CancellationToken cancellationToken = default)
        {
            if (backendAddressPoolName == null)
            {
                throw new ArgumentNullException(nameof(backendAddressPoolName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("BackendAddressPoolContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(backendAddressPoolName, parameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a load balancer backend address pool. </summary>
        /// <param name="backendAddressPoolName"> The name of the backend address pool. </param>
        /// <param name="parameters"> Parameters supplied to the create or update load balancer backend address pool operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="backendAddressPoolName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual LoadBalancerBackendAddressPoolsCreateOrUpdateOperation StartCreateOrUpdate(string backendAddressPoolName, BackendAddressPoolData parameters, CancellationToken cancellationToken = default)
        {
            if (backendAddressPoolName == null)
            {
                throw new ArgumentNullException(nameof(backendAddressPoolName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("BackendAddressPoolContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, Id.Name, backendAddressPoolName, parameters, cancellationToken);
                return new LoadBalancerBackendAddressPoolsCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, backendAddressPoolName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a load balancer backend address pool. </summary>
        /// <param name="backendAddressPoolName"> The name of the backend address pool. </param>
        /// <param name="parameters"> Parameters supplied to the create or update load balancer backend address pool operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="backendAddressPoolName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<LoadBalancerBackendAddressPoolsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string backendAddressPoolName, BackendAddressPoolData parameters, CancellationToken cancellationToken = default)
        {
            if (backendAddressPoolName == null)
            {
                throw new ArgumentNullException(nameof(backendAddressPoolName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("BackendAddressPoolContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Name, backendAddressPoolName, parameters, cancellationToken).ConfigureAwait(false);
                return new LoadBalancerBackendAddressPoolsCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, backendAddressPoolName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="backendAddressPoolName"> The name of the backend address pool. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<BackendAddressPool> Get(string backendAddressPoolName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BackendAddressPoolContainer.Get");
            scope.Start();
            try
            {
                if (backendAddressPoolName == null)
                {
                    throw new ArgumentNullException(nameof(backendAddressPoolName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, backendAddressPoolName, cancellationToken: cancellationToken);
                return Response.FromValue(new BackendAddressPool(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="backendAddressPoolName"> The name of the backend address pool. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<BackendAddressPool>> GetAsync(string backendAddressPoolName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BackendAddressPoolContainer.Get");
            scope.Start();
            try
            {
                if (backendAddressPoolName == null)
                {
                    throw new ArgumentNullException(nameof(backendAddressPoolName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, backendAddressPoolName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new BackendAddressPool(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="backendAddressPoolName"> The name of the backend address pool. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual BackendAddressPool TryGet(string backendAddressPoolName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BackendAddressPoolContainer.TryGet");
            scope.Start();
            try
            {
                if (backendAddressPoolName == null)
                {
                    throw new ArgumentNullException(nameof(backendAddressPoolName));
                }

                return Get(backendAddressPoolName, cancellationToken: cancellationToken).Value;
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
        /// <param name="backendAddressPoolName"> The name of the backend address pool. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<BackendAddressPool> TryGetAsync(string backendAddressPoolName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BackendAddressPoolContainer.TryGet");
            scope.Start();
            try
            {
                if (backendAddressPoolName == null)
                {
                    throw new ArgumentNullException(nameof(backendAddressPoolName));
                }

                return await GetAsync(backendAddressPoolName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <param name="backendAddressPoolName"> The name of the backend address pool. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual bool CheckIfExists(string backendAddressPoolName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BackendAddressPoolContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (backendAddressPoolName == null)
                {
                    throw new ArgumentNullException(nameof(backendAddressPoolName));
                }

                return TryGet(backendAddressPoolName, cancellationToken: cancellationToken) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="backendAddressPoolName"> The name of the backend address pool. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<bool> CheckIfExistsAsync(string backendAddressPoolName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BackendAddressPoolContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (backendAddressPoolName == null)
                {
                    throw new ArgumentNullException(nameof(backendAddressPoolName));
                }

                return await TryGetAsync(backendAddressPoolName, cancellationToken: cancellationToken).ConfigureAwait(false) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all the load balancer backed address pools. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BackendAddressPool" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<BackendAddressPool> GetAll(CancellationToken cancellationToken = default)
        {
            Page<BackendAddressPool> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BackendAddressPoolContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAll(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new BackendAddressPool(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<BackendAddressPool> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BackendAddressPoolContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllNextPage(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new BackendAddressPool(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all the load balancer backed address pools. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BackendAddressPool" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<BackendAddressPool> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<BackendAddressPool>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BackendAddressPoolContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllAsync(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new BackendAddressPool(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<BackendAddressPool>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BackendAddressPoolContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllNextPageAsync(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new BackendAddressPool(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="BackendAddressPool" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> GetAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BackendAddressPoolContainer.GetAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(BackendAddressPoolOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="BackendAddressPool" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> GetAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BackendAddressPoolContainer.GetAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(BackendAddressPoolOperations.ResourceType);
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
        // public ArmBuilder<ResourceIdentifier, BackendAddressPool, BackendAddressPoolData> Construct() { }
    }
}
