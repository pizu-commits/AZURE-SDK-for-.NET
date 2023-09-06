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
using Azure.ResourceManager.Kusto.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Kusto
{
    public partial class KustoClusterData : IUtf8JsonSerializable, IModelJsonSerializable<KustoClusterData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<KustoClusterData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<KustoClusterData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KustoClusterData>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("sku"u8);
            if (Sku is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<KustoSku>)Sku).Serialize(writer, options);
            }
            if (Optional.IsCollectionDefined(Zones))
            {
                writer.WritePropertyName("zones"u8);
                writer.WriteStartArray();
                foreach (var item in Zones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
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
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(TrustedExternalTenants))
            {
                writer.WritePropertyName("trustedExternalTenants"u8);
                writer.WriteStartArray();
                foreach (var item in TrustedExternalTenants)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<KustoClusterTrustedExternalTenant>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(OptimizedAutoscale))
            {
                writer.WritePropertyName("optimizedAutoscale"u8);
                if (OptimizedAutoscale is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<OptimizedAutoscale>)OptimizedAutoscale).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(IsDiskEncryptionEnabled))
            {
                writer.WritePropertyName("enableDiskEncryption"u8);
                writer.WriteBooleanValue(IsDiskEncryptionEnabled.Value);
            }
            if (Optional.IsDefined(IsStreamingIngestEnabled))
            {
                writer.WritePropertyName("enableStreamingIngest"u8);
                writer.WriteBooleanValue(IsStreamingIngestEnabled.Value);
            }
            if (Optional.IsDefined(VirtualNetworkConfiguration))
            {
                writer.WritePropertyName("virtualNetworkConfiguration"u8);
                if (VirtualNetworkConfiguration is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<KustoClusterVirtualNetworkConfiguration>)VirtualNetworkConfiguration).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(KeyVaultProperties))
            {
                writer.WritePropertyName("keyVaultProperties"u8);
                if (KeyVaultProperties is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<KustoKeyVaultProperties>)KeyVaultProperties).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(IsPurgeEnabled))
            {
                writer.WritePropertyName("enablePurge"u8);
                writer.WriteBooleanValue(IsPurgeEnabled.Value);
            }
            if (Optional.IsDefined(LanguageExtensions))
            {
                writer.WritePropertyName("languageExtensions"u8);
                if (LanguageExtensions is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<KustoLanguageExtensionList>)LanguageExtensions).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(IsDoubleEncryptionEnabled))
            {
                writer.WritePropertyName("enableDoubleEncryption"u8);
                writer.WriteBooleanValue(IsDoubleEncryptionEnabled.Value);
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsCollectionDefined(AllowedIPRangeList))
            {
                writer.WritePropertyName("allowedIpRangeList"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedIPRangeList)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EngineType))
            {
                writer.WritePropertyName("engineType"u8);
                writer.WriteStringValue(EngineType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(AcceptedAudiences))
            {
                writer.WritePropertyName("acceptedAudiences"u8);
                writer.WriteStartArray();
                foreach (var item in AcceptedAudiences)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<AcceptedAudience>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsAutoStopEnabled))
            {
                writer.WritePropertyName("enableAutoStop"u8);
                writer.WriteBooleanValue(IsAutoStopEnabled.Value);
            }
            if (Optional.IsDefined(RestrictOutboundNetworkAccess))
            {
                writer.WritePropertyName("restrictOutboundNetworkAccess"u8);
                writer.WriteStringValue(RestrictOutboundNetworkAccess.Value.ToString());
            }
            if (Optional.IsCollectionDefined(AllowedFqdnList))
            {
                writer.WritePropertyName("allowedFqdnList"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedFqdnList)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PublicIPType))
            {
                writer.WritePropertyName("publicIPType"u8);
                writer.WriteStringValue(PublicIPType.Value.ToString());
            }
            if (Optional.IsDefined(VirtualClusterGraduationProperties))
            {
                writer.WritePropertyName("virtualClusterGraduationProperties"u8);
                writer.WriteStringValue(VirtualClusterGraduationProperties);
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

        internal static KustoClusterData DeserializeKustoClusterData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            KustoSku sku = default;
            Optional<IList<string>> zones = default;
            Optional<ManagedServiceIdentity> identity = default;
            Optional<ETag> etag = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<KustoClusterState> state = default;
            Optional<KustoProvisioningState> provisioningState = default;
            Optional<Uri> uri = default;
            Optional<Uri> dataIngestionUri = default;
            Optional<string> stateReason = default;
            Optional<IList<KustoClusterTrustedExternalTenant>> trustedExternalTenants = default;
            Optional<OptimizedAutoscale> optimizedAutoscale = default;
            Optional<bool> enableDiskEncryption = default;
            Optional<bool> enableStreamingIngest = default;
            Optional<KustoClusterVirtualNetworkConfiguration> virtualNetworkConfiguration = default;
            Optional<KustoKeyVaultProperties> keyVaultProperties = default;
            Optional<bool> enablePurge = default;
            Optional<KustoLanguageExtensionList> languageExtensions = default;
            Optional<bool> enableDoubleEncryption = default;
            Optional<KustoClusterPublicNetworkAccess> publicNetworkAccess = default;
            Optional<IList<string>> allowedIPRangeList = default;
            Optional<KustoClusterEngineType> engineType = default;
            Optional<IList<AcceptedAudience>> acceptedAudiences = default;
            Optional<bool> enableAutoStop = default;
            Optional<KustoClusterNetworkAccessFlag> restrictOutboundNetworkAccess = default;
            Optional<IList<string>> allowedFqdnList = default;
            Optional<KustoClusterPublicIPType> publicIPType = default;
            Optional<string> virtualClusterGraduationProperties = default;
            Optional<IReadOnlyList<KustoPrivateEndpointConnectionData>> privateEndpointConnections = default;
            Optional<MigrationClusterProperties> migrationCluster = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    sku = KustoSku.DeserializeKustoSku(property.Value);
                    continue;
                }
                if (property.NameEquals("zones"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    zones = array;
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
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
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
                        if (property0.NameEquals("state"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            state = new KustoClusterState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new KustoProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("uri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            uri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("dataIngestionUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dataIngestionUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("stateReason"u8))
                        {
                            stateReason = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("trustedExternalTenants"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<KustoClusterTrustedExternalTenant> array = new List<KustoClusterTrustedExternalTenant>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(KustoClusterTrustedExternalTenant.DeserializeKustoClusterTrustedExternalTenant(item));
                            }
                            trustedExternalTenants = array;
                            continue;
                        }
                        if (property0.NameEquals("optimizedAutoscale"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            optimizedAutoscale = OptimizedAutoscale.DeserializeOptimizedAutoscale(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("enableDiskEncryption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableDiskEncryption = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableStreamingIngest"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableStreamingIngest = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualNetworkConfiguration = KustoClusterVirtualNetworkConfiguration.DeserializeKustoClusterVirtualNetworkConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("keyVaultProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            keyVaultProperties = KustoKeyVaultProperties.DeserializeKustoKeyVaultProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("enablePurge"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enablePurge = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("languageExtensions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            languageExtensions = KustoLanguageExtensionList.DeserializeKustoLanguageExtensionList(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("enableDoubleEncryption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableDoubleEncryption = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicNetworkAccess = new KustoClusterPublicNetworkAccess(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("allowedIpRangeList"u8))
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
                            allowedIPRangeList = array;
                            continue;
                        }
                        if (property0.NameEquals("engineType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            engineType = new KustoClusterEngineType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("acceptedAudiences"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AcceptedAudience> array = new List<AcceptedAudience>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AcceptedAudience.DeserializeAcceptedAudience(item));
                            }
                            acceptedAudiences = array;
                            continue;
                        }
                        if (property0.NameEquals("enableAutoStop"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableAutoStop = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("restrictOutboundNetworkAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            restrictOutboundNetworkAccess = new KustoClusterNetworkAccessFlag(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("allowedFqdnList"u8))
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
                            allowedFqdnList = array;
                            continue;
                        }
                        if (property0.NameEquals("publicIPType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicIPType = new KustoClusterPublicIPType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("virtualClusterGraduationProperties"u8))
                        {
                            virtualClusterGraduationProperties = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointConnections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<KustoPrivateEndpointConnectionData> array = new List<KustoPrivateEndpointConnectionData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(KustoPrivateEndpointConnectionData.DeserializeKustoPrivateEndpointConnectionData(item));
                            }
                            privateEndpointConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("migrationCluster"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            migrationCluster = MigrationClusterProperties.DeserializeMigrationClusterProperties(property0.Value);
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
            return new KustoClusterData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, sku, Optional.ToList(zones), identity, Optional.ToNullable(etag), Optional.ToNullable(state), Optional.ToNullable(provisioningState), uri.Value, dataIngestionUri.Value, stateReason.Value, Optional.ToList(trustedExternalTenants), optimizedAutoscale.Value, Optional.ToNullable(enableDiskEncryption), Optional.ToNullable(enableStreamingIngest), virtualNetworkConfiguration.Value, keyVaultProperties.Value, Optional.ToNullable(enablePurge), languageExtensions.Value, Optional.ToNullable(enableDoubleEncryption), Optional.ToNullable(publicNetworkAccess), Optional.ToList(allowedIPRangeList), Optional.ToNullable(engineType), Optional.ToList(acceptedAudiences), Optional.ToNullable(enableAutoStop), Optional.ToNullable(restrictOutboundNetworkAccess), Optional.ToList(allowedFqdnList), Optional.ToNullable(publicIPType), virtualClusterGraduationProperties.Value, Optional.ToList(privateEndpointConnections), migrationCluster.Value, rawData);
        }

        KustoClusterData IModelJsonSerializable<KustoClusterData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KustoClusterData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeKustoClusterData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<KustoClusterData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KustoClusterData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        KustoClusterData IModelSerializable<KustoClusterData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KustoClusterData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeKustoClusterData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="KustoClusterData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="KustoClusterData"/> to convert. </param>
        public static implicit operator RequestContent(KustoClusterData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="KustoClusterData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator KustoClusterData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeKustoClusterData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
