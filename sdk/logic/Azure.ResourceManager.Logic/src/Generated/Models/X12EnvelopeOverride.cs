// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary>
    /// The X12 envelope override settings.
    /// Serialized Name: X12EnvelopeOverride
    /// </summary>
    public partial class X12EnvelopeOverride
    {
        /// <summary> Initializes a new instance of X12EnvelopeOverride. </summary>
        /// <param name="targetNamespace">
        /// The target namespace on which this envelope settings has to be applied.
        /// Serialized Name: X12EnvelopeOverride.targetNamespace
        /// </param>
        /// <param name="protocolVersion">
        /// The protocol version on which this envelope settings has to be applied.
        /// Serialized Name: X12EnvelopeOverride.protocolVersion
        /// </param>
        /// <param name="messageId">
        /// The message id on which this envelope settings has to be applied.
        /// Serialized Name: X12EnvelopeOverride.messageId
        /// </param>
        /// <param name="responsibleAgencyCode">
        /// The responsible agency code.
        /// Serialized Name: X12EnvelopeOverride.responsibleAgencyCode
        /// </param>
        /// <param name="headerVersion">
        /// The header version.
        /// Serialized Name: X12EnvelopeOverride.headerVersion
        /// </param>
        /// <param name="senderApplicationId">
        /// The sender application id.
        /// Serialized Name: X12EnvelopeOverride.senderApplicationId
        /// </param>
        /// <param name="receiverApplicationId">
        /// The receiver application id.
        /// Serialized Name: X12EnvelopeOverride.receiverApplicationId
        /// </param>
        /// <param name="dateFormat">
        /// The date format.
        /// Serialized Name: X12EnvelopeOverride.dateFormat
        /// </param>
        /// <param name="timeFormat">
        /// The time format.
        /// Serialized Name: X12EnvelopeOverride.timeFormat
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetNamespace"/>, <paramref name="protocolVersion"/>, <paramref name="messageId"/>, <paramref name="responsibleAgencyCode"/>, <paramref name="headerVersion"/>, <paramref name="senderApplicationId"/> or <paramref name="receiverApplicationId"/> is null. </exception>
        public X12EnvelopeOverride(string targetNamespace, string protocolVersion, string messageId, string responsibleAgencyCode, string headerVersion, string senderApplicationId, string receiverApplicationId, X12DateFormat dateFormat, X12TimeFormat timeFormat)
        {
            if (targetNamespace == null)
            {
                throw new ArgumentNullException(nameof(targetNamespace));
            }
            if (protocolVersion == null)
            {
                throw new ArgumentNullException(nameof(protocolVersion));
            }
            if (messageId == null)
            {
                throw new ArgumentNullException(nameof(messageId));
            }
            if (responsibleAgencyCode == null)
            {
                throw new ArgumentNullException(nameof(responsibleAgencyCode));
            }
            if (headerVersion == null)
            {
                throw new ArgumentNullException(nameof(headerVersion));
            }
            if (senderApplicationId == null)
            {
                throw new ArgumentNullException(nameof(senderApplicationId));
            }
            if (receiverApplicationId == null)
            {
                throw new ArgumentNullException(nameof(receiverApplicationId));
            }

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

        /// <summary> Initializes a new instance of X12EnvelopeOverride. </summary>
        /// <param name="targetNamespace">
        /// The target namespace on which this envelope settings has to be applied.
        /// Serialized Name: X12EnvelopeOverride.targetNamespace
        /// </param>
        /// <param name="protocolVersion">
        /// The protocol version on which this envelope settings has to be applied.
        /// Serialized Name: X12EnvelopeOverride.protocolVersion
        /// </param>
        /// <param name="messageId">
        /// The message id on which this envelope settings has to be applied.
        /// Serialized Name: X12EnvelopeOverride.messageId
        /// </param>
        /// <param name="responsibleAgencyCode">
        /// The responsible agency code.
        /// Serialized Name: X12EnvelopeOverride.responsibleAgencyCode
        /// </param>
        /// <param name="headerVersion">
        /// The header version.
        /// Serialized Name: X12EnvelopeOverride.headerVersion
        /// </param>
        /// <param name="senderApplicationId">
        /// The sender application id.
        /// Serialized Name: X12EnvelopeOverride.senderApplicationId
        /// </param>
        /// <param name="receiverApplicationId">
        /// The receiver application id.
        /// Serialized Name: X12EnvelopeOverride.receiverApplicationId
        /// </param>
        /// <param name="functionalIdentifierCode">
        /// The functional identifier code.
        /// Serialized Name: X12EnvelopeOverride.functionalIdentifierCode
        /// </param>
        /// <param name="dateFormat">
        /// The date format.
        /// Serialized Name: X12EnvelopeOverride.dateFormat
        /// </param>
        /// <param name="timeFormat">
        /// The time format.
        /// Serialized Name: X12EnvelopeOverride.timeFormat
        /// </param>
        internal X12EnvelopeOverride(string targetNamespace, string protocolVersion, string messageId, string responsibleAgencyCode, string headerVersion, string senderApplicationId, string receiverApplicationId, string functionalIdentifierCode, X12DateFormat dateFormat, X12TimeFormat timeFormat)
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
        }

        /// <summary>
        /// The target namespace on which this envelope settings has to be applied.
        /// Serialized Name: X12EnvelopeOverride.targetNamespace
        /// </summary>
        public string TargetNamespace { get; set; }
        /// <summary>
        /// The protocol version on which this envelope settings has to be applied.
        /// Serialized Name: X12EnvelopeOverride.protocolVersion
        /// </summary>
        public string ProtocolVersion { get; set; }
        /// <summary>
        /// The message id on which this envelope settings has to be applied.
        /// Serialized Name: X12EnvelopeOverride.messageId
        /// </summary>
        public string MessageId { get; set; }
        /// <summary>
        /// The responsible agency code.
        /// Serialized Name: X12EnvelopeOverride.responsibleAgencyCode
        /// </summary>
        public string ResponsibleAgencyCode { get; set; }
        /// <summary>
        /// The header version.
        /// Serialized Name: X12EnvelopeOverride.headerVersion
        /// </summary>
        public string HeaderVersion { get; set; }
        /// <summary>
        /// The sender application id.
        /// Serialized Name: X12EnvelopeOverride.senderApplicationId
        /// </summary>
        public string SenderApplicationId { get; set; }
        /// <summary>
        /// The receiver application id.
        /// Serialized Name: X12EnvelopeOverride.receiverApplicationId
        /// </summary>
        public string ReceiverApplicationId { get; set; }
        /// <summary>
        /// The functional identifier code.
        /// Serialized Name: X12EnvelopeOverride.functionalIdentifierCode
        /// </summary>
        public string FunctionalIdentifierCode { get; set; }
        /// <summary>
        /// The date format.
        /// Serialized Name: X12EnvelopeOverride.dateFormat
        /// </summary>
        public X12DateFormat DateFormat { get; set; }
        /// <summary>
        /// The time format.
        /// Serialized Name: X12EnvelopeOverride.timeFormat
        /// </summary>
        public X12TimeFormat TimeFormat { get; set; }
    }
}
