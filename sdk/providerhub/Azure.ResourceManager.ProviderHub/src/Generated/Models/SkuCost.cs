// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The SkuCost. </summary>
    public partial class SkuCost
    {
        /// <summary> Initializes a new instance of SkuCost. </summary>
        /// <param name="meterId"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="meterId"/> is null. </exception>
        public SkuCost(string meterId)
        {
            if (meterId == null)
            {
                throw new ArgumentNullException(nameof(meterId));
            }

            MeterId = meterId;
        }

        /// <summary> Initializes a new instance of SkuCost. </summary>
        /// <param name="meterId"></param>
        /// <param name="quantity"></param>
        /// <param name="extendedUnit"></param>
        internal SkuCost(string meterId, int? quantity, string extendedUnit)
        {
            MeterId = meterId;
            Quantity = quantity;
            ExtendedUnit = extendedUnit;
        }

        /// <summary> Gets or sets the meter id. </summary>
        public string MeterId { get; set; }
        /// <summary> Gets or sets the quantity. </summary>
        public int? Quantity { get; set; }
        /// <summary> Gets or sets the extended unit. </summary>
        public string ExtendedUnit { get; set; }
    }
}
