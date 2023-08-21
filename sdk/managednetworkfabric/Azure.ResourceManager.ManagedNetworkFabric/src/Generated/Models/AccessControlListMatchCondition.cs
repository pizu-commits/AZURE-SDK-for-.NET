// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Defines the match condition that is supported to filter the traffic. </summary>
    public partial class AccessControlListMatchCondition : CommonMatchConditions
    {
        /// <summary> Initializes a new instance of AccessControlListMatchCondition. </summary>
        public AccessControlListMatchCondition()
        {
            EtherTypes = new Core.ChangeTrackingList<string>();
            Fragments = new Core.ChangeTrackingList<string>();
            IPLengths = new Core.ChangeTrackingList<string>();
            TtlValues = new Core.ChangeTrackingList<string>();
            DscpMarkings = new Core.ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of AccessControlListMatchCondition. </summary>
        /// <param name="protocolTypes"> List of the protocols that need to be matched. </param>
        /// <param name="vlanMatchCondition"> Vlan match condition that needs to be matched. </param>
        /// <param name="ipCondition"> IP condition that needs to be matched. </param>
        /// <param name="etherTypes"> List of ether type values that needs to be matched. </param>
        /// <param name="fragments"> List of IP fragment packets that needs to be matched. </param>
        /// <param name="ipLengths"> List of IP Lengths that needs to be matched. </param>
        /// <param name="ttlValues"> List of TTL [Time To Live] values that needs to be matched. </param>
        /// <param name="dscpMarkings"> List of DSCP Markings that needs to be matched. </param>
        /// <param name="portCondition"> Defines the port condition that needs to be matched. </param>
        internal AccessControlListMatchCondition(IList<string> protocolTypes, VlanMatchCondition vlanMatchCondition, IPMatchCondition ipCondition, IList<string> etherTypes, IList<string> fragments, IList<string> ipLengths, IList<string> ttlValues, IList<string> dscpMarkings, AccessControlListPortCondition portCondition) : base(protocolTypes, vlanMatchCondition, ipCondition)
        {
            EtherTypes = etherTypes;
            Fragments = fragments;
            IPLengths = ipLengths;
            TtlValues = ttlValues;
            DscpMarkings = dscpMarkings;
            PortCondition = portCondition;
        }

        /// <summary> List of ether type values that needs to be matched. </summary>
        public IList<string> EtherTypes { get; }
        /// <summary> List of IP fragment packets that needs to be matched. </summary>
        public IList<string> Fragments { get; }
        /// <summary> List of IP Lengths that needs to be matched. </summary>
        public IList<string> IPLengths { get; }
        /// <summary> List of TTL [Time To Live] values that needs to be matched. </summary>
        public IList<string> TtlValues { get; }
        /// <summary> List of DSCP Markings that needs to be matched. </summary>
        public IList<string> DscpMarkings { get; }
        /// <summary> Defines the port condition that needs to be matched. </summary>
        public AccessControlListPortCondition PortCondition { get; set; }
    }
}
