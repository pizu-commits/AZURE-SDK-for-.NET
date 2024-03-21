// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Parameters to create and update Cosmos DB database accounts. </summary>
    public partial class CosmosDBAccountCreateOrUpdateContent : TrackedResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CosmosDBAccountCreateOrUpdateContent"/>. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="locations"> An array that contains the georeplication locations enabled for the Cosmos DB account. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="locations"/> is null. </exception>
        public CosmosDBAccountCreateOrUpdateContent(AzureLocation location, IEnumerable<CosmosDBAccountLocation> locations) : base(location)
        {
            Argument.AssertNotNull(locations, nameof(locations));

            Locations = locations.ToList();
            DatabaseAccountOfferType = CosmosDBAccountOfferType.Standard;
            IPRules = new ChangeTrackingList<CosmosDBIPAddressOrRange>();
            Capabilities = new ChangeTrackingList<CosmosDBAccountCapability>();
            VirtualNetworkRules = new ChangeTrackingList<CosmosDBVirtualNetworkRule>();
            Cors = new ChangeTrackingList<CosmosDBAccountCorsPolicy>();
            NetworkAclBypassResourceIds = new ChangeTrackingList<ResourceIdentifier>();
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBAccountCreateOrUpdateContent"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="kind"> Indicates the type of database account. This can only be set at database account creation. </param>
        /// <param name="consistencyPolicy"> The consistency policy for the Cosmos DB account. </param>
        /// <param name="locations"> An array that contains the georeplication locations enabled for the Cosmos DB account. </param>
        /// <param name="databaseAccountOfferType"> The offer type for the database. </param>
        /// <param name="ipRules"> List of IpRules. </param>
        /// <param name="isVirtualNetworkFilterEnabled"> Flag to indicate whether to enable/disable Virtual Network ACL rules. </param>
        /// <param name="enableAutomaticFailover"> Enables automatic failover of the write region in the rare event that the region is unavailable due to an outage. Automatic failover will result in a new write region for the account and is chosen based on the failover priorities configured for the account. </param>
        /// <param name="capabilities"> List of Cosmos DB capabilities for the account. </param>
        /// <param name="virtualNetworkRules"> List of Virtual Network ACL rules configured for the Cosmos DB account. </param>
        /// <param name="enableMultipleWriteLocations"> Enables the account to write in multiple locations. </param>
        /// <param name="enableCassandraConnector"> Enables the cassandra connector on the Cosmos DB C* account. </param>
        /// <param name="connectorOffer"> The cassandra connector offer type for the Cosmos DB database C* account. </param>
        /// <param name="disableKeyBasedMetadataWriteAccess"> Disable write operations on metadata resources (databases, containers, throughput) via account keys. </param>
        /// <param name="keyVaultKeyUri"> The URI of the key vault. </param>
        /// <param name="defaultIdentity"> The default identity for accessing key vault used in features like customer managed keys. The default identity needs to be explicitly set by the users. It can be "FirstPartyIdentity", "SystemAssignedIdentity" and more. </param>
        /// <param name="publicNetworkAccess"> Whether requests from Public Network are allowed. </param>
        /// <param name="isFreeTierEnabled"> Flag to indicate whether Free Tier is enabled. </param>
        /// <param name="apiProperties"> API specific properties. Currently, supported only for MongoDB API. </param>
        /// <param name="isAnalyticalStorageEnabled"> Flag to indicate whether to enable storage analytics. </param>
        /// <param name="analyticalStorageConfiguration"> Analytical storage specific properties. </param>
        /// <param name="createMode"> Enum to indicate the mode of account creation. </param>
        /// <param name="backupPolicy">
        /// The object representing the policy for taking backups on an account.
        /// Please note <see cref="CosmosDBAccountBackupPolicy"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ContinuousModeBackupPolicy"/> and <see cref="PeriodicModeBackupPolicy"/>.
        /// </param>
        /// <param name="cors"> The CORS policy for the Cosmos DB database account. </param>
        /// <param name="networkAclBypass"> Indicates what services are allowed to bypass firewall checks. </param>
        /// <param name="networkAclBypassResourceIds"> An array that contains the Resource Ids for Network Acl Bypass for the Cosmos DB account. </param>
        /// <param name="diagnosticLogSettings"> The Object representing the different Diagnostic log settings for the Cosmos DB Account. </param>
        /// <param name="disableLocalAuth"> Opt-out of local authentication and ensure only MSI and AAD can be used exclusively for authentication. </param>
        /// <param name="restoreParameters"> Parameters to indicate the information about the restore. </param>
        /// <param name="capacity"> The object that represents all properties related to capacity enforcement on an account. </param>
        /// <param name="enableMaterializedViews"> Flag to indicate whether to enable MaterializedViews on the Cosmos DB account. </param>
        /// <param name="keysMetadata"> This property is ignored during the update/create operation, as the metadata is read-only. The object represents the metadata for the Account Keys of the Cosmos DB account. </param>
        /// <param name="enablePartitionMerge"> Flag to indicate enabling/disabling of Partition Merge feature on the account. </param>
        /// <param name="enableBurstCapacity"> Flag to indicate enabling/disabling of Burst Capacity Preview feature on the account. </param>
        /// <param name="minimalTlsVersion"> Indicates the minimum allowed Tls version. The default is Tls 1.0, except for Cassandra and Mongo API's, which only work with Tls 1.2. </param>
        /// <param name="customerManagedKeyStatus"> Indicates the status of the Customer Managed Key feature on the account. In case there are errors, the property provides troubleshooting guidance. </param>
        /// <param name="enablePriorityBasedExecution"> Flag to indicate enabling/disabling of Priority Based Execution Preview feature on the account. </param>
        /// <param name="defaultPriorityLevel"> Enum to indicate default Priority Level of request for Priority Based Execution. </param>
        /// <param name="identity"> Identity for the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CosmosDBAccountCreateOrUpdateContent(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, CosmosDBAccountKind? kind, ConsistencyPolicy consistencyPolicy, IList<CosmosDBAccountLocation> locations, CosmosDBAccountOfferType databaseAccountOfferType, IList<CosmosDBIPAddressOrRange> ipRules, bool? isVirtualNetworkFilterEnabled, bool? enableAutomaticFailover, IList<CosmosDBAccountCapability> capabilities, IList<CosmosDBVirtualNetworkRule> virtualNetworkRules, bool? enableMultipleWriteLocations, bool? enableCassandraConnector, ConnectorOffer? connectorOffer, bool? disableKeyBasedMetadataWriteAccess, Uri keyVaultKeyUri, string defaultIdentity, CosmosDBPublicNetworkAccess? publicNetworkAccess, bool? isFreeTierEnabled, ApiProperties apiProperties, bool? isAnalyticalStorageEnabled, AnalyticalStorageConfiguration analyticalStorageConfiguration, CosmosDBAccountCreateMode? createMode, CosmosDBAccountBackupPolicy backupPolicy, IList<CosmosDBAccountCorsPolicy> cors, NetworkAclBypass? networkAclBypass, IList<ResourceIdentifier> networkAclBypassResourceIds, DiagnosticLogSettings diagnosticLogSettings, bool? disableLocalAuth, CosmosDBAccountRestoreParameters restoreParameters, CosmosDBAccountCapacity capacity, bool? enableMaterializedViews, DatabaseAccountKeysMetadata keysMetadata, bool? enablePartitionMerge, bool? enableBurstCapacity, CosmosDBMinimalTlsVersion? minimalTlsVersion, CustomerManagedKeyStatus? customerManagedKeyStatus, bool? enablePriorityBasedExecution, DefaultPriorityLevel? defaultPriorityLevel, ManagedServiceIdentity identity, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Kind = kind;
            ConsistencyPolicy = consistencyPolicy;
            Locations = locations;
            DatabaseAccountOfferType = databaseAccountOfferType;
            IPRules = ipRules;
            IsVirtualNetworkFilterEnabled = isVirtualNetworkFilterEnabled;
            EnableAutomaticFailover = enableAutomaticFailover;
            Capabilities = capabilities;
            VirtualNetworkRules = virtualNetworkRules;
            EnableMultipleWriteLocations = enableMultipleWriteLocations;
            EnableCassandraConnector = enableCassandraConnector;
            ConnectorOffer = connectorOffer;
            DisableKeyBasedMetadataWriteAccess = disableKeyBasedMetadataWriteAccess;
            KeyVaultKeyUri = keyVaultKeyUri;
            DefaultIdentity = defaultIdentity;
            PublicNetworkAccess = publicNetworkAccess;
            IsFreeTierEnabled = isFreeTierEnabled;
            ApiProperties = apiProperties;
            IsAnalyticalStorageEnabled = isAnalyticalStorageEnabled;
            AnalyticalStorageConfiguration = analyticalStorageConfiguration;
            CreateMode = createMode;
            BackupPolicy = backupPolicy;
            Cors = cors;
            NetworkAclBypass = networkAclBypass;
            NetworkAclBypassResourceIds = networkAclBypassResourceIds;
            DiagnosticLogSettings = diagnosticLogSettings;
            DisableLocalAuth = disableLocalAuth;
            RestoreParameters = restoreParameters;
            Capacity = capacity;
            EnableMaterializedViews = enableMaterializedViews;
            KeysMetadata = keysMetadata;
            EnablePartitionMerge = enablePartitionMerge;
            EnableBurstCapacity = enableBurstCapacity;
            MinimalTlsVersion = minimalTlsVersion;
            CustomerManagedKeyStatus = customerManagedKeyStatus;
            EnablePriorityBasedExecution = enablePriorityBasedExecution;
            DefaultPriorityLevel = defaultPriorityLevel;
            Identity = identity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBAccountCreateOrUpdateContent"/> for deserialization. </summary>
        internal CosmosDBAccountCreateOrUpdateContent()
        {
        }

        /// <summary> Indicates the type of database account. This can only be set at database account creation. </summary>
        public CosmosDBAccountKind? Kind { get; set; }
        /// <summary> The consistency policy for the Cosmos DB account. </summary>
        public ConsistencyPolicy ConsistencyPolicy { get; set; }
        /// <summary> An array that contains the georeplication locations enabled for the Cosmos DB account. </summary>
        public IList<CosmosDBAccountLocation> Locations { get; }
        /// <summary> List of IpRules. </summary>
        public IList<CosmosDBIPAddressOrRange> IPRules { get; }
        /// <summary> Flag to indicate whether to enable/disable Virtual Network ACL rules. </summary>
        public bool? IsVirtualNetworkFilterEnabled { get; set; }
        /// <summary> Enables automatic failover of the write region in the rare event that the region is unavailable due to an outage. Automatic failover will result in a new write region for the account and is chosen based on the failover priorities configured for the account. </summary>
        public bool? EnableAutomaticFailover { get; set; }
        /// <summary> List of Cosmos DB capabilities for the account. </summary>
        public IList<CosmosDBAccountCapability> Capabilities { get; }
        /// <summary> List of Virtual Network ACL rules configured for the Cosmos DB account. </summary>
        public IList<CosmosDBVirtualNetworkRule> VirtualNetworkRules { get; }
        /// <summary> Enables the account to write in multiple locations. </summary>
        public bool? EnableMultipleWriteLocations { get; set; }
        /// <summary> Enables the cassandra connector on the Cosmos DB C* account. </summary>
        public bool? EnableCassandraConnector { get; set; }
        /// <summary> The cassandra connector offer type for the Cosmos DB database C* account. </summary>
        public ConnectorOffer? ConnectorOffer { get; set; }
        /// <summary> Disable write operations on metadata resources (databases, containers, throughput) via account keys. </summary>
        public bool? DisableKeyBasedMetadataWriteAccess { get; set; }
        /// <summary> The URI of the key vault. </summary>
        public Uri KeyVaultKeyUri { get; set; }
        /// <summary> The default identity for accessing key vault used in features like customer managed keys. The default identity needs to be explicitly set by the users. It can be "FirstPartyIdentity", "SystemAssignedIdentity" and more. </summary>
        public string DefaultIdentity { get; set; }
        /// <summary> Whether requests from Public Network are allowed. </summary>
        public CosmosDBPublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> Flag to indicate whether Free Tier is enabled. </summary>
        public bool? IsFreeTierEnabled { get; set; }
        /// <summary> API specific properties. Currently, supported only for MongoDB API. </summary>
        internal ApiProperties ApiProperties { get; set; }
        /// <summary> Describes the ServerVersion of an a MongoDB account. </summary>
        public CosmosDBServerVersion? ApiServerVersion
        {
            get => ApiProperties is null ? default : ApiProperties.ServerVersion;
            set
            {
                if (ApiProperties is null)
                    ApiProperties = new ApiProperties();
                ApiProperties.ServerVersion = value;
            }
        }

        /// <summary> Flag to indicate whether to enable storage analytics. </summary>
        public bool? IsAnalyticalStorageEnabled { get; set; }
        /// <summary> Analytical storage specific properties. </summary>
        internal AnalyticalStorageConfiguration AnalyticalStorageConfiguration { get; set; }
        /// <summary> Describes the types of schema for analytical storage. </summary>
        public AnalyticalStorageSchemaType? AnalyticalStorageSchemaType
        {
            get => AnalyticalStorageConfiguration is null ? default : AnalyticalStorageConfiguration.SchemaType;
            set
            {
                if (AnalyticalStorageConfiguration is null)
                    AnalyticalStorageConfiguration = new AnalyticalStorageConfiguration();
                AnalyticalStorageConfiguration.SchemaType = value;
            }
        }

        /// <summary> Enum to indicate the mode of account creation. </summary>
        public CosmosDBAccountCreateMode? CreateMode { get; set; }
        /// <summary>
        /// The object representing the policy for taking backups on an account.
        /// Please note <see cref="CosmosDBAccountBackupPolicy"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ContinuousModeBackupPolicy"/> and <see cref="PeriodicModeBackupPolicy"/>.
        /// </summary>
        public CosmosDBAccountBackupPolicy BackupPolicy { get; set; }
        /// <summary> The CORS policy for the Cosmos DB database account. </summary>
        public IList<CosmosDBAccountCorsPolicy> Cors { get; }
        /// <summary> Indicates what services are allowed to bypass firewall checks. </summary>
        public NetworkAclBypass? NetworkAclBypass { get; set; }
        /// <summary> An array that contains the Resource Ids for Network Acl Bypass for the Cosmos DB account. </summary>
        public IList<ResourceIdentifier> NetworkAclBypassResourceIds { get; }
        /// <summary> The Object representing the different Diagnostic log settings for the Cosmos DB Account. </summary>
        internal DiagnosticLogSettings DiagnosticLogSettings { get; set; }
        /// <summary> Describe the level of detail with which queries are to be logged. </summary>
        public EnableFullTextQuery? DiagnosticLogEnableFullTextQuery
        {
            get => DiagnosticLogSettings is null ? default : DiagnosticLogSettings.EnableFullTextQuery;
            set
            {
                if (DiagnosticLogSettings is null)
                    DiagnosticLogSettings = new DiagnosticLogSettings();
                DiagnosticLogSettings.EnableFullTextQuery = value;
            }
        }

        /// <summary> Opt-out of local authentication and ensure only MSI and AAD can be used exclusively for authentication. </summary>
        public bool? DisableLocalAuth { get; set; }
        /// <summary> Parameters to indicate the information about the restore. </summary>
        public CosmosDBAccountRestoreParameters RestoreParameters { get; set; }
        /// <summary> The object that represents all properties related to capacity enforcement on an account. </summary>
        internal CosmosDBAccountCapacity Capacity { get; set; }
        /// <summary> The total throughput limit imposed on the account. A totalThroughputLimit of 2000 imposes a strict limit of max throughput that can be provisioned on that account to be 2000. A totalThroughputLimit of -1 indicates no limits on provisioning of throughput. </summary>
        public int? CapacityTotalThroughputLimit
        {
            get => Capacity is null ? default : Capacity.TotalThroughputLimit;
            set
            {
                if (Capacity is null)
                    Capacity = new CosmosDBAccountCapacity();
                Capacity.TotalThroughputLimit = value;
            }
        }

        /// <summary> Flag to indicate whether to enable MaterializedViews on the Cosmos DB account. </summary>
        public bool? EnableMaterializedViews { get; set; }
        /// <summary> This property is ignored during the update/create operation, as the metadata is read-only. The object represents the metadata for the Account Keys of the Cosmos DB account. </summary>
        public DatabaseAccountKeysMetadata KeysMetadata { get; }
        /// <summary> Flag to indicate enabling/disabling of Partition Merge feature on the account. </summary>
        public bool? EnablePartitionMerge { get; set; }
        /// <summary> Flag to indicate enabling/disabling of Burst Capacity Preview feature on the account. </summary>
        public bool? EnableBurstCapacity { get; set; }
        /// <summary> Indicates the minimum allowed Tls version. The default is Tls 1.0, except for Cassandra and Mongo API's, which only work with Tls 1.2. </summary>
        public CosmosDBMinimalTlsVersion? MinimalTlsVersion { get; set; }
        /// <summary> Indicates the status of the Customer Managed Key feature on the account. In case there are errors, the property provides troubleshooting guidance. </summary>
        public CustomerManagedKeyStatus? CustomerManagedKeyStatus { get; set; }
        /// <summary> Flag to indicate enabling/disabling of Priority Based Execution Preview feature on the account. </summary>
        public bool? EnablePriorityBasedExecution { get; set; }
        /// <summary> Enum to indicate default Priority Level of request for Priority Based Execution. </summary>
        public DefaultPriorityLevel? DefaultPriorityLevel { get; set; }
        /// <summary> Identity for the resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
    }
}
