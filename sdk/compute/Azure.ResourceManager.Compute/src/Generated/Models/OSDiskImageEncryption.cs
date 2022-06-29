// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Contains encryption settings for an OS disk image. </summary>
    public partial class OSDiskImageEncryption : DiskImageEncryption
    {
        /// <summary> Initializes a new instance of OSDiskImageEncryption. </summary>
        public OSDiskImageEncryption()
        {
        }

        /// <summary> Initializes a new instance of OSDiskImageEncryption. </summary>
        /// <param name="diskEncryptionSetId"> A relative URI containing the resource ID of the disk encryption set. </param>
        /// <param name="securityProfile"> This property specifies the security profile of an OS disk image. </param>
        internal OSDiskImageEncryption(ResourceIdentifier diskEncryptionSetId, OSDiskImageSecurityProfile securityProfile) : base(diskEncryptionSetId)
        {
            SecurityProfile = securityProfile;
        }

        /// <summary> This property specifies the security profile of an OS disk image. </summary>
        public OSDiskImageSecurityProfile SecurityProfile { get; set; }
    }
}
