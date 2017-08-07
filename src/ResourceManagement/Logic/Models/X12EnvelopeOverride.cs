// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Logic;
    using Microsoft.Azure.Management.Logic.Fluent;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The X12 envelope override settings.
    /// </summary>
    public partial class X12EnvelopeOverride
    {
        /// <summary>
        /// Initializes a new instance of the X12EnvelopeOverride class.
        /// </summary>
        public X12EnvelopeOverride()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the X12EnvelopeOverride class.
        /// </summary>
        /// <param name="targetNamespace">The target namespace on which this
        /// envelope settings has to be applied.</param>
        /// <param name="protocolVersion">The protocol version on which this
        /// envelope settings has to be applied.</param>
        /// <param name="messageId">The message id on which this envelope
        /// settings has to be applied.</param>
        /// <param name="responsibleAgencyCode">The responsible agency
        /// code.</param>
        /// <param name="headerVersion">The header version.</param>
        /// <param name="senderApplicationId">The sender application
        /// id.</param>
        /// <param name="receiverApplicationId">The receiver application
        /// id.</param>
        /// <param name="dateFormat">The date format. Possible values include:
        /// 'NotSpecified', 'CCYYMMDD', 'YYMMDD'</param>
        /// <param name="timeFormat">The time format. Possible values include:
        /// 'NotSpecified', 'HHMM', 'HHMMSS', 'HHMMSSdd', 'HHMMSSd'</param>
        /// <param name="functionalIdentifierCode">The functional identifier
        /// code.</param>
        public X12EnvelopeOverride(string targetNamespace, string protocolVersion, string messageId, string responsibleAgencyCode, string headerVersion, string senderApplicationId, string receiverApplicationId, X12DateFormat dateFormat, X12TimeFormat timeFormat, string functionalIdentifierCode = default(string))
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
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the target namespace on which this envelope settings
        /// has to be applied.
        /// </summary>
        [JsonProperty(PropertyName = "targetNamespace")]
        public string TargetNamespace { get; set; }

        /// <summary>
        /// Gets or sets the protocol version on which this envelope settings
        /// has to be applied.
        /// </summary>
        [JsonProperty(PropertyName = "protocolVersion")]
        public string ProtocolVersion { get; set; }

        /// <summary>
        /// Gets or sets the message id on which this envelope settings has to
        /// be applied.
        /// </summary>
        [JsonProperty(PropertyName = "messageId")]
        public string MessageId { get; set; }

        /// <summary>
        /// Gets or sets the responsible agency code.
        /// </summary>
        [JsonProperty(PropertyName = "responsibleAgencyCode")]
        public string ResponsibleAgencyCode { get; set; }

        /// <summary>
        /// Gets or sets the header version.
        /// </summary>
        [JsonProperty(PropertyName = "headerVersion")]
        public string HeaderVersion { get; set; }

        /// <summary>
        /// Gets or sets the sender application id.
        /// </summary>
        [JsonProperty(PropertyName = "senderApplicationId")]
        public string SenderApplicationId { get; set; }

        /// <summary>
        /// Gets or sets the receiver application id.
        /// </summary>
        [JsonProperty(PropertyName = "receiverApplicationId")]
        public string ReceiverApplicationId { get; set; }

        /// <summary>
        /// Gets or sets the functional identifier code.
        /// </summary>
        [JsonProperty(PropertyName = "functionalIdentifierCode")]
        public string FunctionalIdentifierCode { get; set; }

        /// <summary>
        /// Gets or sets the date format. Possible values include:
        /// 'NotSpecified', 'CCYYMMDD', 'YYMMDD'
        /// </summary>
        [JsonProperty(PropertyName = "dateFormat")]
        public X12DateFormat DateFormat { get; set; }

        /// <summary>
        /// Gets or sets the time format. Possible values include:
        /// 'NotSpecified', 'HHMM', 'HHMMSS', 'HHMMSSdd', 'HHMMSSd'
        /// </summary>
        [JsonProperty(PropertyName = "timeFormat")]
        public X12TimeFormat TimeFormat { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TargetNamespace == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TargetNamespace");
            }
            if (ProtocolVersion == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ProtocolVersion");
            }
            if (MessageId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MessageId");
            }
            if (ResponsibleAgencyCode == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ResponsibleAgencyCode");
            }
            if (HeaderVersion == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "HeaderVersion");
            }
            if (SenderApplicationId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SenderApplicationId");
            }
            if (ReceiverApplicationId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ReceiverApplicationId");
            }
        }
    }
}
