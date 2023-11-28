// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.RecoveryServicesBackup.Models;

namespace Azure.ResourceManager.RecoveryServicesBackup
{
    /// <summary>
    /// A class representing the BackupProtectedItem data model.
    /// Base class for backup items.
    /// </summary>
    public partial class BackupProtectedItemData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="BackupProtectedItemData"/>. </summary>
        /// <param name="location"> The location. </param>
        public BackupProtectedItemData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="BackupProtectedItemData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties">
        /// ProtectedItemResource properties
        /// Please note <see cref="BackupGenericProtectedItem"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FileshareProtectedItem"/>, <see cref="IaasVmProtectedItem"/>, <see cref="VmWorkloadProtectedItem"/>, <see cref="VmWorkloadSapAseDatabaseProtectedItem"/>, <see cref="VmWorkloadSapHanaDBInstanceProtectedItem"/>, <see cref="VmWorkloadSapHanaDatabaseProtectedItem"/>, <see cref="VmWorkloadSqlDatabaseProtectedItem"/>, <see cref="DpmProtectedItem"/>, <see cref="GenericProtectedItem"/>, <see cref="MabFileFolderProtectedItem"/>, <see cref="IaasClassicComputeVmProtectedItem"/>, <see cref="IaasComputeVmProtectedItem"/> and <see cref="SqlProtectedItem"/>.
        /// </param>
        /// <param name="eTag"> Optional ETag. </param>
        internal BackupProtectedItemData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, BackupGenericProtectedItem properties, ETag? eTag) : base(id, name, resourceType, systemData, tags, location)
        {
            Properties = properties;
            ETag = eTag;
        }

        /// <summary>
        /// ProtectedItemResource properties
        /// Please note <see cref="BackupGenericProtectedItem"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FileshareProtectedItem"/>, <see cref="IaasVmProtectedItem"/>, <see cref="VmWorkloadProtectedItem"/>, <see cref="VmWorkloadSapAseDatabaseProtectedItem"/>, <see cref="VmWorkloadSapHanaDBInstanceProtectedItem"/>, <see cref="VmWorkloadSapHanaDatabaseProtectedItem"/>, <see cref="VmWorkloadSqlDatabaseProtectedItem"/>, <see cref="DpmProtectedItem"/>, <see cref="GenericProtectedItem"/>, <see cref="MabFileFolderProtectedItem"/>, <see cref="IaasClassicComputeVmProtectedItem"/>, <see cref="IaasComputeVmProtectedItem"/> and <see cref="SqlProtectedItem"/>.
        /// </summary>
        public BackupGenericProtectedItem Properties { get; set; }
        /// <summary> Optional ETag. </summary>
        public ETag? ETag { get; set; }
    }
}
