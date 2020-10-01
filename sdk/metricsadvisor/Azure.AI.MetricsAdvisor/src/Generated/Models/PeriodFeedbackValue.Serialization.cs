// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    public partial class PeriodFeedbackValue : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("periodType");
            writer.WriteStringValue(PeriodType.ToString());
            writer.WritePropertyName("periodValue");
            writer.WriteNumberValue(PeriodValue);
            writer.WriteEndObject();
        }

        internal static PeriodFeedbackValue DeserializePeriodFeedbackValue(JsonElement element)
        {
            PeriodType periodType = default;
            int periodValue = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("periodType"))
                {
                    periodType = new PeriodType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("periodValue"))
                {
                    periodValue = property.Value.GetInt32();
                    continue;
                }
            }
            return new PeriodFeedbackValue(periodType, periodValue);
        }
    }
}
