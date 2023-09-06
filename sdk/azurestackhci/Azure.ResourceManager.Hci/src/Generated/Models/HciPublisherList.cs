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
    /// <summary> List of Publisher proxy resources for the HCI cluster. </summary>
    internal partial class HciPublisherList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="HciPublisherList"/>. </summary>
        internal HciPublisherList()
        {
            Value = new ChangeTrackingList<PublisherData>();
        }

        /// <summary> Initializes a new instance of <see cref="HciPublisherList"/>. </summary>
        /// <param name="value"> List of Publisher proxy resources. </param>
        /// <param name="nextLink"> Link to the next set of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal HciPublisherList(IReadOnlyList<PublisherData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> List of Publisher proxy resources. </summary>
        public IReadOnlyList<PublisherData> Value { get; }
        /// <summary> Link to the next set of results. </summary>
        public string NextLink { get; }
    }
}
