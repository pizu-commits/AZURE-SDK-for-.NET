// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CosmosDBMetricDefinition : IUtf8JsonSerializable, IJsonModel<CosmosDBMetricDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CosmosDBMetricDefinition>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CosmosDBMetricDefinition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBMetricDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBMetricDefinition)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && !(MetricAvailabilities is ChangeTrackingList<CosmosDBMetricAvailability> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("metricAvailabilities"u8);
                writer.WriteStartArray();
                foreach (var item in MetricAvailabilities)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(PrimaryAggregationType))
            {
                writer.WritePropertyName("primaryAggregationType"u8);
                writer.WriteStringValue(PrimaryAggregationType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Unit))
            {
                writer.WritePropertyName("unit"u8);
                writer.WriteStringValue(Unit.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceUri"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (options.Format != "W" && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteObjectValue(Name);
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

        CosmosDBMetricDefinition IJsonModel<CosmosDBMetricDefinition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBMetricDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBMetricDefinition)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCosmosDBMetricDefinition(document.RootElement, options);
        }

        internal static CosmosDBMetricDefinition DeserializeCosmosDBMetricDefinition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<CosmosDBMetricAvailability>> metricAvailabilities = default;
            Optional<CosmosDBMetricPrimaryAggregationType> primaryAggregationType = default;
            Optional<CosmosDBMetricUnitType> unit = default;
            Optional<ResourceIdentifier> resourceUri = default;
            Optional<CosmosDBMetricName> name = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metricAvailabilities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CosmosDBMetricAvailability> array = new List<CosmosDBMetricAvailability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CosmosDBMetricAvailability.DeserializeCosmosDBMetricAvailability(item, options));
                    }
                    metricAvailabilities = array;
                    continue;
                }
                if (property.NameEquals("primaryAggregationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryAggregationType = new CosmosDBMetricPrimaryAggregationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("unit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    unit = new CosmosDBMetricUnitType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceUri = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = CosmosDBMetricName.DeserializeCosmosDBMetricName(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CosmosDBMetricDefinition(Optional.ToList(metricAvailabilities), Optional.ToNullable(primaryAggregationType), Optional.ToNullable(unit), resourceUri.Value, name.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CosmosDBMetricDefinition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBMetricDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CosmosDBMetricDefinition)} does not support '{options.Format}' format.");
            }
        }

        CosmosDBMetricDefinition IPersistableModel<CosmosDBMetricDefinition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBMetricDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCosmosDBMetricDefinition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CosmosDBMetricDefinition)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CosmosDBMetricDefinition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
