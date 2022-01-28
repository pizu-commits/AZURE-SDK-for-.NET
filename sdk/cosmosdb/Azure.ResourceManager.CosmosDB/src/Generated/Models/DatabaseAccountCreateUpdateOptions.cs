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
    public partial class DatabaseAccountCreateUpdateOptions : TrackedResource
    {
        /// <summary> Initializes a new instance of DatabaseAccountCreateUpdateOptions. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="locations"> An array that contains the georeplication locations enabled for the Cosmos DB account. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="locations"/> is null. </exception>
        public DatabaseAccountCreateUpdateOptions(AzureLocation location, IEnumerable<DatabaseAccountLocation> locations) : base(location)
        {
            if (locations == null)
            {
                throw new ArgumentNullException(nameof(locations));
            }

            Locations = locations.ToList();
            DatabaseAccountOfferType = "Standard";
            IpRules = new ChangeTrackingList<IpAddressOrRange>();
            Capabilities = new ChangeTrackingList<DatabaseAccountCapability>();
            VirtualNetworkRules = new ChangeTrackingList<VirtualNetworkRule>();
            Cors = new ChangeTrackingList<CorsPolicy>();
            NetworkAclBypassResourceIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of DatabaseAccountCreateUpdateOptions. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="kind"> Indicates the type of database account. This can only be set at database account creation. </param>
        /// <param name="identity"> Identity for the resource. </param>
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
        /// <param name="defaultIdentity"> The default identity for accessing key vault used in features like customer managed keys. The default identity needs to be explicitly set by the users. It can be &quot;FirstPartyIdentity&quot;, &quot;SystemAssignedIdentity&quot; and more. </param>
        /// <param name="publicNetworkAccess"> Whether requests from Public Network are allowed. </param>
        /// <param name="enableFreeTier"> Flag to indicate whether Free Tier is enabled. </param>
        /// <param name="apiProperties"> API specific properties. Currently, supported only for MongoDB API. </param>
        /// <param name="enableAnalyticalStorage"> Flag to indicate whether to enable storage analytics. </param>
        /// <param name="analyticalStorageConfiguration"> Analytical storage specific properties. </param>
        /// <param name="createMode"> Enum to indicate the mode of account creation. </param>
        /// <param name="backupPolicy"> The object representing the policy for taking backups on an account. </param>
        /// <param name="cors"> The CORS policy for the Cosmos DB database account. </param>
        /// <param name="networkAclBypass"> Indicates what services are allowed to bypass firewall checks. </param>
        /// <param name="networkAclBypassResourceIds"> An array that contains the Resource Ids for Network Acl Bypass for the Cosmos DB account. </param>
        /// <param name="disableLocalAuth"> Opt-out of local authentication and ensure only MSI and AAD can be used exclusively for authentication. </param>
        /// <param name="restoreParameters"> Parameters to indicate the information about the restore. </param>
        internal DatabaseAccountCreateUpdateOptions(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, DatabaseAccountKind? kind, ManagedServiceIdentity identity, ConsistencyPolicy consistencyPolicy, IList<DatabaseAccountLocation> locations, string databaseAccountOfferType, IList<IpAddressOrRange> ipRules, bool? isVirtualNetworkFilterEnabled, bool? enableAutomaticFailover, IList<DatabaseAccountCapability> capabilities, IList<VirtualNetworkRule> virtualNetworkRules, bool? enableMultipleWriteLocations, bool? enableCassandraConnector, ConnectorOffer? connectorOffer, bool? disableKeyBasedMetadataWriteAccess, string keyVaultKeyUri, string defaultIdentity, PublicNetworkAccess? publicNetworkAccess, bool? enableFreeTier, ApiProperties apiProperties, bool? enableAnalyticalStorage, AnalyticalStorageConfiguration analyticalStorageConfiguration, CreateMode? createMode, BackupPolicy backupPolicy, IList<CorsPolicy> cors, NetworkAclBypass? networkAclBypass, IList<string> networkAclBypassResourceIds, bool? disableLocalAuth, RestoreParameters restoreParameters) : base(id, name, type, systemData, tags, location)
        {
            Kind = kind;
            Identity = identity;
            ConsistencyPolicy = consistencyPolicy;
            Locations = locations;
            DatabaseAccountOfferType = databaseAccountOfferType;
            IpRules = ipRules;
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
            EnableFreeTier = enableFreeTier;
            ApiProperties = apiProperties;
            EnableAnalyticalStorage = enableAnalyticalStorage;
            AnalyticalStorageConfiguration = analyticalStorageConfiguration;
            CreateMode = createMode;
            BackupPolicy = backupPolicy;
            Cors = cors;
            NetworkAclBypass = networkAclBypass;
            NetworkAclBypassResourceIds = networkAclBypassResourceIds;
            DisableLocalAuth = disableLocalAuth;
            RestoreParameters = restoreParameters;
        }

        /// <summary> Indicates the type of database account. This can only be set at database account creation. </summary>
        public DatabaseAccountKind? Kind { get; set; }
        /// <summary> Identity for the resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The consistency policy for the Cosmos DB account. </summary>
        public ConsistencyPolicy ConsistencyPolicy { get; set; }
        /// <summary> An array that contains the georeplication locations enabled for the Cosmos DB account. </summary>
        public IList<DatabaseAccountLocation> Locations { get; }
        /// <summary> The offer type for the database. </summary>
        public string DatabaseAccountOfferType { get; set; }
        /// <summary> List of IpRules. </summary>
        public IList<IpAddressOrRange> IpRules { get; }
        /// <summary> Flag to indicate whether to enable/disable Virtual Network ACL rules. </summary>
        public bool? IsVirtualNetworkFilterEnabled { get; set; }
        /// <summary> Enables automatic failover of the write region in the rare event that the region is unavailable due to an outage. Automatic failover will result in a new write region for the account and is chosen based on the failover priorities configured for the account. </summary>
        public bool? EnableAutomaticFailover { get; set; }
        /// <summary> List of Cosmos DB capabilities for the account. </summary>
        public IList<DatabaseAccountCapability> Capabilities { get; }
        /// <summary> List of Virtual Network ACL rules configured for the Cosmos DB account. </summary>
        public IList<VirtualNetworkRule> VirtualNetworkRules { get; }
        /// <summary> Enables the account to write in multiple locations. </summary>
        public bool? EnableMultipleWriteLocations { get; set; }
        /// <summary> Enables the cassandra connector on the Cosmos DB C* account. </summary>
        public bool? EnableCassandraConnector { get; set; }
        /// <summary> The cassandra connector offer type for the Cosmos DB database C* account. </summary>
        public ConnectorOffer? ConnectorOffer { get; set; }
        /// <summary> Disable write operations on metadata resources (databases, containers, throughput) via account keys. </summary>
        public bool? DisableKeyBasedMetadataWriteAccess { get; set; }
        /// <summary> The URI of the key vault. </summary>
        public string KeyVaultKeyUri { get; set; }
        /// <summary> The default identity for accessing key vault used in features like customer managed keys. The default identity needs to be explicitly set by the users. It can be &quot;FirstPartyIdentity&quot;, &quot;SystemAssignedIdentity&quot; and more. </summary>
        public string DefaultIdentity { get; set; }
        /// <summary> Whether requests from Public Network are allowed. </summary>
        public PublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> Flag to indicate whether Free Tier is enabled. </summary>
        public bool? EnableFreeTier { get; set; }
        /// <summary> API specific properties. Currently, supported only for MongoDB API. </summary>
        public ApiProperties ApiProperties { get; set; }
        /// <summary> Flag to indicate whether to enable storage analytics. </summary>
        public bool? EnableAnalyticalStorage { get; set; }
        /// <summary> Analytical storage specific properties. </summary>
        public AnalyticalStorageConfiguration AnalyticalStorageConfiguration { get; set; }
        /// <summary> Enum to indicate the mode of account creation. </summary>
        public CreateMode? CreateMode { get; set; }
        /// <summary> The object representing the policy for taking backups on an account. </summary>
        public BackupPolicy BackupPolicy { get; set; }
        /// <summary> The CORS policy for the Cosmos DB database account. </summary>
        public IList<CorsPolicy> Cors { get; }
        /// <summary> Indicates what services are allowed to bypass firewall checks. </summary>
        public NetworkAclBypass? NetworkAclBypass { get; set; }
        /// <summary> An array that contains the Resource Ids for Network Acl Bypass for the Cosmos DB account. </summary>
        public IList<string> NetworkAclBypassResourceIds { get; }
        /// <summary> Opt-out of local authentication and ensure only MSI and AAD can be used exclusively for authentication. </summary>
        public bool? DisableLocalAuth { get; set; }
        /// <summary> Parameters to indicate the information about the restore. </summary>
        public RestoreParameters RestoreParameters { get; set; }
    }
}
