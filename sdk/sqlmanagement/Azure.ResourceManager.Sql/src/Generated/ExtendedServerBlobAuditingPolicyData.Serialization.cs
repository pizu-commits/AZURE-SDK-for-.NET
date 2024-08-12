// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class ExtendedServerBlobAuditingPolicyData : IUtf8JsonSerializable, IJsonModel<ExtendedServerBlobAuditingPolicyData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExtendedServerBlobAuditingPolicyData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ExtendedServerBlobAuditingPolicyData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtendedServerBlobAuditingPolicyData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExtendedServerBlobAuditingPolicyData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(IsDevopsAuditEnabled))
            {
                writer.WritePropertyName("isDevopsAuditEnabled"u8);
                writer.WriteBooleanValue(IsDevopsAuditEnabled.Value);
            }
            if (Optional.IsDefined(PredicateExpression))
            {
                writer.WritePropertyName("predicateExpression"u8);
                writer.WriteStringValue(PredicateExpression);
            }
            if (Optional.IsDefined(RetentionDays))
            {
                writer.WritePropertyName("retentionDays"u8);
                writer.WriteNumberValue(RetentionDays.Value);
            }
            if (Optional.IsCollectionDefined(AuditActionsAndGroups))
            {
                writer.WritePropertyName("auditActionsAndGroups"u8);
                writer.WriteStartArray();
                foreach (var item in AuditActionsAndGroups)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsStorageSecondaryKeyInUse))
            {
                writer.WritePropertyName("isStorageSecondaryKeyInUse"u8);
                writer.WriteBooleanValue(IsStorageSecondaryKeyInUse.Value);
            }
            if (Optional.IsDefined(IsAzureMonitorTargetEnabled))
            {
                writer.WritePropertyName("isAzureMonitorTargetEnabled"u8);
                writer.WriteBooleanValue(IsAzureMonitorTargetEnabled.Value);
            }
            if (Optional.IsDefined(QueueDelayMs))
            {
                writer.WritePropertyName("queueDelayMs"u8);
                writer.WriteNumberValue(QueueDelayMs.Value);
            }
            if (Optional.IsDefined(IsManagedIdentityInUse))
            {
                writer.WritePropertyName("isManagedIdentityInUse"u8);
                writer.WriteBooleanValue(IsManagedIdentityInUse.Value);
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToSerialString());
            }
            if (Optional.IsDefined(StorageEndpoint))
            {
                writer.WritePropertyName("storageEndpoint"u8);
                writer.WriteStringValue(StorageEndpoint);
            }
            if (Optional.IsDefined(StorageAccountAccessKey))
            {
                writer.WritePropertyName("storageAccountAccessKey"u8);
                writer.WriteStringValue(StorageAccountAccessKey);
            }
            if (Optional.IsDefined(StorageAccountSubscriptionId))
            {
                writer.WritePropertyName("storageAccountSubscriptionId"u8);
                writer.WriteStringValue(StorageAccountSubscriptionId.Value);
            }
            writer.WriteEndObject();
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

        ExtendedServerBlobAuditingPolicyData IJsonModel<ExtendedServerBlobAuditingPolicyData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtendedServerBlobAuditingPolicyData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExtendedServerBlobAuditingPolicyData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExtendedServerBlobAuditingPolicyData(document.RootElement, options);
        }

        internal static ExtendedServerBlobAuditingPolicyData DeserializeExtendedServerBlobAuditingPolicyData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            bool? isDevopsAuditEnabled = default;
            string predicateExpression = default;
            int? retentionDays = default;
            IList<string> auditActionsAndGroups = default;
            bool? isStorageSecondaryKeyInUse = default;
            bool? isAzureMonitorTargetEnabled = default;
            int? queueDelayMs = default;
            bool? isManagedIdentityInUse = default;
            BlobAuditingPolicyState? state = default;
            string storageEndpoint = default;
            string storageAccountAccessKey = default;
            Guid? storageAccountSubscriptionId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("isDevopsAuditEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isDevopsAuditEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("predicateExpression"u8))
                        {
                            predicateExpression = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("retentionDays"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            retentionDays = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("auditActionsAndGroups"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            auditActionsAndGroups = array;
                            continue;
                        }
                        if (property0.NameEquals("isStorageSecondaryKeyInUse"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isStorageSecondaryKeyInUse = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isAzureMonitorTargetEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isAzureMonitorTargetEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("queueDelayMs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            queueDelayMs = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("isManagedIdentityInUse"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isManagedIdentityInUse = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("state"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            state = property0.Value.GetString().ToBlobAuditingPolicyState();
                            continue;
                        }
                        if (property0.NameEquals("storageEndpoint"u8))
                        {
                            storageEndpoint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("storageAccountAccessKey"u8))
                        {
                            storageAccountAccessKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("storageAccountSubscriptionId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageAccountSubscriptionId = property0.Value.GetGuid();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ExtendedServerBlobAuditingPolicyData(
                id,
                name,
                type,
                systemData,
                isDevopsAuditEnabled,
                predicateExpression,
                retentionDays,
                auditActionsAndGroups ?? new ChangeTrackingList<string>(),
                isStorageSecondaryKeyInUse,
                isAzureMonitorTargetEnabled,
                queueDelayMs,
                isManagedIdentityInUse,
                state,
                storageEndpoint,
                storageAccountAccessKey,
                storageAccountSubscriptionId,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Name))
                {
                    builder.Append("  name: ");
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Id), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  id: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Id))
                {
                    builder.Append("  id: ");
                    builder.AppendLine($"'{Id.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SystemData), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  systemData: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SystemData))
                {
                    builder.Append("  systemData: ");
                    builder.AppendLine($"'{SystemData.ToString()}'");
                }
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsDevopsAuditEnabled), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    isDevopsAuditEnabled: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsDevopsAuditEnabled))
                {
                    builder.Append("    isDevopsAuditEnabled: ");
                    var boolValue = IsDevopsAuditEnabled.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PredicateExpression), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    predicateExpression: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PredicateExpression))
                {
                    builder.Append("    predicateExpression: ");
                    if (PredicateExpression.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{PredicateExpression}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{PredicateExpression}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RetentionDays), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    retentionDays: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RetentionDays))
                {
                    builder.Append("    retentionDays: ");
                    builder.AppendLine($"{RetentionDays.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AuditActionsAndGroups), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    auditActionsAndGroups: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(AuditActionsAndGroups))
                {
                    if (AuditActionsAndGroups.Any())
                    {
                        builder.Append("    auditActionsAndGroups: ");
                        builder.AppendLine("[");
                        foreach (var item in AuditActionsAndGroups)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("      '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"      '{item}'");
                            }
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsStorageSecondaryKeyInUse), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    isStorageSecondaryKeyInUse: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsStorageSecondaryKeyInUse))
                {
                    builder.Append("    isStorageSecondaryKeyInUse: ");
                    var boolValue = IsStorageSecondaryKeyInUse.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsAzureMonitorTargetEnabled), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    isAzureMonitorTargetEnabled: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsAzureMonitorTargetEnabled))
                {
                    builder.Append("    isAzureMonitorTargetEnabled: ");
                    var boolValue = IsAzureMonitorTargetEnabled.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(QueueDelayMs), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    queueDelayMs: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(QueueDelayMs))
                {
                    builder.Append("    queueDelayMs: ");
                    builder.AppendLine($"{QueueDelayMs.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsManagedIdentityInUse), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    isManagedIdentityInUse: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsManagedIdentityInUse))
                {
                    builder.Append("    isManagedIdentityInUse: ");
                    var boolValue = IsManagedIdentityInUse.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(State), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    state: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(State))
                {
                    builder.Append("    state: ");
                    builder.AppendLine($"'{State.Value.ToSerialString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(StorageEndpoint), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    storageEndpoint: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(StorageEndpoint))
                {
                    builder.Append("    storageEndpoint: ");
                    if (StorageEndpoint.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{StorageEndpoint}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{StorageEndpoint}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(StorageAccountAccessKey), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    storageAccountAccessKey: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(StorageAccountAccessKey))
                {
                    builder.Append("    storageAccountAccessKey: ");
                    if (StorageAccountAccessKey.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{StorageAccountAccessKey}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{StorageAccountAccessKey}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(StorageAccountSubscriptionId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    storageAccountSubscriptionId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(StorageAccountSubscriptionId))
                {
                    builder.Append("    storageAccountSubscriptionId: ");
                    builder.AppendLine($"'{StorageAccountSubscriptionId.Value.ToString()}'");
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ExtendedServerBlobAuditingPolicyData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtendedServerBlobAuditingPolicyData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ExtendedServerBlobAuditingPolicyData)} does not support writing '{options.Format}' format.");
            }
        }

        ExtendedServerBlobAuditingPolicyData IPersistableModel<ExtendedServerBlobAuditingPolicyData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtendedServerBlobAuditingPolicyData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExtendedServerBlobAuditingPolicyData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExtendedServerBlobAuditingPolicyData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExtendedServerBlobAuditingPolicyData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
