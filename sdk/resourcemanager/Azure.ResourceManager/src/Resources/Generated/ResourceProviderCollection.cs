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

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class representing collection of ResourceProvider and their operations over its parent. </summary>
    public partial class ResourceProviderCollection : ArmCollection, IEnumerable<ResourceProviderResource>, IAsyncEnumerable<ResourceProviderResource>
    {
        private readonly ClientDiagnostics _resourceProviderProvidersClientDiagnostics;
        private readonly ProvidersRestOperations _resourceProviderProvidersRestClient;

        /// <summary> Initializes a new instance of the <see cref="ResourceProviderCollection"/> class for mocking. </summary>
        protected ResourceProviderCollection()
        {
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the specified resource provider.
        /// Request Path: /subscriptions/{subscriptionId}/providers/{resourceProviderNamespace}
        /// Operation Id: Providers_Get
        /// </summary>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider. </param>
        /// <param name="expand"> The $expand query parameter. For example, to include property aliases in response, use $expand=resourceTypes/aliases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceProviderNamespace"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceProviderNamespace"/> is null. </exception>
        public virtual async Task<Response<ResourceProviderResource>> GetAsync(string resourceProviderNamespace, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceProviderNamespace, nameof(resourceProviderNamespace));

            using var scope = _resourceProviderProvidersClientDiagnostics.CreateScope("ResourceProviderCollection.Get");
            scope.Start();
            try
            {
                var response = await _resourceProviderProvidersRestClient.GetAsync(Id.SubscriptionId, resourceProviderNamespace, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceProviderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified resource provider.
        /// Request Path: /subscriptions/{subscriptionId}/providers/{resourceProviderNamespace}
        /// Operation Id: Providers_Get
        /// </summary>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider. </param>
        /// <param name="expand"> The $expand query parameter. For example, to include property aliases in response, use $expand=resourceTypes/aliases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceProviderNamespace"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceProviderNamespace"/> is null. </exception>
        public virtual Response<ResourceProviderResource> Get(string resourceProviderNamespace, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceProviderNamespace, nameof(resourceProviderNamespace));

            using var scope = _resourceProviderProvidersClientDiagnostics.CreateScope("ResourceProviderCollection.Get");
            scope.Start();
            try
            {
                var response = _resourceProviderProvidersRestClient.Get(Id.SubscriptionId, resourceProviderNamespace, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceProviderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all resource providers for a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers
        /// Operation Id: Providers_List
        /// </summary>
        /// <param name="top"> The number of results to return. If null is passed returns all deployments. </param>
        /// <param name="expand"> The properties to include in the results. For example, use &amp;$expand=metadata in the query string to retrieve resource provider metadata. To include property aliases in response, use $expand=resourceTypes/aliases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourceProviderResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourceProviderResource> GetAllAsync(int? top = null, string expand = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ResourceProviderResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _resourceProviderProvidersClientDiagnostics.CreateScope("ResourceProviderCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _resourceProviderProvidersRestClient.ListAsync(Id.SubscriptionId, top, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourceProviderResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ResourceProviderResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _resourceProviderProvidersClientDiagnostics.CreateScope("ResourceProviderCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _resourceProviderProvidersRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, top, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourceProviderResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets all resource providers for a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers
        /// Operation Id: Providers_List
        /// </summary>
        /// <param name="top"> The number of results to return. If null is passed returns all deployments. </param>
        /// <param name="expand"> The properties to include in the results. For example, use &amp;$expand=metadata in the query string to retrieve resource provider metadata. To include property aliases in response, use $expand=resourceTypes/aliases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourceProviderResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourceProviderResource> GetAll(int? top = null, string expand = null, CancellationToken cancellationToken = default)
        {
            Page<ResourceProviderResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _resourceProviderProvidersClientDiagnostics.CreateScope("ResourceProviderCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _resourceProviderProvidersRestClient.List(Id.SubscriptionId, top, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourceProviderResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ResourceProviderResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _resourceProviderProvidersClientDiagnostics.CreateScope("ResourceProviderCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _resourceProviderProvidersRestClient.ListNextPage(nextLink, Id.SubscriptionId, top, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourceProviderResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/providers/{resourceProviderNamespace}
        /// Operation Id: Providers_Get
        /// </summary>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider. </param>
        /// <param name="expand"> The $expand query parameter. For example, to include property aliases in response, use $expand=resourceTypes/aliases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceProviderNamespace"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceProviderNamespace"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string resourceProviderNamespace, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceProviderNamespace, nameof(resourceProviderNamespace));

            using var scope = _resourceProviderProvidersClientDiagnostics.CreateScope("ResourceProviderCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(resourceProviderNamespace, expand: expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/providers/{resourceProviderNamespace}
        /// Operation Id: Providers_Get
        /// </summary>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider. </param>
        /// <param name="expand"> The $expand query parameter. For example, to include property aliases in response, use $expand=resourceTypes/aliases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceProviderNamespace"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceProviderNamespace"/> is null. </exception>
        public virtual Response<bool> Exists(string resourceProviderNamespace, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceProviderNamespace, nameof(resourceProviderNamespace));

            using var scope = _resourceProviderProvidersClientDiagnostics.CreateScope("ResourceProviderCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(resourceProviderNamespace, expand: expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/providers/{resourceProviderNamespace}
        /// Operation Id: Providers_Get
        /// </summary>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider. </param>
        /// <param name="expand"> The $expand query parameter. For example, to include property aliases in response, use $expand=resourceTypes/aliases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceProviderNamespace"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceProviderNamespace"/> is null. </exception>
        public virtual async Task<Response<ResourceProviderResource>> GetIfExistsAsync(string resourceProviderNamespace, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceProviderNamespace, nameof(resourceProviderNamespace));

            using var scope = _resourceProviderProvidersClientDiagnostics.CreateScope("ResourceProviderCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _resourceProviderProvidersRestClient.GetAsync(Id.SubscriptionId, resourceProviderNamespace, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ResourceProviderResource>(null, response.GetRawResponse());
                return Response.FromValue(new ResourceProviderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/providers/{resourceProviderNamespace}
        /// Operation Id: Providers_Get
        /// </summary>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider. </param>
        /// <param name="expand"> The $expand query parameter. For example, to include property aliases in response, use $expand=resourceTypes/aliases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceProviderNamespace"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceProviderNamespace"/> is null. </exception>
        public virtual Response<ResourceProviderResource> GetIfExists(string resourceProviderNamespace, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceProviderNamespace, nameof(resourceProviderNamespace));

            using var scope = _resourceProviderProvidersClientDiagnostics.CreateScope("ResourceProviderCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _resourceProviderProvidersRestClient.Get(Id.SubscriptionId, resourceProviderNamespace, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ResourceProviderResource>(null, response.GetRawResponse());
                return Response.FromValue(new ResourceProviderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ResourceProviderResource> IEnumerable<ResourceProviderResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ResourceProviderResource> IAsyncEnumerable<ResourceProviderResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
