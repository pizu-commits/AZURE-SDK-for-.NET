// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.Management.WebSites.Models
{
    public partial class InboundEnvironmentEndpoint
    {
        internal static InboundEnvironmentEndpoint DeserializeInboundEnvironmentEndpoint(JsonElement element)
        {
            Optional<string> description = default;
            Optional<IReadOnlyList<string>> endpoints = default;
            Optional<IReadOnlyList<string>> ports = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpoints"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    endpoints = array;
                    continue;
                }
                if (property.NameEquals("ports"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    ports = array;
                    continue;
                }
            }
            return new InboundEnvironmentEndpoint(description.Value, Optional.ToList(endpoints), Optional.ToList(ports));
        }
    }
}
