// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class ContainerRegistryEventRequest
    {
        internal static ContainerRegistryEventRequest DeserializeContainerRegistryEventRequest(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> addr = default;
            Optional<string> host = default;
            Optional<string> method = default;
            Optional<string> useragent = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("addr"))
                {
                    addr = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("host"))
                {
                    host = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("method"))
                {
                    method = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("useragent"))
                {
                    useragent = property.Value.GetString();
                    continue;
                }
            }
            return new ContainerRegistryEventRequest(id.Value, addr.Value, host.Value, method.Value, useragent.Value);
        }
    }
}
