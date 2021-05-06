// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.Management.WebSites.Models
{
    public partial class CorsSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AllowedOrigins))
            {
                writer.WritePropertyName("allowedOrigins");
                writer.WriteStartArray();
                foreach (var item in AllowedOrigins)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SupportCredentials))
            {
                writer.WritePropertyName("supportCredentials");
                writer.WriteBooleanValue(SupportCredentials.Value);
            }
            writer.WriteEndObject();
        }

        internal static CorsSettings DeserializeCorsSettings(JsonElement element)
        {
            Optional<IList<string>> allowedOrigins = default;
            Optional<bool> supportCredentials = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allowedOrigins"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    allowedOrigins = array;
                    continue;
                }
                if (property.NameEquals("supportCredentials"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    supportCredentials = property.Value.GetBoolean();
                    continue;
                }
            }
            return new CorsSettings(Optional.ToList(allowedOrigins), Optional.ToNullable(supportCredentials));
        }
    }
}
