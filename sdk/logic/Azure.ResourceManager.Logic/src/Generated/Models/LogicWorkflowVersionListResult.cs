// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Logic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The list of workflow versions. </summary>
    internal partial class LogicWorkflowVersionListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="LogicWorkflowVersionListResult"/>. </summary>
        internal LogicWorkflowVersionListResult()
        {
            Value = new ChangeTrackingList<LogicWorkflowVersionData>();
        }

        /// <summary> Initializes a new instance of <see cref="LogicWorkflowVersionListResult"/>. </summary>
        /// <param name="value"> A list of workflow versions. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal LogicWorkflowVersionListResult(IReadOnlyList<LogicWorkflowVersionData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> A list of workflow versions. </summary>
        public IReadOnlyList<LogicWorkflowVersionData> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
