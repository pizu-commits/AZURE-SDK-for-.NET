// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Class to specify properties of content key. </summary>
    public partial class StreamingPolicyContentKey
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="StreamingPolicyContentKey"/>. </summary>
        public StreamingPolicyContentKey()
        {
            Tracks = new ChangeTrackingList<MediaTrackSelection>();
        }

        /// <summary> Initializes a new instance of <see cref="StreamingPolicyContentKey"/>. </summary>
        /// <param name="label"> Label can be used to specify Content Key when creating a Streaming Locator. </param>
        /// <param name="policyName"> Policy used by Content Key. </param>
        /// <param name="tracks"> Tracks which use this content key. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal StreamingPolicyContentKey(string label, string policyName, IList<MediaTrackSelection> tracks, Dictionary<string, BinaryData> rawData)
        {
            Label = label;
            PolicyName = policyName;
            Tracks = tracks;
            _rawData = rawData;
        }

        /// <summary> Label can be used to specify Content Key when creating a Streaming Locator. </summary>
        public string Label { get; set; }
        /// <summary> Policy used by Content Key. </summary>
        public string PolicyName { get; set; }
        /// <summary> Tracks which use this content key. </summary>
        public IList<MediaTrackSelection> Tracks { get; }
    }
}
