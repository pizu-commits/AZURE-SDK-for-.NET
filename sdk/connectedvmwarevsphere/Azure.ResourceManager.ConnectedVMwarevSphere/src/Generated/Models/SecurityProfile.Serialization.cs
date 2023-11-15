// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    internal partial class SecurityProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(UefiSettings))
            {
                writer.WritePropertyName("uefiSettings"u8);
                writer.WriteObjectValue(UefiSettings);
            }
            writer.WriteEndObject();
        }

        internal static SecurityProfile DeserializeSecurityProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<UefiSettings> uefiSettings = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("uefiSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    uefiSettings = UefiSettings.DeserializeUefiSettings(property.Value);
                    continue;
                }
            }
            return new SecurityProfile(uefiSettings.Value);
        }
    }
}
