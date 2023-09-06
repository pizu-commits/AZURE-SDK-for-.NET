// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Paged list of content types. </summary>
    internal partial class ContentTypeListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ContentTypeListResult"/>. </summary>
        internal ContentTypeListResult()
        {
            Value = new ChangeTrackingList<ApiManagementContentType>();
        }

        /// <summary> Initializes a new instance of <see cref="ContentTypeListResult"/>. </summary>
        /// <param name="value"> Collection of content types. </param>
        /// <param name="nextLink"> Next page link, if any. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContentTypeListResult(IReadOnlyList<ApiManagementContentType> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Collection of content types. </summary>
        public IReadOnlyList<ApiManagementContentType> Value { get; }
        /// <summary> Next page link, if any. </summary>
        public string NextLink { get; }
    }
}
