// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.ResourceManager;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Resource information. </summary>
    public partial class GenericResourceAutoGenerated : TrackedResource
    {
        /// <summary> Initializes a new instance of GenericResourceAutoGenerated. </summary>
        /// <param name="location"> The location. </param>
        public GenericResourceAutoGenerated(Location location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of GenericResourceAutoGenerated. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="managedBy"> ID of the resource that manages this resource. </param>
        /// <param name="sku"> The SKU of the resource. </param>
        internal GenericResourceAutoGenerated(ResourceIdentifier id, string name, ResourceType type, IDictionary<string, string> tags, Location location, string managedBy, SkuAutoGenerated sku) : base(id, name, type, tags, location)
        {
            ManagedBy = managedBy;
            Sku = sku;
        }

        /// <summary> ID of the resource that manages this resource. </summary>
        public string ManagedBy { get; set; }
        /// <summary> The SKU of the resource. </summary>
        public SkuAutoGenerated Sku { get; set; }
    }
}
