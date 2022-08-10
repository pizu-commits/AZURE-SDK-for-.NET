// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.IotCentral;

namespace Azure.ResourceManager.IotCentral.Models
{
    internal partial class IotCentralAppListResult
    {
        internal static IotCentralAppListResult DeserializeIotCentralAppListResult(JsonElement element)
        {
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<IotCentralAppData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<IotCentralAppData> array = new List<IotCentralAppData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IotCentralAppData.DeserializeIotCentralAppData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new IotCentralAppListResult(nextLink.Value, Optional.ToList(value));
        }
    }
}
