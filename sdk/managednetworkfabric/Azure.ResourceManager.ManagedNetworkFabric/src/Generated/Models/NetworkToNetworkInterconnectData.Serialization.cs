// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;
using Azure.ResourceManager.ManagedNetworkFabric.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    public partial class NetworkToNetworkInterconnectData : IUtf8JsonSerializable, IModelJsonSerializable<NetworkToNetworkInterconnectData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NetworkToNetworkInterconnectData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NetworkToNetworkInterconnectData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(NniType))
            {
                writer.WritePropertyName("nniType"u8);
                writer.WriteStringValue(NniType.Value.ToString());
            }
            if (Optional.IsDefined(IsManagementType))
            {
                writer.WritePropertyName("isManagementType"u8);
                writer.WriteStringValue(IsManagementType.Value.ToString());
            }
            writer.WritePropertyName("useOptionB"u8);
            writer.WriteStringValue(UseOptionB.ToString());
            if (Optional.IsDefined(Layer2Configuration))
            {
                writer.WritePropertyName("layer2Configuration"u8);
                if (Layer2Configuration is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<Layer2Configuration>)Layer2Configuration).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(OptionBLayer3Configuration))
            {
                writer.WritePropertyName("optionBLayer3Configuration"u8);
                if (OptionBLayer3Configuration is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<NetworkToNetworkInterconnectOptionBLayer3Configuration>)OptionBLayer3Configuration).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(NpbStaticRouteConfiguration))
            {
                writer.WritePropertyName("npbStaticRouteConfiguration"u8);
                if (NpbStaticRouteConfiguration is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<NpbStaticRouteConfiguration>)NpbStaticRouteConfiguration).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(ImportRoutePolicy))
            {
                writer.WritePropertyName("importRoutePolicy"u8);
                if (ImportRoutePolicy is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ImportRoutePolicyInformation>)ImportRoutePolicy).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(ExportRoutePolicy))
            {
                writer.WritePropertyName("exportRoutePolicy"u8);
                if (ExportRoutePolicy is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ExportRoutePolicyInformation>)ExportRoutePolicy).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(EgressAclId))
            {
                writer.WritePropertyName("egressAclId"u8);
                writer.WriteStringValue(EgressAclId);
            }
            if (Optional.IsDefined(IngressAclId))
            {
                writer.WritePropertyName("ingressAclId"u8);
                writer.WriteStringValue(IngressAclId);
            }
            writer.WriteEndObject();
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static NetworkToNetworkInterconnectData DeserializeNetworkToNetworkInterconnectData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<NniType> nniType = default;
            Optional<IsManagementType> isManagementType = default;
            NetworkFabricBooleanValue useOptionB = default;
            Optional<Layer2Configuration> layer2Configuration = default;
            Optional<NetworkToNetworkInterconnectOptionBLayer3Configuration> optionBLayer3Configuration = default;
            Optional<NpbStaticRouteConfiguration> npbStaticRouteConfiguration = default;
            Optional<ImportRoutePolicyInformation> importRoutePolicy = default;
            Optional<ExportRoutePolicyInformation> exportRoutePolicy = default;
            Optional<ResourceIdentifier> egressAclId = default;
            Optional<ResourceIdentifier> ingressAclId = default;
            Optional<NetworkFabricConfigurationState> configurationState = default;
            Optional<NetworkFabricProvisioningState> provisioningState = default;
            Optional<NetworkFabricAdministrativeState> administrativeState = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
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
                        if (property0.NameEquals("nniType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nniType = new NniType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("isManagementType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isManagementType = new IsManagementType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("useOptionB"u8))
                        {
                            useOptionB = new NetworkFabricBooleanValue(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("layer2Configuration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            layer2Configuration = Layer2Configuration.DeserializeLayer2Configuration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("optionBLayer3Configuration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            optionBLayer3Configuration = NetworkToNetworkInterconnectOptionBLayer3Configuration.DeserializeNetworkToNetworkInterconnectOptionBLayer3Configuration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("npbStaticRouteConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            npbStaticRouteConfiguration = NpbStaticRouteConfiguration.DeserializeNpbStaticRouteConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("importRoutePolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            importRoutePolicy = ImportRoutePolicyInformation.DeserializeImportRoutePolicyInformation(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("exportRoutePolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            exportRoutePolicy = ExportRoutePolicyInformation.DeserializeExportRoutePolicyInformation(property0.Value);
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
                        if (property0.NameEquals("ingressAclId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ingressAclId = new ResourceIdentifier(property0.Value.GetString());
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
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new NetworkToNetworkInterconnectData(id, name, type, systemData.Value, Optional.ToNullable(nniType), Optional.ToNullable(isManagementType), useOptionB, layer2Configuration.Value, optionBLayer3Configuration.Value, npbStaticRouteConfiguration.Value, importRoutePolicy.Value, exportRoutePolicy.Value, egressAclId.Value, ingressAclId.Value, Optional.ToNullable(configurationState), Optional.ToNullable(provisioningState), Optional.ToNullable(administrativeState), rawData);
        }

        NetworkToNetworkInterconnectData IModelJsonSerializable<NetworkToNetworkInterconnectData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkToNetworkInterconnectData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NetworkToNetworkInterconnectData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NetworkToNetworkInterconnectData IModelSerializable<NetworkToNetworkInterconnectData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNetworkToNetworkInterconnectData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="NetworkToNetworkInterconnectData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="NetworkToNetworkInterconnectData"/> to convert. </param>
        public static implicit operator RequestContent(NetworkToNetworkInterconnectData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="NetworkToNetworkInterconnectData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator NetworkToNetworkInterconnectData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNetworkToNetworkInterconnectData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
