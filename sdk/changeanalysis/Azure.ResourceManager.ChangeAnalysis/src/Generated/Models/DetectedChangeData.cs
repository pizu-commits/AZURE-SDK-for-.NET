// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ChangeAnalysis.Models
{
    /// <summary> The detected change. </summary>
    public partial class DetectedChangeData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DetectedChangeData"/>. </summary>
        internal DetectedChangeData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DetectedChangeData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The properties of a change. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DetectedChangeData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ChangeProperties properties, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            _rawData = rawData;
        }

        /// <summary> The properties of a change. </summary>
        public ChangeProperties Properties { get; }
    }
}
