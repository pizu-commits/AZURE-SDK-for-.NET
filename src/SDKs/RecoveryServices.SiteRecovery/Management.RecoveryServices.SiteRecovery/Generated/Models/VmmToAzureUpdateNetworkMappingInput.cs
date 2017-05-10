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
    /// Update network mappings input properties/behaviour specific to vmm to
    /// azure.
    /// </summary>
    public partial class VmmToAzureUpdateNetworkMappingInput : FabricSpecificUpdateNetworkMappingInput
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VmmToAzureUpdateNetworkMappingInput class.
        /// </summary>
        public VmmToAzureUpdateNetworkMappingInput() { }

        /// <summary>
        /// Initializes a new instance of the
        /// VmmToAzureUpdateNetworkMappingInput class.
        /// </summary>
        public VmmToAzureUpdateNetworkMappingInput(string instanceType = default(string))
            : base(instanceType)
        {
        }

    }
}
