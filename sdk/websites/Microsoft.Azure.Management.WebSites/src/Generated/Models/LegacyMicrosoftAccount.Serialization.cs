// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.Management.WebSites.Models
{
    public partial class LegacyMicrosoftAccount : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties");
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
            if (Optional.IsDefined(Validation))
            {
                writer.WritePropertyName("validation");
                writer.WriteObjectValue(Validation);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static LegacyMicrosoftAccount DeserializeLegacyMicrosoftAccount(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> kind = default;
            Optional<string> type = default;
            Optional<bool> enabled = default;
            Optional<ClientRegistration> registration = default;
            Optional<LoginScopes> login = default;
            Optional<AllowedAudiencesValidation> validation = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("enabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("registration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            registration = ClientRegistration.DeserializeClientRegistration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("login"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            login = LoginScopes.DeserializeLoginScopes(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("validation"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            validation = AllowedAudiencesValidation.DeserializeAllowedAudiencesValidation(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new LegacyMicrosoftAccount(id.Value, name.Value, kind.Value, type.Value, Optional.ToNullable(enabled), registration.Value, login.Value, validation.Value);
        }
    }
}
