// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> Contains information about orchestrator. </summary>
    public partial class OrchestratorProfile
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="OrchestratorProfile"/>. </summary>
        internal OrchestratorProfile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="OrchestratorProfile"/>. </summary>
        /// <param name="isPreview"> Whether Kubernetes version is currently in preview. </param>
        /// <param name="orchestratorType"> Orchestrator type. </param>
        /// <param name="orchestratorVersion"> Orchestrator version (major, minor, patch). </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal OrchestratorProfile(bool? isPreview, string orchestratorType, string orchestratorVersion, Dictionary<string, BinaryData> rawData)
        {
            IsPreview = isPreview;
            OrchestratorType = orchestratorType;
            OrchestratorVersion = orchestratorVersion;
            _rawData = rawData;
        }

        /// <summary> Whether Kubernetes version is currently in preview. </summary>
        public bool? IsPreview { get; }
        /// <summary> Orchestrator type. </summary>
        public string OrchestratorType { get; }
        /// <summary> Orchestrator version (major, minor, patch). </summary>
        public string OrchestratorVersion { get; }
    }
}
