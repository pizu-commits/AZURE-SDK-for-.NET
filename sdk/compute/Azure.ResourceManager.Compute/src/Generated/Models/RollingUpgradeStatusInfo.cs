// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The status of the latest virtual machine scale set rolling upgrade. </summary>
    public partial class RollingUpgradeStatusInfo : Resource
    {
        /// <summary> Initializes a new instance of RollingUpgradeStatusInfo. </summary>
        /// <param name="location"> Resource location. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        public RollingUpgradeStatusInfo(string location) : base(location)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
        }

        /// <summary> Initializes a new instance of RollingUpgradeStatusInfo. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="policy"> The rolling upgrade policies applied for this upgrade. </param>
        /// <param name="runningStatus"> Information about the current running state of the overall upgrade. </param>
        /// <param name="progress"> Information about the number of virtual machine instances in each upgrade state. </param>
        /// <param name="error"> Error details for this upgrade, if there are any. </param>
        internal RollingUpgradeStatusInfo(string id, string name, string type, string location, IDictionary<string, string> tags, RollingUpgradePolicy policy, RollingUpgradeRunningStatus runningStatus, RollingUpgradeProgressInfo progress, ApiError error) : base(id, name, type, location, tags)
        {
            Policy = policy;
            RunningStatus = runningStatus;
            Progress = progress;
            Error = error;
        }

        /// <summary> The rolling upgrade policies applied for this upgrade. </summary>
        public RollingUpgradePolicy Policy { get; }
        /// <summary> Information about the current running state of the overall upgrade. </summary>
        public RollingUpgradeRunningStatus RunningStatus { get; }
        /// <summary> Information about the number of virtual machine instances in each upgrade state. </summary>
        public RollingUpgradeProgressInfo Progress { get; }
        /// <summary> Error details for this upgrade, if there are any. </summary>
        public ApiError Error { get; }
    }
}
