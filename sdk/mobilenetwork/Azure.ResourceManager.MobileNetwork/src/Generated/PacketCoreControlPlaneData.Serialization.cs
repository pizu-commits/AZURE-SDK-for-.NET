// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MobileNetwork.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.MobileNetwork
{
    public partial class PacketCoreControlPlaneData : IUtf8JsonSerializable, IJsonModel<PacketCoreControlPlaneData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PacketCoreControlPlaneData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PacketCoreControlPlaneData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PacketCoreControlPlaneData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PacketCoreControlPlaneData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(UserAssignedIdentity))
            {
                writer.WritePropertyName("identity"u8);
                writer.WriteObjectValue<MobileNetworkManagedServiceIdentity>(UserAssignedIdentity, options);
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
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(Installation))
            {
                writer.WritePropertyName("installation"u8);
                writer.WriteObjectValue<MobileNetworkInstallation>(Installation, options);
            }
            writer.WritePropertyName("sites"u8);
            writer.WriteStartArray();
            foreach (var item in Sites)
            {
                JsonSerializer.Serialize(writer, item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("platform"u8);
            writer.WriteObjectValue<MobileNetworkPlatformConfiguration>(Platform, options);
            if (Optional.IsDefined(CoreNetworkTechnology))
            {
                writer.WritePropertyName("coreNetworkTechnology"u8);
                writer.WriteStringValue(CoreNetworkTechnology.Value.ToSerialString());
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            if (options.Format != "W" && Optional.IsDefined(InstalledVersion))
            {
                writer.WritePropertyName("installedVersion"u8);
                writer.WriteStringValue(InstalledVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(RollbackVersion))
            {
                writer.WritePropertyName("rollbackVersion"u8);
                writer.WriteStringValue(RollbackVersion);
            }
            writer.WritePropertyName("controlPlaneAccessInterface"u8);
            writer.WriteObjectValue<MobileNetworkInterfaceProperties>(ControlPlaneAccessInterface, options);
            if (Optional.IsCollectionDefined(ControlPlaneAccessVirtualIPv4Addresses))
            {
                writer.WritePropertyName("controlPlaneAccessVirtualIpv4Addresses"u8);
                writer.WriteStartArray();
                foreach (var item in ControlPlaneAccessVirtualIPv4Addresses)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("sku"u8);
            writer.WriteStringValue(Sku.ToString());
            if (Optional.IsDefined(UeMtu))
            {
                writer.WritePropertyName("ueMtu"u8);
                writer.WriteNumberValue(UeMtu.Value);
            }
            writer.WritePropertyName("localDiagnosticsAccess"u8);
            writer.WriteObjectValue<MobileNetworkLocalDiagnosticsAccessConfiguration>(LocalDiagnosticsAccess, options);
            if (Optional.IsDefined(DiagnosticsUpload))
            {
                writer.WritePropertyName("diagnosticsUpload"u8);
                writer.WriteObjectValue<DiagnosticsUploadConfiguration>(DiagnosticsUpload, options);
            }
            if (Optional.IsDefined(EventHub))
            {
                writer.WritePropertyName("eventHub"u8);
                writer.WriteObjectValue<MobileNetworkEventHubConfiguration>(EventHub, options);
            }
            if (Optional.IsDefined(Signaling))
            {
                writer.WritePropertyName("signaling"u8);
                writer.WriteObjectValue<SignalingConfiguration>(Signaling, options);
            }
            if (Optional.IsDefined(InteropSettings))
            {
                writer.WritePropertyName("interopSettings"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(InteropSettings);
#else
                using (JsonDocument document = JsonDocument.Parse(InteropSettings))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
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

        PacketCoreControlPlaneData IJsonModel<PacketCoreControlPlaneData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PacketCoreControlPlaneData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PacketCoreControlPlaneData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePacketCoreControlPlaneData(document.RootElement, options);
        }

        internal static PacketCoreControlPlaneData DeserializePacketCoreControlPlaneData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MobileNetworkManagedServiceIdentity identity = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            MobileNetworkProvisioningState? provisioningState = default;
            MobileNetworkInstallation installation = default;
            IList<WritableSubResource> sites = default;
            MobileNetworkPlatformConfiguration platform = default;
            MobileNetworkCoreNetworkType? coreNetworkTechnology = default;
            string version = default;
            string installedVersion = default;
            string rollbackVersion = default;
            MobileNetworkInterfaceProperties controlPlaneAccessInterface = default;
            IList<string> controlPlaneAccessVirtualIPv4Addresses = default;
            MobileNetworkBillingSku sku = default;
            int? ueMtu = default;
            MobileNetworkLocalDiagnosticsAccessConfiguration localDiagnosticsAccess = default;
            DiagnosticsUploadConfiguration diagnosticsUpload = default;
            MobileNetworkEventHubConfiguration eventHub = default;
            SignalingConfiguration signaling = default;
            BinaryData interopSettings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = MobileNetworkManagedServiceIdentity.DeserializeMobileNetworkManagedServiceIdentity(property.Value, options);
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
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new MobileNetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("installation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            installation = MobileNetworkInstallation.DeserializeMobileNetworkInstallation(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("sites"u8))
                        {
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            sites = array;
                            continue;
                        }
                        if (property0.NameEquals("platform"u8))
                        {
                            platform = MobileNetworkPlatformConfiguration.DeserializeMobileNetworkPlatformConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("coreNetworkTechnology"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            coreNetworkTechnology = property0.Value.GetString().ToMobileNetworkCoreNetworkType();
                            continue;
                        }
                        if (property0.NameEquals("version"u8))
                        {
                            version = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("installedVersion"u8))
                        {
                            installedVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("rollbackVersion"u8))
                        {
                            rollbackVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("controlPlaneAccessInterface"u8))
                        {
                            controlPlaneAccessInterface = MobileNetworkInterfaceProperties.DeserializeMobileNetworkInterfaceProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("controlPlaneAccessVirtualIpv4Addresses"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            controlPlaneAccessVirtualIPv4Addresses = array;
                            continue;
                        }
                        if (property0.NameEquals("sku"u8))
                        {
                            sku = new MobileNetworkBillingSku(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("ueMtu"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ueMtu = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("localDiagnosticsAccess"u8))
                        {
                            localDiagnosticsAccess = MobileNetworkLocalDiagnosticsAccessConfiguration.DeserializeMobileNetworkLocalDiagnosticsAccessConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("diagnosticsUpload"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            diagnosticsUpload = DiagnosticsUploadConfiguration.DeserializeDiagnosticsUploadConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("eventHub"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            eventHub = MobileNetworkEventHubConfiguration.DeserializeMobileNetworkEventHubConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("signaling"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            signaling = SignalingConfiguration.DeserializeSignalingConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("interopSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            interopSettings = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PacketCoreControlPlaneData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                identity,
                provisioningState,
                installation,
                sites,
                platform,
                coreNetworkTechnology,
                version,
                installedVersion,
                rollbackVersion,
                controlPlaneAccessInterface,
                controlPlaneAccessVirtualIPv4Addresses ?? new ChangeTrackingList<string>(),
                sku,
                ueMtu,
                localDiagnosticsAccess,
                diagnosticsUpload,
                eventHub,
                signaling,
                interopSettings,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PacketCoreControlPlaneData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PacketCoreControlPlaneData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PacketCoreControlPlaneData)} does not support writing '{options.Format}' format.");
            }
        }

        PacketCoreControlPlaneData IPersistableModel<PacketCoreControlPlaneData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PacketCoreControlPlaneData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePacketCoreControlPlaneData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PacketCoreControlPlaneData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PacketCoreControlPlaneData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
