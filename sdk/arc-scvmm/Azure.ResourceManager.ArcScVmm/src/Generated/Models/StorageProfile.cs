// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ArcScVmm.Models
{
    /// <summary> Defines the resource properties. </summary>
    internal partial class StorageProfile
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StorageProfile"/>. </summary>
        public StorageProfile()
        {
            Disks = new ChangeTrackingList<VirtualDisk>();
        }

        /// <summary> Initializes a new instance of <see cref="StorageProfile"/>. </summary>
        /// <param name="disks"> Gets or sets the list of virtual disks associated with the virtual machine. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageProfile(IList<VirtualDisk> disks, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Disks = disks;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the list of virtual disks associated with the virtual machine. </summary>
        public IList<VirtualDisk> Disks { get; }
    }
}
