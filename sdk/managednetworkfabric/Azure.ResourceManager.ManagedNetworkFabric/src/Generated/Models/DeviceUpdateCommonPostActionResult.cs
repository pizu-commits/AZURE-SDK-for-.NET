// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Common response for device updates. </summary>
    public partial class DeviceUpdateCommonPostActionResult : NetworkFabricErrorResult
    {
        /// <summary> Initializes a new instance of DeviceUpdateCommonPostActionResult. </summary>
        internal DeviceUpdateCommonPostActionResult()
        {
            SuccessfulDevices = new ChangeTrackingList<string>();
            FailedDevices = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of DeviceUpdateCommonPostActionResult. </summary>
        /// <param name="error"> The error object. </param>
        /// <param name="configurationState"> Gets the configuration state. </param>
        /// <param name="successfulDevices"> List of ARM Resource IDs for which the given action applied successfully. </param>
        /// <param name="failedDevices"> List of ARM Resource IDs for which the given action failed to apply. </param>
        internal DeviceUpdateCommonPostActionResult(ResponseError error, NetworkFabricConfigurationState? configurationState, IReadOnlyList<string> successfulDevices, IReadOnlyList<string> failedDevices) : base(error)
        {
            ConfigurationState = configurationState;
            SuccessfulDevices = successfulDevices;
            FailedDevices = failedDevices;
        }

        /// <summary> Gets the configuration state. </summary>
        public NetworkFabricConfigurationState? ConfigurationState { get; }
        /// <summary> List of ARM Resource IDs for which the given action applied successfully. </summary>
        public IReadOnlyList<string> SuccessfulDevices { get; }
        /// <summary> List of ARM Resource IDs for which the given action failed to apply. </summary>
        public IReadOnlyList<string> FailedDevices { get; }
    }
}
