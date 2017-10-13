// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Vpn device configuration script generation parameters
    /// </summary>
    public partial class VpnDeviceScriptParameters
    {
        /// <summary>
        /// Initializes a new instance of the VpnDeviceScriptParameters class.
        /// </summary>
        public VpnDeviceScriptParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VpnDeviceScriptParameters class.
        /// </summary>
        /// <param name="vendor">The vendor for the vpn device.</param>
        /// <param name="deviceFamily">The device family for the vpn
        /// device.</param>
        /// <param name="firmwareVersion">The firmware version for the vpn
        /// device.</param>
        public VpnDeviceScriptParameters(string vendor = default(string), string deviceFamily = default(string), string firmwareVersion = default(string))
        {
            Vendor = vendor;
            DeviceFamily = deviceFamily;
            FirmwareVersion = firmwareVersion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the vendor for the vpn device.
        /// </summary>
        [JsonProperty(PropertyName = "vendor")]
        public string Vendor { get; set; }

        /// <summary>
        /// Gets or sets the device family for the vpn device.
        /// </summary>
        [JsonProperty(PropertyName = "deviceFamily")]
        public string DeviceFamily { get; set; }

        /// <summary>
        /// Gets or sets the firmware version for the vpn device.
        /// </summary>
        [JsonProperty(PropertyName = "firmwareVersion")]
        public string FirmwareVersion { get; set; }

    }
}
