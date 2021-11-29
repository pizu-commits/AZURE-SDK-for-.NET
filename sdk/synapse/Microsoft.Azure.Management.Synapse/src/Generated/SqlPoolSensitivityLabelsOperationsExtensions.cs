// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SqlPoolSensitivityLabelsOperations.
    /// </summary>
    public static partial class SqlPoolSensitivityLabelsOperationsExtensions
    {
            /// <summary>
            /// Gets SQL pool sensitivity labels
            /// </summary>
            /// <remarks>
            /// Gets SQL pool sensitivity labels.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<SensitivityLabel> ListCurrent(this ISqlPoolSensitivityLabelsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, ODataQuery<SensitivityLabel> odataQuery = default(ODataQuery<SensitivityLabel>))
            {
                return operations.ListCurrentAsync(resourceGroupName, workspaceName, sqlPoolName, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets SQL pool sensitivity labels
            /// </summary>
            /// <remarks>
            /// Gets SQL pool sensitivity labels.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SensitivityLabel>> ListCurrentAsync(this ISqlPoolSensitivityLabelsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, ODataQuery<SensitivityLabel> odataQuery = default(ODataQuery<SensitivityLabel>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListCurrentWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update sensitivity labels of a given SQL Pool using an operations batch.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='parameters'>
            /// </param>
            public static void Update(this ISqlPoolSensitivityLabelsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, SensitivityLabelUpdateList parameters)
            {
                operations.UpdateAsync(resourceGroupName, workspaceName, sqlPoolName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update sensitivity labels of a given SQL Pool using an operations batch.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='parameters'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateAsync(this ISqlPoolSensitivityLabelsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, SensitivityLabelUpdateList parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, parameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets sensitivity labels of a given SQL pool
            /// </summary>
            /// <remarks>
            /// Gets sensitivity labels of a given SQL pool.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='includeDisabledRecommendations'>
            /// Specifies whether to include disabled recommendations or not.
            /// </param>
            /// <param name='skipToken'>
            /// An OData query option to indicate how many elements to skip in the
            /// collection.
            /// </param>
            public static IPage<SensitivityLabel> ListRecommended(this ISqlPoolSensitivityLabelsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, ODataQuery<SensitivityLabel> odataQuery = default(ODataQuery<SensitivityLabel>), bool? includeDisabledRecommendations = default(bool?), string skipToken = default(string))
            {
                return operations.ListRecommendedAsync(resourceGroupName, workspaceName, sqlPoolName, odataQuery, includeDisabledRecommendations, skipToken).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets sensitivity labels of a given SQL pool
            /// </summary>
            /// <remarks>
            /// Gets sensitivity labels of a given SQL pool.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='includeDisabledRecommendations'>
            /// Specifies whether to include disabled recommendations or not.
            /// </param>
            /// <param name='skipToken'>
            /// An OData query option to indicate how many elements to skip in the
            /// collection.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SensitivityLabel>> ListRecommendedAsync(this ISqlPoolSensitivityLabelsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, ODataQuery<SensitivityLabel> odataQuery = default(ODataQuery<SensitivityLabel>), bool? includeDisabledRecommendations = default(bool?), string skipToken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListRecommendedWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, odataQuery, includeDisabledRecommendations, skipToken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates the sensitivity label of a given column in a Sql pool
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='schemaName'>
            /// The name of the schema.
            /// </param>
            /// <param name='tableName'>
            /// The name of the table.
            /// </param>
            /// <param name='columnName'>
            /// The name of the column.
            /// </param>
            /// <param name='parameters'>
            /// The column sensitivity label resource.
            /// </param>
            public static SensitivityLabel CreateOrUpdate(this ISqlPoolSensitivityLabelsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string schemaName, string tableName, string columnName, SensitivityLabel parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, workspaceName, sqlPoolName, schemaName, tableName, columnName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates the sensitivity label of a given column in a Sql pool
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='schemaName'>
            /// The name of the schema.
            /// </param>
            /// <param name='tableName'>
            /// The name of the table.
            /// </param>
            /// <param name='columnName'>
            /// The name of the column.
            /// </param>
            /// <param name='parameters'>
            /// The column sensitivity label resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SensitivityLabel> CreateOrUpdateAsync(this ISqlPoolSensitivityLabelsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string schemaName, string tableName, string columnName, SensitivityLabel parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, schemaName, tableName, columnName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the sensitivity label of a given column in a Sql pool
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='schemaName'>
            /// The name of the schema.
            /// </param>
            /// <param name='tableName'>
            /// The name of the table.
            /// </param>
            /// <param name='columnName'>
            /// The name of the column.
            /// </param>
            public static void Delete(this ISqlPoolSensitivityLabelsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string schemaName, string tableName, string columnName)
            {
                operations.DeleteAsync(resourceGroupName, workspaceName, sqlPoolName, schemaName, tableName, columnName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the sensitivity label of a given column in a Sql pool
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='schemaName'>
            /// The name of the schema.
            /// </param>
            /// <param name='tableName'>
            /// The name of the table.
            /// </param>
            /// <param name='columnName'>
            /// The name of the column.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ISqlPoolSensitivityLabelsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string schemaName, string tableName, string columnName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, schemaName, tableName, columnName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the sensitivity label of a given column
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='schemaName'>
            /// The name of the schema.
            /// </param>
            /// <param name='tableName'>
            /// The name of the table.
            /// </param>
            /// <param name='columnName'>
            /// The name of the column.
            /// </param>
            /// <param name='sensitivityLabelSource'>
            /// The source of the sensitivity label. Possible values include: 'current',
            /// 'recommended'
            /// </param>
            public static SensitivityLabel Get(this ISqlPoolSensitivityLabelsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string schemaName, string tableName, string columnName, SensitivityLabelSource sensitivityLabelSource)
            {
                return operations.GetAsync(resourceGroupName, workspaceName, sqlPoolName, schemaName, tableName, columnName, sensitivityLabelSource).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the sensitivity label of a given column
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='schemaName'>
            /// The name of the schema.
            /// </param>
            /// <param name='tableName'>
            /// The name of the table.
            /// </param>
            /// <param name='columnName'>
            /// The name of the column.
            /// </param>
            /// <param name='sensitivityLabelSource'>
            /// The source of the sensitivity label. Possible values include: 'current',
            /// 'recommended'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SensitivityLabel> GetAsync(this ISqlPoolSensitivityLabelsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string schemaName, string tableName, string columnName, SensitivityLabelSource sensitivityLabelSource, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, schemaName, tableName, columnName, sensitivityLabelSource, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Enables sensitivity recommendations on a given column (recommendations are
            /// enabled by default on all columns)
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='schemaName'>
            /// The name of the schema.
            /// </param>
            /// <param name='tableName'>
            /// The name of the table.
            /// </param>
            /// <param name='columnName'>
            /// The name of the column.
            /// </param>
            public static void EnableRecommendation(this ISqlPoolSensitivityLabelsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string schemaName, string tableName, string columnName)
            {
                operations.EnableRecommendationAsync(resourceGroupName, workspaceName, sqlPoolName, schemaName, tableName, columnName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Enables sensitivity recommendations on a given column (recommendations are
            /// enabled by default on all columns)
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='schemaName'>
            /// The name of the schema.
            /// </param>
            /// <param name='tableName'>
            /// The name of the table.
            /// </param>
            /// <param name='columnName'>
            /// The name of the column.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task EnableRecommendationAsync(this ISqlPoolSensitivityLabelsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string schemaName, string tableName, string columnName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.EnableRecommendationWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, schemaName, tableName, columnName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Disables sensitivity recommendations on a given column
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='schemaName'>
            /// The name of the schema.
            /// </param>
            /// <param name='tableName'>
            /// The name of the table.
            /// </param>
            /// <param name='columnName'>
            /// The name of the column.
            /// </param>
            public static void DisableRecommendation(this ISqlPoolSensitivityLabelsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string schemaName, string tableName, string columnName)
            {
                operations.DisableRecommendationAsync(resourceGroupName, workspaceName, sqlPoolName, schemaName, tableName, columnName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Disables sensitivity recommendations on a given column
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='schemaName'>
            /// The name of the schema.
            /// </param>
            /// <param name='tableName'>
            /// The name of the table.
            /// </param>
            /// <param name='columnName'>
            /// The name of the column.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DisableRecommendationAsync(this ISqlPoolSensitivityLabelsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string schemaName, string tableName, string columnName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DisableRecommendationWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, schemaName, tableName, columnName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets SQL pool sensitivity labels
            /// </summary>
            /// <remarks>
            /// Gets SQL pool sensitivity labels.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SensitivityLabel> ListCurrentNext(this ISqlPoolSensitivityLabelsOperations operations, string nextPageLink)
            {
                return operations.ListCurrentNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets SQL pool sensitivity labels
            /// </summary>
            /// <remarks>
            /// Gets SQL pool sensitivity labels.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SensitivityLabel>> ListCurrentNextAsync(this ISqlPoolSensitivityLabelsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListCurrentNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets sensitivity labels of a given SQL pool
            /// </summary>
            /// <remarks>
            /// Gets sensitivity labels of a given SQL pool.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SensitivityLabel> ListRecommendedNext(this ISqlPoolSensitivityLabelsOperations operations, string nextPageLink)
            {
                return operations.ListRecommendedNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets sensitivity labels of a given SQL pool
            /// </summary>
            /// <remarks>
            /// Gets sensitivity labels of a given SQL pool.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SensitivityLabel>> ListRecommendedNextAsync(this ISqlPoolSensitivityLabelsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListRecommendedNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
