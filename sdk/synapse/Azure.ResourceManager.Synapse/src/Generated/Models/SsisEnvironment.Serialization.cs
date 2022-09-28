// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SsisEnvironment
    {
        internal static SsisEnvironment DeserializeSsisEnvironment(JsonElement element)
        {
            Optional<long> folderId = default;
            Optional<IReadOnlyList<SsisVariable>> variables = default;
            SsisObjectMetadataType type = default;
            Optional<long> id = default;
            Optional<string> name = default;
            Optional<string> description = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("folderId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    folderId = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("variables"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SsisVariable> array = new List<SsisVariable>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SsisVariable.DeserializeSsisVariable(item));
                    }
                    variables = array;
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new SsisObjectMetadataType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    id = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
            }
            return new SsisEnvironment(type, Optional.ToNullable(id), name.Value, description.Value, Optional.ToNullable(folderId), Optional.ToList(variables));
        }
    }
}
