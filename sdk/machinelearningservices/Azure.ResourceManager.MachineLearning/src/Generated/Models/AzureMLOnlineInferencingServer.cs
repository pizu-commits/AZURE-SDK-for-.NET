// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Azure ML online inferencing configurations. </summary>
    public partial class AzureMLOnlineInferencingServer : InferencingServer
    {
        /// <summary> Initializes a new instance of <see cref="AzureMLOnlineInferencingServer"/>. </summary>
        public AzureMLOnlineInferencingServer()
        {
            ServerType = InferencingServerType.AzureMLOnline;
        }

        /// <summary> Initializes a new instance of <see cref="AzureMLOnlineInferencingServer"/>. </summary>
        /// <param name="serverType"> [Required] Inferencing server type for various targets. </param>
        /// <param name="codeConfiguration"> Code configuration for AML inferencing server. </param>
        internal AzureMLOnlineInferencingServer(InferencingServerType serverType, MachineLearningCodeConfiguration codeConfiguration) : base(serverType)
        {
            CodeConfiguration = codeConfiguration;
            ServerType = serverType;
        }

        /// <summary> Code configuration for AML inferencing server. </summary>
        public MachineLearningCodeConfiguration CodeConfiguration { get; set; }
    }
}
