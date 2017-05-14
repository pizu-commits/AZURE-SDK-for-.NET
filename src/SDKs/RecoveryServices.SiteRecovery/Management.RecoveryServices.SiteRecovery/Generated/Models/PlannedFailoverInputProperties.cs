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
    /// Input definition for planned failover input properties.
    /// </summary>
    public partial class PlannedFailoverInputProperties
    {
        /// <summary>
        /// Initializes a new instance of the PlannedFailoverInputProperties
        /// class.
        /// </summary>
        public PlannedFailoverInputProperties() { }

        /// <summary>
        /// Initializes a new instance of the PlannedFailoverInputProperties
        /// class.
        /// </summary>
        public PlannedFailoverInputProperties(string failoverDirection = default(string), ProviderSpecificFailoverInput providerSpecificDetails = default(ProviderSpecificFailoverInput))
        {
            FailoverDirection = failoverDirection;
            ProviderSpecificDetails = providerSpecificDetails;
        }

        /// <summary>
        /// Failover direction.
        /// </summary>
        [JsonProperty(PropertyName = "failoverDirection")]
        public string FailoverDirection { get; set; }

        /// <summary>
        /// Provider specific settings
        /// </summary>
        [JsonProperty(PropertyName = "providerSpecificDetails")]
        public ProviderSpecificFailoverInput ProviderSpecificDetails { get; set; }

    }
}
