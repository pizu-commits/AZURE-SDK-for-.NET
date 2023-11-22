// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    public partial class PostgreSqlFlexibleServerLogFile : IUtf8JsonSerializable, IJsonModel<PostgreSqlFlexibleServerLogFile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PostgreSqlFlexibleServerLogFile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PostgreSqlFlexibleServerLogFile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerLogFile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(PostgreSqlFlexibleServerLogFile)} does not support '{format}' format.");
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
            if (Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("createdTime"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Optional.IsDefined(LastModifiedOn))
            {
                writer.WritePropertyName("lastModifiedTime"u8);
                writer.WriteStringValue(LastModifiedOn.Value, "O");
            }
            if (Optional.IsDefined(SizeInKb))
            {
                writer.WritePropertyName("sizeInKb"u8);
                writer.WriteNumberValue(SizeInKb.Value);
            }
            if (Optional.IsDefined(TypePropertiesType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(TypePropertiesType);
            }
            if (Optional.IsDefined(Uri))
            {
                writer.WritePropertyName("url"u8);
                writer.WriteStringValue(Uri.AbsoluteUri);
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

        PostgreSqlFlexibleServerLogFile IJsonModel<PostgreSqlFlexibleServerLogFile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerLogFile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(PostgreSqlFlexibleServerLogFile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePostgreSqlFlexibleServerLogFile(document.RootElement, options);
        }

        internal static PostgreSqlFlexibleServerLogFile DeserializePostgreSqlFlexibleServerLogFile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<DateTimeOffset> createdTime = default;
            Optional<DateTimeOffset> lastModifiedTime = default;
            Optional<long> sizeInKb = default;
            Optional<string> type0 = default;
            Optional<Uri> url = default;
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
                        if (property0.NameEquals("createdTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastModifiedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("sizeInKb"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sizeInKb = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("type"u8))
                        {
                            type0 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("url"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            url = new Uri(property0.Value.GetString());
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
            return new PostgreSqlFlexibleServerLogFile(id, name, type, systemData.Value, Optional.ToNullable(createdTime), Optional.ToNullable(lastModifiedTime), Optional.ToNullable(sizeInKb), type0.Value, url.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PostgreSqlFlexibleServerLogFile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerLogFile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(PostgreSqlFlexibleServerLogFile)} does not support '{options.Format}' format.");
            }
        }

        PostgreSqlFlexibleServerLogFile IPersistableModel<PostgreSqlFlexibleServerLogFile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerLogFile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePostgreSqlFlexibleServerLogFile(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(PostgreSqlFlexibleServerLogFile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PostgreSqlFlexibleServerLogFile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
