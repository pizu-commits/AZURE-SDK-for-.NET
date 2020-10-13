// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ServiceTagsListResult
    {
        internal static ServiceTagsListResult DeserializeServiceTagsListResult(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> id = default;
            Optional<string> type = default;
            Optional<string> changeNumber = default;
            Optional<string> cloud = default;
            Optional<IReadOnlyList<ServiceTagInformation>> values = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
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
            }
            return new ServiceTagsListResult(name.Value, id.Value, type.Value, changeNumber.Value, cloud.Value, Optional.ToList(values));
        }
    }
}
