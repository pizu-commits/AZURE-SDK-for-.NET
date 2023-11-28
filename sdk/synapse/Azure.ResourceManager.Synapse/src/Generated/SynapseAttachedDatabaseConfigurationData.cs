// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A class representing the SynapseAttachedDatabaseConfiguration data model.
    /// Class representing an attached database configuration.
    /// </summary>
    public partial class SynapseAttachedDatabaseConfigurationData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="SynapseAttachedDatabaseConfigurationData"/>. </summary>
        public SynapseAttachedDatabaseConfigurationData()
        {
            AttachedDatabaseNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="SynapseAttachedDatabaseConfigurationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="provisioningState"> The provisioned state of the resource. </param>
        /// <param name="databaseName"> The name of the database which you would like to attach, use * if you want to follow all current and future databases. </param>
        /// <param name="kustoPoolResourceId"> The resource id of the kusto pool where the databases you would like to attach reside. </param>
        /// <param name="attachedDatabaseNames"> The list of databases from the clusterResourceId which are currently attached to the kusto pool. </param>
        /// <param name="defaultPrincipalsModificationKind"> The default principals modification kind. </param>
        /// <param name="tableLevelSharingProperties"> Table level sharing specifications. </param>
        internal SynapseAttachedDatabaseConfigurationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, ResourceProvisioningState? provisioningState, string databaseName, ResourceIdentifier kustoPoolResourceId, IReadOnlyList<string> attachedDatabaseNames, SynapseDefaultPrincipalsModificationKind? defaultPrincipalsModificationKind, SynapseTableLevelSharingProperties tableLevelSharingProperties) : base(id, name, resourceType, systemData)
        {
            Location = location;
            ProvisioningState = provisioningState;
            DatabaseName = databaseName;
            KustoPoolResourceId = kustoPoolResourceId;
            AttachedDatabaseNames = attachedDatabaseNames;
            DefaultPrincipalsModificationKind = defaultPrincipalsModificationKind;
            TableLevelSharingProperties = tableLevelSharingProperties;
        }

        /// <summary> Resource location. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> The provisioned state of the resource. </summary>
        public ResourceProvisioningState? ProvisioningState { get; }
        /// <summary> The name of the database which you would like to attach, use * if you want to follow all current and future databases. </summary>
        public string DatabaseName { get; set; }
        /// <summary> The resource id of the kusto pool where the databases you would like to attach reside. </summary>
        public ResourceIdentifier KustoPoolResourceId { get; set; }
        /// <summary> The list of databases from the clusterResourceId which are currently attached to the kusto pool. </summary>
        public IReadOnlyList<string> AttachedDatabaseNames { get; }
        /// <summary> The default principals modification kind. </summary>
        public SynapseDefaultPrincipalsModificationKind? DefaultPrincipalsModificationKind { get; set; }
        /// <summary> Table level sharing specifications. </summary>
        public SynapseTableLevelSharingProperties TableLevelSharingProperties { get; set; }
    }
}
