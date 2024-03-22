// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ApiManagementServicePatch : IUtf8JsonSerializable, IJsonModel<ApiManagementServicePatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApiManagementServicePatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ApiManagementServicePatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementServicePatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApiManagementServicePatch)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue<ApiManagementServiceSkuProperties>(Sku, options);
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
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
            if (Optional.IsDefined(NotificationSenderEmail))
            {
                writer.WritePropertyName("notificationSenderEmail"u8);
                writer.WriteStringValue(NotificationSenderEmail);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (options.Format != "W" && Optional.IsDefined(TargetProvisioningState))
            {
                writer.WritePropertyName("targetProvisioningState"u8);
                writer.WriteStringValue(TargetProvisioningState);
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedAtUtc))
            {
                writer.WritePropertyName("createdAtUtc"u8);
                writer.WriteStringValue(CreatedAtUtc.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(GatewayUri))
            {
                writer.WritePropertyName("gatewayUrl"u8);
                writer.WriteStringValue(GatewayUri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(GatewayRegionalUri))
            {
                writer.WritePropertyName("gatewayRegionalUrl"u8);
                writer.WriteStringValue(GatewayRegionalUri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(PortalUri))
            {
                writer.WritePropertyName("portalUrl"u8);
                writer.WriteStringValue(PortalUri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(ManagementApiUri))
            {
                writer.WritePropertyName("managementApiUrl"u8);
                writer.WriteStringValue(ManagementApiUri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(ScmUri))
            {
                writer.WritePropertyName("scmUrl"u8);
                writer.WriteStringValue(ScmUri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(DeveloperPortalUri))
            {
                writer.WritePropertyName("developerPortalUrl"u8);
                writer.WriteStringValue(DeveloperPortalUri.AbsoluteUri);
            }
            if (Optional.IsCollectionDefined(HostnameConfigurations))
            {
                writer.WritePropertyName("hostnameConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in HostnameConfigurations)
                {
                    writer.WriteObjectValue<HostnameConfiguration>(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(PublicIPAddresses))
            {
                writer.WritePropertyName("publicIPAddresses"u8);
                writer.WriteStartArray();
                foreach (var item in PublicIPAddresses)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(PrivateIPAddresses))
            {
                writer.WritePropertyName("privateIPAddresses"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateIPAddresses)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PublicIPAddressId))
            {
                writer.WritePropertyName("publicIpAddressId"u8);
                writer.WriteStringValue(PublicIPAddressId);
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsDefined(VirtualNetworkConfiguration))
            {
                writer.WritePropertyName("virtualNetworkConfiguration"u8);
                writer.WriteObjectValue<VirtualNetworkConfiguration>(VirtualNetworkConfiguration, options);
            }
            if (Optional.IsCollectionDefined(AdditionalLocations))
            {
                writer.WritePropertyName("additionalLocations"u8);
                writer.WriteStartArray();
                foreach (var item in AdditionalLocations)
                {
                    writer.WriteObjectValue<AdditionalLocation>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(CustomProperties))
            {
                writer.WritePropertyName("customProperties"u8);
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
                writer.WritePropertyName("certificates"u8);
                writer.WriteStartArray();
                foreach (var item in Certificates)
                {
                    writer.WriteObjectValue<CertificateConfiguration>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EnableClientCertificate))
            {
                writer.WritePropertyName("enableClientCertificate"u8);
                writer.WriteBooleanValue(EnableClientCertificate.Value);
            }
            if (Optional.IsDefined(DisableGateway))
            {
                writer.WritePropertyName("disableGateway"u8);
                writer.WriteBooleanValue(DisableGateway.Value);
            }
            if (Optional.IsDefined(VirtualNetworkType))
            {
                writer.WritePropertyName("virtualNetworkType"u8);
                writer.WriteStringValue(VirtualNetworkType.Value.ToString());
            }
            if (Optional.IsDefined(ApiVersionConstraint))
            {
                writer.WritePropertyName("apiVersionConstraint"u8);
                writer.WriteObjectValue<ApiVersionConstraint>(ApiVersionConstraint, options);
            }
            if (Optional.IsDefined(Restore))
            {
                writer.WritePropertyName("restore"u8);
                writer.WriteBooleanValue(Restore.Value);
            }
            if (Optional.IsCollectionDefined(PrivateEndpointConnections))
            {
                writer.WritePropertyName("privateEndpointConnections"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateEndpointConnections)
                {
                    writer.WriteObjectValue<RemotePrivateEndpointConnectionWrapper>(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(PlatformVersion))
            {
                writer.WritePropertyName("platformVersion"u8);
                writer.WriteStringValue(PlatformVersion.Value.ToString());
            }
            if (Optional.IsDefined(PublisherEmail))
            {
                writer.WritePropertyName("publisherEmail"u8);
                writer.WriteStringValue(PublisherEmail);
            }
            if (Optional.IsDefined(PublisherName))
            {
                writer.WritePropertyName("publisherName"u8);
                writer.WriteStringValue(PublisherName);
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

        ApiManagementServicePatch IJsonModel<ApiManagementServicePatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementServicePatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApiManagementServicePatch)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApiManagementServicePatch(document.RootElement, options);
        }

        internal static ApiManagementServicePatch DeserializeApiManagementServicePatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ApiManagementServiceSkuProperties sku = default;
            ManagedServiceIdentity identity = default;
            ETag? etag = default;
            IList<string> zones = default;
            IDictionary<string, string> tags = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string notificationSenderEmail = default;
            string provisioningState = default;
            string targetProvisioningState = default;
            DateTimeOffset? createdAtUtc = default;
            Uri gatewayUri = default;
            Uri gatewayRegionalUri = default;
            Uri portalUri = default;
            Uri managementApiUri = default;
            Uri scmUri = default;
            Uri developerPortalUri = default;
            IList<HostnameConfiguration> hostnameConfigurations = default;
            IReadOnlyList<IPAddress> publicIPAddresses = default;
            IReadOnlyList<IPAddress> privateIPAddresses = default;
            ResourceIdentifier publicIPAddressId = default;
            PublicNetworkAccess? publicNetworkAccess = default;
            VirtualNetworkConfiguration virtualNetworkConfiguration = default;
            IList<AdditionalLocation> additionalLocations = default;
            IDictionary<string, string> customProperties = default;
            IList<CertificateConfiguration> certificates = default;
            bool? enableClientCertificate = default;
            bool? disableGateway = default;
            VirtualNetworkType? virtualNetworkType = default;
            ApiVersionConstraint apiVersionConstraint = default;
            bool? restore = default;
            IList<RemotePrivateEndpointConnectionWrapper> privateEndpointConnections = default;
            PlatformVersion? platformVersion = default;
            string publisherEmail = default;
            string publisherName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = ApiManagementServiceSkuProperties.DeserializeApiManagementServiceSkuProperties(property.Value, options);
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
                        if (property0.NameEquals("notificationSenderEmail"u8))
                        {
                            notificationSenderEmail = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("targetProvisioningState"u8))
                        {
                            targetProvisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createdAtUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdAtUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("gatewayUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            gatewayUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("gatewayRegionalUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            gatewayRegionalUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("portalUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            portalUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("managementApiUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            managementApiUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("scmUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            scmUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("developerPortalUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            developerPortalUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("hostnameConfigurations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<HostnameConfiguration> array = new List<HostnameConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(HostnameConfiguration.DeserializeHostnameConfiguration(item, options));
                            }
                            hostnameConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("publicIPAddresses"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<IPAddress> array = new List<IPAddress>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(IPAddress.Parse(item.GetString()));
                                }
                            }
                            publicIPAddresses = array;
                            continue;
                        }
                        if (property0.NameEquals("privateIPAddresses"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<IPAddress> array = new List<IPAddress>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(IPAddress.Parse(item.GetString()));
                                }
                            }
                            privateIPAddresses = array;
                            continue;
                        }
                        if (property0.NameEquals("publicIpAddressId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicIPAddressId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicNetworkAccess = new PublicNetworkAccess(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualNetworkConfiguration = VirtualNetworkConfiguration.DeserializeVirtualNetworkConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("additionalLocations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AdditionalLocation> array = new List<AdditionalLocation>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AdditionalLocation.DeserializeAdditionalLocation(item, options));
                            }
                            additionalLocations = array;
                            continue;
                        }
                        if (property0.NameEquals("customProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
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
                        if (property0.NameEquals("certificates"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<CertificateConfiguration> array = new List<CertificateConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(CertificateConfiguration.DeserializeCertificateConfiguration(item, options));
                            }
                            certificates = array;
                            continue;
                        }
                        if (property0.NameEquals("enableClientCertificate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableClientCertificate = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("disableGateway"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            disableGateway = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualNetworkType = new VirtualNetworkType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("apiVersionConstraint"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            apiVersionConstraint = ApiVersionConstraint.DeserializeApiVersionConstraint(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("restore"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            restore = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointConnections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<RemotePrivateEndpointConnectionWrapper> array = new List<RemotePrivateEndpointConnectionWrapper>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RemotePrivateEndpointConnectionWrapper.DeserializeRemotePrivateEndpointConnectionWrapper(item, options));
                            }
                            privateEndpointConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("platformVersion"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            platformVersion = new PlatformVersion(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("publisherEmail"u8))
                        {
                            publisherEmail = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publisherName"u8))
                        {
                            publisherName = property0.Value.GetString();
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
            return new ApiManagementServicePatch(
                id,
                name,
                type,
                systemData,
                sku,
                identity,
                etag,
                zones ?? new ChangeTrackingList<string>(),
                notificationSenderEmail,
                provisioningState,
                targetProvisioningState,
                createdAtUtc,
                gatewayUri,
                gatewayRegionalUri,
                portalUri,
                managementApiUri,
                scmUri,
                developerPortalUri,
                hostnameConfigurations ?? new ChangeTrackingList<HostnameConfiguration>(),
                publicIPAddresses ?? new ChangeTrackingList<IPAddress>(),
                privateIPAddresses ?? new ChangeTrackingList<IPAddress>(),
                publicIPAddressId,
                publicNetworkAccess,
                virtualNetworkConfiguration,
                additionalLocations ?? new ChangeTrackingList<AdditionalLocation>(),
                customProperties ?? new ChangeTrackingDictionary<string, string>(),
                certificates ?? new ChangeTrackingList<CertificateConfiguration>(),
                enableClientCertificate,
                disableGateway,
                virtualNetworkType,
                apiVersionConstraint,
                restore,
                privateEndpointConnections ?? new ChangeTrackingList<RemotePrivateEndpointConnectionWrapper>(),
                platformVersion,
                publisherEmail,
                publisherName,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApiManagementServicePatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementServicePatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ApiManagementServicePatch)} does not support writing '{options.Format}' format.");
            }
        }

        ApiManagementServicePatch IPersistableModel<ApiManagementServicePatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementServicePatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeApiManagementServicePatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApiManagementServicePatch)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApiManagementServicePatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
