// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.IotHub;

namespace Azure.ResourceManager.IotHub.Models
{
    internal partial class IotHubPrivateLinkResources
    {
        internal static IotHubPrivateLinkResources DeserializeIotHubPrivateLinkResources(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<IotHubPrivateEndpointGroupInformationData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IotHubPrivateEndpointGroupInformationData> array = new List<IotHubPrivateEndpointGroupInformationData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IotHubPrivateEndpointGroupInformationData.DeserializeIotHubPrivateEndpointGroupInformationData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new IotHubPrivateLinkResources(Core.Optional.ToList(value));
        }
    }
}
