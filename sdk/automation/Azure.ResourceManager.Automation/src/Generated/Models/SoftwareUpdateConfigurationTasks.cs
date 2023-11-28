// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Task properties of the software update configuration. </summary>
    public partial class SoftwareUpdateConfigurationTasks
    {
        /// <summary> Initializes a new instance of <see cref="SoftwareUpdateConfigurationTasks"/>. </summary>
        public SoftwareUpdateConfigurationTasks()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SoftwareUpdateConfigurationTasks"/>. </summary>
        /// <param name="preTask"> Pre task properties. </param>
        /// <param name="postTask"> Post task properties. </param>
        internal SoftwareUpdateConfigurationTasks(SoftwareUpdateConfigurationTaskProperties preTask, SoftwareUpdateConfigurationTaskProperties postTask)
        {
            PreTask = preTask;
            PostTask = postTask;
        }

        /// <summary> Pre task properties. </summary>
        public SoftwareUpdateConfigurationTaskProperties PreTask { get; set; }
        /// <summary> Post task properties. </summary>
        public SoftwareUpdateConfigurationTaskProperties PostTask { get; set; }
    }
}
