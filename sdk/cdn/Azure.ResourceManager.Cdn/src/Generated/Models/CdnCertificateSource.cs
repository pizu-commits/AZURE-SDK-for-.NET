// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the parameters for using CDN managed certificate for securing custom domain. </summary>
    public partial class CdnCertificateSource
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CdnCertificateSource"/>. </summary>
        /// <param name="sourceType"></param>
        /// <param name="certificateType"> Type of certificate used. </param>
        public CdnCertificateSource(CdnCertificateSourceType sourceType, CdnManagedCertificateType certificateType)
        {
            SourceType = sourceType;
            CertificateType = certificateType;
        }

        /// <summary> Initializes a new instance of <see cref="CdnCertificateSource"/>. </summary>
        /// <param name="sourceType"></param>
        /// <param name="certificateType"> Type of certificate used. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CdnCertificateSource(CdnCertificateSourceType sourceType, CdnManagedCertificateType certificateType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SourceType = sourceType;
            CertificateType = certificateType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CdnCertificateSource"/> for deserialization. </summary>
        internal CdnCertificateSource()
        {
        }

        /// <summary> Gets or sets the source type. </summary>
        public CdnCertificateSourceType SourceType { get; set; }
        /// <summary> Type of certificate used. </summary>
        public CdnManagedCertificateType CertificateType { get; set; }
    }
}
