// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Defines the match condition that is supported to filter the traffic. </summary>
    public partial class NetworkTapRuleMatchCondition : CommonMatchConditions
    {
        /// <summary> Initializes a new instance of <see cref="NetworkTapRuleMatchCondition"/>. </summary>
        public NetworkTapRuleMatchCondition()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NetworkTapRuleMatchCondition"/>. </summary>
        /// <param name="protocolTypes"> List of the protocols that need to be matched. </param>
        /// <param name="vlanMatchCondition"> Vlan match condition that needs to be matched. </param>
        /// <param name="ipCondition"> IP condition that needs to be matched. </param>
        /// <param name="encapsulationType"> Encapsulation Type. </param>
        /// <param name="portCondition"> Defines the port condition that needs to be matched. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkTapRuleMatchCondition(IList<string> protocolTypes, VlanMatchCondition vlanMatchCondition, IPMatchCondition ipCondition, NetworkTapEncapsulationType? encapsulationType, NetworkFabricPortCondition portCondition, Dictionary<string, BinaryData> rawData) : base(protocolTypes, vlanMatchCondition, ipCondition, rawData)
        {
            EncapsulationType = encapsulationType;
            PortCondition = portCondition;
        }

        /// <summary> Encapsulation Type. </summary>
        public NetworkTapEncapsulationType? EncapsulationType { get; set; }
        /// <summary> Defines the port condition that needs to be matched. </summary>
        public NetworkFabricPortCondition PortCondition { get; set; }
    }
}
