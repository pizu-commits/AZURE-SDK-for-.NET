// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.StorageSync.Models
{
    /// <summary> Files not tiering error object. </summary>
    public partial class FilesNotTieringError
    {
        /// <summary> Initializes a new instance of <see cref="FilesNotTieringError"/>. </summary>
        internal FilesNotTieringError()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FilesNotTieringError"/>. </summary>
        /// <param name="errorCode"> Error code (HResult). </param>
        /// <param name="fileCount"> Count of files with this error. </param>
        internal FilesNotTieringError(int? errorCode, long? fileCount)
        {
            ErrorCode = errorCode;
            FileCount = fileCount;
        }

        /// <summary> Error code (HResult). </summary>
        public int? ErrorCode { get; }
        /// <summary> Count of files with this error. </summary>
        public long? FileCount { get; }
    }
}
