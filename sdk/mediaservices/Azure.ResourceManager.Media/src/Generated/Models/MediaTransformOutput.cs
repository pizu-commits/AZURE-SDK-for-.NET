// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Describes the properties of a TransformOutput, which are the rules to be applied while generating the desired output. </summary>
    public partial class MediaTransformOutput
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MediaTransformOutput"/>. </summary>
        /// <param name="preset">
        /// Preset that describes the operations that will be used to modify, transcode, or extract insights from the source file to generate the output.
        /// Please note <see cref="MediaTransformPreset"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AudioAnalyzerPreset"/>, <see cref="BuiltInStandardEncoderPreset"/>, <see cref="StandardEncoderPreset"/> and <see cref="VideoAnalyzerPreset"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="preset"/> is null. </exception>
        public MediaTransformOutput(MediaTransformPreset preset)
        {
            Argument.AssertNotNull(preset, nameof(preset));

            Preset = preset;
        }

        /// <summary> Initializes a new instance of <see cref="MediaTransformOutput"/>. </summary>
        /// <param name="onError"> A Transform can define more than one outputs. This property defines what the service should do when one output fails - either continue to produce other outputs, or, stop the other outputs. The overall Job state will not reflect failures of outputs that are specified with 'ContinueJob'. The default is 'StopProcessingJob'. </param>
        /// <param name="relativePriority"> Sets the relative priority of the TransformOutputs within a Transform. This sets the priority that the service uses for processing TransformOutputs. The default priority is Normal. </param>
        /// <param name="preset">
        /// Preset that describes the operations that will be used to modify, transcode, or extract insights from the source file to generate the output.
        /// Please note <see cref="MediaTransformPreset"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AudioAnalyzerPreset"/>, <see cref="BuiltInStandardEncoderPreset"/>, <see cref="StandardEncoderPreset"/> and <see cref="VideoAnalyzerPreset"/>.
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MediaTransformOutput(MediaTransformOnErrorType? onError, MediaJobPriority? relativePriority, MediaTransformPreset preset, Dictionary<string, BinaryData> rawData)
        {
            OnError = onError;
            RelativePriority = relativePriority;
            Preset = preset;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="MediaTransformOutput"/> for deserialization. </summary>
        internal MediaTransformOutput()
        {
        }

        /// <summary> A Transform can define more than one outputs. This property defines what the service should do when one output fails - either continue to produce other outputs, or, stop the other outputs. The overall Job state will not reflect failures of outputs that are specified with 'ContinueJob'. The default is 'StopProcessingJob'. </summary>
        public MediaTransformOnErrorType? OnError { get; set; }
        /// <summary> Sets the relative priority of the TransformOutputs within a Transform. This sets the priority that the service uses for processing TransformOutputs. The default priority is Normal. </summary>
        public MediaJobPriority? RelativePriority { get; set; }
        /// <summary>
        /// Preset that describes the operations that will be used to modify, transcode, or extract insights from the source file to generate the output.
        /// Please note <see cref="MediaTransformPreset"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AudioAnalyzerPreset"/>, <see cref="BuiltInStandardEncoderPreset"/>, <see cref="StandardEncoderPreset"/> and <see cref="VideoAnalyzerPreset"/>.
        /// </summary>
        public MediaTransformPreset Preset { get; set; }
    }
}
