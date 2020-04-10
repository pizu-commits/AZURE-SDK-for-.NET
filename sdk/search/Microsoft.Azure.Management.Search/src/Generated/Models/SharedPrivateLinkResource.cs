// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Search.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes a Shared Private Link Resource managed by the Azure Cognitive
    /// Search service.
    /// </summary>
    public partial class SharedPrivateLinkResource
    {
        /// <summary>
        /// Initializes a new instance of the SharedPrivateLinkResource class.
        /// </summary>
        public SharedPrivateLinkResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SharedPrivateLinkResource class.
        /// </summary>
        /// <param name="name">The name of the shared private link
        /// resource.</param>
        /// <param name="properties">Describes the properties of a Shared
        /// Private Link Resource managed by the Azure Cognitive Search
        /// service.</param>
        public SharedPrivateLinkResource(string name = default(string), SharedPrivateLinkResourceProperties properties = default(SharedPrivateLinkResourceProperties))
        {
            Name = name;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the shared private link resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets describes the properties of a Shared Private Link
        /// Resource managed by the Azure Cognitive Search service.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public SharedPrivateLinkResourceProperties Properties { get; set; }

    }
}
