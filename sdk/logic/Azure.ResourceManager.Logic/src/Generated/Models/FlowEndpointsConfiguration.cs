// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The endpoints configuration. </summary>
    public partial class FlowEndpointsConfiguration
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="FlowEndpointsConfiguration"/>. </summary>
        public FlowEndpointsConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FlowEndpointsConfiguration"/>. </summary>
        /// <param name="workflow"> The workflow endpoints. </param>
        /// <param name="connector"> The connector endpoints. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal FlowEndpointsConfiguration(FlowEndpoints workflow, FlowEndpoints connector, Dictionary<string, BinaryData> rawData)
        {
            Workflow = workflow;
            Connector = connector;
            _rawData = rawData;
        }

        /// <summary> The workflow endpoints. </summary>
        public FlowEndpoints Workflow { get; set; }
        /// <summary> The connector endpoints. </summary>
        public FlowEndpoints Connector { get; set; }
    }
}
