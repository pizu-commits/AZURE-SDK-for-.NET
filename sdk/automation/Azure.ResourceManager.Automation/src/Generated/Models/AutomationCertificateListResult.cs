// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Automation;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The response model for the list certificate operation. </summary>
    internal partial class AutomationCertificateListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AutomationCertificateListResult"/>. </summary>
        internal AutomationCertificateListResult()
        {
            Value = new ChangeTrackingList<AutomationCertificateData>();
        }

        /// <summary> Initializes a new instance of <see cref="AutomationCertificateListResult"/>. </summary>
        /// <param name="value"> Gets or sets a list of certificates. </param>
        /// <param name="nextLink"> Gets or sets the next link. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AutomationCertificateListResult(IReadOnlyList<AutomationCertificateData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Gets or sets a list of certificates. </summary>
        public IReadOnlyList<AutomationCertificateData> Value { get; }
        /// <summary> Gets or sets the next link. </summary>
        public string NextLink { get; }
    }
}
