// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Storage.Files.DataLake.Models
{
    /// <summary> The BlobPrefix. </summary>
    internal partial class BlobPrefix
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BlobPrefix"/>. </summary>
        /// <param name="name"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        internal BlobPrefix(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="BlobPrefix"/>. </summary>
        /// <param name="name"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BlobPrefix(string name, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BlobPrefix"/> for deserialization. </summary>
        internal BlobPrefix()
        {
        }

        /// <summary> Gets the name. </summary>
        public string Name { get; }
    }
}
