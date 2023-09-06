// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The ResourcesResponseCustomDomainsItem. </summary>
    public partial class ResourcesResponseCustomDomainsItem
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ResourcesResponseCustomDomainsItem"/>. </summary>
        internal ResourcesResponseCustomDomainsItem()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ResourcesResponseCustomDomainsItem"/>. </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="endpointId"></param>
        /// <param name="history"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourcesResponseCustomDomainsItem(string id, string name, string endpointId, bool? history, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            Name = name;
            EndpointId = endpointId;
            History = history;
            _rawData = rawData;
        }

        /// <summary> Gets the id. </summary>
        public string Id { get; }
        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Gets the endpoint id. </summary>
        public string EndpointId { get; }
        /// <summary> Gets the history. </summary>
        public bool? History { get; }
    }
}
