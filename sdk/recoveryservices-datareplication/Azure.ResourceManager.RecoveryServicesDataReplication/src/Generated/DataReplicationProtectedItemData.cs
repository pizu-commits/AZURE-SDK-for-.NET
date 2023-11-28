// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.RecoveryServicesDataReplication.Models;

namespace Azure.ResourceManager.RecoveryServicesDataReplication
{
    /// <summary>
    /// A class representing the DataReplicationProtectedItem data model.
    /// Protected item model.
    /// </summary>
    public partial class DataReplicationProtectedItemData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="DataReplicationProtectedItemData"/>. </summary>
        /// <param name="properties"> Protected item model properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public DataReplicationProtectedItemData(DataReplicationProtectedItemProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> Initializes a new instance of <see cref="DataReplicationProtectedItemData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Protected item model properties. </param>
        internal DataReplicationProtectedItemData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DataReplicationProtectedItemProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary> Protected item model properties. </summary>
        public DataReplicationProtectedItemProperties Properties { get; set; }
    }
}
