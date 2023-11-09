// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Protocol-specific configuration. </summary>
    internal partial class ConnectivityCheckRequestProtocolConfiguration
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ConnectivityCheckRequestProtocolConfiguration"/>. </summary>
        public ConnectivityCheckRequestProtocolConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ConnectivityCheckRequestProtocolConfiguration"/>. </summary>
        /// <param name="httpConfiguration"> Configuration for HTTP or HTTPS requests. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConnectivityCheckRequestProtocolConfiguration(ConnectivityCheckRequestHttpConfiguration httpConfiguration, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            HttpConfiguration = httpConfiguration;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Configuration for HTTP or HTTPS requests. </summary>
        public ConnectivityCheckRequestHttpConfiguration HttpConfiguration { get; set; }
    }
}
