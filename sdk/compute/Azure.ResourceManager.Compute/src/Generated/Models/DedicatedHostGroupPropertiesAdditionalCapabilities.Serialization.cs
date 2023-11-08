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
    internal partial class DedicatedHostGroupPropertiesAdditionalCapabilities : IUtf8JsonSerializable, IJsonModel<DedicatedHostGroupPropertiesAdditionalCapabilities>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DedicatedHostGroupPropertiesAdditionalCapabilities>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<DedicatedHostGroupPropertiesAdditionalCapabilities>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(UltraSsdEnabled))
            {
                writer.WritePropertyName("ultraSSDEnabled"u8);
                writer.WriteBooleanValue(UltraSsdEnabled.Value);
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

        DedicatedHostGroupPropertiesAdditionalCapabilities IJsonModel<DedicatedHostGroupPropertiesAdditionalCapabilities>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DedicatedHostGroupPropertiesAdditionalCapabilities)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDedicatedHostGroupPropertiesAdditionalCapabilities(document.RootElement, options);
        }

        internal static DedicatedHostGroupPropertiesAdditionalCapabilities DeserializeDedicatedHostGroupPropertiesAdditionalCapabilities(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> ultraSsdEnabled = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ultraSSDEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ultraSsdEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DedicatedHostGroupPropertiesAdditionalCapabilities(Optional.ToNullable(ultraSsdEnabled), serializedAdditionalRawData);
        }

        BinaryData IModel<DedicatedHostGroupPropertiesAdditionalCapabilities>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DedicatedHostGroupPropertiesAdditionalCapabilities)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        DedicatedHostGroupPropertiesAdditionalCapabilities IModel<DedicatedHostGroupPropertiesAdditionalCapabilities>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DedicatedHostGroupPropertiesAdditionalCapabilities)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeDedicatedHostGroupPropertiesAdditionalCapabilities(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<DedicatedHostGroupPropertiesAdditionalCapabilities>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
