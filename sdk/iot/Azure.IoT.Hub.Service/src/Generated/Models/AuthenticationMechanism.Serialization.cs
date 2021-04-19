// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.IoT.Hub.Service.Models
{
    public partial class AuthenticationMechanism : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SymmetricKey))
            {
                writer.WritePropertyName("symmetricKey");
                writer.WriteObjectValue(SymmetricKey);
            }
            if (Optional.IsDefined(X509Thumbprint))
            {
                writer.WritePropertyName("x509Thumbprint");
                writer.WriteObjectValue(X509Thumbprint);
            }
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static AuthenticationMechanism DeserializeAuthenticationMechanism(JsonElement element)
        {
            Optional<SymmetricKey> symmetricKey = default;
            Optional<X509Thumbprint> x509Thumbprint = default;
            Optional<AuthenticationMechanismType> type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("symmetricKey"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    symmetricKey = SymmetricKey.DeserializeSymmetricKey(property.Value);
                    continue;
                }
                if (property.NameEquals("x509Thumbprint"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    x509Thumbprint = X509Thumbprint.DeserializeX509Thumbprint(property.Value);
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new AuthenticationMechanismType(property.Value.GetString());
                    continue;
                }
            }
            return new AuthenticationMechanism(symmetricKey.Value, x509Thumbprint.Value, Optional.ToNullable(type));
        }
    }
}
