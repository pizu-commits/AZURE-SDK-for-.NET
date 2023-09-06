// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> The vlan match conditions that need to be matched. </summary>
    public partial class VlanMatchCondition
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="VlanMatchCondition"/>. </summary>
        public VlanMatchCondition()
        {
            Vlans = new ChangeTrackingList<string>();
            InnerVlans = new ChangeTrackingList<string>();
            VlanGroupNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="VlanMatchCondition"/>. </summary>
        /// <param name="vlans"> List of vlans that need to be matched. </param>
        /// <param name="innerVlans"> List of inner vlans that need to be matched. </param>
        /// <param name="vlanGroupNames"> List of vlan group names that need to be matched. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VlanMatchCondition(IList<string> vlans, IList<string> innerVlans, IList<string> vlanGroupNames, Dictionary<string, BinaryData> rawData)
        {
            Vlans = vlans;
            InnerVlans = innerVlans;
            VlanGroupNames = vlanGroupNames;
            _rawData = rawData;
        }

        /// <summary> List of vlans that need to be matched. </summary>
        public IList<string> Vlans { get; }
        /// <summary> List of inner vlans that need to be matched. </summary>
        public IList<string> InnerVlans { get; }
        /// <summary> List of vlan group names that need to be matched. </summary>
        public IList<string> VlanGroupNames { get; }
    }
}
