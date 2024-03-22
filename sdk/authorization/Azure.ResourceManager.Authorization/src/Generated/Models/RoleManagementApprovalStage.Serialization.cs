// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Authorization.Models
{
    public partial class RoleManagementApprovalStage : IUtf8JsonSerializable, IJsonModel<RoleManagementApprovalStage>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RoleManagementApprovalStage>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RoleManagementApprovalStage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoleManagementApprovalStage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RoleManagementApprovalStage)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ApprovalStageTimeOutInDays))
            {
                writer.WritePropertyName("approvalStageTimeOutInDays"u8);
                writer.WriteNumberValue(ApprovalStageTimeOutInDays.Value);
            }
            if (Optional.IsDefined(IsApproverJustificationRequired))
            {
                writer.WritePropertyName("isApproverJustificationRequired"u8);
                writer.WriteBooleanValue(IsApproverJustificationRequired.Value);
            }
            if (Optional.IsDefined(EscalationTimeInMinutes))
            {
                writer.WritePropertyName("escalationTimeInMinutes"u8);
                writer.WriteNumberValue(EscalationTimeInMinutes.Value);
            }
            if (Optional.IsCollectionDefined(PrimaryApprovers))
            {
                writer.WritePropertyName("primaryApprovers"u8);
                writer.WriteStartArray();
                foreach (var item in PrimaryApprovers)
                {
                    writer.WriteObjectValue<RoleManagementUserInfo>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsEscalationEnabled))
            {
                writer.WritePropertyName("isEscalationEnabled"u8);
                writer.WriteBooleanValue(IsEscalationEnabled.Value);
            }
            if (Optional.IsCollectionDefined(EscalationApprovers))
            {
                writer.WritePropertyName("escalationApprovers"u8);
                writer.WriteStartArray();
                foreach (var item in EscalationApprovers)
                {
                    writer.WriteObjectValue<RoleManagementUserInfo>(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        RoleManagementApprovalStage IJsonModel<RoleManagementApprovalStage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoleManagementApprovalStage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RoleManagementApprovalStage)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRoleManagementApprovalStage(document.RootElement, options);
        }

        internal static RoleManagementApprovalStage DeserializeRoleManagementApprovalStage(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? approvalStageTimeOutInDays = default;
            bool? isApproverJustificationRequired = default;
            int? escalationTimeInMinutes = default;
            IList<RoleManagementUserInfo> primaryApprovers = default;
            bool? isEscalationEnabled = default;
            IList<RoleManagementUserInfo> escalationApprovers = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("approvalStageTimeOutInDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    approvalStageTimeOutInDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("isApproverJustificationRequired"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isApproverJustificationRequired = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("escalationTimeInMinutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    escalationTimeInMinutes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("primaryApprovers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RoleManagementUserInfo> array = new List<RoleManagementUserInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RoleManagementUserInfo.DeserializeRoleManagementUserInfo(item, options));
                    }
                    primaryApprovers = array;
                    continue;
                }
                if (property.NameEquals("isEscalationEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isEscalationEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("escalationApprovers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RoleManagementUserInfo> array = new List<RoleManagementUserInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RoleManagementUserInfo.DeserializeRoleManagementUserInfo(item, options));
                    }
                    escalationApprovers = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RoleManagementApprovalStage(
                approvalStageTimeOutInDays,
                isApproverJustificationRequired,
                escalationTimeInMinutes,
                primaryApprovers ?? new ChangeTrackingList<RoleManagementUserInfo>(),
                isEscalationEnabled,
                escalationApprovers ?? new ChangeTrackingList<RoleManagementUserInfo>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RoleManagementApprovalStage>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoleManagementApprovalStage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RoleManagementApprovalStage)} does not support writing '{options.Format}' format.");
            }
        }

        RoleManagementApprovalStage IPersistableModel<RoleManagementApprovalStage>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoleManagementApprovalStage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRoleManagementApprovalStage(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RoleManagementApprovalStage)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RoleManagementApprovalStage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
