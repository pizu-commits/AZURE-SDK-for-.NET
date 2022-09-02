// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    internal partial class EventTypesListResult
    {
        internal static EventTypesListResult DeserializeEventTypesListResult(JsonElement element)
        {
            Optional<IReadOnlyList<EventType>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<EventType> array = new List<EventType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EventType.DeserializeEventType(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new EventTypesListResult(Optional.ToList(value));
        }
    }
}
