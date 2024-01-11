// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sphere.Models
{
    /// <summary> Request of the action to list device groups for a catalog. </summary>
    public partial class ListSphereDeviceGroupsContent
    {
        /// <summary> Initializes a new instance of <see cref="ListSphereDeviceGroupsContent"/>. </summary>
        public ListSphereDeviceGroupsContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ListSphereDeviceGroupsContent"/>. </summary>
        /// <param name="deviceGroupName"> Device Group name. </param>
        internal ListSphereDeviceGroupsContent(string deviceGroupName)
        {
            DeviceGroupName = deviceGroupName;
        }

        /// <summary> Device Group name. </summary>
        public string DeviceGroupName { get; set; }
    }
}
