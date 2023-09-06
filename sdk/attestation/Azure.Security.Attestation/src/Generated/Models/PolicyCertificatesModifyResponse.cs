// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Security.Attestation
{
    /// <summary> The response to an attestation policy management API. </summary>
    internal partial class PolicyCertificatesModifyResponse
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PolicyCertificatesModifyResponse"/>. </summary>
        internal PolicyCertificatesModifyResponse()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PolicyCertificatesModifyResponse"/>. </summary>
        /// <param name="token"> An RFC7519 JSON Web Token structure whose body is a PolicyCertificatesModificationResult object. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PolicyCertificatesModifyResponse(string token, Dictionary<string, BinaryData> rawData)
        {
            Token = token;
            _rawData = rawData;
        }

        /// <summary> An RFC7519 JSON Web Token structure whose body is a PolicyCertificatesModificationResult object. </summary>
        public string Token { get; }
    }
}
