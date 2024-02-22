// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataLakeAnalytics.Models
{
    internal partial class DataLakeAnalyticsSasTokenInformationListResult : IUtf8JsonSerializable, IJsonModel<DataLakeAnalyticsSasTokenInformationListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataLakeAnalyticsSasTokenInformationListResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataLakeAnalyticsSasTokenInformationListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeAnalyticsSasTokenInformationListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataLakeAnalyticsSasTokenInformationListResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && !(Value is ChangeTrackingList<DataLakeAnalyticsSasTokenInformation> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(NextLink))
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

        DataLakeAnalyticsSasTokenInformationListResult IJsonModel<DataLakeAnalyticsSasTokenInformationListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeAnalyticsSasTokenInformationListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataLakeAnalyticsSasTokenInformationListResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataLakeAnalyticsSasTokenInformationListResult(document.RootElement, options);
        }

        internal static DataLakeAnalyticsSasTokenInformationListResult DeserializeDataLakeAnalyticsSasTokenInformationListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<DataLakeAnalyticsSasTokenInformation>> value = default;
            Optional<string> nextLink = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataLakeAnalyticsSasTokenInformation> array = new List<DataLakeAnalyticsSasTokenInformation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataLakeAnalyticsSasTokenInformation.DeserializeDataLakeAnalyticsSasTokenInformation(item, options));
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
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataLakeAnalyticsSasTokenInformationListResult(Optional.ToList(value), nextLink.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataLakeAnalyticsSasTokenInformationListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeAnalyticsSasTokenInformationListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataLakeAnalyticsSasTokenInformationListResult)} does not support '{options.Format}' format.");
            }
        }

        DataLakeAnalyticsSasTokenInformationListResult IPersistableModel<DataLakeAnalyticsSasTokenInformationListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeAnalyticsSasTokenInformationListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataLakeAnalyticsSasTokenInformationListResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataLakeAnalyticsSasTokenInformationListResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataLakeAnalyticsSasTokenInformationListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
