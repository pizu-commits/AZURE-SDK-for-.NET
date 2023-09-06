// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> A list of private link resources. </summary>
    internal partial class AutomationPrivateLinkResourceListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AutomationPrivateLinkResourceListResult"/>. </summary>
        internal AutomationPrivateLinkResourceListResult()
        {
            Value = new ChangeTrackingList<AutomationPrivateLinkResource>();
        }

        /// <summary> Initializes a new instance of <see cref="AutomationPrivateLinkResourceListResult"/>. </summary>
        /// <param name="value"> Array of private link resources. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AutomationPrivateLinkResourceListResult(IReadOnlyList<AutomationPrivateLinkResource> value, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            _rawData = rawData;
        }

        /// <summary> Array of private link resources. </summary>
        public IReadOnlyList<AutomationPrivateLinkResource> Value { get; }
    }
}
