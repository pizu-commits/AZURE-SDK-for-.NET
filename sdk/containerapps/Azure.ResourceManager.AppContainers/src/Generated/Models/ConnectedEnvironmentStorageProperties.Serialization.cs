// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    internal partial class ConnectedEnvironmentStorageProperties : IUtf8JsonSerializable, IJsonModel<ConnectedEnvironmentStorageProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConnectedEnvironmentStorageProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ConnectedEnvironmentStorageProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectedEnvironmentStorageProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectedEnvironmentStorageProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AzureFile))
            {
                writer.WritePropertyName("azureFile"u8);
                writer.WriteObjectValue(AzureFile);
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

        ConnectedEnvironmentStorageProperties IJsonModel<ConnectedEnvironmentStorageProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectedEnvironmentStorageProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectedEnvironmentStorageProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectedEnvironmentStorageProperties(document.RootElement, options);
        }

        internal static ConnectedEnvironmentStorageProperties DeserializeConnectedEnvironmentStorageProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ContainerAppAzureFileProperties> azureFile = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("azureFile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureFile = ContainerAppAzureFileProperties.DeserializeContainerAppAzureFileProperties(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ConnectedEnvironmentStorageProperties(azureFile.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConnectedEnvironmentStorageProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectedEnvironmentStorageProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConnectedEnvironmentStorageProperties)} does not support '{options.Format}' format.");
            }
        }

        ConnectedEnvironmentStorageProperties IPersistableModel<ConnectedEnvironmentStorageProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectedEnvironmentStorageProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConnectedEnvironmentStorageProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConnectedEnvironmentStorageProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConnectedEnvironmentStorageProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
