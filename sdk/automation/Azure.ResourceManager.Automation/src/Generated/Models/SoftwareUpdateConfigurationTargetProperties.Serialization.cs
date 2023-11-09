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
    public partial class SoftwareUpdateConfigurationTargetProperties : IUtf8JsonSerializable, IJsonModel<SoftwareUpdateConfigurationTargetProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SoftwareUpdateConfigurationTargetProperties>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<SoftwareUpdateConfigurationTargetProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AzureQueries))
            {
                writer.WritePropertyName("azureQueries"u8);
                writer.WriteStartArray();
                foreach (var item in AzureQueries)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(NonAzureQueries))
            {
                writer.WritePropertyName("nonAzureQueries"u8);
                writer.WriteStartArray();
                foreach (var item in NonAzureQueries)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        SoftwareUpdateConfigurationTargetProperties IJsonModel<SoftwareUpdateConfigurationTargetProperties>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SoftwareUpdateConfigurationTargetProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSoftwareUpdateConfigurationTargetProperties(document.RootElement, options);
        }

        internal static SoftwareUpdateConfigurationTargetProperties DeserializeSoftwareUpdateConfigurationTargetProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<AzureQueryProperties>> azureQueries = default;
            Optional<IList<NonAzureQueryProperties>> nonAzureQueries = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("azureQueries"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AzureQueryProperties> array = new List<AzureQueryProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AzureQueryProperties.DeserializeAzureQueryProperties(item));
                    }
                    azureQueries = array;
                    continue;
                }
                if (property.NameEquals("nonAzureQueries"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NonAzureQueryProperties> array = new List<NonAzureQueryProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NonAzureQueryProperties.DeserializeNonAzureQueryProperties(item));
                    }
                    nonAzureQueries = array;
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SoftwareUpdateConfigurationTargetProperties(Optional.ToList(azureQueries), Optional.ToList(nonAzureQueries), serializedAdditionalRawData);
        }

        BinaryData IModel<SoftwareUpdateConfigurationTargetProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SoftwareUpdateConfigurationTargetProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SoftwareUpdateConfigurationTargetProperties IModel<SoftwareUpdateConfigurationTargetProperties>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SoftwareUpdateConfigurationTargetProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSoftwareUpdateConfigurationTargetProperties(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<SoftwareUpdateConfigurationTargetProperties>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
