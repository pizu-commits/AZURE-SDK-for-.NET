// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Paged list of content items. </summary>
    internal partial class ContentItemListResult
    {
        /// <summary> Initializes a new instance of ContentItemListResult. </summary>
        internal ContentItemListResult()
        {
            Value = new Core.ChangeTrackingList<ApiManagementContentItem>();
        }

        /// <summary> Initializes a new instance of ContentItemListResult. </summary>
        /// <param name="value"> Collection of content items. </param>
        /// <param name="nextLink"> Next page link, if any. </param>
        internal ContentItemListResult(IReadOnlyList<ApiManagementContentItem> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Collection of content items. </summary>
        public IReadOnlyList<ApiManagementContentItem> Value { get; }
        /// <summary> Next page link, if any. </summary>
        public string NextLink { get; }
    }
}
