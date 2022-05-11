// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ElasticSan.Models
{
    /// <summary> Iscsi target information. </summary>
    public partial class IscsiTargetInfo
    {
        /// <summary> Initializes a new instance of IscsiTargetInfo. </summary>
        internal IscsiTargetInfo()
        {
        }

        /// <summary> Initializes a new instance of IscsiTargetInfo. </summary>
        /// <param name="targetIqn"> iSCSI Target IQN (iSCSI Qualified Name); example: &quot;iqn.2005-03.org.iscsi:server&quot;. </param>
        /// <param name="targetPortalHostname"> iSCSI Target Portal Host Name. </param>
        /// <param name="targetPortalPort"> iSCSI Target Portal Port. </param>
        /// <param name="provisioningState"> State of the operation on the resource. </param>
        /// <param name="status"> Operational status of the iSCSI Target. </param>
        internal IscsiTargetInfo(string targetIqn, string targetPortalHostname, int? targetPortalPort, ProvisioningStates? provisioningState, OperationalStatus? status)
        {
            TargetIqn = targetIqn;
            TargetPortalHostname = targetPortalHostname;
            TargetPortalPort = targetPortalPort;
            ProvisioningState = provisioningState;
            Status = status;
        }

        /// <summary> iSCSI Target IQN (iSCSI Qualified Name); example: &quot;iqn.2005-03.org.iscsi:server&quot;. </summary>
        public string TargetIqn { get; }
        /// <summary> iSCSI Target Portal Host Name. </summary>
        public string TargetPortalHostname { get; }
        /// <summary> iSCSI Target Portal Port. </summary>
        public int? TargetPortalPort { get; }
        /// <summary> State of the operation on the resource. </summary>
        public ProvisioningStates? ProvisioningState { get; }
        /// <summary> Operational status of the iSCSI Target. </summary>
        public OperationalStatus? Status { get; }
    }
}
