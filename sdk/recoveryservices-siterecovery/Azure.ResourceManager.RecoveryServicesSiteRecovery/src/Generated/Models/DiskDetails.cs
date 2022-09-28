// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Onprem disk details data. </summary>
    public partial class DiskDetails
    {
        /// <summary> Initializes a new instance of DiskDetails. </summary>
        internal DiskDetails()
        {
        }

        /// <summary> Initializes a new instance of DiskDetails. </summary>
        /// <param name="maxSizeMB"> The hard disk max size in MB. </param>
        /// <param name="vhdType"> The type of the volume. </param>
        /// <param name="vhdId"> The VHD Id. </param>
        /// <param name="vhdName"> The VHD name. </param>
        internal DiskDetails(long? maxSizeMB, string vhdType, string vhdId, string vhdName)
        {
            MaxSizeMB = maxSizeMB;
            VhdType = vhdType;
            VhdId = vhdId;
            VhdName = vhdName;
        }

        /// <summary> The hard disk max size in MB. </summary>
        public long? MaxSizeMB { get; }
        /// <summary> The type of the volume. </summary>
        public string VhdType { get; }
        /// <summary> The VHD Id. </summary>
        public string VhdId { get; }
        /// <summary> The VHD name. </summary>
        public string VhdName { get; }
    }
}
