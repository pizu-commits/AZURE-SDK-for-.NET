// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Definition of the runbook property type. </summary>
    public partial class AutomationContentHash
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AutomationContentHash"/>. </summary>
        /// <param name="algorithm"> Gets or sets the content hash algorithm used to hash the content. </param>
        /// <param name="value"> Gets or sets expected hash value of the content. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="algorithm"/> or <paramref name="value"/> is null. </exception>
        public AutomationContentHash(string algorithm, string value)
        {
            Argument.AssertNotNull(algorithm, nameof(algorithm));
            Argument.AssertNotNull(value, nameof(value));

            Algorithm = algorithm;
            Value = value;
        }

        /// <summary> Initializes a new instance of <see cref="AutomationContentHash"/>. </summary>
        /// <param name="algorithm"> Gets or sets the content hash algorithm used to hash the content. </param>
        /// <param name="value"> Gets or sets expected hash value of the content. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AutomationContentHash(string algorithm, string value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Algorithm = algorithm;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AutomationContentHash"/> for deserialization. </summary>
        internal AutomationContentHash()
        {
        }

        /// <summary> Gets or sets the content hash algorithm used to hash the content. </summary>
        public string Algorithm { get; set; }
        /// <summary> Gets or sets expected hash value of the content. </summary>
        public string Value { get; set; }
    }
}
