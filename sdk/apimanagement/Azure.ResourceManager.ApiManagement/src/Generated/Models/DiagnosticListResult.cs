// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ApiManagement;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Paged Diagnostic list representation. </summary>
    internal partial class DiagnosticListResult
    {
        /// <summary> Initializes a new instance of DiagnosticListResult. </summary>
        internal DiagnosticListResult()
        {
            Value = new Core.ChangeTrackingList<DiagnosticContractData>();
        }

        /// <summary> Initializes a new instance of DiagnosticListResult. </summary>
        /// <param name="value"> Page values. </param>
        /// <param name="count"> Total record count number across all pages. </param>
        /// <param name="nextLink"> Next page link if any. </param>
        internal DiagnosticListResult(IReadOnlyList<DiagnosticContractData> value, long? count, string nextLink)
        {
            Value = value;
            Count = count;
            NextLink = nextLink;
        }

        /// <summary> Page values. </summary>
        public IReadOnlyList<DiagnosticContractData> Value { get; }
        /// <summary> Total record count number across all pages. </summary>
        public long? Count { get; }
        /// <summary> Next page link if any. </summary>
        public string NextLink { get; }
    }
}
