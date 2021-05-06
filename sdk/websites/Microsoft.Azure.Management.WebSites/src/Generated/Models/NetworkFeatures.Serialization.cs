// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.Management.WebSites.Models
{
    public partial class NetworkFeatures : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static NetworkFeatures DeserializeNetworkFeatures(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> kind = default;
            Optional<string> type = default;
            Optional<string> virtualNetworkName = default;
            Optional<VnetInfo> virtualNetworkConnection = default;
            Optional<IReadOnlyList<RelayServiceConnectionEntity>> hybridConnections = default;
            Optional<IReadOnlyList<HybridConnection>> hybridConnectionsV2 = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("virtualNetworkName"))
                        {
                            virtualNetworkName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkConnection"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            virtualNetworkConnection = VnetInfo.DeserializeVnetInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("hybridConnections"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<RelayServiceConnectionEntity> array = new List<RelayServiceConnectionEntity>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RelayServiceConnectionEntity.DeserializeRelayServiceConnectionEntity(item));
                            }
                            hybridConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("hybridConnectionsV2"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<HybridConnection> array = new List<HybridConnection>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(HybridConnection.DeserializeHybridConnection(item));
                            }
                            hybridConnectionsV2 = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new NetworkFeatures(id.Value, name.Value, kind.Value, type.Value, virtualNetworkName.Value, virtualNetworkConnection.Value, Optional.ToList(hybridConnections), Optional.ToList(hybridConnectionsV2));
        }
    }
}
