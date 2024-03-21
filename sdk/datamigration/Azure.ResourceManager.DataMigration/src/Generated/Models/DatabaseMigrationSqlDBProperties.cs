// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Database Migration Resource properties for SQL database. </summary>
    public partial class DatabaseMigrationSqlDBProperties : DatabaseMigrationProperties
    {
        /// <summary> Initializes a new instance of <see cref="DatabaseMigrationSqlDBProperties"/>. </summary>
        public DatabaseMigrationSqlDBProperties()
        {
            TableList = new ChangeTrackingList<string>();
            Kind = ResourceType.SqlDB;
        }

        /// <summary> Initializes a new instance of <see cref="DatabaseMigrationSqlDBProperties"/>. </summary>
        /// <param name="kind"></param>
        /// <param name="scope"> Resource Id of the target resource (SQL VM or SQL Managed Instance). </param>
        /// <param name="provisioningState"> Provisioning State of migration. ProvisioningState as Succeeded implies that validations have been performed and migration has started. </param>
        /// <param name="migrationStatus"> Migration status. </param>
        /// <param name="startedOn"> Database migration start time. </param>
        /// <param name="endedOn"> Database migration end time. </param>
        /// <param name="sourceSqlConnection"> Source SQL Server connection details. </param>
        /// <param name="sourceDatabaseName"> Name of the source database. </param>
        /// <param name="sourceServerName"> Name of the source sql server. </param>
        /// <param name="migrationService"> Resource Id of the Migration Service. </param>
        /// <param name="migrationOperationId"> ID tracking current migration operation. </param>
        /// <param name="migrationFailureError"> Error details in case of migration failure. </param>
        /// <param name="targetDatabaseCollation"> Database collation to be used for the target database. </param>
        /// <param name="provisioningError"> Error message for migration provisioning failure, if any. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="migrationStatusDetails"> Detailed migration status. Not included by default. </param>
        /// <param name="targetSqlConnection"> Target SQL DB connection details. </param>
        /// <param name="offlineConfiguration"> Offline configuration. </param>
        /// <param name="tableList"> List of tables to copy. </param>
        internal DatabaseMigrationSqlDBProperties(ResourceType kind, string scope, string provisioningState, string migrationStatus, DateTimeOffset? startedOn, DateTimeOffset? endedOn, SqlConnectionInformation sourceSqlConnection, string sourceDatabaseName, string sourceServerName, string migrationService, string migrationOperationId, ErrorInfo migrationFailureError, string targetDatabaseCollation, string provisioningError, IDictionary<string, BinaryData> serializedAdditionalRawData, SqlDBMigrationStatusDetails migrationStatusDetails, SqlConnectionInformation targetSqlConnection, SqlDBOfflineConfiguration offlineConfiguration, IList<string> tableList) : base(kind, scope, provisioningState, migrationStatus, startedOn, endedOn, sourceSqlConnection, sourceDatabaseName, sourceServerName, migrationService, migrationOperationId, migrationFailureError, targetDatabaseCollation, provisioningError, serializedAdditionalRawData)
        {
            MigrationStatusDetails = migrationStatusDetails;
            TargetSqlConnection = targetSqlConnection;
            OfflineConfiguration = offlineConfiguration;
            TableList = tableList;
            Kind = kind;
        }

        /// <summary> Detailed migration status. Not included by default. </summary>
        public SqlDBMigrationStatusDetails MigrationStatusDetails { get; }
        /// <summary> Target SQL DB connection details. </summary>
        public SqlConnectionInformation TargetSqlConnection { get; set; }
        /// <summary> Offline configuration. </summary>
        internal SqlDBOfflineConfiguration OfflineConfiguration { get; }
        /// <summary> Offline migration. </summary>
        public bool? Offline
        {
            get => OfflineConfiguration?.Offline;
        }

        /// <summary> List of tables to copy. </summary>
        public IList<string> TableList { get; }
    }
}
