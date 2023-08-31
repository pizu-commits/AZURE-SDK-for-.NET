// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Connected Subnet properties. </summary>
    public partial class ConnectedSubnet : AnnotationResourceProperties
    {
        /// <summary> Initializes a new instance of <see cref="ConnectedSubnet"/>. </summary>
        /// <param name="prefix"> Prefix of the Connected Subnet. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="prefix"/> is null. </exception>
        public ConnectedSubnet(string prefix)
        {
            Argument.AssertNotNull(prefix, nameof(prefix));

            Prefix = prefix;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectedSubnet"/>. </summary>
        /// <param name="annotation"> Switch configuration description. </param>
        /// <param name="prefix"> Prefix of the Connected Subnet. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ConnectedSubnet(string annotation, string prefix, Dictionary<string, BinaryData> rawData) : base(annotation, rawData)
        {
            Prefix = prefix;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectedSubnet"/> for deserialization. </summary>
        internal ConnectedSubnet()
        {
        }

        /// <summary> Prefix of the Connected Subnet. </summary>
        public string Prefix { get; set; }
    }
}
