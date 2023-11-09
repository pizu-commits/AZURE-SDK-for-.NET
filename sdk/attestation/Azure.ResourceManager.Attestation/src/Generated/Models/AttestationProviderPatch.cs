// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Attestation.Models
{
    /// <summary> Parameters for patching an attestation provider. </summary>
    public partial class AttestationProviderPatch
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AttestationProviderPatch"/>. </summary>
        public AttestationProviderPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="AttestationProviderPatch"/>. </summary>
        /// <param name="tags"> The tags that will be assigned to the attestation provider. </param>
        /// <param name="properties"> Properties of the attestation provider. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AttestationProviderPatch(IDictionary<string, string> tags, AttestationServicePatchSpecificParams properties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Tags = tags;
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The tags that will be assigned to the attestation provider. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Properties of the attestation provider. </summary>
        internal AttestationServicePatchSpecificParams Properties { get; set; }
        /// <summary> Controls whether traffic from the public network is allowed to access the Attestation Provider APIs. </summary>
        public PublicNetworkAccessType? AttestationServicePatchSpecificParamsPublicNetworkAccess
        {
            get => Properties is null ? default : Properties.PublicNetworkAccess;
            set
            {
                if (Properties is null)
                    Properties = new AttestationServicePatchSpecificParams();
                Properties.PublicNetworkAccess = value;
            }
        }
    }
}
