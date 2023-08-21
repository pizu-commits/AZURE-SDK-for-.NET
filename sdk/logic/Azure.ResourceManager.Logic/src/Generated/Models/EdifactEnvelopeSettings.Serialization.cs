// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class EdifactEnvelopeSettings : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(GroupAssociationAssignedCode))
            {
                writer.WritePropertyName("groupAssociationAssignedCode"u8);
                writer.WriteStringValue(GroupAssociationAssignedCode);
            }
            if (Core.Optional.IsDefined(CommunicationAgreementId))
            {
                writer.WritePropertyName("communicationAgreementId"u8);
                writer.WriteStringValue(CommunicationAgreementId);
            }
            writer.WritePropertyName("applyDelimiterStringAdvice"u8);
            writer.WriteBooleanValue(ApplyDelimiterStringAdvice);
            writer.WritePropertyName("createGroupingSegments"u8);
            writer.WriteBooleanValue(CreateGroupingSegments);
            writer.WritePropertyName("enableDefaultGroupHeaders"u8);
            writer.WriteBooleanValue(EnableDefaultGroupHeaders);
            if (Core.Optional.IsDefined(RecipientReferencePasswordValue))
            {
                writer.WritePropertyName("recipientReferencePasswordValue"u8);
                writer.WriteStringValue(RecipientReferencePasswordValue);
            }
            if (Core.Optional.IsDefined(RecipientReferencePasswordQualifier))
            {
                writer.WritePropertyName("recipientReferencePasswordQualifier"u8);
                writer.WriteStringValue(RecipientReferencePasswordQualifier);
            }
            if (Core.Optional.IsDefined(ApplicationReferenceId))
            {
                writer.WritePropertyName("applicationReferenceId"u8);
                writer.WriteStringValue(ApplicationReferenceId);
            }
            if (Core.Optional.IsDefined(ProcessingPriorityCode))
            {
                writer.WritePropertyName("processingPriorityCode"u8);
                writer.WriteStringValue(ProcessingPriorityCode);
            }
            writer.WritePropertyName("interchangeControlNumberLowerBound"u8);
            writer.WriteNumberValue(InterchangeControlNumberLowerBound);
            writer.WritePropertyName("interchangeControlNumberUpperBound"u8);
            writer.WriteNumberValue(InterchangeControlNumberUpperBound);
            writer.WritePropertyName("rolloverInterchangeControlNumber"u8);
            writer.WriteBooleanValue(RolloverInterchangeControlNumber);
            if (Core.Optional.IsDefined(InterchangeControlNumberPrefix))
            {
                writer.WritePropertyName("interchangeControlNumberPrefix"u8);
                writer.WriteStringValue(InterchangeControlNumberPrefix);
            }
            if (Core.Optional.IsDefined(InterchangeControlNumberSuffix))
            {
                writer.WritePropertyName("interchangeControlNumberSuffix"u8);
                writer.WriteStringValue(InterchangeControlNumberSuffix);
            }
            if (Core.Optional.IsDefined(SenderReverseRoutingAddress))
            {
                writer.WritePropertyName("senderReverseRoutingAddress"u8);
                writer.WriteStringValue(SenderReverseRoutingAddress);
            }
            if (Core.Optional.IsDefined(ReceiverReverseRoutingAddress))
            {
                writer.WritePropertyName("receiverReverseRoutingAddress"u8);
                writer.WriteStringValue(ReceiverReverseRoutingAddress);
            }
            if (Core.Optional.IsDefined(FunctionalGroupId))
            {
                writer.WritePropertyName("functionalGroupId"u8);
                writer.WriteStringValue(FunctionalGroupId);
            }
            if (Core.Optional.IsDefined(GroupControllingAgencyCode))
            {
                writer.WritePropertyName("groupControllingAgencyCode"u8);
                writer.WriteStringValue(GroupControllingAgencyCode);
            }
            if (Core.Optional.IsDefined(GroupMessageVersion))
            {
                writer.WritePropertyName("groupMessageVersion"u8);
                writer.WriteStringValue(GroupMessageVersion);
            }
            if (Core.Optional.IsDefined(GroupMessageRelease))
            {
                writer.WritePropertyName("groupMessageRelease"u8);
                writer.WriteStringValue(GroupMessageRelease);
            }
            writer.WritePropertyName("groupControlNumberLowerBound"u8);
            writer.WriteNumberValue(GroupControlNumberLowerBound);
            writer.WritePropertyName("groupControlNumberUpperBound"u8);
            writer.WriteNumberValue(GroupControlNumberUpperBound);
            writer.WritePropertyName("rolloverGroupControlNumber"u8);
            writer.WriteBooleanValue(RolloverGroupControlNumber);
            if (Core.Optional.IsDefined(GroupControlNumberPrefix))
            {
                writer.WritePropertyName("groupControlNumberPrefix"u8);
                writer.WriteStringValue(GroupControlNumberPrefix);
            }
            if (Core.Optional.IsDefined(GroupControlNumberSuffix))
            {
                writer.WritePropertyName("groupControlNumberSuffix"u8);
                writer.WriteStringValue(GroupControlNumberSuffix);
            }
            if (Core.Optional.IsDefined(GroupApplicationReceiverQualifier))
            {
                writer.WritePropertyName("groupApplicationReceiverQualifier"u8);
                writer.WriteStringValue(GroupApplicationReceiverQualifier);
            }
            if (Core.Optional.IsDefined(GroupApplicationReceiverId))
            {
                writer.WritePropertyName("groupApplicationReceiverId"u8);
                writer.WriteStringValue(GroupApplicationReceiverId);
            }
            if (Core.Optional.IsDefined(GroupApplicationSenderQualifier))
            {
                writer.WritePropertyName("groupApplicationSenderQualifier"u8);
                writer.WriteStringValue(GroupApplicationSenderQualifier);
            }
            if (Core.Optional.IsDefined(GroupApplicationSenderId))
            {
                writer.WritePropertyName("groupApplicationSenderId"u8);
                writer.WriteStringValue(GroupApplicationSenderId);
            }
            if (Core.Optional.IsDefined(GroupApplicationPassword))
            {
                writer.WritePropertyName("groupApplicationPassword"u8);
                writer.WriteStringValue(GroupApplicationPassword);
            }
            writer.WritePropertyName("overwriteExistingTransactionSetControlNumber"u8);
            writer.WriteBooleanValue(OverwriteExistingTransactionSetControlNumber);
            if (Core.Optional.IsDefined(TransactionSetControlNumberPrefix))
            {
                writer.WritePropertyName("transactionSetControlNumberPrefix"u8);
                writer.WriteStringValue(TransactionSetControlNumberPrefix);
            }
            if (Core.Optional.IsDefined(TransactionSetControlNumberSuffix))
            {
                writer.WritePropertyName("transactionSetControlNumberSuffix"u8);
                writer.WriteStringValue(TransactionSetControlNumberSuffix);
            }
            writer.WritePropertyName("transactionSetControlNumberLowerBound"u8);
            writer.WriteNumberValue(TransactionSetControlNumberLowerBound);
            writer.WritePropertyName("transactionSetControlNumberUpperBound"u8);
            writer.WriteNumberValue(TransactionSetControlNumberUpperBound);
            writer.WritePropertyName("rolloverTransactionSetControlNumber"u8);
            writer.WriteBooleanValue(RolloverTransactionSetControlNumber);
            writer.WritePropertyName("isTestInterchange"u8);
            writer.WriteBooleanValue(IsTestInterchange);
            if (Core.Optional.IsDefined(SenderInternalIdentification))
            {
                writer.WritePropertyName("senderInternalIdentification"u8);
                writer.WriteStringValue(SenderInternalIdentification);
            }
            if (Core.Optional.IsDefined(SenderInternalSubIdentification))
            {
                writer.WritePropertyName("senderInternalSubIdentification"u8);
                writer.WriteStringValue(SenderInternalSubIdentification);
            }
            if (Core.Optional.IsDefined(ReceiverInternalIdentification))
            {
                writer.WritePropertyName("receiverInternalIdentification"u8);
                writer.WriteStringValue(ReceiverInternalIdentification);
            }
            if (Core.Optional.IsDefined(ReceiverInternalSubIdentification))
            {
                writer.WritePropertyName("receiverInternalSubIdentification"u8);
                writer.WriteStringValue(ReceiverInternalSubIdentification);
            }
            writer.WriteEndObject();
        }

        internal static EdifactEnvelopeSettings DeserializeEdifactEnvelopeSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> groupAssociationAssignedCode = default;
            Core.Optional<string> communicationAgreementId = default;
            bool applyDelimiterStringAdvice = default;
            bool createGroupingSegments = default;
            bool enableDefaultGroupHeaders = default;
            Core.Optional<string> recipientReferencePasswordValue = default;
            Core.Optional<string> recipientReferencePasswordQualifier = default;
            Core.Optional<string> applicationReferenceId = default;
            Core.Optional<string> processingPriorityCode = default;
            long interchangeControlNumberLowerBound = default;
            long interchangeControlNumberUpperBound = default;
            bool rolloverInterchangeControlNumber = default;
            Core.Optional<string> interchangeControlNumberPrefix = default;
            Core.Optional<string> interchangeControlNumberSuffix = default;
            Core.Optional<string> senderReverseRoutingAddress = default;
            Core.Optional<string> receiverReverseRoutingAddress = default;
            Core.Optional<string> functionalGroupId = default;
            Core.Optional<string> groupControllingAgencyCode = default;
            Core.Optional<string> groupMessageVersion = default;
            Core.Optional<string> groupMessageRelease = default;
            long groupControlNumberLowerBound = default;
            long groupControlNumberUpperBound = default;
            bool rolloverGroupControlNumber = default;
            Core.Optional<string> groupControlNumberPrefix = default;
            Core.Optional<string> groupControlNumberSuffix = default;
            Core.Optional<string> groupApplicationReceiverQualifier = default;
            Core.Optional<string> groupApplicationReceiverId = default;
            Core.Optional<string> groupApplicationSenderQualifier = default;
            Core.Optional<string> groupApplicationSenderId = default;
            Core.Optional<string> groupApplicationPassword = default;
            bool overwriteExistingTransactionSetControlNumber = default;
            Core.Optional<string> transactionSetControlNumberPrefix = default;
            Core.Optional<string> transactionSetControlNumberSuffix = default;
            long transactionSetControlNumberLowerBound = default;
            long transactionSetControlNumberUpperBound = default;
            bool rolloverTransactionSetControlNumber = default;
            bool isTestInterchange = default;
            Core.Optional<string> senderInternalIdentification = default;
            Core.Optional<string> senderInternalSubIdentification = default;
            Core.Optional<string> receiverInternalIdentification = default;
            Core.Optional<string> receiverInternalSubIdentification = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("groupAssociationAssignedCode"u8))
                {
                    groupAssociationAssignedCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("communicationAgreementId"u8))
                {
                    communicationAgreementId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("applyDelimiterStringAdvice"u8))
                {
                    applyDelimiterStringAdvice = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("createGroupingSegments"u8))
                {
                    createGroupingSegments = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableDefaultGroupHeaders"u8))
                {
                    enableDefaultGroupHeaders = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("recipientReferencePasswordValue"u8))
                {
                    recipientReferencePasswordValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recipientReferencePasswordQualifier"u8))
                {
                    recipientReferencePasswordQualifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("applicationReferenceId"u8))
                {
                    applicationReferenceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("processingPriorityCode"u8))
                {
                    processingPriorityCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("interchangeControlNumberLowerBound"u8))
                {
                    interchangeControlNumberLowerBound = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("interchangeControlNumberUpperBound"u8))
                {
                    interchangeControlNumberUpperBound = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("rolloverInterchangeControlNumber"u8))
                {
                    rolloverInterchangeControlNumber = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("interchangeControlNumberPrefix"u8))
                {
                    interchangeControlNumberPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("interchangeControlNumberSuffix"u8))
                {
                    interchangeControlNumberSuffix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("senderReverseRoutingAddress"u8))
                {
                    senderReverseRoutingAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("receiverReverseRoutingAddress"u8))
                {
                    receiverReverseRoutingAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("functionalGroupId"u8))
                {
                    functionalGroupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groupControllingAgencyCode"u8))
                {
                    groupControllingAgencyCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groupMessageVersion"u8))
                {
                    groupMessageVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groupMessageRelease"u8))
                {
                    groupMessageRelease = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groupControlNumberLowerBound"u8))
                {
                    groupControlNumberLowerBound = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("groupControlNumberUpperBound"u8))
                {
                    groupControlNumberUpperBound = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("rolloverGroupControlNumber"u8))
                {
                    rolloverGroupControlNumber = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("groupControlNumberPrefix"u8))
                {
                    groupControlNumberPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groupControlNumberSuffix"u8))
                {
                    groupControlNumberSuffix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groupApplicationReceiverQualifier"u8))
                {
                    groupApplicationReceiverQualifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groupApplicationReceiverId"u8))
                {
                    groupApplicationReceiverId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groupApplicationSenderQualifier"u8))
                {
                    groupApplicationSenderQualifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groupApplicationSenderId"u8))
                {
                    groupApplicationSenderId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groupApplicationPassword"u8))
                {
                    groupApplicationPassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("overwriteExistingTransactionSetControlNumber"u8))
                {
                    overwriteExistingTransactionSetControlNumber = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("transactionSetControlNumberPrefix"u8))
                {
                    transactionSetControlNumberPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("transactionSetControlNumberSuffix"u8))
                {
                    transactionSetControlNumberSuffix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("transactionSetControlNumberLowerBound"u8))
                {
                    transactionSetControlNumberLowerBound = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("transactionSetControlNumberUpperBound"u8))
                {
                    transactionSetControlNumberUpperBound = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("rolloverTransactionSetControlNumber"u8))
                {
                    rolloverTransactionSetControlNumber = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isTestInterchange"u8))
                {
                    isTestInterchange = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("senderInternalIdentification"u8))
                {
                    senderInternalIdentification = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("senderInternalSubIdentification"u8))
                {
                    senderInternalSubIdentification = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("receiverInternalIdentification"u8))
                {
                    receiverInternalIdentification = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("receiverInternalSubIdentification"u8))
                {
                    receiverInternalSubIdentification = property.Value.GetString();
                    continue;
                }
            }
            return new EdifactEnvelopeSettings(groupAssociationAssignedCode.Value, communicationAgreementId.Value, applyDelimiterStringAdvice, createGroupingSegments, enableDefaultGroupHeaders, recipientReferencePasswordValue.Value, recipientReferencePasswordQualifier.Value, applicationReferenceId.Value, processingPriorityCode.Value, interchangeControlNumberLowerBound, interchangeControlNumberUpperBound, rolloverInterchangeControlNumber, interchangeControlNumberPrefix.Value, interchangeControlNumberSuffix.Value, senderReverseRoutingAddress.Value, receiverReverseRoutingAddress.Value, functionalGroupId.Value, groupControllingAgencyCode.Value, groupMessageVersion.Value, groupMessageRelease.Value, groupControlNumberLowerBound, groupControlNumberUpperBound, rolloverGroupControlNumber, groupControlNumberPrefix.Value, groupControlNumberSuffix.Value, groupApplicationReceiverQualifier.Value, groupApplicationReceiverId.Value, groupApplicationSenderQualifier.Value, groupApplicationSenderId.Value, groupApplicationPassword.Value, overwriteExistingTransactionSetControlNumber, transactionSetControlNumberPrefix.Value, transactionSetControlNumberSuffix.Value, transactionSetControlNumberLowerBound, transactionSetControlNumberUpperBound, rolloverTransactionSetControlNumber, isTestInterchange, senderInternalIdentification.Value, senderInternalSubIdentification.Value, receiverInternalIdentification.Value, receiverInternalSubIdentification.Value);
        }
    }
}
