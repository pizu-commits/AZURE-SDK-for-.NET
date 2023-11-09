// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Automation.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Automation
{
    /// <summary>
    /// A class representing the DscNodeConfiguration data model.
    /// Definition of the dsc node configuration.
    /// </summary>
    public partial class DscNodeConfigurationData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DscNodeConfigurationData"/>. </summary>
        public DscNodeConfigurationData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DscNodeConfigurationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="lastModifiedOn"> Gets or sets the last modified time. </param>
        /// <param name="createdOn"> Gets or sets creation time. </param>
        /// <param name="configuration"> Gets or sets the configuration of the node. </param>
        /// <param name="source"> Source of node configuration. </param>
        /// <param name="nodeCount"> Number of nodes with this node configuration assigned. </param>
        /// <param name="isIncrementNodeConfigurationBuildRequired"> If a new build version of NodeConfiguration is required. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DscNodeConfigurationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DateTimeOffset? lastModifiedOn, DateTimeOffset? createdOn, DscConfigurationAssociationProperty configuration, string source, long? nodeCount, bool? isIncrementNodeConfigurationBuildRequired, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            LastModifiedOn = lastModifiedOn;
            CreatedOn = createdOn;
            Configuration = configuration;
            Source = source;
            NodeCount = nodeCount;
            IsIncrementNodeConfigurationBuildRequired = isIncrementNodeConfigurationBuildRequired;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the last modified time. </summary>
        public DateTimeOffset? LastModifiedOn { get; set; }
        /// <summary> Gets or sets creation time. </summary>
        public DateTimeOffset? CreatedOn { get; set; }
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

        /// <summary> Source of node configuration. </summary>
        public string Source { get; set; }
        /// <summary> Number of nodes with this node configuration assigned. </summary>
        public long? NodeCount { get; set; }
        /// <summary> If a new build version of NodeConfiguration is required. </summary>
        public bool? IsIncrementNodeConfigurationBuildRequired { get; set; }
    }
}
