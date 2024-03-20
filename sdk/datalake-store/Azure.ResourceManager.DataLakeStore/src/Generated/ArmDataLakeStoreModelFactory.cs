// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataLakeStore.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmDataLakeStoreModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Models.DataLakeStoreAccountBasicData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="accountId"> The unique identifier associated with this Data Lake Store account. </param>
        /// <param name="provisioningState"> The provisioning status of the Data Lake Store account. </param>
        /// <param name="state"> The state of the Data Lake Store account. </param>
        /// <param name="createdOn"> The account creation time. </param>
        /// <param name="lastModifiedOn"> The account last modified time. </param>
        /// <param name="endpoint"> The full CName endpoint for this account. </param>
        /// <param name="location"> The resource location. </param>
        /// <param name="tags"> The resource tags. </param>
        /// <returns> A new <see cref="Models.DataLakeStoreAccountBasicData"/> instance for mocking. </returns>
        public static DataLakeStoreAccountBasicData DataLakeStoreAccountBasicData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, Guid? accountId = null, DataLakeStoreAccountStatus? provisioningState = null, DataLakeStoreAccountState? state = null, DateTimeOffset? createdOn = null, DateTimeOffset? lastModifiedOn = null, string endpoint = null, AzureLocation? location = null, IReadOnlyDictionary<string, string> tags = null)
        {
            tags ??= new Dictionary<string, string>();

            return new DataLakeStoreAccountBasicData(
                id,
                name,
                resourceType,
                systemData,
                accountId,
                provisioningState,
                state,
                createdOn,
                lastModifiedOn,
                endpoint,
                location,
                tags,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DataLakeStoreAccountCreateOrUpdateContent"/>. </summary>
        /// <param name="location"> The resource location. </param>
        /// <param name="tags"> The resource tags. </param>
        /// <param name="identity"> The Key Vault encryption identity, if any. Current supported identity types: SystemAssigned. </param>
        /// <param name="defaultGroup"> The default owner group for all new folders and files created in the Data Lake Store account. </param>
        /// <param name="encryptionConfig"> The Key Vault encryption configuration. </param>
        /// <param name="encryptionState"> The current state of encryption for this Data Lake Store account. </param>
        /// <param name="firewallRules"> The list of firewall rules associated with this Data Lake Store account. </param>
        /// <param name="virtualNetworkRules"> The list of virtual network rules associated with this Data Lake Store account. </param>
        /// <param name="firewallState"> The current state of the IP address firewall for this Data Lake Store account. </param>
        /// <param name="firewallAllowAzureIPs"> The current state of allowing or disallowing IPs originating within Azure through the firewall. If the firewall is disabled, this is not enforced. </param>
        /// <param name="trustedIdProviders"> The list of trusted identity providers associated with this Data Lake Store account. </param>
        /// <param name="trustedIdProviderState"> The current state of the trusted identity provider feature for this Data Lake Store account. </param>
        /// <param name="newTier"> The commitment tier to use for next month. </param>
        /// <returns> A new <see cref="Models.DataLakeStoreAccountCreateOrUpdateContent"/> instance for mocking. </returns>
        public static DataLakeStoreAccountCreateOrUpdateContent DataLakeStoreAccountCreateOrUpdateContent(AzureLocation location = default, IDictionary<string, string> tags = null, ManagedServiceIdentity identity = null, string defaultGroup = null, DataLakeStoreAccountEncryptionConfig encryptionConfig = null, DataLakeStoreEncryptionState? encryptionState = null, IEnumerable<FirewallRuleForDataLakeStoreAccountCreateOrUpdateContent> firewallRules = null, IEnumerable<VirtualNetworkRuleForDataLakeStoreAccountCreateOrUpdateContent> virtualNetworkRules = null, DataLakeStoreFirewallState? firewallState = null, DataLakeStoreFirewallAllowAzureIPsState? firewallAllowAzureIPs = null, IEnumerable<TrustedIdProviderForDataLakeStoreAccountCreateOrUpdateContent> trustedIdProviders = null, DataLakeStoreTrustedIdProviderState? trustedIdProviderState = null, DataLakeStoreCommitmentTierType? newTier = null)
        {
            tags ??= new Dictionary<string, string>();
            firewallRules ??= new List<FirewallRuleForDataLakeStoreAccountCreateOrUpdateContent>();
            virtualNetworkRules ??= new List<VirtualNetworkRuleForDataLakeStoreAccountCreateOrUpdateContent>();
            trustedIdProviders ??= new List<TrustedIdProviderForDataLakeStoreAccountCreateOrUpdateContent>();

            return new DataLakeStoreAccountCreateOrUpdateContent(
                location,
                tags,
                identity,
                defaultGroup,
                encryptionConfig,
                encryptionState,
                firewallRules?.ToList(),
                virtualNetworkRules?.ToList(),
                firewallState,
                firewallAllowAzureIPs,
                trustedIdProviders?.ToList(),
                trustedIdProviderState,
                newTier,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="DataLakeStore.DataLakeStoreAccountData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="identity"> The Key Vault encryption identity, if any. Current supported identity types: SystemAssigned. </param>
        /// <param name="accountId"> The unique identifier associated with this Data Lake Store account. </param>
        /// <param name="provisioningState"> The provisioning status of the Data Lake Store account. </param>
        /// <param name="state"> The state of the Data Lake Store account. </param>
        /// <param name="createdOn"> The account creation time. </param>
        /// <param name="lastModifiedOn"> The account last modified time. </param>
        /// <param name="endpoint"> The full CName endpoint for this account. </param>
        /// <param name="defaultGroup"> The default owner group for all new folders and files created in the Data Lake Store account. </param>
        /// <param name="encryptionConfig"> The Key Vault encryption configuration. </param>
        /// <param name="encryptionState"> The current state of encryption for this Data Lake Store account. </param>
        /// <param name="encryptionProvisioningState"> The current state of encryption provisioning for this Data Lake Store account. </param>
        /// <param name="firewallRules"> The list of firewall rules associated with this Data Lake Store account. </param>
        /// <param name="virtualNetworkRules"> The list of virtual network rules associated with this Data Lake Store account. </param>
        /// <param name="firewallState"> The current state of the IP address firewall for this Data Lake Store account. </param>
        /// <param name="firewallAllowAzureIPs"> The current state of allowing or disallowing IPs originating within Azure through the firewall. If the firewall is disabled, this is not enforced. </param>
        /// <param name="trustedIdProviders"> The list of trusted identity providers associated with this Data Lake Store account. </param>
        /// <param name="trustedIdProviderState"> The current state of the trusted identity provider feature for this Data Lake Store account. </param>
        /// <param name="newTier"> The commitment tier to use for next month. </param>
        /// <param name="currentTier"> The commitment tier in use for the current month. </param>
        /// <param name="location"> The resource location. </param>
        /// <param name="tags"> The resource tags. </param>
        /// <returns> A new <see cref="DataLakeStore.DataLakeStoreAccountData"/> instance for mocking. </returns>
        public static DataLakeStoreAccountData DataLakeStoreAccountData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ManagedServiceIdentity identity = null, Guid? accountId = null, DataLakeStoreAccountStatus? provisioningState = null, DataLakeStoreAccountState? state = null, DateTimeOffset? createdOn = null, DateTimeOffset? lastModifiedOn = null, string endpoint = null, string defaultGroup = null, DataLakeStoreAccountEncryptionConfig encryptionConfig = null, DataLakeStoreEncryptionState? encryptionState = null, DataLakeStoreEncryptionProvisioningState? encryptionProvisioningState = null, IEnumerable<DataLakeStoreFirewallRuleData> firewallRules = null, IEnumerable<DataLakeStoreVirtualNetworkRuleData> virtualNetworkRules = null, DataLakeStoreFirewallState? firewallState = null, DataLakeStoreFirewallAllowAzureIPsState? firewallAllowAzureIPs = null, IEnumerable<DataLakeStoreTrustedIdProviderData> trustedIdProviders = null, DataLakeStoreTrustedIdProviderState? trustedIdProviderState = null, DataLakeStoreCommitmentTierType? newTier = null, DataLakeStoreCommitmentTierType? currentTier = null, AzureLocation? location = null, IReadOnlyDictionary<string, string> tags = null)
        {
            firewallRules ??= new List<DataLakeStoreFirewallRuleData>();
            virtualNetworkRules ??= new List<DataLakeStoreVirtualNetworkRuleData>();
            trustedIdProviders ??= new List<DataLakeStoreTrustedIdProviderData>();
            tags ??= new Dictionary<string, string>();

            return new DataLakeStoreAccountData(
                id,
                name,
                resourceType,
                systemData,
                identity,
                accountId,
                provisioningState,
                state,
                createdOn,
                lastModifiedOn,
                endpoint,
                defaultGroup,
                encryptionConfig,
                encryptionState,
                encryptionProvisioningState,
                firewallRules?.ToList(),
                virtualNetworkRules?.ToList(),
                firewallState,
                firewallAllowAzureIPs,
                trustedIdProviders?.ToList(),
                trustedIdProviderState,
                newTier,
                currentTier,
                location,
                tags,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="DataLakeStore.DataLakeStoreFirewallRuleData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="startIPAddress"> The start IP address for the firewall rule. This can be either ipv4 or ipv6. Start and End should be in the same protocol. </param>
        /// <param name="endIPAddress"> The end IP address for the firewall rule. This can be either ipv4 or ipv6. Start and End should be in the same protocol. </param>
        /// <returns> A new <see cref="DataLakeStore.DataLakeStoreFirewallRuleData"/> instance for mocking. </returns>
        public static DataLakeStoreFirewallRuleData DataLakeStoreFirewallRuleData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IPAddress startIPAddress = null, IPAddress endIPAddress = null)
        {
            return new DataLakeStoreFirewallRuleData(
                id,
                name,
                resourceType,
                systemData,
                startIPAddress,
                endIPAddress,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="DataLakeStore.DataLakeStoreVirtualNetworkRuleData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="subnetId"> The resource identifier for the subnet. </param>
        /// <returns> A new <see cref="DataLakeStore.DataLakeStoreVirtualNetworkRuleData"/> instance for mocking. </returns>
        public static DataLakeStoreVirtualNetworkRuleData DataLakeStoreVirtualNetworkRuleData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ResourceIdentifier subnetId = null)
        {
            return new DataLakeStoreVirtualNetworkRuleData(
                id,
                name,
                resourceType,
                systemData,
                subnetId,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="DataLakeStore.DataLakeStoreTrustedIdProviderData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="idProvider"> The URL of this trusted identity provider. </param>
        /// <returns> A new <see cref="DataLakeStore.DataLakeStoreTrustedIdProviderData"/> instance for mocking. </returns>
        public static DataLakeStoreTrustedIdProviderData DataLakeStoreTrustedIdProviderData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, Uri idProvider = null)
        {
            return new DataLakeStoreTrustedIdProviderData(
                id,
                name,
                resourceType,
                systemData,
                idProvider,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.FirewallRuleForDataLakeStoreAccountUpdateContent"/>. </summary>
        /// <param name="name"> The unique name of the firewall rule to update. </param>
        /// <param name="startIPAddress"> The start IP address for the firewall rule. This can be either ipv4 or ipv6. Start and End should be in the same protocol. </param>
        /// <param name="endIPAddress"> The end IP address for the firewall rule. This can be either ipv4 or ipv6. Start and End should be in the same protocol. </param>
        /// <returns> A new <see cref="Models.FirewallRuleForDataLakeStoreAccountUpdateContent"/> instance for mocking. </returns>
        public static FirewallRuleForDataLakeStoreAccountUpdateContent FirewallRuleForDataLakeStoreAccountUpdateContent(string name = null, IPAddress startIPAddress = null, IPAddress endIPAddress = null)
        {
            return new FirewallRuleForDataLakeStoreAccountUpdateContent(name, startIPAddress, endIPAddress, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.VirtualNetworkRuleForDataLakeStoreAccountUpdateContent"/>. </summary>
        /// <param name="name"> The unique name of the virtual network rule to update. </param>
        /// <param name="subnetId"> The resource identifier for the subnet. </param>
        /// <returns> A new <see cref="Models.VirtualNetworkRuleForDataLakeStoreAccountUpdateContent"/> instance for mocking. </returns>
        public static VirtualNetworkRuleForDataLakeStoreAccountUpdateContent VirtualNetworkRuleForDataLakeStoreAccountUpdateContent(string name = null, ResourceIdentifier subnetId = null)
        {
            return new VirtualNetworkRuleForDataLakeStoreAccountUpdateContent(name, subnetId, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.TrustedIdProviderForDataLakeStoreAccountUpdateContent"/>. </summary>
        /// <param name="name"> The unique name of the trusted identity provider to update. </param>
        /// <param name="idProvider"> The URL of this trusted identity provider. </param>
        /// <returns> A new <see cref="Models.TrustedIdProviderForDataLakeStoreAccountUpdateContent"/> instance for mocking. </returns>
        public static TrustedIdProviderForDataLakeStoreAccountUpdateContent TrustedIdProviderForDataLakeStoreAccountUpdateContent(string name = null, Uri idProvider = null)
        {
            return new TrustedIdProviderForDataLakeStoreAccountUpdateContent(name, idProvider, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DataLakeStoreCapabilityInformation"/>. </summary>
        /// <param name="subscriptionId"> The subscription credentials that uniquely identifies the subscription. </param>
        /// <param name="state"> The subscription state. </param>
        /// <param name="maxAccountCount"> The maximum supported number of accounts under this subscription. </param>
        /// <param name="accountCount"> The current number of accounts under this subscription. </param>
        /// <param name="isUnderMigrationState"> The Boolean value of true or false to indicate the maintenance state. </param>
        /// <returns> A new <see cref="Models.DataLakeStoreCapabilityInformation"/> instance for mocking. </returns>
        public static DataLakeStoreCapabilityInformation DataLakeStoreCapabilityInformation(Guid? subscriptionId = null, DataLakeStoreSubscriptionState? state = null, int? maxAccountCount = null, int? accountCount = null, bool? isUnderMigrationState = null)
        {
            return new DataLakeStoreCapabilityInformation(
                subscriptionId,
                state,
                maxAccountCount,
                accountCount,
                isUnderMigrationState,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DataLakeStoreUsage"/>. </summary>
        /// <param name="unit"> Gets the unit of measurement. </param>
        /// <param name="id"> Resource identifier. </param>
        /// <param name="currentValue"> Gets the current count of the allocated resources in the subscription. </param>
        /// <param name="limit"> Gets the maximum count of the resources that can be allocated in the subscription. </param>
        /// <param name="name"> Gets the name of the type of usage. </param>
        /// <returns> A new <see cref="Models.DataLakeStoreUsage"/> instance for mocking. </returns>
        public static DataLakeStoreUsage DataLakeStoreUsage(DataLakeStoreUsageUnit? unit = null, ResourceIdentifier id = null, int? currentValue = null, int? limit = null, DataLakeStoreUsageName name = null)
        {
            return new DataLakeStoreUsage(
                unit,
                id,
                currentValue,
                limit,
                name,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DataLakeStoreUsageName"/>. </summary>
        /// <param name="value"> Gets a string describing the resource name. </param>
        /// <param name="localizedValue"> Gets a localized string describing the resource name. </param>
        /// <returns> A new <see cref="Models.DataLakeStoreUsageName"/> instance for mocking. </returns>
        public static DataLakeStoreUsageName DataLakeStoreUsageName(string value = null, string localizedValue = null)
        {
            return new DataLakeStoreUsageName(value, localizedValue, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DataLakeStoreAccountNameAvailabilityResult"/>. </summary>
        /// <param name="isNameAvailable"> The Boolean value of true or false to indicate whether the Data Lake Store account name is available or not. </param>
        /// <param name="reason"> The reason why the Data Lake Store account name is not available, if nameAvailable is false. </param>
        /// <param name="message"> The message describing why the Data Lake Store account name is not available, if nameAvailable is false. </param>
        /// <returns> A new <see cref="Models.DataLakeStoreAccountNameAvailabilityResult"/> instance for mocking. </returns>
        public static DataLakeStoreAccountNameAvailabilityResult DataLakeStoreAccountNameAvailabilityResult(bool? isNameAvailable = null, string reason = null, string message = null)
        {
            return new DataLakeStoreAccountNameAvailabilityResult(isNameAvailable, reason, message, serializedAdditionalRawData: null);
        }
    }
}
