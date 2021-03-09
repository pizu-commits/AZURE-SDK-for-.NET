// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    internal partial class LoadBalancerProbeListResult
    {
        internal static LoadBalancerProbeListResult DeserializeLoadBalancerProbeListResult(JsonElement element)
        {
            Optional<IReadOnlyList<Probe>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<Probe> array = new List<Probe>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Probe.DeserializeProbe(item));
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
            return new LoadBalancerProbeListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
