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
    /// Implements the Alert class.
    /// </summary>
    public partial class Alert : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Alert class.
        /// </summary>
        public Alert() { }

        /// <summary>
        /// Initializes a new instance of the Alert class.
        /// </summary>
        public Alert(string id = default(string), string name = default(string), string type = default(string), string location = default(string), AlertProperties properties = default(AlertProperties))
            : base(id, name, type, location)
        {
            Properties = properties;
        }

        /// <summary>
        /// Alert related data.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public AlertProperties Properties { get; set; }

    }
}
