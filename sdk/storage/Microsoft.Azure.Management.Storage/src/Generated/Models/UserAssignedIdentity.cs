// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// UserAssignedIdentity for the resource.
    /// </summary>
    public partial class UserAssignedIdentity
    {
        /// <summary>
        /// Initializes a new instance of the UserAssignedIdentity class.
        /// </summary>
        public UserAssignedIdentity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UserAssignedIdentity class.
        /// </summary>
        /// <param name="principalId">The principal ID of the identity.</param>
        /// <param name="clientId">The client ID of the identity.</param>
        public UserAssignedIdentity(string principalId = default(string), string clientId = default(string))
        {
            PrincipalId = principalId;
            ClientId = clientId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the principal ID of the identity.
        /// </summary>
        [JsonProperty(PropertyName = "principalId")]
        public string PrincipalId { get; private set; }

        /// <summary>
        /// Gets the client ID of the identity.
        /// </summary>
        [JsonProperty(PropertyName = "clientId")]
        public string ClientId { get; private set; }

    }
}
