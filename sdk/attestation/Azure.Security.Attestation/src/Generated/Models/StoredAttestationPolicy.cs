// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Security.Attestation
{
    /// <summary> The StoredAttestationPolicy. </summary>
    public partial class StoredAttestationPolicy
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StoredAttestationPolicy"/>. </summary>
        /// <param name="attestationPolicy"> Policy text to set as a sequence of UTF-8 encoded octets. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StoredAttestationPolicy(string attestationPolicy, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AttestationPolicy = attestationPolicy;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }
    }
}
