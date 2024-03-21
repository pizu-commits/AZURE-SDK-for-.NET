// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    internal partial class ManagedClusterPodIdentityProvisioningError : IUtf8JsonSerializable, IJsonModel<ManagedClusterPodIdentityProvisioningError>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedClusterPodIdentityProvisioningError>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedClusterPodIdentityProvisioningError>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterPodIdentityProvisioningError>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterPodIdentityProvisioningError)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ErrorDetail))
            {
                writer.WritePropertyName("error"u8);
                JsonSerializer.Serialize(writer, ErrorDetail);
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

        ManagedClusterPodIdentityProvisioningError IJsonModel<ManagedClusterPodIdentityProvisioningError>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterPodIdentityProvisioningError>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterPodIdentityProvisioningError)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedClusterPodIdentityProvisioningError(document.RootElement, options);
        }

        internal static ManagedClusterPodIdentityProvisioningError DeserializeManagedClusterPodIdentityProvisioningError(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResponseError error = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = JsonSerializer.Deserialize<ResponseError>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagedClusterPodIdentityProvisioningError(error, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedClusterPodIdentityProvisioningError>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterPodIdentityProvisioningError>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterPodIdentityProvisioningError)} does not support '{options.Format}' format.");
            }
        }

        ManagedClusterPodIdentityProvisioningError IPersistableModel<ManagedClusterPodIdentityProvisioningError>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterPodIdentityProvisioningError>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedClusterPodIdentityProvisioningError(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterPodIdentityProvisioningError)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedClusterPodIdentityProvisioningError>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
