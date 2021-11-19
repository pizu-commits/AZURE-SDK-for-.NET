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
    /// Extension methods for SqlPoolSchemasOperations.
    /// </summary>
    public static partial class SqlPoolSchemasOperationsExtensions
    {
            /// <summary>
            /// Gets schemas of a given SQL pool
            /// </summary>
            /// <remarks>
            /// Gets schemas of a given SQL pool.
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
            public static IPage<SqlPoolSchema> List(this ISqlPoolSchemasOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, ODataQuery<SqlPoolSchema> odataQuery = default(ODataQuery<SqlPoolSchema>))
            {
                return operations.ListAsync(resourceGroupName, workspaceName, sqlPoolName, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets schemas of a given SQL pool
            /// </summary>
            /// <remarks>
            /// Gets schemas of a given SQL pool.
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
            public static async Task<IPage<SqlPoolSchema>> ListAsync(this ISqlPoolSchemasOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, ODataQuery<SqlPoolSchema> odataQuery = default(ODataQuery<SqlPoolSchema>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get Sql Pool schema
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
            public static SqlPoolSchema Get(this ISqlPoolSchemasOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string schemaName)
            {
                return operations.GetAsync(resourceGroupName, workspaceName, sqlPoolName, schemaName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get Sql Pool schema
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SqlPoolSchema> GetAsync(this ISqlPoolSchemasOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string schemaName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, schemaName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets schemas of a given SQL pool
            /// </summary>
            /// <remarks>
            /// Gets schemas of a given SQL pool.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SqlPoolSchema> ListNext(this ISqlPoolSchemasOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets schemas of a given SQL pool
            /// </summary>
            /// <remarks>
            /// Gets schemas of a given SQL pool.
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
            public static async Task<IPage<SqlPoolSchema>> ListNextAsync(this ISqlPoolSchemasOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
