// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class UriSigningKey : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("keyId"u8);
            writer.WriteStringValue(KeyId);
            writer.WritePropertyName("keySourceParameters"u8);
            writer.WriteObjectValue(KeySourceParameters);
            writer.WriteEndObject();
        }

        internal static UriSigningKey DeserializeUriSigningKey(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string keyId = default;
            KeyVaultSigningKey keySourceParameters = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyId"u8))
                {
                    keyId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keySourceParameters"u8))
                {
                    keySourceParameters = KeyVaultSigningKey.DeserializeKeyVaultSigningKey(property.Value);
                    continue;
                }
            }
            return new UriSigningKey(keyId, keySourceParameters);
        }
    }
}
