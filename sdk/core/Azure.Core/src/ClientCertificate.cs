// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Security.Cryptography.X509Certificates;
using Azure.Core;

namespace Azure
{
    /// <summary>
    /// Represents a client certificate used for TLS authentication.
    /// </summary>
    public class ClientCertificate
    {
        /// <summary>
        /// The client certificate to be used for authentication.
        /// </summary>
        /// <value></value>
        public X509Certificate2 Certificate { get; }

        /// <summary>
        /// Initializes an instance of <see cref="ClientCertificate"/>.
        /// </summary>
        /// <param name="certificate">The certificate to be used for authentication.</param>
        public ClientCertificate(X509Certificate2 certificate)
        {
            Argument.AssertNotNull(certificate, nameof(certificate));
            Certificate = certificate;
        }
    }
}
