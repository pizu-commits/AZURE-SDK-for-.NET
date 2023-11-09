// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Advisor;

namespace Azure.ResourceManager.Advisor.Models
{
    /// <summary> The list of metadata entities. </summary>
    internal partial class MetadataEntityListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MetadataEntityListResult"/>. </summary>
        internal MetadataEntityListResult()
        {
            Value = new ChangeTrackingList<MetadataEntityData>();
        }

        /// <summary> Initializes a new instance of <see cref="MetadataEntityListResult"/>. </summary>
        /// <param name="value"> The list of metadata entities. </param>
        /// <param name="nextLink"> The link used to get the next page of metadata. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MetadataEntityListResult(IReadOnlyList<MetadataEntityData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of metadata entities. </summary>
        public IReadOnlyList<MetadataEntityData> Value { get; }
        /// <summary> The link used to get the next page of metadata. </summary>
        public string NextLink { get; }
    }
}
