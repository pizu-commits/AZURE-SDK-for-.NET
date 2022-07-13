// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A Class representing a CosmosTableThroughputSetting along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="CosmosTableThroughputSettingResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetCosmosTableThroughputSettingResource method.
    /// Otherwise you can get one from its parent resource <see cref="CosmosDBTableResource" /> using the GetCosmosTableThroughputSetting method.
    /// </summary>
    public partial class CosmosTableThroughputSettingResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="CosmosTableThroughputSettingResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string accountName, string tableName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/tables/{tableName}/throughputSettings/default";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _cosmosTableThroughputSettingTableResourcesClientDiagnostics;
        private readonly TableResourcesRestOperations _cosmosTableThroughputSettingTableResourcesRestClient;
        private readonly ThroughputSettingsData _data;

        /// <summary> Initializes a new instance of the <see cref="CosmosTableThroughputSettingResource"/> class for mocking. </summary>
        protected CosmosTableThroughputSettingResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "CosmosTableThroughputSettingResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal CosmosTableThroughputSettingResource(ArmClient client, ThroughputSettingsData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="CosmosTableThroughputSettingResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal CosmosTableThroughputSettingResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cosmosTableThroughputSettingTableResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string cosmosTableThroughputSettingTableResourcesApiVersion);
            _cosmosTableThroughputSettingTableResourcesRestClient = new TableResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cosmosTableThroughputSettingTableResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DocumentDB/databaseAccounts/tables/throughputSettings";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ThroughputSettingsData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the RUs per second of the Table under an existing Azure Cosmos DB database account with the provided name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/tables/{tableName}/throughputSettings/default
        /// Operation Id: TableResources_GetTableThroughput
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CosmosTableThroughputSettingResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _cosmosTableThroughputSettingTableResourcesClientDiagnostics.CreateScope("CosmosTableThroughputSettingResource.Get");
            scope.Start();
            try
            {
                var response = await _cosmosTableThroughputSettingTableResourcesRestClient.GetTableThroughputAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosTableThroughputSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the RUs per second of the Table under an existing Azure Cosmos DB database account with the provided name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/tables/{tableName}/throughputSettings/default
        /// Operation Id: TableResources_GetTableThroughput
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CosmosTableThroughputSettingResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _cosmosTableThroughputSettingTableResourcesClientDiagnostics.CreateScope("CosmosTableThroughputSettingResource.Get");
            scope.Start();
            try
            {
                var response = _cosmosTableThroughputSettingTableResourcesRestClient.GetTableThroughput(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosTableThroughputSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update RUs per second of an Azure Cosmos DB Table
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/tables/{tableName}/throughputSettings/default
        /// Operation Id: TableResources_UpdateTableThroughput
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The parameters to provide for the RUs per second of the current Table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<CosmosTableThroughputSettingResource>> CreateOrUpdateAsync(WaitUntil waitUntil, ThroughputSettingsUpdateData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _cosmosTableThroughputSettingTableResourcesClientDiagnostics.CreateScope("CosmosTableThroughputSettingResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _cosmosTableThroughputSettingTableResourcesRestClient.UpdateTableThroughputAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<CosmosTableThroughputSettingResource>(new CosmosTableThroughputSettingOperationSource(Client), _cosmosTableThroughputSettingTableResourcesClientDiagnostics, Pipeline, _cosmosTableThroughputSettingTableResourcesRestClient.CreateUpdateTableThroughputRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Update RUs per second of an Azure Cosmos DB Table
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/tables/{tableName}/throughputSettings/default
        /// Operation Id: TableResources_UpdateTableThroughput
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The parameters to provide for the RUs per second of the current Table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<CosmosTableThroughputSettingResource> CreateOrUpdate(WaitUntil waitUntil, ThroughputSettingsUpdateData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _cosmosTableThroughputSettingTableResourcesClientDiagnostics.CreateScope("CosmosTableThroughputSettingResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _cosmosTableThroughputSettingTableResourcesRestClient.UpdateTableThroughput(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, data, cancellationToken);
                var operation = new CosmosDBArmOperation<CosmosTableThroughputSettingResource>(new CosmosTableThroughputSettingOperationSource(Client), _cosmosTableThroughputSettingTableResourcesClientDiagnostics, Pipeline, _cosmosTableThroughputSettingTableResourcesRestClient.CreateUpdateTableThroughputRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Migrate an Azure Cosmos DB Table from manual throughput to autoscale
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/tables/{tableName}/throughputSettings/default/migrateToAutoscale
        /// Operation Id: TableResources_MigrateTableToAutoscale
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation<CosmosTableThroughputSettingResource>> MigrateTableToAutoscaleAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _cosmosTableThroughputSettingTableResourcesClientDiagnostics.CreateScope("CosmosTableThroughputSettingResource.MigrateTableToAutoscale");
            scope.Start();
            try
            {
                var response = await _cosmosTableThroughputSettingTableResourcesRestClient.MigrateTableToAutoscaleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<CosmosTableThroughputSettingResource>(new CosmosTableThroughputSettingOperationSource(Client), _cosmosTableThroughputSettingTableResourcesClientDiagnostics, Pipeline, _cosmosTableThroughputSettingTableResourcesRestClient.CreateMigrateTableToAutoscaleRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Migrate an Azure Cosmos DB Table from manual throughput to autoscale
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/tables/{tableName}/throughputSettings/default/migrateToAutoscale
        /// Operation Id: TableResources_MigrateTableToAutoscale
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<CosmosTableThroughputSettingResource> MigrateTableToAutoscale(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _cosmosTableThroughputSettingTableResourcesClientDiagnostics.CreateScope("CosmosTableThroughputSettingResource.MigrateTableToAutoscale");
            scope.Start();
            try
            {
                var response = _cosmosTableThroughputSettingTableResourcesRestClient.MigrateTableToAutoscale(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                var operation = new CosmosDBArmOperation<CosmosTableThroughputSettingResource>(new CosmosTableThroughputSettingOperationSource(Client), _cosmosTableThroughputSettingTableResourcesClientDiagnostics, Pipeline, _cosmosTableThroughputSettingTableResourcesRestClient.CreateMigrateTableToAutoscaleRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Migrate an Azure Cosmos DB Table from autoscale to manual throughput
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/tables/{tableName}/throughputSettings/default/migrateToManualThroughput
        /// Operation Id: TableResources_MigrateTableToManualThroughput
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation<CosmosTableThroughputSettingResource>> MigrateTableToManualThroughputAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _cosmosTableThroughputSettingTableResourcesClientDiagnostics.CreateScope("CosmosTableThroughputSettingResource.MigrateTableToManualThroughput");
            scope.Start();
            try
            {
                var response = await _cosmosTableThroughputSettingTableResourcesRestClient.MigrateTableToManualThroughputAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<CosmosTableThroughputSettingResource>(new CosmosTableThroughputSettingOperationSource(Client), _cosmosTableThroughputSettingTableResourcesClientDiagnostics, Pipeline, _cosmosTableThroughputSettingTableResourcesRestClient.CreateMigrateTableToManualThroughputRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Migrate an Azure Cosmos DB Table from autoscale to manual throughput
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/tables/{tableName}/throughputSettings/default/migrateToManualThroughput
        /// Operation Id: TableResources_MigrateTableToManualThroughput
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<CosmosTableThroughputSettingResource> MigrateTableToManualThroughput(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _cosmosTableThroughputSettingTableResourcesClientDiagnostics.CreateScope("CosmosTableThroughputSettingResource.MigrateTableToManualThroughput");
            scope.Start();
            try
            {
                var response = _cosmosTableThroughputSettingTableResourcesRestClient.MigrateTableToManualThroughput(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                var operation = new CosmosDBArmOperation<CosmosTableThroughputSettingResource>(new CosmosTableThroughputSettingOperationSource(Client), _cosmosTableThroughputSettingTableResourcesClientDiagnostics, Pipeline, _cosmosTableThroughputSettingTableResourcesRestClient.CreateMigrateTableToManualThroughputRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/tables/{tableName}/throughputSettings/default
        /// Operation Id: TableResources_GetTableThroughput
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual async Task<Response<CosmosTableThroughputSettingResource>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _cosmosTableThroughputSettingTableResourcesClientDiagnostics.CreateScope("CosmosTableThroughputSettingResource.AddTag");
            scope.Start();
            try
            {
                var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues[key] = value;
                await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _cosmosTableThroughputSettingTableResourcesRestClient.GetTableThroughputAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new CosmosTableThroughputSettingResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/tables/{tableName}/throughputSettings/default
        /// Operation Id: TableResources_GetTableThroughput
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<CosmosTableThroughputSettingResource> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _cosmosTableThroughputSettingTableResourcesClientDiagnostics.CreateScope("CosmosTableThroughputSettingResource.AddTag");
            scope.Start();
            try
            {
                var originalTags = GetTagResource().Get(cancellationToken);
                originalTags.Value.Data.TagValues[key] = value;
                GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _cosmosTableThroughputSettingTableResourcesRestClient.GetTableThroughput(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                return Response.FromValue(new CosmosTableThroughputSettingResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/tables/{tableName}/throughputSettings/default
        /// Operation Id: TableResources_GetTableThroughput
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual async Task<Response<CosmosTableThroughputSettingResource>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _cosmosTableThroughputSettingTableResourcesClientDiagnostics.CreateScope("CosmosTableThroughputSettingResource.SetTags");
            scope.Start();
            try
            {
                await GetTagResource().DeleteAsync(WaitUntil.Completed, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues.ReplaceWith(tags);
                await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _cosmosTableThroughputSettingTableResourcesRestClient.GetTableThroughputAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new CosmosTableThroughputSettingResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/tables/{tableName}/throughputSettings/default
        /// Operation Id: TableResources_GetTableThroughput
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<CosmosTableThroughputSettingResource> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _cosmosTableThroughputSettingTableResourcesClientDiagnostics.CreateScope("CosmosTableThroughputSettingResource.SetTags");
            scope.Start();
            try
            {
                GetTagResource().Delete(WaitUntil.Completed, cancellationToken: cancellationToken);
                var originalTags = GetTagResource().Get(cancellationToken);
                originalTags.Value.Data.TagValues.ReplaceWith(tags);
                GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _cosmosTableThroughputSettingTableResourcesRestClient.GetTableThroughput(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                return Response.FromValue(new CosmosTableThroughputSettingResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/tables/{tableName}/throughputSettings/default
        /// Operation Id: TableResources_GetTableThroughput
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual async Task<Response<CosmosTableThroughputSettingResource>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _cosmosTableThroughputSettingTableResourcesClientDiagnostics.CreateScope("CosmosTableThroughputSettingResource.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues.Remove(key);
                await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _cosmosTableThroughputSettingTableResourcesRestClient.GetTableThroughputAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new CosmosTableThroughputSettingResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/tables/{tableName}/throughputSettings/default
        /// Operation Id: TableResources_GetTableThroughput
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<CosmosTableThroughputSettingResource> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _cosmosTableThroughputSettingTableResourcesClientDiagnostics.CreateScope("CosmosTableThroughputSettingResource.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = GetTagResource().Get(cancellationToken);
                originalTags.Value.Data.TagValues.Remove(key);
                GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _cosmosTableThroughputSettingTableResourcesRestClient.GetTableThroughput(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                return Response.FromValue(new CosmosTableThroughputSettingResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
