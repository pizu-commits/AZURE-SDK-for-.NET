// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Blueprint.Models
{
    public partial class SecretValueReference : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("keyVault"u8);
            JsonSerializer.Serialize(writer, KeyVault); writer.WritePropertyName("secretName"u8);
            writer.WriteStringValue(SecretName);
            if (Core.Optional.IsDefined(SecretVersion))
            {
                writer.WritePropertyName("secretVersion"u8);
                writer.WriteStringValue(SecretVersion);
            }
            writer.WriteEndObject();
        }

        internal static SecretValueReference DeserializeSecretValueReference(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            WritableSubResource keyVault = default;
            string secretName = default;
            Core.Optional<string> secretVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyVault"u8))
                {
                    keyVault = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("secretName"u8))
                {
                    secretName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secretVersion"u8))
                {
                    secretVersion = property.Value.GetString();
                    continue;
                }
            }
            return new SecretValueReference(keyVault, secretName, secretVersion.Value);
        }
    }
}
