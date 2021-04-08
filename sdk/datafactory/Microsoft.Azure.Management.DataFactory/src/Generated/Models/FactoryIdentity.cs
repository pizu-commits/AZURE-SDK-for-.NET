// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Identity properties of the factory resource.
    /// </summary>
    public partial class FactoryIdentity
    {
        /// <summary>
        /// Initializes a new instance of the FactoryIdentity class.
        /// </summary>
        public FactoryIdentity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FactoryIdentity class.
        /// </summary>
        /// <param name="type">The identity type. Possible values include:
        /// 'SystemAssigned', 'UserAssigned',
        /// 'SystemAssigned,UserAssigned'</param>
        /// <param name="principalId">The principal id of the identity.</param>
        /// <param name="tenantId">The client tenant id of the
        /// identity.</param>
        /// <param name="userAssignedIdentities">List of user assigned
        /// identities for the factory.</param>
        public FactoryIdentity(string type, System.Guid? principalId = default(System.Guid?), System.Guid? tenantId = default(System.Guid?), IDictionary<string, object> userAssignedIdentities = default(IDictionary<string, object>))
        {
            Type = type;
            PrincipalId = principalId;
            TenantId = tenantId;
            UserAssignedIdentities = userAssignedIdentities;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the identity type. Possible values include:
        /// 'SystemAssigned', 'UserAssigned', 'SystemAssigned,UserAssigned'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets the principal id of the identity.
        /// </summary>
        [JsonProperty(PropertyName = "principalId")]
        public System.Guid? PrincipalId { get; private set; }

        /// <summary>
        /// Gets the client tenant id of the identity.
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public System.Guid? TenantId { get; private set; }

        /// <summary>
        /// Gets or sets list of user assigned identities for the factory.
        /// </summary>
        [JsonProperty(PropertyName = "userAssignedIdentities")]
        public IDictionary<string, object> UserAssignedIdentities { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
        }
    }
}
