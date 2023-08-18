// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Automation;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The response model for the list variables operation. </summary>
    internal partial class AutomationVariableListResult
    {
        /// <summary> Initializes a new instance of AutomationVariableListResult. </summary>
        internal AutomationVariableListResult()
        {
            Value = new Core.ChangeTrackingList<AutomationVariableData>();
        }

        /// <summary> Initializes a new instance of AutomationVariableListResult. </summary>
        /// <param name="value"> Gets or sets a list of variables. </param>
        /// <param name="nextLink"> Gets or sets the next link. </param>
        internal AutomationVariableListResult(IReadOnlyList<AutomationVariableData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets or sets a list of variables. </summary>
        public IReadOnlyList<AutomationVariableData> Value { get; }
        /// <summary> Gets or sets the next link. </summary>
        public string NextLink { get; }
    }
}
