// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.Management.WebSites.Models
{
    public partial class VnetParameters : IUtf8JsonSerializable
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
            if (Optional.IsDefined(VnetResourceGroup))
            {
                writer.WritePropertyName("vnetResourceGroup");
                writer.WriteStringValue(VnetResourceGroup);
            }
            if (Optional.IsDefined(VnetName))
            {
                writer.WritePropertyName("vnetName");
                writer.WriteStringValue(VnetName);
            }
            if (Optional.IsDefined(VnetSubnetName))
            {
                writer.WritePropertyName("vnetSubnetName");
                writer.WriteStringValue(VnetSubnetName);
            }
            if (Optional.IsDefined(SubnetResourceId))
            {
                writer.WritePropertyName("subnetResourceId");
                writer.WriteStringValue(SubnetResourceId);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static VnetParameters DeserializeVnetParameters(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> kind = default;
            Optional<string> type = default;
            Optional<string> vnetResourceGroup = default;
            Optional<string> vnetName = default;
            Optional<string> vnetSubnetName = default;
            Optional<string> subnetResourceId = default;
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
                        if (property0.NameEquals("vnetResourceGroup"))
                        {
                            vnetResourceGroup = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vnetName"))
                        {
                            vnetName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vnetSubnetName"))
                        {
                            vnetSubnetName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("subnetResourceId"))
                        {
                            subnetResourceId = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new VnetParameters(id.Value, name.Value, kind.Value, type.Value, vnetResourceGroup.Value, vnetName.Value, vnetSubnetName.Value, subnetResourceId.Value);
        }
    }
}
