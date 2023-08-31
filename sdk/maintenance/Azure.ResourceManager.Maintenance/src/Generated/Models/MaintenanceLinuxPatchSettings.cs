// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Maintenance.Models
{
    /// <summary> Input properties for patching a Linux machine. </summary>
    public partial class MaintenanceLinuxPatchSettings
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MaintenanceLinuxPatchSettings"/>. </summary>
        public MaintenanceLinuxPatchSettings()
        {
            PackageNameMasksToExclude = new ChangeTrackingList<string>();
            PackageNameMasksToInclude = new ChangeTrackingList<string>();
            ClassificationsToInclude = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="MaintenanceLinuxPatchSettings"/>. </summary>
        /// <param name="packageNameMasksToExclude"> Package names to be excluded for patching. </param>
        /// <param name="packageNameMasksToInclude"> Package names to be included for patching. </param>
        /// <param name="classificationsToInclude"> Classification category of patches to be patched. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MaintenanceLinuxPatchSettings(IList<string> packageNameMasksToExclude, IList<string> packageNameMasksToInclude, IList<string> classificationsToInclude, Dictionary<string, BinaryData> rawData)
        {
            PackageNameMasksToExclude = packageNameMasksToExclude;
            PackageNameMasksToInclude = packageNameMasksToInclude;
            ClassificationsToInclude = classificationsToInclude;
            _rawData = rawData;
        }

        /// <summary> Package names to be excluded for patching. </summary>
        public IList<string> PackageNameMasksToExclude { get; }
        /// <summary> Package names to be included for patching. </summary>
        public IList<string> PackageNameMasksToInclude { get; }
        /// <summary> Classification category of patches to be patched. </summary>
        public IList<string> ClassificationsToInclude { get; }
    }
}
