// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class ServiceTreeInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ServiceId))
            {
                writer.WritePropertyName("serviceId");
                writer.WriteStringValue(ServiceId);
            }
            if (Optional.IsDefined(ComponentId))
            {
                writer.WritePropertyName("componentId");
                writer.WriteStringValue(ComponentId);
            }
            if (Optional.IsDefined(Readiness))
            {
                writer.WritePropertyName("readiness");
                writer.WriteStringValue(Readiness.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static ServiceTreeInfo DeserializeServiceTreeInfo(JsonElement element)
        {
            Optional<string> serviceId = default;
            Optional<string> componentId = default;
            Optional<Readiness> readiness = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serviceId"))
                {
                    serviceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("componentId"))
                {
                    componentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("readiness"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    readiness = new Readiness(property.Value.GetString());
                    continue;
                }
            }
            return new ServiceTreeInfo(serviceId.Value, componentId.Value, Optional.ToNullable(readiness));
        }
    }
}
