// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The AS2 agreement acknowledgement connection settings. </summary>
    public partial class AS2AcknowledgementConnectionSettings
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AS2AcknowledgementConnectionSettings"/>. </summary>
        /// <param name="ignoreCertificateNameMismatch"> Indicates whether to ignore mismatch in certificate name. </param>
        /// <param name="supportHttpStatusCodeContinue"> Indicates whether to support HTTP status code 'CONTINUE'. </param>
        /// <param name="keepHttpConnectionAlive"> Indicates whether to keep the connection alive. </param>
        /// <param name="unfoldHttpHeaders"> Indicates whether to unfold the HTTP headers. </param>
        public AS2AcknowledgementConnectionSettings(bool ignoreCertificateNameMismatch, bool supportHttpStatusCodeContinue, bool keepHttpConnectionAlive, bool unfoldHttpHeaders)
        {
            IgnoreCertificateNameMismatch = ignoreCertificateNameMismatch;
            SupportHttpStatusCodeContinue = supportHttpStatusCodeContinue;
            KeepHttpConnectionAlive = keepHttpConnectionAlive;
            UnfoldHttpHeaders = unfoldHttpHeaders;
        }

        /// <summary> Initializes a new instance of <see cref="AS2AcknowledgementConnectionSettings"/>. </summary>
        /// <param name="ignoreCertificateNameMismatch"> Indicates whether to ignore mismatch in certificate name. </param>
        /// <param name="supportHttpStatusCodeContinue"> Indicates whether to support HTTP status code 'CONTINUE'. </param>
        /// <param name="keepHttpConnectionAlive"> Indicates whether to keep the connection alive. </param>
        /// <param name="unfoldHttpHeaders"> Indicates whether to unfold the HTTP headers. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AS2AcknowledgementConnectionSettings(bool ignoreCertificateNameMismatch, bool supportHttpStatusCodeContinue, bool keepHttpConnectionAlive, bool unfoldHttpHeaders, Dictionary<string, BinaryData> rawData)
        {
            IgnoreCertificateNameMismatch = ignoreCertificateNameMismatch;
            SupportHttpStatusCodeContinue = supportHttpStatusCodeContinue;
            KeepHttpConnectionAlive = keepHttpConnectionAlive;
            UnfoldHttpHeaders = unfoldHttpHeaders;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="AS2AcknowledgementConnectionSettings"/> for deserialization. </summary>
        internal AS2AcknowledgementConnectionSettings()
        {
        }

        /// <summary> Indicates whether to ignore mismatch in certificate name. </summary>
        public bool IgnoreCertificateNameMismatch { get; set; }
        /// <summary> Indicates whether to support HTTP status code 'CONTINUE'. </summary>
        public bool SupportHttpStatusCodeContinue { get; set; }
        /// <summary> Indicates whether to keep the connection alive. </summary>
        public bool KeepHttpConnectionAlive { get; set; }
        /// <summary> Indicates whether to unfold the HTTP headers. </summary>
        public bool UnfoldHttpHeaders { get; set; }
    }
}
