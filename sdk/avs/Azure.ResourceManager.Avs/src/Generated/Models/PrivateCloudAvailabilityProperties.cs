// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> The properties describing private cloud availability zone distribution. </summary>
    public partial class PrivateCloudAvailabilityProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PrivateCloudAvailabilityProperties"/>. </summary>
        public PrivateCloudAvailabilityProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PrivateCloudAvailabilityProperties"/>. </summary>
        /// <param name="strategy"> The availability strategy for the private cloud. </param>
        /// <param name="zone"> The primary availability zone for the private cloud. </param>
        /// <param name="secondaryZone"> The secondary availability zone for the private cloud. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PrivateCloudAvailabilityProperties(AvailabilityStrategy? strategy, int? zone, int? secondaryZone, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Strategy = strategy;
            Zone = zone;
            SecondaryZone = secondaryZone;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The availability strategy for the private cloud. </summary>
        public AvailabilityStrategy? Strategy { get; set; }
        /// <summary> The primary availability zone for the private cloud. </summary>
        public int? Zone { get; set; }
        /// <summary> The secondary availability zone for the private cloud. </summary>
        public int? SecondaryZone { get; set; }
    }
}
