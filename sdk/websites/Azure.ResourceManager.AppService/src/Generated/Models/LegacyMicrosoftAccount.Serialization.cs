// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class LegacyMicrosoftAccount : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled");
                writer.WriteBooleanValue(IsEnabled.Value);
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
            if (Optional.IsDefined(Validation))
            {
                writer.WritePropertyName("validation");
                writer.WriteObjectValue(Validation);
            }
            writer.WriteEndObject();
        }

        internal static LegacyMicrosoftAccount DeserializeLegacyMicrosoftAccount(JsonElement element)
        {
            Optional<bool> enabled = default;
            Optional<ClientRegistration> registration = default;
            Optional<LoginScopes> login = default;
            Optional<AllowedAudiencesValidation> validation = default;
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
                    registration = ClientRegistration.DeserializeClientRegistration(property.Value);
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
                if (property.NameEquals("validation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    validation = AllowedAudiencesValidation.DeserializeAllowedAudiencesValidation(property.Value);
                    continue;
                }
            }
            return new LegacyMicrosoftAccount(Optional.ToNullable(enabled), registration.Value, login.Value, validation.Value);
        }
    }
}
