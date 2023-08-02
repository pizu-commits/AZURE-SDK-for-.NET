// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.DataMigration;

namespace Azure.ResourceManager.DataMigration.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    internal partial class DataMigrationResourceGroupMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="DataMigrationResourceGroupMockingExtension"/> class for mocking. </summary>
        protected DataMigrationResourceGroupMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataMigrationResourceGroupMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DataMigrationResourceGroupMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of DatabaseMigrationSqlDBResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of DatabaseMigrationSqlDBResources and their operations over a DatabaseMigrationSqlDBResource. </returns>
        public virtual DatabaseMigrationSqlDBCollection GetDatabaseMigrationSqlDBs()
        {
            return GetCachedClient(Client => new DatabaseMigrationSqlDBCollection(Client, Id));
        }

        /// <summary>
        /// Retrieve the Database Migration resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{sqlDbInstanceName}/providers/Microsoft.DataMigration/databaseMigrations/{targetDbName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseMigrationsSqlDb_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sqlDBInstanceName"> The String to use. </param>
        /// <param name="targetDBName"> The name of the target database. </param>
        /// <param name="migrationOperationId"> Optional migration operation ID. If this is provided, then details of migration operation for that ID are retrieved. If not provided (default), then details related to most recent or current operation are retrieved. </param>
        /// <param name="expand"> Complete migration details be included in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual async Task<Response<DatabaseMigrationSqlDBResource>> GetDatabaseMigrationSqlDBAsync(string sqlDBInstanceName, string targetDBName, Guid? migrationOperationId = null, string expand = null, CancellationToken cancellationToken = default)
        {
            return await GetDatabaseMigrationSqlDBs().GetAsync(sqlDBInstanceName, targetDBName, migrationOperationId, expand, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieve the Database Migration resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{sqlDbInstanceName}/providers/Microsoft.DataMigration/databaseMigrations/{targetDbName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseMigrationsSqlDb_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sqlDBInstanceName"> The String to use. </param>
        /// <param name="targetDBName"> The name of the target database. </param>
        /// <param name="migrationOperationId"> Optional migration operation ID. If this is provided, then details of migration operation for that ID are retrieved. If not provided (default), then details related to most recent or current operation are retrieved. </param>
        /// <param name="expand"> Complete migration details be included in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual Response<DatabaseMigrationSqlDBResource> GetDatabaseMigrationSqlDB(string sqlDBInstanceName, string targetDBName, Guid? migrationOperationId = null, string expand = null, CancellationToken cancellationToken = default)
        {
            return GetDatabaseMigrationSqlDBs().Get(sqlDBInstanceName, targetDBName, migrationOperationId, expand, cancellationToken);
        }

        /// <summary> Gets a collection of DatabaseMigrationSqlMIResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of DatabaseMigrationSqlMIResources and their operations over a DatabaseMigrationSqlMIResource. </returns>
        public virtual DatabaseMigrationSqlMICollection GetDatabaseMigrationSqlMIs()
        {
            return GetCachedClient(Client => new DatabaseMigrationSqlMICollection(Client, Id));
        }

        /// <summary>
        /// Retrieve the specified database migration for a given SQL Managed Instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/providers/Microsoft.DataMigration/databaseMigrations/{targetDbName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseMigrationsSqlMi_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="managedInstanceName"> The String to use. </param>
        /// <param name="targetDBName"> The name of the target database. </param>
        /// <param name="migrationOperationId"> Optional migration operation ID. If this is provided, then details of migration operation for that ID are retrieved. If not provided (default), then details related to most recent or current operation are retrieved. </param>
        /// <param name="expand"> Complete migration details be included in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual async Task<Response<DatabaseMigrationSqlMIResource>> GetDatabaseMigrationSqlMIAsync(string managedInstanceName, string targetDBName, Guid? migrationOperationId = null, string expand = null, CancellationToken cancellationToken = default)
        {
            return await GetDatabaseMigrationSqlMIs().GetAsync(managedInstanceName, targetDBName, migrationOperationId, expand, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieve the specified database migration for a given SQL Managed Instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/providers/Microsoft.DataMigration/databaseMigrations/{targetDbName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseMigrationsSqlMi_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="managedInstanceName"> The String to use. </param>
        /// <param name="targetDBName"> The name of the target database. </param>
        /// <param name="migrationOperationId"> Optional migration operation ID. If this is provided, then details of migration operation for that ID are retrieved. If not provided (default), then details related to most recent or current operation are retrieved. </param>
        /// <param name="expand"> Complete migration details be included in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual Response<DatabaseMigrationSqlMIResource> GetDatabaseMigrationSqlMI(string managedInstanceName, string targetDBName, Guid? migrationOperationId = null, string expand = null, CancellationToken cancellationToken = default)
        {
            return GetDatabaseMigrationSqlMIs().Get(managedInstanceName, targetDBName, migrationOperationId, expand, cancellationToken);
        }

        /// <summary> Gets a collection of DatabaseMigrationSqlVmResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of DatabaseMigrationSqlVmResources and their operations over a DatabaseMigrationSqlVmResource. </returns>
        public virtual DatabaseMigrationSqlVmCollection GetDatabaseMigrationSqlVms()
        {
            return GetCachedClient(Client => new DatabaseMigrationSqlVmCollection(Client, Id));
        }

        /// <summary>
        /// Retrieve the specified database migration for a given SQL VM.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines/{sqlVirtualMachineName}/providers/Microsoft.DataMigration/databaseMigrations/{targetDbName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseMigrationsSqlVm_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sqlVirtualMachineName"> The String to use. </param>
        /// <param name="targetDBName"> The name of the target database. </param>
        /// <param name="migrationOperationId"> Optional migration operation ID. If this is provided, then details of migration operation for that ID are retrieved. If not provided (default), then details related to most recent or current operation are retrieved. </param>
        /// <param name="expand"> Complete migration details be included in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual async Task<Response<DatabaseMigrationSqlVmResource>> GetDatabaseMigrationSqlVmAsync(string sqlVirtualMachineName, string targetDBName, Guid? migrationOperationId = null, string expand = null, CancellationToken cancellationToken = default)
        {
            return await GetDatabaseMigrationSqlVms().GetAsync(sqlVirtualMachineName, targetDBName, migrationOperationId, expand, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieve the specified database migration for a given SQL VM.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines/{sqlVirtualMachineName}/providers/Microsoft.DataMigration/databaseMigrations/{targetDbName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseMigrationsSqlVm_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sqlVirtualMachineName"> The String to use. </param>
        /// <param name="targetDBName"> The name of the target database. </param>
        /// <param name="migrationOperationId"> Optional migration operation ID. If this is provided, then details of migration operation for that ID are retrieved. If not provided (default), then details related to most recent or current operation are retrieved. </param>
        /// <param name="expand"> Complete migration details be included in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual Response<DatabaseMigrationSqlVmResource> GetDatabaseMigrationSqlVm(string sqlVirtualMachineName, string targetDBName, Guid? migrationOperationId = null, string expand = null, CancellationToken cancellationToken = default)
        {
            return GetDatabaseMigrationSqlVms().Get(sqlVirtualMachineName, targetDBName, migrationOperationId, expand, cancellationToken);
        }

        /// <summary> Gets a collection of SqlMigrationServiceResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of SqlMigrationServiceResources and their operations over a SqlMigrationServiceResource. </returns>
        public virtual SqlMigrationServiceCollection GetSqlMigrationServices()
        {
            return GetCachedClient(Client => new SqlMigrationServiceCollection(Client, Id));
        }

        /// <summary>
        /// Retrieve the Database Migration Service
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataMigration/sqlMigrationServices/{sqlMigrationServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlMigrationServices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sqlMigrationServiceName"> Name of the SQL Migration Service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual async Task<Response<SqlMigrationServiceResource>> GetSqlMigrationServiceAsync(string sqlMigrationServiceName, CancellationToken cancellationToken = default)
        {
            return await GetSqlMigrationServices().GetAsync(sqlMigrationServiceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieve the Database Migration Service
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataMigration/sqlMigrationServices/{sqlMigrationServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlMigrationServices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sqlMigrationServiceName"> Name of the SQL Migration Service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual Response<SqlMigrationServiceResource> GetSqlMigrationService(string sqlMigrationServiceName, CancellationToken cancellationToken = default)
        {
            return GetSqlMigrationServices().Get(sqlMigrationServiceName, cancellationToken);
        }

        /// <summary> Gets a collection of DataMigrationServiceResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of DataMigrationServiceResources and their operations over a DataMigrationServiceResource. </returns>
        public virtual DataMigrationServiceCollection GetDataMigrationServices()
        {
            return GetCachedClient(Client => new DataMigrationServiceCollection(Client, Id));
        }

        /// <summary>
        /// The services resource is the top-level resource that represents the Database Migration Service. The GET method retrieves information about a service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.DataMigration/services/{serviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceName"> Name of the service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual async Task<Response<DataMigrationServiceResource>> GetDataMigrationServiceAsync(string serviceName, CancellationToken cancellationToken = default)
        {
            return await GetDataMigrationServices().GetAsync(serviceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// The services resource is the top-level resource that represents the Database Migration Service. The GET method retrieves information about a service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.DataMigration/services/{serviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceName"> Name of the service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual Response<DataMigrationServiceResource> GetDataMigrationService(string serviceName, CancellationToken cancellationToken = default)
        {
            return GetDataMigrationServices().Get(serviceName, cancellationToken);
        }
    }
}
