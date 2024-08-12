// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ScVmm.Models
{
    public partial class ScVmmStorageQosPolicy : IUtf8JsonSerializable, IJsonModel<ScVmmStorageQosPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ScVmmStorageQosPolicy>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ScVmmStorageQosPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScVmmStorageQosPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScVmmStorageQosPolicy)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(IopsMaximum))
            {
                writer.WritePropertyName("iopsMaximum"u8);
                writer.WriteNumberValue(IopsMaximum.Value);
            }
            if (Optional.IsDefined(IopsMinimum))
            {
                writer.WritePropertyName("iopsMinimum"u8);
                writer.WriteNumberValue(IopsMinimum.Value);
            }
            if (Optional.IsDefined(BandwidthLimit))
            {
                writer.WritePropertyName("bandwidthLimit"u8);
                writer.WriteNumberValue(BandwidthLimit.Value);
            }
            if (Optional.IsDefined(PolicyId))
            {
                writer.WritePropertyName("policyId"u8);
                writer.WriteStringValue(PolicyId);
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

        ScVmmStorageQosPolicy IJsonModel<ScVmmStorageQosPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScVmmStorageQosPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScVmmStorageQosPolicy)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeScVmmStorageQosPolicy(document.RootElement, options);
        }

        internal static ScVmmStorageQosPolicy DeserializeScVmmStorageQosPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string id = default;
            long? iopsMaximum = default;
            long? iopsMinimum = default;
            long? bandwidthLimit = default;
            string policyId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("iopsMaximum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    iopsMaximum = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("iopsMinimum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    iopsMinimum = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("bandwidthLimit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bandwidthLimit = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("policyId"u8))
                {
                    policyId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ScVmmStorageQosPolicy(
                name,
                id,
                iopsMaximum,
                iopsMinimum,
                bandwidthLimit,
                policyId,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ScVmmStorageQosPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScVmmStorageQosPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ScVmmStorageQosPolicy)} does not support writing '{options.Format}' format.");
            }
        }

        ScVmmStorageQosPolicy IPersistableModel<ScVmmStorageQosPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScVmmStorageQosPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeScVmmStorageQosPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ScVmmStorageQosPolicy)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ScVmmStorageQosPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
