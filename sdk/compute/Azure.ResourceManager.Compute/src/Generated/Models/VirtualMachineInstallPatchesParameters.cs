// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Input for InstallPatches as directly received by the API. </summary>
    public partial class VirtualMachineInstallPatchesParameters
    {
        /// <summary> Initializes a new instance of VirtualMachineInstallPatchesParameters. </summary>
        /// <param name="rebootSetting"> Defines when it is acceptable to reboot a VM during a software update operation. </param>
        public VirtualMachineInstallPatchesParameters(VmGuestPatchRebootSetting rebootSetting)
        {
            RebootSetting = rebootSetting;
        }

        /// <summary> Specifies the maximum amount of time that the operation will run. It must be an ISO 8601-compliant duration string such as PT4H (4 hours). </summary>
        public string MaximumDuration { get; set; }
        /// <summary> Defines when it is acceptable to reboot a VM during a software update operation. </summary>
        public VmGuestPatchRebootSetting RebootSetting { get; }
        /// <summary> Input for InstallPatches on a Windows VM, as directly received by the API. </summary>
        public WindowsParameters WindowsParameters { get; set; }
        /// <summary> Input for InstallPatches on a Linux VM, as directly received by the API. </summary>
        public LinuxParameters LinuxParameters { get; set; }
    }
}
