// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> HTTP Live Streaming (HLS) packing setting for the live output. </summary>
    internal partial class Hls
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="Hls"/>. </summary>
        public Hls()
        {
        }

        /// <summary> Initializes a new instance of <see cref="Hls"/>. </summary>
        /// <param name="fragmentsPerTsSegment"> The number of fragments in an HTTP Live Streaming (HLS) TS segment in the output of the live event. This value does not affect the packing ratio for HLS CMAF output. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal Hls(int? fragmentsPerTsSegment, Dictionary<string, BinaryData> rawData)
        {
            FragmentsPerTsSegment = fragmentsPerTsSegment;
            _rawData = rawData;
        }

        /// <summary> The number of fragments in an HTTP Live Streaming (HLS) TS segment in the output of the live event. This value does not affect the packing ratio for HLS CMAF output. </summary>
        public int? FragmentsPerTsSegment { get; set; }
    }
}
