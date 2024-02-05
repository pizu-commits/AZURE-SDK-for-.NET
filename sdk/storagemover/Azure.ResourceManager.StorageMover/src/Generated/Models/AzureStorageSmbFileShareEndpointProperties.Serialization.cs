// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageMover.Models
{
    public partial class AzureStorageSmbFileShareEndpointProperties : IUtf8JsonSerializable, IJsonModel<AzureStorageSmbFileShareEndpointProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureStorageSmbFileShareEndpointProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AzureStorageSmbFileShareEndpointProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureStorageSmbFileShareEndpointProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureStorageSmbFileShareEndpointProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("storageAccountResourceId"u8);
            writer.WriteStringValue(StorageAccountResourceId);
            writer.WritePropertyName("fileShareName"u8);
            writer.WriteStringValue(FileShareName);
            writer.WritePropertyName("endpointType"u8);
            writer.WriteStringValue(EndpointType.ToString());
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
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

        AzureStorageSmbFileShareEndpointProperties IJsonModel<AzureStorageSmbFileShareEndpointProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureStorageSmbFileShareEndpointProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureStorageSmbFileShareEndpointProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureStorageSmbFileShareEndpointProperties(document.RootElement, options);
        }

        internal static AzureStorageSmbFileShareEndpointProperties DeserializeAzureStorageSmbFileShareEndpointProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier storageAccountResourceId = default;
            string fileShareName = default;
            EndpointType endpointType = default;
            Optional<string> description = default;
            Optional<StorageMoverProvisioningState> provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageAccountResourceId"u8))
                {
                    storageAccountResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("fileShareName"u8))
                {
                    fileShareName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpointType"u8))
                {
                    endpointType = new EndpointType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new StorageMoverProvisioningState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AzureStorageSmbFileShareEndpointProperties(endpointType, description.Value, Optional.ToNullable(provisioningState), serializedAdditionalRawData, storageAccountResourceId, fileShareName);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(StorageAccountResourceId))
            {
                builder.Append("  storageAccountResourceId:");
                builder.AppendLine($" '{StorageAccountResourceId.ToString()}'");
            }

            if (Optional.IsDefined(FileShareName))
            {
                builder.Append("  fileShareName:");
                builder.AppendLine($" '{FileShareName}'");
            }

            if (Optional.IsDefined(EndpointType))
            {
                builder.Append("  endpointType:");
                builder.AppendLine($" '{EndpointType.ToString()}'");
            }

            if (Optional.IsDefined(Description))
            {
                builder.Append("  description:");
                builder.AppendLine($" '{Description}'");
            }

            if (Optional.IsDefined(ProvisioningState))
            {
                builder.Append("  provisioningState:");
                builder.AppendLine($" '{ProvisioningState.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (i == 0 && !indentFirstLine)
                {
                    stringBuilder.AppendLine($" {line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
        }

        BinaryData IPersistableModel<AzureStorageSmbFileShareEndpointProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureStorageSmbFileShareEndpointProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(AzureStorageSmbFileShareEndpointProperties)} does not support '{options.Format}' format.");
            }
        }

        AzureStorageSmbFileShareEndpointProperties IPersistableModel<AzureStorageSmbFileShareEndpointProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureStorageSmbFileShareEndpointProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureStorageSmbFileShareEndpointProperties(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(AzureStorageSmbFileShareEndpointProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureStorageSmbFileShareEndpointProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
