// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Kubernetes.Models
{
    public partial class HybridConnectionConfig
    {
        internal static HybridConnectionConfig DeserializeHybridConnectionConfig(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<long> expirationTime = default;
            Core.Optional<string> hybridConnectionName = default;
            Core.Optional<string> relay = default;
            Core.Optional<string> token = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("expirationTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expirationTime = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("hybridConnectionName"u8))
                {
                    hybridConnectionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("relay"u8))
                {
                    relay = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("token"u8))
                {
                    token = property.Value.GetString();
                    continue;
                }
            }
            return new HybridConnectionConfig(Core.Optional.ToNullable(expirationTime), hybridConnectionName.Value, relay.Value, token.Value);
        }
    }
}
