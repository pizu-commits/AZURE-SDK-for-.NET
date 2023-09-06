// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Action that need to performed. </summary>
    public partial class AccessControlListAction
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AccessControlListAction"/>. </summary>
        public AccessControlListAction()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AccessControlListAction"/>. </summary>
        /// <param name="aclActionType"> Type of actions that can be performed. </param>
        /// <param name="counterName"> Name of the counter block to get match count information. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AccessControlListAction(AclActionType? aclActionType, string counterName, Dictionary<string, BinaryData> rawData)
        {
            AclActionType = aclActionType;
            CounterName = counterName;
            _rawData = rawData;
        }

        /// <summary> Type of actions that can be performed. </summary>
        public AclActionType? AclActionType { get; set; }
        /// <summary> Name of the counter block to get match count information. </summary>
        public string CounterName { get; set; }
    }
}
