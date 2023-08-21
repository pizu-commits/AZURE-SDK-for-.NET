// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    public partial class HelmOperatorProperties : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(ChartVersion))
            {
                writer.WritePropertyName("chartVersion"u8);
                writer.WriteStringValue(ChartVersion);
            }
            if (Core.Optional.IsDefined(ChartValues))
            {
                writer.WritePropertyName("chartValues"u8);
                writer.WriteStringValue(ChartValues);
            }
            writer.WriteEndObject();
        }

        internal static HelmOperatorProperties DeserializeHelmOperatorProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> chartVersion = default;
            Core.Optional<string> chartValues = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("chartVersion"u8))
                {
                    chartVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("chartValues"u8))
                {
                    chartValues = property.Value.GetString();
                    continue;
                }
            }
            return new HelmOperatorProperties(chartVersion.Value, chartValues.Value);
        }
    }
}
