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
    internal partial class UnknownPackageInputPathBase : IUtf8JsonSerializable, IJsonModel<PackageInputPathBase>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PackageInputPathBase>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PackageInputPathBase>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PackageInputPathBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PackageInputPathBase)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("inputPathType"u8);
            writer.WriteStringValue(InputPathType.ToString());
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

        PackageInputPathBase IJsonModel<PackageInputPathBase>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PackageInputPathBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PackageInputPathBase)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePackageInputPathBase(document.RootElement, options);
        }

        internal static UnknownPackageInputPathBase DeserializeUnknownPackageInputPathBase(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InputPathType inputPathType = "Unknown";
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("inputPathType"u8))
                {
                    inputPathType = new InputPathType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UnknownPackageInputPathBase(inputPathType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PackageInputPathBase>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PackageInputPathBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PackageInputPathBase)} does not support writing '{options.Format}' format.");
            }
        }

        PackageInputPathBase IPersistableModel<PackageInputPathBase>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PackageInputPathBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePackageInputPathBase(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PackageInputPathBase)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PackageInputPathBase>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
