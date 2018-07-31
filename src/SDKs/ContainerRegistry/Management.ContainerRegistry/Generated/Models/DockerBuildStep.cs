// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The Docker build step.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Docker")]
    public partial class DockerBuildStep : BuildStepProperties
    {
        /// <summary>
        /// Initializes a new instance of the DockerBuildStep class.
        /// </summary>
        public DockerBuildStep()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DockerBuildStep class.
        /// </summary>
        /// <param name="provisioningState">The provisioning state of the build
        /// step. Possible values include: 'Creating', 'Updating', 'Deleting',
        /// 'Succeeded', 'Failed', 'Canceled'</param>
        /// <param name="branch">The repository branch name.</param>
        /// <param name="imageNames">The fully qualified image names including
        /// the repository and tag.</param>
        /// <param name="isPushEnabled">The value of this property indicates
        /// whether the image built should be pushed to the registry or
        /// not.</param>
        /// <param name="noCache">The value of this property indicates whether
        /// the image cache is enabled or not.</param>
        /// <param name="dockerFilePath">The Docker file path relative to the
        /// source control root.</param>
        /// <param name="contextPath">The relative context path for a docker
        /// build in the source.</param>
        /// <param name="buildArguments">The custom arguments for building this
        /// build step.</param>
        /// <param name="baseImageDependencies">List of base image dependencies
        /// for a step.</param>
        /// <param name="baseImageTrigger">The type of the auto trigger for
        /// base image dependency updates. Possible values include: 'All',
        /// 'Runtime', 'None'</param>
        public DockerBuildStep(string provisioningState = default(string), string branch = default(string), IList<string> imageNames = default(IList<string>), bool? isPushEnabled = default(bool?), bool? noCache = default(bool?), string dockerFilePath = default(string), string contextPath = default(string), IList<BuildArgument> buildArguments = default(IList<BuildArgument>), IList<BaseImageDependency> baseImageDependencies = default(IList<BaseImageDependency>), string baseImageTrigger = default(string))
            : base(provisioningState)
        {
            Branch = branch;
            ImageNames = imageNames;
            IsPushEnabled = isPushEnabled;
            NoCache = noCache;
            DockerFilePath = dockerFilePath;
            ContextPath = contextPath;
            BuildArguments = buildArguments;
            BaseImageDependencies = baseImageDependencies;
            BaseImageTrigger = baseImageTrigger;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the repository branch name.
        /// </summary>
        [JsonProperty(PropertyName = "branch")]
        public string Branch { get; set; }

        /// <summary>
        /// Gets or sets the fully qualified image names including the
        /// repository and tag.
        /// </summary>
        [JsonProperty(PropertyName = "imageNames")]
        public IList<string> ImageNames { get; set; }

        /// <summary>
        /// Gets or sets the value of this property indicates whether the image
        /// built should be pushed to the registry or not.
        /// </summary>
        [JsonProperty(PropertyName = "isPushEnabled")]
        public bool? IsPushEnabled { get; set; }

        /// <summary>
        /// Gets or sets the value of this property indicates whether the image
        /// cache is enabled or not.
        /// </summary>
        [JsonProperty(PropertyName = "noCache")]
        public bool? NoCache { get; set; }

        /// <summary>
        /// Gets or sets the Docker file path relative to the source control
        /// root.
        /// </summary>
        [JsonProperty(PropertyName = "dockerFilePath")]
        public string DockerFilePath { get; set; }

        /// <summary>
        /// Gets or sets the relative context path for a docker build in the
        /// source.
        /// </summary>
        [JsonProperty(PropertyName = "contextPath")]
        public string ContextPath { get; set; }

        /// <summary>
        /// Gets or sets the custom arguments for building this build step.
        /// </summary>
        [JsonProperty(PropertyName = "buildArguments")]
        public IList<BuildArgument> BuildArguments { get; set; }

        /// <summary>
        /// Gets list of base image dependencies for a step.
        /// </summary>
        [JsonProperty(PropertyName = "baseImageDependencies")]
        public IList<BaseImageDependency> BaseImageDependencies { get; private set; }

        /// <summary>
        /// Gets or sets the type of the auto trigger for base image dependency
        /// updates. Possible values include: 'All', 'Runtime', 'None'
        /// </summary>
        [JsonProperty(PropertyName = "baseImageTrigger")]
        public string BaseImageTrigger { get; set; }

    }
}
