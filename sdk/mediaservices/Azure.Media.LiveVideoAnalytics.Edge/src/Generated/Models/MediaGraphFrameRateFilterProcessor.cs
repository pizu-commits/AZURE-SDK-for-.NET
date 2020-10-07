// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Media.LiveVideoAnalytics.Edge.Models
{
    /// <summary> Limits the frame rate on the input video stream based on the maximumFps property. </summary>
    public partial class MediaGraphFrameRateFilterProcessor : MediaGraphProcessor
    {
        /// <summary> Initializes a new instance of MediaGraphFrameRateFilterProcessor. </summary>
        /// <param name="name"> The name for this processor node. </param>
        /// <param name="inputs"> An array of the names of the other nodes in the media graph, the outputs of which are used as input for this processor node. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="inputs"/> is null. </exception>
        public MediaGraphFrameRateFilterProcessor(string name, IEnumerable<MediaGraphNodeInput> inputs) : base(name, inputs)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (inputs == null)
            {
                throw new ArgumentNullException(nameof(inputs));
            }

            Type = "#Microsoft.Media.MediaGraphFrameRateFilterProcessor";
        }

        /// <summary> Initializes a new instance of MediaGraphFrameRateFilterProcessor. </summary>
        /// <param name="type"> The discriminator for derived types. </param>
        /// <param name="name"> The name for this processor node. </param>
        /// <param name="inputs"> An array of the names of the other nodes in the media graph, the outputs of which are used as input for this processor node. </param>
        /// <param name="maximumFps"> Ensures that the frame rate of the video leaving this processor does not exceed this limit. </param>
        internal MediaGraphFrameRateFilterProcessor(string type, string name, IList<MediaGraphNodeInput> inputs, string maximumFps) : base(type, name, inputs)
        {
            MaximumFps = maximumFps;
            Type = type ?? "#Microsoft.Media.MediaGraphFrameRateFilterProcessor";
        }

        /// <summary> Ensures that the frame rate of the video leaving this processor does not exceed this limit. </summary>
        public string MaximumFps { get; set; }
    }
}
