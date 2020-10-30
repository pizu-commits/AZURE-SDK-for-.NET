// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Security.Attestation.Models
{
    /// <summary> Attestation request for Trusted Platform Module (TPM) attestation. </summary>
    public partial class TpmAttestationRequest
    {
        /// <summary> Initializes a new instance of TpmAttestationRequest. </summary>
        public TpmAttestationRequest()
        {
        }

        /// <summary> Protocol data containing artifacts for attestation. </summary>
        public byte[] Data { get; set; }
    }
}
