// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> An environment variable to be set on a task process. </summary>
    public partial class BatchEnvironmentSetting
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BatchEnvironmentSetting"/>. </summary>
        /// <param name="name"> The name of the environment variable. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public BatchEnvironmentSetting(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="BatchEnvironmentSetting"/>. </summary>
        /// <param name="name"> The name of the environment variable. </param>
        /// <param name="value"> The value of the environment variable. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchEnvironmentSetting(string name, string value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BatchEnvironmentSetting"/> for deserialization. </summary>
        internal BatchEnvironmentSetting()
        {
        }

        /// <summary> The name of the environment variable. </summary>
        public string Name { get; set; }
        /// <summary> The value of the environment variable. </summary>
        public string Value { get; set; }
    }
}
