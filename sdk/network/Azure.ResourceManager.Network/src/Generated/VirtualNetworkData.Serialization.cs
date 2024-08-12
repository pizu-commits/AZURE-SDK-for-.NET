// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    public partial class VirtualNetworkData : IUtf8JsonSerializable, IJsonModel<VirtualNetworkData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualNetworkData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VirtualNetworkData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualNetworkData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualNetworkData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ExtendedLocation))
            {
                writer.WritePropertyName("extendedLocation"u8);
                JsonSerializer.Serialize(writer, ExtendedLocation);
            }
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W" && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType.Value);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AddressSpace))
            {
                writer.WritePropertyName("addressSpace"u8);
                writer.WriteObjectValue(AddressSpace, options);
            }
            if (Optional.IsDefined(DhcpOptions))
            {
                writer.WritePropertyName("dhcpOptions"u8);
                writer.WriteObjectValue(DhcpOptions, options);
            }
            if (Optional.IsDefined(FlowTimeoutInMinutes))
            {
                writer.WritePropertyName("flowTimeoutInMinutes"u8);
                writer.WriteNumberValue(FlowTimeoutInMinutes.Value);
            }
            if (Optional.IsCollectionDefined(Subnets))
            {
                writer.WritePropertyName("subnets"u8);
                writer.WriteStartArray();
                foreach (var item in Subnets)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VirtualNetworkPeerings))
            {
                writer.WritePropertyName("virtualNetworkPeerings"u8);
                writer.WriteStartArray();
                foreach (var item in VirtualNetworkPeerings)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceGuid))
            {
                writer.WritePropertyName("resourceGuid"u8);
                writer.WriteStringValue(ResourceGuid.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(EnableDdosProtection))
            {
                writer.WritePropertyName("enableDdosProtection"u8);
                writer.WriteBooleanValue(EnableDdosProtection.Value);
            }
            if (Optional.IsDefined(EnableVmProtection))
            {
                writer.WritePropertyName("enableVmProtection"u8);
                writer.WriteBooleanValue(EnableVmProtection.Value);
            }
            if (Optional.IsDefined(DdosProtectionPlan))
            {
                writer.WritePropertyName("ddosProtectionPlan"u8);
                JsonSerializer.Serialize(writer, DdosProtectionPlan);
            }
            if (Optional.IsDefined(BgpCommunities))
            {
                writer.WritePropertyName("bgpCommunities"u8);
                writer.WriteObjectValue(BgpCommunities, options);
            }
            if (Optional.IsDefined(Encryption))
            {
                writer.WritePropertyName("encryption"u8);
                writer.WriteObjectValue(Encryption, options);
            }
            if (Optional.IsCollectionDefined(IPAllocations))
            {
                writer.WritePropertyName("ipAllocations"u8);
                writer.WriteStartArray();
                foreach (var item in IPAllocations)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(FlowLogs))
            {
                writer.WritePropertyName("flowLogs"u8);
                writer.WriteStartArray();
                foreach (var item in FlowLogs)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        VirtualNetworkData IJsonModel<VirtualNetworkData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualNetworkData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualNetworkData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualNetworkData(document.RootElement, options);
        }

        internal static VirtualNetworkData DeserializeVirtualNetworkData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ExtendedLocation extendedLocation = default;
            ETag? etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType? type = default;
            AzureLocation? location = default;
            IDictionary<string, string> tags = default;
            AddressSpace addressSpace = default;
            DhcpOptions dhcpOptions = default;
            int? flowTimeoutInMinutes = default;
            IList<SubnetData> subnets = default;
            IList<VirtualNetworkPeeringData> virtualNetworkPeerings = default;
            Guid? resourceGuid = default;
            NetworkProvisioningState? provisioningState = default;
            bool? enableDdosProtection = default;
            bool? enableVmProtection = default;
            WritableSubResource ddosProtectionPlan = default;
            VirtualNetworkBgpCommunities bgpCommunities = default;
            VirtualNetworkEncryption encryption = default;
            IList<WritableSubResource> ipAllocations = default;
            IReadOnlyList<FlowLogData> flowLogs = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extendedLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedLocation = JsonSerializer.Deserialize<ExtendedLocation>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("addressSpace"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            addressSpace = AddressSpace.DeserializeAddressSpace(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("dhcpOptions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dhcpOptions = DhcpOptions.DeserializeDhcpOptions(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("flowTimeoutInMinutes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            flowTimeoutInMinutes = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("subnets"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SubnetData> array = new List<SubnetData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SubnetData.DeserializeSubnetData(item, options));
                            }
                            subnets = array;
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkPeerings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VirtualNetworkPeeringData> array = new List<VirtualNetworkPeeringData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VirtualNetworkPeeringData.DeserializeVirtualNetworkPeeringData(item, options));
                            }
                            virtualNetworkPeerings = array;
                            continue;
                        }
                        if (property0.NameEquals("resourceGuid"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceGuid = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("enableDdosProtection"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableDdosProtection = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableVmProtection"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableVmProtection = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("ddosProtectionPlan"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ddosProtectionPlan = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("bgpCommunities"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            bgpCommunities = VirtualNetworkBgpCommunities.DeserializeVirtualNetworkBgpCommunities(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("encryption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryption = VirtualNetworkEncryption.DeserializeVirtualNetworkEncryption(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("ipAllocations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            ipAllocations = array;
                            continue;
                        }
                        if (property0.NameEquals("flowLogs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<FlowLogData> array = new List<FlowLogData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(FlowLogData.DeserializeFlowLogData(item, options));
                            }
                            flowLogs = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new VirtualNetworkData(
                id,
                name,
                type,
                location,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                serializedAdditionalRawData,
                extendedLocation,
                etag,
                addressSpace,
                dhcpOptions,
                flowTimeoutInMinutes,
                subnets ?? new ChangeTrackingList<SubnetData>(),
                virtualNetworkPeerings ?? new ChangeTrackingList<VirtualNetworkPeeringData>(),
                resourceGuid,
                provisioningState,
                enableDdosProtection,
                enableVmProtection,
                ddosProtectionPlan,
                bgpCommunities,
                encryption,
                ipAllocations ?? new ChangeTrackingList<WritableSubResource>(),
                flowLogs ?? new ChangeTrackingList<FlowLogData>());
        }

        BinaryData IPersistableModel<VirtualNetworkData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualNetworkData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VirtualNetworkData)} does not support writing '{options.Format}' format.");
            }
        }

        VirtualNetworkData IPersistableModel<VirtualNetworkData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualNetworkData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualNetworkData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualNetworkData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualNetworkData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
