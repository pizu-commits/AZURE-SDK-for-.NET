// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class SamplingOptions : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SkipSamplesWithoutAnnotation))
            {
                writer.WritePropertyName("skipSamplesWithoutAnnotation");
                writer.WriteStringValue(SkipSamplesWithoutAnnotation);
            }
            if (Optional.IsDefined(MaximumSamplesPerSecond))
            {
                writer.WritePropertyName("maximumSamplesPerSecond");
                writer.WriteStringValue(MaximumSamplesPerSecond);
            }
            writer.WriteEndObject();
        }

        internal static SamplingOptions DeserializeSamplingOptions(JsonElement element)
        {
            Optional<string> skipSamplesWithoutAnnotation = default;
            Optional<string> maximumSamplesPerSecond = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("skipSamplesWithoutAnnotation"))
                {
                    skipSamplesWithoutAnnotation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maximumSamplesPerSecond"))
                {
                    maximumSamplesPerSecond = property.Value.GetString();
                    continue;
                }
            }
            return new SamplingOptions(skipSamplesWithoutAnnotation.Value, maximumSamplesPerSecond.Value);
        }
    }
}
