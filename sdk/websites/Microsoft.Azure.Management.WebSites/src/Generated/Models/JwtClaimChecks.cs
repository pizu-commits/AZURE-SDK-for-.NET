// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The configuration settings of the checks that should be made while
    /// validating the JWT Claims.
    /// </summary>
    public partial class JwtClaimChecks
    {
        /// <summary>
        /// Initializes a new instance of the JwtClaimChecks class.
        /// </summary>
        public JwtClaimChecks()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JwtClaimChecks class.
        /// </summary>
        /// <param name="allowedGroups">The list of the allowed groups.</param>
        /// <param name="allowedClientApplications">The list of the allowed
        /// client applications.</param>
        public JwtClaimChecks(IList<string> allowedGroups = default(IList<string>), IList<string> allowedClientApplications = default(IList<string>))
        {
            AllowedGroups = allowedGroups;
            AllowedClientApplications = allowedClientApplications;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of the allowed groups.
        /// </summary>
        [JsonProperty(PropertyName = "allowedGroups")]
        public IList<string> AllowedGroups { get; set; }

        /// <summary>
        /// Gets or sets the list of the allowed client applications.
        /// </summary>
        [JsonProperty(PropertyName = "allowedClientApplications")]
        public IList<string> AllowedClientApplications { get; set; }

    }
}
