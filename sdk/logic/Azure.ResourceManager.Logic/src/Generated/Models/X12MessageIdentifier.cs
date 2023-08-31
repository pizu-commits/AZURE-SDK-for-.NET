// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The X12 message identifier. </summary>
    public partial class X12MessageIdentifier
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="X12MessageIdentifier"/>. </summary>
        /// <param name="messageId"> The message id. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="messageId"/> is null. </exception>
        public X12MessageIdentifier(string messageId)
        {
            Argument.AssertNotNull(messageId, nameof(messageId));

            MessageId = messageId;
        }

        /// <summary> Initializes a new instance of <see cref="X12MessageIdentifier"/>. </summary>
        /// <param name="messageId"> The message id. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal X12MessageIdentifier(string messageId, Dictionary<string, BinaryData> rawData)
        {
            MessageId = messageId;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="X12MessageIdentifier"/> for deserialization. </summary>
        internal X12MessageIdentifier()
        {
        }

        /// <summary> The message id. </summary>
        public string MessageId { get; set; }
    }
}
