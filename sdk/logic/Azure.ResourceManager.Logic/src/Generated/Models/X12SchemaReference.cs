// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The X12 schema reference. </summary>
    public partial class X12SchemaReference
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="X12SchemaReference"/>. </summary>
        /// <param name="messageId"> The message id. </param>
        /// <param name="schemaVersion"> The schema version. </param>
        /// <param name="schemaName"> The schema name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="messageId"/>, <paramref name="schemaVersion"/> or <paramref name="schemaName"/> is null. </exception>
        public X12SchemaReference(string messageId, string schemaVersion, string schemaName)
        {
            Argument.AssertNotNull(messageId, nameof(messageId));
            Argument.AssertNotNull(schemaVersion, nameof(schemaVersion));
            Argument.AssertNotNull(schemaName, nameof(schemaName));

            MessageId = messageId;
            SchemaVersion = schemaVersion;
            SchemaName = schemaName;
        }

        /// <summary> Initializes a new instance of <see cref="X12SchemaReference"/>. </summary>
        /// <param name="messageId"> The message id. </param>
        /// <param name="senderApplicationId"> The sender application id. </param>
        /// <param name="schemaVersion"> The schema version. </param>
        /// <param name="schemaName"> The schema name. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal X12SchemaReference(string messageId, string senderApplicationId, string schemaVersion, string schemaName, Dictionary<string, BinaryData> rawData)
        {
            MessageId = messageId;
            SenderApplicationId = senderApplicationId;
            SchemaVersion = schemaVersion;
            SchemaName = schemaName;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="X12SchemaReference"/> for deserialization. </summary>
        internal X12SchemaReference()
        {
        }

        /// <summary> The message id. </summary>
        public string MessageId { get; set; }
        /// <summary> The sender application id. </summary>
        public string SenderApplicationId { get; set; }
        /// <summary> The schema version. </summary>
        public string SchemaVersion { get; set; }
        /// <summary> The schema name. </summary>
        public string SchemaName { get; set; }
    }
}
