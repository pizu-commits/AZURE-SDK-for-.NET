// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
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
    public partial class DscpConfigurationCollection : ArmCollection, IEnumerable<DscpConfiguration>, IAsyncEnumerable<DscpConfiguration>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly DscpConfigurationRestOperations _restClient;

        /// <summary> Initializes a new instance of the <see cref="DscpConfigurationCollection"/> class for mocking. </summary>
        protected DscpConfigurationCollection()
        {
        }

        /// <summary> Initializes a new instance of DscpConfigurationCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal DscpConfigurationCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new DscpConfigurationRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        IEnumerator<DscpConfiguration> IEnumerable<DscpConfiguration>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DscpConfiguration> IAsyncEnumerable<DscpConfiguration>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroup.ResourceType;

        // Collection level operations.

        /// <summary> Creates or updates a DSCP Configuration. </summary>
        /// <param name="dscpConfigurationName"> The name of the resource. </param>
        /// <param name="parameters"> Parameters supplied to the create or update dscp configuration operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dscpConfigurationName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual DscpConfigurationCreateOrUpdateOperation CreateOrUpdate(string dscpConfigurationName, DscpConfigurationData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (dscpConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(dscpConfigurationName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("DscpConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, dscpConfigurationName, parameters, cancellationToken);
                var operation = new DscpConfigurationCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, dscpConfigurationName, parameters).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
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
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dscpConfigurationName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<DscpConfigurationCreateOrUpdateOperation> CreateOrUpdateAsync(string dscpConfigurationName, DscpConfigurationData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (dscpConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(dscpConfigurationName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("DscpConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, dscpConfigurationName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new DscpConfigurationCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, dscpConfigurationName, parameters).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
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
            using var scope = _clientDiagnostics.CreateScope("DscpConfigurationCollection.Get");
            scope.Start();
            try
            {
                if (dscpConfigurationName == null)
                {
                    throw new ArgumentNullException(nameof(dscpConfigurationName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, dscpConfigurationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
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
            using var scope = _clientDiagnostics.CreateScope("DscpConfigurationCollection.Get");
            scope.Start();
            try
            {
                if (dscpConfigurationName == null)
                {
                    throw new ArgumentNullException(nameof(dscpConfigurationName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, dscpConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
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
        public virtual Response<DscpConfiguration> GetIfExists(string dscpConfigurationName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DscpConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                if (dscpConfigurationName == null)
                {
                    throw new ArgumentNullException(nameof(dscpConfigurationName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, dscpConfigurationName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<DscpConfiguration>(null, response.GetRawResponse())
                    : Response.FromValue(new DscpConfiguration(this, response.Value), response.GetRawResponse());
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
        public async virtual Task<Response<DscpConfiguration>> GetIfExistsAsync(string dscpConfigurationName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DscpConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                if (dscpConfigurationName == null)
                {
                    throw new ArgumentNullException(nameof(dscpConfigurationName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, dscpConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<DscpConfiguration>(null, response.GetRawResponse())
                    : Response.FromValue(new DscpConfiguration(this, response.Value), response.GetRawResponse());
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
        public virtual Response<bool> CheckIfExists(string dscpConfigurationName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DscpConfigurationCollection.CheckIfExists");
            scope.Start();
            try
            {
                if (dscpConfigurationName == null)
                {
                    throw new ArgumentNullException(nameof(dscpConfigurationName));
                }

                var response = GetIfExists(dscpConfigurationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
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
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string dscpConfigurationName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DscpConfigurationCollection.CheckIfExists");
            scope.Start();
            try
            {
                if (dscpConfigurationName == null)
                {
                    throw new ArgumentNullException(nameof(dscpConfigurationName));
                }

                var response = await GetIfExistsAsync(dscpConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
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
        public virtual Pageable<DscpConfiguration> GetAll(CancellationToken cancellationToken = default)
        {
            Page<DscpConfiguration> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DscpConfigurationCollection.GetAll");
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
                using var scope = _clientDiagnostics.CreateScope("DscpConfigurationCollection.GetAll");
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
        public virtual AsyncPageable<DscpConfiguration> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DscpConfiguration>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DscpConfigurationCollection.GetAll");
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
                using var scope = _clientDiagnostics.CreateScope("DscpConfigurationCollection.GetAll");
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
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DscpConfigurationCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(DscpConfiguration.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
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
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DscpConfigurationCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(DscpConfiguration.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
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
