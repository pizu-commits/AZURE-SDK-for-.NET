// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class StreamAnalyticsPrivateEndpointProperties : IUtf8JsonSerializable, IJsonModel<StreamAnalyticsPrivateEndpointProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StreamAnalyticsPrivateEndpointProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<StreamAnalyticsPrivateEndpointProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamAnalyticsPrivateEndpointProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamAnalyticsPrivateEndpointProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("createdDate"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Optional.IsCollectionDefined(ManualPrivateLinkServiceConnections))
            {
                writer.WritePropertyName("manualPrivateLinkServiceConnections"u8);
                writer.WriteStartArray();
                foreach (var item in ManualPrivateLinkServiceConnections)
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

        StreamAnalyticsPrivateEndpointProperties IJsonModel<StreamAnalyticsPrivateEndpointProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamAnalyticsPrivateEndpointProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamAnalyticsPrivateEndpointProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStreamAnalyticsPrivateEndpointProperties(document.RootElement, options);
        }

        internal static StreamAnalyticsPrivateEndpointProperties DeserializeStreamAnalyticsPrivateEndpointProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? createdDate = default;
            IList<StreamAnalyticsPrivateLinkServiceConnection> manualPrivateLinkServiceConnections = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("createdDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("manualPrivateLinkServiceConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StreamAnalyticsPrivateLinkServiceConnection> array = new List<StreamAnalyticsPrivateLinkServiceConnection>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StreamAnalyticsPrivateLinkServiceConnection.DeserializeStreamAnalyticsPrivateLinkServiceConnection(item, options));
                    }
                    manualPrivateLinkServiceConnections = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new StreamAnalyticsPrivateEndpointProperties(createdDate, manualPrivateLinkServiceConnections ?? new ChangeTrackingList<StreamAnalyticsPrivateLinkServiceConnection>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StreamAnalyticsPrivateEndpointProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamAnalyticsPrivateEndpointProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StreamAnalyticsPrivateEndpointProperties)} does not support writing '{options.Format}' format.");
            }
        }

        StreamAnalyticsPrivateEndpointProperties IPersistableModel<StreamAnalyticsPrivateEndpointProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamAnalyticsPrivateEndpointProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStreamAnalyticsPrivateEndpointProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StreamAnalyticsPrivateEndpointProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StreamAnalyticsPrivateEndpointProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
