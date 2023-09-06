// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Security.Attestation
{
    /// <summary> The body of the JWT used for the PolicyCertificates APIs. </summary>
    internal partial class PolicyCertificateModification
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PolicyCertificateModification"/>. </summary>
        public PolicyCertificateModification()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PolicyCertificateModification"/>. </summary>
        /// <param name="internalPolicyCertificate"> RFC 7517 Json Web Key describing the certificate. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PolicyCertificateModification(JsonWebKey internalPolicyCertificate, Dictionary<string, BinaryData> rawData)
        {
            InternalPolicyCertificate = internalPolicyCertificate;
            _rawData = rawData;
        }
    }
}
