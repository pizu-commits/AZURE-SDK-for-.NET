// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> The ManagedDatabaseSensitivityLabels service client. </summary>
    public partial class ManagedDatabaseSensitivityLabelsOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ManagedDatabaseSensitivityLabelsRestOperations RestClient { get; }

        /// <summary> Initializes a new instance of ManagedDatabaseSensitivityLabelsOperations for mocking. </summary>
        protected ManagedDatabaseSensitivityLabelsOperations()
        {
        }

        /// <summary> Initializes a new instance of ManagedDatabaseSensitivityLabelsOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal ManagedDatabaseSensitivityLabelsOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new ManagedDatabaseSensitivityLabelsRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets the sensitivity label of a given column. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="columnName"> The name of the column. </param>
        /// <param name="sensitivityLabelSource"> The source of the sensitivity label. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SensitivityLabel>> GetAsync(string resourceGroupName, string managedInstanceName, string databaseName, string schemaName, string tableName, string columnName, SensitivityLabelSource sensitivityLabelSource, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedDatabaseSensitivityLabelsOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, managedInstanceName, databaseName, schemaName, tableName, columnName, sensitivityLabelSource, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the sensitivity label of a given column. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="columnName"> The name of the column. </param>
        /// <param name="sensitivityLabelSource"> The source of the sensitivity label. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SensitivityLabel> Get(string resourceGroupName, string managedInstanceName, string databaseName, string schemaName, string tableName, string columnName, SensitivityLabelSource sensitivityLabelSource, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedDatabaseSensitivityLabelsOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, managedInstanceName, databaseName, schemaName, tableName, columnName, sensitivityLabelSource, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates the sensitivity label of a given column. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="columnName"> The name of the column. </param>
        /// <param name="parameters"> The column sensitivity label resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SensitivityLabel>> CreateOrUpdateAsync(string resourceGroupName, string managedInstanceName, string databaseName, string schemaName, string tableName, string columnName, SensitivityLabel parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedDatabaseSensitivityLabelsOperations.CreateOrUpdate");
            scope.Start();
            try
            {
                return await RestClient.CreateOrUpdateAsync(resourceGroupName, managedInstanceName, databaseName, schemaName, tableName, columnName, parameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates the sensitivity label of a given column. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="columnName"> The name of the column. </param>
        /// <param name="parameters"> The column sensitivity label resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SensitivityLabel> CreateOrUpdate(string resourceGroupName, string managedInstanceName, string databaseName, string schemaName, string tableName, string columnName, SensitivityLabel parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedDatabaseSensitivityLabelsOperations.CreateOrUpdate");
            scope.Start();
            try
            {
                return RestClient.CreateOrUpdate(resourceGroupName, managedInstanceName, databaseName, schemaName, tableName, columnName, parameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the sensitivity label of a given column. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="columnName"> The name of the column. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAsync(string resourceGroupName, string managedInstanceName, string databaseName, string schemaName, string tableName, string columnName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedDatabaseSensitivityLabelsOperations.Delete");
            scope.Start();
            try
            {
                return await RestClient.DeleteAsync(resourceGroupName, managedInstanceName, databaseName, schemaName, tableName, columnName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the sensitivity label of a given column. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="columnName"> The name of the column. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(string resourceGroupName, string managedInstanceName, string databaseName, string schemaName, string tableName, string columnName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedDatabaseSensitivityLabelsOperations.Delete");
            scope.Start();
            try
            {
                return RestClient.Delete(resourceGroupName, managedInstanceName, databaseName, schemaName, tableName, columnName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Disables sensitivity recommendations on a given column. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="columnName"> The name of the column. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DisableRecommendationAsync(string resourceGroupName, string managedInstanceName, string databaseName, string schemaName, string tableName, string columnName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedDatabaseSensitivityLabelsOperations.DisableRecommendation");
            scope.Start();
            try
            {
                return await RestClient.DisableRecommendationAsync(resourceGroupName, managedInstanceName, databaseName, schemaName, tableName, columnName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Disables sensitivity recommendations on a given column. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="columnName"> The name of the column. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response DisableRecommendation(string resourceGroupName, string managedInstanceName, string databaseName, string schemaName, string tableName, string columnName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedDatabaseSensitivityLabelsOperations.DisableRecommendation");
            scope.Start();
            try
            {
                return RestClient.DisableRecommendation(resourceGroupName, managedInstanceName, databaseName, schemaName, tableName, columnName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Enables sensitivity recommendations on a given column (recommendations are enabled by default on all columns). </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="columnName"> The name of the column. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> EnableRecommendationAsync(string resourceGroupName, string managedInstanceName, string databaseName, string schemaName, string tableName, string columnName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedDatabaseSensitivityLabelsOperations.EnableRecommendation");
            scope.Start();
            try
            {
                return await RestClient.EnableRecommendationAsync(resourceGroupName, managedInstanceName, databaseName, schemaName, tableName, columnName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Enables sensitivity recommendations on a given column (recommendations are enabled by default on all columns). </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="columnName"> The name of the column. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response EnableRecommendation(string resourceGroupName, string managedInstanceName, string databaseName, string schemaName, string tableName, string columnName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedDatabaseSensitivityLabelsOperations.EnableRecommendation");
            scope.Start();
            try
            {
                return RestClient.EnableRecommendation(resourceGroupName, managedInstanceName, databaseName, schemaName, tableName, columnName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the sensitivity labels of a given database. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, or <paramref name="databaseName"/> is null. </exception>
        public virtual AsyncPageable<SensitivityLabel> ListCurrentByDatabaseAsync(string resourceGroupName, string managedInstanceName, string databaseName, string filter = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }

            async Task<Page<SensitivityLabel>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedDatabaseSensitivityLabelsOperations.ListCurrentByDatabase");
                scope.Start();
                try
                {
                    var response = await RestClient.ListCurrentByDatabaseAsync(resourceGroupName, managedInstanceName, databaseName, filter, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SensitivityLabel>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedDatabaseSensitivityLabelsOperations.ListCurrentByDatabase");
                scope.Start();
                try
                {
                    var response = await RestClient.ListCurrentByDatabaseNextPageAsync(nextLink, resourceGroupName, managedInstanceName, databaseName, filter, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets the sensitivity labels of a given database. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, or <paramref name="databaseName"/> is null. </exception>
        public virtual Pageable<SensitivityLabel> ListCurrentByDatabase(string resourceGroupName, string managedInstanceName, string databaseName, string filter = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }

            Page<SensitivityLabel> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedDatabaseSensitivityLabelsOperations.ListCurrentByDatabase");
                scope.Start();
                try
                {
                    var response = RestClient.ListCurrentByDatabase(resourceGroupName, managedInstanceName, databaseName, filter, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SensitivityLabel> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedDatabaseSensitivityLabelsOperations.ListCurrentByDatabase");
                scope.Start();
                try
                {
                    var response = RestClient.ListCurrentByDatabaseNextPage(nextLink, resourceGroupName, managedInstanceName, databaseName, filter, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets the sensitivity labels of a given database. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="includeDisabledRecommendations"> Specifies whether to include disabled recommendations or not. </param>
        /// <param name="skipToken"> The String to use. </param>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, or <paramref name="databaseName"/> is null. </exception>
        public virtual AsyncPageable<SensitivityLabel> ListRecommendedByDatabaseAsync(string resourceGroupName, string managedInstanceName, string databaseName, bool? includeDisabledRecommendations = null, string skipToken = null, string filter = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }

            async Task<Page<SensitivityLabel>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedDatabaseSensitivityLabelsOperations.ListRecommendedByDatabase");
                scope.Start();
                try
                {
                    var response = await RestClient.ListRecommendedByDatabaseAsync(resourceGroupName, managedInstanceName, databaseName, includeDisabledRecommendations, skipToken, filter, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SensitivityLabel>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedDatabaseSensitivityLabelsOperations.ListRecommendedByDatabase");
                scope.Start();
                try
                {
                    var response = await RestClient.ListRecommendedByDatabaseNextPageAsync(nextLink, resourceGroupName, managedInstanceName, databaseName, includeDisabledRecommendations, skipToken, filter, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets the sensitivity labels of a given database. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="includeDisabledRecommendations"> Specifies whether to include disabled recommendations or not. </param>
        /// <param name="skipToken"> The String to use. </param>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, or <paramref name="databaseName"/> is null. </exception>
        public virtual Pageable<SensitivityLabel> ListRecommendedByDatabase(string resourceGroupName, string managedInstanceName, string databaseName, bool? includeDisabledRecommendations = null, string skipToken = null, string filter = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }

            Page<SensitivityLabel> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedDatabaseSensitivityLabelsOperations.ListRecommendedByDatabase");
                scope.Start();
                try
                {
                    var response = RestClient.ListRecommendedByDatabase(resourceGroupName, managedInstanceName, databaseName, includeDisabledRecommendations, skipToken, filter, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SensitivityLabel> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedDatabaseSensitivityLabelsOperations.ListRecommendedByDatabase");
                scope.Start();
                try
                {
                    var response = RestClient.ListRecommendedByDatabaseNextPage(nextLink, resourceGroupName, managedInstanceName, databaseName, includeDisabledRecommendations, skipToken, filter, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
