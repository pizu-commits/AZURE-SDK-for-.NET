// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Parameters required for content purge. </summary>
    public partial class PurgeContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PurgeContent"/>. </summary>
        /// <param name="contentPaths"> The path to the content to be purged. Can describe a file path or a wild card directory. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="contentPaths"/> is null. </exception>
        public PurgeContent(IEnumerable<string> contentPaths)
        {
            Argument.AssertNotNull(contentPaths, nameof(contentPaths));

            ContentPaths = contentPaths.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="PurgeContent"/>. </summary>
        /// <param name="contentPaths"> The path to the content to be purged. Can describe a file path or a wild card directory. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PurgeContent(IList<string> contentPaths, Dictionary<string, BinaryData> rawData)
        {
            ContentPaths = contentPaths;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="PurgeContent"/> for deserialization. </summary>
        internal PurgeContent()
        {
        }

        /// <summary> The path to the content to be purged. Can describe a file path or a wild card directory. </summary>
        public IList<string> ContentPaths { get; }
    }
}
