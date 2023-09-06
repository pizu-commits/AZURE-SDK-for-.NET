// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Logic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The list of integration service environments. </summary>
    internal partial class IntegrationServiceEnvironmentListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="IntegrationServiceEnvironmentListResult"/>. </summary>
        internal IntegrationServiceEnvironmentListResult()
        {
            Value = new ChangeTrackingList<IntegrationServiceEnvironmentData>();
        }

        /// <summary> Initializes a new instance of <see cref="IntegrationServiceEnvironmentListResult"/>. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal IntegrationServiceEnvironmentListResult(IReadOnlyList<IntegrationServiceEnvironmentData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<IntegrationServiceEnvironmentData> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
