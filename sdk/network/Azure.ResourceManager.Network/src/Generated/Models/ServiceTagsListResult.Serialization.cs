// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ServiceTagsListResult
    {
        internal static ServiceTagsListResult DeserializeServiceTagsListResult(JsonElement element)
        {
            Optional<string> changeNumber = default;
            Optional<string> cloud = default;
            Optional<IReadOnlyList<ServiceTagInformation>> values = default;
            Optional<string> nextLink = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("changeNumber"))
                {
                    changeNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cloud"))
                {
                    cloud = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("values"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ServiceTagInformation> array = new List<ServiceTagInformation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServiceTagInformation.DeserializeServiceTagInformation(item));
                    }
                    values = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
            }
            return new ServiceTagsListResult(id, name, type, systemData.Value, changeNumber.Value, cloud.Value, Optional.ToList(values), nextLink.Value);
        }
    }
}
