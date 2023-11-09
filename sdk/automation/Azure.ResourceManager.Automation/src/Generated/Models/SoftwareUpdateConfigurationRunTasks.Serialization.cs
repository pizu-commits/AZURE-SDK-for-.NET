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

namespace Azure.ResourceManager.Automation.Models
{
    public partial class SoftwareUpdateConfigurationRunTasks : IUtf8JsonSerializable, IJsonModel<SoftwareUpdateConfigurationRunTasks>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SoftwareUpdateConfigurationRunTasks>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<SoftwareUpdateConfigurationRunTasks>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PreTask))
            {
                writer.WritePropertyName("preTask"u8);
                writer.WriteObjectValue(PreTask);
            }
            if (Optional.IsDefined(PostTask))
            {
                writer.WritePropertyName("postTask"u8);
                writer.WriteObjectValue(PostTask);
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

        SoftwareUpdateConfigurationRunTasks IJsonModel<SoftwareUpdateConfigurationRunTasks>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SoftwareUpdateConfigurationRunTasks)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSoftwareUpdateConfigurationRunTasks(document.RootElement, options);
        }

        internal static SoftwareUpdateConfigurationRunTasks DeserializeSoftwareUpdateConfigurationRunTasks(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SoftwareUpdateConfigurationRunTaskProperties> preTask = default;
            Optional<SoftwareUpdateConfigurationRunTaskProperties> postTask = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("preTask"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preTask = SoftwareUpdateConfigurationRunTaskProperties.DeserializeSoftwareUpdateConfigurationRunTaskProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("postTask"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    postTask = SoftwareUpdateConfigurationRunTaskProperties.DeserializeSoftwareUpdateConfigurationRunTaskProperties(property.Value);
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SoftwareUpdateConfigurationRunTasks(preTask.Value, postTask.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<SoftwareUpdateConfigurationRunTasks>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SoftwareUpdateConfigurationRunTasks)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SoftwareUpdateConfigurationRunTasks IModel<SoftwareUpdateConfigurationRunTasks>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SoftwareUpdateConfigurationRunTasks)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSoftwareUpdateConfigurationRunTasks(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<SoftwareUpdateConfigurationRunTasks>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
