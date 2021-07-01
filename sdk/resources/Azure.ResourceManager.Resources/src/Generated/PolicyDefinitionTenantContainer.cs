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
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class representing collection of PolicyDefinition and their operations over a Tenant. </summary>
    public partial class PolicyDefinitionTenantContainer : ResourceContainerBase<ResourceGroupResourceIdentifier, PolicyDefinition, PolicyDefinitionData>
    {
        /// <summary> Initializes a new instance of the <see cref="PolicyDefinitionTenantContainer"/> class for mocking. </summary>
        protected PolicyDefinitionTenantContainer()
        {
        }

        /// <summary> Initializes a new instance of PolicyDefinitionTenantContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal PolicyDefinitionTenantContainer(ResourceOperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private PolicyDefinitionsRestOperations _restClient => new PolicyDefinitionsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId);

        /// <summary> Typed Resource Identifier for the container. </summary>
        public new ResourceGroupResourceIdentifier Id => base.Id as ResourceGroupResourceIdentifier;

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceIdentifier.RootResourceIdentifier.ResourceType;

        // Container level operations.

        /// <summary> The operation to create or update a PolicyDefinition. Please note some properties can be set only during creation. </summary>
        /// <param name="policyDefinitionName"> The name of the policy definition to create. </param>
        /// <param name="parameters"> The policy definition properties. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public Response<PolicyDefinition> CreateOrUpdate(string policyDefinitionName, PolicyDefinitionData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionTenantContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (policyDefinitionName == null)
                {
                    throw new ArgumentNullException(nameof(policyDefinitionName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                return StartCreateOrUpdate(policyDefinitionName, parameters, cancellationToken: cancellationToken).WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a PolicyDefinition. Please note some properties can be set only during creation. </summary>
        /// <param name="policyDefinitionName"> The name of the policy definition to create. </param>
        /// <param name="parameters"> The policy definition properties. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<Response<PolicyDefinition>> CreateOrUpdateAsync(string policyDefinitionName, PolicyDefinitionData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionTenantContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (policyDefinitionName == null)
                {
                    throw new ArgumentNullException(nameof(policyDefinitionName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var operation = await StartCreateOrUpdateAsync(policyDefinitionName, parameters, cancellationToken: cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a PolicyDefinition. Please note some properties can be set only during creation. </summary>
        /// <param name="policyDefinitionName"> The name of the policy definition to create. </param>
        /// <param name="parameters"> The policy definition properties. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public PolicyDefinitionsCreateOrUpdateOperation StartCreateOrUpdate(string policyDefinitionName, PolicyDefinitionData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionTenantContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (policyDefinitionName == null)
                {
                    throw new ArgumentNullException(nameof(policyDefinitionName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var originalResponse = _restClient.CreateOrUpdate(policyDefinitionName, parameters, cancellationToken: cancellationToken);
                return new PolicyDefinitionsCreateOrUpdateOperation(Parent, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a PolicyDefinition. Please note some properties can be set only during creation. </summary>
        /// <param name="policyDefinitionName"> The name of the policy definition to create. </param>
        /// <param name="parameters"> The policy definition properties. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<PolicyDefinitionsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string policyDefinitionName, PolicyDefinitionData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionTenantContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (policyDefinitionName == null)
                {
                    throw new ArgumentNullException(nameof(policyDefinitionName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var originalResponse = await _restClient.CreateOrUpdateAsync(policyDefinitionName, parameters, cancellationToken: cancellationToken).ConfigureAwait(false);
                return new PolicyDefinitionsCreateOrUpdateOperation(Parent, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        /// <param name="policyDefinitionName"> The name of the policy definition to get. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public Response<PolicyDefinition> Get(string policyDefinitionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionTenantContainer.Get");
            scope.Start();
            try
            {
                if (policyDefinitionName == null)
                {
                    throw new ArgumentNullException(nameof(policyDefinitionName));
                }

                var response = _restClient.Get(policyDefinitionName, cancellationToken: cancellationToken);
                return Response.FromValue(new PolicyDefinition(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        /// <param name="policyDefinitionName"> The name of the policy definition to get. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<Response<PolicyDefinition>> GetAsync(string policyDefinitionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionTenantContainer.Get");
            scope.Start();
            try
            {
                if (policyDefinitionName == null)
                {
                    throw new ArgumentNullException(nameof(policyDefinitionName));
                }

                var response = await _restClient.GetAsync(policyDefinitionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new PolicyDefinition(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation retrieves a list of all the policy definitions in a given subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PolicyDefinition" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<PolicyDefinition> List(CancellationToken cancellationToken = default)
        {
            Page<PolicyDefinition> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionTenantContainer.List");
                scope.Start();
                try
                {
                    var response = _restClient.List(cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PolicyDefinition(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<PolicyDefinition> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionTenantContainer.List");
                scope.Start();
                try
                {
                    var response = _restClient.ListNextPage(nextLink, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PolicyDefinition(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> This operation retrieves a list of all the policy definitions in a given subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PolicyDefinition" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<PolicyDefinition> ListAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<PolicyDefinition>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionTenantContainer.List");
                scope.Start();
                try
                {
                    var response = await _restClient.ListAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PolicyDefinition(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<PolicyDefinition>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionTenantContainer.List");
                scope.Start();
                try
                {
                    var response = await _restClient.ListNextPageAsync(nextLink, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PolicyDefinition(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of PolicyDefinition for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<Core.GenericResourceExpanded> ListAsGenericResource(string nameFilter, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionTenantContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(PolicyDefinition.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContext(Parent as ResourceGroupOperations, filters, top: top, cancellationToken: cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of PolicyDefinition for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<Core.GenericResourceExpanded> ListAsGenericResourceAsync(string nameFilter, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionTenantContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(PolicyDefinition.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContextAsync(Parent as ResourceGroupOperations, filters, top: top, cancellationToken: cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation creates or updates a policy definition in the given management group with the given name. </summary>
        /// <param name="parameters"> The policy definition properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual async Task<Response<PolicyDefinitionData>> CreateOrUpdateAtManagementGroupAsync(PolicyDefinitionData parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionTenantContainer.CreateOrUpdateAtManagementGroup");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAtManagementGroupAsync(Id.Name, Id.Name, parameters, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation creates or updates a policy definition in the given management group with the given name. </summary>
        /// <param name="parameters"> The policy definition properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual Response<PolicyDefinitionData> CreateOrUpdateAtManagementGroup(PolicyDefinitionData parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionTenantContainer.CreateOrUpdateAtManagementGroup");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdateAtManagementGroup(Id.Name, Id.Name, parameters, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceGroupResourceIdentifier, PolicyDefinition, PolicyDefinitionData> Construct() { }
    }
}
