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
    /// A class representing a collection of <see cref="ApiManagementOpenIdConnectProviderResource" /> and their operations.
    /// Each <see cref="ApiManagementOpenIdConnectProviderResource" /> in the collection will belong to the same instance of <see cref="ApiManagementServiceResource" />.
    /// To get an <see cref="ApiManagementOpenIdConnectProviderCollection" /> instance call the GetApiManagementOpenIdConnectProviders method from an instance of <see cref="ApiManagementServiceResource" />.
    /// </summary>
    public partial class ApiManagementOpenIdConnectProviderCollection : ArmCollection, IEnumerable<ApiManagementOpenIdConnectProviderResource>, IAsyncEnumerable<ApiManagementOpenIdConnectProviderResource>
    {
        private readonly ClientDiagnostics _apiManagementOpenIdConnectProviderOpenIdConnectProviderClientDiagnostics;
        private readonly OpenIdConnectProviderRestOperations _apiManagementOpenIdConnectProviderOpenIdConnectProviderRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApiManagementOpenIdConnectProviderCollection"/> class for mocking. </summary>
        protected ApiManagementOpenIdConnectProviderCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApiManagementOpenIdConnectProviderCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ApiManagementOpenIdConnectProviderCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiManagementOpenIdConnectProviderOpenIdConnectProviderClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ApiManagementOpenIdConnectProviderResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ApiManagementOpenIdConnectProviderResource.ResourceType, out string apiManagementOpenIdConnectProviderOpenIdConnectProviderApiVersion);
            _apiManagementOpenIdConnectProviderOpenIdConnectProviderRestClient = new OpenIdConnectProviderRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiManagementOpenIdConnectProviderOpenIdConnectProviderApiVersion);
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
        public virtual async Task<ArmOperation<ApiManagementOpenIdConnectProviderResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string openId, ApiManagementOpenIdConnectProviderData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(openId, nameof(openId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _apiManagementOpenIdConnectProviderOpenIdConnectProviderClientDiagnostics.CreateScope("ApiManagementOpenIdConnectProviderCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _apiManagementOpenIdConnectProviderOpenIdConnectProviderRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, openId, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<ApiManagementOpenIdConnectProviderResource>(Response.FromValue(new ApiManagementOpenIdConnectProviderResource(Client, response), response.GetRawResponse()));
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
        public virtual ArmOperation<ApiManagementOpenIdConnectProviderResource> CreateOrUpdate(WaitUntil waitUntil, string openId, ApiManagementOpenIdConnectProviderData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(openId, nameof(openId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _apiManagementOpenIdConnectProviderOpenIdConnectProviderClientDiagnostics.CreateScope("ApiManagementOpenIdConnectProviderCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _apiManagementOpenIdConnectProviderOpenIdConnectProviderRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, openId, data, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation<ApiManagementOpenIdConnectProviderResource>(Response.FromValue(new ApiManagementOpenIdConnectProviderResource(Client, response), response.GetRawResponse()));
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
        public virtual async Task<Response<ApiManagementOpenIdConnectProviderResource>> GetAsync(string openId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(openId, nameof(openId));

            using var scope = _apiManagementOpenIdConnectProviderOpenIdConnectProviderClientDiagnostics.CreateScope("ApiManagementOpenIdConnectProviderCollection.Get");
            scope.Start();
            try
            {
                var response = await _apiManagementOpenIdConnectProviderOpenIdConnectProviderRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, openId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementOpenIdConnectProviderResource(Client, response.Value), response.GetRawResponse());
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
        public virtual Response<ApiManagementOpenIdConnectProviderResource> Get(string openId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(openId, nameof(openId));

            using var scope = _apiManagementOpenIdConnectProviderOpenIdConnectProviderClientDiagnostics.CreateScope("ApiManagementOpenIdConnectProviderCollection.Get");
            scope.Start();
            try
            {
                var response = _apiManagementOpenIdConnectProviderOpenIdConnectProviderRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, openId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementOpenIdConnectProviderResource(Client, response.Value), response.GetRawResponse());
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
        /// <returns> An async collection of <see cref="ApiManagementOpenIdConnectProviderResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApiManagementOpenIdConnectProviderResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ApiManagementOpenIdConnectProviderResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _apiManagementOpenIdConnectProviderOpenIdConnectProviderClientDiagnostics.CreateScope("ApiManagementOpenIdConnectProviderCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _apiManagementOpenIdConnectProviderOpenIdConnectProviderRestClient.ListByServiceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ApiManagementOpenIdConnectProviderResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ApiManagementOpenIdConnectProviderResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _apiManagementOpenIdConnectProviderOpenIdConnectProviderClientDiagnostics.CreateScope("ApiManagementOpenIdConnectProviderCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _apiManagementOpenIdConnectProviderOpenIdConnectProviderRestClient.ListByServiceNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ApiManagementOpenIdConnectProviderResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// <returns> A collection of <see cref="ApiManagementOpenIdConnectProviderResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApiManagementOpenIdConnectProviderResource> GetAll(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            Page<ApiManagementOpenIdConnectProviderResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _apiManagementOpenIdConnectProviderOpenIdConnectProviderClientDiagnostics.CreateScope("ApiManagementOpenIdConnectProviderCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _apiManagementOpenIdConnectProviderOpenIdConnectProviderRestClient.ListByService(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ApiManagementOpenIdConnectProviderResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ApiManagementOpenIdConnectProviderResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _apiManagementOpenIdConnectProviderOpenIdConnectProviderClientDiagnostics.CreateScope("ApiManagementOpenIdConnectProviderCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _apiManagementOpenIdConnectProviderOpenIdConnectProviderRestClient.ListByServiceNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ApiManagementOpenIdConnectProviderResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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

            using var scope = _apiManagementOpenIdConnectProviderOpenIdConnectProviderClientDiagnostics.CreateScope("ApiManagementOpenIdConnectProviderCollection.Exists");
            scope.Start();
            try
            {
                var response = await _apiManagementOpenIdConnectProviderOpenIdConnectProviderRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, openId, cancellationToken: cancellationToken).ConfigureAwait(false);
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

            using var scope = _apiManagementOpenIdConnectProviderOpenIdConnectProviderClientDiagnostics.CreateScope("ApiManagementOpenIdConnectProviderCollection.Exists");
            scope.Start();
            try
            {
                var response = _apiManagementOpenIdConnectProviderOpenIdConnectProviderRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, openId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ApiManagementOpenIdConnectProviderResource> IEnumerable<ApiManagementOpenIdConnectProviderResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ApiManagementOpenIdConnectProviderResource> IAsyncEnumerable<ApiManagementOpenIdConnectProviderResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
