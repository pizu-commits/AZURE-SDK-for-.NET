// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> Status of Arc Extension for a particular node in HCI Cluster. </summary>
    public partial class PerNodeExtensionState
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PerNodeExtensionState"/>. </summary>
        internal PerNodeExtensionState()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PerNodeExtensionState"/>. </summary>
        /// <param name="name"> Name of the node in HCI Cluster. </param>
        /// <param name="extension"> Fully qualified resource ID for the particular Arc Extension on this node. </param>
        /// <param name="typeHandlerVersion"> Specifies the version of the script handler. </param>
        /// <param name="state"> State of Arc Extension in this node. </param>
        /// <param name="instanceView"> The extension instance view. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PerNodeExtensionState(string name, string extension, string typeHandlerVersion, NodeExtensionState? state, HciExtensionInstanceView instanceView, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            Extension = extension;
            TypeHandlerVersion = typeHandlerVersion;
            State = state;
            InstanceView = instanceView;
            _rawData = rawData;
        }

        /// <summary> Name of the node in HCI Cluster. </summary>
        public string Name { get; }
        /// <summary> Fully qualified resource ID for the particular Arc Extension on this node. </summary>
        public string Extension { get; }
        /// <summary> Specifies the version of the script handler. </summary>
        public string TypeHandlerVersion { get; }
        /// <summary> State of Arc Extension in this node. </summary>
        public NodeExtensionState? State { get; }
        /// <summary> The extension instance view. </summary>
        public HciExtensionInstanceView InstanceView { get; }
    }
}
