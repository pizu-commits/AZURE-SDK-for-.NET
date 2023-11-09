// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Task properties of the software update configuration. </summary>
    public partial class SoftwareUpdateConfigurationTaskProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SoftwareUpdateConfigurationTaskProperties"/>. </summary>
        public SoftwareUpdateConfigurationTaskProperties()
        {
            Parameters = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="SoftwareUpdateConfigurationTaskProperties"/>. </summary>
        /// <param name="parameters"> Gets or sets the parameters of the task. </param>
        /// <param name="source"> Gets or sets the name of the runbook. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SoftwareUpdateConfigurationTaskProperties(IDictionary<string, string> parameters, string source, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Parameters = parameters;
            Source = source;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the parameters of the task. </summary>
        public IDictionary<string, string> Parameters { get; }
        /// <summary> Gets or sets the name of the runbook. </summary>
        public string Source { get; set; }
    }
}
