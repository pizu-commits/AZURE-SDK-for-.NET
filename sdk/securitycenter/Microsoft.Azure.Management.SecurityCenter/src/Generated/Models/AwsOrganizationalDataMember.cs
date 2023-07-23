// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The AWS organization data for the member account
    /// </summary>
    [Newtonsoft.Json.JsonObject("Member")]
    public partial class AwsOrganizationalDataMember : AwsOrganizationalData
    {
        /// <summary>
        /// Initializes a new instance of the AwsOrganizationalDataMember
        /// class.
        /// </summary>
        public AwsOrganizationalDataMember()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AwsOrganizationalDataMember
        /// class.
        /// </summary>
        /// <param name="parentHierarchyId">If the multi cloud account is not
        /// of membership type organization, this will be the ID of the
        /// account's parent</param>
        public AwsOrganizationalDataMember(string parentHierarchyId = default(string))
        {
            ParentHierarchyId = parentHierarchyId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets if the multi cloud account is not of membership type
        /// organization, this will be the ID of the account's parent
        /// </summary>
        [JsonProperty(PropertyName = "parentHierarchyId")]
        public string ParentHierarchyId { get; set; }

    }
}
