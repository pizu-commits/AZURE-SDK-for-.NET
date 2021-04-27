// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Options for controlling the authentication of TLS endpoints. </summary>
    public partial class TlsValidationOptions
    {
        /// <summary> Initializes a new instance of TlsValidationOptions. </summary>
        public TlsValidationOptions()
        {
        }

        /// <summary> Initializes a new instance of TlsValidationOptions. </summary>
        /// <param name="ignoreHostname"> Boolean value ignoring the host name (common name) during validation. </param>
        /// <param name="ignoreSignature"> Boolean value ignoring the integrity of the certificate chain at the current time. </param>
        internal TlsValidationOptions(string ignoreHostname, string ignoreSignature)
        {
            IgnoreHostname = ignoreHostname;
            IgnoreSignature = ignoreSignature;
        }

        /// <summary> Boolean value ignoring the host name (common name) during validation. </summary>
        public string IgnoreHostname { get; set; }
        /// <summary> Boolean value ignoring the integrity of the certificate chain at the current time. </summary>
        public string IgnoreSignature { get; set; }
    }
}
