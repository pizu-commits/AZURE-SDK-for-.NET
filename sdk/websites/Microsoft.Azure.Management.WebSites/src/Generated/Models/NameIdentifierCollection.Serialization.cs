// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.Management.WebSites.Models
{
    internal partial class NameIdentifierCollection
    {
        internal static NameIdentifierCollection DeserializeNameIdentifierCollection(JsonElement element)
        {
            IReadOnlyList<NameIdentifier> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<NameIdentifier> array = new List<NameIdentifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NameIdentifier.DeserializeNameIdentifier(item));
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
            return new NameIdentifierCollection(value, nextLink.Value);
        }
    }
}
