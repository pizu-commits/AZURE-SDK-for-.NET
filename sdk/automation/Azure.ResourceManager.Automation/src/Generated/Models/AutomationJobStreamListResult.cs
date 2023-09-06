// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The response model for the list job stream operation. </summary>
    internal partial class AutomationJobStreamListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AutomationJobStreamListResult"/>. </summary>
        internal AutomationJobStreamListResult()
        {
            Value = new ChangeTrackingList<AutomationJobStream>();
        }

        /// <summary> Initializes a new instance of <see cref="AutomationJobStreamListResult"/>. </summary>
        /// <param name="value"> A list of job streams. </param>
        /// <param name="nextLink"> Gets or sets the next link. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AutomationJobStreamListResult(IReadOnlyList<AutomationJobStream> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> A list of job streams. </summary>
        public IReadOnlyList<AutomationJobStream> Value { get; }
        /// <summary> Gets or sets the next link. </summary>
        public string NextLink { get; }
    }
}
