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
    /// Protection profile input.
    /// </summary>
    public partial class CreatePolicyInput
    {
        /// <summary>
        /// Initializes a new instance of the CreatePolicyInput class.
        /// </summary>
        public CreatePolicyInput() { }

        /// <summary>
        /// Initializes a new instance of the CreatePolicyInput class.
        /// </summary>
        public CreatePolicyInput(CreatePolicyInputProperties properties = default(CreatePolicyInputProperties))
        {
            Properties = properties;
        }

        /// <summary>
        /// Policy creation properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public CreatePolicyInputProperties Properties { get; set; }

    }
}
