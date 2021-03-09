// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes the properties for generating an MPEG-2 Transport Stream
    /// (ISO/IEC 13818-1) output video file(s).
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Media.TransportStreamFormat")]
    public partial class TransportStreamFormat : MultiBitrateFormat
    {
        /// <summary>
        /// Initializes a new instance of the TransportStreamFormat class.
        /// </summary>
        public TransportStreamFormat()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TransportStreamFormat class.
        /// </summary>
        /// <param name="filenamePattern">The pattern of the file names for the
        /// generated output files. The following macros are supported in the
        /// file name: {Basename} - An expansion macro that will use the name
        /// of the input video file. If the base name(the file suffix is not
        /// included) of the input video file is less than 32 characters long,
        /// the base name of input video files will be used. If the length of
        /// base name of the input video file exceeds 32 characters, the base
        /// name is truncated to the first 32 characters in total length.
        /// {Extension} - The appropriate extension for this format. {Label} -
        /// The label assigned to the codec/layer. {Index} - A unique index for
        /// thumbnails. Only applicable to thumbnails. {Bitrate} - The
        /// audio/video bitrate. Not applicable to thumbnails. {Codec} - The
        /// type of the audio/video codec. {Resolution} - The video resolution.
        /// Any unsubstituted macros will be collapsed and removed from the
        /// filename.</param>
        /// <param name="outputFiles">The list of output files to produce.
        /// Each entry in the list is a set of audio and video layer labels to
        /// be muxed together .</param>
        public TransportStreamFormat(string filenamePattern, IList<OutputFile> outputFiles = default(IList<OutputFile>))
            : base(filenamePattern, outputFiles)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
