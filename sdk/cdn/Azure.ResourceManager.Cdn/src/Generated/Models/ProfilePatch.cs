// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Properties required to update a profile. </summary>
    public partial class ProfilePatch
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ProfilePatch"/>. </summary>
        public ProfilePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="ProfilePatch"/>. </summary>
        /// <param name="tags"> Profile tags. </param>
        /// <param name="originResponseTimeoutSeconds"> Send and receive timeout on forwarding request to the origin. When timeout is reached, the request fails and returns. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ProfilePatch(IDictionary<string, string> tags, int? originResponseTimeoutSeconds, Dictionary<string, BinaryData> rawData)
        {
            Tags = tags;
            OriginResponseTimeoutSeconds = originResponseTimeoutSeconds;
            _rawData = rawData;
        }

        /// <summary> Profile tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Send and receive timeout on forwarding request to the origin. When timeout is reached, the request fails and returns. </summary>
        public int? OriginResponseTimeoutSeconds { get; set; }
    }
}
