// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Azure VM workload-specific additional information for job.
    /// </summary>
    public partial class AzureWorkloadJobExtendedInfo
    {
        /// <summary>
        /// Initializes a new instance of the AzureWorkloadJobExtendedInfo
        /// class.
        /// </summary>
        public AzureWorkloadJobExtendedInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureWorkloadJobExtendedInfo
        /// class.
        /// </summary>
        /// <param name="tasksList">List of tasks for this job</param>
        /// <param name="propertyBag">Job properties.</param>
        /// <param name="dynamicErrorMessage">Non localized error message on
        /// job execution.</param>
        public AzureWorkloadJobExtendedInfo(IList<AzureWorkloadJobTaskDetails> tasksList = default(IList<AzureWorkloadJobTaskDetails>), IDictionary<string, string> propertyBag = default(IDictionary<string, string>), string dynamicErrorMessage = default(string))
        {
            TasksList = tasksList;
            PropertyBag = propertyBag;
            DynamicErrorMessage = dynamicErrorMessage;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of tasks for this job
        /// </summary>
        [JsonProperty(PropertyName = "tasksList")]
        public IList<AzureWorkloadJobTaskDetails> TasksList { get; set; }

        /// <summary>
        /// Gets or sets job properties.
        /// </summary>
        [JsonProperty(PropertyName = "propertyBag")]
        public IDictionary<string, string> PropertyBag { get; set; }

        /// <summary>
        /// Gets or sets non localized error message on job execution.
        /// </summary>
        [JsonProperty(PropertyName = "dynamicErrorMessage")]
        public string DynamicErrorMessage { get; set; }

    }
}
