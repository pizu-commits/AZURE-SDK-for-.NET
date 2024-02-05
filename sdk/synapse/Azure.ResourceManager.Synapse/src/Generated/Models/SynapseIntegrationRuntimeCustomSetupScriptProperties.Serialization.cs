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

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseIntegrationRuntimeCustomSetupScriptProperties : IUtf8JsonSerializable, IJsonModel<SynapseIntegrationRuntimeCustomSetupScriptProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseIntegrationRuntimeCustomSetupScriptProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SynapseIntegrationRuntimeCustomSetupScriptProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIntegrationRuntimeCustomSetupScriptProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeCustomSetupScriptProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(BlobContainerUri))
            {
                writer.WritePropertyName("blobContainerUri"u8);
                writer.WriteStringValue(BlobContainerUri.AbsoluteUri);
            }
            if (Optional.IsDefined(SasToken))
            {
                writer.WritePropertyName("sasToken"u8);
                writer.WriteObjectValue(SasToken);
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

        SynapseIntegrationRuntimeCustomSetupScriptProperties IJsonModel<SynapseIntegrationRuntimeCustomSetupScriptProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIntegrationRuntimeCustomSetupScriptProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeCustomSetupScriptProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseIntegrationRuntimeCustomSetupScriptProperties(document.RootElement, options);
        }

        internal static SynapseIntegrationRuntimeCustomSetupScriptProperties DeserializeSynapseIntegrationRuntimeCustomSetupScriptProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Uri> blobContainerUri = default;
            Optional<SynapseSecureString> sasToken = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("blobContainerUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    blobContainerUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sasToken"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sasToken = SynapseSecureString.DeserializeSynapseSecureString(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SynapseIntegrationRuntimeCustomSetupScriptProperties(blobContainerUri.Value, sasToken.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(BlobContainerUri))
            {
                builder.Append("  blobContainerUri:");
                builder.AppendLine($" '{BlobContainerUri.AbsoluteUri}'");
            }

            if (Optional.IsDefined(SasToken))
            {
                builder.Append("  sasToken:");
                AppendChildObject(builder, SasToken, options, 2, false);
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

        BinaryData IPersistableModel<SynapseIntegrationRuntimeCustomSetupScriptProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIntegrationRuntimeCustomSetupScriptProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeCustomSetupScriptProperties)} does not support '{options.Format}' format.");
            }
        }

        SynapseIntegrationRuntimeCustomSetupScriptProperties IPersistableModel<SynapseIntegrationRuntimeCustomSetupScriptProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIntegrationRuntimeCustomSetupScriptProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseIntegrationRuntimeCustomSetupScriptProperties(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeCustomSetupScriptProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseIntegrationRuntimeCustomSetupScriptProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
