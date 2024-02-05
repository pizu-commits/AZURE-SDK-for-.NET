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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class MetricSpecification : IUtf8JsonSerializable, IJsonModel<MetricSpecification>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MetricSpecification>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MetricSpecification>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MetricSpecification>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MetricSpecification)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(DisplayDescription))
            {
                writer.WritePropertyName("displayDescription"u8);
                writer.WriteStringValue(DisplayDescription);
            }
            if (Optional.IsDefined(Unit))
            {
                writer.WritePropertyName("unit"u8);
                writer.WriteStringValue(Unit);
            }
            if (Optional.IsDefined(AggregationType))
            {
                writer.WritePropertyName("aggregationType"u8);
                writer.WriteStringValue(AggregationType);
            }
            if (Optional.IsDefined(IsInstanceLevelAggregationSupported))
            {
                writer.WritePropertyName("supportsInstanceLevelAggregation"u8);
                writer.WriteBooleanValue(IsInstanceLevelAggregationSupported.Value);
            }
            if (Optional.IsDefined(IsRegionalMdmAccountEnabled))
            {
                writer.WritePropertyName("enableRegionalMdmAccount"u8);
                writer.WriteBooleanValue(IsRegionalMdmAccountEnabled.Value);
            }
            if (Optional.IsDefined(SourceMdmAccount))
            {
                writer.WritePropertyName("sourceMdmAccount"u8);
                writer.WriteStringValue(SourceMdmAccount);
            }
            if (Optional.IsDefined(SourceMdmNamespace))
            {
                writer.WritePropertyName("sourceMdmNamespace"u8);
                writer.WriteStringValue(SourceMdmNamespace);
            }
            if (Optional.IsDefined(MetricFilterPattern))
            {
                writer.WritePropertyName("metricFilterPattern"u8);
                writer.WriteStringValue(MetricFilterPattern);
            }
            if (Optional.IsDefined(FillGapWithZero))
            {
                writer.WritePropertyName("fillGapWithZero"u8);
                writer.WriteBooleanValue(FillGapWithZero.Value);
            }
            if (Optional.IsDefined(IsInternal))
            {
                writer.WritePropertyName("isInternal"u8);
                writer.WriteBooleanValue(IsInternal.Value);
            }
            if (Optional.IsCollectionDefined(Dimensions))
            {
                writer.WritePropertyName("dimensions"u8);
                writer.WriteStartArray();
                foreach (var item in Dimensions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Category))
            {
                writer.WritePropertyName("category"u8);
                writer.WriteStringValue(Category);
            }
            if (Optional.IsCollectionDefined(Availabilities))
            {
                writer.WritePropertyName("availabilities"u8);
                writer.WriteStartArray();
                foreach (var item in Availabilities)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SupportedTimeGrainTypes))
            {
                writer.WritePropertyName("supportedTimeGrainTypes"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedTimeGrainTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SupportedAggregationTypes))
            {
                writer.WritePropertyName("supportedAggregationTypes"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedAggregationTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        MetricSpecification IJsonModel<MetricSpecification>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MetricSpecification>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MetricSpecification)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMetricSpecification(document.RootElement, options);
        }

        internal static MetricSpecification DeserializeMetricSpecification(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> displayName = default;
            Optional<string> displayDescription = default;
            Optional<string> unit = default;
            Optional<string> aggregationType = default;
            Optional<bool> supportsInstanceLevelAggregation = default;
            Optional<bool> enableRegionalMdmAccount = default;
            Optional<string> sourceMdmAccount = default;
            Optional<string> sourceMdmNamespace = default;
            Optional<string> metricFilterPattern = default;
            Optional<bool> fillGapWithZero = default;
            Optional<bool> isInternal = default;
            Optional<IReadOnlyList<MetricDimension>> dimensions = default;
            Optional<string> category = default;
            Optional<IReadOnlyList<MetricAvailability>> availabilities = default;
            Optional<IReadOnlyList<string>> supportedTimeGrainTypes = default;
            Optional<IReadOnlyList<string>> supportedAggregationTypes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayDescription"u8))
                {
                    displayDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("unit"u8))
                {
                    unit = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aggregationType"u8))
                {
                    aggregationType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportsInstanceLevelAggregation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    supportsInstanceLevelAggregation = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableRegionalMdmAccount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableRegionalMdmAccount = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("sourceMdmAccount"u8))
                {
                    sourceMdmAccount = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceMdmNamespace"u8))
                {
                    sourceMdmNamespace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metricFilterPattern"u8))
                {
                    metricFilterPattern = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fillGapWithZero"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fillGapWithZero = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isInternal"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isInternal = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("dimensions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MetricDimension> array = new List<MetricDimension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MetricDimension.DeserializeMetricDimension(item));
                    }
                    dimensions = array;
                    continue;
                }
                if (property.NameEquals("category"u8))
                {
                    category = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("availabilities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MetricAvailability> array = new List<MetricAvailability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MetricAvailability.DeserializeMetricAvailability(item));
                    }
                    availabilities = array;
                    continue;
                }
                if (property.NameEquals("supportedTimeGrainTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    supportedTimeGrainTypes = array;
                    continue;
                }
                if (property.NameEquals("supportedAggregationTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    supportedAggregationTypes = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MetricSpecification(name.Value, displayName.Value, displayDescription.Value, unit.Value, aggregationType.Value, Optional.ToNullable(supportsInstanceLevelAggregation), Optional.ToNullable(enableRegionalMdmAccount), sourceMdmAccount.Value, sourceMdmNamespace.Value, metricFilterPattern.Value, Optional.ToNullable(fillGapWithZero), Optional.ToNullable(isInternal), Optional.ToList(dimensions), category.Value, Optional.ToList(availabilities), Optional.ToList(supportedTimeGrainTypes), Optional.ToList(supportedAggregationTypes), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Name))
            {
                builder.Append("  name:");
                builder.AppendLine($" '{Name}'");
            }

            if (Optional.IsDefined(DisplayName))
            {
                builder.Append("  displayName:");
                builder.AppendLine($" '{DisplayName}'");
            }

            if (Optional.IsDefined(DisplayDescription))
            {
                builder.Append("  displayDescription:");
                builder.AppendLine($" '{DisplayDescription}'");
            }

            if (Optional.IsDefined(Unit))
            {
                builder.Append("  unit:");
                builder.AppendLine($" '{Unit}'");
            }

            if (Optional.IsDefined(AggregationType))
            {
                builder.Append("  aggregationType:");
                builder.AppendLine($" '{AggregationType}'");
            }

            if (Optional.IsDefined(IsInstanceLevelAggregationSupported))
            {
                builder.Append("  supportsInstanceLevelAggregation:");
                var boolValue = IsInstanceLevelAggregationSupported.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(IsRegionalMdmAccountEnabled))
            {
                builder.Append("  enableRegionalMdmAccount:");
                var boolValue = IsRegionalMdmAccountEnabled.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(SourceMdmAccount))
            {
                builder.Append("  sourceMdmAccount:");
                builder.AppendLine($" '{SourceMdmAccount}'");
            }

            if (Optional.IsDefined(SourceMdmNamespace))
            {
                builder.Append("  sourceMdmNamespace:");
                builder.AppendLine($" '{SourceMdmNamespace}'");
            }

            if (Optional.IsDefined(MetricFilterPattern))
            {
                builder.Append("  metricFilterPattern:");
                builder.AppendLine($" '{MetricFilterPattern}'");
            }

            if (Optional.IsDefined(FillGapWithZero))
            {
                builder.Append("  fillGapWithZero:");
                var boolValue = FillGapWithZero.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(IsInternal))
            {
                builder.Append("  isInternal:");
                var boolValue = IsInternal.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsCollectionDefined(Dimensions))
            {
                if (Dimensions.Any())
                {
                    builder.Append("  dimensions:");
                    builder.AppendLine(" [");
                    foreach (var item in Dimensions)
                    {
                        AppendChildObject(builder, item, options, 4, true);
                    }
                    builder.AppendLine("  ]");
                }
            }

            if (Optional.IsDefined(Category))
            {
                builder.Append("  category:");
                builder.AppendLine($" '{Category}'");
            }

            if (Optional.IsCollectionDefined(Availabilities))
            {
                if (Availabilities.Any())
                {
                    builder.Append("  availabilities:");
                    builder.AppendLine(" [");
                    foreach (var item in Availabilities)
                    {
                        AppendChildObject(builder, item, options, 4, true);
                    }
                    builder.AppendLine("  ]");
                }
            }

            if (Optional.IsCollectionDefined(SupportedTimeGrainTypes))
            {
                if (SupportedTimeGrainTypes.Any())
                {
                    builder.Append("  supportedTimeGrainTypes:");
                    builder.AppendLine(" [");
                    foreach (var item in SupportedTimeGrainTypes)
                    {
                        if (item == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        builder.AppendLine($"    '{item}'");
                    }
                    builder.AppendLine("  ]");
                }
            }

            if (Optional.IsCollectionDefined(SupportedAggregationTypes))
            {
                if (SupportedAggregationTypes.Any())
                {
                    builder.Append("  supportedAggregationTypes:");
                    builder.AppendLine(" [");
                    foreach (var item in SupportedAggregationTypes)
                    {
                        if (item == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        builder.AppendLine($"    '{item}'");
                    }
                    builder.AppendLine("  ]");
                }
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

        BinaryData IPersistableModel<MetricSpecification>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MetricSpecification>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MetricSpecification)} does not support '{options.Format}' format.");
            }
        }

        MetricSpecification IPersistableModel<MetricSpecification>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MetricSpecification>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMetricSpecification(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(MetricSpecification)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MetricSpecification>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
