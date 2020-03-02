// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;

namespace Azure.Search.Models
{
    internal static class IndexActionTypeExtensions
    {
        public static string ToSerialString(this IndexActionType value) => value switch
        {
            IndexActionType.Upload => "upload",
            IndexActionType.Merge => "merge",
            IndexActionType.MergeOrUpload => "mergeOrUpload",
            IndexActionType.Delete => "delete",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown IndexActionType value.")
        };

        public static IndexActionType ToIndexActionType(this string value) => value switch
        {
            "upload" => IndexActionType.Upload,
            "merge" => IndexActionType.Merge,
            "mergeOrUpload" => IndexActionType.MergeOrUpload,
            "delete" => IndexActionType.Delete,
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown IndexActionType value.")
        };
    }
}
