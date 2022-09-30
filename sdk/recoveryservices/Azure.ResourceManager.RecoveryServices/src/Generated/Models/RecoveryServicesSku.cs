// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> Identifies the unique system identifier for each Azure resource. </summary>
    public partial class RecoveryServicesSku
    {
        /// <summary> Initializes a new instance of RecoveryServicesSku. </summary>
        /// <param name="name"> Name of SKU is RS0 (Recovery Services 0th version) and the tier is standard tier. They do not have affect on backend storage redundancy or any other vault settings. To manage storage redundancy, use the backupstorageconfig. </param>
        public RecoveryServicesSku(RecoveryServicesSkuName name)
        {
            Name = name;
        }

        /// <summary> Initializes a new instance of RecoveryServicesSku. </summary>
        /// <param name="name"> Name of SKU is RS0 (Recovery Services 0th version) and the tier is standard tier. They do not have affect on backend storage redundancy or any other vault settings. To manage storage redundancy, use the backupstorageconfig. </param>
        /// <param name="tier"> The Sku tier. </param>
        /// <param name="family"> The sku family. </param>
        /// <param name="size"> The sku size. </param>
        /// <param name="capacity"> The sku capacity. </param>
        internal RecoveryServicesSku(RecoveryServicesSkuName name, string tier, string family, string size, string capacity)
        {
            Name = name;
            Tier = tier;
            Family = family;
            Size = size;
            Capacity = capacity;
        }

        /// <summary> Name of SKU is RS0 (Recovery Services 0th version) and the tier is standard tier. They do not have affect on backend storage redundancy or any other vault settings. To manage storage redundancy, use the backupstorageconfig. </summary>
        public RecoveryServicesSkuName Name { get; set; }
        /// <summary> The Sku tier. </summary>
        public string Tier { get; set; }
        /// <summary> The sku family. </summary>
        public string Family { get; set; }
        /// <summary> The sku size. </summary>
        public string Size { get; set; }
        /// <summary> The sku capacity. </summary>
        public string Capacity { get; set; }
    }
}
