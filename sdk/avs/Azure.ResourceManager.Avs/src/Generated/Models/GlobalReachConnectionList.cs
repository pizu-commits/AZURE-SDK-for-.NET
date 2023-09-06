// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Avs;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> A paged list of global reach connections. </summary>
    internal partial class GlobalReachConnectionList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="GlobalReachConnectionList"/>. </summary>
        internal GlobalReachConnectionList()
        {
            Value = new ChangeTrackingList<GlobalReachConnectionData>();
        }

        /// <summary> Initializes a new instance of <see cref="GlobalReachConnectionList"/>. </summary>
        /// <param name="value"> The items on a page. </param>
        /// <param name="nextLink"> URL to get the next page if any. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal GlobalReachConnectionList(IReadOnlyList<GlobalReachConnectionData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> The items on a page. </summary>
        public IReadOnlyList<GlobalReachConnectionData> Value { get; }
        /// <summary> URL to get the next page if any. </summary>
        public string NextLink { get; }
    }
}
