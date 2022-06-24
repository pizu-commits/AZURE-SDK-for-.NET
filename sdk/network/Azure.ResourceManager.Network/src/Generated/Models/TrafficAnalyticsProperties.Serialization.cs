// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    internal partial class TrafficAnalyticsProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TrafficAnalyticsConfiguration))
            {
                writer.WritePropertyName("networkWatcherFlowAnalyticsConfiguration");
                writer.WriteObjectValue(TrafficAnalyticsConfiguration);
            }
            writer.WriteEndObject();
        }

        internal static TrafficAnalyticsProperties DeserializeTrafficAnalyticsProperties(JsonElement element)
        {
            Optional<TrafficAnalyticsConfigurationProperties> networkWatcherFlowAnalyticsConfiguration = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkWatcherFlowAnalyticsConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    networkWatcherFlowAnalyticsConfiguration = TrafficAnalyticsConfigurationProperties.DeserializeTrafficAnalyticsConfigurationProperties(property.Value);
                    continue;
                }
            }
            return new TrafficAnalyticsProperties(networkWatcherFlowAnalyticsConfiguration.Value);
        }
    }
}
