// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Models
{
    /// <summary> Managed service identity (either system assigned, or none). </summary>
    [PropertyReferenceType]
    public partial class SystemAssignedServiceIdentity
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SystemAssignedServiceIdentity"/>. </summary>
        /// <param name="principalId"> The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity. </param>
        /// <param name="tenantId"> The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity. </param>
        /// <param name="systemAssignedServiceIdentityType"> Type of managed service identity (either system assigned, or none). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SystemAssignedServiceIdentity(Guid? principalId, Guid? tenantId, SystemAssignedServiceIdentityType systemAssignedServiceIdentityType, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            //PrincipalId = principalId;
            //TenantId = tenantId;
            SystemAssignedServiceIdentityType = systemAssignedServiceIdentityType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SystemAssignedServiceIdentity"/> for deserialization. </summary>
        internal SystemAssignedServiceIdentity()
        {
        }
    }
}
