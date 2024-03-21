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
using Azure.ResourceManager.CosmosDB.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A class representing a collection of <see cref="CosmosDBAccountResource"/> and their operations.
    /// Each <see cref="CosmosDBAccountResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="CosmosDBAccountCollection"/> instance call the GetCosmosDBAccounts method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class CosmosDBAccountCollection : ArmCollection, IEnumerable<CosmosDBAccountResource>, IAsyncEnumerable<CosmosDBAccountResource>
    {
        private readonly ClientDiagnostics _cosmosDBAccountDatabaseAccountsClientDiagnostics;
        private readonly DatabaseAccountsRestOperations _cosmosDBAccountDatabaseAccountsRestClient;

        /// <summary> Initializes a new instance of the <see cref="CosmosDBAccountCollection"/> class for mocking. </summary>
        protected CosmosDBAccountCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CosmosDBAccountCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CosmosDBAccountCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cosmosDBAccountDatabaseAccountsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", CosmosDBAccountResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CosmosDBAccountResource.ResourceType, out string cosmosDBAccountDatabaseAccountsApiVersion);
            _cosmosDBAccountDatabaseAccountsRestClient = new DatabaseAccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cosmosDBAccountDatabaseAccountsApiVersion);
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
        /// Creates or updates an Azure Cosmos DB database account. The "Update" method is preferred when performing updates on an account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseAccounts_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="accountName"> Cosmos DB database account name. </param>
        /// <param name="content"> The parameters to provide for the current database account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<CosmosDBAccountResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string accountName, CosmosDBAccountCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _cosmosDBAccountDatabaseAccountsClientDiagnostics.CreateScope("CosmosDBAccountCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _cosmosDBAccountDatabaseAccountsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, accountName, content, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<CosmosDBAccountResource>(new CosmosDBAccountOperationSource(Client), _cosmosDBAccountDatabaseAccountsClientDiagnostics, Pipeline, _cosmosDBAccountDatabaseAccountsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, accountName, content).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates an Azure Cosmos DB database account. The "Update" method is preferred when performing updates on an account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseAccounts_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="accountName"> Cosmos DB database account name. </param>
        /// <param name="content"> The parameters to provide for the current database account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<CosmosDBAccountResource> CreateOrUpdate(WaitUntil waitUntil, string accountName, CosmosDBAccountCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _cosmosDBAccountDatabaseAccountsClientDiagnostics.CreateScope("CosmosDBAccountCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _cosmosDBAccountDatabaseAccountsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, accountName, content, cancellationToken);
                var operation = new CosmosDBArmOperation<CosmosDBAccountResource>(new CosmosDBAccountOperationSource(Client), _cosmosDBAccountDatabaseAccountsClientDiagnostics, Pipeline, _cosmosDBAccountDatabaseAccountsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, accountName, content).Request, response, OperationFinalStateVia.Location);
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
        /// Retrieves the properties of an existing Azure Cosmos DB database account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseAccounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> Cosmos DB database account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual async Task<Response<CosmosDBAccountResource>> GetAsync(string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _cosmosDBAccountDatabaseAccountsClientDiagnostics.CreateScope("CosmosDBAccountCollection.Get");
            scope.Start();
            try
            {
                var response = await _cosmosDBAccountDatabaseAccountsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the properties of an existing Azure Cosmos DB database account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseAccounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> Cosmos DB database account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual Response<CosmosDBAccountResource> Get(string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _cosmosDBAccountDatabaseAccountsClientDiagnostics.CreateScope("CosmosDBAccountCollection.Get");
            scope.Start();
            try
            {
                var response = _cosmosDBAccountDatabaseAccountsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the Azure Cosmos DB database accounts available under the given resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseAccounts_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CosmosDBAccountResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CosmosDBAccountResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cosmosDBAccountDatabaseAccountsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new CosmosDBAccountResource(Client, CosmosDBAccountData.DeserializeCosmosDBAccountData(e)), _cosmosDBAccountDatabaseAccountsClientDiagnostics, Pipeline, "CosmosDBAccountCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists all the Azure Cosmos DB database accounts available under the given resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseAccounts_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CosmosDBAccountResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CosmosDBAccountResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cosmosDBAccountDatabaseAccountsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new CosmosDBAccountResource(Client, CosmosDBAccountData.DeserializeCosmosDBAccountData(e)), _cosmosDBAccountDatabaseAccountsClientDiagnostics, Pipeline, "CosmosDBAccountCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseAccounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> Cosmos DB database account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _cosmosDBAccountDatabaseAccountsClientDiagnostics.CreateScope("CosmosDBAccountCollection.Exists");
            scope.Start();
            try
            {
                var response = await _cosmosDBAccountDatabaseAccountsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseAccounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> Cosmos DB database account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual Response<bool> Exists(string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _cosmosDBAccountDatabaseAccountsClientDiagnostics.CreateScope("CosmosDBAccountCollection.Exists");
            scope.Start();
            try
            {
                var response = _cosmosDBAccountDatabaseAccountsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseAccounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> Cosmos DB database account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual async Task<NullableResponse<CosmosDBAccountResource>> GetIfExistsAsync(string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _cosmosDBAccountDatabaseAccountsClientDiagnostics.CreateScope("CosmosDBAccountCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _cosmosDBAccountDatabaseAccountsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<CosmosDBAccountResource>(response.GetRawResponse());
                return Response.FromValue(new CosmosDBAccountResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseAccounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> Cosmos DB database account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual NullableResponse<CosmosDBAccountResource> GetIfExists(string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _cosmosDBAccountDatabaseAccountsClientDiagnostics.CreateScope("CosmosDBAccountCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _cosmosDBAccountDatabaseAccountsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<CosmosDBAccountResource>(response.GetRawResponse());
                return Response.FromValue(new CosmosDBAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CosmosDBAccountResource> IEnumerable<CosmosDBAccountResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CosmosDBAccountResource> IAsyncEnumerable<CosmosDBAccountResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
