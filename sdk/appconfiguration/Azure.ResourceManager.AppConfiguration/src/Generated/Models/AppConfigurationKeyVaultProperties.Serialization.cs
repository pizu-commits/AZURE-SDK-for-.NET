// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppConfiguration.Models
{
    public partial class AppConfigurationKeyVaultProperties : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(KeyIdentifier))
            {
                writer.WritePropertyName("keyIdentifier"u8);
                writer.WriteStringValue(KeyIdentifier);
            }
            if (Core.Optional.IsDefined(IdentityClientId))
            {
                writer.WritePropertyName("identityClientId"u8);
                writer.WriteStringValue(IdentityClientId);
            }
            writer.WriteEndObject();
        }

        internal static AppConfigurationKeyVaultProperties DeserializeAppConfigurationKeyVaultProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> keyIdentifier = default;
            Core.Optional<string> identityClientId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyIdentifier"u8))
                {
                    keyIdentifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identityClientId"u8))
                {
                    identityClientId = property.Value.GetString();
                    continue;
                }
            }
            return new AppConfigurationKeyVaultProperties(keyIdentifier.Value, identityClientId.Value);
        }
    }
}
