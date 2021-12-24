// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ConnectedVMware.Models
{
    public partial class PlacementProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ResourcePoolId))
            {
                writer.WritePropertyName("resourcePoolId");
                writer.WriteStringValue(ResourcePoolId);
            }
            if (Optional.IsDefined(ClusterId))
            {
                writer.WritePropertyName("clusterId");
                writer.WriteStringValue(ClusterId);
            }
            if (Optional.IsDefined(HostId))
            {
                writer.WritePropertyName("hostId");
                writer.WriteStringValue(HostId);
            }
            if (Optional.IsDefined(DatastoreId))
            {
                writer.WritePropertyName("datastoreId");
                writer.WriteStringValue(DatastoreId);
            }
            writer.WriteEndObject();
        }

        internal static PlacementProfile DeserializePlacementProfile(JsonElement element)
        {
            Optional<string> resourcePoolId = default;
            Optional<string> clusterId = default;
            Optional<string> hostId = default;
            Optional<string> datastoreId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourcePoolId"))
                {
                    resourcePoolId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clusterId"))
                {
                    clusterId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hostId"))
                {
                    hostId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("datastoreId"))
                {
                    datastoreId = property.Value.GetString();
                    continue;
                }
            }
            return new PlacementProfile(resourcePoolId.Value, clusterId.Value, hostId.Value, datastoreId.Value);
        }
    }
}
