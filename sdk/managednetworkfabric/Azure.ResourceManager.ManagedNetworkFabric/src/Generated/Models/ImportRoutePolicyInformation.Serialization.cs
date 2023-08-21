// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class ImportRoutePolicyInformation : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(ImportIPv4RoutePolicyId))
            {
                writer.WritePropertyName("importIpv4RoutePolicyId"u8);
                writer.WriteStringValue(ImportIPv4RoutePolicyId);
            }
            if (Core.Optional.IsDefined(ImportIPv6RoutePolicyId))
            {
                writer.WritePropertyName("importIpv6RoutePolicyId"u8);
                writer.WriteStringValue(ImportIPv6RoutePolicyId);
            }
            writer.WriteEndObject();
        }

        internal static ImportRoutePolicyInformation DeserializeImportRoutePolicyInformation(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<ResourceIdentifier> importIPv4RoutePolicyId = default;
            Core.Optional<ResourceIdentifier> importIPv6RoutePolicyId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("importIpv4RoutePolicyId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    importIPv4RoutePolicyId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("importIpv6RoutePolicyId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    importIPv6RoutePolicyId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
            }
            return new ImportRoutePolicyInformation(importIPv4RoutePolicyId.Value, importIPv6RoutePolicyId.Value);
        }
    }
}
