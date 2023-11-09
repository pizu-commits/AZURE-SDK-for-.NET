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
    /// <summary> The response model for the list connection operation. </summary>
    internal partial class AutomationConnectionListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AutomationConnectionListResult"/>. </summary>
        internal AutomationConnectionListResult()
        {
            Value = new ChangeTrackingList<AutomationConnectionData>();
        }

        /// <summary> Initializes a new instance of <see cref="AutomationConnectionListResult"/>. </summary>
        /// <param name="value"> Gets or sets a list of connection. </param>
        /// <param name="nextLink"> Gets or sets the next link. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AutomationConnectionListResult(IReadOnlyList<AutomationConnectionData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets a list of connection. </summary>
        public IReadOnlyList<AutomationConnectionData> Value { get; }
        /// <summary> Gets or sets the next link. </summary>
        public string NextLink { get; }
    }
}
