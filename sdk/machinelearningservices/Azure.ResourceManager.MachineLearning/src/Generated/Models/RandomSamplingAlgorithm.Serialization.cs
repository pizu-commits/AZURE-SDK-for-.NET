// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class RandomSamplingAlgorithm : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Rule))
            {
                writer.WritePropertyName("rule"u8);
                writer.WriteStringValue(Rule.Value.ToString());
            }
            if (Core.Optional.IsDefined(Seed))
            {
                if (Seed != null)
                {
                    writer.WritePropertyName("seed"u8);
                    writer.WriteNumberValue(Seed.Value);
                }
                else
                {
                    writer.WriteNull("seed");
                }
            }
            writer.WritePropertyName("samplingAlgorithmType"u8);
            writer.WriteStringValue(SamplingAlgorithmType.ToString());
            writer.WriteEndObject();
        }

        internal static RandomSamplingAlgorithm DeserializeRandomSamplingAlgorithm(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<RandomSamplingAlgorithmRule> rule = default;
            Core.Optional<int?> seed = default;
            SamplingAlgorithmType samplingAlgorithmType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rule = new RandomSamplingAlgorithmRule(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("seed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        seed = null;
                        continue;
                    }
                    seed = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("samplingAlgorithmType"u8))
                {
                    samplingAlgorithmType = new SamplingAlgorithmType(property.Value.GetString());
                    continue;
                }
            }
            return new RandomSamplingAlgorithm(samplingAlgorithmType, Core.Optional.ToNullable(rule), Core.Optional.ToNullable(seed));
        }
    }
}
