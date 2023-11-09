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

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class ComponentsKpo1PjSchemasWafrankingsresponsePropertiesDataItemsPropertiesMetricsItems : IUtf8JsonSerializable, IJsonModel<ComponentsKpo1PjSchemasWafrankingsresponsePropertiesDataItemsPropertiesMetricsItems>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ComponentsKpo1PjSchemasWafrankingsresponsePropertiesDataItemsPropertiesMetricsItems>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<ComponentsKpo1PjSchemasWafrankingsresponsePropertiesDataItemsPropertiesMetricsItems>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Metric))
            {
                writer.WritePropertyName("metric"u8);
                writer.WriteStringValue(Metric);
            }
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteNumberValue(Value.Value);
            }
            if (Optional.IsDefined(Percentage))
            {
                writer.WritePropertyName("percentage"u8);
                writer.WriteNumberValue(Percentage.Value);
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

        ComponentsKpo1PjSchemasWafrankingsresponsePropertiesDataItemsPropertiesMetricsItems IJsonModel<ComponentsKpo1PjSchemasWafrankingsresponsePropertiesDataItemsPropertiesMetricsItems>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ComponentsKpo1PjSchemasWafrankingsresponsePropertiesDataItemsPropertiesMetricsItems)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeComponentsKpo1PjSchemasWafrankingsresponsePropertiesDataItemsPropertiesMetricsItems(document.RootElement, options);
        }

        internal static ComponentsKpo1PjSchemasWafrankingsresponsePropertiesDataItemsPropertiesMetricsItems DeserializeComponentsKpo1PjSchemasWafrankingsresponsePropertiesDataItemsPropertiesMetricsItems(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> metric = default;
            Optional<long> value = default;
            Optional<double> percentage = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metric"u8))
                {
                    metric = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    value = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("percentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    percentage = property.Value.GetDouble();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ComponentsKpo1PjSchemasWafrankingsresponsePropertiesDataItemsPropertiesMetricsItems(metric.Value, Optional.ToNullable(value), Optional.ToNullable(percentage), serializedAdditionalRawData);
        }

        BinaryData IModel<ComponentsKpo1PjSchemasWafrankingsresponsePropertiesDataItemsPropertiesMetricsItems>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ComponentsKpo1PjSchemasWafrankingsresponsePropertiesDataItemsPropertiesMetricsItems)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ComponentsKpo1PjSchemasWafrankingsresponsePropertiesDataItemsPropertiesMetricsItems IModel<ComponentsKpo1PjSchemasWafrankingsresponsePropertiesDataItemsPropertiesMetricsItems>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ComponentsKpo1PjSchemasWafrankingsresponsePropertiesDataItemsPropertiesMetricsItems)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeComponentsKpo1PjSchemasWafrankingsresponsePropertiesDataItemsPropertiesMetricsItems(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<ComponentsKpo1PjSchemasWafrankingsresponsePropertiesDataItemsPropertiesMetricsItems>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
