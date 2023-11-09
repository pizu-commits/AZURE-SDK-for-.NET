// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    /// <summary> A class represent a AppComplianceAutomation report resource update properties. </summary>
    public partial class ReportResourcePatch
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ReportResourcePatch"/>. </summary>
        public ReportResourcePatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ReportResourcePatch"/>. </summary>
        /// <param name="properties"> Report property. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ReportResourcePatch(ReportProperties properties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Report property. </summary>
        public ReportProperties Properties { get; set; }
    }
}
