// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class ContentKeyPolicyPlayReadyConfiguration : IUtf8JsonSerializable, IJsonModel<ContentKeyPolicyPlayReadyConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContentKeyPolicyPlayReadyConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContentKeyPolicyPlayReadyConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicyPlayReadyConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContentKeyPolicyPlayReadyConfiguration)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("licenses"u8);
            writer.WriteStartArray();
            foreach (var item in Licenses)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(ResponseCustomData))
            {
                writer.WritePropertyName("responseCustomData"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ResponseCustomData);
#else
                using (JsonDocument document = JsonDocument.Parse(ResponseCustomData))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
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

        ContentKeyPolicyPlayReadyConfiguration IJsonModel<ContentKeyPolicyPlayReadyConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicyPlayReadyConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContentKeyPolicyPlayReadyConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContentKeyPolicyPlayReadyConfiguration(document.RootElement, options);
        }

        internal static ContentKeyPolicyPlayReadyConfiguration DeserializeContentKeyPolicyPlayReadyConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ContentKeyPolicyPlayReadyLicense> licenses = default;
            BinaryData responseCustomData = default;
            string odataType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("licenses"u8))
                {
                    List<ContentKeyPolicyPlayReadyLicense> array = new List<ContentKeyPolicyPlayReadyLicense>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContentKeyPolicyPlayReadyLicense.DeserializeContentKeyPolicyPlayReadyLicense(item, options));
                    }
                    licenses = array;
                    continue;
                }
                if (property.NameEquals("responseCustomData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    responseCustomData = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContentKeyPolicyPlayReadyConfiguration(odataType, serializedAdditionalRawData, licenses, responseCustomData);
        }

        BinaryData IPersistableModel<ContentKeyPolicyPlayReadyConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicyPlayReadyConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContentKeyPolicyPlayReadyConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        ContentKeyPolicyPlayReadyConfiguration IPersistableModel<ContentKeyPolicyPlayReadyConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicyPlayReadyConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContentKeyPolicyPlayReadyConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContentKeyPolicyPlayReadyConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContentKeyPolicyPlayReadyConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
