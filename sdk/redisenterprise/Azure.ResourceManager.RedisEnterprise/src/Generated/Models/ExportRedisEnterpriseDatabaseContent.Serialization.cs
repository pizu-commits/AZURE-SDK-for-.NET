// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RedisEnterprise.Models
{
    public partial class ExportRedisEnterpriseDatabaseContent : IUtf8JsonSerializable, IJsonModel<ExportRedisEnterpriseDatabaseContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExportRedisEnterpriseDatabaseContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ExportRedisEnterpriseDatabaseContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExportRedisEnterpriseDatabaseContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExportRedisEnterpriseDatabaseContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("sasUri"u8);
            writer.WriteStringValue(SasUri.AbsoluteUri);
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

        ExportRedisEnterpriseDatabaseContent IJsonModel<ExportRedisEnterpriseDatabaseContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExportRedisEnterpriseDatabaseContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExportRedisEnterpriseDatabaseContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExportRedisEnterpriseDatabaseContent(document.RootElement, options);
        }

        internal static ExportRedisEnterpriseDatabaseContent DeserializeExportRedisEnterpriseDatabaseContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri sasUri = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sasUri"u8))
                {
                    sasUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ExportRedisEnterpriseDatabaseContent(sasUri, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ExportRedisEnterpriseDatabaseContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExportRedisEnterpriseDatabaseContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExportRedisEnterpriseDatabaseContent)} does not support writing '{options.Format}' format.");
            }
        }

        ExportRedisEnterpriseDatabaseContent IPersistableModel<ExportRedisEnterpriseDatabaseContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExportRedisEnterpriseDatabaseContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExportRedisEnterpriseDatabaseContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExportRedisEnterpriseDatabaseContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExportRedisEnterpriseDatabaseContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
