// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AgFoodPlatform.Models
{
    /// <summary> FarmBeats ARM Resource properties. </summary>
    public partial class FarmBeatsUpdateProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="FarmBeatsUpdateProperties"/>. </summary>
        public FarmBeatsUpdateProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FarmBeatsUpdateProperties"/>. </summary>
        /// <param name="sensorIntegration"> Sensor integration request model. </param>
        /// <param name="publicNetworkAccess"> Property to allow or block public traffic for an Azure FarmBeats resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal FarmBeatsUpdateProperties(SensorIntegration sensorIntegration, PublicNetworkAccess? publicNetworkAccess, Dictionary<string, BinaryData> rawData)
        {
            SensorIntegration = sensorIntegration;
            PublicNetworkAccess = publicNetworkAccess;
            _rawData = rawData;
        }

        /// <summary> Sensor integration request model. </summary>
        public SensorIntegration SensorIntegration { get; set; }
        /// <summary> Property to allow or block public traffic for an Azure FarmBeats resource. </summary>
        public PublicNetworkAccess? PublicNetworkAccess { get; set; }
    }
}
