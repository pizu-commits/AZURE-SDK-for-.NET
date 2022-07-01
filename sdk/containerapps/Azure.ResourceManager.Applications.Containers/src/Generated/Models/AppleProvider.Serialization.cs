// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Applications.Containers.Models
{
    public partial class AppleProvider : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled");
                writer.WriteBooleanValue(Enabled.Value);
            }
            if (Optional.IsDefined(Registration))
            {
                writer.WritePropertyName("registration");
                writer.WriteObjectValue(Registration);
            }
            if (Optional.IsDefined(Login))
            {
                writer.WritePropertyName("login");
                writer.WriteObjectValue(Login);
            }
            writer.WriteEndObject();
        }

        internal static AppleProvider DeserializeAppleProvider(JsonElement element)
        {
            Optional<bool> enabled = default;
            Optional<AppleRegistration> registration = default;
            Optional<LoginScopes> login = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("registration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    registration = AppleRegistration.DeserializeAppleRegistration(property.Value);
                    continue;
                }
                if (property.NameEquals("login"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    login = Models.LoginScopes.DeserializeLoginScopes(property.Value);
                    continue;
                }
            }
            return new AppleProvider(Optional.ToNullable(enabled), registration.Value, login.Value);
        }
    }
}
