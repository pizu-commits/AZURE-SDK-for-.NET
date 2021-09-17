// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Orbital.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Response for the ListContactProfiles API service call.
    /// </summary>
    public partial class ContactProfileListResult
    {
        /// <summary>
        /// Initializes a new instance of the ContactProfileListResult class.
        /// </summary>
        public ContactProfileListResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ContactProfileListResult class.
        /// </summary>
        /// <param name="value">A list of contact profile resources in a
        /// resource group.</param>
        /// <param name="nextLink">The URL to get the next set of
        /// results.</param>
        public ContactProfileListResult(IList<ContactProfile> value = default(IList<ContactProfile>), string nextLink = default(string))
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
        /// Gets or sets a list of contact profile resources in a resource
        /// group.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<ContactProfile> Value { get; set; }

        /// <summary>
        /// Gets the URL to get the next set of results.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; private set; }

    }
}
