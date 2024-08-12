// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Datadog.Models
{
    internal partial class DatadogSingleSignOnResourceListResponse : IUtf8JsonSerializable, IJsonModel<DatadogSingleSignOnResourceListResponse>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DatadogSingleSignOnResourceListResponse>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DatadogSingleSignOnResourceListResponse>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatadogSingleSignOnResourceListResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DatadogSingleSignOnResourceListResponse)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
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

        DatadogSingleSignOnResourceListResponse IJsonModel<DatadogSingleSignOnResourceListResponse>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatadogSingleSignOnResourceListResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DatadogSingleSignOnResourceListResponse)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDatadogSingleSignOnResourceListResponse(document.RootElement, options);
        }

        internal static DatadogSingleSignOnResourceListResponse DeserializeDatadogSingleSignOnResourceListResponse(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<DatadogSingleSignOnResourceData> value = default;
            string nextLink = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DatadogSingleSignOnResourceData> array = new List<DatadogSingleSignOnResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DatadogSingleSignOnResourceData.DeserializeDatadogSingleSignOnResourceData(item, options));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DatadogSingleSignOnResourceListResponse(value ?? new ChangeTrackingList<DatadogSingleSignOnResourceData>(), nextLink, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DatadogSingleSignOnResourceListResponse>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatadogSingleSignOnResourceListResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DatadogSingleSignOnResourceListResponse)} does not support writing '{options.Format}' format.");
            }
        }

        DatadogSingleSignOnResourceListResponse IPersistableModel<DatadogSingleSignOnResourceListResponse>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatadogSingleSignOnResourceListResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDatadogSingleSignOnResourceListResponse(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DatadogSingleSignOnResourceListResponse)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DatadogSingleSignOnResourceListResponse>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
