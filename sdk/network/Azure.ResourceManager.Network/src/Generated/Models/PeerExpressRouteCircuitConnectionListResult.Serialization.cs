// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class PeerExpressRouteCircuitConnectionListResult
    {
        internal static PeerExpressRouteCircuitConnectionListResult DeserializePeerExpressRouteCircuitConnectionListResult(JsonElement element)
        {
            Optional<IReadOnlyList<PeerExpressRouteCircuitConnection>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<PeerExpressRouteCircuitConnection> array = new List<PeerExpressRouteCircuitConnection>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PeerExpressRouteCircuitConnection.DeserializePeerExpressRouteCircuitConnection(item));
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
            return new PeerExpressRouteCircuitConnectionListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
