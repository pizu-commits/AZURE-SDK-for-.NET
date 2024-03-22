// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.MySql.FlexibleServers.Models;

namespace Azure.ResourceManager.MySql.FlexibleServers
{
    public partial class MySqlFlexibleServersCapabilityData : IUtf8JsonSerializable, IJsonModel<MySqlFlexibleServersCapabilityData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MySqlFlexibleServersCapabilityData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MySqlFlexibleServersCapabilityData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServersCapabilityData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MySqlFlexibleServersCapabilityData)} does not support writing '{format}' format.");
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
            if (options.Format != "W" && Optional.IsCollectionDefined(SupportedGeoBackupRegions))
            {
                writer.WritePropertyName("supportedGeoBackupRegions"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedGeoBackupRegions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(SupportedFlexibleServerEditions))
            {
                writer.WritePropertyName("supportedFlexibleServerEditions"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedFlexibleServerEditions)
                {
                    writer.WriteObjectValue<ServerEditionCapabilityV2>(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(SupportedServerVersions))
            {
                writer.WritePropertyName("supportedServerVersions"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedServerVersions)
                {
                    writer.WriteObjectValue<ServerVersionCapabilityV2>(item, options);
                }
                writer.WriteEndArray();
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

        MySqlFlexibleServersCapabilityData IJsonModel<MySqlFlexibleServersCapabilityData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServersCapabilityData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MySqlFlexibleServersCapabilityData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMySqlFlexibleServersCapabilityData(document.RootElement, options);
        }

        internal static MySqlFlexibleServersCapabilityData DeserializeMySqlFlexibleServersCapabilityData(JsonElement element, ModelReaderWriterOptions options = null)
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
            IReadOnlyList<string> supportedGeoBackupRegions = default;
            IReadOnlyList<ServerEditionCapabilityV2> supportedFlexibleServerEditions = default;
            IReadOnlyList<ServerVersionCapabilityV2> supportedServerVersions = default;
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
                        if (property0.NameEquals("supportedGeoBackupRegions"u8))
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
                            supportedGeoBackupRegions = array;
                            continue;
                        }
                        if (property0.NameEquals("supportedFlexibleServerEditions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ServerEditionCapabilityV2> array = new List<ServerEditionCapabilityV2>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ServerEditionCapabilityV2.DeserializeServerEditionCapabilityV2(item, options));
                            }
                            supportedFlexibleServerEditions = array;
                            continue;
                        }
                        if (property0.NameEquals("supportedServerVersions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ServerVersionCapabilityV2> array = new List<ServerVersionCapabilityV2>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ServerVersionCapabilityV2.DeserializeServerVersionCapabilityV2(item, options));
                            }
                            supportedServerVersions = array;
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
            return new MySqlFlexibleServersCapabilityData(
                id,
                name,
                type,
                systemData,
                supportedGeoBackupRegions ?? new ChangeTrackingList<string>(),
                supportedFlexibleServerEditions ?? new ChangeTrackingList<ServerEditionCapabilityV2>(),
                supportedServerVersions ?? new ChangeTrackingList<ServerVersionCapabilityV2>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MySqlFlexibleServersCapabilityData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServersCapabilityData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MySqlFlexibleServersCapabilityData)} does not support writing '{options.Format}' format.");
            }
        }

        MySqlFlexibleServersCapabilityData IPersistableModel<MySqlFlexibleServersCapabilityData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServersCapabilityData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMySqlFlexibleServersCapabilityData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MySqlFlexibleServersCapabilityData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MySqlFlexibleServersCapabilityData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
