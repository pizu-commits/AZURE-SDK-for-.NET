// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    public partial class NetworkFabricInternalNetworkData : IUtf8JsonSerializable, IJsonModel<NetworkFabricInternalNetworkData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkFabricInternalNetworkData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NetworkFabricInternalNetworkData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkFabricInternalNetworkData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkFabricInternalNetworkData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Annotation))
            {
                writer.WritePropertyName("annotation"u8);
                writer.WriteStringValue(Annotation);
            }
            if (Optional.IsDefined(Mtu))
            {
                writer.WritePropertyName("mtu"u8);
                writer.WriteNumberValue(Mtu.Value);
            }
            if (Optional.IsCollectionDefined(ConnectedIPv4Subnets))
            {
                writer.WritePropertyName("connectedIPv4Subnets"u8);
                writer.WriteStartArray();
                foreach (var item in ConnectedIPv4Subnets)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ConnectedIPv6Subnets))
            {
                writer.WritePropertyName("connectedIPv6Subnets"u8);
                writer.WriteStartArray();
                foreach (var item in ConnectedIPv6Subnets)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ImportRoutePolicyId))
            {
                writer.WritePropertyName("importRoutePolicyId"u8);
                writer.WriteStringValue(ImportRoutePolicyId);
            }
            if (Optional.IsDefined(ExportRoutePolicyId))
            {
                writer.WritePropertyName("exportRoutePolicyId"u8);
                writer.WriteStringValue(ExportRoutePolicyId);
            }
            if (Optional.IsDefined(ImportRoutePolicy))
            {
                writer.WritePropertyName("importRoutePolicy"u8);
                writer.WriteObjectValue(ImportRoutePolicy, options);
            }
            if (Optional.IsDefined(ExportRoutePolicy))
            {
                writer.WritePropertyName("exportRoutePolicy"u8);
                writer.WriteObjectValue(ExportRoutePolicy, options);
            }
            if (Optional.IsDefined(IngressAclId))
            {
                writer.WritePropertyName("ingressAclId"u8);
                writer.WriteStringValue(IngressAclId);
            }
            if (Optional.IsDefined(EgressAclId))
            {
                writer.WritePropertyName("egressAclId"u8);
                writer.WriteStringValue(EgressAclId);
            }
            if (Optional.IsDefined(IsMonitoringEnabled))
            {
                writer.WritePropertyName("isMonitoringEnabled"u8);
                writer.WriteStringValue(IsMonitoringEnabled.Value.ToString());
            }
            if (Optional.IsDefined(Extension))
            {
                writer.WritePropertyName("extension"u8);
                writer.WriteStringValue(Extension.Value.ToString());
            }
            writer.WritePropertyName("vlanId"u8);
            writer.WriteNumberValue(VlanId);
            if (Optional.IsDefined(BgpConfiguration))
            {
                writer.WritePropertyName("bgpConfiguration"u8);
                writer.WriteObjectValue(BgpConfiguration, options);
            }
            if (Optional.IsDefined(StaticRouteConfiguration))
            {
                writer.WritePropertyName("staticRouteConfiguration"u8);
                writer.WriteObjectValue(StaticRouteConfiguration, options);
            }
            if (options.Format != "W" && Optional.IsDefined(ConfigurationState))
            {
                writer.WritePropertyName("configurationState"u8);
                writer.WriteStringValue(ConfigurationState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(AdministrativeState))
            {
                writer.WritePropertyName("administrativeState"u8);
                writer.WriteStringValue(AdministrativeState.Value.ToString());
            }
            writer.WriteEndObject();
        }

        NetworkFabricInternalNetworkData IJsonModel<NetworkFabricInternalNetworkData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkFabricInternalNetworkData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkFabricInternalNetworkData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkFabricInternalNetworkData(document.RootElement, options);
        }

        internal static NetworkFabricInternalNetworkData DeserializeNetworkFabricInternalNetworkData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string annotation = default;
            int? mtu = default;
            IList<ConnectedSubnet> connectedIPv4Subnets = default;
            IList<ConnectedSubnet> connectedIPv6Subnets = default;
            ResourceIdentifier importRoutePolicyId = default;
            ResourceIdentifier exportRoutePolicyId = default;
            ImportRoutePolicy importRoutePolicy = default;
            ExportRoutePolicy exportRoutePolicy = default;
            ResourceIdentifier ingressAclId = default;
            ResourceIdentifier egressAclId = default;
            IsMonitoringEnabled? isMonitoringEnabled = default;
            StaticRouteConfigurationExtension? extension = default;
            int vlanId = default;
            InternalNetworkBgpConfiguration bgpConfiguration = default;
            InternalNetworkStaticRouteConfiguration staticRouteConfiguration = default;
            NetworkFabricConfigurationState? configurationState = default;
            NetworkFabricProvisioningState? provisioningState = default;
            NetworkFabricAdministrativeState? administrativeState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
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
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
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
                        if (property0.NameEquals("annotation"u8))
                        {
                            annotation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("mtu"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            mtu = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("connectedIPv4Subnets"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ConnectedSubnet> array = new List<ConnectedSubnet>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ConnectedSubnet.DeserializeConnectedSubnet(item, options));
                            }
                            connectedIPv4Subnets = array;
                            continue;
                        }
                        if (property0.NameEquals("connectedIPv6Subnets"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ConnectedSubnet> array = new List<ConnectedSubnet>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ConnectedSubnet.DeserializeConnectedSubnet(item, options));
                            }
                            connectedIPv6Subnets = array;
                            continue;
                        }
                        if (property0.NameEquals("importRoutePolicyId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            importRoutePolicyId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("exportRoutePolicyId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            exportRoutePolicyId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("importRoutePolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            importRoutePolicy = ImportRoutePolicy.DeserializeImportRoutePolicy(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("exportRoutePolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            exportRoutePolicy = ExportRoutePolicy.DeserializeExportRoutePolicy(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("ingressAclId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ingressAclId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("egressAclId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            egressAclId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("isMonitoringEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isMonitoringEnabled = new IsMonitoringEnabled(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("extension"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            extension = new StaticRouteConfigurationExtension(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("vlanId"u8))
                        {
                            vlanId = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("bgpConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            bgpConfiguration = InternalNetworkBgpConfiguration.DeserializeInternalNetworkBgpConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("staticRouteConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            staticRouteConfiguration = InternalNetworkStaticRouteConfiguration.DeserializeInternalNetworkStaticRouteConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("configurationState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            configurationState = new NetworkFabricConfigurationState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkFabricProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("administrativeState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            administrativeState = new NetworkFabricAdministrativeState(property0.Value.GetString());
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
            return new NetworkFabricInternalNetworkData(
                id,
                name,
                type,
                systemData,
                annotation,
                mtu,
                connectedIPv4Subnets ?? new ChangeTrackingList<ConnectedSubnet>(),
                connectedIPv6Subnets ?? new ChangeTrackingList<ConnectedSubnet>(),
                importRoutePolicyId,
                exportRoutePolicyId,
                importRoutePolicy,
                exportRoutePolicy,
                ingressAclId,
                egressAclId,
                isMonitoringEnabled,
                extension,
                vlanId,
                bgpConfiguration,
                staticRouteConfiguration,
                configurationState,
                provisioningState,
                administrativeState,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkFabricInternalNetworkData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkFabricInternalNetworkData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkFabricInternalNetworkData)} does not support writing '{options.Format}' format.");
            }
        }

        NetworkFabricInternalNetworkData IPersistableModel<NetworkFabricInternalNetworkData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkFabricInternalNetworkData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkFabricInternalNetworkData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkFabricInternalNetworkData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkFabricInternalNetworkData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
