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

namespace Azure.ResourceManager.Batch
{
    /// <summary>
    /// A class representing a collection of <see cref="BatchPrivateEndpointConnectionResource" /> and their operations.
    /// Each <see cref="BatchPrivateEndpointConnectionResource" /> in the collection will belong to the same instance of <see cref="BatchAccountResource" />.
    /// To get a <see cref="BatchPrivateEndpointConnectionCollection" /> instance call the GetBatchPrivateEndpointConnections method from an instance of <see cref="BatchAccountResource" />.
    /// </summary>
    public partial class BatchPrivateEndpointConnectionCollection : ArmCollection, IEnumerable<BatchPrivateEndpointConnectionResource>, IAsyncEnumerable<BatchPrivateEndpointConnectionResource>
    {
        private readonly ClientDiagnostics _batchPrivateEndpointConnectionPrivateEndpointConnectionClientDiagnostics;
        private readonly PrivateEndpointConnectionRestOperations _batchPrivateEndpointConnectionPrivateEndpointConnectionRestClient;

        /// <summary> Initializes a new instance of the <see cref="BatchPrivateEndpointConnectionCollection"/> class for mocking. </summary>
        protected BatchPrivateEndpointConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BatchPrivateEndpointConnectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal BatchPrivateEndpointConnectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _batchPrivateEndpointConnectionPrivateEndpointConnectionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Batch", BatchPrivateEndpointConnectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(BatchPrivateEndpointConnectionResource.ResourceType, out string batchPrivateEndpointConnectionPrivateEndpointConnectionApiVersion);
            _batchPrivateEndpointConnectionPrivateEndpointConnectionRestClient = new PrivateEndpointConnectionRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, batchPrivateEndpointConnectionPrivateEndpointConnectionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != BatchAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, BatchAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets information about the specified private endpoint connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnection_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointConnectionName"> The private endpoint connection name. This must be unique within the account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual async Task<Response<BatchPrivateEndpointConnectionResource>> GetAsync(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _batchPrivateEndpointConnectionPrivateEndpointConnectionClientDiagnostics.CreateScope("BatchPrivateEndpointConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _batchPrivateEndpointConnectionPrivateEndpointConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BatchPrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified private endpoint connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnection_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointConnectionName"> The private endpoint connection name. This must be unique within the account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual Response<BatchPrivateEndpointConnectionResource> Get(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _batchPrivateEndpointConnectionPrivateEndpointConnectionClientDiagnostics.CreateScope("BatchPrivateEndpointConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _batchPrivateEndpointConnectionPrivateEndpointConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BatchPrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all of the private endpoint connections in the specified account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/privateEndpointConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnection_ListByBatchAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="maxresults"> The maximum number of items to return in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BatchPrivateEndpointConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BatchPrivateEndpointConnectionResource> GetAllAsync(int? maxresults = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _batchPrivateEndpointConnectionPrivateEndpointConnectionRestClient.CreateListByBatchAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, maxresults);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _batchPrivateEndpointConnectionPrivateEndpointConnectionRestClient.CreateListByBatchAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, maxresults);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new BatchPrivateEndpointConnectionResource(Client, BatchPrivateEndpointConnectionData.DeserializeBatchPrivateEndpointConnectionData(e)), _batchPrivateEndpointConnectionPrivateEndpointConnectionClientDiagnostics, Pipeline, "BatchPrivateEndpointConnectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all of the private endpoint connections in the specified account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/privateEndpointConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnection_ListByBatchAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="maxresults"> The maximum number of items to return in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BatchPrivateEndpointConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BatchPrivateEndpointConnectionResource> GetAll(int? maxresults = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _batchPrivateEndpointConnectionPrivateEndpointConnectionRestClient.CreateListByBatchAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, maxresults);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _batchPrivateEndpointConnectionPrivateEndpointConnectionRestClient.CreateListByBatchAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, maxresults);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new BatchPrivateEndpointConnectionResource(Client, BatchPrivateEndpointConnectionData.DeserializeBatchPrivateEndpointConnectionData(e)), _batchPrivateEndpointConnectionPrivateEndpointConnectionClientDiagnostics, Pipeline, "BatchPrivateEndpointConnectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnection_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointConnectionName"> The private endpoint connection name. This must be unique within the account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _batchPrivateEndpointConnectionPrivateEndpointConnectionClientDiagnostics.CreateScope("BatchPrivateEndpointConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _batchPrivateEndpointConnectionPrivateEndpointConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnection_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointConnectionName"> The private endpoint connection name. This must be unique within the account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _batchPrivateEndpointConnectionPrivateEndpointConnectionClientDiagnostics.CreateScope("BatchPrivateEndpointConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = _batchPrivateEndpointConnectionPrivateEndpointConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<BatchPrivateEndpointConnectionResource> IEnumerable<BatchPrivateEndpointConnectionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<BatchPrivateEndpointConnectionResource> IAsyncEnumerable<BatchPrivateEndpointConnectionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
