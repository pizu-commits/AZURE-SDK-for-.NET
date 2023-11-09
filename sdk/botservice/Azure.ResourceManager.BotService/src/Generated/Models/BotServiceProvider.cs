// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> Service Provider Definition. </summary>
    public partial class BotServiceProvider
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BotServiceProvider"/>. </summary>
        internal BotServiceProvider()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BotServiceProvider"/>. </summary>
        /// <param name="properties"> The Properties of a Service Provider Object. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BotServiceProvider(BotServiceProviderProperties properties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The Properties of a Service Provider Object. </summary>
        public BotServiceProviderProperties Properties { get; }
    }
}
