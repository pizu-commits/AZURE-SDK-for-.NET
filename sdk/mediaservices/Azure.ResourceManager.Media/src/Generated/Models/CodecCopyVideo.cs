// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> A codec flag, which tells the encoder to copy the input video bitstream without re-encoding. </summary>
    public partial class CodecCopyVideo : MediaCodecBase
    {
        /// <summary> Initializes a new instance of CodecCopyVideo. </summary>
        public CodecCopyVideo()
        {
            OdataType = "#Microsoft.Media.CopyVideo";
        }

        /// <summary> Initializes a new instance of CodecCopyVideo. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        /// <param name="label"> An optional label for the codec. The label can be used to control muxing behavior. </param>
        internal CodecCopyVideo(string odataType, string label) : base(odataType, label)
        {
            OdataType = odataType ?? "#Microsoft.Media.CopyVideo";
        }
    }
}
