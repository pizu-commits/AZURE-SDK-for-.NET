// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Class representing the ONVIF MediaProfiles. </summary>
    public partial class MediaProfile
    {
        /// <summary> Initializes a new instance of <see cref="MediaProfile"/>. </summary>
        public MediaProfile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MediaProfile"/>. </summary>
        /// <param name="name"> The name of the Media Profile. </param>
        /// <param name="mediaUri"> Object representing the URI that will be used to request for media streaming. </param>
        /// <param name="videoEncoderConfiguration"> The Video encoder configuration. </param>
        internal MediaProfile(string name, object mediaUri, VideoEncoderConfiguration videoEncoderConfiguration)
        {
            Name = name;
            MediaUri = mediaUri;
            VideoEncoderConfiguration = videoEncoderConfiguration;
        }

        /// <summary> The name of the Media Profile. </summary>
        public string Name { get; set; }
        /// <summary> Object representing the URI that will be used to request for media streaming. </summary>
        public object MediaUri { get; set; }
        /// <summary> The Video encoder configuration. </summary>
        public VideoEncoderConfiguration VideoEncoderConfiguration { get; set; }
    }
}
