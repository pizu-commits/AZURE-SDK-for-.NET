// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Name availability result payload. </summary>
    public partial class AppPlatformNameAvailabilityResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AppPlatformNameAvailabilityResult"/>. </summary>
        internal AppPlatformNameAvailabilityResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppPlatformNameAvailabilityResult"/>. </summary>
        /// <param name="isNameAvailable"> Indicates whether the name is available. </param>
        /// <param name="reason"> Reason why the name is not available. </param>
        /// <param name="message"> Message why the name is not available. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppPlatformNameAvailabilityResult(bool? isNameAvailable, string reason, string message, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsNameAvailable = isNameAvailable;
            Reason = reason;
            Message = message;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Indicates whether the name is available. </summary>
        public bool? IsNameAvailable { get; }
        /// <summary> Reason why the name is not available. </summary>
        public string Reason { get; }
        /// <summary> Message why the name is not available. </summary>
        public string Message { get; }
    }
}
