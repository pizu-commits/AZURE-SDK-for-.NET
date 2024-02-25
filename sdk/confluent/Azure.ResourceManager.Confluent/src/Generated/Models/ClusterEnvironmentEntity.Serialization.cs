// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Confluent.Models
{
    public partial class ClusterEnvironmentEntity : IUtf8JsonSerializable, IJsonModel<ClusterEnvironmentEntity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClusterEnvironmentEntity>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ClusterEnvironmentEntity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterEnvironmentEntity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterEnvironmentEntity)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Environment != null)
            {
                writer.WritePropertyName("environment"u8);
                writer.WriteStringValue(Environment);
            }
            if (Related != null)
            {
                writer.WritePropertyName("related"u8);
                writer.WriteStringValue(Related);
            }
            if (ResourceName != null)
            {
                writer.WritePropertyName("resource_name"u8);
                writer.WriteStringValue(ResourceName);
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

        ClusterEnvironmentEntity IJsonModel<ClusterEnvironmentEntity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterEnvironmentEntity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterEnvironmentEntity)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClusterEnvironmentEntity(document.RootElement, options);
        }

        internal static ClusterEnvironmentEntity DeserializeClusterEnvironmentEntity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<string> environment = default;
            Optional<string> related = default;
            Optional<string> resourceName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("environment"u8))
                {
                    environment = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("related"u8))
                {
                    related = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resource_name"u8))
                {
                    resourceName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ClusterEnvironmentEntity(id.Value, environment.Value, related.Value, resourceName.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ClusterEnvironmentEntity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterEnvironmentEntity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ClusterEnvironmentEntity)} does not support '{options.Format}' format.");
            }
        }

        ClusterEnvironmentEntity IPersistableModel<ClusterEnvironmentEntity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterEnvironmentEntity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeClusterEnvironmentEntity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ClusterEnvironmentEntity)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ClusterEnvironmentEntity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
