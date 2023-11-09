// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Definition of the content source. </summary>
    public partial class AutomationContentSource
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AutomationContentSource"/>. </summary>
        public AutomationContentSource()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AutomationContentSource"/>. </summary>
        /// <param name="hash"> Gets or sets the hash. </param>
        /// <param name="sourceType"> Gets or sets the content source type. </param>
        /// <param name="value"> Gets or sets the value of the content. This is based on the content source type. </param>
        /// <param name="version"> Gets or sets the version of the content. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AutomationContentSource(AutomationContentHash hash, AutomationContentSourceType? sourceType, string value, string version, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Hash = hash;
            SourceType = sourceType;
            Value = value;
            Version = version;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the hash. </summary>
        public AutomationContentHash Hash { get; set; }
        /// <summary> Gets or sets the content source type. </summary>
        public AutomationContentSourceType? SourceType { get; set; }
        /// <summary> Gets or sets the value of the content. This is based on the content source type. </summary>
        public string Value { get; set; }
        /// <summary> Gets or sets the version of the content. </summary>
        public string Version { get; set; }
    }
}
