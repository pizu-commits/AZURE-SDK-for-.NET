// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;

namespace Azure.ResourceManager.AgFoodPlatform.Models
{
    /// <summary> Sensor integration request model. </summary>
    public partial class SensorIntegration
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SensorIntegration"/>. </summary>
        public SensorIntegration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SensorIntegration"/>. </summary>
        /// <param name="enabled"> Sensor integration enable state. Allowed values are True, None. </param>
        /// <param name="provisioningState"> Sensor integration instance provisioning state. </param>
        /// <param name="provisioningInfo"> Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also follows the OData error response format.). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SensorIntegration(string enabled, ProvisioningState? provisioningState, ErrorResponse provisioningInfo, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Enabled = enabled;
            ProvisioningState = provisioningState;
            ProvisioningInfo = provisioningInfo;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Sensor integration enable state. Allowed values are True, None. </summary>
        public string Enabled { get; set; }
        /// <summary> Sensor integration instance provisioning state. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also follows the OData error response format.). </summary>
        internal ErrorResponse ProvisioningInfo { get; set; }
        /// <summary> The error object. </summary>
        public ResponseError ProvisioningInfoError
        {
            get => ProvisioningInfo is null ? default : ProvisioningInfo.Error;
            set
            {
                if (ProvisioningInfo is null)
                    ProvisioningInfo = new ErrorResponse();
                ProvisioningInfo.Error = value;
            }
        }
    }
}
