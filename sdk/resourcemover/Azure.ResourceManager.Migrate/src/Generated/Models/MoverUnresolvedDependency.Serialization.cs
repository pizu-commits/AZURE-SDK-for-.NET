// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Migrate.Models
{
    public partial class MoverUnresolvedDependency
    {
        internal static MoverUnresolvedDependency DeserializeMoverUnresolvedDependency(JsonElement element)
        {
            Optional<int> count = default;
            Optional<ResourceIdentifier> id = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("count"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    count = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
            }
            return new MoverUnresolvedDependency(Optional.ToNullable(count), id.Value);
        }
    }
}
