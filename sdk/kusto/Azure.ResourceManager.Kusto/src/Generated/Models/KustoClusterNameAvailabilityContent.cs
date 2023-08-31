// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> The result returned from a cluster check name availability request. </summary>
    public partial class KustoClusterNameAvailabilityContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="KustoClusterNameAvailabilityContent"/>. </summary>
        /// <param name="name"> Cluster name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public KustoClusterNameAvailabilityContent(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            ResourceType = KustoClusterType.MicrosoftKustoClusters;
        }

        /// <summary> Initializes a new instance of <see cref="KustoClusterNameAvailabilityContent"/>. </summary>
        /// <param name="name"> Cluster name. </param>
        /// <param name="resourceType"> The type of resource, Microsoft.Kusto/clusters. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal KustoClusterNameAvailabilityContent(string name, KustoClusterType resourceType, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            ResourceType = resourceType;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="KustoClusterNameAvailabilityContent"/> for deserialization. </summary>
        internal KustoClusterNameAvailabilityContent()
        {
        }

        /// <summary> Cluster name. </summary>
        public string Name { get; }
        /// <summary> The type of resource, Microsoft.Kusto/clusters. </summary>
        public KustoClusterType ResourceType { get; }
    }
}
