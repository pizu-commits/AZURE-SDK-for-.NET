// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    public partial class CapacityReservationProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WriteEndObject();
        }

        internal static CapacityReservationProperties DeserializeCapacityReservationProperties(JsonElement element)
        {
            Optional<string> lastSkuUpdate = default;
            Optional<long> minCapacity = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lastSkuUpdate"))
                {
                    lastSkuUpdate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("minCapacity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    minCapacity = property.Value.GetInt64();
                    continue;
                }
            }
            return new CapacityReservationProperties(lastSkuUpdate.Value, Optional.ToNullable(minCapacity));
        }
    }
}
