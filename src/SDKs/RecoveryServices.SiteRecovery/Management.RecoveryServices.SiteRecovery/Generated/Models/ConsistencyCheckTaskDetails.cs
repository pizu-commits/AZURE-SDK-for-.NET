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
    /// This class contains monitoring details of all the inconsistent
    /// Protected Entites in Vmm.
    /// </summary>
    public partial class ConsistencyCheckTaskDetails : TaskTypeDetails
    {
        /// <summary>
        /// Initializes a new instance of the ConsistencyCheckTaskDetails
        /// class.
        /// </summary>
        public ConsistencyCheckTaskDetails() { }

        /// <summary>
        /// Initializes a new instance of the ConsistencyCheckTaskDetails
        /// class.
        /// </summary>
        public ConsistencyCheckTaskDetails(IList<InconsistentVmDetails> vmDetails = default(IList<InconsistentVmDetails>))
        {
            VmDetails = vmDetails;
        }

        /// <summary>
        /// The list of inconsistent Vm details.
        /// </summary>
        [JsonProperty(PropertyName = "vmDetails")]
        public IList<InconsistentVmDetails> VmDetails { get; set; }

    }
}
