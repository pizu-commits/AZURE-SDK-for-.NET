// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The TLS certificate properties of the connected registry login server. </summary>
    public partial class TlsCertificateProperties
    {
        /// <summary> Initializes a new instance of TlsCertificateProperties. </summary>
        internal TlsCertificateProperties()
        {
        }

        /// <summary> Initializes a new instance of TlsCertificateProperties. </summary>
        /// <param name="locationType"> The type of certificate location. </param>
        /// <param name="certificateLocation"> Indicates the location of the certificates. </param>
        internal TlsCertificateProperties(TlsCertificateLocationType? locationType, string certificateLocation)
        {
            LocationType = locationType;
            CertificateLocation = certificateLocation;
        }

        /// <summary> The type of certificate location. </summary>
        public TlsCertificateLocationType? LocationType { get; }
        /// <summary> Indicates the location of the certificates. </summary>
        public string CertificateLocation { get; }
    }
}
