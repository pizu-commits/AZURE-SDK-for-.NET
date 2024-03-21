// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    public partial class MsixPackageDependencies : IUtf8JsonSerializable, IJsonModel<MsixPackageDependencies>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MsixPackageDependencies>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MsixPackageDependencies>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MsixPackageDependencies>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MsixPackageDependencies)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DependencyName))
            {
                writer.WritePropertyName("dependencyName"u8);
                writer.WriteStringValue(DependencyName);
            }
            if (Optional.IsDefined(Publisher))
            {
                writer.WritePropertyName("publisher"u8);
                writer.WriteStringValue(Publisher);
            }
            if (Optional.IsDefined(MinVersion))
            {
                writer.WritePropertyName("minVersion"u8);
                writer.WriteStringValue(MinVersion);
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

        MsixPackageDependencies IJsonModel<MsixPackageDependencies>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MsixPackageDependencies>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MsixPackageDependencies)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMsixPackageDependencies(document.RootElement, options);
        }

        internal static MsixPackageDependencies DeserializeMsixPackageDependencies(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string dependencyName = default;
            string publisher = default;
            string minVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dependencyName"u8))
                {
                    dependencyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publisher"u8))
                {
                    publisher = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("minVersion"u8))
                {
                    minVersion = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MsixPackageDependencies(dependencyName, publisher, minVersion, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MsixPackageDependencies>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MsixPackageDependencies>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MsixPackageDependencies)} does not support '{options.Format}' format.");
            }
        }

        MsixPackageDependencies IPersistableModel<MsixPackageDependencies>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MsixPackageDependencies>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMsixPackageDependencies(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MsixPackageDependencies)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MsixPackageDependencies>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
