// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Build result log resource properties payload. </summary>
    public partial class AppPlatformBuildResultLog
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AppPlatformBuildResultLog"/>. </summary>
        internal AppPlatformBuildResultLog()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppPlatformBuildResultLog"/>. </summary>
        /// <param name="blobUri"> The public download URL of this build result log. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AppPlatformBuildResultLog(Uri blobUri, Dictionary<string, BinaryData> rawData)
        {
            BlobUri = blobUri;
            _rawData = rawData;
        }

        /// <summary> The public download URL of this build result log. </summary>
        public Uri BlobUri { get; }
    }
}
