// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ElasticSan.Models
{
    public partial class ElasticSanSkuInformation : IUtf8JsonSerializable, IJsonModel<ElasticSanSkuInformation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ElasticSanSkuInformation>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ElasticSanSkuInformation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticSanSkuInformation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ElasticSanSkuInformation)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name.ToString());
            if (Optional.IsDefined(Tier))
            {
                writer.WritePropertyName("tier"u8);
                writer.WriteStringValue(Tier.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceType))
            {
                writer.WritePropertyName("resourceType"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Locations))
            {
                writer.WritePropertyName("locations"u8);
                writer.WriteStartArray();
                foreach (var item in Locations)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(LocationInfo))
            {
                writer.WritePropertyName("locationInfo"u8);
                writer.WriteStartArray();
                foreach (var item in LocationInfo)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Capabilities))
            {
                writer.WritePropertyName("capabilities"u8);
                writer.WriteStartArray();
                foreach (var item in Capabilities)
                {
                    writer.WriteObjectValue(item, options);
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

        ElasticSanSkuInformation IJsonModel<ElasticSanSkuInformation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticSanSkuInformation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ElasticSanSkuInformation)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeElasticSanSkuInformation(document.RootElement, options);
        }

        internal static ElasticSanSkuInformation DeserializeElasticSanSkuInformation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ElasticSanSkuName name = default;
            ElasticSanSkuTier? tier = default;
            string resourceType = default;
            IReadOnlyList<string> locations = default;
            IReadOnlyList<ElasticSanSkuLocationInfo> locationInfo = default;
            IReadOnlyList<ElasticSanSkuCapability> capabilities = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = new ElasticSanSkuName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tier"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tier = new ElasticSanSkuTier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceType"u8))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("locations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    locations = array;
                    continue;
                }
                if (property.NameEquals("locationInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ElasticSanSkuLocationInfo> array = new List<ElasticSanSkuLocationInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ElasticSanSkuLocationInfo.DeserializeElasticSanSkuLocationInfo(item, options));
                    }
                    locationInfo = array;
                    continue;
                }
                if (property.NameEquals("capabilities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ElasticSanSkuCapability> array = new List<ElasticSanSkuCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ElasticSanSkuCapability.DeserializeElasticSanSkuCapability(item, options));
                    }
                    capabilities = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ElasticSanSkuInformation(
                name,
                tier,
                resourceType,
                locations ?? new ChangeTrackingList<string>(),
                locationInfo ?? new ChangeTrackingList<ElasticSanSkuLocationInfo>(),
                capabilities ?? new ChangeTrackingList<ElasticSanSkuCapability>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ElasticSanSkuInformation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticSanSkuInformation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ElasticSanSkuInformation)} does not support writing '{options.Format}' format.");
            }
        }

        ElasticSanSkuInformation IPersistableModel<ElasticSanSkuInformation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticSanSkuInformation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeElasticSanSkuInformation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ElasticSanSkuInformation)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ElasticSanSkuInformation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
