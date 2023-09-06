// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> Cognitive Services account ModelDeprecationInfo. </summary>
    public partial class ServiceAccountModelDeprecationInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ServiceAccountModelDeprecationInfo"/>. </summary>
        public ServiceAccountModelDeprecationInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ServiceAccountModelDeprecationInfo"/>. </summary>
        /// <param name="fineTuneOn"> The datetime of deprecation of the fineTune Model. </param>
        /// <param name="inferenceOn"> The datetime of deprecation of the inference Model. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ServiceAccountModelDeprecationInfo(DateTimeOffset? fineTuneOn, DateTimeOffset? inferenceOn, Dictionary<string, BinaryData> rawData)
        {
            FineTuneOn = fineTuneOn;
            InferenceOn = inferenceOn;
            _rawData = rawData;
        }

        /// <summary> The datetime of deprecation of the fineTune Model. </summary>
        public DateTimeOffset? FineTuneOn { get; set; }
        /// <summary> The datetime of deprecation of the inference Model. </summary>
        public DateTimeOffset? InferenceOn { get; set; }
    }
}
