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
    /// <summary> The list of workflow run actions. </summary>
    internal partial class LogicWorkflowRunActionListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="LogicWorkflowRunActionListResult"/>. </summary>
        internal LogicWorkflowRunActionListResult()
        {
            Value = new ChangeTrackingList<LogicWorkflowRunActionData>();
        }

        /// <summary> Initializes a new instance of <see cref="LogicWorkflowRunActionListResult"/>. </summary>
        /// <param name="value"> A list of workflow run actions. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal LogicWorkflowRunActionListResult(IReadOnlyList<LogicWorkflowRunActionData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> A list of workflow run actions. </summary>
        public IReadOnlyList<LogicWorkflowRunActionData> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
