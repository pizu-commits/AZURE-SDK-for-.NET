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
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ElasticSan
{
    /// <summary>
    /// A class representing a collection of <see cref="ElasticSanResource" /> and their operations.
    /// Each <see cref="ElasticSanResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get an <see cref="ElasticSanCollection" /> instance call the GetElasticSans method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class ElasticSanCollection : ArmCollection, IEnumerable<ElasticSanResource>, IAsyncEnumerable<ElasticSanResource>
    {
        private readonly ClientDiagnostics _elasticSanClientDiagnostics;
        private readonly ElasticSansRestOperations _elasticSanRestClient;

        /// <summary> Initializes a new instance of the <see cref="ElasticSanCollection"/> class for mocking. </summary>
        protected ElasticSanCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ElasticSanCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ElasticSanCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _elasticSanClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ElasticSan", ElasticSanResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ElasticSanResource.ResourceType, out string elasticSanApiVersion);
            _elasticSanRestClient = new ElasticSansRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, elasticSanApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create ElasticSan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ElasticSans_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="elasticSanName"> The name of the ElasticSan. </param>
        /// <param name="data"> Elastic San object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="elasticSanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="elasticSanName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ElasticSanResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string elasticSanName, ElasticSanData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(elasticSanName, nameof(elasticSanName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _elasticSanClientDiagnostics.CreateScope("ElasticSanCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _elasticSanRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, elasticSanName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ElasticSanArmOperation<ElasticSanResource>(new ElasticSanOperationSource(Client), _elasticSanClientDiagnostics, Pipeline, _elasticSanRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, elasticSanName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create ElasticSan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ElasticSans_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="elasticSanName"> The name of the ElasticSan. </param>
        /// <param name="data"> Elastic San object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="elasticSanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="elasticSanName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ElasticSanResource> CreateOrUpdate(WaitUntil waitUntil, string elasticSanName, ElasticSanData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(elasticSanName, nameof(elasticSanName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _elasticSanClientDiagnostics.CreateScope("ElasticSanCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _elasticSanRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, elasticSanName, data, cancellationToken);
                var operation = new ElasticSanArmOperation<ElasticSanResource>(new ElasticSanOperationSource(Client), _elasticSanClientDiagnostics, Pipeline, _elasticSanRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, elasticSanName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get a ElasticSan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ElasticSans_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="elasticSanName"> The name of the ElasticSan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="elasticSanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="elasticSanName"/> is null. </exception>
        public virtual async Task<Response<ElasticSanResource>> GetAsync(string elasticSanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(elasticSanName, nameof(elasticSanName));

            using var scope = _elasticSanClientDiagnostics.CreateScope("ElasticSanCollection.Get");
            scope.Start();
            try
            {
                var response = await _elasticSanRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, elasticSanName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ElasticSanResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a ElasticSan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ElasticSans_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="elasticSanName"> The name of the ElasticSan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="elasticSanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="elasticSanName"/> is null. </exception>
        public virtual Response<ElasticSanResource> Get(string elasticSanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(elasticSanName, nameof(elasticSanName));

            using var scope = _elasticSanClientDiagnostics.CreateScope("ElasticSanCollection.Get");
            scope.Start();
            try
            {
                var response = _elasticSanRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, elasticSanName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ElasticSanResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of ElasticSan in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ElasticSans_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ElasticSanResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ElasticSanResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _elasticSanRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _elasticSanRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ElasticSanResource(Client, ElasticSanData.DeserializeElasticSanData(e)), _elasticSanClientDiagnostics, Pipeline, "ElasticSanCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of ElasticSan in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ElasticSans_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ElasticSanResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ElasticSanResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _elasticSanRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _elasticSanRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ElasticSanResource(Client, ElasticSanData.DeserializeElasticSanData(e)), _elasticSanClientDiagnostics, Pipeline, "ElasticSanCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ElasticSans_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="elasticSanName"> The name of the ElasticSan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="elasticSanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="elasticSanName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string elasticSanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(elasticSanName, nameof(elasticSanName));

            using var scope = _elasticSanClientDiagnostics.CreateScope("ElasticSanCollection.Exists");
            scope.Start();
            try
            {
                var response = await _elasticSanRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, elasticSanName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ElasticSans_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="elasticSanName"> The name of the ElasticSan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="elasticSanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="elasticSanName"/> is null. </exception>
        public virtual Response<bool> Exists(string elasticSanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(elasticSanName, nameof(elasticSanName));

            using var scope = _elasticSanClientDiagnostics.CreateScope("ElasticSanCollection.Exists");
            scope.Start();
            try
            {
                var response = _elasticSanRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, elasticSanName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ElasticSanResource> IEnumerable<ElasticSanResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ElasticSanResource> IAsyncEnumerable<ElasticSanResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
