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
    /// This class represents the vm NicUpdates task details.
    /// </summary>
    public partial class VmNicUpdatesTaskDetails : TaskTypeDetails
    {
        /// <summary>
        /// Initializes a new instance of the VmNicUpdatesTaskDetails class.
        /// </summary>
        public VmNicUpdatesTaskDetails() { }

        /// <summary>
        /// Initializes a new instance of the VmNicUpdatesTaskDetails class.
        /// </summary>
        public VmNicUpdatesTaskDetails(string vmId = default(string), string nicId = default(string), string name = default(string))
        {
            VmId = vmId;
            NicId = nicId;
            Name = name;
        }

        /// <summary>
        /// VmId.
        /// </summary>
        [JsonProperty(PropertyName = "vmId")]
        public string VmId { get; set; }

        /// <summary>
        /// NicId.
        /// </summary>
        [JsonProperty(PropertyName = "nicId")]
        public string NicId { get; set; }

        /// <summary>
        /// Name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
