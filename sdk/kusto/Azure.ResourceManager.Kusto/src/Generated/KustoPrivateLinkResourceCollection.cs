// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Kusto
{
    /// <summary>
    /// A class representing a collection of <see cref="KustoPrivateLinkResource" /> and their operations.
    /// Each <see cref="KustoPrivateLinkResource" /> in the collection will belong to the same instance of <see cref="KustoClusterResource" />.
    /// To get a <see cref="KustoPrivateLinkResourceCollection" /> instance call the GetKustoPrivateLinkResources method from an instance of <see cref="KustoClusterResource" />.
    /// </summary>
    public partial class KustoPrivateLinkResourceCollection : ArmCollection, IEnumerable<KustoPrivateLinkResource>, IAsyncEnumerable<KustoPrivateLinkResource>
    {
        private readonly ClientDiagnostics _kustoPrivateLinkResourcePrivateLinkResourcesClientDiagnostics;
        private readonly PrivateLinkResourcesRestOperations _kustoPrivateLinkResourcePrivateLinkResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="KustoPrivateLinkResourceCollection"/> class for mocking. </summary>
        protected KustoPrivateLinkResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="KustoPrivateLinkResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal KustoPrivateLinkResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _kustoPrivateLinkResourcePrivateLinkResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Kusto", KustoPrivateLinkResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(KustoPrivateLinkResource.ResourceType, out string kustoPrivateLinkResourcePrivateLinkResourcesApiVersion);
            _kustoPrivateLinkResourcePrivateLinkResourcesRestClient = new PrivateLinkResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, kustoPrivateLinkResourcePrivateLinkResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != KustoClusterResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, KustoClusterResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a private link resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/privateLinkResources/{privateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateLinkResourceName"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateLinkResourceName"/> is null. </exception>
        public virtual async Task<Response<KustoPrivateLinkResource>> GetAsync(string privateLinkResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateLinkResourceName, nameof(privateLinkResourceName));

            using var scope = _kustoPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("KustoPrivateLinkResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _kustoPrivateLinkResourcePrivateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateLinkResourceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new KustoPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a private link resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/privateLinkResources/{privateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateLinkResourceName"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateLinkResourceName"/> is null. </exception>
        public virtual Response<KustoPrivateLinkResource> Get(string privateLinkResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateLinkResourceName, nameof(privateLinkResourceName));

            using var scope = _kustoPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("KustoPrivateLinkResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _kustoPrivateLinkResourcePrivateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateLinkResourceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new KustoPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns the list of private link resources.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/privateLinkResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="KustoPrivateLinkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<KustoPrivateLinkResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _kustoPrivateLinkResourcePrivateLinkResourcesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new KustoPrivateLinkResource(Client, KustoPrivateLinkResourceData.DeserializeKustoPrivateLinkResourceData(e)), _kustoPrivateLinkResourcePrivateLinkResourcesClientDiagnostics, Pipeline, "KustoPrivateLinkResourceCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Returns the list of private link resources.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/privateLinkResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="KustoPrivateLinkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<KustoPrivateLinkResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _kustoPrivateLinkResourcePrivateLinkResourcesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, null, e => new KustoPrivateLinkResource(Client, KustoPrivateLinkResourceData.DeserializeKustoPrivateLinkResourceData(e)), _kustoPrivateLinkResourcePrivateLinkResourcesClientDiagnostics, Pipeline, "KustoPrivateLinkResourceCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/privateLinkResources/{privateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateLinkResourceName"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateLinkResourceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string privateLinkResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateLinkResourceName, nameof(privateLinkResourceName));

            using var scope = _kustoPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("KustoPrivateLinkResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _kustoPrivateLinkResourcePrivateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateLinkResourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/privateLinkResources/{privateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateLinkResourceName"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateLinkResourceName"/> is null. </exception>
        public virtual Response<bool> Exists(string privateLinkResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateLinkResourceName, nameof(privateLinkResourceName));

            using var scope = _kustoPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("KustoPrivateLinkResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _kustoPrivateLinkResourcePrivateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateLinkResourceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<KustoPrivateLinkResource> IEnumerable<KustoPrivateLinkResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<KustoPrivateLinkResource> IAsyncEnumerable<KustoPrivateLinkResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
