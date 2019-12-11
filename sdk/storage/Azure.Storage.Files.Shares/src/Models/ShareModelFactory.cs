﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Azure.Storage.Files.Shares.Models
{
    public static partial class ShareModelFactory
    {
        /// <summary>
        /// Creates a new StorageClosedHandlesSegment instance for mocking.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static StorageClosedHandlesSegment StorageClosedHandlesSegment(
            string marker,
            int numberOfHandlesClosed)
            => StorageClosedHandlesSegment(
                marker: marker,
                numberOfHandlesClosed: numberOfHandlesClosed,
                numberOfHandlesFailedToClosed: 0);

        /// <summary>
        /// Creates a new ShareProperties instance for mocking.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static ShareProperties ShareProperties(
            DateTimeOffset? lastModified,
            ETag? eTag,
            int? quotaInGB,
            IDictionary<string, string> metadata)
            => ShareProperties(
                lastModified: lastModified,
                eTag: eTag,
                quotaInGB: quotaInGB,
                metadata: metadata);
    }
}
