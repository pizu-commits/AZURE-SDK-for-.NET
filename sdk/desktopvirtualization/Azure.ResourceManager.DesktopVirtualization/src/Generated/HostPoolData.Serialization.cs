// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DesktopVirtualization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DesktopVirtualization
{
    public partial class HostPoolData : IUtf8JsonSerializable, IJsonModel<HostPoolData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HostPoolData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HostPoolData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HostPoolData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HostPoolData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ManagedBy))
            {
                writer.WritePropertyName("managedBy"u8);
                writer.WriteStringValue(ManagedBy);
            }
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku, options);
            }
            if (Optional.IsDefined(Plan))
            {
                writer.WritePropertyName("plan"u8);
                JsonSerializer.Serialize(writer, Plan);
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
            if (options.Format != "W" && Optional.IsDefined(ObjectId))
            {
                writer.WritePropertyName("objectId"u8);
                writer.WriteStringValue(ObjectId);
            }
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("hostPoolType"u8);
            writer.WriteStringValue(HostPoolType.ToString());
            if (Optional.IsDefined(PersonalDesktopAssignmentType))
            {
                writer.WritePropertyName("personalDesktopAssignmentType"u8);
                writer.WriteStringValue(PersonalDesktopAssignmentType.Value.ToString());
            }
            if (Optional.IsDefined(CustomRdpProperty))
            {
                writer.WritePropertyName("customRdpProperty"u8);
                writer.WriteStringValue(CustomRdpProperty);
            }
            if (Optional.IsDefined(MaxSessionLimit))
            {
                writer.WritePropertyName("maxSessionLimit"u8);
                writer.WriteNumberValue(MaxSessionLimit.Value);
            }
            writer.WritePropertyName("loadBalancerType"u8);
            writer.WriteStringValue(LoadBalancerType.ToString());
            if (Optional.IsDefined(Ring))
            {
                writer.WritePropertyName("ring"u8);
                writer.WriteNumberValue(Ring.Value);
            }
            if (Optional.IsDefined(IsValidationEnvironment))
            {
                writer.WritePropertyName("validationEnvironment"u8);
                writer.WriteBooleanValue(IsValidationEnvironment.Value);
            }
            if (Optional.IsDefined(RegistrationInfo))
            {
                writer.WritePropertyName("registrationInfo"u8);
                writer.WriteObjectValue(RegistrationInfo, options);
            }
            if (Optional.IsDefined(VmTemplate))
            {
                writer.WritePropertyName("vmTemplate"u8);
                writer.WriteStringValue(VmTemplate);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ApplicationGroupReferences))
            {
                writer.WritePropertyName("applicationGroupReferences"u8);
                writer.WriteStartArray();
                foreach (var item in ApplicationGroupReferences)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SsoAdfsAuthority))
            {
                writer.WritePropertyName("ssoadfsAuthority"u8);
                writer.WriteStringValue(SsoAdfsAuthority);
            }
            if (Optional.IsDefined(SsoClientId))
            {
                writer.WritePropertyName("ssoClientId"u8);
                writer.WriteStringValue(SsoClientId);
            }
            if (Optional.IsDefined(SsoClientSecretKeyVaultPath))
            {
                writer.WritePropertyName("ssoClientSecretKeyVaultPath"u8);
                writer.WriteStringValue(SsoClientSecretKeyVaultPath);
            }
            if (Optional.IsDefined(SsoSecretType))
            {
                writer.WritePropertyName("ssoSecretType"u8);
                writer.WriteStringValue(SsoSecretType.Value.ToString());
            }
            writer.WritePropertyName("preferredAppGroupType"u8);
            writer.WriteStringValue(PreferredAppGroupType.ToString());
            if (Optional.IsDefined(StartVmOnConnect))
            {
                writer.WritePropertyName("startVMOnConnect"u8);
                writer.WriteBooleanValue(StartVmOnConnect.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(IsCloudPCResource))
            {
                writer.WritePropertyName("cloudPcResource"u8);
                writer.WriteBooleanValue(IsCloudPCResource.Value);
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsDefined(AgentUpdate))
            {
                writer.WritePropertyName("agentUpdate"u8);
                writer.WriteObjectValue(AgentUpdate, options);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(PrivateEndpointConnections))
            {
                writer.WritePropertyName("privateEndpointConnections"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateEndpointConnections)
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

        HostPoolData IJsonModel<HostPoolData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HostPoolData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HostPoolData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHostPoolData(document.RootElement, options);
        }

        internal static HostPoolData DeserializeHostPoolData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier managedBy = default;
            string kind = default;
            ETag? etag = default;
            ManagedServiceIdentity identity = default;
            DesktopVirtualizationSku sku = default;
            ArmPlan plan = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string objectId = default;
            string friendlyName = default;
            string description = default;
            HostPoolType hostPoolType = default;
            PersonalDesktopAssignmentType? personalDesktopAssignmentType = default;
            string customRdpProperty = default;
            int? maxSessionLimit = default;
            HostPoolLoadBalancerType loadBalancerType = default;
            int? ring = default;
            bool? validationEnvironment = default;
            HostPoolRegistrationInfo registrationInfo = default;
            string vmTemplate = default;
            IReadOnlyList<string> applicationGroupReferences = default;
            string ssoadfsAuthority = default;
            string ssoClientId = default;
            string ssoClientSecretKeyVaultPath = default;
            HostPoolSsoSecretType? ssoSecretType = default;
            PreferredAppGroupType preferredAppGroupType = default;
            bool? startVmOnConnect = default;
            bool? cloudPCResource = default;
            HostPoolPublicNetworkAccess? publicNetworkAccess = default;
            SessionHostAgentUpdateProperties agentUpdate = default;
            IReadOnlyList<DesktopVirtualizationPrivateEndpointConnection> privateEndpointConnections = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("managedBy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    managedBy = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
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
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = DesktopVirtualizationSku.DeserializeDesktopVirtualizationSku(property.Value, options);
                    continue;
                }
                if (property.NameEquals("plan"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    plan = JsonSerializer.Deserialize<ArmPlan>(property.Value.GetRawText());
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
                        if (property0.NameEquals("objectId"u8))
                        {
                            objectId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("friendlyName"u8))
                        {
                            friendlyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hostPoolType"u8))
                        {
                            hostPoolType = new HostPoolType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("personalDesktopAssignmentType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            personalDesktopAssignmentType = new PersonalDesktopAssignmentType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("customRdpProperty"u8))
                        {
                            customRdpProperty = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("maxSessionLimit"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxSessionLimit = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("loadBalancerType"u8))
                        {
                            loadBalancerType = new HostPoolLoadBalancerType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("ring"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ring = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("validationEnvironment"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            validationEnvironment = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("registrationInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            registrationInfo = HostPoolRegistrationInfo.DeserializeHostPoolRegistrationInfo(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("vmTemplate"u8))
                        {
                            vmTemplate = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("applicationGroupReferences"u8))
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
                            applicationGroupReferences = array;
                            continue;
                        }
                        if (property0.NameEquals("ssoadfsAuthority"u8))
                        {
                            ssoadfsAuthority = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ssoClientId"u8))
                        {
                            ssoClientId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ssoClientSecretKeyVaultPath"u8))
                        {
                            ssoClientSecretKeyVaultPath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ssoSecretType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ssoSecretType = new HostPoolSsoSecretType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("preferredAppGroupType"u8))
                        {
                            preferredAppGroupType = new PreferredAppGroupType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("startVMOnConnect"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startVmOnConnect = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("cloudPcResource"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            cloudPCResource = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicNetworkAccess = new HostPoolPublicNetworkAccess(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("agentUpdate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            agentUpdate = SessionHostAgentUpdateProperties.DeserializeSessionHostAgentUpdateProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointConnections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DesktopVirtualizationPrivateEndpointConnection> array = new List<DesktopVirtualizationPrivateEndpointConnection>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DesktopVirtualizationPrivateEndpointConnection.DeserializeDesktopVirtualizationPrivateEndpointConnection(item, options));
                            }
                            privateEndpointConnections = array;
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
            return new HostPoolData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                objectId,
                friendlyName,
                description,
                hostPoolType,
                personalDesktopAssignmentType,
                customRdpProperty,
                maxSessionLimit,
                loadBalancerType,
                ring,
                validationEnvironment,
                registrationInfo,
                vmTemplate,
                applicationGroupReferences ?? new ChangeTrackingList<string>(),
                ssoadfsAuthority,
                ssoClientId,
                ssoClientSecretKeyVaultPath,
                ssoSecretType,
                preferredAppGroupType,
                startVmOnConnect,
                cloudPCResource,
                publicNetworkAccess,
                agentUpdate,
                privateEndpointConnections ?? new ChangeTrackingList<DesktopVirtualizationPrivateEndpointConnection>(),
                managedBy,
                kind,
                etag,
                identity,
                sku,
                plan,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HostPoolData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HostPoolData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HostPoolData)} does not support writing '{options.Format}' format.");
            }
        }

        HostPoolData IPersistableModel<HostPoolData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HostPoolData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHostPoolData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HostPoolData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HostPoolData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
