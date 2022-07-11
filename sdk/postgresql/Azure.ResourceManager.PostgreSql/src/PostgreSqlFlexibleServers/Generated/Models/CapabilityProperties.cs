// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> Location capabilities. </summary>
    public partial class CapabilityProperties
    {
        /// <summary> Initializes a new instance of CapabilityProperties. </summary>
        internal CapabilityProperties()
        {
            SupportedFlexibleServerEditions = new ChangeTrackingList<FlexibleServerEditionCapability>();
            SupportedHyperscaleNodeEditions = new ChangeTrackingList<HyperscaleNodeEditionCapability>();
            SupportedHAMode = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of CapabilityProperties. </summary>
        /// <param name="zone"> zone name. </param>
        /// <param name="geoBackupSupported"> A value indicating whether a new server in this region can have geo-backups to paired region. </param>
        /// <param name="zoneRedundantHaSupported"> A value indicating whether a new server in this region can support multi zone HA. </param>
        /// <param name="zoneRedundantHaAndGeoBackupSupported"> A value indicating whether a new server in this region can have geo-backups to paired region. </param>
        /// <param name="supportedFlexibleServerEditions"></param>
        /// <param name="supportedHyperscaleNodeEditions"></param>
        /// <param name="supportedHAMode"> Supported high availability mode. </param>
        /// <param name="status"> The status. </param>
        internal CapabilityProperties(string zone, bool? geoBackupSupported, bool? zoneRedundantHaSupported, bool? zoneRedundantHaAndGeoBackupSupported, IReadOnlyList<FlexibleServerEditionCapability> supportedFlexibleServerEditions, IReadOnlyList<HyperscaleNodeEditionCapability> supportedHyperscaleNodeEditions, IReadOnlyList<string> supportedHAMode, string status)
        {
            Zone = zone;
            GeoBackupSupported = geoBackupSupported;
            ZoneRedundantHaSupported = zoneRedundantHaSupported;
            ZoneRedundantHaAndGeoBackupSupported = zoneRedundantHaAndGeoBackupSupported;
            SupportedFlexibleServerEditions = supportedFlexibleServerEditions;
            SupportedHyperscaleNodeEditions = supportedHyperscaleNodeEditions;
            SupportedHAMode = supportedHAMode;
            Status = status;
        }

        /// <summary> zone name. </summary>
        public string Zone { get; }
        /// <summary> A value indicating whether a new server in this region can have geo-backups to paired region. </summary>
        public bool? GeoBackupSupported { get; }
        /// <summary> A value indicating whether a new server in this region can support multi zone HA. </summary>
        public bool? ZoneRedundantHaSupported { get; }
        /// <summary> A value indicating whether a new server in this region can have geo-backups to paired region. </summary>
        public bool? ZoneRedundantHaAndGeoBackupSupported { get; }
        /// <summary> Gets the supported flexible server editions. </summary>
        public IReadOnlyList<FlexibleServerEditionCapability> SupportedFlexibleServerEditions { get; }
        /// <summary> Gets the supported hyperscale node editions. </summary>
        public IReadOnlyList<HyperscaleNodeEditionCapability> SupportedHyperscaleNodeEditions { get; }
        /// <summary> Supported high availability mode. </summary>
        public IReadOnlyList<string> SupportedHAMode { get; }
        /// <summary> The status. </summary>
        public string Status { get; }
    }
}
