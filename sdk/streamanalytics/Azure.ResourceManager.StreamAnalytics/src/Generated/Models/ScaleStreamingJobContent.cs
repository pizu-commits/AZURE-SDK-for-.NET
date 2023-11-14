// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> Parameters supplied to the Scale Streaming Job operation. </summary>
    public partial class ScaleStreamingJobContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ScaleStreamingJobContent"/>. </summary>
        public ScaleStreamingJobContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ScaleStreamingJobContent"/>. </summary>
        /// <param name="streamingUnits"> Specifies the number of streaming units that the streaming job will scale to. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ScaleStreamingJobContent(int? streamingUnits, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            StreamingUnits = streamingUnits;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Specifies the number of streaming units that the streaming job will scale to. </summary>
        public int? StreamingUnits { get; set; }
    }
}
