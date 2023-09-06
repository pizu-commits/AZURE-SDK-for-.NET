// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MachineLearning.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary>
    /// A class representing the MachineLearningModelContainer data model.
    /// Azure Resource Manager resource envelope.
    /// </summary>
    public partial class MachineLearningModelContainerData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MachineLearningModelContainerData"/>. </summary>
        /// <param name="properties"> [Required] Additional attributes of the entity. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public MachineLearningModelContainerData(MachineLearningModelContainerProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningModelContainerData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> [Required] Additional attributes of the entity. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningModelContainerData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, MachineLearningModelContainerProperties properties, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningModelContainerData"/> for deserialization. </summary>
        internal MachineLearningModelContainerData()
        {
        }

        /// <summary> [Required] Additional attributes of the entity. </summary>
        public MachineLearningModelContainerProperties Properties { get; set; }
    }
}
