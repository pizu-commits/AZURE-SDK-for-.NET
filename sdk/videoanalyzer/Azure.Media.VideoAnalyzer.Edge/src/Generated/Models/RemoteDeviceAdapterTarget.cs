// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Properties of the remote device adapter target. </summary>
    public partial class RemoteDeviceAdapterTarget
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RemoteDeviceAdapterTarget"/>. </summary>
        /// <param name="host"> Hostname or IP address of the remote device. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="host"/> is null. </exception>
        public RemoteDeviceAdapterTarget(string host)
        {
            Argument.AssertNotNull(host, nameof(host));

            Host = host;
        }

        /// <summary> Initializes a new instance of <see cref="RemoteDeviceAdapterTarget"/>. </summary>
        /// <param name="host"> Hostname or IP address of the remote device. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RemoteDeviceAdapterTarget(string host, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Host = host;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RemoteDeviceAdapterTarget"/> for deserialization. </summary>
        internal RemoteDeviceAdapterTarget()
        {
        }

        /// <summary> Hostname or IP address of the remote device. </summary>
        public string Host { get; set; }
    }
}
