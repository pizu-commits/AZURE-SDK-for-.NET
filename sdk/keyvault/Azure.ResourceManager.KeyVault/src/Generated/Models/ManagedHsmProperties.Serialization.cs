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

namespace Azure.ResourceManager.KeyVault.Models
{
    public partial class ManagedHsmProperties : IUtf8JsonSerializable, IModelJsonSerializable<ManagedHsmProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ManagedHsmProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ManagedHsmProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
            }
            if (Optional.IsCollectionDefined(InitialAdminObjectIds))
            {
                writer.WritePropertyName("initialAdminObjectIds"u8);
                writer.WriteStartArray();
                foreach (var item in InitialAdminObjectIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EnableSoftDelete))
            {
                writer.WritePropertyName("enableSoftDelete"u8);
                writer.WriteBooleanValue(EnableSoftDelete.Value);
            }
            if (Optional.IsDefined(SoftDeleteRetentionInDays))
            {
                writer.WritePropertyName("softDeleteRetentionInDays"u8);
                writer.WriteNumberValue(SoftDeleteRetentionInDays.Value);
            }
            if (Optional.IsDefined(EnablePurgeProtection))
            {
                writer.WritePropertyName("enablePurgeProtection"u8);
                writer.WriteBooleanValue(EnablePurgeProtection.Value);
            }
            if (Optional.IsDefined(CreateMode))
            {
                writer.WritePropertyName("createMode"u8);
                writer.WriteStringValue(CreateMode.Value.ToSerialString());
            }
            if (Optional.IsDefined(NetworkRuleSet))
            {
                writer.WritePropertyName("networkAcls"u8);
                if (NetworkRuleSet is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ManagedHsmNetworkRuleSet>)NetworkRuleSet).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(Regions))
            {
                writer.WritePropertyName("regions"u8);
                writer.WriteStartArray();
                foreach (var item in Regions)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ManagedHsmGeoReplicatedRegion>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
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

        internal static ManagedHsmProperties DeserializeManagedHsmProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> tenantId = default;
            Optional<IList<string>> initialAdminObjectIds = default;
            Optional<Uri> hsmUri = default;
            Optional<bool> enableSoftDelete = default;
            Optional<int> softDeleteRetentionInDays = default;
            Optional<bool> enablePurgeProtection = default;
            Optional<ManagedHsmCreateMode> createMode = default;
            Optional<string> statusMessage = default;
            Optional<ManagedHsmProvisioningState> provisioningState = default;
            Optional<ManagedHsmNetworkRuleSet> networkAcls = default;
            Optional<IList<ManagedHsmGeoReplicatedRegion>> regions = default;
            Optional<IReadOnlyList<ManagedHsmPrivateEndpointConnectionItemData>> privateEndpointConnections = default;
            Optional<ManagedHsmPublicNetworkAccess> publicNetworkAccess = default;
            Optional<DateTimeOffset> scheduledPurgeDate = default;
            Optional<ManagedHSMSecurityDomainProperties> securityDomainProperties = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("initialAdminObjectIds"u8))
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
                    initialAdminObjectIds = array;
                    continue;
                }
                if (property.NameEquals("hsmUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hsmUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("enableSoftDelete"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableSoftDelete = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("softDeleteRetentionInDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    softDeleteRetentionInDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("enablePurgeProtection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enablePurgeProtection = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("createMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createMode = property.Value.GetString().ToManagedHsmCreateMode();
                    continue;
                }
                if (property.NameEquals("statusMessage"u8))
                {
                    statusMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ManagedHsmProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("networkAcls"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkAcls = ManagedHsmNetworkRuleSet.DeserializeManagedHsmNetworkRuleSet(property.Value);
                    continue;
                }
                if (property.NameEquals("regions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManagedHsmGeoReplicatedRegion> array = new List<ManagedHsmGeoReplicatedRegion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedHsmGeoReplicatedRegion.DeserializeManagedHsmGeoReplicatedRegion(item));
                    }
                    regions = array;
                    continue;
                }
                if (property.NameEquals("privateEndpointConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManagedHsmPrivateEndpointConnectionItemData> array = new List<ManagedHsmPrivateEndpointConnectionItemData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedHsmPrivateEndpointConnectionItemData.DeserializeManagedHsmPrivateEndpointConnectionItemData(item));
                    }
                    privateEndpointConnections = array;
                    continue;
                }
                if (property.NameEquals("publicNetworkAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicNetworkAccess = new ManagedHsmPublicNetworkAccess(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("scheduledPurgeDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scheduledPurgeDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("securityDomainProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    securityDomainProperties = ManagedHSMSecurityDomainProperties.DeserializeManagedHSMSecurityDomainProperties(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ManagedHsmProperties(Optional.ToNullable(tenantId), Optional.ToList(initialAdminObjectIds), hsmUri.Value, Optional.ToNullable(enableSoftDelete), Optional.ToNullable(softDeleteRetentionInDays), Optional.ToNullable(enablePurgeProtection), Optional.ToNullable(createMode), statusMessage.Value, Optional.ToNullable(provisioningState), networkAcls.Value, Optional.ToList(regions), Optional.ToList(privateEndpointConnections), Optional.ToNullable(publicNetworkAccess), Optional.ToNullable(scheduledPurgeDate), securityDomainProperties.Value, rawData);
        }

        ManagedHsmProperties IModelJsonSerializable<ManagedHsmProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedHsmProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ManagedHsmProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ManagedHsmProperties IModelSerializable<ManagedHsmProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeManagedHsmProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ManagedHsmProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ManagedHsmProperties"/> to convert. </param>
        public static implicit operator RequestContent(ManagedHsmProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ManagedHsmProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ManagedHsmProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeManagedHsmProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
