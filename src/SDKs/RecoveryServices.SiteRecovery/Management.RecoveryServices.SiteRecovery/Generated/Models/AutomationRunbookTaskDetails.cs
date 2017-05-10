// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
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
    /// This class represents the task details for an automation runbook.
    /// </summary>
    public partial class AutomationRunbookTaskDetails : TaskTypeDetails
    {
        /// <summary>
        /// Initializes a new instance of the AutomationRunbookTaskDetails
        /// class.
        /// </summary>
        public AutomationRunbookTaskDetails() { }

        /// <summary>
        /// Initializes a new instance of the AutomationRunbookTaskDetails
        /// class.
        /// </summary>
        public AutomationRunbookTaskDetails(string name = default(string), string cloudServiceName = default(string), string subscriptionId = default(string), string accountName = default(string), string runbookId = default(string), string runbookName = default(string), string jobId = default(string), string jobOutput = default(string), bool? isPrimarySideScript = default(bool?))
        {
            Name = name;
            CloudServiceName = cloudServiceName;
            SubscriptionId = subscriptionId;
            AccountName = accountName;
            RunbookId = runbookId;
            RunbookName = runbookName;
            JobId = jobId;
            JobOutput = jobOutput;
            IsPrimarySideScript = isPrimarySideScript;
        }

        /// <summary>
        /// The recovery plan task name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The cloud service of the automation runbook account.
        /// </summary>
        [JsonProperty(PropertyName = "cloudServiceName")]
        public string CloudServiceName { get; set; }

        /// <summary>
        /// The subscription Id of the automation runbook account.
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionId")]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// The automation account name of the runbook.
        /// </summary>
        [JsonProperty(PropertyName = "accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// The runbook Id.
        /// </summary>
        [JsonProperty(PropertyName = "runbookId")]
        public string RunbookId { get; set; }

        /// <summary>
        /// The runbook name.
        /// </summary>
        [JsonProperty(PropertyName = "runbookName")]
        public string RunbookName { get; set; }

        /// <summary>
        /// The job Id of the runbook execution.
        /// </summary>
        [JsonProperty(PropertyName = "jobId")]
        public string JobId { get; set; }

        /// <summary>
        /// The execution output of the runbook.
        /// </summary>
        [JsonProperty(PropertyName = "jobOutput")]
        public string JobOutput { get; set; }

        /// <summary>
        /// A value indicating whether it is a primary side script or not.
        /// </summary>
        [JsonProperty(PropertyName = "isPrimarySideScript")]
        public bool? IsPrimarySideScript { get; set; }

    }
}
