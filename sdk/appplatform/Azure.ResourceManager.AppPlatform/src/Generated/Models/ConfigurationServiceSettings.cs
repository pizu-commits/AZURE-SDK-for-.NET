// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> The settings of Application Configuration Service. </summary>
    public partial class ConfigurationServiceSettings
    {
        /// <summary> Initializes a new instance of ConfigurationServiceSettings. </summary>
        public ConfigurationServiceSettings()
        {
        }

        /// <summary> Initializes a new instance of ConfigurationServiceSettings. </summary>
        /// <param name="gitProperty"> Property of git environment. </param>
        internal ConfigurationServiceSettings(ConfigurationServiceGitProperty gitProperty)
        {
            GitProperty = gitProperty;
        }

        /// <summary> Property of git environment. </summary>
        internal ConfigurationServiceGitProperty GitProperty { get; set; }
        /// <summary> Repositories of Application Configuration Service git property. </summary>
        public IList<ConfigurationServiceGitRepository> GitPropertyRepositories
        {
            get
            {
                if (GitProperty is null)
                    GitProperty = new ConfigurationServiceGitProperty();
                return GitProperty.Repositories;
            }
        }
    }
}
