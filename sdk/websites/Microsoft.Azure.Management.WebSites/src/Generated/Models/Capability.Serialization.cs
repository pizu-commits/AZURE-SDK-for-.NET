// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.Management.WebSites.Models
{
    public partial class Capability : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value");
                writer.WriteStringValue(Value);
            }
            if (Optional.IsDefined(Reason))
            {
                writer.WritePropertyName("reason");
                writer.WriteStringValue(Reason);
            }
            writer.WriteEndObject();
        }

        internal static Capability DeserializeCapability(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> value = default;
            Optional<string> reason = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reason"))
                {
                    reason = property.Value.GetString();
                    continue;
                }
            }
            return new Capability(name.Value, value.Value, reason.Value);
        }
    }
}
