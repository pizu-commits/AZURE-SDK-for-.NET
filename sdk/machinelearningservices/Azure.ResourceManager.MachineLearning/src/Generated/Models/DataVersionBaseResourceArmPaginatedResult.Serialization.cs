// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class DataVersionBaseResourceArmPaginatedResult : IUtf8JsonSerializable, IJsonModel<DataVersionBaseResourceArmPaginatedResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataVersionBaseResourceArmPaginatedResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataVersionBaseResourceArmPaginatedResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataVersionBaseResourceArmPaginatedResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataVersionBaseResourceArmPaginatedResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
            }
            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item);
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

        DataVersionBaseResourceArmPaginatedResult IJsonModel<DataVersionBaseResourceArmPaginatedResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataVersionBaseResourceArmPaginatedResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataVersionBaseResourceArmPaginatedResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataVersionBaseResourceArmPaginatedResult(document.RootElement, options);
        }

        internal static DataVersionBaseResourceArmPaginatedResult DeserializeDataVersionBaseResourceArmPaginatedResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string nextLink = default;
            IReadOnlyList<MachineLearningDataVersionData> value = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MachineLearningDataVersionData> array = new List<MachineLearningDataVersionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MachineLearningDataVersionData.DeserializeMachineLearningDataVersionData(item, options));
                    }
                    value = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataVersionBaseResourceArmPaginatedResult(nextLink, value ?? new ChangeTrackingList<MachineLearningDataVersionData>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataVersionBaseResourceArmPaginatedResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataVersionBaseResourceArmPaginatedResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataVersionBaseResourceArmPaginatedResult)} does not support '{options.Format}' format.");
            }
        }

        DataVersionBaseResourceArmPaginatedResult IPersistableModel<DataVersionBaseResourceArmPaginatedResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataVersionBaseResourceArmPaginatedResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataVersionBaseResourceArmPaginatedResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataVersionBaseResourceArmPaginatedResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataVersionBaseResourceArmPaginatedResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
