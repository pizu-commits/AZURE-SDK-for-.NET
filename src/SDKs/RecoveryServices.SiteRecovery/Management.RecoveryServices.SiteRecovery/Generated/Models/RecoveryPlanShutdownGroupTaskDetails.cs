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
    /// This class represents the recovery plan shutdown group task details.
    /// </summary>
    public partial class RecoveryPlanShutdownGroupTaskDetails : GroupTaskDetails
    {
        /// <summary>
        /// Initializes a new instance of the
        /// RecoveryPlanShutdownGroupTaskDetails class.
        /// </summary>
        public RecoveryPlanShutdownGroupTaskDetails() { }

        /// <summary>
        /// Initializes a new instance of the
        /// RecoveryPlanShutdownGroupTaskDetails class.
        /// </summary>
        public RecoveryPlanShutdownGroupTaskDetails(IList<ASRTask> childTasks = default(IList<ASRTask>), string name = default(string), string groupId = default(string), string rpGroupType = default(string))
            : base(childTasks)
        {
            Name = name;
            GroupId = groupId;
            RpGroupType = rpGroupType;
        }

        /// <summary>
        /// The name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The group identifier.
        /// </summary>
        [JsonProperty(PropertyName = "groupId")]
        public string GroupId { get; set; }

        /// <summary>
        /// The group type.
        /// </summary>
        [JsonProperty(PropertyName = "rpGroupType")]
        public string RpGroupType { get; set; }

    }
}
