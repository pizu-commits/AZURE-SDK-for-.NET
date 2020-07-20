// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Messaging.EventGrid.Models
{
    /// <summary> Schema of the Data property of an EventGridEvent for a device connection state event (DeviceConnected, DeviceDisconnected). </summary>
    public partial class DeviceConnectionStateEventProperties
    {
        /// <summary> Initializes a new instance of DeviceConnectionStateEventProperties. </summary>
        internal DeviceConnectionStateEventProperties()
        {
        }

        /// <summary> Initializes a new instance of DeviceConnectionStateEventProperties. </summary>
        /// <param name="deviceId"> The unique identifier of the device. This case-sensitive string can be up to 128 characters long, and supports ASCII 7-bit alphanumeric characters plus the following special characters: - : . + % _ &amp;#35; * ? ! ( ) , = @ ; $ &apos;. </param>
        /// <param name="moduleId"> The unique identifier of the module. This case-sensitive string can be up to 128 characters long, and supports ASCII 7-bit alphanumeric characters plus the following special characters: - : . + % _ &amp;#35; * ? ! ( ) , = @ ; $ &apos;. </param>
        /// <param name="hubName"> Name of the IoT Hub where the device was created or deleted. </param>
        /// <param name="deviceConnectionStateEventInfo"> Information about the device connection state event. </param>
        internal DeviceConnectionStateEventProperties(string deviceId, string moduleId, string hubName, DeviceConnectionStateEventInfo deviceConnectionStateEventInfo)
        {
            DeviceId = deviceId;
            ModuleId = moduleId;
            HubName = hubName;
            DeviceConnectionStateEventInfo = deviceConnectionStateEventInfo;
        }

        /// <summary> The unique identifier of the device. This case-sensitive string can be up to 128 characters long, and supports ASCII 7-bit alphanumeric characters plus the following special characters: - : . + % _ &amp;#35; * ? ! ( ) , = @ ; $ &apos;. </summary>
        public string DeviceId { get; }
        /// <summary> The unique identifier of the module. This case-sensitive string can be up to 128 characters long, and supports ASCII 7-bit alphanumeric characters plus the following special characters: - : . + % _ &amp;#35; * ? ! ( ) , = @ ; $ &apos;. </summary>
        public string ModuleId { get; }
        /// <summary> Name of the IoT Hub where the device was created or deleted. </summary>
        public string HubName { get; }
        /// <summary> Information about the device connection state event. </summary>
        public DeviceConnectionStateEventInfo DeviceConnectionStateEventInfo { get; }
    }
}
