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
    /// A class representing the DataReplicationDra data model.
    /// Dra model.
    /// </summary>
    public partial class DataReplicationDraData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="DataReplicationDraData"/>. </summary>
        /// <param name="properties"> Dra model properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public DataReplicationDraData(DataReplicationDraProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> Initializes a new instance of <see cref="DataReplicationDraData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Dra model properties. </param>
        internal DataReplicationDraData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DataReplicationDraProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary> Dra model properties. </summary>
        public DataReplicationDraProperties Properties { get; set; }
    }
}
