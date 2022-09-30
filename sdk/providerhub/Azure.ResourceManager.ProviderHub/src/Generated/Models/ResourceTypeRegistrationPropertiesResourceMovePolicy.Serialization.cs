// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class ResourceTypeRegistrationPropertiesResourceMovePolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ValidationRequired))
            {
                writer.WritePropertyName("validationRequired");
                writer.WriteBooleanValue(ValidationRequired.Value);
            }
            if (Optional.IsDefined(CrossResourceGroupMoveEnabled))
            {
                writer.WritePropertyName("crossResourceGroupMoveEnabled");
                writer.WriteBooleanValue(CrossResourceGroupMoveEnabled.Value);
            }
            if (Optional.IsDefined(CrossSubscriptionMoveEnabled))
            {
                writer.WritePropertyName("crossSubscriptionMoveEnabled");
                writer.WriteBooleanValue(CrossSubscriptionMoveEnabled.Value);
            }
            writer.WriteEndObject();
        }

        internal static ResourceTypeRegistrationPropertiesResourceMovePolicy DeserializeResourceTypeRegistrationPropertiesResourceMovePolicy(JsonElement element)
        {
            Optional<bool> validationRequired = default;
            Optional<bool> crossResourceGroupMoveEnabled = default;
            Optional<bool> crossSubscriptionMoveEnabled = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("validationRequired"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    validationRequired = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("crossResourceGroupMoveEnabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    crossResourceGroupMoveEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("crossSubscriptionMoveEnabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    crossSubscriptionMoveEnabled = property.Value.GetBoolean();
                    continue;
                }
            }
            return new ResourceTypeRegistrationPropertiesResourceMovePolicy(Optional.ToNullable(validationRequired), Optional.ToNullable(crossResourceGroupMoveEnabled), Optional.ToNullable(crossSubscriptionMoveEnabled));
        }
    }
}
