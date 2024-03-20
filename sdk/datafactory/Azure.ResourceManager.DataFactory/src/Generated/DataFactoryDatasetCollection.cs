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
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.DataFactory
{
    /// <summary>
    /// A class representing a collection of <see cref="DataFactoryDatasetResource"/> and their operations.
    /// Each <see cref="DataFactoryDatasetResource"/> in the collection will belong to the same instance of <see cref="DataFactoryResource"/>.
    /// To get a <see cref="DataFactoryDatasetCollection"/> instance call the GetDataFactoryDatasets method from an instance of <see cref="DataFactoryResource"/>.
    /// </summary>
    public partial class DataFactoryDatasetCollection : ArmCollection, IEnumerable<DataFactoryDatasetResource>, IAsyncEnumerable<DataFactoryDatasetResource>
    {
        private readonly ClientDiagnostics _dataFactoryDatasetDatasetsClientDiagnostics;
        private readonly DatasetsRestOperations _dataFactoryDatasetDatasetsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataFactoryDatasetCollection"/> class for mocking. </summary>
        protected DataFactoryDatasetCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataFactoryDatasetCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataFactoryDatasetCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataFactoryDatasetDatasetsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataFactory", DataFactoryDatasetResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataFactoryDatasetResource.ResourceType, out string dataFactoryDatasetDatasetsApiVersion);
            _dataFactoryDatasetDatasetsRestClient = new DatasetsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataFactoryDatasetDatasetsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DataFactoryResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DataFactoryResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a dataset.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/datasets/{datasetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Datasets_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataFactoryDatasetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="datasetName"> The dataset name. </param>
        /// <param name="data"> Dataset resource definition. </param>
        /// <param name="ifMatch"> ETag of the dataset entity.  Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="datasetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="datasetName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DataFactoryDatasetResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string datasetName, DataFactoryDatasetData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(datasetName, nameof(datasetName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataFactoryDatasetDatasetsClientDiagnostics.CreateScope("DataFactoryDatasetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dataFactoryDatasetDatasetsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, datasetName, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new DataFactoryArmOperation<DataFactoryDatasetResource>(Response.FromValue(new DataFactoryDatasetResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates a dataset.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/datasets/{datasetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Datasets_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataFactoryDatasetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="datasetName"> The dataset name. </param>
        /// <param name="data"> Dataset resource definition. </param>
        /// <param name="ifMatch"> ETag of the dataset entity.  Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="datasetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="datasetName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DataFactoryDatasetResource> CreateOrUpdate(WaitUntil waitUntil, string datasetName, DataFactoryDatasetData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(datasetName, nameof(datasetName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataFactoryDatasetDatasetsClientDiagnostics.CreateScope("DataFactoryDatasetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dataFactoryDatasetDatasetsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, datasetName, data, ifMatch, cancellationToken);
                var operation = new DataFactoryArmOperation<DataFactoryDatasetResource>(Response.FromValue(new DataFactoryDatasetResource(Client, response), response.GetRawResponse()));
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
        /// Gets a dataset.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/datasets/{datasetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Datasets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataFactoryDatasetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="datasetName"> The dataset name. </param>
        /// <param name="ifNoneMatch"> ETag of the dataset entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="datasetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="datasetName"/> is null. </exception>
        public virtual async Task<Response<DataFactoryDatasetResource>> GetAsync(string datasetName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(datasetName, nameof(datasetName));

            using var scope = _dataFactoryDatasetDatasetsClientDiagnostics.CreateScope("DataFactoryDatasetCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataFactoryDatasetDatasetsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, datasetName, ifNoneMatch, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataFactoryDatasetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a dataset.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/datasets/{datasetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Datasets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataFactoryDatasetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="datasetName"> The dataset name. </param>
        /// <param name="ifNoneMatch"> ETag of the dataset entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="datasetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="datasetName"/> is null. </exception>
        public virtual Response<DataFactoryDatasetResource> Get(string datasetName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(datasetName, nameof(datasetName));

            using var scope = _dataFactoryDatasetDatasetsClientDiagnostics.CreateScope("DataFactoryDatasetCollection.Get");
            scope.Start();
            try
            {
                var response = _dataFactoryDatasetDatasetsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, datasetName, ifNoneMatch, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataFactoryDatasetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists datasets.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/datasets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Datasets_ListByFactory</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataFactoryDatasetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataFactoryDatasetResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataFactoryDatasetResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataFactoryDatasetDatasetsRestClient.CreateListByFactoryRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataFactoryDatasetDatasetsRestClient.CreateListByFactoryNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DataFactoryDatasetResource(Client, DataFactoryDatasetData.DeserializeDataFactoryDatasetData(e)), _dataFactoryDatasetDatasetsClientDiagnostics, Pipeline, "DataFactoryDatasetCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists datasets.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/datasets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Datasets_ListByFactory</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataFactoryDatasetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataFactoryDatasetResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataFactoryDatasetResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataFactoryDatasetDatasetsRestClient.CreateListByFactoryRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataFactoryDatasetDatasetsRestClient.CreateListByFactoryNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DataFactoryDatasetResource(Client, DataFactoryDatasetData.DeserializeDataFactoryDatasetData(e)), _dataFactoryDatasetDatasetsClientDiagnostics, Pipeline, "DataFactoryDatasetCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/datasets/{datasetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Datasets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataFactoryDatasetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="datasetName"> The dataset name. </param>
        /// <param name="ifNoneMatch"> ETag of the dataset entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="datasetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="datasetName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string datasetName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(datasetName, nameof(datasetName));

            using var scope = _dataFactoryDatasetDatasetsClientDiagnostics.CreateScope("DataFactoryDatasetCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataFactoryDatasetDatasetsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, datasetName, ifNoneMatch, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/datasets/{datasetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Datasets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataFactoryDatasetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="datasetName"> The dataset name. </param>
        /// <param name="ifNoneMatch"> ETag of the dataset entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="datasetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="datasetName"/> is null. </exception>
        public virtual Response<bool> Exists(string datasetName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(datasetName, nameof(datasetName));

            using var scope = _dataFactoryDatasetDatasetsClientDiagnostics.CreateScope("DataFactoryDatasetCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataFactoryDatasetDatasetsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, datasetName, ifNoneMatch, cancellationToken: cancellationToken);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/datasets/{datasetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Datasets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataFactoryDatasetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="datasetName"> The dataset name. </param>
        /// <param name="ifNoneMatch"> ETag of the dataset entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="datasetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="datasetName"/> is null. </exception>
        public virtual async Task<NullableResponse<DataFactoryDatasetResource>> GetIfExistsAsync(string datasetName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(datasetName, nameof(datasetName));

            using var scope = _dataFactoryDatasetDatasetsClientDiagnostics.CreateScope("DataFactoryDatasetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _dataFactoryDatasetDatasetsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, datasetName, ifNoneMatch, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DataFactoryDatasetResource>(response.GetRawResponse());
                return Response.FromValue(new DataFactoryDatasetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/datasets/{datasetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Datasets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataFactoryDatasetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="datasetName"> The dataset name. </param>
        /// <param name="ifNoneMatch"> ETag of the dataset entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="datasetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="datasetName"/> is null. </exception>
        public virtual NullableResponse<DataFactoryDatasetResource> GetIfExists(string datasetName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(datasetName, nameof(datasetName));

            using var scope = _dataFactoryDatasetDatasetsClientDiagnostics.CreateScope("DataFactoryDatasetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _dataFactoryDatasetDatasetsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, datasetName, ifNoneMatch, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DataFactoryDatasetResource>(response.GetRawResponse());
                return Response.FromValue(new DataFactoryDatasetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataFactoryDatasetResource> IEnumerable<DataFactoryDatasetResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataFactoryDatasetResource> IAsyncEnumerable<DataFactoryDatasetResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
