// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class NodeTypeFrontendConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IPAddressType))
            {
                writer.WritePropertyName("ipAddressType"u8);
                writer.WriteStringValue(IPAddressType.Value.ToString());
            }
            if (Optional.IsDefined(LoadBalancerBackendAddressPoolId))
            {
                writer.WritePropertyName("loadBalancerBackendAddressPoolId"u8);
                writer.WriteStringValue(LoadBalancerBackendAddressPoolId);
            }
            if (Optional.IsDefined(LoadBalancerInboundNatPoolId))
            {
                writer.WritePropertyName("loadBalancerInboundNatPoolId"u8);
                writer.WriteStringValue(LoadBalancerInboundNatPoolId);
            }
            if (Optional.IsDefined(ApplicationGatewayBackendAddressPoolId))
            {
                writer.WritePropertyName("applicationGatewayBackendAddressPoolId"u8);
                writer.WriteStringValue(ApplicationGatewayBackendAddressPoolId);
            }
            writer.WriteEndObject();
        }

        internal static NodeTypeFrontendConfiguration DeserializeNodeTypeFrontendConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<NodeTypeFrontendConfigurationIPAddressType> ipAddressType = default;
            Optional<ResourceIdentifier> loadBalancerBackendAddressPoolId = default;
            Optional<ResourceIdentifier> loadBalancerInboundNatPoolId = default;
            Optional<ResourceIdentifier> applicationGatewayBackendAddressPoolId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipAddressType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipAddressType = new NodeTypeFrontendConfigurationIPAddressType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("loadBalancerBackendAddressPoolId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    loadBalancerBackendAddressPoolId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("loadBalancerInboundNatPoolId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    loadBalancerInboundNatPoolId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("applicationGatewayBackendAddressPoolId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    applicationGatewayBackendAddressPoolId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
            }
            return new NodeTypeFrontendConfiguration(Optional.ToNullable(ipAddressType), loadBalancerBackendAddressPoolId.Value, loadBalancerInboundNatPoolId.Value, applicationGatewayBackendAddressPoolId.Value);
        }
    }
}
