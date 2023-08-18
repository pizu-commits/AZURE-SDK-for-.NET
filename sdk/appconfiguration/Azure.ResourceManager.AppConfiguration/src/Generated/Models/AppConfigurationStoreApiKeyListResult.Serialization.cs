// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppConfiguration.Models
{
    internal partial class AppConfigurationStoreApiKeyListResult
    {
        internal static AppConfigurationStoreApiKeyListResult DeserializeAppConfigurationStoreApiKeyListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<AppConfigurationStoreApiKey>> value = default;
            Core.Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AppConfigurationStoreApiKey> array = new List<AppConfigurationStoreApiKey>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AppConfigurationStoreApiKey.DeserializeAppConfigurationStoreApiKey(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new AppConfigurationStoreApiKeyListResult(Core.Optional.ToList(value), nextLink.Value);
        }
    }
}
