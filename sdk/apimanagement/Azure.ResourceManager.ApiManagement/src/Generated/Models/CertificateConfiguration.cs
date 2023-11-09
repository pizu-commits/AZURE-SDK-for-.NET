// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Certificate configuration which consist of non-trusted intermediates and root certificates. </summary>
    public partial class CertificateConfiguration
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CertificateConfiguration"/>. </summary>
        /// <param name="storeName"> The System.Security.Cryptography.x509certificates.StoreName certificate store location. Only Root and CertificateAuthority are valid locations. </param>
        public CertificateConfiguration(CertificateConfigurationStoreName storeName)
        {
            StoreName = storeName;
        }

        /// <summary> Initializes a new instance of <see cref="CertificateConfiguration"/>. </summary>
        /// <param name="encodedCertificate"> Base64 Encoded certificate. </param>
        /// <param name="certificatePassword"> Certificate Password. </param>
        /// <param name="storeName"> The System.Security.Cryptography.x509certificates.StoreName certificate store location. Only Root and CertificateAuthority are valid locations. </param>
        /// <param name="certificate"> Certificate information. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CertificateConfiguration(string encodedCertificate, string certificatePassword, CertificateConfigurationStoreName storeName, CertificateInformation certificate, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            EncodedCertificate = encodedCertificate;
            CertificatePassword = certificatePassword;
            StoreName = storeName;
            Certificate = certificate;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CertificateConfiguration"/> for deserialization. </summary>
        internal CertificateConfiguration()
        {
        }

        /// <summary> Base64 Encoded certificate. </summary>
        public string EncodedCertificate { get; set; }
        /// <summary> Certificate Password. </summary>
        public string CertificatePassword { get; set; }
        /// <summary> The System.Security.Cryptography.x509certificates.StoreName certificate store location. Only Root and CertificateAuthority are valid locations. </summary>
        public CertificateConfigurationStoreName StoreName { get; set; }
        /// <summary> Certificate information. </summary>
        public CertificateInformation Certificate { get; set; }
    }
}
