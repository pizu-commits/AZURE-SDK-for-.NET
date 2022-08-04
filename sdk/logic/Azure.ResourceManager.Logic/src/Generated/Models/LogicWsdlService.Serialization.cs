// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class LogicWsdlService
    {
        internal static LogicWsdlService DeserializeLogicWsdlService(JsonElement element)
        {
            Optional<string> qualifiedName = default;
            Optional<IReadOnlyList<string>> endpointQualifiedNames = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("qualifiedName"))
                {
                    qualifiedName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("EndpointQualifiedNames"))
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
                    endpointQualifiedNames = array;
                    continue;
                }
            }
            return new LogicWsdlService(qualifiedName.Value, Optional.ToList(endpointQualifiedNames));
        }
    }
}
