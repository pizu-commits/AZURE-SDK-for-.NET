// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.IotHub.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ArmIdentity
    {
        /// <summary>
        /// Initializes a new instance of the ArmIdentity class.
        /// </summary>
        public ArmIdentity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ArmIdentity class.
        /// </summary>
        /// <param name="principalId">Principal Id</param>
        /// <param name="tenantId">Tenant Id</param>
        /// <param name="type">The type of identity used for the resource. The
        /// type 'SystemAssigned,UserAssigned' includes both an implicitly
        /// created identity and a set of user assigned identities. The type
        /// 'None' will remove any identities from the service. Possible values
        /// include: 'SystemAssigned', 'UserAssigned', 'SystemAssigned,
        /// UserAssigned', 'None'</param>
        public ArmIdentity(string principalId = default(string), string tenantId = default(string), ResourceIdentityType? type = default(ResourceIdentityType?), IDictionary<string, ArmUserIdentity> userAssignedIdentities = default(IDictionary<string, ArmUserIdentity>))
        {
            PrincipalId = principalId;
            TenantId = tenantId;
            Type = type;
            UserAssignedIdentities = userAssignedIdentities;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets principal Id
        /// </summary>
        [JsonProperty(PropertyName = "principalId")]
        public string PrincipalId { get; private set; }

        /// <summary>
        /// Gets tenant Id
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; private set; }

        /// <summary>
        /// Gets or sets the type of identity used for the resource. The type
        /// 'SystemAssigned,UserAssigned' includes both an implicitly created
        /// identity and a set of user assigned identities. The type 'None'
        /// will remove any identities from the service. Possible values
        /// include: 'SystemAssigned', 'UserAssigned', 'SystemAssigned,
        /// UserAssigned', 'None'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public ResourceIdentityType? Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "userAssignedIdentities")]
        public IDictionary<string, ArmUserIdentity> UserAssignedIdentities { get; set; }

    }
}
