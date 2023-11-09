// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Sku of Azure Spring Apps. </summary>
    public partial class AppPlatformSku
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AppPlatformSku"/>. </summary>
        public AppPlatformSku()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppPlatformSku"/>. </summary>
        /// <param name="name"> Name of the Sku. </param>
        /// <param name="tier"> Tier of the Sku. </param>
        /// <param name="capacity"> Current capacity of the target resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppPlatformSku(string name, string tier, int? capacity, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Tier = tier;
            Capacity = capacity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name of the Sku. </summary>
        public string Name { get; set; }
        /// <summary> Tier of the Sku. </summary>
        public string Tier { get; set; }
        /// <summary> Current capacity of the target resource. </summary>
        public int? Capacity { get; set; }
    }
}
