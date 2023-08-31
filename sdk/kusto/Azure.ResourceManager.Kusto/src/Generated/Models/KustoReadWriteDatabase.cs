// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Kusto;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> Class representing a read write database. </summary>
    public partial class KustoReadWriteDatabase : KustoDatabaseData
    {
        /// <summary> Initializes a new instance of <see cref="KustoReadWriteDatabase"/>. </summary>
        public KustoReadWriteDatabase()
        {
            Kind = KustoKind.ReadWrite;
        }

        /// <summary> Initializes a new instance of <see cref="KustoReadWriteDatabase"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="kind"> Kind of the database. </param>
        /// <param name="provisioningState"> The provisioned state of the resource. </param>
        /// <param name="softDeletePeriod"> The time the data should be kept before it stops being accessible to queries in TimeSpan. </param>
        /// <param name="hotCachePeriod"> The time the data should be kept in cache for fast queries in TimeSpan. </param>
        /// <param name="statistics"> The statistics of the database. </param>
        /// <param name="isFollowed"> Indicates whether the database is followed. </param>
        /// <param name="keyVaultProperties"> KeyVault properties for the database encryption. </param>
        /// <param name="suspensionDetails"> The database suspension details. If the database is suspended, this object contains information related to the database's suspension state. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal KustoReadWriteDatabase(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, KustoKind kind, KustoProvisioningState? provisioningState, TimeSpan? softDeletePeriod, TimeSpan? hotCachePeriod, DatabaseStatistics statistics, bool? isFollowed, KustoKeyVaultProperties keyVaultProperties, SuspensionDetails suspensionDetails, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, location, kind, rawData)
        {
            ProvisioningState = provisioningState;
            SoftDeletePeriod = softDeletePeriod;
            HotCachePeriod = hotCachePeriod;
            Statistics = statistics;
            IsFollowed = isFollowed;
            KeyVaultProperties = keyVaultProperties;
            SuspensionDetails = suspensionDetails;
            Kind = kind;
        }

        /// <summary> The provisioned state of the resource. </summary>
        public KustoProvisioningState? ProvisioningState { get; }
        /// <summary> The time the data should be kept before it stops being accessible to queries in TimeSpan. </summary>
        public TimeSpan? SoftDeletePeriod { get; set; }
        /// <summary> The time the data should be kept in cache for fast queries in TimeSpan. </summary>
        public TimeSpan? HotCachePeriod { get; set; }
        /// <summary> The statistics of the database. </summary>
        internal DatabaseStatistics Statistics { get; }
        /// <summary> The database size - the total size of compressed data and index in bytes. </summary>
        public float? StatisticsSize
        {
            get => Statistics?.Size;
        }

        /// <summary> Indicates whether the database is followed. </summary>
        public bool? IsFollowed { get; }
        /// <summary> KeyVault properties for the database encryption. </summary>
        public KustoKeyVaultProperties KeyVaultProperties { get; set; }
        /// <summary> The database suspension details. If the database is suspended, this object contains information related to the database's suspension state. </summary>
        internal SuspensionDetails SuspensionDetails { get; }
        /// <summary> The starting date and time of the suspension state. </summary>
        public DateTimeOffset? SuspensionStartOn
        {
            get => SuspensionDetails?.SuspensionStartOn;
        }
    }
}
