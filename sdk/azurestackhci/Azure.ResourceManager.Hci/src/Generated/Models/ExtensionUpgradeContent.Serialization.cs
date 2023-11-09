// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Hci.Models
{
    public partial class ExtensionUpgradeContent : IUtf8JsonSerializable, IJsonModel<ExtensionUpgradeContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExtensionUpgradeContent>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<ExtensionUpgradeContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TargetVersion))
            {
                writer.WritePropertyName("targetVersion"u8);
                writer.WriteStringValue(TargetVersion);
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        ExtensionUpgradeContent IJsonModel<ExtensionUpgradeContent>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ExtensionUpgradeContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExtensionUpgradeContent(document.RootElement, options);
        }

        internal static ExtensionUpgradeContent DeserializeExtensionUpgradeContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> targetVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targetVersion"u8))
                {
                    targetVersion = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ExtensionUpgradeContent(targetVersion.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<ExtensionUpgradeContent>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ExtensionUpgradeContent)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ExtensionUpgradeContent IModel<ExtensionUpgradeContent>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ExtensionUpgradeContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeExtensionUpgradeContent(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<ExtensionUpgradeContent>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
