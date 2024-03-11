// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.FrontDoor;

namespace Azure.ResourceManager.FrontDoor.Models
{
    public partial class LatencyMetric : IUtf8JsonSerializable, IJsonModel<LatencyMetric>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LatencyMetric>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LatencyMetric>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LatencyMetric>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LatencyMetric)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endDateTimeUTC"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(AValue))
            {
                writer.WritePropertyName("aValue"u8);
                writer.WriteNumberValue(AValue.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(BValue))
            {
                writer.WritePropertyName("bValue"u8);
                writer.WriteNumberValue(BValue.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Delta))
            {
                writer.WritePropertyName("delta"u8);
                writer.WriteNumberValue(Delta.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(DeltaPercent))
            {
                writer.WritePropertyName("deltaPercent"u8);
                writer.WriteNumberValue(DeltaPercent.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ACLower95CI))
            {
                writer.WritePropertyName("aCLower95CI"u8);
                writer.WriteNumberValue(ACLower95CI.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(AHUpper95CI))
            {
                writer.WritePropertyName("aHUpper95CI"u8);
                writer.WriteNumberValue(AHUpper95CI.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(BCLower95CI))
            {
                writer.WritePropertyName("bCLower95CI"u8);
                writer.WriteNumberValue(BCLower95CI.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(BUpper95CI))
            {
                writer.WritePropertyName("bUpper95CI"u8);
                writer.WriteNumberValue(BUpper95CI.Value);
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

        LatencyMetric IJsonModel<LatencyMetric>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LatencyMetric>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LatencyMetric)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLatencyMetric(document.RootElement, options);
        }

        internal static LatencyMetric DeserializeLatencyMetric(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            DateTimeOffset? endDateTimeUtc = default;
            float? aValue = default;
            float? bValue = default;
            float? delta = default;
            float? deltaPercent = default;
            float? acLower95CI = default;
            float? ahUpper95CI = default;
            float? bcLower95CI = default;
            float? bUpper95CI = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endDateTimeUTC"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endDateTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("aValue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    aValue = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("bValue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bValue = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("delta"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    delta = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("deltaPercent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deltaPercent = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("aCLower95CI"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    acLower95CI = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("aHUpper95CI"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ahUpper95CI = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("bCLower95CI"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bcLower95CI = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("bUpper95CI"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bUpper95CI = property.Value.GetSingle();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LatencyMetric(
                name,
                endDateTimeUtc,
                aValue,
                bValue,
                delta,
                deltaPercent,
                acLower95CI,
                ahUpper95CI,
                bcLower95CI,
                bUpper95CI,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LatencyMetric>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LatencyMetric>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LatencyMetric)} does not support '{options.Format}' format.");
            }
        }

        LatencyMetric IPersistableModel<LatencyMetric>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LatencyMetric>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLatencyMetric(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LatencyMetric)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LatencyMetric>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
