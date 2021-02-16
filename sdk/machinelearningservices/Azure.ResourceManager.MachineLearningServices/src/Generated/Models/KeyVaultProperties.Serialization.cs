// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    public partial class KeyVaultProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("keyVaultArmId");
            writer.WriteStringValue(KeyVaultArmId);
            writer.WritePropertyName("keyIdentifier");
            writer.WriteStringValue(KeyIdentifier);
            if (Optional.IsDefined(IdentityClientId))
            {
                writer.WritePropertyName("identityClientId");
                writer.WriteStringValue(IdentityClientId);
            }
            writer.WriteEndObject();
        }

        internal static KeyVaultProperties DeserializeKeyVaultProperties(JsonElement element)
        {
            string keyVaultArmId = default;
            string keyIdentifier = default;
            Optional<string> identityClientId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyVaultArmId"))
                {
                    keyVaultArmId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyIdentifier"))
                {
                    keyIdentifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identityClientId"))
                {
                    identityClientId = property.Value.GetString();
                    continue;
                }
            }
            return new KeyVaultProperties(keyVaultArmId, keyIdentifier, identityClientId.Value);
        }
    }
}
