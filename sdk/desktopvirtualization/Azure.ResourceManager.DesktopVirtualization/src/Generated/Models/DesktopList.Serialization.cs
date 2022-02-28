// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DesktopVirtualization;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    public partial class DesktopList
    {
        internal static DesktopList DeserializeDesktopList(JsonElement element)
        {
            Optional<IReadOnlyList<DesktopData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DesktopData> array = new List<DesktopData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DesktopData.DeserializeDesktopData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new DesktopList(Optional.ToList(value), nextLink.Value);
        }
    }
}
