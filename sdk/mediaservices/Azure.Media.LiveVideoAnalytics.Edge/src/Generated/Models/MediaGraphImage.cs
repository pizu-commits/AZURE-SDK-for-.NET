// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Media.LiveVideoAnalytics.Edge.Models
{
    /// <summary> Describes the properties of an image frame. </summary>
    public partial class MediaGraphImage
    {
        /// <summary> Initializes a new instance of MediaGraphImage. </summary>
        public MediaGraphImage()
        {
        }

        /// <summary> Initializes a new instance of MediaGraphImage. </summary>
        /// <param name="scale"> The scaling mode for the image. </param>
        /// <param name="format"> Encoding settings for an image. </param>
        internal MediaGraphImage(MediaGraphImageScale scale, MediaGraphImageFormat format)
        {
            Scale = scale;
            Format = format;
        }

        /// <summary> The scaling mode for the image. </summary>
        public MediaGraphImageScale Scale { get; set; }
        /// <summary> Encoding settings for an image. </summary>
        public MediaGraphImageFormat Format { get; set; }
    }
}
