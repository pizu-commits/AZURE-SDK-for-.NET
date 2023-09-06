// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> Customer Managed Identity. </summary>
    public partial class MyWorkbookUserAssignedIdentities
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MyWorkbookUserAssignedIdentities"/>. </summary>
        public MyWorkbookUserAssignedIdentities()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MyWorkbookUserAssignedIdentities"/>. </summary>
        /// <param name="principalId"> The principal ID of resource identity. </param>
        /// <param name="tenantId"> The tenant ID of resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MyWorkbookUserAssignedIdentities(string principalId, Guid? tenantId, Dictionary<string, BinaryData> rawData)
        {
            PrincipalId = principalId;
            TenantId = tenantId;
            _rawData = rawData;
        }

        /// <summary> The principal ID of resource identity. </summary>
        public string PrincipalId { get; }
        /// <summary> The tenant ID of resource. </summary>
        public Guid? TenantId { get; }
    }
}
