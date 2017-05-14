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
    /// Recovery plan Automation runbook action details.
    /// </summary>
    [JsonObject("AutomationRunbookActionDetails")]
    public partial class RecoveryPlanAutomationRunbookActionDetails : RecoveryPlanActionDetails
    {
        /// <summary>
        /// Initializes a new instance of the
        /// RecoveryPlanAutomationRunbookActionDetails class.
        /// </summary>
        public RecoveryPlanAutomationRunbookActionDetails() { }

        /// <summary>
        /// Initializes a new instance of the
        /// RecoveryPlanAutomationRunbookActionDetails class.
        /// </summary>
        public RecoveryPlanAutomationRunbookActionDetails(RecoveryPlanActionLocation fabricLocation, string runbookId = default(string), string timeout = default(string))
        {
            RunbookId = runbookId;
            Timeout = timeout;
            FabricLocation = fabricLocation;
        }

        /// <summary>
        /// The runbook ARM Id.
        /// </summary>
        [JsonProperty(PropertyName = "runbookId")]
        public string RunbookId { get; set; }

        /// <summary>
        /// The runbook timeout.
        /// </summary>
        [JsonProperty(PropertyName = "timeout")]
        public string Timeout { get; set; }

        /// <summary>
        /// The fabric location. Possible values include: 'Primary', 'Recovery'
        /// </summary>
        [JsonProperty(PropertyName = "fabricLocation")]
        public RecoveryPlanActionLocation FabricLocation { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
        }
    }
}
