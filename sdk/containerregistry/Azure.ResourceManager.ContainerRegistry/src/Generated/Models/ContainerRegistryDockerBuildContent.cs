// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The parameters for a docker quick build. </summary>
    public partial class ContainerRegistryDockerBuildContent : ContainerRegistryRunContent
    {
        /// <summary> Initializes a new instance of <see cref="ContainerRegistryDockerBuildContent"/>. </summary>
        /// <param name="dockerFilePath"> The Docker file path relative to the source location. </param>
        /// <param name="platform"> The platform properties against which the run has to happen. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dockerFilePath"/> or <paramref name="platform"/> is null. </exception>
        public ContainerRegistryDockerBuildContent(string dockerFilePath, ContainerRegistryPlatformProperties platform)
        {
            Argument.AssertNotNull(dockerFilePath, nameof(dockerFilePath));
            Argument.AssertNotNull(platform, nameof(platform));

            ImageNames = new ChangeTrackingList<string>();
            DockerFilePath = dockerFilePath;
            Arguments = new ChangeTrackingList<ContainerRegistryRunArgument>();
            Platform = platform;
            RunRequestType = "DockerBuildRequest";
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryDockerBuildContent"/>. </summary>
        /// <param name="runRequestType"> The type of the run request. </param>
        /// <param name="isArchiveEnabled"> The value that indicates whether archiving is enabled for the run or not. </param>
        /// <param name="agentPoolName"> The dedicated agent pool for the run. </param>
        /// <param name="logTemplate"> The template that describes the repository and tag information for run log artifact. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="imageNames"> The fully qualified image names including the repository and tag. </param>
        /// <param name="isPushEnabled"> The value of this property indicates whether the image built should be pushed to the registry or not. </param>
        /// <param name="noCache"> The value of this property indicates whether the image cache is enabled or not. </param>
        /// <param name="dockerFilePath"> The Docker file path relative to the source location. </param>
        /// <param name="target"> The name of the target build stage for the docker build. </param>
        /// <param name="arguments"> The collection of override arguments to be used when executing the run. </param>
        /// <param name="timeoutInSeconds"> Run timeout in seconds. </param>
        /// <param name="platform"> The platform properties against which the run has to happen. </param>
        /// <param name="agentConfiguration"> The machine configuration of the run agent. </param>
        /// <param name="sourceLocation">
        /// The URL(absolute or relative) of the source context. It can be an URL to a tar or git repository.
        /// If it is relative URL, the relative path should be obtained from calling listBuildSourceUploadUrl API.
        /// </param>
        /// <param name="credentials"> The properties that describes a set of credentials that will be used when this run is invoked. </param>
        internal ContainerRegistryDockerBuildContent(string runRequestType, bool? isArchiveEnabled, string agentPoolName, string logTemplate, IDictionary<string, BinaryData> serializedAdditionalRawData, IList<string> imageNames, bool? isPushEnabled, bool? noCache, string dockerFilePath, string target, IList<ContainerRegistryRunArgument> arguments, int? timeoutInSeconds, ContainerRegistryPlatformProperties platform, ContainerRegistryAgentProperties agentConfiguration, string sourceLocation, ContainerRegistryCredentials credentials) : base(runRequestType, isArchiveEnabled, agentPoolName, logTemplate, serializedAdditionalRawData)
        {
            ImageNames = imageNames;
            IsPushEnabled = isPushEnabled;
            NoCache = noCache;
            DockerFilePath = dockerFilePath;
            Target = target;
            Arguments = arguments;
            TimeoutInSeconds = timeoutInSeconds;
            Platform = platform;
            AgentConfiguration = agentConfiguration;
            SourceLocation = sourceLocation;
            Credentials = credentials;
            RunRequestType = runRequestType ?? "DockerBuildRequest";
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryDockerBuildContent"/> for deserialization. </summary>
        internal ContainerRegistryDockerBuildContent()
        {
        }

        /// <summary> The fully qualified image names including the repository and tag. </summary>
        [WirePath("imageNames")]
        public IList<string> ImageNames { get; }
        /// <summary> The value of this property indicates whether the image built should be pushed to the registry or not. </summary>
        [WirePath("isPushEnabled")]
        public bool? IsPushEnabled { get; set; }
        /// <summary> The value of this property indicates whether the image cache is enabled or not. </summary>
        [WirePath("noCache")]
        public bool? NoCache { get; set; }
        /// <summary> The Docker file path relative to the source location. </summary>
        [WirePath("dockerFilePath")]
        public string DockerFilePath { get; set; }
        /// <summary> The name of the target build stage for the docker build. </summary>
        [WirePath("target")]
        public string Target { get; set; }
        /// <summary> The collection of override arguments to be used when executing the run. </summary>
        [WirePath("arguments")]
        public IList<ContainerRegistryRunArgument> Arguments { get; }
        /// <summary> Run timeout in seconds. </summary>
        [WirePath("timeout")]
        public int? TimeoutInSeconds { get; set; }
        /// <summary> The platform properties against which the run has to happen. </summary>
        [WirePath("platform")]
        public ContainerRegistryPlatformProperties Platform { get; set; }
        /// <summary> The machine configuration of the run agent. </summary>
        internal ContainerRegistryAgentProperties AgentConfiguration { get; set; }
        /// <summary> The CPU configuration in terms of number of cores required for the run. </summary>
        [WirePath("agentConfiguration.cpu")]
        public int? AgentCpu
        {
            get => AgentConfiguration is null ? default : AgentConfiguration.Cpu;
            set
            {
                if (AgentConfiguration is null)
                    AgentConfiguration = new ContainerRegistryAgentProperties();
                AgentConfiguration.Cpu = value;
            }
        }

        /// <summary>
        /// The URL(absolute or relative) of the source context. It can be an URL to a tar or git repository.
        /// If it is relative URL, the relative path should be obtained from calling listBuildSourceUploadUrl API.
        /// </summary>
        [WirePath("sourceLocation")]
        public string SourceLocation { get; set; }
        /// <summary> The properties that describes a set of credentials that will be used when this run is invoked. </summary>
        [WirePath("credentials")]
        public ContainerRegistryCredentials Credentials { get; set; }
    }
}
