// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> Azure resource SKU definition. </summary>
    public partial class KustoAvailableSkuDetails
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="KustoAvailableSkuDetails"/>. </summary>
        internal KustoAvailableSkuDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="KustoAvailableSkuDetails"/>. </summary>
        /// <param name="resourceType"> Resource Namespace and Type. </param>
        /// <param name="sku"> The SKU details. </param>
        /// <param name="capacity"> The number of instances of the cluster. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal KustoAvailableSkuDetails(string resourceType, KustoSku sku, KustoCapacity capacity, Dictionary<string, BinaryData> rawData)
        {
            ResourceType = resourceType;
            Sku = sku;
            Capacity = capacity;
            _rawData = rawData;
        }

        /// <summary> Resource Namespace and Type. </summary>
        public string ResourceType { get; }
        /// <summary> The SKU details. </summary>
        public KustoSku Sku { get; }
        /// <summary> The number of instances of the cluster. </summary>
        public KustoCapacity Capacity { get; }
    }
}
