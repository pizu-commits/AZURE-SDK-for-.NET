// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CustomerInsights;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    /// <summary> The response of list view operation. </summary>
    internal partial class ViewListResult
    {
        /// <summary> Initializes a new instance of <see cref="ViewListResult"/>. </summary>
        internal ViewListResult()
        {
            Value = new ChangeTrackingList<ViewResourceFormatData>();
        }

        /// <summary> Initializes a new instance of <see cref="ViewListResult"/>. </summary>
        /// <param name="value"> Results of the list operation. </param>
        /// <param name="nextLink"> Link to the next set of results. </param>
        internal ViewListResult(IReadOnlyList<ViewResourceFormatData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Results of the list operation. </summary>
        public IReadOnlyList<ViewResourceFormatData> Value { get; }
        /// <summary> Link to the next set of results. </summary>
        public string NextLink { get; }
    }
}
