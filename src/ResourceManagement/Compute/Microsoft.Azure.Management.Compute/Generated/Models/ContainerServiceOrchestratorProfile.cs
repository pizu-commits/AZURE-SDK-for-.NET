// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Profile for Orchestrator
    /// </summary>
    public partial class ContainerServiceOrchestratorProfile
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ContainerServiceOrchestratorProfile class.
        /// </summary>
        public ContainerServiceOrchestratorProfile() { }

        /// <summary>
        /// Initializes a new instance of the
        /// ContainerServiceOrchestratorProfile class.
        /// </summary>
        public ContainerServiceOrchestratorProfile(ContainerServiceOchestratorTypes? orchestratorType = default(ContainerServiceOchestratorTypes?))
        {
            OrchestratorType = orchestratorType;
        }

        /// <summary>
        /// Specifies what orchestrator will be used to manage container
        /// cluster resources. Possible values include: 'SwarmPreview', 'DCOS'
        /// </summary>
        [JsonProperty(PropertyName = "orchestratorType")]
        public ContainerServiceOchestratorTypes? OrchestratorType { get; set; }

    }
}
