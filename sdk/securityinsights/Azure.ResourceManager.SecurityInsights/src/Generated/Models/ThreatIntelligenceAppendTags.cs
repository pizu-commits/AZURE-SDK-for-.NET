// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Array of tags to be appended to the threat intelligence indicator. </summary>
    public partial class ThreatIntelligenceAppendTags
    {
        /// <summary> Initializes a new instance of ThreatIntelligenceAppendTags. </summary>
        public ThreatIntelligenceAppendTags()
        {
            ThreatIntelligenceTags = new ChangeTrackingList<string>();
        }

        /// <summary> List of tags to be appended. </summary>
        public IList<string> ThreatIntelligenceTags { get; }
    }
}
