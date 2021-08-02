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
    /// <summary> A class representing collection of DscpConfiguration and their operations over a ResourceGroup. </summary>
    public partial class DscpConfigurationContainer : ResourceContainer
    {
        /// <summary> Initializes a new instance of the <see cref="DscpConfigurationContainer"/> class for mocking. </summary>
        protected DscpConfigurationContainer()
        {
        }

        /// <summary> Initializes a new instance of DscpConfigurationContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal DscpConfigurationContainer(ResourceOperations parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private DscpConfigurationRestOperations _restClient => new DscpConfigurationRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroupOperations.ResourceType;

        // Container level operations.

        /// <summary> Creates or updates a DSCP Configuration. </summary>
        /// <param name="dscpConfigurationName"> The name of the resource. </param>
        /// <param name="parameters"> Parameters supplied to the create or update dscp configuration operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dscpConfigurationName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual Response<DscpConfiguration> CreateOrUpdate(string dscpConfigurationName, DscpConfigurationData parameters, CancellationToken cancellationToken = default)
        {
            if (dscpConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(dscpConfigurationName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("DscpConfigurationContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(dscpConfigurationName, parameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a DSCP Configuration. </summary>
        /// <param name="dscpConfigurationName"> The name of the resource. </param>
        /// <param name="parameters"> Parameters supplied to the create or update dscp configuration operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dscpConfigurationName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<DscpConfiguration>> CreateOrUpdateAsync(string dscpConfigurationName, DscpConfigurationData parameters, CancellationToken cancellationToken = default)
        {
            if (dscpConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(dscpConfigurationName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("DscpConfigurationContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(dscpConfigurationName, parameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a DSCP Configuration. </summary>
        /// <param name="dscpConfigurationName"> The name of the resource. </param>
        /// <param name="parameters"> Parameters supplied to the create or update dscp configuration operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dscpConfigurationName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual DscpConfigurationCreateOrUpdateOperation StartCreateOrUpdate(string dscpConfigurationName, DscpConfigurationData parameters, CancellationToken cancellationToken = default)
        {
            if (dscpConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(dscpConfigurationName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("DscpConfigurationContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, dscpConfigurationName, parameters, cancellationToken);
                return new DscpConfigurationCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, dscpConfigurationName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a DSCP Configuration. </summary>
        /// <param name="dscpConfigurationName"> The name of the resource. </param>
        /// <param name="parameters"> Parameters supplied to the create or update dscp configuration operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dscpConfigurationName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<DscpConfigurationCreateOrUpdateOperation> StartCreateOrUpdateAsync(string dscpConfigurationName, DscpConfigurationData parameters, CancellationToken cancellationToken = default)
        {
            if (dscpConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(dscpConfigurationName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("DscpConfigurationContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, dscpConfigurationName, parameters, cancellationToken).ConfigureAwait(false);
                return new DscpConfigurationCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, dscpConfigurationName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="dscpConfigurationName"> The name of the resource. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<DscpConfiguration> Get(string dscpConfigurationName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DscpConfigurationContainer.Get");
            scope.Start();
            try
            {
                if (dscpConfigurationName == null)
                {
                    throw new ArgumentNullException(nameof(dscpConfigurationName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, dscpConfigurationName, cancellationToken: cancellationToken);
                return Response.FromValue(new DscpConfiguration(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="dscpConfigurationName"> The name of the resource. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<DscpConfiguration>> GetAsync(string dscpConfigurationName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DscpConfigurationContainer.Get");
            scope.Start();
            try
            {
                if (dscpConfigurationName == null)
                {
                    throw new ArgumentNullException(nameof(dscpConfigurationName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, dscpConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new DscpConfiguration(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="dscpConfigurationName"> The name of the resource. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual DscpConfiguration TryGet(string dscpConfigurationName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DscpConfigurationContainer.TryGet");
            scope.Start();
            try
            {
                if (dscpConfigurationName == null)
                {
                    throw new ArgumentNullException(nameof(dscpConfigurationName));
                }

                return Get(dscpConfigurationName, cancellationToken: cancellationToken).Value;
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
        /// <param name="dscpConfigurationName"> The name of the resource. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<DscpConfiguration> TryGetAsync(string dscpConfigurationName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DscpConfigurationContainer.TryGet");
            scope.Start();
            try
            {
                if (dscpConfigurationName == null)
                {
                    throw new ArgumentNullException(nameof(dscpConfigurationName));
                }

                return await GetAsync(dscpConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <param name="dscpConfigurationName"> The name of the resource. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual bool CheckIfExists(string dscpConfigurationName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DscpConfigurationContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (dscpConfigurationName == null)
                {
                    throw new ArgumentNullException(nameof(dscpConfigurationName));
                }

                return TryGet(dscpConfigurationName, cancellationToken: cancellationToken) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="dscpConfigurationName"> The name of the resource. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<bool> CheckIfExistsAsync(string dscpConfigurationName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DscpConfigurationContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (dscpConfigurationName == null)
                {
                    throw new ArgumentNullException(nameof(dscpConfigurationName));
                }

                return await TryGetAsync(dscpConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a DSCP Configuration. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DscpConfiguration" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<DscpConfiguration> GetAll(CancellationToken cancellationToken = default)
        {
            Page<DscpConfiguration> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DscpConfigurationContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAll(Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DscpConfiguration(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DscpConfiguration> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DscpConfigurationContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllNextPage(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DscpConfiguration(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets a DSCP Configuration. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DscpConfiguration" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<DscpConfiguration> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DscpConfiguration>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DscpConfigurationContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllAsync(Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DscpConfiguration(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DscpConfiguration>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DscpConfigurationContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllNextPageAsync(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DscpConfiguration(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="DscpConfiguration" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> GetAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DscpConfigurationContainer.GetAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(DscpConfigurationOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="DscpConfiguration" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> GetAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DscpConfigurationContainer.GetAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(DscpConfigurationOperations.ResourceType);
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
        // public ArmBuilder<ResourceIdentifier, DscpConfiguration, DscpConfigurationData> Construct() { }
    }
}
