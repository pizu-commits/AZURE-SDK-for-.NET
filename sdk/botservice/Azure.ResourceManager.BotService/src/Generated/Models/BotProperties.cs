// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.BotService;

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> The parameters to provide for the Bot. </summary>
    public partial class BotProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BotProperties"/>. </summary>
        /// <param name="displayName"> The Name of the bot. </param>
        /// <param name="endpoint"> The bot's endpoint. </param>
        /// <param name="msaAppId"> Microsoft App Id for the bot. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="displayName"/> or <paramref name="msaAppId"/> is null. </exception>
        public BotProperties(string displayName, Uri endpoint, string msaAppId)
        {
            Argument.AssertNotNull(displayName, nameof(displayName));
            Argument.AssertNotNull(msaAppId, nameof(msaAppId));

            DisplayName = displayName;
            Endpoint = endpoint;
            AllSettings = new ChangeTrackingDictionary<string, string>();
            Parameters = new ChangeTrackingDictionary<string, string>();
            MsaAppId = msaAppId;
            ConfiguredChannels = new ChangeTrackingList<string>();
            EnabledChannels = new ChangeTrackingList<string>();
            LuisAppIds = new ChangeTrackingList<string>();
            PrivateEndpointConnections = new ChangeTrackingList<BotServicePrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of <see cref="BotProperties"/>. </summary>
        /// <param name="displayName"> The Name of the bot. </param>
        /// <param name="description"> The description of the bot. </param>
        /// <param name="iconUri"> The Icon Url of the bot. </param>
        /// <param name="endpoint"> The bot's endpoint. </param>
        /// <param name="endpointVersion"> The bot's endpoint version. </param>
        /// <param name="allSettings"> Contains resource all settings defined as key/value pairs. </param>
        /// <param name="parameters"> Contains resource parameters defined as key/value pairs. </param>
        /// <param name="manifestUri"> The bot's manifest url. </param>
        /// <param name="msaAppType"> Microsoft App Type for the bot. </param>
        /// <param name="msaAppId"> Microsoft App Id for the bot. </param>
        /// <param name="msaAppTenantId"> Microsoft App Tenant Id for the bot. </param>
        /// <param name="msaAppMSIResourceId"> Microsoft App Managed Identity Resource Id for the bot. </param>
        /// <param name="configuredChannels"> Collection of channels for which the bot is configured. </param>
        /// <param name="enabledChannels"> Collection of channels for which the bot is enabled. </param>
        /// <param name="developerAppInsightKey"> The Application Insights key. </param>
        /// <param name="developerAppInsightsApiKey"> The Application Insights Api Key. </param>
        /// <param name="developerAppInsightsApplicationId"> The Application Insights App Id. </param>
        /// <param name="luisAppIds"> Collection of LUIS App Ids. </param>
        /// <param name="luisKey"> The LUIS Key. </param>
        /// <param name="isCmekEnabled"> Whether Cmek is enabled. </param>
        /// <param name="cmekKeyVaultUri"> The CMK Url. </param>
        /// <param name="cmekEncryptionStatus"> The CMK encryption status. </param>
        /// <param name="tenantId"> The Tenant Id for the bot. </param>
        /// <param name="publicNetworkAccess"> Whether the bot is in an isolated network. </param>
        /// <param name="isStreamingSupported"> Whether the bot is streaming supported. </param>
        /// <param name="isDeveloperAppInsightsApiKeySet"> Whether the bot is developerAppInsightsApiKey set. </param>
        /// <param name="migrationToken"> Token used to migrate non Azure bot to azure subscription. </param>
        /// <param name="isLocalAuthDisabled"> Opt-out of local authentication and ensure only MSI and AAD can be used exclusively for authentication. </param>
        /// <param name="schemaTransformationVersion"> The channel schema transformation version for the bot. </param>
        /// <param name="storageResourceId"> The storage resourceId for the bot. </param>
        /// <param name="privateEndpointConnections"> List of Private Endpoint Connections configured for the bot. </param>
        /// <param name="openWithHint"> The hint to browser (e.g. protocol handler) on how to open the bot for authoring. </param>
        /// <param name="appPasswordHint"> The hint (e.g. keyVault secret resourceId) on how to fetch the app secret. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="publishingCredentials"> Publishing credentials of the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BotProperties(string displayName, string description, Uri iconUri, Uri endpoint, string endpointVersion, IDictionary<string, string> allSettings, IDictionary<string, string> parameters, Uri manifestUri, BotMsaAppType? msaAppType, string msaAppId, string msaAppTenantId, ResourceIdentifier msaAppMSIResourceId, IReadOnlyList<string> configuredChannels, IReadOnlyList<string> enabledChannels, string developerAppInsightKey, string developerAppInsightsApiKey, string developerAppInsightsApplicationId, IList<string> luisAppIds, string luisKey, bool? isCmekEnabled, Uri cmekKeyVaultUri, string cmekEncryptionStatus, Guid? tenantId, BotServicePublicNetworkAccess? publicNetworkAccess, bool? isStreamingSupported, bool? isDeveloperAppInsightsApiKeySet, string migrationToken, bool? isLocalAuthDisabled, string schemaTransformationVersion, ResourceIdentifier storageResourceId, IReadOnlyList<BotServicePrivateEndpointConnectionData> privateEndpointConnections, string openWithHint, string appPasswordHint, string provisioningState, string publishingCredentials, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DisplayName = displayName;
            Description = description;
            IconUri = iconUri;
            Endpoint = endpoint;
            EndpointVersion = endpointVersion;
            AllSettings = allSettings;
            Parameters = parameters;
            ManifestUri = manifestUri;
            MsaAppType = msaAppType;
            MsaAppId = msaAppId;
            MsaAppTenantId = msaAppTenantId;
            MsaAppMSIResourceId = msaAppMSIResourceId;
            ConfiguredChannels = configuredChannels;
            EnabledChannels = enabledChannels;
            DeveloperAppInsightKey = developerAppInsightKey;
            DeveloperAppInsightsApiKey = developerAppInsightsApiKey;
            DeveloperAppInsightsApplicationId = developerAppInsightsApplicationId;
            LuisAppIds = luisAppIds;
            LuisKey = luisKey;
            IsCmekEnabled = isCmekEnabled;
            CmekKeyVaultUri = cmekKeyVaultUri;
            CmekEncryptionStatus = cmekEncryptionStatus;
            TenantId = tenantId;
            PublicNetworkAccess = publicNetworkAccess;
            IsStreamingSupported = isStreamingSupported;
            IsDeveloperAppInsightsApiKeySet = isDeveloperAppInsightsApiKeySet;
            MigrationToken = migrationToken;
            IsLocalAuthDisabled = isLocalAuthDisabled;
            SchemaTransformationVersion = schemaTransformationVersion;
            StorageResourceId = storageResourceId;
            PrivateEndpointConnections = privateEndpointConnections;
            OpenWithHint = openWithHint;
            AppPasswordHint = appPasswordHint;
            ProvisioningState = provisioningState;
            PublishingCredentials = publishingCredentials;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BotProperties"/> for deserialization. </summary>
        internal BotProperties()
        {
        }

        /// <summary> The Name of the bot. </summary>
        public string DisplayName { get; set; }
        /// <summary> The description of the bot. </summary>
        public string Description { get; set; }
        /// <summary> The Icon Url of the bot. </summary>
        public Uri IconUri { get; set; }
        /// <summary> The bot's endpoint. </summary>
        public Uri Endpoint { get; set; }
        /// <summary> The bot's endpoint version. </summary>
        public string EndpointVersion { get; }
        /// <summary> Contains resource all settings defined as key/value pairs. </summary>
        public IDictionary<string, string> AllSettings { get; }
        /// <summary> Contains resource parameters defined as key/value pairs. </summary>
        public IDictionary<string, string> Parameters { get; }
        /// <summary> The bot's manifest url. </summary>
        public Uri ManifestUri { get; set; }
        /// <summary> Microsoft App Type for the bot. </summary>
        public BotMsaAppType? MsaAppType { get; set; }
        /// <summary> Microsoft App Id for the bot. </summary>
        public string MsaAppId { get; set; }
        /// <summary> Microsoft App Tenant Id for the bot. </summary>
        public string MsaAppTenantId { get; set; }
        /// <summary> Microsoft App Managed Identity Resource Id for the bot. </summary>
        public ResourceIdentifier MsaAppMSIResourceId { get; set; }
        /// <summary> Collection of channels for which the bot is configured. </summary>
        public IReadOnlyList<string> ConfiguredChannels { get; }
        /// <summary> Collection of channels for which the bot is enabled. </summary>
        public IReadOnlyList<string> EnabledChannels { get; }
        /// <summary> The Application Insights key. </summary>
        public string DeveloperAppInsightKey { get; set; }
        /// <summary> The Application Insights Api Key. </summary>
        public string DeveloperAppInsightsApiKey { get; set; }
        /// <summary> The Application Insights App Id. </summary>
        public string DeveloperAppInsightsApplicationId { get; set; }
        /// <summary> Collection of LUIS App Ids. </summary>
        public IList<string> LuisAppIds { get; }
        /// <summary> The LUIS Key. </summary>
        public string LuisKey { get; set; }
        /// <summary> Whether Cmek is enabled. </summary>
        public bool? IsCmekEnabled { get; set; }
        /// <summary> The CMK Url. </summary>
        public Uri CmekKeyVaultUri { get; set; }
        /// <summary> The CMK encryption status. </summary>
        public string CmekEncryptionStatus { get; }
        /// <summary> The Tenant Id for the bot. </summary>
        public Guid? TenantId { get; set; }
        /// <summary> Whether the bot is in an isolated network. </summary>
        public BotServicePublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> Whether the bot is streaming supported. </summary>
        public bool? IsStreamingSupported { get; set; }
        /// <summary> Whether the bot is developerAppInsightsApiKey set. </summary>
        public bool? IsDeveloperAppInsightsApiKeySet { get; }
        /// <summary> Token used to migrate non Azure bot to azure subscription. </summary>
        public string MigrationToken { get; }
        /// <summary> Opt-out of local authentication and ensure only MSI and AAD can be used exclusively for authentication. </summary>
        public bool? IsLocalAuthDisabled { get; set; }
        /// <summary> The channel schema transformation version for the bot. </summary>
        public string SchemaTransformationVersion { get; set; }
        /// <summary> The storage resourceId for the bot. </summary>
        public ResourceIdentifier StorageResourceId { get; set; }
        /// <summary> List of Private Endpoint Connections configured for the bot. </summary>
        public IReadOnlyList<BotServicePrivateEndpointConnectionData> PrivateEndpointConnections { get; }
        /// <summary> The hint to browser (e.g. protocol handler) on how to open the bot for authoring. </summary>
        public string OpenWithHint { get; set; }
        /// <summary> The hint (e.g. keyVault secret resourceId) on how to fetch the app secret. </summary>
        public string AppPasswordHint { get; set; }
        /// <summary> Provisioning state of the resource. </summary>
        public string ProvisioningState { get; }
        /// <summary> Publishing credentials of the resource. </summary>
        public string PublishingCredentials { get; set; }
    }
}
