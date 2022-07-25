// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary>
    /// The X12 agreement acknowledgement settings.
    /// Serialized Name: X12AcknowledgementSettings
    /// </summary>
    public partial class X12AcknowledgementSettings
    {
        /// <summary> Initializes a new instance of X12AcknowledgementSettings. </summary>
        /// <param name="needTechnicalAcknowledgement">
        /// The value indicating whether technical acknowledgement is needed.
        /// Serialized Name: X12AcknowledgementSettings.needTechnicalAcknowledgement
        /// </param>
        /// <param name="batchTechnicalAcknowledgements">
        /// The value indicating whether to batch the technical acknowledgements.
        /// Serialized Name: X12AcknowledgementSettings.batchTechnicalAcknowledgements
        /// </param>
        /// <param name="needFunctionalAcknowledgement">
        /// The value indicating whether functional acknowledgement is needed.
        /// Serialized Name: X12AcknowledgementSettings.needFunctionalAcknowledgement
        /// </param>
        /// <param name="batchFunctionalAcknowledgements">
        /// The value indicating whether to batch functional acknowledgements.
        /// Serialized Name: X12AcknowledgementSettings.batchFunctionalAcknowledgements
        /// </param>
        /// <param name="needImplementationAcknowledgement">
        /// The value indicating whether implementation acknowledgement is needed.
        /// Serialized Name: X12AcknowledgementSettings.needImplementationAcknowledgement
        /// </param>
        /// <param name="batchImplementationAcknowledgements">
        /// The value indicating whether to batch implementation acknowledgements.
        /// Serialized Name: X12AcknowledgementSettings.batchImplementationAcknowledgements
        /// </param>
        /// <param name="needLoopForValidMessages">
        /// The value indicating whether a loop is needed for valid messages.
        /// Serialized Name: X12AcknowledgementSettings.needLoopForValidMessages
        /// </param>
        /// <param name="sendSynchronousAcknowledgement">
        /// The value indicating whether to send synchronous acknowledgement.
        /// Serialized Name: X12AcknowledgementSettings.sendSynchronousAcknowledgement
        /// </param>
        /// <param name="acknowledgementControlNumberLowerBound">
        /// The acknowledgement control number lower bound.
        /// Serialized Name: X12AcknowledgementSettings.acknowledgementControlNumberLowerBound
        /// </param>
        /// <param name="acknowledgementControlNumberUpperBound">
        /// The acknowledgement control number upper bound.
        /// Serialized Name: X12AcknowledgementSettings.acknowledgementControlNumberUpperBound
        /// </param>
        /// <param name="rolloverAcknowledgementControlNumber">
        /// The value indicating whether to rollover acknowledgement control number.
        /// Serialized Name: X12AcknowledgementSettings.rolloverAcknowledgementControlNumber
        /// </param>
        public X12AcknowledgementSettings(bool needTechnicalAcknowledgement, bool batchTechnicalAcknowledgements, bool needFunctionalAcknowledgement, bool batchFunctionalAcknowledgements, bool needImplementationAcknowledgement, bool batchImplementationAcknowledgements, bool needLoopForValidMessages, bool sendSynchronousAcknowledgement, int acknowledgementControlNumberLowerBound, int acknowledgementControlNumberUpperBound, bool rolloverAcknowledgementControlNumber)
        {
            NeedTechnicalAcknowledgement = needTechnicalAcknowledgement;
            BatchTechnicalAcknowledgements = batchTechnicalAcknowledgements;
            NeedFunctionalAcknowledgement = needFunctionalAcknowledgement;
            BatchFunctionalAcknowledgements = batchFunctionalAcknowledgements;
            NeedImplementationAcknowledgement = needImplementationAcknowledgement;
            BatchImplementationAcknowledgements = batchImplementationAcknowledgements;
            NeedLoopForValidMessages = needLoopForValidMessages;
            SendSynchronousAcknowledgement = sendSynchronousAcknowledgement;
            AcknowledgementControlNumberLowerBound = acknowledgementControlNumberLowerBound;
            AcknowledgementControlNumberUpperBound = acknowledgementControlNumberUpperBound;
            RolloverAcknowledgementControlNumber = rolloverAcknowledgementControlNumber;
        }

        /// <summary> Initializes a new instance of X12AcknowledgementSettings. </summary>
        /// <param name="needTechnicalAcknowledgement">
        /// The value indicating whether technical acknowledgement is needed.
        /// Serialized Name: X12AcknowledgementSettings.needTechnicalAcknowledgement
        /// </param>
        /// <param name="batchTechnicalAcknowledgements">
        /// The value indicating whether to batch the technical acknowledgements.
        /// Serialized Name: X12AcknowledgementSettings.batchTechnicalAcknowledgements
        /// </param>
        /// <param name="needFunctionalAcknowledgement">
        /// The value indicating whether functional acknowledgement is needed.
        /// Serialized Name: X12AcknowledgementSettings.needFunctionalAcknowledgement
        /// </param>
        /// <param name="functionalAcknowledgementVersion">
        /// The functional acknowledgement version.
        /// Serialized Name: X12AcknowledgementSettings.functionalAcknowledgementVersion
        /// </param>
        /// <param name="batchFunctionalAcknowledgements">
        /// The value indicating whether to batch functional acknowledgements.
        /// Serialized Name: X12AcknowledgementSettings.batchFunctionalAcknowledgements
        /// </param>
        /// <param name="needImplementationAcknowledgement">
        /// The value indicating whether implementation acknowledgement is needed.
        /// Serialized Name: X12AcknowledgementSettings.needImplementationAcknowledgement
        /// </param>
        /// <param name="implementationAcknowledgementVersion">
        /// The implementation acknowledgement version.
        /// Serialized Name: X12AcknowledgementSettings.implementationAcknowledgementVersion
        /// </param>
        /// <param name="batchImplementationAcknowledgements">
        /// The value indicating whether to batch implementation acknowledgements.
        /// Serialized Name: X12AcknowledgementSettings.batchImplementationAcknowledgements
        /// </param>
        /// <param name="needLoopForValidMessages">
        /// The value indicating whether a loop is needed for valid messages.
        /// Serialized Name: X12AcknowledgementSettings.needLoopForValidMessages
        /// </param>
        /// <param name="sendSynchronousAcknowledgement">
        /// The value indicating whether to send synchronous acknowledgement.
        /// Serialized Name: X12AcknowledgementSettings.sendSynchronousAcknowledgement
        /// </param>
        /// <param name="acknowledgementControlNumberPrefix">
        /// The acknowledgement control number prefix.
        /// Serialized Name: X12AcknowledgementSettings.acknowledgementControlNumberPrefix
        /// </param>
        /// <param name="acknowledgementControlNumberSuffix">
        /// The acknowledgement control number suffix.
        /// Serialized Name: X12AcknowledgementSettings.acknowledgementControlNumberSuffix
        /// </param>
        /// <param name="acknowledgementControlNumberLowerBound">
        /// The acknowledgement control number lower bound.
        /// Serialized Name: X12AcknowledgementSettings.acknowledgementControlNumberLowerBound
        /// </param>
        /// <param name="acknowledgementControlNumberUpperBound">
        /// The acknowledgement control number upper bound.
        /// Serialized Name: X12AcknowledgementSettings.acknowledgementControlNumberUpperBound
        /// </param>
        /// <param name="rolloverAcknowledgementControlNumber">
        /// The value indicating whether to rollover acknowledgement control number.
        /// Serialized Name: X12AcknowledgementSettings.rolloverAcknowledgementControlNumber
        /// </param>
        internal X12AcknowledgementSettings(bool needTechnicalAcknowledgement, bool batchTechnicalAcknowledgements, bool needFunctionalAcknowledgement, string functionalAcknowledgementVersion, bool batchFunctionalAcknowledgements, bool needImplementationAcknowledgement, string implementationAcknowledgementVersion, bool batchImplementationAcknowledgements, bool needLoopForValidMessages, bool sendSynchronousAcknowledgement, string acknowledgementControlNumberPrefix, string acknowledgementControlNumberSuffix, int acknowledgementControlNumberLowerBound, int acknowledgementControlNumberUpperBound, bool rolloverAcknowledgementControlNumber)
        {
            NeedTechnicalAcknowledgement = needTechnicalAcknowledgement;
            BatchTechnicalAcknowledgements = batchTechnicalAcknowledgements;
            NeedFunctionalAcknowledgement = needFunctionalAcknowledgement;
            FunctionalAcknowledgementVersion = functionalAcknowledgementVersion;
            BatchFunctionalAcknowledgements = batchFunctionalAcknowledgements;
            NeedImplementationAcknowledgement = needImplementationAcknowledgement;
            ImplementationAcknowledgementVersion = implementationAcknowledgementVersion;
            BatchImplementationAcknowledgements = batchImplementationAcknowledgements;
            NeedLoopForValidMessages = needLoopForValidMessages;
            SendSynchronousAcknowledgement = sendSynchronousAcknowledgement;
            AcknowledgementControlNumberPrefix = acknowledgementControlNumberPrefix;
            AcknowledgementControlNumberSuffix = acknowledgementControlNumberSuffix;
            AcknowledgementControlNumberLowerBound = acknowledgementControlNumberLowerBound;
            AcknowledgementControlNumberUpperBound = acknowledgementControlNumberUpperBound;
            RolloverAcknowledgementControlNumber = rolloverAcknowledgementControlNumber;
        }

        /// <summary>
        /// The value indicating whether technical acknowledgement is needed.
        /// Serialized Name: X12AcknowledgementSettings.needTechnicalAcknowledgement
        /// </summary>
        public bool NeedTechnicalAcknowledgement { get; set; }
        /// <summary>
        /// The value indicating whether to batch the technical acknowledgements.
        /// Serialized Name: X12AcknowledgementSettings.batchTechnicalAcknowledgements
        /// </summary>
        public bool BatchTechnicalAcknowledgements { get; set; }
        /// <summary>
        /// The value indicating whether functional acknowledgement is needed.
        /// Serialized Name: X12AcknowledgementSettings.needFunctionalAcknowledgement
        /// </summary>
        public bool NeedFunctionalAcknowledgement { get; set; }
        /// <summary>
        /// The functional acknowledgement version.
        /// Serialized Name: X12AcknowledgementSettings.functionalAcknowledgementVersion
        /// </summary>
        public string FunctionalAcknowledgementVersion { get; set; }
        /// <summary>
        /// The value indicating whether to batch functional acknowledgements.
        /// Serialized Name: X12AcknowledgementSettings.batchFunctionalAcknowledgements
        /// </summary>
        public bool BatchFunctionalAcknowledgements { get; set; }
        /// <summary>
        /// The value indicating whether implementation acknowledgement is needed.
        /// Serialized Name: X12AcknowledgementSettings.needImplementationAcknowledgement
        /// </summary>
        public bool NeedImplementationAcknowledgement { get; set; }
        /// <summary>
        /// The implementation acknowledgement version.
        /// Serialized Name: X12AcknowledgementSettings.implementationAcknowledgementVersion
        /// </summary>
        public string ImplementationAcknowledgementVersion { get; set; }
        /// <summary>
        /// The value indicating whether to batch implementation acknowledgements.
        /// Serialized Name: X12AcknowledgementSettings.batchImplementationAcknowledgements
        /// </summary>
        public bool BatchImplementationAcknowledgements { get; set; }
        /// <summary>
        /// The value indicating whether a loop is needed for valid messages.
        /// Serialized Name: X12AcknowledgementSettings.needLoopForValidMessages
        /// </summary>
        public bool NeedLoopForValidMessages { get; set; }
        /// <summary>
        /// The value indicating whether to send synchronous acknowledgement.
        /// Serialized Name: X12AcknowledgementSettings.sendSynchronousAcknowledgement
        /// </summary>
        public bool SendSynchronousAcknowledgement { get; set; }
        /// <summary>
        /// The acknowledgement control number prefix.
        /// Serialized Name: X12AcknowledgementSettings.acknowledgementControlNumberPrefix
        /// </summary>
        public string AcknowledgementControlNumberPrefix { get; set; }
        /// <summary>
        /// The acknowledgement control number suffix.
        /// Serialized Name: X12AcknowledgementSettings.acknowledgementControlNumberSuffix
        /// </summary>
        public string AcknowledgementControlNumberSuffix { get; set; }
        /// <summary>
        /// The acknowledgement control number lower bound.
        /// Serialized Name: X12AcknowledgementSettings.acknowledgementControlNumberLowerBound
        /// </summary>
        public int AcknowledgementControlNumberLowerBound { get; set; }
        /// <summary>
        /// The acknowledgement control number upper bound.
        /// Serialized Name: X12AcknowledgementSettings.acknowledgementControlNumberUpperBound
        /// </summary>
        public int AcknowledgementControlNumberUpperBound { get; set; }
        /// <summary>
        /// The value indicating whether to rollover acknowledgement control number.
        /// Serialized Name: X12AcknowledgementSettings.rolloverAcknowledgementControlNumber
        /// </summary>
        public bool RolloverAcknowledgementControlNumber { get; set; }
    }
}
