// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Automation;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The response model for the list certificate operation. </summary>
    internal partial class AutomationCertificateListResult
    {
        /// <summary> Initializes a new instance of AutomationCertificateListResult. </summary>
        internal AutomationCertificateListResult()
        {
            Value = new Core.ChangeTrackingList<AutomationCertificateData>();
        }

        /// <summary> Initializes a new instance of AutomationCertificateListResult. </summary>
        /// <param name="value"> Gets or sets a list of certificates. </param>
        /// <param name="nextLink"> Gets or sets the next link. </param>
        internal AutomationCertificateListResult(IReadOnlyList<AutomationCertificateData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets or sets a list of certificates. </summary>
        public IReadOnlyList<AutomationCertificateData> Value { get; }
        /// <summary> Gets or sets the next link. </summary>
        public string NextLink { get; }
    }
}
