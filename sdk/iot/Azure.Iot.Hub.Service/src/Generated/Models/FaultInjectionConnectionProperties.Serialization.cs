// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Iot.Hub.Service.Models
{
    internal partial class FaultInjectionConnectionProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Action))
            {
                writer.WritePropertyName("action");
                writer.WriteStringValue(Action.Value.ToString());
            }
            if (Optional.IsDefined(BlockDurationInMinutes))
            {
                writer.WritePropertyName("blockDurationInMinutes");
                writer.WriteNumberValue(BlockDurationInMinutes.Value);
            }
            writer.WriteEndObject();
        }

        internal static FaultInjectionConnectionProperties DeserializeFaultInjectionConnectionProperties(JsonElement element)
        {
            Optional<FaultInjectionConnectionPropertiesAction> action = default;
            Optional<int> blockDurationInMinutes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("action"))
                {
                    action = new FaultInjectionConnectionPropertiesAction(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("blockDurationInMinutes"))
                {
                    blockDurationInMinutes = property.Value.GetInt32();
                    continue;
                }
            }
            return new FaultInjectionConnectionProperties(Optional.ToNullable(action), Optional.ToNullable(blockDurationInMinutes));
        }
    }
}
