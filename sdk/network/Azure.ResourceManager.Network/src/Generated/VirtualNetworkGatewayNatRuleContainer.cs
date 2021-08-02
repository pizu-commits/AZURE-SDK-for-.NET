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
    /// <summary> A class representing collection of VirtualNetworkGatewayNatRule and their operations over a VirtualNetworkGateway. </summary>
    public partial class VirtualNetworkGatewayNatRuleContainer : ResourceContainer
    {
        /// <summary> Initializes a new instance of the <see cref="VirtualNetworkGatewayNatRuleContainer"/> class for mocking. </summary>
        protected VirtualNetworkGatewayNatRuleContainer()
        {
        }

        /// <summary> Initializes a new instance of VirtualNetworkGatewayNatRuleContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal VirtualNetworkGatewayNatRuleContainer(ResourceOperations parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private VirtualNetworkGatewayNatRulesRestOperations _restClient => new VirtualNetworkGatewayNatRulesRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => VirtualNetworkGatewayOperations.ResourceType;

        // Container level operations.

        /// <summary> Creates a nat rule to a scalable virtual network gateway if it doesn&apos;t exist else updates the existing nat rules. </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="natRuleParameters"> Parameters supplied to create or Update a Nat Rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> or <paramref name="natRuleParameters"/> is null. </exception>
        public virtual Response<VirtualNetworkGatewayNatRule> CreateOrUpdate(string natRuleName, VirtualNetworkGatewayNatRuleData natRuleParameters, CancellationToken cancellationToken = default)
        {
            if (natRuleName == null)
            {
                throw new ArgumentNullException(nameof(natRuleName));
            }
            if (natRuleParameters == null)
            {
                throw new ArgumentNullException(nameof(natRuleParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(natRuleName, natRuleParameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a nat rule to a scalable virtual network gateway if it doesn&apos;t exist else updates the existing nat rules. </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="natRuleParameters"> Parameters supplied to create or Update a Nat Rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> or <paramref name="natRuleParameters"/> is null. </exception>
        public async virtual Task<Response<VirtualNetworkGatewayNatRule>> CreateOrUpdateAsync(string natRuleName, VirtualNetworkGatewayNatRuleData natRuleParameters, CancellationToken cancellationToken = default)
        {
            if (natRuleName == null)
            {
                throw new ArgumentNullException(nameof(natRuleName));
            }
            if (natRuleParameters == null)
            {
                throw new ArgumentNullException(nameof(natRuleParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(natRuleName, natRuleParameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a nat rule to a scalable virtual network gateway if it doesn&apos;t exist else updates the existing nat rules. </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="natRuleParameters"> Parameters supplied to create or Update a Nat Rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> or <paramref name="natRuleParameters"/> is null. </exception>
        public virtual VirtualNetworkGatewayNatRulesCreateOrUpdateOperation StartCreateOrUpdate(string natRuleName, VirtualNetworkGatewayNatRuleData natRuleParameters, CancellationToken cancellationToken = default)
        {
            if (natRuleName == null)
            {
                throw new ArgumentNullException(nameof(natRuleName));
            }
            if (natRuleParameters == null)
            {
                throw new ArgumentNullException(nameof(natRuleParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, Id.Name, natRuleName, natRuleParameters, cancellationToken);
                return new VirtualNetworkGatewayNatRulesCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, natRuleName, natRuleParameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a nat rule to a scalable virtual network gateway if it doesn&apos;t exist else updates the existing nat rules. </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="natRuleParameters"> Parameters supplied to create or Update a Nat Rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> or <paramref name="natRuleParameters"/> is null. </exception>
        public async virtual Task<VirtualNetworkGatewayNatRulesCreateOrUpdateOperation> StartCreateOrUpdateAsync(string natRuleName, VirtualNetworkGatewayNatRuleData natRuleParameters, CancellationToken cancellationToken = default)
        {
            if (natRuleName == null)
            {
                throw new ArgumentNullException(nameof(natRuleName));
            }
            if (natRuleParameters == null)
            {
                throw new ArgumentNullException(nameof(natRuleParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Name, natRuleName, natRuleParameters, cancellationToken).ConfigureAwait(false);
                return new VirtualNetworkGatewayNatRulesCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, natRuleName, natRuleParameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<VirtualNetworkGatewayNatRule> Get(string natRuleName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleContainer.Get");
            scope.Start();
            try
            {
                if (natRuleName == null)
                {
                    throw new ArgumentNullException(nameof(natRuleName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, natRuleName, cancellationToken: cancellationToken);
                return Response.FromValue(new VirtualNetworkGatewayNatRule(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<VirtualNetworkGatewayNatRule>> GetAsync(string natRuleName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleContainer.Get");
            scope.Start();
            try
            {
                if (natRuleName == null)
                {
                    throw new ArgumentNullException(nameof(natRuleName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, natRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new VirtualNetworkGatewayNatRule(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual VirtualNetworkGatewayNatRule TryGet(string natRuleName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleContainer.TryGet");
            scope.Start();
            try
            {
                if (natRuleName == null)
                {
                    throw new ArgumentNullException(nameof(natRuleName));
                }

                return Get(natRuleName, cancellationToken: cancellationToken).Value;
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
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<VirtualNetworkGatewayNatRule> TryGetAsync(string natRuleName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleContainer.TryGet");
            scope.Start();
            try
            {
                if (natRuleName == null)
                {
                    throw new ArgumentNullException(nameof(natRuleName));
                }

                return await GetAsync(natRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual bool CheckIfExists(string natRuleName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (natRuleName == null)
                {
                    throw new ArgumentNullException(nameof(natRuleName));
                }

                return TryGet(natRuleName, cancellationToken: cancellationToken) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<bool> CheckIfExistsAsync(string natRuleName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (natRuleName == null)
                {
                    throw new ArgumentNullException(nameof(natRuleName));
                }

                return await TryGetAsync(natRuleName, cancellationToken: cancellationToken).ConfigureAwait(false) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves all nat rules for a particular virtual network gateway. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualNetworkGatewayNatRule" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<VirtualNetworkGatewayNatRule> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VirtualNetworkGatewayNatRule> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetByVirtualNetworkGateway(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkGatewayNatRule(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualNetworkGatewayNatRule> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetByVirtualNetworkGatewayNextPage(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkGatewayNatRule(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Retrieves all nat rules for a particular virtual network gateway. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualNetworkGatewayNatRule" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<VirtualNetworkGatewayNatRule> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualNetworkGatewayNatRule>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetByVirtualNetworkGatewayAsync(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkGatewayNatRule(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualNetworkGatewayNatRule>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetByVirtualNetworkGatewayNextPageAsync(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkGatewayNatRule(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="VirtualNetworkGatewayNatRule" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> GetAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleContainer.GetAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VirtualNetworkGatewayNatRuleOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="VirtualNetworkGatewayNatRule" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> GetAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleContainer.GetAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VirtualNetworkGatewayNatRuleOperations.ResourceType);
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
        // public ArmBuilder<ResourceIdentifier, VirtualNetworkGatewayNatRule, VirtualNetworkGatewayNatRuleData> Construct() { }
    }
}
