// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> Parameters for a check name availability request. </summary>
    public partial class BatchNameAvailabilityContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BatchNameAvailabilityContent"/>. </summary>
        /// <param name="name"> The name to check for availability. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public BatchNameAvailabilityContent(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            ResourceType = "Microsoft.Batch/batchAccounts";
        }

        /// <summary> Initializes a new instance of <see cref="BatchNameAvailabilityContent"/>. </summary>
        /// <param name="name"> The name to check for availability. </param>
        /// <param name="resourceType"> The resource type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchNameAvailabilityContent(string name, ResourceType resourceType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            ResourceType = resourceType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BatchNameAvailabilityContent"/> for deserialization. </summary>
        internal BatchNameAvailabilityContent()
        {
        }

        /// <summary> The name to check for availability. </summary>
        public string Name { get; }
        /// <summary> The resource type. </summary>
        public ResourceType ResourceType { get; }
    }
}
