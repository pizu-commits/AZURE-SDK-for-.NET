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
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class representing collection of PolicyDefinition and their operations over its parent. </summary>
    public partial class TenantPolicyDefinitionCollection : ArmCollection, IEnumerable<TenantPolicyDefinition>, IAsyncEnumerable<TenantPolicyDefinition>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly PolicyDefinitionsRestOperations _policyDefinitionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="TenantPolicyDefinitionCollection"/> class for mocking. </summary>
        protected TenantPolicyDefinitionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TenantPolicyDefinitionCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal TenantPolicyDefinitionCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", typeof(ArmClientOptions).Assembly, DiagnosticOptions);
            _policyDefinitionsRestClient = new PolicyDefinitionsRestOperations(_clientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Tenant.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Tenant.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}
        /// ContextualPath: /
        /// OperationId: PolicyDefinitions_GetBuiltIn
        /// <summary> This operation retrieves the built-in policy definition with the given name. </summary>
        /// <param name="policyDefinitionName"> The name of the built-in policy definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyDefinitionName"/> is null. </exception>
        public virtual Response<TenantPolicyDefinition> Get(string policyDefinitionName, CancellationToken cancellationToken = default)
        {
            if (policyDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(policyDefinitionName));
            }

            using var scope = _clientDiagnostics.CreateScope("TenantPolicyDefinitionCollection.Get");
            scope.Start();
            try
            {
                var response = _policyDefinitionsRestClient.GetBuiltIn(policyDefinitionName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TenantPolicyDefinition(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}
        /// ContextualPath: /
        /// OperationId: PolicyDefinitions_GetBuiltIn
        /// <summary> This operation retrieves the built-in policy definition with the given name. </summary>
        /// <param name="policyDefinitionName"> The name of the built-in policy definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyDefinitionName"/> is null. </exception>
        public async virtual Task<Response<TenantPolicyDefinition>> GetAsync(string policyDefinitionName, CancellationToken cancellationToken = default)
        {
            if (policyDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(policyDefinitionName));
            }

            using var scope = _clientDiagnostics.CreateScope("TenantPolicyDefinitionCollection.Get");
            scope.Start();
            try
            {
                var response = await _policyDefinitionsRestClient.GetBuiltInAsync(policyDefinitionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new TenantPolicyDefinition(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="policyDefinitionName"> The name of the built-in policy definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyDefinitionName"/> is null. </exception>
        public virtual Response<TenantPolicyDefinition> GetIfExists(string policyDefinitionName, CancellationToken cancellationToken = default)
        {
            if (policyDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(policyDefinitionName));
            }

            using var scope = _clientDiagnostics.CreateScope("TenantPolicyDefinitionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _policyDefinitionsRestClient.GetBuiltIn(policyDefinitionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<TenantPolicyDefinition>(null, response.GetRawResponse());
                return Response.FromValue(new TenantPolicyDefinition(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="policyDefinitionName"> The name of the built-in policy definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyDefinitionName"/> is null. </exception>
        public async virtual Task<Response<TenantPolicyDefinition>> GetIfExistsAsync(string policyDefinitionName, CancellationToken cancellationToken = default)
        {
            if (policyDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(policyDefinitionName));
            }

            using var scope = _clientDiagnostics.CreateScope("TenantPolicyDefinitionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _policyDefinitionsRestClient.GetBuiltInAsync(policyDefinitionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<TenantPolicyDefinition>(null, response.GetRawResponse());
                return Response.FromValue(new TenantPolicyDefinition(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="policyDefinitionName"> The name of the built-in policy definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyDefinitionName"/> is null. </exception>
        public virtual Response<bool> Exists(string policyDefinitionName, CancellationToken cancellationToken = default)
        {
            if (policyDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(policyDefinitionName));
            }

            using var scope = _clientDiagnostics.CreateScope("TenantPolicyDefinitionCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(policyDefinitionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="policyDefinitionName"> The name of the built-in policy definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyDefinitionName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string policyDefinitionName, CancellationToken cancellationToken = default)
        {
            if (policyDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(policyDefinitionName));
            }

            using var scope = _clientDiagnostics.CreateScope("TenantPolicyDefinitionCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(policyDefinitionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /providers/Microsoft.Authorization/policyDefinitions
        /// ContextualPath: /
        /// OperationId: PolicyDefinitions_ListBuiltIn
        /// <summary> This operation retrieves a list of all the built-in policy definitions that match the optional given $filter. If $filter=&apos;policyType -eq {value}&apos; is provided, the returned list only includes all built-in policy definitions whose type match the {value}. Possible policyType values are NotSpecified, BuiltIn, Custom, and Static. If $filter=&apos;category -eq {value}&apos; is provided, the returned list only includes all built-in policy definitions whose category match the {value}. </summary>
        /// <param name="filter"> The filter to apply on the operation. Valid values for $filter are: &apos;atExactScope()&apos;, &apos;policyType -eq {value}&apos; or &apos;category eq &apos;{value}&apos;&apos;. If $filter is not provided, no filtering is performed. If $filter=atExactScope() is provided, the returned list only includes all policy definitions that at the given scope. If $filter=&apos;policyType -eq {value}&apos; is provided, the returned list only includes all policy definitions whose type match the {value}. Possible policyType values are NotSpecified, BuiltIn, Custom, and Static. If $filter=&apos;category -eq {value}&apos; is provided, the returned list only includes all policy definitions whose category match the {value}. </param>
        /// <param name="top"> Maximum number of records to return. When the $top filter is not provided, it will return 500 records. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="TenantPolicyDefinition" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<TenantPolicyDefinition> GetAll(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            Page<TenantPolicyDefinition> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("TenantPolicyDefinitionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _policyDefinitionsRestClient.ListBuiltIn(filter, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new TenantPolicyDefinition(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<TenantPolicyDefinition> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("TenantPolicyDefinitionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _policyDefinitionsRestClient.ListBuiltInNextPage(nextLink, filter, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new TenantPolicyDefinition(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /providers/Microsoft.Authorization/policyDefinitions
        /// ContextualPath: /
        /// OperationId: PolicyDefinitions_ListBuiltIn
        /// <summary> This operation retrieves a list of all the built-in policy definitions that match the optional given $filter. If $filter=&apos;policyType -eq {value}&apos; is provided, the returned list only includes all built-in policy definitions whose type match the {value}. Possible policyType values are NotSpecified, BuiltIn, Custom, and Static. If $filter=&apos;category -eq {value}&apos; is provided, the returned list only includes all built-in policy definitions whose category match the {value}. </summary>
        /// <param name="filter"> The filter to apply on the operation. Valid values for $filter are: &apos;atExactScope()&apos;, &apos;policyType -eq {value}&apos; or &apos;category eq &apos;{value}&apos;&apos;. If $filter is not provided, no filtering is performed. If $filter=atExactScope() is provided, the returned list only includes all policy definitions that at the given scope. If $filter=&apos;policyType -eq {value}&apos; is provided, the returned list only includes all policy definitions whose type match the {value}. Possible policyType values are NotSpecified, BuiltIn, Custom, and Static. If $filter=&apos;category -eq {value}&apos; is provided, the returned list only includes all policy definitions whose category match the {value}. </param>
        /// <param name="top"> Maximum number of records to return. When the $top filter is not provided, it will return 500 records. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="TenantPolicyDefinition" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<TenantPolicyDefinition> GetAllAsync(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<TenantPolicyDefinition>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("TenantPolicyDefinitionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _policyDefinitionsRestClient.ListBuiltInAsync(filter, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new TenantPolicyDefinition(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<TenantPolicyDefinition>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("TenantPolicyDefinitionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _policyDefinitionsRestClient.ListBuiltInNextPageAsync(nextLink, filter, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new TenantPolicyDefinition(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<TenantPolicyDefinition> IEnumerable<TenantPolicyDefinition>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<TenantPolicyDefinition> IAsyncEnumerable<TenantPolicyDefinition>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, TenantPolicyDefinition, PolicyDefinitionData> Construct() { }
    }
}
