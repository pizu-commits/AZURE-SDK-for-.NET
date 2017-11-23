// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Resource provider operation's display properties.
    /// </summary>
    public partial class ResourceProviderOperationDisplayProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ResourceProviderOperationDisplayProperties class.
        /// </summary>
        public ResourceProviderOperationDisplayProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ResourceProviderOperationDisplayProperties class.
        /// </summary>
        /// <param name="publisher">Operation description.</param>
        /// <param name="provider">Operation provider.</param>
        /// <param name="resource">Operation resource.</param>
        /// <param name="operation">Operation.</param>
        /// <param name="description">Operation description.</param>
        public ResourceProviderOperationDisplayProperties(string publisher = default(string), string provider = default(string), string resource = default(string), string operation = default(string), string description = default(string))
        {
            Publisher = publisher;
            Provider = provider;
            Resource = resource;
            Operation = operation;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets operation description.
        /// </summary>
        [JsonProperty(PropertyName = "publisher")]
        public string Publisher { get; set; }

        /// <summary>
        /// Gets or sets operation provider.
        /// </summary>
        [JsonProperty(PropertyName = "provider")]
        public string Provider { get; set; }

        /// <summary>
        /// Gets or sets operation resource.
        /// </summary>
        [JsonProperty(PropertyName = "resource")]
        public string Resource { get; set; }

        /// <summary>
        /// Gets or sets operation.
        /// </summary>
        [JsonProperty(PropertyName = "operation")]
        public string Operation { get; set; }

        /// <summary>
        /// Gets or sets operation description.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

    }
}
