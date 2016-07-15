// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// List of resource groups.
    /// </summary>
    public partial class ResourceGroupListResultInner
    {
        /// <summary>
        /// Initializes a new instance of the ResourceGroupListResultInner
        /// class.
        /// </summary>
        public ResourceGroupListResultInner() { }

        /// <summary>
        /// Initializes a new instance of the ResourceGroupListResultInner
        /// class.
        /// </summary>
        /// <param name="nextLink">Gets or sets the URL to get the next set of
        /// results.</param>
        /// <param name="value">Gets or sets the list of resource
        /// groups.</param>
        public ResourceGroupListResultInner(string nextLink, IList<ResourceGroupInner> value = default(IList<ResourceGroupInner>))
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// Gets or sets the list of resource groups.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<ResourceGroupInner> Value { get; set; }

        /// <summary>
        /// Gets or sets the URL to get the next set of results.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (NextLink == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "NextLink");
            }
            if (this.Value != null)
            {
                foreach (var element in this.Value)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
