// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary> A class representing collection of SqlContainer and their operations over its parent. </summary>
    public partial class SqlContainerCollection : ArmCollection, IEnumerable<SqlContainer>, IAsyncEnumerable<SqlContainer>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly SqlResourcesRestOperations _sqlResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SqlContainerCollection"/> class for mocking. </summary>
        protected SqlContainerCollection()
        {
        }

        /// <summary> Initializes a new instance of SqlContainerCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SqlContainerCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _sqlResourcesRestClient = new SqlResourcesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => SqlDatabase.ResourceType;

        // Collection level operations.

        /// <summary> Create or update an Azure Cosmos DB SQL container. </summary>
        /// <param name="containerName"> Cosmos DB container name. </param>
        /// <param name="createUpdateSqlContainerParameters"> The parameters to provide for the current SQL container. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> or <paramref name="createUpdateSqlContainerParameters"/> is null. </exception>
        public virtual SqlResourceCreateUpdateSqlContainerOperation CreateOrUpdate(string containerName, SqlContainerCreateUpdateOptions createUpdateSqlContainerParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (containerName == null)
            {
                throw new ArgumentNullException(nameof(containerName));
            }
            if (createUpdateSqlContainerParameters == null)
            {
                throw new ArgumentNullException(nameof(createUpdateSqlContainerParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SqlContainerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sqlResourcesRestClient.CreateUpdateSqlContainer(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, containerName, createUpdateSqlContainerParameters, cancellationToken);
                var operation = new SqlResourceCreateUpdateSqlContainerOperation(Parent, _clientDiagnostics, Pipeline, _sqlResourcesRestClient.CreateCreateUpdateSqlContainerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, containerName, createUpdateSqlContainerParameters).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update an Azure Cosmos DB SQL container. </summary>
        /// <param name="containerName"> Cosmos DB container name. </param>
        /// <param name="createUpdateSqlContainerParameters"> The parameters to provide for the current SQL container. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> or <paramref name="createUpdateSqlContainerParameters"/> is null. </exception>
        public async virtual Task<SqlResourceCreateUpdateSqlContainerOperation> CreateOrUpdateAsync(string containerName, SqlContainerCreateUpdateOptions createUpdateSqlContainerParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (containerName == null)
            {
                throw new ArgumentNullException(nameof(containerName));
            }
            if (createUpdateSqlContainerParameters == null)
            {
                throw new ArgumentNullException(nameof(createUpdateSqlContainerParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SqlContainerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sqlResourcesRestClient.CreateUpdateSqlContainerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, containerName, createUpdateSqlContainerParameters, cancellationToken).ConfigureAwait(false);
                var operation = new SqlResourceCreateUpdateSqlContainerOperation(Parent, _clientDiagnostics, Pipeline, _sqlResourcesRestClient.CreateCreateUpdateSqlContainerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, containerName, createUpdateSqlContainerParameters).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the SQL container under an existing Azure Cosmos DB database account. </summary>
        /// <param name="containerName"> Cosmos DB container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> is null. </exception>
        public virtual Response<SqlContainer> Get(string containerName, CancellationToken cancellationToken = default)
        {
            if (containerName == null)
            {
                throw new ArgumentNullException(nameof(containerName));
            }

            using var scope = _clientDiagnostics.CreateScope("SqlContainerCollection.Get");
            scope.Start();
            try
            {
                var response = _sqlResourcesRestClient.GetSqlContainer(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, containerName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlContainer(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the SQL container under an existing Azure Cosmos DB database account. </summary>
        /// <param name="containerName"> Cosmos DB container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> is null. </exception>
        public async virtual Task<Response<SqlContainer>> GetAsync(string containerName, CancellationToken cancellationToken = default)
        {
            if (containerName == null)
            {
                throw new ArgumentNullException(nameof(containerName));
            }

            using var scope = _clientDiagnostics.CreateScope("SqlContainerCollection.Get");
            scope.Start();
            try
            {
                var response = await _sqlResourcesRestClient.GetSqlContainerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, containerName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SqlContainer(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="containerName"> Cosmos DB container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> is null. </exception>
        public virtual Response<SqlContainer> GetIfExists(string containerName, CancellationToken cancellationToken = default)
        {
            if (containerName == null)
            {
                throw new ArgumentNullException(nameof(containerName));
            }

            using var scope = _clientDiagnostics.CreateScope("SqlContainerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _sqlResourcesRestClient.GetSqlContainer(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, containerName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<SqlContainer>(null, response.GetRawResponse())
                    : Response.FromValue(new SqlContainer(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="containerName"> Cosmos DB container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> is null. </exception>
        public async virtual Task<Response<SqlContainer>> GetIfExistsAsync(string containerName, CancellationToken cancellationToken = default)
        {
            if (containerName == null)
            {
                throw new ArgumentNullException(nameof(containerName));
            }

            using var scope = _clientDiagnostics.CreateScope("SqlContainerCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _sqlResourcesRestClient.GetSqlContainerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, containerName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<SqlContainer>(null, response.GetRawResponse())
                    : Response.FromValue(new SqlContainer(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="containerName"> Cosmos DB container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> is null. </exception>
        public virtual Response<bool> Exists(string containerName, CancellationToken cancellationToken = default)
        {
            if (containerName == null)
            {
                throw new ArgumentNullException(nameof(containerName));
            }

            using var scope = _clientDiagnostics.CreateScope("SqlContainerCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(containerName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="containerName"> Cosmos DB container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string containerName, CancellationToken cancellationToken = default)
        {
            if (containerName == null)
            {
                throw new ArgumentNullException(nameof(containerName));
            }

            using var scope = _clientDiagnostics.CreateScope("SqlContainerCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(containerName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists the SQL container under an existing Azure Cosmos DB database account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SqlContainer" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SqlContainer> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SqlContainer> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SqlContainerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sqlResourcesRestClient.ListSqlContainers(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlContainer(Parent, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> Lists the SQL container under an existing Azure Cosmos DB database account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SqlContainer" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SqlContainer> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SqlContainer>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SqlContainerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sqlResourcesRestClient.ListSqlContainersAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlContainer(Parent, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        IEnumerator<SqlContainer> IEnumerable<SqlContainer>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SqlContainer> IAsyncEnumerable<SqlContainer>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, SqlContainer, SqlContainerData> Construct() { }
    }
}
