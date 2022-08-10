// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ResourceMover;

namespace Azure.ResourceManager.ResourceMover.Models
{
    /// <summary> Defines the collection of move resources. </summary>
    internal partial class MoveResourceList
    {
        /// <summary> Initializes a new instance of MoveResourceList. </summary>
        internal MoveResourceList()
        {
            Value = new ChangeTrackingList<MoveResourceData>();
        }

        /// <summary> Initializes a new instance of MoveResourceList. </summary>
        /// <param name="value"> Gets the list of move resources. </param>
        /// <param name="nextLink"> Gets the value of  next link. </param>
        /// <param name="summaryCollection"> Gets or sets the list of summary items and the field on which summary is done. </param>
        /// <param name="totalCount"> Gets the total count. </param>
        internal MoveResourceList(IReadOnlyList<MoveResourceData> value, string nextLink, MoverSummaryList summaryCollection, long? totalCount)
        {
            Value = value;
            NextLink = nextLink;
            SummaryCollection = summaryCollection;
            TotalCount = totalCount;
        }

        /// <summary> Gets the list of move resources. </summary>
        public IReadOnlyList<MoveResourceData> Value { get; }
        /// <summary> Gets the value of  next link. </summary>
        public string NextLink { get; }
        /// <summary> Gets or sets the list of summary items and the field on which summary is done. </summary>
        public MoverSummaryList SummaryCollection { get; }
        /// <summary> Gets the total count. </summary>
        public long? TotalCount { get; }
    }
}
