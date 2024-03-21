// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class GenerateCertResult : IUtf8JsonSerializable, IJsonModel<GenerateCertResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GenerateCertResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GenerateCertResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GenerateCertResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GenerateCertResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PublicKey))
            {
                writer.WritePropertyName("publicKey"u8);
                writer.WriteStringValue(PublicKey);
            }
            if (Optional.IsDefined(PrivateKey))
            {
                writer.WritePropertyName("privateKey"u8);
                writer.WriteStringValue(PrivateKey);
            }
            if (Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expiryTimeInUTC"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
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

        GenerateCertResult IJsonModel<GenerateCertResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GenerateCertResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GenerateCertResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGenerateCertResult(document.RootElement, options);
        }

        internal static GenerateCertResult DeserializeGenerateCertResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string publicKey = default;
            string privateKey = default;
            DateTimeOffset? expiryTimeInUtc = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publicKey"u8))
                {
                    publicKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateKey"u8))
                {
                    privateKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expiryTimeInUTC"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiryTimeInUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GenerateCertResult(publicKey, privateKey, expiryTimeInUtc, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GenerateCertResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GenerateCertResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GenerateCertResult)} does not support '{options.Format}' format.");
            }
        }

        GenerateCertResult IPersistableModel<GenerateCertResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GenerateCertResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGenerateCertResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GenerateCertResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GenerateCertResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
