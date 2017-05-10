// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Azure role assignment details.
    /// </summary>
    public partial class RoleAssignment
    {
        /// <summary>
        /// Initializes a new instance of the RoleAssignment class.
        /// </summary>
        public RoleAssignment() { }

        /// <summary>
        /// Initializes a new instance of the RoleAssignment class.
        /// </summary>
        public RoleAssignment(string id = default(string), string name = default(string), string scope = default(string), string principalId = default(string), string roleDefinitionId = default(string))
        {
            Id = id;
            Name = name;
            Scope = scope;
            PrincipalId = principalId;
            RoleDefinitionId = roleDefinitionId;
        }

        /// <summary>
        /// The ARM Id of the role assignment.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The name of the role assignment.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Role assignment scope.
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        public string Scope { get; set; }

        /// <summary>
        /// Principal Id.
        /// </summary>
        [JsonProperty(PropertyName = "principalId")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// Role definition id.
        /// </summary>
        [JsonProperty(PropertyName = "roleDefinitionId")]
        public string RoleDefinitionId { get; set; }

    }
}
