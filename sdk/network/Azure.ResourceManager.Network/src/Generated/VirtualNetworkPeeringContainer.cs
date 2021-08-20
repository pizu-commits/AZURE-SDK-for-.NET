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
    /// <summary> A class representing collection of VirtualNetworkPeering and their operations over a VirtualNetwork. </summary>
    public partial class VirtualNetworkPeeringContainer : ArmContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly VirtualNetworkPeeringsRestOperations _restClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualNetworkPeeringContainer"/> class for mocking. </summary>
        protected VirtualNetworkPeeringContainer()
        {
        }

        /// <summary> Initializes a new instance of VirtualNetworkPeeringContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal VirtualNetworkPeeringContainer(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new VirtualNetworkPeeringsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => VirtualNetwork.ResourceType;

        // Container level operations.

        /// <summary> Creates or updates a peering in the specified virtual network. </summary>
        /// <param name="virtualNetworkPeeringName"> The name of the peering. </param>
        /// <param name="virtualNetworkPeeringParameters"> Parameters supplied to the create or update virtual network peering operation. </param>
        /// <param name="syncRemoteAddressSpace"> Parameter indicates the intention to sync the peering with the current address space on the remote vNet after it&apos;s updated. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkPeeringName"/> or <paramref name="virtualNetworkPeeringParameters"/> is null. </exception>
        public virtual VirtualNetworkPeeringCreateOrUpdateOperation CreateOrUpdate(string virtualNetworkPeeringName, VirtualNetworkPeeringData virtualNetworkPeeringParameters, SyncRemoteAddressSpace? syncRemoteAddressSpace = null, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (virtualNetworkPeeringName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkPeeringName));
            }
            if (virtualNetworkPeeringParameters == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkPeeringParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkPeeringContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, Id.Name, virtualNetworkPeeringName, virtualNetworkPeeringParameters, syncRemoteAddressSpace, cancellationToken);
                var operation = new VirtualNetworkPeeringCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, virtualNetworkPeeringName, virtualNetworkPeeringParameters, syncRemoteAddressSpace).Request, response);
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

        /// <summary> Creates or updates a peering in the specified virtual network. </summary>
        /// <param name="virtualNetworkPeeringName"> The name of the peering. </param>
        /// <param name="virtualNetworkPeeringParameters"> Parameters supplied to the create or update virtual network peering operation. </param>
        /// <param name="syncRemoteAddressSpace"> Parameter indicates the intention to sync the peering with the current address space on the remote vNet after it&apos;s updated. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkPeeringName"/> or <paramref name="virtualNetworkPeeringParameters"/> is null. </exception>
        public async virtual Task<VirtualNetworkPeeringCreateOrUpdateOperation> CreateOrUpdateAsync(string virtualNetworkPeeringName, VirtualNetworkPeeringData virtualNetworkPeeringParameters, SyncRemoteAddressSpace? syncRemoteAddressSpace = null, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (virtualNetworkPeeringName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkPeeringName));
            }
            if (virtualNetworkPeeringParameters == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkPeeringParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkPeeringContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Name, virtualNetworkPeeringName, virtualNetworkPeeringParameters, syncRemoteAddressSpace, cancellationToken).ConfigureAwait(false);
                var operation = new VirtualNetworkPeeringCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, virtualNetworkPeeringName, virtualNetworkPeeringParameters, syncRemoteAddressSpace).Request, response);
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
        /// <param name="virtualNetworkPeeringName"> The name of the virtual network peering. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<VirtualNetworkPeering> Get(string virtualNetworkPeeringName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkPeeringContainer.Get");
            scope.Start();
            try
            {
                if (virtualNetworkPeeringName == null)
                {
                    throw new ArgumentNullException(nameof(virtualNetworkPeeringName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, virtualNetworkPeeringName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkPeering(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="virtualNetworkPeeringName"> The name of the virtual network peering. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<VirtualNetworkPeering>> GetAsync(string virtualNetworkPeeringName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkPeeringContainer.Get");
            scope.Start();
            try
            {
                if (virtualNetworkPeeringName == null)
                {
                    throw new ArgumentNullException(nameof(virtualNetworkPeeringName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, virtualNetworkPeeringName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VirtualNetworkPeering(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualNetworkPeeringName"> The name of the virtual network peering. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<VirtualNetworkPeering> GetIfExists(string virtualNetworkPeeringName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkPeeringContainer.GetIfExists");
            scope.Start();
            try
            {
                if (virtualNetworkPeeringName == null)
                {
                    throw new ArgumentNullException(nameof(virtualNetworkPeeringName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, virtualNetworkPeeringName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<VirtualNetworkPeering>(null, response.GetRawResponse())
                    : Response.FromValue(new VirtualNetworkPeering(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualNetworkPeeringName"> The name of the virtual network peering. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<VirtualNetworkPeering>> GetIfExistsAsync(string virtualNetworkPeeringName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkPeeringContainer.GetIfExists");
            scope.Start();
            try
            {
                if (virtualNetworkPeeringName == null)
                {
                    throw new ArgumentNullException(nameof(virtualNetworkPeeringName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, virtualNetworkPeeringName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<VirtualNetworkPeering>(null, response.GetRawResponse())
                    : Response.FromValue(new VirtualNetworkPeering(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualNetworkPeeringName"> The name of the virtual network peering. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string virtualNetworkPeeringName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkPeeringContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (virtualNetworkPeeringName == null)
                {
                    throw new ArgumentNullException(nameof(virtualNetworkPeeringName));
                }

                var response = GetIfExists(virtualNetworkPeeringName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualNetworkPeeringName"> The name of the virtual network peering. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string virtualNetworkPeeringName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkPeeringContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (virtualNetworkPeeringName == null)
                {
                    throw new ArgumentNullException(nameof(virtualNetworkPeeringName));
                }

                var response = await GetIfExistsAsync(virtualNetworkPeeringName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all virtual network peerings in a virtual network. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualNetworkPeering" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualNetworkPeering> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VirtualNetworkPeering> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkPeeringContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAll(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkPeering(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualNetworkPeering> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkPeeringContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllNextPage(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkPeering(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all virtual network peerings in a virtual network. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualNetworkPeering" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualNetworkPeering> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualNetworkPeering>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkPeeringContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllAsync(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkPeering(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualNetworkPeering>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkPeeringContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllNextPageAsync(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkPeering(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="VirtualNetworkPeering" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkPeeringContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VirtualNetworkPeering.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="VirtualNetworkPeering" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkPeeringContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VirtualNetworkPeering.ResourceType);
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
        // public ArmBuilder<ResourceIdentifier, VirtualNetworkPeering, VirtualNetworkPeeringData> Construct() { }
    }
}
