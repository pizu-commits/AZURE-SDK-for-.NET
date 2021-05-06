// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.Azure.Management.WebSites.Models
{
    /// <summary> MySQL migration status. </summary>
    public partial class MigrateMySqlStatus : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of MigrateMySqlStatus. </summary>
        public MigrateMySqlStatus()
        {
        }

        /// <summary> Initializes a new instance of MigrateMySqlStatus. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="name"> Resource Name. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="migrationOperationStatus"> Status of the migration task. </param>
        /// <param name="operationId"> Operation ID for the migration task. </param>
        /// <param name="localMySqlEnabled"> True if the web app has in app MySql enabled. </param>
        internal MigrateMySqlStatus(string id, string name, string kind, string type, OperationStatus? migrationOperationStatus, string operationId, bool? localMySqlEnabled) : base(id, name, kind, type)
        {
            MigrationOperationStatus = migrationOperationStatus;
            OperationId = operationId;
            LocalMySqlEnabled = localMySqlEnabled;
        }

        /// <summary> Status of the migration task. </summary>
        public OperationStatus? MigrationOperationStatus { get; }
        /// <summary> Operation ID for the migration task. </summary>
        public string OperationId { get; }
        /// <summary> True if the web app has in app MySql enabled. </summary>
        public bool? LocalMySqlEnabled { get; }
    }
}
