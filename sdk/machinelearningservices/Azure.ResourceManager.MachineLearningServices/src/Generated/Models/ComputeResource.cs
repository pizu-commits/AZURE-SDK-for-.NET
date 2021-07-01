// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Machine Learning compute object wrapped into ARM resource envelope. </summary>
    public partial class ComputeResource : Resource
    {
        /// <summary> Initializes a new instance of ComputeResource. </summary>
        public ComputeResource()
        {
        }

        /// <summary> Initializes a new instance of ComputeResource. </summary>
        /// <param name="id"> Specifies the resource ID. </param>
        /// <param name="name"> Specifies the name of the resource. </param>
        /// <param name="identity"> The identity of the resource. </param>
        /// <param name="location"> Specifies the location of the resource. </param>
        /// <param name="type"> Specifies the type of the resource. </param>
        /// <param name="tags"> Contains resource tags defined as key/value pairs. </param>
        /// <param name="sku"> The sku of the workspace. </param>
        /// <param name="properties"> Compute properties. </param>
        internal ComputeResource(string id, string name, Identity identity, string location, string type, IDictionary<string, string> tags, Sku sku, Compute properties) : base(id, name, identity, location, type, tags, sku)
        {
            Properties = properties;
        }

        /// <summary> Compute properties. </summary>
        public Compute Properties { get; set; }
    }
}
