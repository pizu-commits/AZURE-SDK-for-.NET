// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Analysis.Models
{
    /// <summary> The checking result of server name availability. </summary>
    public partial class AnalysisServerNameAvailabilityResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AnalysisServerNameAvailabilityResult"/>. </summary>
        internal AnalysisServerNameAvailabilityResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AnalysisServerNameAvailabilityResult"/>. </summary>
        /// <param name="isNameAvailable"> Indicator of available of the server name. </param>
        /// <param name="reason"> The reason of unavailability. </param>
        /// <param name="message"> The detailed message of the request unavailability. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AnalysisServerNameAvailabilityResult(bool? isNameAvailable, string reason, string message, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsNameAvailable = isNameAvailable;
            Reason = reason;
            Message = message;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Indicator of available of the server name. </summary>
        public bool? IsNameAvailable { get; }
        /// <summary> The reason of unavailability. </summary>
        public string Reason { get; }
        /// <summary> The detailed message of the request unavailability. </summary>
        public string Message { get; }
    }
}
