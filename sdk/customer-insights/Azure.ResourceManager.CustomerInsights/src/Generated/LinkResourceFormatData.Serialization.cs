// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.CustomerInsights.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CustomerInsights
{
    public partial class LinkResourceFormatData : IUtf8JsonSerializable, IJsonModel<LinkResourceFormatData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LinkResourceFormatData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LinkResourceFormatData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinkResourceFormatData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LinkResourceFormatData)} does not support writing '{format}' format.");
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
            if (options.Format != "W" && Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(LinkName))
            {
                writer.WritePropertyName("linkName"u8);
                writer.WriteStringValue(LinkName);
            }
            if (Optional.IsDefined(SourceEntityType))
            {
                writer.WritePropertyName("sourceEntityType"u8);
                writer.WriteStringValue(SourceEntityType.Value.ToSerialString());
            }
            if (Optional.IsDefined(TargetEntityType))
            {
                writer.WritePropertyName("targetEntityType"u8);
                writer.WriteStringValue(TargetEntityType.Value.ToSerialString());
            }
            if (Optional.IsDefined(SourceEntityTypeName))
            {
                writer.WritePropertyName("sourceEntityTypeName"u8);
                writer.WriteStringValue(SourceEntityTypeName);
            }
            if (Optional.IsDefined(TargetEntityTypeName))
            {
                writer.WritePropertyName("targetEntityTypeName"u8);
                writer.WriteStringValue(TargetEntityTypeName);
            }
            if (Optional.IsCollectionDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStartObject();
                foreach (var item in DisplayName)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStartObject();
                foreach (var item in Description)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Mappings))
            {
                writer.WritePropertyName("mappings"u8);
                writer.WriteStartArray();
                foreach (var item in Mappings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ParticipantPropertyReferences))
            {
                writer.WritePropertyName("participantPropertyReferences"u8);
                writer.WriteStartArray();
                foreach (var item in ParticipantPropertyReferences)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(ReferenceOnly))
            {
                writer.WritePropertyName("referenceOnly"u8);
                writer.WriteBooleanValue(ReferenceOnly.Value);
            }
            if (Optional.IsDefined(OperationType))
            {
                writer.WritePropertyName("operationType"u8);
                writer.WriteStringValue(OperationType.Value.ToSerialString());
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

        LinkResourceFormatData IJsonModel<LinkResourceFormatData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinkResourceFormatData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LinkResourceFormatData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLinkResourceFormatData(document.RootElement, options);
        }

        internal static LinkResourceFormatData DeserializeLinkResourceFormatData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Guid? tenantId = default;
            string linkName = default;
            EntityType? sourceEntityType = default;
            EntityType? targetEntityType = default;
            string sourceEntityTypeName = default;
            string targetEntityTypeName = default;
            IDictionary<string, string> displayName = default;
            IDictionary<string, string> description = default;
            IList<TypePropertiesMapping> mappings = default;
            IList<ParticipantPropertyReference> participantPropertyReferences = default;
            ProvisioningState? provisioningState = default;
            bool? referenceOnly = default;
            InstanceOperationType? operationType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
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
                        if (property0.NameEquals("tenantId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            tenantId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("linkName"u8))
                        {
                            linkName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sourceEntityType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sourceEntityType = property0.Value.GetString().ToEntityType();
                            continue;
                        }
                        if (property0.NameEquals("targetEntityType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetEntityType = property0.Value.GetString().ToEntityType();
                            continue;
                        }
                        if (property0.NameEquals("sourceEntityTypeName"u8))
                        {
                            sourceEntityTypeName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("targetEntityTypeName"u8))
                        {
                            targetEntityTypeName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            displayName = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            description = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("mappings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<TypePropertiesMapping> array = new List<TypePropertiesMapping>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(TypePropertiesMapping.DeserializeTypePropertiesMapping(item, options));
                            }
                            mappings = array;
                            continue;
                        }
                        if (property0.NameEquals("participantPropertyReferences"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ParticipantPropertyReference> array = new List<ParticipantPropertyReference>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ParticipantPropertyReference.DeserializeParticipantPropertyReference(item, options));
                            }
                            participantPropertyReferences = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("referenceOnly"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            referenceOnly = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("operationType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            operationType = property0.Value.GetString().ToInstanceOperationType();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LinkResourceFormatData(
                id,
                name,
                type,
                systemData,
                tenantId,
                linkName,
                sourceEntityType,
                targetEntityType,
                sourceEntityTypeName,
                targetEntityTypeName,
                displayName ?? new ChangeTrackingDictionary<string, string>(),
                description ?? new ChangeTrackingDictionary<string, string>(),
                mappings ?? new ChangeTrackingList<TypePropertiesMapping>(),
                participantPropertyReferences ?? new ChangeTrackingList<ParticipantPropertyReference>(),
                provisioningState,
                referenceOnly,
                operationType,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LinkResourceFormatData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinkResourceFormatData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LinkResourceFormatData)} does not support writing '{options.Format}' format.");
            }
        }

        LinkResourceFormatData IPersistableModel<LinkResourceFormatData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinkResourceFormatData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLinkResourceFormatData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LinkResourceFormatData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<LinkResourceFormatData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
