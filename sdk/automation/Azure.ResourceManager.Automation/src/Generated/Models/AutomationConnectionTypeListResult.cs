// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Automation;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The response model for the list connection type operation. </summary>
    internal partial class AutomationConnectionTypeListResult
    {
        /// <summary> Initializes a new instance of AutomationConnectionTypeListResult. </summary>
        internal AutomationConnectionTypeListResult()
        {
            Value = new Core.ChangeTrackingList<AutomationConnectionTypeData>();
        }

        /// <summary> Initializes a new instance of AutomationConnectionTypeListResult. </summary>
        /// <param name="value"> Gets or sets a list of connection types. </param>
        /// <param name="nextLink"> Gets or sets the next link. </param>
        internal AutomationConnectionTypeListResult(IReadOnlyList<AutomationConnectionTypeData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets or sets a list of connection types. </summary>
        public IReadOnlyList<AutomationConnectionTypeData> Value { get; }
        /// <summary> Gets or sets the next link. </summary>
        public string NextLink { get; }
    }
}
