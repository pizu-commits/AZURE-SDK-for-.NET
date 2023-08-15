// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class ServiceFabricManagedUnsupportedVmSize
    {
        internal static ServiceFabricManagedUnsupportedVmSize DeserializeServiceFabricManagedUnsupportedVmSize(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<VmSize> properties = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = Models.VmSize.DeserializeVmSize(property.Value);
                    continue;
                }
                if (property.NameEquals("id"u8) || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
            }
            return new ServiceFabricManagedUnsupportedVmSize(id, name, type, systemData.Value, properties.Value);
        }
    }
}
