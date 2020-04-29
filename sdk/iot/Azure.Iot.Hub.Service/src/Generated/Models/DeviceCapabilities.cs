// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Iot.Hub.Service.Models
{
    /// <summary> Status of Capabilities enabled on the device. </summary>
    public partial class DeviceCapabilities
    {
        /// <summary> Initializes a new instance of DeviceCapabilities. </summary>
        public DeviceCapabilities()
        {
        }

        /// <summary> Initializes a new instance of DeviceCapabilities. </summary>
        /// <param name="iotEdge"> Whether or not this device is an edge device or not. If null, this device is not an edge device. </param>
        internal DeviceCapabilities(bool? iotEdge)
        {
            IotEdge = iotEdge;
        }

        /// <summary> Whether or not this device is an edge device or not. If null, this device is not an edge device. </summary>
        public bool? IotEdge { get; set; }
    }
}
