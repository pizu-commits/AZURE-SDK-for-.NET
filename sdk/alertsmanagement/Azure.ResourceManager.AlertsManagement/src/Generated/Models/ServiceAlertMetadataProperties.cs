// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    /// <summary>
    /// alert meta data property bag
    /// Please note <see cref="ServiceAlertMetadataProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="MonitorServiceList"/>.
    /// </summary>
    [AbstractTypeDeserializer(typeof(UnknownAlertsMetaDataProperties))]
    public abstract partial class ServiceAlertMetadataProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ServiceAlertMetadataProperties"/>. </summary>
        protected ServiceAlertMetadataProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ServiceAlertMetadataProperties"/>. </summary>
        /// <param name="metadataIdentifier"> Identification of the information to be retrieved by API call. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ServiceAlertMetadataProperties(ServiceAlertMetadataIdentifier metadataIdentifier, Dictionary<string, BinaryData> rawData)
        {
            MetadataIdentifier = metadataIdentifier;
            _rawData = rawData;
        }

        /// <summary> Identification of the information to be retrieved by API call. </summary>
        internal ServiceAlertMetadataIdentifier MetadataIdentifier { get; set; }
    }
}
