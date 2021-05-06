// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.Management.WebSites.Models
{
    internal partial class TopLevelDomainCollection
    {
        internal static TopLevelDomainCollection DeserializeTopLevelDomainCollection(JsonElement element)
        {
            IReadOnlyList<TopLevelDomain> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<TopLevelDomain> array = new List<TopLevelDomain>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TopLevelDomain.DeserializeTopLevelDomain(item));
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
            return new TopLevelDomainCollection(value, nextLink.Value);
        }
    }
}
