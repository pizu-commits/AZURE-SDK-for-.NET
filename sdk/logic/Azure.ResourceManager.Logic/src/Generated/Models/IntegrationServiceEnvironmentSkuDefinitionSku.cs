// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The sku. </summary>
    public partial class IntegrationServiceEnvironmentSkuDefinitionSku
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="IntegrationServiceEnvironmentSkuDefinitionSku"/>. </summary>
        internal IntegrationServiceEnvironmentSkuDefinitionSku()
        {
        }

        /// <summary> Initializes a new instance of <see cref="IntegrationServiceEnvironmentSkuDefinitionSku"/>. </summary>
        /// <param name="name"> The sku name. </param>
        /// <param name="tier"> The sku tier. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal IntegrationServiceEnvironmentSkuDefinitionSku(IntegrationServiceEnvironmentSkuName? name, string tier, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            Tier = tier;
            _rawData = rawData;
        }

        /// <summary> The sku name. </summary>
        public IntegrationServiceEnvironmentSkuName? Name { get; }
        /// <summary> The sku tier. </summary>
        public string Tier { get; }
    }
}
