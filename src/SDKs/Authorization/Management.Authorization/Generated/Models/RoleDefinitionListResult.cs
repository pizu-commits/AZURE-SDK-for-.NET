// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Authorization.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Authorization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Role definition list operation result.
    /// </summary>
    public partial class RoleDefinitionListResult
    {
        /// <summary>
        /// Initializes a new instance of the RoleDefinitionListResult class.
        /// </summary>
        public RoleDefinitionListResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RoleDefinitionListResult class.
        /// </summary>
        /// <param name="value">Role definition list.</param>
        /// <param name="nextLink">The URL to use for getting the next set of
        /// results.</param>
        public RoleDefinitionListResult(IList<RoleDefinition> value = default(IList<RoleDefinition>), string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets role definition list.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<RoleDefinition> Value { get; set; }

        /// <summary>
        /// Gets or sets the URL to use for getting the next set of results.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

    }
}
