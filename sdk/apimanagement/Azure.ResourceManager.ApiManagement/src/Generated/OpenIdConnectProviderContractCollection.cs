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

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="OpenIdConnectProviderContractResource" /> and their operations.
    /// Each <see cref="OpenIdConnectProviderContractResource" /> in the collection will belong to the same instance of <see cref="ApiManagementServiceResource" />.
    /// To get an <see cref="OpenIdConnectProviderContractCollection" /> instance call the GetOpenIdConnectProviderContracts method from an instance of <see cref="ApiManagementServiceResource" />.
    /// </summary>
    public partial class OpenIdConnectProviderContractCollection : ArmCollection, IEnumerable<OpenIdConnectProviderContractResource>, IAsyncEnumerable<OpenIdConnectProviderContractResource>
    {
        private readonly ClientDiagnostics _openIdConnectProviderContractOpenIdConnectProviderClientDiagnostics;
        private readonly OpenIdConnectProviderRestOperations _openIdConnectProviderContractOpenIdConnectProviderRestClient;

        /// <summary> Initializes a new instance of the <see cref="OpenIdConnectProviderContractCollection"/> class for mocking. </summary>
        protected OpenIdConnectProviderContractCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="OpenIdConnectProviderContractCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal OpenIdConnectProviderContractCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _openIdConnectProviderContractOpenIdConnectProviderClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", OpenIdConnectProviderContractResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(OpenIdConnectProviderContractResource.ResourceType, out string openIdConnectProviderContractOpenIdConnectProviderApiVersion);
            _openIdConnectProviderContractOpenIdConnectProviderRestClient = new OpenIdConnectProviderRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, openIdConnectProviderContractOpenIdConnectProviderApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ApiManagementServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ApiManagementServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates the OpenID Connect Provider.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/openidConnectProviders/{opid}
        /// Operation Id: OpenIdConnectProvider_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="openId"> Identifier of the OpenID Connect Provider. </param>
        /// <param name="data"> Create parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="openId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="openId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<OpenIdConnectProviderContractResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string openId, OpenIdConnectProviderContractData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(openId, nameof(openId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _openIdConnectProviderContractOpenIdConnectProviderClientDiagnostics.CreateScope("OpenIdConnectProviderContractCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _openIdConnectProviderContractOpenIdConnectProviderRestClient.CreateOrUpdateAsync(openId, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<OpenIdConnectProviderContractResource>(Response.FromValue(new OpenIdConnectProviderContractResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates the OpenID Connect Provider.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/openidConnectProviders/{opid}
        /// Operation Id: OpenIdConnectProvider_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="openId"> Identifier of the OpenID Connect Provider. </param>
        /// <param name="data"> Create parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="openId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="openId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<OpenIdConnectProviderContractResource> CreateOrUpdate(WaitUntil waitUntil, string openId, OpenIdConnectProviderContractData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(openId, nameof(openId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _openIdConnectProviderContractOpenIdConnectProviderClientDiagnostics.CreateScope("OpenIdConnectProviderContractCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _openIdConnectProviderContractOpenIdConnectProviderRestClient.CreateOrUpdate(openId, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, data, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation<OpenIdConnectProviderContractResource>(Response.FromValue(new OpenIdConnectProviderContractResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets specific OpenID Connect Provider without secrets.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/openidConnectProviders/{opid}
        /// Operation Id: OpenIdConnectProvider_Get
        /// </summary>
        /// <param name="openId"> Identifier of the OpenID Connect Provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="openId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="openId"/> is null. </exception>
        public virtual async Task<Response<OpenIdConnectProviderContractResource>> GetAsync(string openId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(openId, nameof(openId));

            using var scope = _openIdConnectProviderContractOpenIdConnectProviderClientDiagnostics.CreateScope("OpenIdConnectProviderContractCollection.Get");
            scope.Start();
            try
            {
                var response = await _openIdConnectProviderContractOpenIdConnectProviderRestClient.GetAsync(openId, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OpenIdConnectProviderContractResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets specific OpenID Connect Provider without secrets.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/openidConnectProviders/{opid}
        /// Operation Id: OpenIdConnectProvider_Get
        /// </summary>
        /// <param name="openId"> Identifier of the OpenID Connect Provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="openId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="openId"/> is null. </exception>
        public virtual Response<OpenIdConnectProviderContractResource> Get(string openId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(openId, nameof(openId));

            using var scope = _openIdConnectProviderContractOpenIdConnectProviderClientDiagnostics.CreateScope("OpenIdConnectProviderContractCollection.Get");
            scope.Start();
            try
            {
                var response = _openIdConnectProviderContractOpenIdConnectProviderRestClient.Get(openId, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OpenIdConnectProviderContractResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists of all the OpenId Connect Providers.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/openidConnectProviders
        /// Operation Id: OpenIdConnectProvider_ListByService
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| displayName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OpenIdConnectProviderContractResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<OpenIdConnectProviderContractResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<OpenIdConnectProviderContractResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _openIdConnectProviderContractOpenIdConnectProviderClientDiagnostics.CreateScope("OpenIdConnectProviderContractCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _openIdConnectProviderContractOpenIdConnectProviderRestClient.ListByServiceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new OpenIdConnectProviderContractResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<OpenIdConnectProviderContractResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _openIdConnectProviderContractOpenIdConnectProviderClientDiagnostics.CreateScope("OpenIdConnectProviderContractCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _openIdConnectProviderContractOpenIdConnectProviderRestClient.ListByServiceNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new OpenIdConnectProviderContractResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists of all the OpenId Connect Providers.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/openidConnectProviders
        /// Operation Id: OpenIdConnectProvider_ListByService
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| displayName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OpenIdConnectProviderContractResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<OpenIdConnectProviderContractResource> GetAll(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            Page<OpenIdConnectProviderContractResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _openIdConnectProviderContractOpenIdConnectProviderClientDiagnostics.CreateScope("OpenIdConnectProviderContractCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _openIdConnectProviderContractOpenIdConnectProviderRestClient.ListByService(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new OpenIdConnectProviderContractResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<OpenIdConnectProviderContractResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _openIdConnectProviderContractOpenIdConnectProviderClientDiagnostics.CreateScope("OpenIdConnectProviderContractCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _openIdConnectProviderContractOpenIdConnectProviderRestClient.ListByServiceNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new OpenIdConnectProviderContractResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/openidConnectProviders/{opid}
        /// Operation Id: OpenIdConnectProvider_Get
        /// </summary>
        /// <param name="openId"> Identifier of the OpenID Connect Provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="openId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="openId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string openId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(openId, nameof(openId));

            using var scope = _openIdConnectProviderContractOpenIdConnectProviderClientDiagnostics.CreateScope("OpenIdConnectProviderContractCollection.Exists");
            scope.Start();
            try
            {
                var response = await _openIdConnectProviderContractOpenIdConnectProviderRestClient.GetAsync(openId, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/openidConnectProviders/{opid}
        /// Operation Id: OpenIdConnectProvider_Get
        /// </summary>
        /// <param name="openId"> Identifier of the OpenID Connect Provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="openId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="openId"/> is null. </exception>
        public virtual Response<bool> Exists(string openId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(openId, nameof(openId));

            using var scope = _openIdConnectProviderContractOpenIdConnectProviderClientDiagnostics.CreateScope("OpenIdConnectProviderContractCollection.Exists");
            scope.Start();
            try
            {
                var response = _openIdConnectProviderContractOpenIdConnectProviderRestClient.Get(openId, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<OpenIdConnectProviderContractResource> IEnumerable<OpenIdConnectProviderContractResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<OpenIdConnectProviderContractResource> IAsyncEnumerable<OpenIdConnectProviderContractResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
