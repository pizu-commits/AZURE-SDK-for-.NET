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
    /// Provider details.
    /// </summary>
    public partial class RecoveryServicesProvider : Resource
    {
        /// <summary>
        /// Initializes a new instance of the RecoveryServicesProvider class.
        /// </summary>
        public RecoveryServicesProvider() { }

        /// <summary>
        /// Initializes a new instance of the RecoveryServicesProvider class.
        /// </summary>
        public RecoveryServicesProvider(string id = default(string), string name = default(string), string type = default(string), string location = default(string), RecoveryServicesProviderProperties properties = default(RecoveryServicesProviderProperties))
            : base(id, name, type, location)
        {
            Properties = properties;
        }

        /// <summary>
        /// Provider properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public RecoveryServicesProviderProperties Properties { get; set; }

    }
}
