// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.IoT.Hub.Service.Models
{
    /// <summary> The ExportImportDevice. </summary>
    public partial class ExportImportDevice
    {
        /// <summary> Initializes a new instance of ExportImportDevice. </summary>
        public ExportImportDevice()
        {
            Tags = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> The unique identifier of the device. </summary>
        public string Id { get; set; }
        /// <summary> The unique identifier of the module, if applicable. </summary>
        public string ModuleId { get; set; }
        /// <summary> The string representing a weak ETag for the device RFC7232. The value is only used if import mode is updateIfMatchETag, in that case the import operation is performed only if this ETag matches the value maintained by the server. </summary>
        public string ETag { get; set; }
        /// <summary> The type of registry operation and ETag preferences. </summary>
        public ExportImportDeviceImportMode? ImportMode { get; set; }
        /// <summary> The status of the module. If disabled, the module cannot connect to the service. </summary>
        public ExportImportDeviceStatus? Status { get; set; }
        /// <summary> The 128 character-long string that stores the reason for the device identity status. All UTF-8 characters are allowed. </summary>
        public string StatusReason { get; set; }
        /// <summary> The authentication mechanism used by the module. This parameter is optional and defaults to SAS if not provided. In that case, primary/secondary access keys are auto-generated. </summary>
        public AuthenticationMechanism Authentication { get; set; }
        /// <summary> The string representing a weak ETag for the device twin RFC7232. The value is only used if import mode is updateIfMatchETag, in that case the import operation is performed only if this ETag matches the value maintained by the server. </summary>
        public string TwinETag { get; set; }
        /// <summary> The JSON document read and written by the solution back end. The tags are not visible to device apps. </summary>
        public IDictionary<string, object> Tags { get; }
        /// <summary> The desired and reported properties for the device. </summary>
        public PropertyContainer Properties { get; set; }
        /// <summary> The status of capabilities enabled on the device. </summary>
        public DeviceCapabilities Capabilities { get; set; }
        /// <summary> The scope of the device. </summary>
        public string DeviceScope { get; set; }
    }
}
