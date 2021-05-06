// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.Management.WebSites.Models
{
    internal partial class HostNameBindingCollection
    {
        internal static HostNameBindingCollection DeserializeHostNameBindingCollection(JsonElement element)
        {
            IReadOnlyList<HostNameBinding> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<HostNameBinding> array = new List<HostNameBinding>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HostNameBinding.DeserializeHostNameBinding(item));
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
            return new HostNameBindingCollection(value, nextLink.Value);
        }
    }
}
