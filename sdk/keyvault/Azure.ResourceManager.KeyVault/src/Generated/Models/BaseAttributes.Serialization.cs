// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KeyVault.Models
{
    public partial class BaseAttributes : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled");
                writer.WriteBooleanValue(Enabled.Value);
            }
            if (Optional.IsDefined(NotBefore))
            {
                writer.WritePropertyName("nbf");
                writer.WriteNumberValue(NotBefore.Value, "U");
            }
            if (Optional.IsDefined(Expires))
            {
                writer.WritePropertyName("exp");
                writer.WriteNumberValue(Expires.Value, "U");
            }
            writer.WriteEndObject();
        }

        internal static BaseAttributes DeserializeBaseAttributes(JsonElement element)
        {
            Optional<bool> enabled = default;
            Optional<DateTimeOffset> nbf = default;
            Optional<DateTimeOffset> exp = default;
            Optional<DateTimeOffset> created = default;
            Optional<DateTimeOffset> updated = default;
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
                if (property.NameEquals("nbf"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    nbf = property.Value.GetDateTimeOffset("U");
                    continue;
                }
                if (property.NameEquals("exp"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    exp = property.Value.GetDateTimeOffset("U");
                    continue;
                }
                if (property.NameEquals("created"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    created = property.Value.GetDateTimeOffset("U");
                    continue;
                }
                if (property.NameEquals("updated"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    updated = property.Value.GetDateTimeOffset("U");
                    continue;
                }
            }
            return new BaseAttributes(Optional.ToNullable(enabled), Optional.ToNullable(nbf), Optional.ToNullable(exp), Optional.ToNullable(created), Optional.ToNullable(updated));
        }
    }
}
