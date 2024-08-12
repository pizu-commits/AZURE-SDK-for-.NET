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
    public partial class MachineLearningDataPathAssetReference : IUtf8JsonSerializable, IJsonModel<MachineLearningDataPathAssetReference>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningDataPathAssetReference>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineLearningDataPathAssetReference>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningDataPathAssetReference>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningDataPathAssetReference)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DatastoreId))
            {
                if (DatastoreId != null)
                {
                    writer.WritePropertyName("datastoreId"u8);
                    writer.WriteStringValue(DatastoreId);
                }
                else
                {
                    writer.WriteNull("datastoreId");
                }
            }
            if (Optional.IsDefined(Path))
            {
                if (Path != null)
                {
                    writer.WritePropertyName("path"u8);
                    writer.WriteStringValue(Path);
                }
                else
                {
                    writer.WriteNull("path");
                }
            }
            writer.WritePropertyName("referenceType"u8);
            writer.WriteStringValue(ReferenceType.ToString());
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

        MachineLearningDataPathAssetReference IJsonModel<MachineLearningDataPathAssetReference>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningDataPathAssetReference>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningDataPathAssetReference)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningDataPathAssetReference(document.RootElement, options);
        }

        internal static MachineLearningDataPathAssetReference DeserializeMachineLearningDataPathAssetReference(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string datastoreId = default;
            string path = default;
            ReferenceType referenceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("datastoreId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        datastoreId = null;
                        continue;
                    }
                    datastoreId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("path"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        path = null;
                        continue;
                    }
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("referenceType"u8))
                {
                    referenceType = new ReferenceType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MachineLearningDataPathAssetReference(referenceType, serializedAdditionalRawData, datastoreId, path);
        }

        BinaryData IPersistableModel<MachineLearningDataPathAssetReference>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningDataPathAssetReference>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningDataPathAssetReference)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningDataPathAssetReference IPersistableModel<MachineLearningDataPathAssetReference>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningDataPathAssetReference>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningDataPathAssetReference(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningDataPathAssetReference)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningDataPathAssetReference>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
