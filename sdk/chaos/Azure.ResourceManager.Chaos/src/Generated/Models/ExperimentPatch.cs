// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Chaos.Models
{
    /// <summary> Describes an experiment update. </summary>
    public partial class ExperimentPatch
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ExperimentPatch"/>. </summary>
        public ExperimentPatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ExperimentPatch"/>. </summary>
        /// <param name="identity"> The identity of the experiment resource. Current supported identity types: None, SystemAssigned, UserAssigned. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ExperimentPatch(ManagedServiceIdentity identity, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Identity = identity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The identity of the experiment resource. Current supported identity types: None, SystemAssigned, UserAssigned. </summary>
        public ManagedServiceIdentity Identity { get; set; }
    }
}
