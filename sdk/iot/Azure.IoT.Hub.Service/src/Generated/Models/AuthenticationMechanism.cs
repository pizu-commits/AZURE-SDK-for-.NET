// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.IoT.Hub.Service.Models
{
    /// <summary> The AuthenticationMechanism. </summary>
    public partial class AuthenticationMechanism
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AuthenticationMechanism"/>. </summary>
        public AuthenticationMechanism()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AuthenticationMechanism"/>. </summary>
        /// <param name="symmetricKey"> The primary and secondary keys used for SAS based authentication. </param>
        /// <param name="x509Thumbprint"> The primary and secondary x509 thumbprints used for x509 based authentication. </param>
        /// <param name="type"> The type of authentication used to connect to the service. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AuthenticationMechanism(SymmetricKey symmetricKey, X509Thumbprint x509Thumbprint, AuthenticationMechanismType? type, Dictionary<string, BinaryData> rawData)
        {
            SymmetricKey = symmetricKey;
            X509Thumbprint = x509Thumbprint;
            Type = type;
            _rawData = rawData;
        }

        /// <summary> The primary and secondary keys used for SAS based authentication. </summary>
        public SymmetricKey SymmetricKey { get; set; }
        /// <summary> The primary and secondary x509 thumbprints used for x509 based authentication. </summary>
        public X509Thumbprint X509Thumbprint { get; set; }
        /// <summary> The type of authentication used to connect to the service. </summary>
        public AuthenticationMechanismType? Type { get; set; }
    }
}
