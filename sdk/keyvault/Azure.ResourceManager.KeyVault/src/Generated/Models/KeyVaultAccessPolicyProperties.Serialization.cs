// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KeyVault.Models
{
    public partial class KeyVaultAccessPolicyProperties : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("accessPolicies"u8);
            writer.WriteStartArray();
            foreach (var item in AccessPolicies)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static KeyVaultAccessPolicyProperties DeserializeKeyVaultAccessPolicyProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<KeyVaultAccessPolicy> accessPolicies = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accessPolicies"u8))
                {
                    List<KeyVaultAccessPolicy> array = new List<KeyVaultAccessPolicy>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KeyVaultAccessPolicy.DeserializeKeyVaultAccessPolicy(item));
                    }
                    accessPolicies = array;
                    continue;
                }
            }
            return new KeyVaultAccessPolicyProperties(accessPolicies);
        }
    }
}
