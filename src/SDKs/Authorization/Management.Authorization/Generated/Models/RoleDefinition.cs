// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Authorization.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Authorization;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Role definition.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class RoleDefinition
    {
        /// <summary>
        /// Initializes a new instance of the RoleDefinition class.
        /// </summary>
        public RoleDefinition()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RoleDefinition class.
        /// </summary>
        /// <param name="id">The role definition ID.</param>
        /// <param name="name">The role definition name.</param>
        /// <param name="type">The role definition type.</param>
        /// <param name="roleName">The role name.</param>
        /// <param name="description">The role definition description.</param>
        /// <param name="roleType">The role type.</param>
        /// <param name="permissions">Role definition permissions.</param>
        /// <param name="assignableScopes">Role definition assignable
        /// scopes.</param>
        public RoleDefinition(string id = default(string), string name = default(string), string type = default(string), string roleName = default(string), string description = default(string), string roleType = default(string), IList<Permission> permissions = default(IList<Permission>), IList<string> assignableScopes = default(IList<string>))
        {
            Id = id;
            Name = name;
            Type = type;
            RoleName = roleName;
            Description = description;
            RoleType = roleType;
            Permissions = permissions;
            AssignableScopes = assignableScopes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the role definition ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the role definition name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the role definition type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or sets the role name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.roleName")]
        public string RoleName { get; set; }

        /// <summary>
        /// Gets or sets the role definition description.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the role type.
        /// </summary>
        [JsonProperty(PropertyName = "properties.type")]
        public string RoleType { get; set; }

        /// <summary>
        /// Gets or sets role definition permissions.
        /// </summary>
        [JsonProperty(PropertyName = "properties.permissions")]
        public IList<Permission> Permissions { get; set; }

        /// <summary>
        /// Gets or sets role definition assignable scopes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.assignableScopes")]
        public IList<string> AssignableScopes { get; set; }

    }
}
