// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary>
    /// The AS2 agreement message connection settings.
    /// Serialized Name: AS2MessageConnectionSettings
    /// </summary>
    public partial class AS2MessageConnectionSettings
    {
        /// <summary> Initializes a new instance of AS2MessageConnectionSettings. </summary>
        /// <param name="ignoreCertificateNameMismatch">
        /// The value indicating whether to ignore mismatch in certificate name.
        /// Serialized Name: AS2MessageConnectionSettings.ignoreCertificateNameMismatch
        /// </param>
        /// <param name="supportHttpStatusCodeContinue">
        /// The value indicating whether to support HTTP status code &apos;CONTINUE&apos;.
        /// Serialized Name: AS2MessageConnectionSettings.supportHttpStatusCodeContinue
        /// </param>
        /// <param name="keepHttpConnectionAlive">
        /// The value indicating whether to keep the connection alive.
        /// Serialized Name: AS2MessageConnectionSettings.keepHttpConnectionAlive
        /// </param>
        /// <param name="unfoldHttpHeaders">
        /// The value indicating whether to unfold the HTTP headers.
        /// Serialized Name: AS2MessageConnectionSettings.unfoldHttpHeaders
        /// </param>
        public AS2MessageConnectionSettings(bool ignoreCertificateNameMismatch, bool supportHttpStatusCodeContinue, bool keepHttpConnectionAlive, bool unfoldHttpHeaders)
        {
            IgnoreCertificateNameMismatch = ignoreCertificateNameMismatch;
            SupportHttpStatusCodeContinue = supportHttpStatusCodeContinue;
            KeepHttpConnectionAlive = keepHttpConnectionAlive;
            UnfoldHttpHeaders = unfoldHttpHeaders;
        }

        /// <summary>
        /// The value indicating whether to ignore mismatch in certificate name.
        /// Serialized Name: AS2MessageConnectionSettings.ignoreCertificateNameMismatch
        /// </summary>
        public bool IgnoreCertificateNameMismatch { get; set; }
        /// <summary>
        /// The value indicating whether to support HTTP status code &apos;CONTINUE&apos;.
        /// Serialized Name: AS2MessageConnectionSettings.supportHttpStatusCodeContinue
        /// </summary>
        public bool SupportHttpStatusCodeContinue { get; set; }
        /// <summary>
        /// The value indicating whether to keep the connection alive.
        /// Serialized Name: AS2MessageConnectionSettings.keepHttpConnectionAlive
        /// </summary>
        public bool KeepHttpConnectionAlive { get; set; }
        /// <summary>
        /// The value indicating whether to unfold the HTTP headers.
        /// Serialized Name: AS2MessageConnectionSettings.unfoldHttpHeaders
        /// </summary>
        public bool UnfoldHttpHeaders { get; set; }
    }
}
