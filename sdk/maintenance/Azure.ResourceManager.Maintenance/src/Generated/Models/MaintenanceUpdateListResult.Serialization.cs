// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Maintenance.Models
{
    internal partial class MaintenanceUpdateListResult
    {
        internal static MaintenanceUpdateListResult DeserializeMaintenanceUpdateListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<MaintenanceUpdate>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MaintenanceUpdate> array = new List<MaintenanceUpdate>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MaintenanceUpdate.DeserializeMaintenanceUpdate(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new MaintenanceUpdateListResult(Core.Optional.ToList(value));
        }
    }
}
