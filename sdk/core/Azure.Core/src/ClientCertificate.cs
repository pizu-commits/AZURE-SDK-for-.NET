// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Security.Cryptography.X509Certificates;
using Azure.Core;

namespace Azure
{
    /// <summary>
    ///
    /// </summary>
    public class ClientCertificate
    {
        /// <summary>
        ///
        /// </summary>
        /// <value></value>
        public X509Certificate2 Certificate { get; }

        /// <summary>
        ///
        /// </summary>
        /// <param name="certificate"></param>
        public ClientCertificate(X509Certificate2 certificate)
        {
            Argument.AssertNotNull(certificate, nameof(certificate));
            Certificate = certificate;
        }
    }
}
