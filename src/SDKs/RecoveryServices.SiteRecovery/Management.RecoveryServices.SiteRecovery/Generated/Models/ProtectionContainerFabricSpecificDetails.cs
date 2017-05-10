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
    /// Base class for fabric specific details of container.
    /// </summary>
    public partial class ProtectionContainerFabricSpecificDetails
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ProtectionContainerFabricSpecificDetails class.
        /// </summary>
        public ProtectionContainerFabricSpecificDetails() { }

        /// <summary>
        /// Initializes a new instance of the
        /// ProtectionContainerFabricSpecificDetails class.
        /// </summary>
        public ProtectionContainerFabricSpecificDetails(string instanceType = default(string))
        {
            InstanceType = instanceType;
        }

        /// <summary>
        /// Gets the class type. Overriden in derived classes.
        /// </summary>
        [JsonProperty(PropertyName = "instanceType")]
        public string InstanceType { get; private set; }

    }
}
