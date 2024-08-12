// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sphere.Models
{
    public partial class ProofOfPossessionNonceContent : IUtf8JsonSerializable, IJsonModel<ProofOfPossessionNonceContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ProofOfPossessionNonceContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ProofOfPossessionNonceContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProofOfPossessionNonceContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProofOfPossessionNonceContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("proofOfPossessionNonce"u8);
            writer.WriteStringValue(ProofOfPossessionNonce);
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

        ProofOfPossessionNonceContent IJsonModel<ProofOfPossessionNonceContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProofOfPossessionNonceContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProofOfPossessionNonceContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeProofOfPossessionNonceContent(document.RootElement, options);
        }

        internal static ProofOfPossessionNonceContent DeserializeProofOfPossessionNonceContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string proofOfPossessionNonce = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("proofOfPossessionNonce"u8))
                {
                    proofOfPossessionNonce = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ProofOfPossessionNonceContent(proofOfPossessionNonce, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ProofOfPossessionNonceContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProofOfPossessionNonceContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ProofOfPossessionNonceContent)} does not support writing '{options.Format}' format.");
            }
        }

        ProofOfPossessionNonceContent IPersistableModel<ProofOfPossessionNonceContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProofOfPossessionNonceContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeProofOfPossessionNonceContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ProofOfPossessionNonceContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ProofOfPossessionNonceContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
