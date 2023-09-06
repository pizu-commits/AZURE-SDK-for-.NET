// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Update version properties. </summary>
    public partial class NetworkFabricUpdateVersionContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NetworkFabricUpdateVersionContent"/>. </summary>
        public NetworkFabricUpdateVersionContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NetworkFabricUpdateVersionContent"/>. </summary>
        /// <param name="version"> Specify the version. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkFabricUpdateVersionContent(string version, Dictionary<string, BinaryData> rawData)
        {
            Version = version;
            _rawData = rawData;
        }

        /// <summary> Specify the version. </summary>
        public string Version { get; set; }
    }
}
