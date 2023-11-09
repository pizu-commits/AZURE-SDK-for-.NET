// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> Meta data for the Service Provider. </summary>
    internal partial class ServiceProviderParameterMetadata
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ServiceProviderParameterMetadata"/>. </summary>
        internal ServiceProviderParameterMetadata()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ServiceProviderParameterMetadata"/>. </summary>
        /// <param name="constraints"> the constraints of the bot meta data. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServiceProviderParameterMetadata(ServiceProviderParameterMetadataConstraints constraints, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Constraints = constraints;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> the constraints of the bot meta data. </summary>
        internal ServiceProviderParameterMetadataConstraints Constraints { get; }
        /// <summary> Whether required the constraints of the bot meta data. </summary>
        public bool? IsRequired
        {
            get => Constraints?.IsRequired;
        }
    }
}
