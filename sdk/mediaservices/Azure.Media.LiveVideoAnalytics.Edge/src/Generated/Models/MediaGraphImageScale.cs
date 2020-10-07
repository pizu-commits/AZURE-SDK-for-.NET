// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Media.LiveVideoAnalytics.Edge.Models
{
    /// <summary> The scaling mode for the image. </summary>
    public partial class MediaGraphImageScale
    {
        /// <summary> Initializes a new instance of MediaGraphImageScale. </summary>
        public MediaGraphImageScale()
        {
        }

        /// <summary> Initializes a new instance of MediaGraphImageScale. </summary>
        /// <param name="mode"> Describes the modes for scaling an input video frame into an image, before it is sent to an inference engine. </param>
        /// <param name="width"> The desired output width of the image. </param>
        /// <param name="height"> The desired output height of the image. </param>
        internal MediaGraphImageScale(MediaGraphImageScaleMode? mode, string width, string height)
        {
            Mode = mode;
            Width = width;
            Height = height;
        }

        /// <summary> Describes the modes for scaling an input video frame into an image, before it is sent to an inference engine. </summary>
        public MediaGraphImageScaleMode? Mode { get; set; }
        /// <summary> The desired output width of the image. </summary>
        public string Width { get; set; }
        /// <summary> The desired output height of the image. </summary>
        public string Height { get; set; }
    }
}
