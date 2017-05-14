// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
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
    /// Update protection profile input.
    /// </summary>
    public partial class UpdatePolicyInput
    {
        /// <summary>
        /// Initializes a new instance of the UpdatePolicyInput class.
        /// </summary>
        public UpdatePolicyInput() { }

        /// <summary>
        /// Initializes a new instance of the UpdatePolicyInput class.
        /// </summary>
        public UpdatePolicyInput(UpdatePolicyInputProperties properties = default(UpdatePolicyInputProperties))
        {
            Properties = properties;
        }

        /// <summary>
        /// The ReplicationProviderSettings.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public UpdatePolicyInputProperties Properties { get; set; }

    }
}
