// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> The connectivity check operation destination. </summary>
    public partial class ConnectivityCheckRequestDestination
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ConnectivityCheckRequestDestination"/>. </summary>
        /// <param name="address"> Destination address. Can either be an IP address or a FQDN. </param>
        /// <param name="port"> Destination port. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="address"/> is null. </exception>
        public ConnectivityCheckRequestDestination(string address, long port)
        {
            Argument.AssertNotNull(address, nameof(address));

            Address = address;
            Port = port;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectivityCheckRequestDestination"/>. </summary>
        /// <param name="address"> Destination address. Can either be an IP address or a FQDN. </param>
        /// <param name="port"> Destination port. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ConnectivityCheckRequestDestination(string address, long port, Dictionary<string, BinaryData> rawData)
        {
            Address = address;
            Port = port;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectivityCheckRequestDestination"/> for deserialization. </summary>
        internal ConnectivityCheckRequestDestination()
        {
        }

        /// <summary> Destination address. Can either be an IP address or a FQDN. </summary>
        public string Address { get; }
        /// <summary> Destination port. </summary>
        public long Port { get; }
    }
}
