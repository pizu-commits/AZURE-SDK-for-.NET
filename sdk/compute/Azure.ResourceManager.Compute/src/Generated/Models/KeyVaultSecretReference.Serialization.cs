// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class KeyVaultSecretReference : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("secretUrl");
            writer.WriteStringValue(SecretUrl);
            writer.WritePropertyName("sourceVault");
            JsonSerializer.Serialize(writer, SourceVault); writer.WriteEndObject();
        }

        internal static KeyVaultSecretReference DeserializeKeyVaultSecretReference(JsonElement element)
        {
            string secretUrl = default;
            WritableSubResource sourceVault = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("secretUrl"))
                {
                    secretUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceVault"))
                {
                    sourceVault = JsonSerializer.Deserialize<WritableSubResource>(property.Value.ToString());
                    continue;
                }
            }
            return new KeyVaultSecretReference(secretUrl, sourceVault);
        }
    }
}
