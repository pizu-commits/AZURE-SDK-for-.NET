// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Security.KeyVault.Storage.Models
{
    public partial class StorageBundle
    {
        internal static StorageBundle DeserializeStorageBundle(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> id = default;
            Core.Optional<string> resourceId = default;
            Core.Optional<string> activeKeyName = default;
            Core.Optional<bool> autoRegenerateKey = default;
            Core.Optional<string> regenerationPeriod = default;
            Core.Optional<StorageAccountAttributes> attributes = default;
            Core.Optional<IReadOnlyDictionary<string, string>> tags = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceId"u8))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("activeKeyName"u8))
                {
                    activeKeyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("autoRegenerateKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoRegenerateKey = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("regenerationPeriod"u8))
                {
                    regenerationPeriod = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("attributes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    attributes = StorageAccountAttributes.DeserializeStorageAccountAttributes(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
            }
            return new StorageBundle(id.Value, resourceId.Value, activeKeyName.Value, Core.Optional.ToNullable(autoRegenerateKey), regenerationPeriod.Value, attributes.Value, Core.Optional.ToDictionary(tags));
        }
    }
}
