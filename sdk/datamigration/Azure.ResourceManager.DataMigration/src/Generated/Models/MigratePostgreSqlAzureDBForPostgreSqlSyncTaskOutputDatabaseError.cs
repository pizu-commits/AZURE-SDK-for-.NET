// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> The MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputDatabaseError. </summary>
    public partial class MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputDatabaseError : MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput
    {
        /// <summary> Initializes a new instance of MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputDatabaseError. </summary>
        internal MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputDatabaseError()
        {
            Events = new ChangeTrackingList<SyncMigrationDatabaseErrorEvent>();
            ResultType = "DatabaseLevelErrorOutput";
        }

        /// <summary> Initializes a new instance of MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputDatabaseError. </summary>
        /// <param name="id"> Result identifier. </param>
        /// <param name="resultType"> Result type. </param>
        /// <param name="errorMessage"> Error message. </param>
        /// <param name="events"> List of error events. </param>
        internal MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputDatabaseError(string id, string resultType, string errorMessage, IReadOnlyList<SyncMigrationDatabaseErrorEvent> events) : base(id, resultType)
        {
            ErrorMessage = errorMessage;
            Events = events;
            ResultType = resultType ?? "DatabaseLevelErrorOutput";
        }

        /// <summary> Error message. </summary>
        public string ErrorMessage { get; }
        /// <summary> List of error events. </summary>
        public IReadOnlyList<SyncMigrationDatabaseErrorEvent> Events { get; }
    }
}
