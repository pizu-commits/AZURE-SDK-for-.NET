// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.Language.QuestionAnswering
{
    /// <summary> Object to provide the key value pair for each metadata. </summary>
    public partial class MetadataRecord
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MetadataRecord"/>. </summary>
        /// <param name="key"> Metadata Key from Metadata dictionary used in the QnA. </param>
        /// <param name="value"> Metadata Value from Metadata dictionary used in the QnA. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public MetadataRecord(string key, string value)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            Key = key;
            Value = value;
        }

        /// <summary> Initializes a new instance of <see cref="MetadataRecord"/>. </summary>
        /// <param name="key"> Metadata Key from Metadata dictionary used in the QnA. </param>
        /// <param name="value"> Metadata Value from Metadata dictionary used in the QnA. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MetadataRecord(string key, string value, Dictionary<string, BinaryData> rawData)
        {
            Key = key;
            Value = value;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="MetadataRecord"/> for deserialization. </summary>
        internal MetadataRecord()
        {
        }

        /// <summary> Metadata Key from Metadata dictionary used in the QnA. </summary>
        public string Key { get; }
        /// <summary> Metadata Value from Metadata dictionary used in the QnA. </summary>
        public string Value { get; }
    }
}
