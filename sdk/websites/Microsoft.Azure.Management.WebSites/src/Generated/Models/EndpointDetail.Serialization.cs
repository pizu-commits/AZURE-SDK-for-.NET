// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.Management.WebSites.Models
{
    public partial class EndpointDetail
    {
        internal static EndpointDetail DeserializeEndpointDetail(JsonElement element)
        {
            Optional<string> ipAddress = default;
            Optional<int> port = default;
            Optional<double> latency = default;
            Optional<bool> isAccessible = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipAddress"))
                {
                    ipAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("port"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    port = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("latency"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    latency = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("isAccessible"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isAccessible = property.Value.GetBoolean();
                    continue;
                }
            }
            return new EndpointDetail(ipAddress.Value, Optional.ToNullable(port), Optional.ToNullable(latency), Optional.ToNullable(isAccessible));
        }
    }
}
