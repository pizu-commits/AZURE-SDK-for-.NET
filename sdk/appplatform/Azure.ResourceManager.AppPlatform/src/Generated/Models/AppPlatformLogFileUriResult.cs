// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Log file URL payload. </summary>
    public partial class AppPlatformLogFileUriResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AppPlatformLogFileUriResult"/>. </summary>
        /// <param name="uri"> URL of the log file. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="uri"/> is null. </exception>
        internal AppPlatformLogFileUriResult(Uri uri)
        {
            Argument.AssertNotNull(uri, nameof(uri));

            Uri = uri;
        }

        /// <summary> Initializes a new instance of <see cref="AppPlatformLogFileUriResult"/>. </summary>
        /// <param name="uri"> URL of the log file. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppPlatformLogFileUriResult(Uri uri, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Uri = uri;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AppPlatformLogFileUriResult"/> for deserialization. </summary>
        internal AppPlatformLogFileUriResult()
        {
        }

        /// <summary> URL of the log file. </summary>
        public Uri Uri { get; }
    }
}
