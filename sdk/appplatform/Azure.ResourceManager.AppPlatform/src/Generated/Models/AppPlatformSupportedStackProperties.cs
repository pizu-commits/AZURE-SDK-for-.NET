// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Supported stack resource properties. </summary>
    public partial class AppPlatformSupportedStackProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AppPlatformSupportedStackProperties"/>. </summary>
        public AppPlatformSupportedStackProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppPlatformSupportedStackProperties"/>. </summary>
        /// <param name="stackId"> The id of supported stack. </param>
        /// <param name="version"> The version of supported stack. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AppPlatformSupportedStackProperties(string stackId, string version, Dictionary<string, BinaryData> rawData)
        {
            StackId = stackId;
            Version = version;
            _rawData = rawData;
        }

        /// <summary> The id of supported stack. </summary>
        public string StackId { get; set; }
        /// <summary> The version of supported stack. </summary>
        public string Version { get; set; }
    }
}
