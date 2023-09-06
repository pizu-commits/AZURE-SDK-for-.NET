// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    /// <summary> A list which includes all the compliance result for one report. </summary>
    internal partial class ReportComplianceStatus
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ReportComplianceStatus"/>. </summary>
        internal ReportComplianceStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ReportComplianceStatus"/>. </summary>
        /// <param name="m365"> The Microsoft 365 certification name. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ReportComplianceStatus(OverviewStatus m365, Dictionary<string, BinaryData> rawData)
        {
            M365 = m365;
            _rawData = rawData;
        }

        /// <summary> The Microsoft 365 certification name. </summary>
        public OverviewStatus M365 { get; }
    }
}
