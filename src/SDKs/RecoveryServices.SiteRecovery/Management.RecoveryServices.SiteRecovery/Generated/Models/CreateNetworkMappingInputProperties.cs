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
    /// Common input details for network mapping operation.
    /// </summary>
    public partial class CreateNetworkMappingInputProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CreateNetworkMappingInputProperties class.
        /// </summary>
        public CreateNetworkMappingInputProperties() { }

        /// <summary>
        /// Initializes a new instance of the
        /// CreateNetworkMappingInputProperties class.
        /// </summary>
        public CreateNetworkMappingInputProperties(string recoveryFabricName = default(string), string recoveryNetworkId = default(string), FabricSpecificCreateNetworkMappingInput fabricSpecificDetails = default(FabricSpecificCreateNetworkMappingInput))
        {
            RecoveryFabricName = recoveryFabricName;
            RecoveryNetworkId = recoveryNetworkId;
            FabricSpecificDetails = fabricSpecificDetails;
        }

        /// <summary>
        /// Recovery fabric Name.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryFabricName")]
        public string RecoveryFabricName { get; set; }

        /// <summary>
        /// Recovery network Id.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryNetworkId")]
        public string RecoveryNetworkId { get; set; }

        /// <summary>
        /// Fabric specific input properties.
        /// </summary>
        [JsonProperty(PropertyName = "fabricSpecificDetails")]
        public FabricSpecificCreateNetworkMappingInput FabricSpecificDetails { get; set; }

    }
}
