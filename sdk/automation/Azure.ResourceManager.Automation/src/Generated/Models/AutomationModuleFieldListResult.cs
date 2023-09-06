// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The response model for the list fields operation. </summary>
    internal partial class AutomationModuleFieldListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AutomationModuleFieldListResult"/>. </summary>
        internal AutomationModuleFieldListResult()
        {
            Value = new ChangeTrackingList<AutomationModuleField>();
        }

        /// <summary> Initializes a new instance of <see cref="AutomationModuleFieldListResult"/>. </summary>
        /// <param name="value"> Gets or sets a list of fields. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AutomationModuleFieldListResult(IReadOnlyList<AutomationModuleField> value, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            _rawData = rawData;
        }

        /// <summary> Gets or sets a list of fields. </summary>
        public IReadOnlyList<AutomationModuleField> Value { get; }
    }
}
