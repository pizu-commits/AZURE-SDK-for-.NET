// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> The BlobFlatListSegment. </summary>
    internal partial class BlobFlatListSegment
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BlobFlatListSegment"/>. </summary>
        /// <param name="blobItems"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="blobItems"/> is null. </exception>
        internal BlobFlatListSegment(IEnumerable<BlobItemInternal> blobItems)
        {
            Argument.AssertNotNull(blobItems, nameof(blobItems));

            BlobItems = blobItems.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="BlobFlatListSegment"/>. </summary>
        /// <param name="blobItems"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BlobFlatListSegment(IReadOnlyList<BlobItemInternal> blobItems, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            BlobItems = blobItems;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BlobFlatListSegment"/> for deserialization. </summary>
        internal BlobFlatListSegment()
        {
        }

        /// <summary> Gets the blob items. </summary>
        public IReadOnlyList<BlobItemInternal> BlobItems { get; }
    }
}
