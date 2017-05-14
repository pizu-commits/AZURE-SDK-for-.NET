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
    /// Input definition for planned failover.
    /// </summary>
    public partial class PlannedFailoverInput
    {
        /// <summary>
        /// Initializes a new instance of the PlannedFailoverInput class.
        /// </summary>
        public PlannedFailoverInput() { }

        /// <summary>
        /// Initializes a new instance of the PlannedFailoverInput class.
        /// </summary>
        public PlannedFailoverInput(PlannedFailoverInputProperties properties = default(PlannedFailoverInputProperties))
        {
            Properties = properties;
        }

        /// <summary>
        /// Planned failover input properties
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public PlannedFailoverInputProperties Properties { get; set; }

    }
}
