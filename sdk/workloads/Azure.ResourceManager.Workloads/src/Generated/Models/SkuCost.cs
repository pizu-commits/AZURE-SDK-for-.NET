// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> The SKU cost definition. </summary>
    public partial class SkuCost
    {
        /// <summary> Initializes a new instance of SkuCost. </summary>
        internal SkuCost()
        {
        }

        /// <summary> Initializes a new instance of SkuCost. </summary>
        /// <param name="meterId"> Billing meter id. </param>
        /// <param name="quantity"> The quantity. </param>
        /// <param name="extendedUnit"> The extended unit. </param>
        internal SkuCost(string meterId, int? quantity, string extendedUnit)
        {
            MeterId = meterId;
            Quantity = quantity;
            ExtendedUnit = extendedUnit;
        }

        /// <summary> Billing meter id. </summary>
        public string MeterId { get; }
        /// <summary> The quantity. </summary>
        public int? Quantity { get; }
        /// <summary> The extended unit. </summary>
        public string ExtendedUnit { get; }
    }
}
