// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class DefaultRolloutProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(Specification))
            {
                writer.WritePropertyName("specification");
                writer.WriteObjectValue(Specification);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status");
                writer.WriteObjectValue(Status);
            }
            writer.WriteEndObject();
        }

        internal static DefaultRolloutProperties DeserializeDefaultRolloutProperties(JsonElement element)
        {
            Optional<ProvisioningState> provisioningState = default;
            Optional<DefaultRolloutPropertiesSpecification> specification = default;
            Optional<DefaultRolloutPropertiesStatus> status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("specification"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    specification = DefaultRolloutPropertiesSpecification.DeserializeDefaultRolloutPropertiesSpecification(property.Value);
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    status = DefaultRolloutPropertiesStatus.DeserializeDefaultRolloutPropertiesStatus(property.Value);
                    continue;
                }
            }
            return new DefaultRolloutProperties(Optional.ToNullable(provisioningState), specification.Value, status.Value);
        }
    }
}
