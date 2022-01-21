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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of P2SVpnGateway and their operations over its parent. </summary>
    public partial class P2SVpnGatewayCollection : ArmCollection, IEnumerable<P2SVpnGateway>, IAsyncEnumerable<P2SVpnGateway>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly P2SVpnGatewaysRestOperations _p2sVpnGatewaysRestClient;

        /// <summary> Initializes a new instance of the <see cref="P2SVpnGatewayCollection"/> class for mocking. </summary>
        protected P2SVpnGatewayCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="P2SVpnGatewayCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal P2SVpnGatewayCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(P2SVpnGateway.ResourceType, out string apiVersion);
            _p2sVpnGatewaysRestClient = new P2SVpnGatewaysRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Creates a virtual wan p2s vpn gateway if it doesn&apos;t exist else updates the existing gateway. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="p2SVpnGatewayParameters"> Parameters supplied to create or Update a virtual wan p2s vpn gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> or <paramref name="p2SVpnGatewayParameters"/> is null. </exception>
        public virtual P2SVpnGatewayCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string gatewayName, P2SVpnGatewayData p2SVpnGatewayParameters, CancellationToken cancellationToken = default)
        {
            if (gatewayName == null)
            {
                throw new ArgumentNullException(nameof(gatewayName));
            }
            if (p2SVpnGatewayParameters == null)
            {
                throw new ArgumentNullException(nameof(p2SVpnGatewayParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("P2SVpnGatewayCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _p2sVpnGatewaysRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, gatewayName, p2SVpnGatewayParameters, cancellationToken);
                var operation = new P2SVpnGatewayCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _p2sVpnGatewaysRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, gatewayName, p2SVpnGatewayParameters).Request, response);
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

        /// <summary> Creates a virtual wan p2s vpn gateway if it doesn&apos;t exist else updates the existing gateway. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="p2SVpnGatewayParameters"> Parameters supplied to create or Update a virtual wan p2s vpn gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> or <paramref name="p2SVpnGatewayParameters"/> is null. </exception>
        public async virtual Task<P2SVpnGatewayCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string gatewayName, P2SVpnGatewayData p2SVpnGatewayParameters, CancellationToken cancellationToken = default)
        {
            if (gatewayName == null)
            {
                throw new ArgumentNullException(nameof(gatewayName));
            }
            if (p2SVpnGatewayParameters == null)
            {
                throw new ArgumentNullException(nameof(p2SVpnGatewayParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("P2SVpnGatewayCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _p2sVpnGatewaysRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, gatewayName, p2SVpnGatewayParameters, cancellationToken).ConfigureAwait(false);
                var operation = new P2SVpnGatewayCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _p2sVpnGatewaysRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, gatewayName, p2SVpnGatewayParameters).Request, response);
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

        /// <summary> Retrieves the details of a virtual wan p2s vpn gateway. </summary>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public virtual Response<P2SVpnGateway> Get(string gatewayName, CancellationToken cancellationToken = default)
        {
            if (gatewayName == null)
            {
                throw new ArgumentNullException(nameof(gatewayName));
            }

            using var scope = _clientDiagnostics.CreateScope("P2SVpnGatewayCollection.Get");
            scope.Start();
            try
            {
                var response = _p2sVpnGatewaysRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, gatewayName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new P2SVpnGateway(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves the details of a virtual wan p2s vpn gateway. </summary>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public async virtual Task<Response<P2SVpnGateway>> GetAsync(string gatewayName, CancellationToken cancellationToken = default)
        {
            if (gatewayName == null)
            {
                throw new ArgumentNullException(nameof(gatewayName));
            }

            using var scope = _clientDiagnostics.CreateScope("P2SVpnGatewayCollection.Get");
            scope.Start();
            try
            {
                var response = await _p2sVpnGatewaysRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, gatewayName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new P2SVpnGateway(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public virtual Response<P2SVpnGateway> GetIfExists(string gatewayName, CancellationToken cancellationToken = default)
        {
            if (gatewayName == null)
            {
                throw new ArgumentNullException(nameof(gatewayName));
            }

            using var scope = _clientDiagnostics.CreateScope("P2SVpnGatewayCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _p2sVpnGatewaysRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, gatewayName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<P2SVpnGateway>(null, response.GetRawResponse());
                return Response.FromValue(new P2SVpnGateway(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public async virtual Task<Response<P2SVpnGateway>> GetIfExistsAsync(string gatewayName, CancellationToken cancellationToken = default)
        {
            if (gatewayName == null)
            {
                throw new ArgumentNullException(nameof(gatewayName));
            }

            using var scope = _clientDiagnostics.CreateScope("P2SVpnGatewayCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _p2sVpnGatewaysRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, gatewayName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<P2SVpnGateway>(null, response.GetRawResponse());
                return Response.FromValue(new P2SVpnGateway(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public virtual Response<bool> Exists(string gatewayName, CancellationToken cancellationToken = default)
        {
            if (gatewayName == null)
            {
                throw new ArgumentNullException(nameof(gatewayName));
            }

            using var scope = _clientDiagnostics.CreateScope("P2SVpnGatewayCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(gatewayName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string gatewayName, CancellationToken cancellationToken = default)
        {
            if (gatewayName == null)
            {
                throw new ArgumentNullException(nameof(gatewayName));
            }

            using var scope = _clientDiagnostics.CreateScope("P2SVpnGatewayCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(gatewayName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all the P2SVpnGateways in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="P2SVpnGateway" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<P2SVpnGateway> GetAll(CancellationToken cancellationToken = default)
        {
            Page<P2SVpnGateway> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("P2SVpnGatewayCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _p2sVpnGatewaysRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new P2SVpnGateway(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<P2SVpnGateway> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("P2SVpnGatewayCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _p2sVpnGatewaysRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new P2SVpnGateway(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all the P2SVpnGateways in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="P2SVpnGateway" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<P2SVpnGateway> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<P2SVpnGateway>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("P2SVpnGatewayCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _p2sVpnGatewaysRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new P2SVpnGateway(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<P2SVpnGateway>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("P2SVpnGatewayCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _p2sVpnGatewaysRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new P2SVpnGateway(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="P2SVpnGateway" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("P2SVpnGatewayCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(P2SVpnGateway.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="P2SVpnGateway" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("P2SVpnGatewayCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(P2SVpnGateway.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<P2SVpnGateway> IEnumerable<P2SVpnGateway>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<P2SVpnGateway> IAsyncEnumerable<P2SVpnGateway>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, P2SVpnGateway, P2SVpnGatewayData> Construct() { }
    }
}
