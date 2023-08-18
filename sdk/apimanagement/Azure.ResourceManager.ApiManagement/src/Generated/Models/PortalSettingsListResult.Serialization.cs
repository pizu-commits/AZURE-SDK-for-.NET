// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    internal partial class PortalSettingsListResult
    {
        internal static PortalSettingsListResult DeserializePortalSettingsListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<PortalSettingsContractData>> value = default;
            Core.Optional<long> count = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PortalSettingsContractData> array = new List<PortalSettingsContractData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PortalSettingsContractData.DeserializePortalSettingsContractData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    count = property.Value.GetInt64();
                    continue;
                }
            }
            return new PortalSettingsListResult(Core.Optional.ToList(value), Core.Optional.ToNullable(count));
        }
    }
}
