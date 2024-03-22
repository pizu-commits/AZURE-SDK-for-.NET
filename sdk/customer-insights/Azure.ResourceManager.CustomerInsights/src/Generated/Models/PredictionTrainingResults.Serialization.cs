// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    public partial class PredictionTrainingResults : IUtf8JsonSerializable, IJsonModel<PredictionTrainingResults>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PredictionTrainingResults>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PredictionTrainingResults>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PredictionTrainingResults>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PredictionTrainingResults)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ScoreName))
            {
                writer.WritePropertyName("scoreName"u8);
                writer.WriteStringValue(ScoreName);
            }
            if (options.Format != "W" && Optional.IsDefined(PredictionDistribution))
            {
                writer.WritePropertyName("predictionDistribution"u8);
                writer.WriteObjectValue(PredictionDistribution);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(CanonicalProfiles))
            {
                writer.WritePropertyName("canonicalProfiles"u8);
                writer.WriteStartArray();
                foreach (var item in CanonicalProfiles)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(PrimaryProfileInstanceCount))
            {
                writer.WritePropertyName("primaryProfileInstanceCount"u8);
                writer.WriteNumberValue(PrimaryProfileInstanceCount.Value);
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

        PredictionTrainingResults IJsonModel<PredictionTrainingResults>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PredictionTrainingResults>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PredictionTrainingResults)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePredictionTrainingResults(document.RootElement, options);
        }

        internal static PredictionTrainingResults DeserializePredictionTrainingResults(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid? tenantId = default;
            string scoreName = default;
            PredictionDistributionDefinition predictionDistribution = default;
            IReadOnlyList<CanonicalProfileDefinition> canonicalProfiles = default;
            long? primaryProfileInstanceCount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("scoreName"u8))
                {
                    scoreName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("predictionDistribution"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    predictionDistribution = PredictionDistributionDefinition.DeserializePredictionDistributionDefinition(property.Value, options);
                    continue;
                }
                if (property.NameEquals("canonicalProfiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CanonicalProfileDefinition> array = new List<CanonicalProfileDefinition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CanonicalProfileDefinition.DeserializeCanonicalProfileDefinition(item, options));
                    }
                    canonicalProfiles = array;
                    continue;
                }
                if (property.NameEquals("primaryProfileInstanceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryProfileInstanceCount = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PredictionTrainingResults(
                tenantId,
                scoreName,
                predictionDistribution,
                canonicalProfiles ?? new ChangeTrackingList<CanonicalProfileDefinition>(),
                primaryProfileInstanceCount,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PredictionTrainingResults>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PredictionTrainingResults>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PredictionTrainingResults)} does not support writing '{options.Format}' format.");
            }
        }

        PredictionTrainingResults IPersistableModel<PredictionTrainingResults>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PredictionTrainingResults>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePredictionTrainingResults(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PredictionTrainingResults)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PredictionTrainingResults>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
