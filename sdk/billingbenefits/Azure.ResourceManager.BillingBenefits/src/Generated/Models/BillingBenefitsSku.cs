// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.BillingBenefits.Models
{
    /// <summary> The SKU to be applied for this resource. </summary>
    public partial class BillingBenefitsSku
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BillingBenefitsSku"/>. </summary>
        public BillingBenefitsSku()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BillingBenefitsSku"/>. </summary>
        /// <param name="name"> Name of the SKU to be applied. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BillingBenefitsSku(string name, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            _rawData = rawData;
        }

        /// <summary> Name of the SKU to be applied. </summary>
        public string Name { get; set; }
    }
}
