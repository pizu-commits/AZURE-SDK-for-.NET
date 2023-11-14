// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    public partial class SynapseSensitivityLabelData : IUtf8JsonSerializable, IJsonModel<SynapseSensitivityLabelData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseSensitivityLabelData>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<SynapseSensitivityLabelData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<SynapseSensitivityLabelData>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<SynapseSensitivityLabelData>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ManagedBy))
                {
                    writer.WritePropertyName("managedBy"u8);
                    writer.WriteStringValue(ManagedBy);
                }
            }
            if (options.Format == "J")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format == "J")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format == "J")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(SystemData))
                {
                    writer.WritePropertyName("systemData"u8);
                    JsonSerializer.Serialize(writer, SystemData);
                }
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(SchemaName))
                {
                    writer.WritePropertyName("schemaName"u8);
                    writer.WriteStringValue(SchemaName);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(TableName))
                {
                    writer.WritePropertyName("tableName"u8);
                    writer.WriteStringValue(TableName);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ColumnName))
                {
                    writer.WritePropertyName("columnName"u8);
                    writer.WriteStringValue(ColumnName);
                }
            }
            if (Optional.IsDefined(LabelName))
            {
                writer.WritePropertyName("labelName"u8);
                writer.WriteStringValue(LabelName);
            }
            if (Optional.IsDefined(LabelId))
            {
                writer.WritePropertyName("labelId"u8);
                writer.WriteStringValue(LabelId.Value);
            }
            if (Optional.IsDefined(InformationType))
            {
                writer.WritePropertyName("informationType"u8);
                writer.WriteStringValue(InformationType);
            }
            if (Optional.IsDefined(InformationTypeId))
            {
                writer.WritePropertyName("informationTypeId"u8);
                writer.WriteStringValue(InformationTypeId.Value);
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(IsDisabled))
                {
                    writer.WritePropertyName("isDisabled"u8);
                    writer.WriteBooleanValue(IsDisabled.Value);
                }
            }
            if (Optional.IsDefined(Rank))
            {
                writer.WritePropertyName("rank"u8);
                writer.WriteStringValue(Rank.Value.ToSerialString());
            }
            writer.WriteEndObject();
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        SynapseSensitivityLabelData IJsonModel<SynapseSensitivityLabelData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SynapseSensitivityLabelData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseSensitivityLabelData(document.RootElement, options);
        }

        internal static SynapseSensitivityLabelData DeserializeSynapseSensitivityLabelData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> managedBy = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> schemaName = default;
            Optional<string> tableName = default;
            Optional<string> columnName = default;
            Optional<string> labelName = default;
            Optional<Guid> labelId = default;
            Optional<string> informationType = default;
            Optional<Guid> informationTypeId = default;
            Optional<bool> isDisabled = default;
            Optional<SynapseSensitivityLabelRank> rank = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("managedBy"u8))
                {
                    managedBy = property.Value.GetString();
                    continue;
                }
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
                        if (property0.NameEquals("schemaName"u8))
                        {
                            schemaName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("tableName"u8))
                        {
                            tableName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("columnName"u8))
                        {
                            columnName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("labelName"u8))
                        {
                            labelName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("labelId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            labelId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("informationType"u8))
                        {
                            informationType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("informationTypeId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            informationTypeId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("isDisabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isDisabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("rank"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rank = property0.Value.GetString().ToSynapseSensitivityLabelRank();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SynapseSensitivityLabelData(id, name, type, systemData.Value, managedBy.Value, schemaName.Value, tableName.Value, columnName.Value, labelName.Value, Optional.ToNullable(labelId), informationType.Value, Optional.ToNullable(informationTypeId), Optional.ToNullable(isDisabled), Optional.ToNullable(rank), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SynapseSensitivityLabelData>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SynapseSensitivityLabelData)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SynapseSensitivityLabelData IPersistableModel<SynapseSensitivityLabelData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SynapseSensitivityLabelData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSynapseSensitivityLabelData(document.RootElement, options);
        }

        string IPersistableModel<SynapseSensitivityLabelData>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
