// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 2.2.22.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Parameters for updating a factory resource.
    /// </summary>
    public partial class FactoryUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the FactoryUpdateParameters class.
        /// </summary>
        public FactoryUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FactoryUpdateParameters class.
        /// </summary>
        /// <param name="tags">The resource tags.</param>
        /// <param name="identity">Managed service identity of the
        /// factory.</param>
        public FactoryUpdateParameters(IDictionary<string, string> tags = default(IDictionary<string, string>), FactoryIdentity identity = default(FactoryIdentity))
        {
            Tags = tags;
            Identity = identity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the resource tags.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets managed service identity of the factory.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public FactoryIdentity Identity { get; set; }

    }
}
