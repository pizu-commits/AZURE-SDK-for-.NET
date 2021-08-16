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
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Storage.Models;

namespace Azure.ResourceManager.Storage
{
    /// <summary> A class representing collection of BlobInventoryPolicy and their operations over a StorageAccount. </summary>
    public partial class BlobInventoryPolicyContainer : ArmContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly BlobInventoryPoliciesRestOperations _restClient;

        /// <summary> Initializes a new instance of the <see cref="BlobInventoryPolicyContainer"/> class for mocking. </summary>
        protected BlobInventoryPolicyContainer()
        {
        }

        /// <summary> Initializes a new instance of BlobInventoryPolicyContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal BlobInventoryPolicyContainer(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new BlobInventoryPoliciesRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => StorageAccount.ResourceType;

        // Container level operations.

        /// <summary> Sets the blob inventory policy to the specified storage account. </summary>
        /// <param name="blobInventoryPolicyName"> The name of the storage account blob inventory policy. It should always be &apos;default&apos;. </param>
        /// <param name="properties"> The blob inventory policy set to a storage account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public virtual Response<BlobInventoryPolicy> CreateOrUpdate(BlobInventoryPolicyName blobInventoryPolicyName, BlobInventoryPolicyData properties, CancellationToken cancellationToken = default)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            using var scope = _clientDiagnostics.CreateScope("BlobInventoryPolicyContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(blobInventoryPolicyName, properties, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Sets the blob inventory policy to the specified storage account. </summary>
        /// <param name="blobInventoryPolicyName"> The name of the storage account blob inventory policy. It should always be &apos;default&apos;. </param>
        /// <param name="properties"> The blob inventory policy set to a storage account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public async virtual Task<Response<BlobInventoryPolicy>> CreateOrUpdateAsync(BlobInventoryPolicyName blobInventoryPolicyName, BlobInventoryPolicyData properties, CancellationToken cancellationToken = default)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            using var scope = _clientDiagnostics.CreateScope("BlobInventoryPolicyContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(blobInventoryPolicyName, properties, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Sets the blob inventory policy to the specified storage account. </summary>
        /// <param name="blobInventoryPolicyName"> The name of the storage account blob inventory policy. It should always be &apos;default&apos;. </param>
        /// <param name="properties"> The blob inventory policy set to a storage account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public virtual BlobInventoryPolicyCreateOrUpdateOperation StartCreateOrUpdate(BlobInventoryPolicyName blobInventoryPolicyName, BlobInventoryPolicyData properties, CancellationToken cancellationToken = default)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            using var scope = _clientDiagnostics.CreateScope("BlobInventoryPolicyContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, Id.Name, blobInventoryPolicyName, properties, cancellationToken);
                return new BlobInventoryPolicyCreateOrUpdateOperation(Parent, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Sets the blob inventory policy to the specified storage account. </summary>
        /// <param name="blobInventoryPolicyName"> The name of the storage account blob inventory policy. It should always be &apos;default&apos;. </param>
        /// <param name="properties"> The blob inventory policy set to a storage account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public async virtual Task<BlobInventoryPolicyCreateOrUpdateOperation> StartCreateOrUpdateAsync(BlobInventoryPolicyName blobInventoryPolicyName, BlobInventoryPolicyData properties, CancellationToken cancellationToken = default)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            using var scope = _clientDiagnostics.CreateScope("BlobInventoryPolicyContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Name, blobInventoryPolicyName, properties, cancellationToken).ConfigureAwait(false);
                return new BlobInventoryPolicyCreateOrUpdateOperation(Parent, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="blobInventoryPolicyName"> The name of the storage account blob inventory policy. It should always be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<BlobInventoryPolicy> Get(BlobInventoryPolicyName blobInventoryPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobInventoryPolicyContainer.Get");
            scope.Start();
            try
            {
                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, blobInventoryPolicyName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BlobInventoryPolicy(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="blobInventoryPolicyName"> The name of the storage account blob inventory policy. It should always be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<BlobInventoryPolicy>> GetAsync(BlobInventoryPolicyName blobInventoryPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobInventoryPolicyContainer.Get");
            scope.Start();
            try
            {
                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, blobInventoryPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new BlobInventoryPolicy(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="blobInventoryPolicyName"> The name of the storage account blob inventory policy. It should always be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<BlobInventoryPolicy> GetIfExists(BlobInventoryPolicyName blobInventoryPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobInventoryPolicyContainer.GetIfExists");
            scope.Start();
            try
            {
                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, blobInventoryPolicyName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<BlobInventoryPolicy>(null, response.GetRawResponse())
                    : Response.FromValue(new BlobInventoryPolicy(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="blobInventoryPolicyName"> The name of the storage account blob inventory policy. It should always be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<BlobInventoryPolicy>> GetIfExistsAsync(BlobInventoryPolicyName blobInventoryPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobInventoryPolicyContainer.GetIfExists");
            scope.Start();
            try
            {
                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, blobInventoryPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<BlobInventoryPolicy>(null, response.GetRawResponse())
                    : Response.FromValue(new BlobInventoryPolicy(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="blobInventoryPolicyName"> The name of the storage account blob inventory policy. It should always be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(BlobInventoryPolicyName blobInventoryPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobInventoryPolicyContainer.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(blobInventoryPolicyName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="blobInventoryPolicyName"> The name of the storage account blob inventory policy. It should always be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(BlobInventoryPolicyName blobInventoryPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobInventoryPolicyContainer.CheckIfExists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(blobInventoryPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the blob inventory policy associated with the specified storage account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BlobInventoryPolicy" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<BlobInventoryPolicy> GetAll(CancellationToken cancellationToken = default)
        {
            Page<BlobInventoryPolicy> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BlobInventoryPolicyContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAll(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new BlobInventoryPolicy(Parent, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> Gets the blob inventory policy associated with the specified storage account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BlobInventoryPolicy" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<BlobInventoryPolicy> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<BlobInventoryPolicy>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BlobInventoryPolicyContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllAsync(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new BlobInventoryPolicy(Parent, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary> Filters the list of <see cref="BlobInventoryPolicy" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobInventoryPolicyContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(BlobInventoryPolicy.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="BlobInventoryPolicy" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobInventoryPolicyContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(BlobInventoryPolicy.ResourceType);
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
        // public ArmBuilder<ResourceIdentifier, BlobInventoryPolicy, BlobInventoryPolicyData> Construct() { }
    }
}
