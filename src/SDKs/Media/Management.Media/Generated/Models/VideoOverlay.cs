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
    using System.Linq;

    /// <summary>
    /// Describes the properties of a video overlay.
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Media.VideoOverlay")]
    public partial class VideoOverlay : Overlay
    {
        /// <summary>
        /// Initializes a new instance of the VideoOverlay class.
        /// </summary>
        public VideoOverlay()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VideoOverlay class.
        /// </summary>
        /// <param name="inputLabel">The label of the job input which is to be
        /// used as an overlay. The Input must specify exactly one file. You
        /// can specify an image file in JPG or PNG formats, or an audio file
        /// (such as a WAV, MP3, WMA or M4A file), or a video file. See
        /// https://aka.ms/mesformats for the complete list of supported audio
        /// and video file formats.</param>
        /// <param name="start">The start position, with reference to the input
        /// video, at which the overlay starts. The value should be in ISO 8601
        /// format. For example, PT05S to start the overlay at 5 seconds in to
        /// the input video. If not specified the overlay starts from the
        /// beginning of the input video.</param>
        /// <param name="end">The position in the input video at which the
        /// overlay ends. The value should be in ISO 8601 duration format. For
        /// example, PT30S to end the overlay at 30 seconds in to the input
        /// video. If not specified the overlay will be applied until the end
        /// of the input video if inputLoop is true. Else, if inputLoop is
        /// false, then overlay will last as long as the duration of the
        /// overlay media.</param>
        /// <param name="fadeInDuration">The duration over which the overlay
        /// fades in onto the input video. The value should be in ISO 8601
        /// duration format. If not specified the default behavior is to have
        /// no fade in (same as PT0S).</param>
        /// <param name="fadeOutDuration">The duration over which the overlay
        /// fades out of the input video. The value should be in ISO 8601
        /// duration format. If not specified the default behavior is to have
        /// no fade out (same as PT0S).</param>
        /// <param name="audioGainLevel">The gain level of audio in the
        /// overlay. The value should be in the range [0, 1.0]. The default is
        /// 1.0.</param>
        /// <param name="position">The location in the input video where the
        /// overlay is applied.</param>
        /// <param name="opacity">The opacity of the overlay. This is a value
        /// in the range [0 - 1.0]. Default is 1.0 which mean the overlay is
        /// opaque.</param>
        /// <param name="cropRectangle">An optional rectangular window used to
        /// crop the overlay image or video.</param>
        public VideoOverlay(string inputLabel, System.TimeSpan? start = default(System.TimeSpan?), System.TimeSpan? end = default(System.TimeSpan?), System.TimeSpan? fadeInDuration = default(System.TimeSpan?), System.TimeSpan? fadeOutDuration = default(System.TimeSpan?), double? audioGainLevel = default(double?), Rectangle position = default(Rectangle), double? opacity = default(double?), Rectangle cropRectangle = default(Rectangle))
            : base(inputLabel, start, end, fadeInDuration, fadeOutDuration, audioGainLevel)
        {
            Position = position;
            Opacity = opacity;
            CropRectangle = cropRectangle;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the location in the input video where the overlay is
        /// applied.
        /// </summary>
        [JsonProperty(PropertyName = "position")]
        public Rectangle Position { get; set; }

        /// <summary>
        /// Gets or sets the opacity of the overlay. This is a value in the
        /// range [0 - 1.0]. Default is 1.0 which mean the overlay is opaque.
        /// </summary>
        [JsonProperty(PropertyName = "opacity")]
        public double? Opacity { get; set; }

        /// <summary>
        /// Gets or sets an optional rectangular window used to crop the
        /// overlay image or video.
        /// </summary>
        [JsonProperty(PropertyName = "cropRectangle")]
        public Rectangle CropRectangle { get; set; }

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
