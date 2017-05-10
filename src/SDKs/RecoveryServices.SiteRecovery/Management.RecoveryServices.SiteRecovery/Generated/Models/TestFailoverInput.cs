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
    /// Input definition for planned failover.
    /// </summary>
    public partial class TestFailoverInput
    {
        /// <summary>
        /// Initializes a new instance of the TestFailoverInput class.
        /// </summary>
        public TestFailoverInput() { }

        /// <summary>
        /// Initializes a new instance of the TestFailoverInput class.
        /// </summary>
        public TestFailoverInput(TestFailoverInputProperties properties = default(TestFailoverInputProperties))
        {
            Properties = properties;
        }

        /// <summary>
        /// Planned failover input properties
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public TestFailoverInputProperties Properties { get; set; }

    }
}
