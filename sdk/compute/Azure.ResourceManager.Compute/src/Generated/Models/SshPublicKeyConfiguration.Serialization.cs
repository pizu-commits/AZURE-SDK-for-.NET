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

namespace Azure.ResourceManager.Compute.Models
{
    public partial class SshPublicKeyConfiguration : IUtf8JsonSerializable, IJsonModel<SshPublicKeyConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SshPublicKeyConfiguration>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<SshPublicKeyConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
            }
            if (Optional.IsDefined(KeyData))
            {
                writer.WritePropertyName("keyData"u8);
                writer.WriteStringValue(KeyData);
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

        SshPublicKeyConfiguration IJsonModel<SshPublicKeyConfiguration>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SshPublicKeyConfiguration)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSshPublicKeyConfiguration(document.RootElement, options);
        }

        internal static SshPublicKeyConfiguration DeserializeSshPublicKeyConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> path = default;
            Optional<string> keyData = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("path"u8))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyData"u8))
                {
                    keyData = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SshPublicKeyConfiguration(path.Value, keyData.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<SshPublicKeyConfiguration>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SshPublicKeyConfiguration)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SshPublicKeyConfiguration IModel<SshPublicKeyConfiguration>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SshPublicKeyConfiguration)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSshPublicKeyConfiguration(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<SshPublicKeyConfiguration>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
