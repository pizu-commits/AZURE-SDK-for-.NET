// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    /// <summary> alert meta data information. </summary>
    public partial class ServiceAlertMetadata
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ServiceAlertMetadata"/>. </summary>
        internal ServiceAlertMetadata()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ServiceAlertMetadata"/>. </summary>
        /// <param name="properties">
        /// alert meta data property bag
        /// Please note <see cref="ServiceAlertMetadataProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MonitorServiceList"/>.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServiceAlertMetadata(ServiceAlertMetadataProperties properties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// alert meta data property bag
        /// Please note <see cref="ServiceAlertMetadataProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MonitorServiceList"/>.
        /// </summary>
        public ServiceAlertMetadataProperties Properties { get; }
    }
}
