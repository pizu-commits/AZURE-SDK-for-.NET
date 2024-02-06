// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class FactoryRepoContent : IUtf8JsonSerializable, IJsonModel<FactoryRepoContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FactoryRepoContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FactoryRepoContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FactoryRepoContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FactoryRepoContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(FactoryResourceId))
            {
                writer.WritePropertyName("factoryResourceId"u8);
                writer.WriteStringValue(FactoryResourceId);
            }
            if (Optional.IsDefined(RepoConfiguration))
            {
                writer.WritePropertyName("repoConfiguration"u8);
                writer.WriteObjectValue(RepoConfiguration);
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

        FactoryRepoContent IJsonModel<FactoryRepoContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FactoryRepoContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FactoryRepoContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFactoryRepoContent(document.RootElement, options);
        }

        internal static FactoryRepoContent DeserializeFactoryRepoContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> factoryResourceId = default;
            Optional<FactoryRepoConfiguration> repoConfiguration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("factoryResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    factoryResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("repoConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    repoConfiguration = FactoryRepoConfiguration.DeserializeFactoryRepoConfiguration(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FactoryRepoContent(factoryResourceId.Value, repoConfiguration.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FactoryRepoContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FactoryRepoContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FactoryRepoContent)} does not support '{options.Format}' format.");
            }
        }

        FactoryRepoContent IPersistableModel<FactoryRepoContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FactoryRepoContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFactoryRepoContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FactoryRepoContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FactoryRepoContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
