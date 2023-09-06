// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The list of integration service environment skus. </summary>
    internal partial class IntegrationServiceEnvironmentSkuList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="IntegrationServiceEnvironmentSkuList"/>. </summary>
        internal IntegrationServiceEnvironmentSkuList()
        {
            Value = new ChangeTrackingList<IntegrationServiceEnvironmentSkuDefinition>();
        }

        /// <summary> Initializes a new instance of <see cref="IntegrationServiceEnvironmentSkuList"/>. </summary>
        /// <param name="value"> The list of integration service environment skus. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal IntegrationServiceEnvironmentSkuList(IReadOnlyList<IntegrationServiceEnvironmentSkuDefinition> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> The list of integration service environment skus. </summary>
        public IReadOnlyList<IntegrationServiceEnvironmentSkuDefinition> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
