// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Hci;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> List of Updates. </summary>
    internal partial class HciUpdateList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="HciUpdateList"/>. </summary>
        internal HciUpdateList()
        {
            Value = new ChangeTrackingList<UpdateData>();
        }

        /// <summary> Initializes a new instance of <see cref="HciUpdateList"/>. </summary>
        /// <param name="value"> List of Updates. </param>
        /// <param name="nextLink"> Link to the next set of results. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HciUpdateList(IReadOnlyList<UpdateData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of Updates. </summary>
        public IReadOnlyList<UpdateData> Value { get; }
        /// <summary> Link to the next set of results. </summary>
        public string NextLink { get; }
    }
}
