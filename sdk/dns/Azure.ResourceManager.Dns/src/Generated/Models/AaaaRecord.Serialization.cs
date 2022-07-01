// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Dns.Models
{
    public partial class AaaaRecord : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IPv6Address))
            {
                writer.WritePropertyName("ipv6Address");
                writer.WriteStringValue(IPv6Address);
            }
            writer.WriteEndObject();
        }

        internal static AaaaRecord DeserializeAaaaRecord(JsonElement element)
        {
            Optional<string> ipv6Address = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipv6Address"))
                {
                    ipv6Address = property.Value.GetString();
                    continue;
                }
            }
            return new AaaaRecord(ipv6Address.Value);
        }
    }
}
