// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Avs.Models
{
    public partial class AddonArcProperties : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(VCenter))
            {
                writer.WritePropertyName("vCenter"u8);
                writer.WriteStringValue(VCenter);
            }
            writer.WritePropertyName("addonType"u8);
            writer.WriteStringValue(AddonType.ToString());
            writer.WriteEndObject();
        }

        internal static AddonArcProperties DeserializeAddonArcProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> vCenter = default;
            AddonType addonType = default;
            Core.Optional<AddonProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vCenter"u8))
                {
                    vCenter = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("addonType"u8))
                {
                    addonType = new AddonType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new AddonProvisioningState(property.Value.GetString());
                    continue;
                }
            }
            return new AddonArcProperties(addonType, Core.Optional.ToNullable(provisioningState), vCenter.Value);
        }
    }
}
