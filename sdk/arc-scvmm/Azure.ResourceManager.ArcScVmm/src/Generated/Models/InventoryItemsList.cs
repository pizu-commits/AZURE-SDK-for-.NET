// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.ArcScVmm;

namespace Azure.ResourceManager.ArcScVmm.Models
{
    /// <summary> List of InventoryItems. </summary>
    internal partial class InventoryItemsList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="InventoryItemsList"/>. </summary>
        /// <param name="value"> Array of InventoryItems. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal InventoryItemsList(IEnumerable<InventoryItemData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="InventoryItemsList"/>. </summary>
        /// <param name="nextLink"> Url to follow for getting next page of InventoryItems. </param>
        /// <param name="value"> Array of InventoryItems. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InventoryItemsList(string nextLink, IReadOnlyList<InventoryItemData> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NextLink = nextLink;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="InventoryItemsList"/> for deserialization. </summary>
        internal InventoryItemsList()
        {
        }

        /// <summary> Url to follow for getting next page of InventoryItems. </summary>
        public string NextLink { get; }
        /// <summary> Array of InventoryItems. </summary>
        public IReadOnlyList<InventoryItemData> Value { get; }
    }
}
