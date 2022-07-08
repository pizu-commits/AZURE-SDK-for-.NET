// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Batch.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Batch
{
    public partial class BatchPrivateEndpointConnectionData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(ConnectionState))
            {
                writer.WritePropertyName("privateLinkServiceConnectionState");
                writer.WriteObjectValue(ConnectionState);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static BatchPrivateEndpointConnectionData DeserializeBatchPrivateEndpointConnectionData(JsonElement element)
        {
            Optional<ETag> eTag = default;
            ResourceIdentifier id = default;
            string name = default;
            Core.ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<BatchPrivateEndpointConnectionProvisioningState> provisioningState = default;
            Optional<SubResource> privateEndpoint = default;
            Optional<IReadOnlyList<string>> groupIds = default;
            Optional<BatchPrivateLinkServiceConnectionState> privateLinkServiceConnectionState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    eTag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new Core.ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
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
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = property0.Value.GetString().ToBatchPrivateEndpointConnectionProvisioningState();
                            continue;
                        }
                        if (property0.NameEquals("privateEndpoint"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            privateEndpoint = JsonSerializer.Deserialize<SubResource>(property0.Value.ToString());
                            continue;
                        }
                        if (property0.NameEquals("groupIds"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            groupIds = array;
                            continue;
                        }
                        if (property0.NameEquals("privateLinkServiceConnectionState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            privateLinkServiceConnectionState = BatchPrivateLinkServiceConnectionState.DeserializeBatchPrivateLinkServiceConnectionState(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new BatchPrivateEndpointConnectionData(id, name, type, systemData.Value, Optional.ToNullable(provisioningState), privateEndpoint, Optional.ToList(groupIds), privateLinkServiceConnectionState.Value, Optional.ToNullable(eTag));
        }
    }
}
