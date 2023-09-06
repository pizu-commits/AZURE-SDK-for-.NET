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
    /// A class representing the MachineLearningCompute data model.
    /// Machine Learning compute object wrapped into ARM resource envelope.
    /// </summary>
    public partial class MachineLearningComputeData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MachineLearningComputeData"/>. </summary>
        /// <param name="location"> The location. </param>
        public MachineLearningComputeData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningComputeData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> The identity of the resource. </param>
        /// <param name="sku"> The sku of the workspace. </param>
        /// <param name="properties">
        /// Compute properties
        /// Please note <see cref="MachineLearningComputeProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningAksCompute"/>, <see cref="AmlCompute"/>, <see cref="MachineLearningComputeInstance"/>, <see cref="MachineLearningDataFactoryCompute"/>, <see cref="MachineLearningDataLakeAnalytics"/>, <see cref="MachineLearningDatabricksCompute"/>, <see cref="MachineLearningHDInsightCompute"/>, <see cref="MachineLearningKubernetesCompute"/>, <see cref="MachineLearningSynapseSpark"/> and <see cref="MachineLearningVirtualMachineCompute"/>.
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningComputeData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, MachineLearningSku sku, MachineLearningComputeProperties properties, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            Sku = sku;
            Properties = properties;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningComputeData"/> for deserialization. </summary>
        internal MachineLearningComputeData()
        {
        }

        /// <summary> The identity of the resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The sku of the workspace. </summary>
        public MachineLearningSku Sku { get; set; }
        /// <summary>
        /// Compute properties
        /// Please note <see cref="MachineLearningComputeProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningAksCompute"/>, <see cref="AmlCompute"/>, <see cref="MachineLearningComputeInstance"/>, <see cref="MachineLearningDataFactoryCompute"/>, <see cref="MachineLearningDataLakeAnalytics"/>, <see cref="MachineLearningDatabricksCompute"/>, <see cref="MachineLearningHDInsightCompute"/>, <see cref="MachineLearningKubernetesCompute"/>, <see cref="MachineLearningSynapseSpark"/> and <see cref="MachineLearningVirtualMachineCompute"/>.
        /// </summary>
        public MachineLearningComputeProperties Properties { get; set; }
    }
}
