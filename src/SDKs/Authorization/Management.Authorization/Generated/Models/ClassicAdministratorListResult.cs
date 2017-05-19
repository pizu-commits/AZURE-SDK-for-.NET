// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Authorization.Models
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Authorization;
    using Newtonsoft.Json;

    /// <summary>
    /// ClassicAdministrator list result information.
    /// </summary>
    public partial class ClassicAdministratorListResult
    {
        /// <summary>
        /// Initializes a new instance of the ClassicAdministratorListResult
        /// class.
        /// </summary>
        public ClassicAdministratorListResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ClassicAdministratorListResult
        /// class.
        /// </summary>
        /// <param name="value">An array of administrators.</param>
        /// <param name="nextLink">The URL to use for getting the next set of
        /// results.</param>
        public ClassicAdministratorListResult(IList<ClassicAdministrator> value = default(IList<ClassicAdministrator>), string nextLink = default(string))
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
        /// Gets or sets an array of administrators.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<ClassicAdministrator> Value { get; set; }

        /// <summary>
        /// Gets or sets the URL to use for getting the next set of results.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

    }
}
