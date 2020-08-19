// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ExpressRouteCircuitsArpTableListResult
    {
        internal static ExpressRouteCircuitsArpTableListResult DeserializeExpressRouteCircuitsArpTableListResult(JsonElement element)
        {
            Optional<IReadOnlyList<ExpressRouteCircuitArpTable>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<ExpressRouteCircuitArpTable> array = new List<ExpressRouteCircuitArpTable>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ExpressRouteCircuitArpTable.DeserializeExpressRouteCircuitArpTable(item));
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
            return new ExpressRouteCircuitsArpTableListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
