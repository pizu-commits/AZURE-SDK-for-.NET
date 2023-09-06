// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.IoT.Hub.Service.Models
{
    /// <summary> The parameters to execute a direct method on the device. </summary>
    public partial class CloudToDeviceMethodRequest
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CloudToDeviceMethodRequest"/>. </summary>
        public CloudToDeviceMethodRequest()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CloudToDeviceMethodRequest"/>. </summary>
        /// <param name="methodName"> The name of the method to execute. </param>
        /// <param name="payload"> The JSON-formatted direct method payload, up to 128kb in size. </param>
        /// <param name="responseTimeoutInSeconds"> The time (in seconds) that the service waits for the method invocation to return a response. The default is 30 seconds, minimum is 5 seconds, and maximum is 300 seconds. </param>
        /// <param name="connectTimeoutInSeconds"> The time (in seconds) that the service waits for the device to come online. The default is 0 seconds (which means the device must already be online) and the maximum is 300 seconds. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CloudToDeviceMethodRequest(string methodName, object payload, int? responseTimeoutInSeconds, int? connectTimeoutInSeconds, Dictionary<string, BinaryData> rawData)
        {
            MethodName = methodName;
            Payload = payload;
            ResponseTimeoutInSeconds = responseTimeoutInSeconds;
            ConnectTimeoutInSeconds = connectTimeoutInSeconds;
            _rawData = rawData;
        }

        /// <summary> The name of the method to execute. </summary>
        public string MethodName { get; set; }
        /// <summary> The JSON-formatted direct method payload, up to 128kb in size. </summary>
        public object Payload { get; set; }
        /// <summary> The time (in seconds) that the service waits for the method invocation to return a response. The default is 30 seconds, minimum is 5 seconds, and maximum is 300 seconds. </summary>
        public int? ResponseTimeoutInSeconds { get; set; }
        /// <summary> The time (in seconds) that the service waits for the device to come online. The default is 0 seconds (which means the device must already be online) and the maximum is 300 seconds. </summary>
        public int? ConnectTimeoutInSeconds { get; set; }
    }
}
