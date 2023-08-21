// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class IntegrationServiceEnvironmentNetworkDependency
    {
        internal static IntegrationServiceEnvironmentNetworkDependency DeserializeIntegrationServiceEnvironmentNetworkDependency(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IntegrationServiceEnvironmentNetworkDependencyCategoryType> category = default;
            Core.Optional<string> displayName = default;
            Core.Optional<IReadOnlyList<IntegrationServiceEnvironmentNetworkEndpoint>> endpoints = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("category"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    category = new IntegrationServiceEnvironmentNetworkDependencyCategoryType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IntegrationServiceEnvironmentNetworkEndpoint> array = new List<IntegrationServiceEnvironmentNetworkEndpoint>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IntegrationServiceEnvironmentNetworkEndpoint.DeserializeIntegrationServiceEnvironmentNetworkEndpoint(item));
                    }
                    endpoints = array;
                    continue;
                }
            }
            return new IntegrationServiceEnvironmentNetworkDependency(Core.Optional.ToNullable(category), displayName.Value, Core.Optional.ToList(endpoints));
        }
    }
}
