// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppConfiguration.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmAppConfigurationModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="AppConfiguration.AppConfigurationStoreData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> The managed identity information, if configured. </param>
        /// <param name="skuName"> The sku of the configuration store. </param>
        /// <param name="provisioningState"> The provisioning state of the configuration store. </param>
        /// <param name="createdOn"> The creation date of configuration store. </param>
        /// <param name="endpoint"> The DNS endpoint where the configuration store API will be available. </param>
        /// <param name="encryptionKeyVaultProperties"> The encryption settings of the configuration store. </param>
        /// <param name="privateEndpointConnections"> The list of private endpoint connections that are set up for this resource. </param>
        /// <param name="publicNetworkAccess"> Control permission for data plane traffic coming from public networks while private endpoint is enabled. </param>
        /// <param name="disableLocalAuth"> Disables all authentication methods other than AAD authentication. </param>
        /// <param name="softDeleteRetentionInDays"> The amount of time in days that the configuration store will be retained when it is soft deleted. </param>
        /// <param name="enablePurgeProtection"> Property specifying whether protection against purge is enabled for this configuration store. </param>
        /// <param name="createMode"> Indicates whether the configuration store need to be recovered. </param>
        /// <returns> A new <see cref="AppConfiguration.AppConfigurationStoreData"/> instance for mocking. </returns>
        public static AppConfigurationStoreData AppConfigurationStoreData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, ManagedServiceIdentity identity = null, string skuName = null, AppConfigurationProvisioningState? provisioningState = null, DateTimeOffset? createdOn = null, string endpoint = null, AppConfigurationKeyVaultProperties encryptionKeyVaultProperties = null, IEnumerable<AppConfigurationPrivateEndpointConnectionReference> privateEndpointConnections = null, AppConfigurationPublicNetworkAccess? publicNetworkAccess = null, bool? disableLocalAuth = null, int? softDeleteRetentionInDays = null, bool? enablePurgeProtection = null, AppConfigurationCreateMode? createMode = null)
        {
            tags ??= new Dictionary<string, string>();
            privateEndpointConnections ??= new List<AppConfigurationPrivateEndpointConnectionReference>();

            return new AppConfigurationStoreData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                identity,
                skuName != null ? new AppConfigurationSku(skuName, serializedAdditionalRawData: null) : null,
                provisioningState,
                createdOn,
                endpoint,
                encryptionKeyVaultProperties != null ? new AppConfigurationStoreEncryptionProperties(encryptionKeyVaultProperties, serializedAdditionalRawData: null) : null,
                privateEndpointConnections?.ToList(),
                publicNetworkAccess,
                disableLocalAuth,
                softDeleteRetentionInDays,
                enablePurgeProtection,
                createMode,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.AppConfigurationPrivateEndpointConnectionReference"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> The provisioning status of the private endpoint connection. </param>
        /// <param name="privateEndpointId"> The resource of private endpoint. </param>
        /// <param name="connectionState"> A collection of information about the state of the connection between service consumer and provider. </param>
        /// <returns> A new <see cref="Models.AppConfigurationPrivateEndpointConnectionReference"/> instance for mocking. </returns>
        public static AppConfigurationPrivateEndpointConnectionReference AppConfigurationPrivateEndpointConnectionReference(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, AppConfigurationProvisioningState? provisioningState = null, ResourceIdentifier privateEndpointId = null, AppConfigurationPrivateLinkServiceConnectionState connectionState = null)
        {
            return new AppConfigurationPrivateEndpointConnectionReference(
                id,
                name,
                resourceType,
                systemData,
                provisioningState,
                privateEndpointId != null ? ResourceManagerModelFactory.WritableSubResource(privateEndpointId) : null,
                connectionState,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.AppConfigurationPrivateLinkServiceConnectionState"/>. </summary>
        /// <param name="status"> The private link service connection status. </param>
        /// <param name="description"> The private link service connection description. </param>
        /// <param name="actionsRequired"> Any action that is required beyond basic workflow (approve/ reject/ disconnect). </param>
        /// <returns> A new <see cref="Models.AppConfigurationPrivateLinkServiceConnectionState"/> instance for mocking. </returns>
        public static AppConfigurationPrivateLinkServiceConnectionState AppConfigurationPrivateLinkServiceConnectionState(AppConfigurationPrivateLinkServiceConnectionStatus? status = null, string description = null, AppConfigurationActionsRequired? actionsRequired = null)
        {
            return new AppConfigurationPrivateLinkServiceConnectionState(status, description, actionsRequired, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.AppConfigurationNameAvailabilityResult"/>. </summary>
        /// <param name="isNameAvailable"> The value indicating whether the resource name is available. </param>
        /// <param name="message"> If any, the error message that provides more detail for the reason that the name is not available. </param>
        /// <param name="reason"> If any, the reason that the name is not available. </param>
        /// <returns> A new <see cref="Models.AppConfigurationNameAvailabilityResult"/> instance for mocking. </returns>
        public static AppConfigurationNameAvailabilityResult AppConfigurationNameAvailabilityResult(bool? isNameAvailable = null, string message = null, string reason = null)
        {
            return new AppConfigurationNameAvailabilityResult(isNameAvailable, message, reason, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.AppConfigurationStoreApiKey"/>. </summary>
        /// <param name="id"> The key ID. </param>
        /// <param name="name"> A name for the key describing its usage. </param>
        /// <param name="value"> The value of the key that is used for authentication purposes. </param>
        /// <param name="connectionString"> A connection string that can be used by supporting clients for authentication. </param>
        /// <param name="lastModifiedOn"> The last time any of the key's properties were modified. </param>
        /// <param name="isReadOnly"> Whether this key can only be used for read operations. </param>
        /// <returns> A new <see cref="Models.AppConfigurationStoreApiKey"/> instance for mocking. </returns>
        public static AppConfigurationStoreApiKey AppConfigurationStoreApiKey(string id = null, string name = null, string value = null, string connectionString = null, DateTimeOffset? lastModifiedOn = null, bool? isReadOnly = null)
        {
            return new AppConfigurationStoreApiKey(
                id,
                name,
                value,
                connectionString,
                lastModifiedOn,
                isReadOnly,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="AppConfiguration.AppConfigurationPrivateEndpointConnectionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> The provisioning status of the private endpoint connection. </param>
        /// <param name="privateEndpointId"> The resource of private endpoint. </param>
        /// <param name="connectionState"> A collection of information about the state of the connection between service consumer and provider. </param>
        /// <returns> A new <see cref="AppConfiguration.AppConfigurationPrivateEndpointConnectionData"/> instance for mocking. </returns>
        public static AppConfigurationPrivateEndpointConnectionData AppConfigurationPrivateEndpointConnectionData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, AppConfigurationProvisioningState? provisioningState = null, ResourceIdentifier privateEndpointId = null, AppConfigurationPrivateLinkServiceConnectionState connectionState = null)
        {
            return new AppConfigurationPrivateEndpointConnectionData(
                id,
                name,
                resourceType,
                systemData,
                provisioningState,
                privateEndpointId != null ? ResourceManagerModelFactory.WritableSubResource(privateEndpointId) : null,
                connectionState,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="AppConfiguration.AppConfigurationPrivateLinkResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="groupId"> The private link resource group id. </param>
        /// <param name="requiredMembers"> The private link resource required member names. </param>
        /// <param name="requiredZoneNames"> The list of required DNS zone names of the private link resource. </param>
        /// <returns> A new <see cref="AppConfiguration.AppConfigurationPrivateLinkResourceData"/> instance for mocking. </returns>
        public static AppConfigurationPrivateLinkResourceData AppConfigurationPrivateLinkResourceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string groupId = null, IEnumerable<string> requiredMembers = null, IEnumerable<string> requiredZoneNames = null)
        {
            requiredMembers ??= new List<string>();
            requiredZoneNames ??= new List<string>();

            return new AppConfigurationPrivateLinkResourceData(
                id,
                name,
                resourceType,
                systemData,
                groupId,
                requiredMembers?.ToList(),
                requiredZoneNames?.ToList(),
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="AppConfiguration.AppConfigurationKeyValueData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="key">
        /// The primary identifier of a key-value.
        /// The key is used in unison with the label to uniquely identify a key-value.
        /// </param>
        /// <param name="label">
        /// A value used to group key-values.
        /// The label is used in unison with the key to uniquely identify a key-value.
        /// </param>
        /// <param name="value"> The value of the key-value. </param>
        /// <param name="contentType">
        /// The content type of the key-value's value.
        /// Providing a proper content-type can enable transformations of values when they are retrieved by applications.
        /// </param>
        /// <param name="eTag"> An ETag indicating the state of a key-value within a configuration store. </param>
        /// <param name="lastModifiedOn"> The last time a modifying operation was performed on the given key-value. </param>
        /// <param name="isLocked">
        /// A value indicating whether the key-value is locked.
        /// A locked key-value may not be modified until it is unlocked.
        /// </param>
        /// <param name="tags"> A dictionary of tags that can help identify what a key-value may be applicable for. </param>
        /// <returns> A new <see cref="AppConfiguration.AppConfigurationKeyValueData"/> instance for mocking. </returns>
        public static AppConfigurationKeyValueData AppConfigurationKeyValueData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string key = null, string label = null, string value = null, string contentType = null, ETag? eTag = null, DateTimeOffset? lastModifiedOn = null, bool? isLocked = null, IDictionary<string, string> tags = null)
        {
            tags ??= new Dictionary<string, string>();

            return new AppConfigurationKeyValueData(
                id,
                name,
                resourceType,
                systemData,
                key,
                label,
                value,
                contentType,
                eTag,
                lastModifiedOn,
                isLocked,
                tags,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="AppConfiguration.DeletedAppConfigurationStoreData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="configurationStoreId"> The resource id of the original configuration store. </param>
        /// <param name="location"> The location of the original configuration store. </param>
        /// <param name="deletedOn"> The deleted date. </param>
        /// <param name="scheduledPurgeOn"> The scheduled purged date. </param>
        /// <param name="tags"> Tags of the original configuration store. </param>
        /// <param name="isPurgeProtectionEnabled"> Purge protection status of the original configuration store. </param>
        /// <returns> A new <see cref="AppConfiguration.DeletedAppConfigurationStoreData"/> instance for mocking. </returns>
        public static DeletedAppConfigurationStoreData DeletedAppConfigurationStoreData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ResourceIdentifier configurationStoreId = null, AzureLocation? location = null, DateTimeOffset? deletedOn = null, DateTimeOffset? scheduledPurgeOn = null, IReadOnlyDictionary<string, string> tags = null, bool? isPurgeProtectionEnabled = null)
        {
            tags ??= new Dictionary<string, string>();

            return new DeletedAppConfigurationStoreData(
                id,
                name,
                resourceType,
                systemData,
                configurationStoreId,
                location,
                deletedOn,
                scheduledPurgeOn,
                tags,
                isPurgeProtectionEnabled,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="AppConfiguration.AppConfigurationReplicaData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> The location of the replica. </param>
        /// <param name="endpoint"> The URI of the replica where the replica API will be available. </param>
        /// <param name="provisioningState"> The provisioning state of the replica. </param>
        /// <returns> A new <see cref="AppConfiguration.AppConfigurationReplicaData"/> instance for mocking. </returns>
        public static AppConfigurationReplicaData AppConfigurationReplicaData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, AzureLocation? location = null, string endpoint = null, AppConfigurationReplicaProvisioningState? provisioningState = null)
        {
            return new AppConfigurationReplicaData(
                id,
                name,
                resourceType,
                systemData,
                location,
                endpoint,
                provisioningState,
                serializedAdditionalRawData: null);
        }
    }
}
