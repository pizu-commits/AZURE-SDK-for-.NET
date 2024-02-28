// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    public partial class ServiceAccountThrottlingRule : IUtf8JsonSerializable, IJsonModel<ServiceAccountThrottlingRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServiceAccountThrottlingRule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ServiceAccountThrottlingRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceAccountThrottlingRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceAccountThrottlingRule)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Key != null)
            {
                writer.WritePropertyName("key"u8);
                writer.WriteStringValue(Key);
            }
            if (RenewalPeriod.HasValue)
            {
                writer.WritePropertyName("renewalPeriod"u8);
                writer.WriteNumberValue(RenewalPeriod.Value);
            }
            if (Count.HasValue)
            {
                writer.WritePropertyName("count"u8);
                writer.WriteNumberValue(Count.Value);
            }
            if (MinCount.HasValue)
            {
                writer.WritePropertyName("minCount"u8);
                writer.WriteNumberValue(MinCount.Value);
            }
            if (IsDynamicThrottlingEnabled.HasValue)
            {
                writer.WritePropertyName("dynamicThrottlingEnabled"u8);
                writer.WriteBooleanValue(IsDynamicThrottlingEnabled.Value);
            }
            if (!(MatchPatterns is ChangeTrackingList<ServiceAccountThrottlingMatchPattern> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("matchPatterns"u8);
                writer.WriteStartArray();
                foreach (var item in MatchPatterns)
                {
                    writer.WriteObjectValue(item);
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

        ServiceAccountThrottlingRule IJsonModel<ServiceAccountThrottlingRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceAccountThrottlingRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceAccountThrottlingRule)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceAccountThrottlingRule(document.RootElement, options);
        }

        internal static ServiceAccountThrottlingRule DeserializeServiceAccountThrottlingRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string key = default;
            float? renewalPeriod = default;
            float? count = default;
            float? minCount = default;
            bool? dynamicThrottlingEnabled = default;
            IReadOnlyList<ServiceAccountThrottlingMatchPattern> matchPatterns = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("key"u8))
                {
                    key = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("renewalPeriod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    renewalPeriod = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    count = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("minCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("dynamicThrottlingEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dynamicThrottlingEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("matchPatterns"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ServiceAccountThrottlingMatchPattern> array = new List<ServiceAccountThrottlingMatchPattern>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServiceAccountThrottlingMatchPattern.DeserializeServiceAccountThrottlingMatchPattern(item, options));
                    }
                    matchPatterns = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ServiceAccountThrottlingRule(
                key,
                renewalPeriod,
                count,
                minCount,
                dynamicThrottlingEnabled,
                matchPatterns ?? new ChangeTrackingList<ServiceAccountThrottlingMatchPattern>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ServiceAccountThrottlingRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceAccountThrottlingRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ServiceAccountThrottlingRule)} does not support '{options.Format}' format.");
            }
        }

        ServiceAccountThrottlingRule IPersistableModel<ServiceAccountThrottlingRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceAccountThrottlingRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServiceAccountThrottlingRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServiceAccountThrottlingRule)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServiceAccountThrottlingRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
