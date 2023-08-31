// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> Represents a tenant ID that is trusted by the cluster. </summary>
    public partial class KustoClusterTrustedExternalTenant
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="KustoClusterTrustedExternalTenant"/>. </summary>
        public KustoClusterTrustedExternalTenant()
        {
        }

        /// <summary> Initializes a new instance of <see cref="KustoClusterTrustedExternalTenant"/>. </summary>
        /// <param name="value"> GUID representing an external tenant. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal KustoClusterTrustedExternalTenant(string value, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            _rawData = rawData;
        }

        /// <summary> GUID representing an external tenant. </summary>
        public string Value { get; set; }
    }
}
