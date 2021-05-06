// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.Management.WebSites.Models
{
    public partial class VnetGateway : IUtf8JsonSerializable
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
            if (Optional.IsDefined(VnetName))
            {
                writer.WritePropertyName("vnetName");
                writer.WriteStringValue(VnetName);
            }
            if (Optional.IsDefined(VpnPackageUri))
            {
                writer.WritePropertyName("vpnPackageUri");
                writer.WriteStringValue(VpnPackageUri);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static VnetGateway DeserializeVnetGateway(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> kind = default;
            Optional<string> type = default;
            Optional<string> vnetName = default;
            Optional<string> vpnPackageUri = default;
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
                        if (property0.NameEquals("vnetName"))
                        {
                            vnetName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vpnPackageUri"))
                        {
                            vpnPackageUri = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new VnetGateway(id.Value, name.Value, kind.Value, type.Value, vnetName.Value, vpnPackageUri.Value);
        }
    }
}
