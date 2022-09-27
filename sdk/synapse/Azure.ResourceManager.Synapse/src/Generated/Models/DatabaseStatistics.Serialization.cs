// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    internal partial class DatabaseStatistics
    {
        internal static DatabaseStatistics DeserializeDatabaseStatistics(JsonElement element)
        {
            Optional<float> size = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("size"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    size = property.Value.GetSingle();
                    continue;
                }
            }
            return new DatabaseStatistics(Optional.ToNullable(size));
        }
    }
}
