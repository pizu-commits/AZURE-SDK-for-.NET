// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class DomainSharedAccessKeys
    {
        internal static DomainSharedAccessKeys DeserializeDomainSharedAccessKeys(JsonElement element)
        {
            Optional<string> key1 = default;
            Optional<string> key2 = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("key1"))
                {
                    key1 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("key2"))
                {
                    key2 = property.Value.GetString();
                    continue;
                }
            }
            return new DomainSharedAccessKeys(key1.Value, key2.Value);
        }
    }
}
