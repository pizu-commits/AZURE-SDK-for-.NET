// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class AzureFunctionEventSubscriptionDestination : IUtf8JsonSerializable, IJsonModel<AzureFunctionEventSubscriptionDestination>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureFunctionEventSubscriptionDestination>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AzureFunctionEventSubscriptionDestination>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureFunctionEventSubscriptionDestination>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureFunctionEventSubscriptionDestination)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("endpointType"u8);
            writer.WriteStringValue(EndpointType.ToString());
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (Optional.IsDefined(MaxEventsPerBatch))
            {
                writer.WritePropertyName("maxEventsPerBatch"u8);
                writer.WriteNumberValue(MaxEventsPerBatch.Value);
            }
            if (Optional.IsDefined(PreferredBatchSizeInKilobytes))
            {
                writer.WritePropertyName("preferredBatchSizeInKilobytes"u8);
                writer.WriteNumberValue(PreferredBatchSizeInKilobytes.Value);
            }
            if (Optional.IsCollectionDefined(DeliveryAttributeMappings))
            {
                writer.WritePropertyName("deliveryAttributeMappings"u8);
                writer.WriteStartArray();
                foreach (var item in DeliveryAttributeMappings)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
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

        AzureFunctionEventSubscriptionDestination IJsonModel<AzureFunctionEventSubscriptionDestination>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureFunctionEventSubscriptionDestination>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureFunctionEventSubscriptionDestination)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureFunctionEventSubscriptionDestination(document.RootElement, options);
        }

        internal static AzureFunctionEventSubscriptionDestination DeserializeAzureFunctionEventSubscriptionDestination(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            EndpointType endpointType = default;
            ResourceIdentifier resourceId = default;
            int? maxEventsPerBatch = default;
            int? preferredBatchSizeInKilobytes = default;
            IList<DeliveryAttributeMapping> deliveryAttributeMappings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endpointType"u8))
                {
                    endpointType = new EndpointType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("resourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("maxEventsPerBatch"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxEventsPerBatch = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("preferredBatchSizeInKilobytes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            preferredBatchSizeInKilobytes = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("deliveryAttributeMappings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DeliveryAttributeMapping> array = new List<DeliveryAttributeMapping>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DeliveryAttributeMapping.DeserializeDeliveryAttributeMapping(item, options));
                            }
                            deliveryAttributeMappings = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AzureFunctionEventSubscriptionDestination(
                endpointType,
                serializedAdditionalRawData,
                resourceId,
                maxEventsPerBatch,
                preferredBatchSizeInKilobytes,
                deliveryAttributeMappings ?? new ChangeTrackingList<DeliveryAttributeMapping>());
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EndpointType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  endpointType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  endpointType: ");
                builder.AppendLine($"'{EndpointType.ToString()}'");
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ResourceId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    resourceId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ResourceId))
                {
                    builder.Append("    resourceId: ");
                    builder.AppendLine($"'{ResourceId.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MaxEventsPerBatch), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    maxEventsPerBatch: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MaxEventsPerBatch))
                {
                    builder.Append("    maxEventsPerBatch: ");
                    builder.AppendLine($"{MaxEventsPerBatch.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PreferredBatchSizeInKilobytes), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    preferredBatchSizeInKilobytes: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PreferredBatchSizeInKilobytes))
                {
                    builder.Append("    preferredBatchSizeInKilobytes: ");
                    builder.AppendLine($"{PreferredBatchSizeInKilobytes.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DeliveryAttributeMappings), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    deliveryAttributeMappings: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(DeliveryAttributeMappings))
                {
                    if (DeliveryAttributeMappings.Any())
                    {
                        builder.Append("    deliveryAttributeMappings: ");
                        builder.AppendLine("[");
                        foreach (var item in DeliveryAttributeMappings)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 6, true, "    deliveryAttributeMappings: ");
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<AzureFunctionEventSubscriptionDestination>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureFunctionEventSubscriptionDestination>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(AzureFunctionEventSubscriptionDestination)} does not support writing '{options.Format}' format.");
            }
        }

        AzureFunctionEventSubscriptionDestination IPersistableModel<AzureFunctionEventSubscriptionDestination>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureFunctionEventSubscriptionDestination>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureFunctionEventSubscriptionDestination(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureFunctionEventSubscriptionDestination)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureFunctionEventSubscriptionDestination>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
