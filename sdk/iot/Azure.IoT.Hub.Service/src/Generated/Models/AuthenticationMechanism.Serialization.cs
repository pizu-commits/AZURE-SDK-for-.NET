// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.IoT.Hub.Service.Models
{
    public partial class AuthenticationMechanism : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(SymmetricKey))
            {
                writer.WritePropertyName("symmetricKey"u8);
                writer.WriteObjectValue(SymmetricKey);
            }
            if (Core.Optional.IsDefined(X509Thumbprint))
            {
                writer.WritePropertyName("x509Thumbprint"u8);
                writer.WriteObjectValue(X509Thumbprint);
            }
            if (Core.Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(Type.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static AuthenticationMechanism DeserializeAuthenticationMechanism(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<SymmetricKey> symmetricKey = default;
            Core.Optional<X509Thumbprint> x509Thumbprint = default;
            Core.Optional<AuthenticationMechanismType> type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("symmetricKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    symmetricKey = SymmetricKey.DeserializeSymmetricKey(property.Value);
                    continue;
                }
                if (property.NameEquals("x509Thumbprint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    x509Thumbprint = X509Thumbprint.DeserializeX509Thumbprint(property.Value);
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new AuthenticationMechanismType(property.Value.GetString());
                    continue;
                }
            }
            return new AuthenticationMechanism(symmetricKey.Value, x509Thumbprint.Value, Core.Optional.ToNullable(type));
        }
    }
}
