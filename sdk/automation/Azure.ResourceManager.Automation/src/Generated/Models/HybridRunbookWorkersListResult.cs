// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Automation;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The response model for the list hybrid runbook workers. </summary>
    internal partial class HybridRunbookWorkersListResult
    {
        /// <summary> Initializes a new instance of HybridRunbookWorkersListResult. </summary>
        internal HybridRunbookWorkersListResult()
        {
            Value = new ChangeTrackingList<HybridRunbookWorkerData>();
        }

        /// <summary> Initializes a new instance of HybridRunbookWorkersListResult. </summary>
        /// <param name="value"> Gets or sets a list of hybrid runbook workers. </param>
        /// <param name="nextLink"> Gets or sets the next link. </param>
        internal HybridRunbookWorkersListResult(IReadOnlyList<HybridRunbookWorkerData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets or sets a list of hybrid runbook workers. </summary>
        public IReadOnlyList<HybridRunbookWorkerData> Value { get; }
        /// <summary> Gets or sets the next link. </summary>
        public string NextLink { get; }
    }
}
