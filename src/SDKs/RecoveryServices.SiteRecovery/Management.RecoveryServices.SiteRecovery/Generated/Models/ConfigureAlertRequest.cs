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
    /// Request to configure alerts for the system.
    /// </summary>
    public partial class ConfigureAlertRequest
    {
        /// <summary>
        /// Initializes a new instance of the ConfigureAlertRequest class.
        /// </summary>
        public ConfigureAlertRequest() { }

        /// <summary>
        /// Initializes a new instance of the ConfigureAlertRequest class.
        /// </summary>
        public ConfigureAlertRequest(ConfigureAlertRequestProperties properties = default(ConfigureAlertRequestProperties))
        {
            Properties = properties;
        }

        /// <summary>
        /// The properties of a configure alert request.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public ConfigureAlertRequestProperties Properties { get; set; }

    }
}
