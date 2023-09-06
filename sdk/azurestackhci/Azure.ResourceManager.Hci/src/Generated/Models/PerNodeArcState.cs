// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> Status of Arc agent for a particular node in HCI Cluster. </summary>
    public partial class PerNodeArcState
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PerNodeArcState"/>. </summary>
        internal PerNodeArcState()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PerNodeArcState"/>. </summary>
        /// <param name="name"> Name of the Node in HCI Cluster. </param>
        /// <param name="arcInstance"> Fully qualified resource ID for the Arc agent of this node. </param>
        /// <param name="state"> State of Arc agent in this node. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PerNodeArcState(string name, string arcInstance, NodeArcState? state, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            ArcInstance = arcInstance;
            State = state;
            _rawData = rawData;
        }

        /// <summary> Name of the Node in HCI Cluster. </summary>
        public string Name { get; }
        /// <summary> Fully qualified resource ID for the Arc agent of this node. </summary>
        public string ArcInstance { get; }
        /// <summary> State of Arc agent in this node. </summary>
        public NodeArcState? State { get; }
    }
}
