// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Conversations.Models
{
    /// <summary> The list key extra data kind. </summary>
    public partial class ListKey : ConversationEntityExtraInformation
    {
        /// <summary> Initializes a new instance of <see cref="ListKey"/>. </summary>
        internal ListKey()
        {
            ExtraInformationKind = ExtraInformationKind.ListKey;
        }

        /// <summary> Initializes a new instance of <see cref="ListKey"/>. </summary>
        /// <param name="extraInformationKind"> The extra information object kind. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="key"> The canonical form of the extracted entity. </param>
        internal ListKey(ExtraInformationKind extraInformationKind, IDictionary<string, BinaryData> serializedAdditionalRawData, string key) : base(extraInformationKind, serializedAdditionalRawData)
        {
            Key = key;
        }

        /// <summary> The canonical form of the extracted entity. </summary>
        public string Key { get; }
    }
}
