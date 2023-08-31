// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The X12 envelope override settings. </summary>
    public partial class X12EnvelopeOverride
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="X12EnvelopeOverride"/>. </summary>
        /// <param name="targetNamespace"> The target namespace on which this envelope settings has to be applied. </param>
        /// <param name="protocolVersion"> The protocol version on which this envelope settings has to be applied. </param>
        /// <param name="messageId"> The message id on which this envelope settings has to be applied. </param>
        /// <param name="responsibleAgencyCode"> The responsible agency code. </param>
        /// <param name="headerVersion"> The header version. </param>
        /// <param name="senderApplicationId"> The sender application id. </param>
        /// <param name="receiverApplicationId"> The receiver application id. </param>
        /// <param name="dateFormat"> The date format. </param>
        /// <param name="timeFormat"> The time format. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetNamespace"/>, <paramref name="protocolVersion"/>, <paramref name="messageId"/>, <paramref name="responsibleAgencyCode"/>, <paramref name="headerVersion"/>, <paramref name="senderApplicationId"/> or <paramref name="receiverApplicationId"/> is null. </exception>
        public X12EnvelopeOverride(string targetNamespace, string protocolVersion, string messageId, string responsibleAgencyCode, string headerVersion, string senderApplicationId, string receiverApplicationId, X12DateFormat dateFormat, X12TimeFormat timeFormat)
        {
            Argument.AssertNotNull(targetNamespace, nameof(targetNamespace));
            Argument.AssertNotNull(protocolVersion, nameof(protocolVersion));
            Argument.AssertNotNull(messageId, nameof(messageId));
            Argument.AssertNotNull(responsibleAgencyCode, nameof(responsibleAgencyCode));
            Argument.AssertNotNull(headerVersion, nameof(headerVersion));
            Argument.AssertNotNull(senderApplicationId, nameof(senderApplicationId));
            Argument.AssertNotNull(receiverApplicationId, nameof(receiverApplicationId));

            TargetNamespace = targetNamespace;
            ProtocolVersion = protocolVersion;
            MessageId = messageId;
            ResponsibleAgencyCode = responsibleAgencyCode;
            HeaderVersion = headerVersion;
            SenderApplicationId = senderApplicationId;
            ReceiverApplicationId = receiverApplicationId;
            DateFormat = dateFormat;
            TimeFormat = timeFormat;
        }

        /// <summary> Initializes a new instance of <see cref="X12EnvelopeOverride"/>. </summary>
        /// <param name="targetNamespace"> The target namespace on which this envelope settings has to be applied. </param>
        /// <param name="protocolVersion"> The protocol version on which this envelope settings has to be applied. </param>
        /// <param name="messageId"> The message id on which this envelope settings has to be applied. </param>
        /// <param name="responsibleAgencyCode"> The responsible agency code. </param>
        /// <param name="headerVersion"> The header version. </param>
        /// <param name="senderApplicationId"> The sender application id. </param>
        /// <param name="receiverApplicationId"> The receiver application id. </param>
        /// <param name="functionalIdentifierCode"> The functional identifier code. </param>
        /// <param name="dateFormat"> The date format. </param>
        /// <param name="timeFormat"> The time format. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal X12EnvelopeOverride(string targetNamespace, string protocolVersion, string messageId, string responsibleAgencyCode, string headerVersion, string senderApplicationId, string receiverApplicationId, string functionalIdentifierCode, X12DateFormat dateFormat, X12TimeFormat timeFormat, Dictionary<string, BinaryData> rawData)
        {
            TargetNamespace = targetNamespace;
            ProtocolVersion = protocolVersion;
            MessageId = messageId;
            ResponsibleAgencyCode = responsibleAgencyCode;
            HeaderVersion = headerVersion;
            SenderApplicationId = senderApplicationId;
            ReceiverApplicationId = receiverApplicationId;
            FunctionalIdentifierCode = functionalIdentifierCode;
            DateFormat = dateFormat;
            TimeFormat = timeFormat;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="X12EnvelopeOverride"/> for deserialization. </summary>
        internal X12EnvelopeOverride()
        {
        }

        /// <summary> The target namespace on which this envelope settings has to be applied. </summary>
        public string TargetNamespace { get; set; }
        /// <summary> The protocol version on which this envelope settings has to be applied. </summary>
        public string ProtocolVersion { get; set; }
        /// <summary> The message id on which this envelope settings has to be applied. </summary>
        public string MessageId { get; set; }
        /// <summary> The responsible agency code. </summary>
        public string ResponsibleAgencyCode { get; set; }
        /// <summary> The header version. </summary>
        public string HeaderVersion { get; set; }
        /// <summary> The sender application id. </summary>
        public string SenderApplicationId { get; set; }
        /// <summary> The receiver application id. </summary>
        public string ReceiverApplicationId { get; set; }
        /// <summary> The functional identifier code. </summary>
        public string FunctionalIdentifierCode { get; set; }
        /// <summary> The date format. </summary>
        public X12DateFormat DateFormat { get; set; }
        /// <summary> The time format. </summary>
        public X12TimeFormat TimeFormat { get; set; }
    }
}
