// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    internal partial class RemoveProtectionContainerMappingProperties : IUtf8JsonSerializable, IJsonModel<RemoveProtectionContainerMappingProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RemoveProtectionContainerMappingProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RemoveProtectionContainerMappingProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RemoveProtectionContainerMappingProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RemoveProtectionContainerMappingProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ProviderSpecificContent))
            {
                writer.WritePropertyName("providerSpecificInput"u8);
                writer.WriteObjectValue(ProviderSpecificContent);
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

        RemoveProtectionContainerMappingProperties IJsonModel<RemoveProtectionContainerMappingProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RemoveProtectionContainerMappingProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RemoveProtectionContainerMappingProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRemoveProtectionContainerMappingProperties(document.RootElement, options);
        }

        internal static RemoveProtectionContainerMappingProperties DeserializeRemoveProtectionContainerMappingProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ReplicationProviderContainerUnmappingContent providerSpecificContent = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("providerSpecificInput"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    providerSpecificContent = ReplicationProviderContainerUnmappingContent.DeserializeReplicationProviderContainerUnmappingContent(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RemoveProtectionContainerMappingProperties(providerSpecificContent, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RemoveProtectionContainerMappingProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RemoveProtectionContainerMappingProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RemoveProtectionContainerMappingProperties)} does not support '{options.Format}' format.");
            }
        }

        RemoveProtectionContainerMappingProperties IPersistableModel<RemoveProtectionContainerMappingProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RemoveProtectionContainerMappingProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRemoveProtectionContainerMappingProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RemoveProtectionContainerMappingProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RemoveProtectionContainerMappingProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
