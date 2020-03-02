// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

namespace Azure.Search.Models
{
    /// <summary> The operation to perform on a document in an indexing batch. </summary>
    public enum IndexActionType
    {
        /// <summary> upload. </summary>
        Upload,
        /// <summary> merge. </summary>
        Merge,
        /// <summary> mergeOrUpload. </summary>
        MergeOrUpload,
        /// <summary> delete. </summary>
        Delete
    }
}
