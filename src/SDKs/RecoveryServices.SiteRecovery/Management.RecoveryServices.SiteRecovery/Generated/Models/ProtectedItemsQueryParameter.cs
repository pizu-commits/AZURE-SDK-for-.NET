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
    /// Query parameter to enumerate protected items.
    /// </summary>
    public partial class ProtectedItemsQueryParameter
    {
        /// <summary>
        /// Initializes a new instance of the ProtectedItemsQueryParameter
        /// class.
        /// </summary>
        public ProtectedItemsQueryParameter() { }

        /// <summary>
        /// Initializes a new instance of the ProtectedItemsQueryParameter
        /// class.
        /// </summary>
        public ProtectedItemsQueryParameter(string sourceFabricName = default(string), string recoveryPlanName = default(string))
        {
            SourceFabricName = sourceFabricName;
            RecoveryPlanName = recoveryPlanName;
        }

        /// <summary>
        /// The source fabric name filter.
        /// </summary>
        [JsonProperty(PropertyName = "sourceFabricName")]
        public string SourceFabricName { get; set; }

        /// <summary>
        /// The recovery plan filter.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryPlanName")]
        public string RecoveryPlanName { get; set; }

    }
}
