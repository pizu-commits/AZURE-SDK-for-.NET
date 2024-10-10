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
    public partial class ForceUnlinkRedisEnterpriseDatabaseContent : IUtf8JsonSerializable, IJsonModel<ForceUnlinkRedisEnterpriseDatabaseContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ForceUnlinkRedisEnterpriseDatabaseContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ForceUnlinkRedisEnterpriseDatabaseContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ForceUnlinkRedisEnterpriseDatabaseContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ForceUnlinkRedisEnterpriseDatabaseContent)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("ids"u8);
            writer.WriteStartArray();
            foreach (var item in Ids)
            {
                if (item == null)
                {
                    writer.WriteNullValue();
                    continue;
                }
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
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
        }

        ForceUnlinkRedisEnterpriseDatabaseContent IJsonModel<ForceUnlinkRedisEnterpriseDatabaseContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ForceUnlinkRedisEnterpriseDatabaseContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ForceUnlinkRedisEnterpriseDatabaseContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeForceUnlinkRedisEnterpriseDatabaseContent(document.RootElement, options);
        }

        internal static ForceUnlinkRedisEnterpriseDatabaseContent DeserializeForceUnlinkRedisEnterpriseDatabaseContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ResourceIdentifier> ids = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ids"u8))
                {
                    List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(new ResourceIdentifier(item.GetString()));
                        }
                    }
                    ids = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ForceUnlinkRedisEnterpriseDatabaseContent(ids, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ForceUnlinkRedisEnterpriseDatabaseContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ForceUnlinkRedisEnterpriseDatabaseContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ForceUnlinkRedisEnterpriseDatabaseContent)} does not support writing '{options.Format}' format.");
            }
        }

        ForceUnlinkRedisEnterpriseDatabaseContent IPersistableModel<ForceUnlinkRedisEnterpriseDatabaseContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ForceUnlinkRedisEnterpriseDatabaseContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeForceUnlinkRedisEnterpriseDatabaseContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ForceUnlinkRedisEnterpriseDatabaseContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ForceUnlinkRedisEnterpriseDatabaseContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
