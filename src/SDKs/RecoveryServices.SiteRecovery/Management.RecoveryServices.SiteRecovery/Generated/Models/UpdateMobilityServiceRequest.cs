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
    /// Request to update the mobility service on a protected item.
    /// </summary>
    public partial class UpdateMobilityServiceRequest
    {
        /// <summary>
        /// Initializes a new instance of the UpdateMobilityServiceRequest
        /// class.
        /// </summary>
        public UpdateMobilityServiceRequest() { }

        /// <summary>
        /// Initializes a new instance of the UpdateMobilityServiceRequest
        /// class.
        /// </summary>
        public UpdateMobilityServiceRequest(UpdateMobilityServiceRequestProperties properties = default(UpdateMobilityServiceRequestProperties))
        {
            Properties = properties;
        }

        /// <summary>
        /// The properties of the update mobility service request.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public UpdateMobilityServiceRequestProperties Properties { get; set; }

    }
}
