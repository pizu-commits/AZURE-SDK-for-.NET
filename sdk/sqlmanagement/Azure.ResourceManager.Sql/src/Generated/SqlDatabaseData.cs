// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing the SqlDatabase data model. </summary>
    public partial class SqlDatabaseData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of SqlDatabaseData. </summary>
        /// <param name="location"> The location. </param>
        public SqlDatabaseData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of SqlDatabaseData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku">
        /// The database SKU.
        /// 
        /// The list of SKUs may vary by region and support offer. To determine the SKUs (including the SKU name, tier/edition, family, and capacity) that are available to your subscription in an Azure region, use the `Capabilities_ListByLocation` REST API or one of the following commands:
        /// 
        /// ```azurecli
        /// az sql db list-editions -l &lt;location&gt; -o table
        /// ````
        /// 
        /// ```powershell
        /// Get-AzSqlServerServiceObjective -Location &lt;location&gt;
        /// ````
        /// 
        /// </param>
        /// <param name="kind"> Kind of database. This is metadata used for the Azure portal experience. </param>
        /// <param name="managedBy"> Resource that manages the database. </param>
        /// <param name="identity"> The Azure Active Directory identity of the database. </param>
        /// <param name="createMode">
        /// Specifies the mode of database creation.
        /// 
        /// Default: regular database creation.
        /// 
        /// Copy: creates a database as a copy of an existing database. sourceDatabaseId must be specified as the resource ID of the source database.
        /// 
        /// Secondary: creates a database as a secondary replica of an existing database. sourceDatabaseId must be specified as the resource ID of the existing primary database.
        /// 
        /// PointInTimeRestore: Creates a database by restoring a point in time backup of an existing database. sourceDatabaseId must be specified as the resource ID of the existing database, and restorePointInTime must be specified.
        /// 
        /// Recovery: Creates a database by restoring a geo-replicated backup. sourceDatabaseId must be specified as the recoverable database resource ID to restore.
        /// 
        /// Restore: Creates a database by restoring a backup of a deleted database. sourceDatabaseId must be specified. If sourceDatabaseId is the database&apos;s original resource ID, then sourceDatabaseDeletionDate must be specified. Otherwise sourceDatabaseId must be the restorable dropped database resource ID and sourceDatabaseDeletionDate is ignored. restorePointInTime may also be specified to restore from an earlier point in time.
        /// 
        /// RestoreLongTermRetentionBackup: Creates a database by restoring from a long term retention vault. recoveryServicesRecoveryPointResourceId must be specified as the recovery point resource ID.
        /// 
        /// Copy, Secondary, and RestoreLongTermRetentionBackup are not supported for DataWarehouse edition.
        /// </param>
        /// <param name="collation"> The collation of the database. </param>
        /// <param name="maxSizeBytes"> The max size of the database expressed in bytes. </param>
        /// <param name="sampleName"> The name of the sample schema to apply when creating this database. </param>
        /// <param name="elasticPoolId"> The resource identifier of the elastic pool containing this database. </param>
        /// <param name="sourceDatabaseId"> The resource identifier of the source database associated with create operation of this database. </param>
        /// <param name="status"> The status of the database. </param>
        /// <param name="databaseId"> The ID of the database. </param>
        /// <param name="createdOn"> The creation date of the database (ISO8601 format). </param>
        /// <param name="currentServiceObjectiveName"> The current service level objective name of the database. </param>
        /// <param name="requestedServiceObjectiveName"> The requested service level objective name of the database. </param>
        /// <param name="defaultSecondaryLocation"> The default secondary region for this database. </param>
        /// <param name="failoverGroupId"> Failover Group resource identifier that this database belongs to. </param>
        /// <param name="restorePointInTime"> Specifies the point in time (ISO8601 format) of the source database that will be restored to create the new database. </param>
        /// <param name="sourceDatabaseDeletedOn"> Specifies the time that the database was deleted. </param>
        /// <param name="recoveryServicesRecoveryPointId"> The resource identifier of the recovery point associated with create operation of this database. </param>
        /// <param name="longTermRetentionBackupResourceId"> The resource identifier of the long term retention backup associated with create operation of this database. </param>
        /// <param name="recoverableDatabaseId"> The resource identifier of the recoverable database associated with create operation of this database. </param>
        /// <param name="restorableDroppedDatabaseId"> The resource identifier of the restorable dropped database associated with create operation of this database. </param>
        /// <param name="catalogCollation"> Collation of the metadata catalog. </param>
        /// <param name="isZoneRedundant"> Whether or not this database is zone redundant, which means the replicas of this database will be spread across multiple availability zones. </param>
        /// <param name="licenseType"> The license type to apply for this database. `LicenseIncluded` if you need a license, or `BasePrice` if you have a license and are eligible for the Azure Hybrid Benefit. </param>
        /// <param name="maxLogSizeBytes"> The max log size for this database. </param>
        /// <param name="earliestRestoreOn"> This records the earliest start date and time that restore is available for this database (ISO8601 format). </param>
        /// <param name="readScale"> The state of read-only routing. If enabled, connections that have application intent set to readonly in their connection string may be routed to a readonly secondary replica in the same region. Not applicable to a Hyperscale database within an elastic pool. </param>
        /// <param name="highAvailabilityReplicaCount"> The number of secondary replicas associated with the database that are used to provide high availability. Not applicable to a Hyperscale database within an elastic pool. </param>
        /// <param name="secondaryType"> The secondary type of the database if it is a secondary.  Valid values are Geo and Named. </param>
        /// <param name="currentSku"> The name and tier of the SKU. </param>
        /// <param name="autoPauseDelay"> Time in minutes after which database is automatically paused. A value of -1 means that automatic pause is disabled. </param>
        /// <param name="currentBackupStorageRedundancy"> The storage account type used to store backups for this database. </param>
        /// <param name="requestedBackupStorageRedundancy"> The storage account type to be used to store backups for this database. </param>
        /// <param name="minCapacity"> Minimal capacity that database will always have allocated, if not paused. </param>
        /// <param name="pausedOn"> The date when database was paused by user configuration or action(ISO8601 format). Null if the database is ready. </param>
        /// <param name="resumedOn"> The date when database was resumed by user action or database login (ISO8601 format). Null if the database is paused. </param>
        /// <param name="maintenanceConfigurationId"> Maintenance configuration id assigned to the database. This configuration defines the period when the maintenance updates will occur. </param>
        /// <param name="isLedgerOn"> Whether or not this database is a ledger database, which means all tables in the database are ledger tables. Note: the value of this property cannot be changed after the database has been created. </param>
        /// <param name="isInfraEncryptionEnabled"> Infra encryption is enabled for this database. </param>
        /// <param name="federatedClientId"> The Client id used for cross tenant per database CMK scenario. </param>
        /// <param name="sourceResourceId">
        /// The resource identifier of the source associated with the create operation of this database.
        /// 
        /// When sourceResourceId is specified, sourceDatabaseId, recoverableDatabaseId, restorableDroppedDatabaseId and sourceDatabaseDeletionDate must not be specified and CreateMode must be PointInTimeRestore, Restore or Recover.
        /// 
        /// When createMode is PointInTimeRestore, sourceResourceId must be the resource ID of an existing database or existing sql pool, and restorePointInTime must be specified.
        /// 
        /// When createMode is Restore, sourceResourceId must be the resource ID of restorable dropped database or restorable dropped sql pool.
        /// 
        /// When createMode is Recover, sourceResourceId must be the resource ID of recoverable database or recoverable sql pool.
        /// 
        /// This property allows to restore across subscriptions which is only supported for DataWarehouse edition.
        /// 
        /// When source subscription belongs to a different tenant than target subscription, “x-ms-authorization-auxiliary” header must contain authentication token for the source tenant. For more details about “x-ms-authorization-auxiliary” header see https://docs.microsoft.com/en-us/azure/azure-resource-manager/management/authenticate-multi-tenant 
        /// </param>
        internal SqlDatabaseData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, SqlSku sku, string kind, string managedBy, DatabaseIdentity identity, SqlDatabaseCreateMode? createMode, string collation, long? maxSizeBytes, SampleSchemaName? sampleName, ResourceIdentifier elasticPoolId, ResourceIdentifier sourceDatabaseId, DatabaseStatus? status, Guid? databaseId, DateTimeOffset? createdOn, string currentServiceObjectiveName, string requestedServiceObjectiveName, AzureLocation? defaultSecondaryLocation, ResourceIdentifier failoverGroupId, DateTimeOffset? restorePointInTime, DateTimeOffset? sourceDatabaseDeletedOn, ResourceIdentifier recoveryServicesRecoveryPointId, ResourceIdentifier longTermRetentionBackupResourceId, ResourceIdentifier recoverableDatabaseId, ResourceIdentifier restorableDroppedDatabaseId, CatalogCollationType? catalogCollation, bool? isZoneRedundant, DatabaseLicenseType? licenseType, long? maxLogSizeBytes, DateTimeOffset? earliestRestoreOn, DatabaseReadScale? readScale, int? highAvailabilityReplicaCount, SecondaryType? secondaryType, SqlSku currentSku, int? autoPauseDelay, BackupStorageRedundancy? currentBackupStorageRedundancy, BackupStorageRedundancy? requestedBackupStorageRedundancy, double? minCapacity, DateTimeOffset? pausedOn, DateTimeOffset? resumedOn, ResourceIdentifier maintenanceConfigurationId, bool? isLedgerOn, bool? isInfraEncryptionEnabled, Guid? federatedClientId, ResourceIdentifier sourceResourceId) : base(id, name, resourceType, systemData, tags, location)
        {
            Sku = sku;
            Kind = kind;
            ManagedBy = managedBy;
            Identity = identity;
            CreateMode = createMode;
            Collation = collation;
            MaxSizeBytes = maxSizeBytes;
            SampleName = sampleName;
            ElasticPoolId = elasticPoolId;
            SourceDatabaseId = sourceDatabaseId;
            Status = status;
            DatabaseId = databaseId;
            CreatedOn = createdOn;
            CurrentServiceObjectiveName = currentServiceObjectiveName;
            RequestedServiceObjectiveName = requestedServiceObjectiveName;
            DefaultSecondaryLocation = defaultSecondaryLocation;
            FailoverGroupId = failoverGroupId;
            RestorePointInTime = restorePointInTime;
            SourceDatabaseDeletedOn = sourceDatabaseDeletedOn;
            RecoveryServicesRecoveryPointId = recoveryServicesRecoveryPointId;
            LongTermRetentionBackupResourceId = longTermRetentionBackupResourceId;
            RecoverableDatabaseId = recoverableDatabaseId;
            RestorableDroppedDatabaseId = restorableDroppedDatabaseId;
            CatalogCollation = catalogCollation;
            IsZoneRedundant = isZoneRedundant;
            LicenseType = licenseType;
            MaxLogSizeBytes = maxLogSizeBytes;
            EarliestRestoreOn = earliestRestoreOn;
            ReadScale = readScale;
            HighAvailabilityReplicaCount = highAvailabilityReplicaCount;
            SecondaryType = secondaryType;
            CurrentSku = currentSku;
            AutoPauseDelay = autoPauseDelay;
            CurrentBackupStorageRedundancy = currentBackupStorageRedundancy;
            RequestedBackupStorageRedundancy = requestedBackupStorageRedundancy;
            MinCapacity = minCapacity;
            PausedOn = pausedOn;
            ResumedOn = resumedOn;
            MaintenanceConfigurationId = maintenanceConfigurationId;
            IsLedgerOn = isLedgerOn;
            IsInfraEncryptionEnabled = isInfraEncryptionEnabled;
            FederatedClientId = federatedClientId;
            SourceResourceId = sourceResourceId;
        }

        /// <summary>
        /// The database SKU.
        /// 
        /// The list of SKUs may vary by region and support offer. To determine the SKUs (including the SKU name, tier/edition, family, and capacity) that are available to your subscription in an Azure region, use the `Capabilities_ListByLocation` REST API or one of the following commands:
        /// 
        /// ```azurecli
        /// az sql db list-editions -l &lt;location&gt; -o table
        /// ````
        /// 
        /// ```powershell
        /// Get-AzSqlServerServiceObjective -Location &lt;location&gt;
        /// ````
        /// 
        /// </summary>
        public SqlSku Sku { get; set; }
        /// <summary> Kind of database. This is metadata used for the Azure portal experience. </summary>
        public string Kind { get; }
        /// <summary> Resource that manages the database. </summary>
        public string ManagedBy { get; }
        /// <summary> The Azure Active Directory identity of the database. </summary>
        public DatabaseIdentity Identity { get; set; }
        /// <summary>
        /// Specifies the mode of database creation.
        /// 
        /// Default: regular database creation.
        /// 
        /// Copy: creates a database as a copy of an existing database. sourceDatabaseId must be specified as the resource ID of the source database.
        /// 
        /// Secondary: creates a database as a secondary replica of an existing database. sourceDatabaseId must be specified as the resource ID of the existing primary database.
        /// 
        /// PointInTimeRestore: Creates a database by restoring a point in time backup of an existing database. sourceDatabaseId must be specified as the resource ID of the existing database, and restorePointInTime must be specified.
        /// 
        /// Recovery: Creates a database by restoring a geo-replicated backup. sourceDatabaseId must be specified as the recoverable database resource ID to restore.
        /// 
        /// Restore: Creates a database by restoring a backup of a deleted database. sourceDatabaseId must be specified. If sourceDatabaseId is the database&apos;s original resource ID, then sourceDatabaseDeletionDate must be specified. Otherwise sourceDatabaseId must be the restorable dropped database resource ID and sourceDatabaseDeletionDate is ignored. restorePointInTime may also be specified to restore from an earlier point in time.
        /// 
        /// RestoreLongTermRetentionBackup: Creates a database by restoring from a long term retention vault. recoveryServicesRecoveryPointResourceId must be specified as the recovery point resource ID.
        /// 
        /// Copy, Secondary, and RestoreLongTermRetentionBackup are not supported for DataWarehouse edition.
        /// </summary>
        public SqlDatabaseCreateMode? CreateMode { get; set; }
        /// <summary> The collation of the database. </summary>
        public string Collation { get; set; }
        /// <summary> The max size of the database expressed in bytes. </summary>
        public long? MaxSizeBytes { get; set; }
        /// <summary> The name of the sample schema to apply when creating this database. </summary>
        public SampleSchemaName? SampleName { get; set; }
        /// <summary> The resource identifier of the elastic pool containing this database. </summary>
        public ResourceIdentifier ElasticPoolId { get; set; }
        /// <summary> The resource identifier of the source database associated with create operation of this database. </summary>
        public ResourceIdentifier SourceDatabaseId { get; set; }
        /// <summary> The status of the database. </summary>
        public DatabaseStatus? Status { get; }
        /// <summary> The ID of the database. </summary>
        public Guid? DatabaseId { get; }
        /// <summary> The creation date of the database (ISO8601 format). </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The current service level objective name of the database. </summary>
        public string CurrentServiceObjectiveName { get; }
        /// <summary> The requested service level objective name of the database. </summary>
        public string RequestedServiceObjectiveName { get; }
        /// <summary> The default secondary region for this database. </summary>
        public AzureLocation? DefaultSecondaryLocation { get; }
        /// <summary> Failover Group resource identifier that this database belongs to. </summary>
        public ResourceIdentifier FailoverGroupId { get; }
        /// <summary> Specifies the time that the database was deleted. </summary>
        public DateTimeOffset? SourceDatabaseDeletedOn { get; set; }
        /// <summary> The resource identifier of the recovery point associated with create operation of this database. </summary>
        public ResourceIdentifier RecoveryServicesRecoveryPointId { get; set; }
        /// <summary> The resource identifier of the long term retention backup associated with create operation of this database. </summary>
        public ResourceIdentifier LongTermRetentionBackupResourceId { get; set; }
        /// <summary> The resource identifier of the recoverable database associated with create operation of this database. </summary>
        public ResourceIdentifier RecoverableDatabaseId { get; set; }
        /// <summary> The resource identifier of the restorable dropped database associated with create operation of this database. </summary>
        public ResourceIdentifier RestorableDroppedDatabaseId { get; set; }
        /// <summary> Collation of the metadata catalog. </summary>
        public CatalogCollationType? CatalogCollation { get; set; }
        /// <summary> Whether or not this database is zone redundant, which means the replicas of this database will be spread across multiple availability zones. </summary>
        public bool? IsZoneRedundant { get; set; }
        /// <summary> The license type to apply for this database. `LicenseIncluded` if you need a license, or `BasePrice` if you have a license and are eligible for the Azure Hybrid Benefit. </summary>
        public DatabaseLicenseType? LicenseType { get; set; }
        /// <summary> The max log size for this database. </summary>
        public long? MaxLogSizeBytes { get; }
        /// <summary> This records the earliest start date and time that restore is available for this database (ISO8601 format). </summary>
        public DateTimeOffset? EarliestRestoreOn { get; }
        /// <summary> The state of read-only routing. If enabled, connections that have application intent set to readonly in their connection string may be routed to a readonly secondary replica in the same region. Not applicable to a Hyperscale database within an elastic pool. </summary>
        public DatabaseReadScale? ReadScale { get; set; }
        /// <summary> The number of secondary replicas associated with the database that are used to provide high availability. Not applicable to a Hyperscale database within an elastic pool. </summary>
        public int? HighAvailabilityReplicaCount { get; set; }
        /// <summary> The secondary type of the database if it is a secondary.  Valid values are Geo and Named. </summary>
        public SecondaryType? SecondaryType { get; set; }
        /// <summary> The name and tier of the SKU. </summary>
        public SqlSku CurrentSku { get; }
        /// <summary> Time in minutes after which database is automatically paused. A value of -1 means that automatic pause is disabled. </summary>
        public int? AutoPauseDelay { get; set; }
        /// <summary> The storage account type used to store backups for this database. </summary>
        public BackupStorageRedundancy? CurrentBackupStorageRedundancy { get; }
        /// <summary> The storage account type to be used to store backups for this database. </summary>
        public BackupStorageRedundancy? RequestedBackupStorageRedundancy { get; set; }
        /// <summary> Minimal capacity that database will always have allocated, if not paused. </summary>
        public double? MinCapacity { get; set; }
        /// <summary> The date when database was paused by user configuration or action(ISO8601 format). Null if the database is ready. </summary>
        public DateTimeOffset? PausedOn { get; }
        /// <summary> The date when database was resumed by user action or database login (ISO8601 format). Null if the database is paused. </summary>
        public DateTimeOffset? ResumedOn { get; }
        /// <summary> Maintenance configuration id assigned to the database. This configuration defines the period when the maintenance updates will occur. </summary>
        public ResourceIdentifier MaintenanceConfigurationId { get; set; }
        /// <summary> Whether or not this database is a ledger database, which means all tables in the database are ledger tables. Note: the value of this property cannot be changed after the database has been created. </summary>
        public bool? IsLedgerOn { get; set; }
        /// <summary> Infra encryption is enabled for this database. </summary>
        public bool? IsInfraEncryptionEnabled { get; }
        /// <summary> The Client id used for cross tenant per database CMK scenario. </summary>
        public Guid? FederatedClientId { get; set; }
        /// <summary>
        /// The resource identifier of the source associated with the create operation of this database.
        /// 
        /// When sourceResourceId is specified, sourceDatabaseId, recoverableDatabaseId, restorableDroppedDatabaseId and sourceDatabaseDeletionDate must not be specified and CreateMode must be PointInTimeRestore, Restore or Recover.
        /// 
        /// When createMode is PointInTimeRestore, sourceResourceId must be the resource ID of an existing database or existing sql pool, and restorePointInTime must be specified.
        /// 
        /// When createMode is Restore, sourceResourceId must be the resource ID of restorable dropped database or restorable dropped sql pool.
        /// 
        /// When createMode is Recover, sourceResourceId must be the resource ID of recoverable database or recoverable sql pool.
        /// 
        /// This property allows to restore across subscriptions which is only supported for DataWarehouse edition.
        /// 
        /// When source subscription belongs to a different tenant than target subscription, “x-ms-authorization-auxiliary” header must contain authentication token for the source tenant. For more details about “x-ms-authorization-auxiliary” header see https://docs.microsoft.com/en-us/azure/azure-resource-manager/management/authenticate-multi-tenant 
        /// </summary>
        public ResourceIdentifier SourceResourceId { get; set; }
    }
}
