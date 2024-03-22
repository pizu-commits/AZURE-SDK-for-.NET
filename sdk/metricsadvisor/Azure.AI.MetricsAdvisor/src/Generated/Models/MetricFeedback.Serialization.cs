// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor
{
    public partial class MetricFeedback : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("feedbackType"u8);
            writer.WriteStringValue(FeedbackKind.ToString());
            writer.WritePropertyName("metricId"u8);
            writer.WriteStringValue(MetricId);
            writer.WritePropertyName("dimensionFilter"u8);
            writer.WriteObjectValue<FeedbackFilter>(DimensionFilter);
            writer.WriteEndObject();
        }
    }
}
