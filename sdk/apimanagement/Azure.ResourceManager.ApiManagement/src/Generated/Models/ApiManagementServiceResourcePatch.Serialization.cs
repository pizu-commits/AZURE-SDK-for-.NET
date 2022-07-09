// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ApiManagementServiceResourcePatch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                JsonSerializer.Serialize(writer, Identity);
            }
            if (Optional.IsCollectionDefined(Zones))
            {
                writer.WritePropertyName("zones");
                writer.WriteStartArray();
                foreach (var item in Zones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(NotificationSenderEmail))
            {
                writer.WritePropertyName("notificationSenderEmail");
                writer.WriteStringValue(NotificationSenderEmail);
            }
            if (Optional.IsCollectionDefined(HostnameConfigurations))
            {
                writer.WritePropertyName("hostnameConfigurations");
                writer.WriteStartArray();
                foreach (var item in HostnameConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PublicIPAddressId))
            {
                writer.WritePropertyName("publicIpAddressId");
                writer.WriteStringValue(PublicIPAddressId);
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess");
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsDefined(VirtualNetworkConfiguration))
            {
                writer.WritePropertyName("virtualNetworkConfiguration");
                writer.WriteObjectValue(VirtualNetworkConfiguration);
            }
            if (Optional.IsCollectionDefined(AdditionalLocations))
            {
                writer.WritePropertyName("additionalLocations");
                writer.WriteStartArray();
                foreach (var item in AdditionalLocations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(CustomProperties))
            {
                writer.WritePropertyName("customProperties");
                writer.WriteStartObject();
                foreach (var item in CustomProperties)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Certificates))
            {
                writer.WritePropertyName("certificates");
                writer.WriteStartArray();
                foreach (var item in Certificates)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EnableClientCertificate))
            {
                writer.WritePropertyName("enableClientCertificate");
                writer.WriteBooleanValue(EnableClientCertificate.Value);
            }
            if (Optional.IsDefined(DisableGateway))
            {
                writer.WritePropertyName("disableGateway");
                writer.WriteBooleanValue(DisableGateway.Value);
            }
            if (Optional.IsDefined(VirtualNetworkType))
            {
                writer.WritePropertyName("virtualNetworkType");
                writer.WriteStringValue(VirtualNetworkType.Value.ToString());
            }
            if (Optional.IsDefined(ApiVersionConstraint))
            {
                writer.WritePropertyName("apiVersionConstraint");
                writer.WriteObjectValue(ApiVersionConstraint);
            }
            if (Optional.IsDefined(Restore))
            {
                writer.WritePropertyName("restore");
                writer.WriteBooleanValue(Restore.Value);
            }
            if (Optional.IsCollectionDefined(PrivateEndpointConnections))
            {
                writer.WritePropertyName("privateEndpointConnections");
                writer.WriteStartArray();
                foreach (var item in PrivateEndpointConnections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PublisherEmail))
            {
                writer.WritePropertyName("publisherEmail");
                writer.WriteStringValue(PublisherEmail);
            }
            if (Optional.IsDefined(PublisherName))
            {
                writer.WritePropertyName("publisherName");
                writer.WriteStringValue(PublisherName);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ApiManagementServiceResourcePatch DeserializeApiManagementServiceResourcePatch(JsonElement element)
        {
            Optional<ApiManagementServiceSkuProperties> sku = default;
            Optional<ManagedServiceIdentity> identity = default;
            Optional<ETag> etag = default;
            Optional<IList<string>> zones = default;
            Optional<IDictionary<string, string>> tags = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> notificationSenderEmail = default;
            Optional<string> provisioningState = default;
            Optional<string> targetProvisioningState = default;
            Optional<DateTimeOffset> createdAtUtc = default;
            Optional<Uri> gatewayUrl = default;
            Optional<Uri> gatewayRegionalUrl = default;
            Optional<Uri> portalUrl = default;
            Optional<Uri> managementApiUrl = default;
            Optional<Uri> scmUrl = default;
            Optional<Uri> developerPortalUrl = default;
            Optional<IList<HostnameConfiguration>> hostnameConfigurations = default;
            Optional<IReadOnlyList<string>> publicIPAddresses = default;
            Optional<IReadOnlyList<string>> privateIPAddresses = default;
            Optional<string> publicIPAddressId = default;
            Optional<PublicNetworkAccess> publicNetworkAccess = default;
            Optional<VirtualNetworkConfiguration> virtualNetworkConfiguration = default;
            Optional<IList<AdditionalLocation>> additionalLocations = default;
            Optional<IDictionary<string, string>> customProperties = default;
            Optional<IList<CertificateConfiguration>> certificates = default;
            Optional<bool> enableClientCertificate = default;
            Optional<bool> disableGateway = default;
            Optional<VirtualNetworkType> virtualNetworkType = default;
            Optional<ApiVersionConstraint> apiVersionConstraint = default;
            Optional<bool> restore = default;
            Optional<IList<RemotePrivateEndpointConnectionWrapper>> privateEndpointConnections = default;
            Optional<PlatformVersion> platformVersion = default;
            Optional<string> publisherEmail = default;
            Optional<string> publisherName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sku = ApiManagementServiceSkuProperties.DeserializeApiManagementServiceSkuProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("identity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("zones"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
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
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
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
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("notificationSenderEmail"))
                        {
                            notificationSenderEmail = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("targetProvisioningState"))
                        {
                            targetProvisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createdAtUtc"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            createdAtUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("gatewayUrl"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                gatewayUrl = null;
                                continue;
                            }
                            gatewayUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("gatewayRegionalUrl"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                gatewayRegionalUrl = null;
                                continue;
                            }
                            gatewayRegionalUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("portalUrl"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                portalUrl = null;
                                continue;
                            }
                            portalUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("managementApiUrl"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                managementApiUrl = null;
                                continue;
                            }
                            managementApiUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("scmUrl"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                scmUrl = null;
                                continue;
                            }
                            scmUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("developerPortalUrl"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                developerPortalUrl = null;
                                continue;
                            }
                            developerPortalUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("hostnameConfigurations"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<HostnameConfiguration> array = new List<HostnameConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(HostnameConfiguration.DeserializeHostnameConfiguration(item));
                            }
                            hostnameConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("publicIPAddresses"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            publicIPAddresses = array;
                            continue;
                        }
                        if (property0.NameEquals("privateIPAddresses"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            privateIPAddresses = array;
                            continue;
                        }
                        if (property0.NameEquals("publicIpAddressId"))
                        {
                            publicIPAddressId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            publicNetworkAccess = new PublicNetworkAccess(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkConfiguration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            virtualNetworkConfiguration = VirtualNetworkConfiguration.DeserializeVirtualNetworkConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("additionalLocations"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<AdditionalLocation> array = new List<AdditionalLocation>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AdditionalLocation.DeserializeAdditionalLocation(item));
                            }
                            additionalLocations = array;
                            continue;
                        }
                        if (property0.NameEquals("customProperties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            customProperties = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("certificates"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<CertificateConfiguration> array = new List<CertificateConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(CertificateConfiguration.DeserializeCertificateConfiguration(item));
                            }
                            certificates = array;
                            continue;
                        }
                        if (property0.NameEquals("enableClientCertificate"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enableClientCertificate = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("disableGateway"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            disableGateway = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            virtualNetworkType = new VirtualNetworkType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("apiVersionConstraint"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            apiVersionConstraint = ApiVersionConstraint.DeserializeApiVersionConstraint(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("restore"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            restore = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointConnections"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<RemotePrivateEndpointConnectionWrapper> array = new List<RemotePrivateEndpointConnectionWrapper>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RemotePrivateEndpointConnectionWrapper.DeserializeRemotePrivateEndpointConnectionWrapper(item));
                            }
                            privateEndpointConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("platformVersion"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            platformVersion = new PlatformVersion(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("publisherEmail"))
                        {
                            publisherEmail = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publisherName"))
                        {
                            publisherName = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ApiManagementServiceResourcePatch(id, name, type, systemData.Value, sku.Value, identity, Optional.ToNullable(etag), Optional.ToList(zones), notificationSenderEmail.Value, provisioningState.Value, targetProvisioningState.Value, Optional.ToNullable(createdAtUtc), gatewayUrl.Value, gatewayRegionalUrl.Value, portalUrl.Value, managementApiUrl.Value, scmUrl.Value, developerPortalUrl.Value, Optional.ToList(hostnameConfigurations), Optional.ToList(publicIPAddresses), Optional.ToList(privateIPAddresses), publicIPAddressId.Value, Optional.ToNullable(publicNetworkAccess), virtualNetworkConfiguration.Value, Optional.ToList(additionalLocations), Optional.ToDictionary(customProperties), Optional.ToList(certificates), Optional.ToNullable(enableClientCertificate), Optional.ToNullable(disableGateway), Optional.ToNullable(virtualNetworkType), apiVersionConstraint.Value, Optional.ToNullable(restore), Optional.ToList(privateEndpointConnections), Optional.ToNullable(platformVersion), publisherEmail.Value, publisherName.Value, Optional.ToDictionary(tags));
        }
    }
}
