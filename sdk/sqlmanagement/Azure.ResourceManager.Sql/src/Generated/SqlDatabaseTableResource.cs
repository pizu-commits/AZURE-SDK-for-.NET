// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A Class representing a SqlDatabaseTable along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SqlDatabaseTableResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSqlDatabaseTableResource method.
    /// Otherwise you can get one from its parent resource <see cref="SqlDatabaseSchemaResource" /> using the GetSqlDatabaseTable method.
    /// </summary>
    public partial class SqlDatabaseTableResource : DatabaseTableResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SqlDatabaseTableResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serverName, string databaseName, string schemaName, string tableName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _sqlDatabaseTableDatabaseTablesClientDiagnostics;
        private readonly DatabaseTablesRestOperations _sqlDatabaseTableDatabaseTablesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SqlDatabaseTableResource"/> class for mocking. </summary>
        protected SqlDatabaseTableResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SqlDatabaseTableResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SqlDatabaseTableResource(ArmClient client, DatabaseTableData data) : base(client, data)
        {
            _sqlDatabaseTableDatabaseTablesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string sqlDatabaseTableDatabaseTablesApiVersion);
            _sqlDatabaseTableDatabaseTablesRestClient = new DatabaseTablesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlDatabaseTableDatabaseTablesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="SqlDatabaseTableResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SqlDatabaseTableResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlDatabaseTableDatabaseTablesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string sqlDatabaseTableDatabaseTablesApiVersion);
            _sqlDatabaseTableDatabaseTablesRestClient = new DatabaseTablesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlDatabaseTableDatabaseTablesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/servers/databases/schemas/tables";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of SqlDatabaseColumnResources in the SqlDatabaseTable. </summary>
        /// <returns> An object representing collection of SqlDatabaseColumnResources and their operations over a SqlDatabaseColumnResource. </returns>
        public virtual SqlDatabaseColumnCollection GetSqlDatabaseColumns()
        {
            return GetCachedClient(Client => new SqlDatabaseColumnCollection(Client, Id));
        }

        /// <summary>
        /// Get database column
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}
        /// Operation Id: DatabaseColumns_Get
        /// </summary>
        /// <param name="columnName"> The name of the column. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="columnName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="columnName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SqlDatabaseColumnResource>> GetSqlDatabaseColumnAsync(string columnName, CancellationToken cancellationToken = default)
        {
            return await GetSqlDatabaseColumns().GetAsync(columnName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get database column
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}
        /// Operation Id: DatabaseColumns_Get
        /// </summary>
        /// <param name="columnName"> The name of the column. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="columnName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="columnName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<SqlDatabaseColumnResource> GetSqlDatabaseColumn(string columnName, CancellationToken cancellationToken = default)
        {
            return GetSqlDatabaseColumns().Get(columnName, cancellationToken);
        }

        /// <summary>
        /// Get database table
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}
        /// Operation Id: DatabaseTables_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<DatabaseTableResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _sqlDatabaseTableDatabaseTablesClientDiagnostics.CreateScope("SqlDatabaseTableResource.Get");
            scope.Start();
            try
            {
                var response = await _sqlDatabaseTableDatabaseTablesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get database table
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}
        /// Operation Id: DatabaseTables_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new async Task<Response<SqlDatabaseTableResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var result = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((SqlDatabaseTableResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// Get database table
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}
        /// Operation Id: DatabaseTables_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<DatabaseTableResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _sqlDatabaseTableDatabaseTablesClientDiagnostics.CreateScope("SqlDatabaseTableResource.Get");
            scope.Start();
            try
            {
                var response = _sqlDatabaseTableDatabaseTablesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get database table
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}
        /// Operation Id: DatabaseTables_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new Response<SqlDatabaseTableResource> Get(CancellationToken cancellationToken = default)
        {
            var result = GetCore(cancellationToken);
            return Response.FromValue((SqlDatabaseTableResource)result.Value, result.GetRawResponse());
        }
    }
}
