// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The parameters supplied to the create or update node configuration operation. </summary>
    public partial class DscNodeConfigurationCreateOrUpdateContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DscNodeConfigurationCreateOrUpdateContent"/>. </summary>
        public DscNodeConfigurationCreateOrUpdateContent()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="DscNodeConfigurationCreateOrUpdateContent"/>. </summary>
        /// <param name="name"> Name of the node configuration. </param>
        /// <param name="tags"> Gets or sets the tags attached to the resource. </param>
        /// <param name="source"> Gets or sets the source. </param>
        /// <param name="configuration"> Gets or sets the configuration of the node. </param>
        /// <param name="isIncrementNodeConfigurationBuildRequired"> If a new build version of NodeConfiguration is required. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DscNodeConfigurationCreateOrUpdateContent(string name, IDictionary<string, string> tags, AutomationContentSource source, DscConfigurationAssociationProperty configuration, bool? isIncrementNodeConfigurationBuildRequired, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Tags = tags;
            Source = source;
            Configuration = configuration;
            IsIncrementNodeConfigurationBuildRequired = isIncrementNodeConfigurationBuildRequired;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name of the node configuration. </summary>
        public string Name { get; set; }
        /// <summary> Gets or sets the tags attached to the resource. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Gets or sets the source. </summary>
        public AutomationContentSource Source { get; set; }
        /// <summary> Gets or sets the configuration of the node. </summary>
        internal DscConfigurationAssociationProperty Configuration { get; set; }
        /// <summary> Gets or sets the name of the Dsc configuration. </summary>
        public string ConfigurationName
        {
            get => Configuration is null ? default : Configuration.ConfigurationName;
            set
            {
                if (Configuration is null)
                    Configuration = new DscConfigurationAssociationProperty();
                Configuration.ConfigurationName = value;
            }
        }

        /// <summary> If a new build version of NodeConfiguration is required. </summary>
        public bool? IsIncrementNodeConfigurationBuildRequired { get; set; }
    }
}
