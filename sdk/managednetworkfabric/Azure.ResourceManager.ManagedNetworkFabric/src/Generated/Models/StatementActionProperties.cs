// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Route policy action properties. </summary>
    public partial class StatementActionProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="StatementActionProperties"/>. </summary>
        /// <param name="actionType"> Action type. Example: Permit | Deny | Continue. </param>
        public StatementActionProperties(RoutePolicyActionType actionType)
        {
            ActionType = actionType;
        }

        /// <summary> Initializes a new instance of <see cref="StatementActionProperties"/>. </summary>
        /// <param name="localPreference"> Local Preference of the route policy. </param>
        /// <param name="actionType"> Action type. Example: Permit | Deny | Continue. </param>
        /// <param name="ipCommunityProperties"> IP Community Properties. </param>
        /// <param name="ipExtendedCommunityProperties"> IP Extended Community Properties. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal StatementActionProperties(long? localPreference, RoutePolicyActionType actionType, ActionIPCommunityProperties ipCommunityProperties, ActionIPExtendedCommunityProperties ipExtendedCommunityProperties, Dictionary<string, BinaryData> rawData)
        {
            LocalPreference = localPreference;
            ActionType = actionType;
            IPCommunityProperties = ipCommunityProperties;
            IPExtendedCommunityProperties = ipExtendedCommunityProperties;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="StatementActionProperties"/> for deserialization. </summary>
        internal StatementActionProperties()
        {
        }

        /// <summary> Local Preference of the route policy. </summary>
        public long? LocalPreference { get; set; }
        /// <summary> Action type. Example: Permit | Deny | Continue. </summary>
        public RoutePolicyActionType ActionType { get; set; }
        /// <summary> IP Community Properties. </summary>
        public ActionIPCommunityProperties IPCommunityProperties { get; set; }
        /// <summary> IP Extended Community Properties. </summary>
        public ActionIPExtendedCommunityProperties IPExtendedCommunityProperties { get; set; }
    }
}
