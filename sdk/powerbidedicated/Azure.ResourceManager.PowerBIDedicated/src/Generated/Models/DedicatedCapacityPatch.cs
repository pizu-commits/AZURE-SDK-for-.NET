// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PowerBIDedicated.Models
{
    /// <summary> Provision request specification. </summary>
    public partial class DedicatedCapacityPatch
    {
        /// <summary> Initializes a new instance of DedicatedCapacityPatch. </summary>
        public DedicatedCapacityPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> The SKU of the Dedicated capacity resource. </summary>
        public CapacitySku Sku { get; set; }
        /// <summary> Key-value pairs of additional provisioning properties. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> A collection of Dedicated capacity administrators. </summary>
        internal DedicatedCapacityAdministrators Administration { get; set; }
        /// <summary> An array of administrator user identities. </summary>
        public IList<string> AdministrationMembers
        {
            get
            {
                if (Administration is null)
                    Administration = new DedicatedCapacityAdministrators();
                return Administration.Members;
            }
        }

        /// <summary> Specifies the generation of the Power BI Embedded capacity. If no value is specified, the default value &apos;Gen2&apos; is used. [Learn More](https://docs.microsoft.com/power-bi/developer/embedded/power-bi-embedded-generation-2). </summary>
        public Mode? Mode { get; set; }
        /// <summary> Tenant ID for the capacity. Used for creating Pro Plus capacity. </summary>
        public Guid? TenantId { get; }
        /// <summary> Capacity name. </summary>
        public string FriendlyName { get; }
    }
}
