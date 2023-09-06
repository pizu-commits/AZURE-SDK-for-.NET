// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class EdifactEnvelopeSettings : IUtf8JsonSerializable, IModelJsonSerializable<EdifactEnvelopeSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<EdifactEnvelopeSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<EdifactEnvelopeSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EdifactEnvelopeSettings>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(GroupAssociationAssignedCode))
            {
                writer.WritePropertyName("groupAssociationAssignedCode"u8);
                writer.WriteStringValue(GroupAssociationAssignedCode);
            }
            if (Optional.IsDefined(CommunicationAgreementId))
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
            if (Optional.IsDefined(RecipientReferencePasswordValue))
            {
                writer.WritePropertyName("recipientReferencePasswordValue"u8);
                writer.WriteStringValue(RecipientReferencePasswordValue);
            }
            if (Optional.IsDefined(RecipientReferencePasswordQualifier))
            {
                writer.WritePropertyName("recipientReferencePasswordQualifier"u8);
                writer.WriteStringValue(RecipientReferencePasswordQualifier);
            }
            if (Optional.IsDefined(ApplicationReferenceId))
            {
                writer.WritePropertyName("applicationReferenceId"u8);
                writer.WriteStringValue(ApplicationReferenceId);
            }
            if (Optional.IsDefined(ProcessingPriorityCode))
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
            if (Optional.IsDefined(InterchangeControlNumberPrefix))
            {
                writer.WritePropertyName("interchangeControlNumberPrefix"u8);
                writer.WriteStringValue(InterchangeControlNumberPrefix);
            }
            if (Optional.IsDefined(InterchangeControlNumberSuffix))
            {
                writer.WritePropertyName("interchangeControlNumberSuffix"u8);
                writer.WriteStringValue(InterchangeControlNumberSuffix);
            }
            if (Optional.IsDefined(SenderReverseRoutingAddress))
            {
                writer.WritePropertyName("senderReverseRoutingAddress"u8);
                writer.WriteStringValue(SenderReverseRoutingAddress);
            }
            if (Optional.IsDefined(ReceiverReverseRoutingAddress))
            {
                writer.WritePropertyName("receiverReverseRoutingAddress"u8);
                writer.WriteStringValue(ReceiverReverseRoutingAddress);
            }
            if (Optional.IsDefined(FunctionalGroupId))
            {
                writer.WritePropertyName("functionalGroupId"u8);
                writer.WriteStringValue(FunctionalGroupId);
            }
            if (Optional.IsDefined(GroupControllingAgencyCode))
            {
                writer.WritePropertyName("groupControllingAgencyCode"u8);
                writer.WriteStringValue(GroupControllingAgencyCode);
            }
            if (Optional.IsDefined(GroupMessageVersion))
            {
                writer.WritePropertyName("groupMessageVersion"u8);
                writer.WriteStringValue(GroupMessageVersion);
            }
            if (Optional.IsDefined(GroupMessageRelease))
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
            if (Optional.IsDefined(GroupControlNumberPrefix))
            {
                writer.WritePropertyName("groupControlNumberPrefix"u8);
                writer.WriteStringValue(GroupControlNumberPrefix);
            }
            if (Optional.IsDefined(GroupControlNumberSuffix))
            {
                writer.WritePropertyName("groupControlNumberSuffix"u8);
                writer.WriteStringValue(GroupControlNumberSuffix);
            }
            if (Optional.IsDefined(GroupApplicationReceiverQualifier))
            {
                writer.WritePropertyName("groupApplicationReceiverQualifier"u8);
                writer.WriteStringValue(GroupApplicationReceiverQualifier);
            }
            if (Optional.IsDefined(GroupApplicationReceiverId))
            {
                writer.WritePropertyName("groupApplicationReceiverId"u8);
                writer.WriteStringValue(GroupApplicationReceiverId);
            }
            if (Optional.IsDefined(GroupApplicationSenderQualifier))
            {
                writer.WritePropertyName("groupApplicationSenderQualifier"u8);
                writer.WriteStringValue(GroupApplicationSenderQualifier);
            }
            if (Optional.IsDefined(GroupApplicationSenderId))
            {
                writer.WritePropertyName("groupApplicationSenderId"u8);
                writer.WriteStringValue(GroupApplicationSenderId);
            }
            if (Optional.IsDefined(GroupApplicationPassword))
            {
                writer.WritePropertyName("groupApplicationPassword"u8);
                writer.WriteStringValue(GroupApplicationPassword);
            }
            writer.WritePropertyName("overwriteExistingTransactionSetControlNumber"u8);
            writer.WriteBooleanValue(OverwriteExistingTransactionSetControlNumber);
            if (Optional.IsDefined(TransactionSetControlNumberPrefix))
            {
                writer.WritePropertyName("transactionSetControlNumberPrefix"u8);
                writer.WriteStringValue(TransactionSetControlNumberPrefix);
            }
            if (Optional.IsDefined(TransactionSetControlNumberSuffix))
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
            if (Optional.IsDefined(SenderInternalIdentification))
            {
                writer.WritePropertyName("senderInternalIdentification"u8);
                writer.WriteStringValue(SenderInternalIdentification);
            }
            if (Optional.IsDefined(SenderInternalSubIdentification))
            {
                writer.WritePropertyName("senderInternalSubIdentification"u8);
                writer.WriteStringValue(SenderInternalSubIdentification);
            }
            if (Optional.IsDefined(ReceiverInternalIdentification))
            {
                writer.WritePropertyName("receiverInternalIdentification"u8);
                writer.WriteStringValue(ReceiverInternalIdentification);
            }
            if (Optional.IsDefined(ReceiverInternalSubIdentification))
            {
                writer.WritePropertyName("receiverInternalSubIdentification"u8);
                writer.WriteStringValue(ReceiverInternalSubIdentification);
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static EdifactEnvelopeSettings DeserializeEdifactEnvelopeSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> groupAssociationAssignedCode = default;
            Optional<string> communicationAgreementId = default;
            bool applyDelimiterStringAdvice = default;
            bool createGroupingSegments = default;
            bool enableDefaultGroupHeaders = default;
            Optional<string> recipientReferencePasswordValue = default;
            Optional<string> recipientReferencePasswordQualifier = default;
            Optional<string> applicationReferenceId = default;
            Optional<string> processingPriorityCode = default;
            long interchangeControlNumberLowerBound = default;
            long interchangeControlNumberUpperBound = default;
            bool rolloverInterchangeControlNumber = default;
            Optional<string> interchangeControlNumberPrefix = default;
            Optional<string> interchangeControlNumberSuffix = default;
            Optional<string> senderReverseRoutingAddress = default;
            Optional<string> receiverReverseRoutingAddress = default;
            Optional<string> functionalGroupId = default;
            Optional<string> groupControllingAgencyCode = default;
            Optional<string> groupMessageVersion = default;
            Optional<string> groupMessageRelease = default;
            long groupControlNumberLowerBound = default;
            long groupControlNumberUpperBound = default;
            bool rolloverGroupControlNumber = default;
            Optional<string> groupControlNumberPrefix = default;
            Optional<string> groupControlNumberSuffix = default;
            Optional<string> groupApplicationReceiverQualifier = default;
            Optional<string> groupApplicationReceiverId = default;
            Optional<string> groupApplicationSenderQualifier = default;
            Optional<string> groupApplicationSenderId = default;
            Optional<string> groupApplicationPassword = default;
            bool overwriteExistingTransactionSetControlNumber = default;
            Optional<string> transactionSetControlNumberPrefix = default;
            Optional<string> transactionSetControlNumberSuffix = default;
            long transactionSetControlNumberLowerBound = default;
            long transactionSetControlNumberUpperBound = default;
            bool rolloverTransactionSetControlNumber = default;
            bool isTestInterchange = default;
            Optional<string> senderInternalIdentification = default;
            Optional<string> senderInternalSubIdentification = default;
            Optional<string> receiverInternalIdentification = default;
            Optional<string> receiverInternalSubIdentification = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
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
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new EdifactEnvelopeSettings(groupAssociationAssignedCode.Value, communicationAgreementId.Value, applyDelimiterStringAdvice, createGroupingSegments, enableDefaultGroupHeaders, recipientReferencePasswordValue.Value, recipientReferencePasswordQualifier.Value, applicationReferenceId.Value, processingPriorityCode.Value, interchangeControlNumberLowerBound, interchangeControlNumberUpperBound, rolloverInterchangeControlNumber, interchangeControlNumberPrefix.Value, interchangeControlNumberSuffix.Value, senderReverseRoutingAddress.Value, receiverReverseRoutingAddress.Value, functionalGroupId.Value, groupControllingAgencyCode.Value, groupMessageVersion.Value, groupMessageRelease.Value, groupControlNumberLowerBound, groupControlNumberUpperBound, rolloverGroupControlNumber, groupControlNumberPrefix.Value, groupControlNumberSuffix.Value, groupApplicationReceiverQualifier.Value, groupApplicationReceiverId.Value, groupApplicationSenderQualifier.Value, groupApplicationSenderId.Value, groupApplicationPassword.Value, overwriteExistingTransactionSetControlNumber, transactionSetControlNumberPrefix.Value, transactionSetControlNumberSuffix.Value, transactionSetControlNumberLowerBound, transactionSetControlNumberUpperBound, rolloverTransactionSetControlNumber, isTestInterchange, senderInternalIdentification.Value, senderInternalSubIdentification.Value, receiverInternalIdentification.Value, receiverInternalSubIdentification.Value, rawData);
        }

        EdifactEnvelopeSettings IModelJsonSerializable<EdifactEnvelopeSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EdifactEnvelopeSettings>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeEdifactEnvelopeSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<EdifactEnvelopeSettings>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EdifactEnvelopeSettings>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        EdifactEnvelopeSettings IModelSerializable<EdifactEnvelopeSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EdifactEnvelopeSettings>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeEdifactEnvelopeSettings(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="EdifactEnvelopeSettings"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="EdifactEnvelopeSettings"/> to convert. </param>
        public static implicit operator RequestContent(EdifactEnvelopeSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="EdifactEnvelopeSettings"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator EdifactEnvelopeSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeEdifactEnvelopeSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
