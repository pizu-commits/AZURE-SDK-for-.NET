// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of ExpressRouteGateway and their operations over a ResourceGroup. </summary>
    public partial class ExpressRouteGatewayContainer : ResourceContainer
    {
        /// <summary> Initializes a new instance of the <see cref="ExpressRouteGatewayContainer"/> class for mocking. </summary>
        protected ExpressRouteGatewayContainer()
        {
        }

        /// <summary> Initializes a new instance of ExpressRouteGatewayContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ExpressRouteGatewayContainer(ResourceOperations parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private ExpressRouteGatewaysRestOperations _restClient => new ExpressRouteGatewaysRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroupOperations.ResourceType;

        // Container level operations.

        /// <summary> Creates or updates a ExpressRoute gateway in a specified resource group. </summary>
        /// <param name="expressRouteGatewayName"> The name of the ExpressRoute gateway. </param>
        /// <param name="putExpressRouteGatewayParameters"> Parameters required in an ExpressRoute gateway PUT operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="expressRouteGatewayName"/> or <paramref name="putExpressRouteGatewayParameters"/> is null. </exception>
        public virtual Response<ExpressRouteGateway> CreateOrUpdate(string expressRouteGatewayName, ExpressRouteGatewayData putExpressRouteGatewayParameters, CancellationToken cancellationToken = default)
        {
            if (expressRouteGatewayName == null)
            {
                throw new ArgumentNullException(nameof(expressRouteGatewayName));
            }
            if (putExpressRouteGatewayParameters == null)
            {
                throw new ArgumentNullException(nameof(putExpressRouteGatewayParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteGatewayContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(expressRouteGatewayName, putExpressRouteGatewayParameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a ExpressRoute gateway in a specified resource group. </summary>
        /// <param name="expressRouteGatewayName"> The name of the ExpressRoute gateway. </param>
        /// <param name="putExpressRouteGatewayParameters"> Parameters required in an ExpressRoute gateway PUT operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="expressRouteGatewayName"/> or <paramref name="putExpressRouteGatewayParameters"/> is null. </exception>
        public async virtual Task<Response<ExpressRouteGateway>> CreateOrUpdateAsync(string expressRouteGatewayName, ExpressRouteGatewayData putExpressRouteGatewayParameters, CancellationToken cancellationToken = default)
        {
            if (expressRouteGatewayName == null)
            {
                throw new ArgumentNullException(nameof(expressRouteGatewayName));
            }
            if (putExpressRouteGatewayParameters == null)
            {
                throw new ArgumentNullException(nameof(putExpressRouteGatewayParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteGatewayContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(expressRouteGatewayName, putExpressRouteGatewayParameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a ExpressRoute gateway in a specified resource group. </summary>
        /// <param name="expressRouteGatewayName"> The name of the ExpressRoute gateway. </param>
        /// <param name="putExpressRouteGatewayParameters"> Parameters required in an ExpressRoute gateway PUT operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="expressRouteGatewayName"/> or <paramref name="putExpressRouteGatewayParameters"/> is null. </exception>
        public virtual ExpressRouteGatewaysCreateOrUpdateOperation StartCreateOrUpdate(string expressRouteGatewayName, ExpressRouteGatewayData putExpressRouteGatewayParameters, CancellationToken cancellationToken = default)
        {
            if (expressRouteGatewayName == null)
            {
                throw new ArgumentNullException(nameof(expressRouteGatewayName));
            }
            if (putExpressRouteGatewayParameters == null)
            {
                throw new ArgumentNullException(nameof(putExpressRouteGatewayParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteGatewayContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, expressRouteGatewayName, putExpressRouteGatewayParameters, cancellationToken);
                return new ExpressRouteGatewaysCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, expressRouteGatewayName, putExpressRouteGatewayParameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a ExpressRoute gateway in a specified resource group. </summary>
        /// <param name="expressRouteGatewayName"> The name of the ExpressRoute gateway. </param>
        /// <param name="putExpressRouteGatewayParameters"> Parameters required in an ExpressRoute gateway PUT operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="expressRouteGatewayName"/> or <paramref name="putExpressRouteGatewayParameters"/> is null. </exception>
        public async virtual Task<ExpressRouteGatewaysCreateOrUpdateOperation> StartCreateOrUpdateAsync(string expressRouteGatewayName, ExpressRouteGatewayData putExpressRouteGatewayParameters, CancellationToken cancellationToken = default)
        {
            if (expressRouteGatewayName == null)
            {
                throw new ArgumentNullException(nameof(expressRouteGatewayName));
            }
            if (putExpressRouteGatewayParameters == null)
            {
                throw new ArgumentNullException(nameof(putExpressRouteGatewayParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteGatewayContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, expressRouteGatewayName, putExpressRouteGatewayParameters, cancellationToken).ConfigureAwait(false);
                return new ExpressRouteGatewaysCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, expressRouteGatewayName, putExpressRouteGatewayParameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="expressRouteGatewayName"> The name of the ExpressRoute gateway. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<ExpressRouteGateway> Get(string expressRouteGatewayName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteGatewayContainer.Get");
            scope.Start();
            try
            {
                if (expressRouteGatewayName == null)
                {
                    throw new ArgumentNullException(nameof(expressRouteGatewayName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, expressRouteGatewayName, cancellationToken: cancellationToken);
                return Response.FromValue(new ExpressRouteGateway(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="expressRouteGatewayName"> The name of the ExpressRoute gateway. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<ExpressRouteGateway>> GetAsync(string expressRouteGatewayName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteGatewayContainer.Get");
            scope.Start();
            try
            {
                if (expressRouteGatewayName == null)
                {
                    throw new ArgumentNullException(nameof(expressRouteGatewayName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, expressRouteGatewayName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ExpressRouteGateway(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="expressRouteGatewayName"> The name of the ExpressRoute gateway. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual ExpressRouteGateway TryGet(string expressRouteGatewayName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteGatewayContainer.TryGet");
            scope.Start();
            try
            {
                if (expressRouteGatewayName == null)
                {
                    throw new ArgumentNullException(nameof(expressRouteGatewayName));
                }

                return Get(expressRouteGatewayName, cancellationToken: cancellationToken).Value;
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
        /// <param name="expressRouteGatewayName"> The name of the ExpressRoute gateway. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<ExpressRouteGateway> TryGetAsync(string expressRouteGatewayName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteGatewayContainer.TryGet");
            scope.Start();
            try
            {
                if (expressRouteGatewayName == null)
                {
                    throw new ArgumentNullException(nameof(expressRouteGatewayName));
                }

                return await GetAsync(expressRouteGatewayName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <param name="expressRouteGatewayName"> The name of the ExpressRoute gateway. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual bool CheckIfExists(string expressRouteGatewayName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteGatewayContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (expressRouteGatewayName == null)
                {
                    throw new ArgumentNullException(nameof(expressRouteGatewayName));
                }

                return TryGet(expressRouteGatewayName, cancellationToken: cancellationToken) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="expressRouteGatewayName"> The name of the ExpressRoute gateway. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<bool> CheckIfExistsAsync(string expressRouteGatewayName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteGatewayContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (expressRouteGatewayName == null)
                {
                    throw new ArgumentNullException(nameof(expressRouteGatewayName));
                }

                return await TryGetAsync(expressRouteGatewayName, cancellationToken: cancellationToken).ConfigureAwait(false) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="ExpressRouteGateway" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> GetAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteGatewayContainer.GetAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ExpressRouteGatewayOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="ExpressRouteGateway" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> GetAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteGatewayContainer.GetAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ExpressRouteGatewayOperations.ResourceType);
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
        // public ArmBuilder<ResourceIdentifier, ExpressRouteGateway, ExpressRouteGatewayData> Construct() { }
    }
}
