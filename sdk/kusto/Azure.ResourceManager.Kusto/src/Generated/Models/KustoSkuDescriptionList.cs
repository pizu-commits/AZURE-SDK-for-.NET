// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> The list of the EngagementFabric SKU descriptions. </summary>
    internal partial class KustoSkuDescriptionList
    {
        /// <summary> Initializes a new instance of KustoSkuDescriptionList. </summary>
        internal KustoSkuDescriptionList()
        {
            Value = new Core.ChangeTrackingList<KustoSkuDescription>();
        }

        /// <summary> Initializes a new instance of KustoSkuDescriptionList. </summary>
        /// <param name="value"> SKU descriptions. </param>
        internal KustoSkuDescriptionList(IReadOnlyList<KustoSkuDescription> value)
        {
            Value = value;
        }

        /// <summary> SKU descriptions. </summary>
        public IReadOnlyList<KustoSkuDescription> Value { get; }
    }
}
