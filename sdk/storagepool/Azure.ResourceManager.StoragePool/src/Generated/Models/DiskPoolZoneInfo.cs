// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.StoragePool.Models
{
    /// <summary> Disk Pool SKU Details. </summary>
    public partial class DiskPoolZoneInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DiskPoolZoneInfo"/>. </summary>
        internal DiskPoolZoneInfo()
        {
            AvailabilityZones = new ChangeTrackingList<string>();
            AdditionalCapabilities = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="DiskPoolZoneInfo"/>. </summary>
        /// <param name="availabilityZones"> Logical zone for Disk Pool resource; example: ["1"]. </param>
        /// <param name="additionalCapabilities"> List of additional capabilities for Disk Pool. </param>
        /// <param name="sku"> Determines the SKU of VM deployed for Disk Pool. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DiskPoolZoneInfo(IReadOnlyList<string> availabilityZones, IReadOnlyList<string> additionalCapabilities, StoragePoolSku sku, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AvailabilityZones = availabilityZones;
            AdditionalCapabilities = additionalCapabilities;
            Sku = sku;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Logical zone for Disk Pool resource; example: ["1"]. </summary>
        public IReadOnlyList<string> AvailabilityZones { get; }
        /// <summary> List of additional capabilities for Disk Pool. </summary>
        public IReadOnlyList<string> AdditionalCapabilities { get; }
        /// <summary> Determines the SKU of VM deployed for Disk Pool. </summary>
        public StoragePoolSku Sku { get; }
    }
}
