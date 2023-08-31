// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.IotHub;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> The JSON-serialized array of Certificate objects. </summary>
    internal partial class IotHubCertificateListDescription
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="IotHubCertificateListDescription"/>. </summary>
        internal IotHubCertificateListDescription()
        {
            Value = new ChangeTrackingList<IotHubCertificateDescriptionData>();
        }

        /// <summary> Initializes a new instance of <see cref="IotHubCertificateListDescription"/>. </summary>
        /// <param name="value"> The array of Certificate objects. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal IotHubCertificateListDescription(IReadOnlyList<IotHubCertificateDescriptionData> value, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            _rawData = rawData;
        }

        /// <summary> The array of Certificate objects. </summary>
        public IReadOnlyList<IotHubCertificateDescriptionData> Value { get; }
    }
}
