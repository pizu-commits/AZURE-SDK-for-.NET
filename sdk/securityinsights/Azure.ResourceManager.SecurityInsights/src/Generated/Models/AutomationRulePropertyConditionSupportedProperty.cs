// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The property to evaluate in an automation rule property condition. </summary>
    public readonly partial struct AutomationRulePropertyConditionSupportedProperty : IEquatable<AutomationRulePropertyConditionSupportedProperty>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AutomationRulePropertyConditionSupportedProperty"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AutomationRulePropertyConditionSupportedProperty(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IncidentTitleValue = "IncidentTitle";
        private const string IncidentDescriptionValue = "IncidentDescription";
        private const string IncidentSeverityValue = "IncidentSeverity";
        private const string IncidentStatusValue = "IncidentStatus";
        private const string IncidentRelatedAnalyticRuleIdsValue = "IncidentRelatedAnalyticRuleIds";
        private const string IncidentTacticsValue = "IncidentTactics";
        private const string IncidentLabelValue = "IncidentLabel";
        private const string IncidentProviderNameValue = "IncidentProviderName";
        private const string AccountAadTenantIdValue = "AccountAadTenantId";
        private const string AccountAadUserIdValue = "AccountAadUserId";
        private const string AccountNameValue = "AccountName";
        private const string AccountNTDomainValue = "AccountNTDomain";
        private const string AccountPuidValue = "AccountPUID";
        private const string AccountSidValue = "AccountSid";
        private const string AccountObjectGuidValue = "AccountObjectGuid";
        private const string AccountUPNSuffixValue = "AccountUPNSuffix";
        private const string AlertProductNamesValue = "AlertProductNames";
        private const string AlertAnalyticRuleIdsValue = "AlertAnalyticRuleIds";
        private const string AzureResourceResourceIdValue = "AzureResourceResourceId";
        private const string AzureResourceSubscriptionIdValue = "AzureResourceSubscriptionId";
        private const string CloudApplicationAppIdValue = "CloudApplicationAppId";
        private const string CloudApplicationAppNameValue = "CloudApplicationAppName";
        private const string DnsDomainNameValue = "DNSDomainName";
        private const string FileDirectoryValue = "FileDirectory";
        private const string FileNameValue = "FileName";
        private const string FileHashValueValue = "FileHashValue";
        private const string HostAzureIdValue = "HostAzureID";
        private const string HostNameValue = "HostName";
        private const string HostNetBiosNameValue = "HostNetBiosName";
        private const string HostNTDomainValue = "HostNTDomain";
        private const string HostOSVersionValue = "HostOSVersion";
        private const string IoTDeviceIdValue = "IoTDeviceId";
        private const string IoTDeviceNameValue = "IoTDeviceName";
        private const string IoTDeviceTypeValue = "IoTDeviceType";
        private const string IoTDeviceVendorValue = "IoTDeviceVendor";
        private const string IoTDeviceModelValue = "IoTDeviceModel";
        private const string IoTDeviceOperatingSystemValue = "IoTDeviceOperatingSystem";
        private const string IPAddressValue = "IPAddress";
        private const string MailboxDisplayNameValue = "MailboxDisplayName";
        private const string MailboxPrimaryAddressValue = "MailboxPrimaryAddress";
        private const string MailboxUPNValue = "MailboxUPN";
        private const string MailMessageDeliveryActionValue = "MailMessageDeliveryAction";
        private const string MailMessageDeliveryLocationValue = "MailMessageDeliveryLocation";
        private const string MailMessageRecipientValue = "MailMessageRecipient";
        private const string MailMessageSenderIPValue = "MailMessageSenderIP";
        private const string MailMessageSubjectValue = "MailMessageSubject";
        private const string MailMessageP1SenderValue = "MailMessageP1Sender";
        private const string MailMessageP2SenderValue = "MailMessageP2Sender";
        private const string MalwareCategoryValue = "MalwareCategory";
        private const string MalwareNameValue = "MalwareName";
        private const string ProcessCommandLineValue = "ProcessCommandLine";
        private const string ProcessIdValue = "ProcessId";
        private const string RegistryKeyValue = "RegistryKey";
        private const string RegistryValueDataValue = "RegistryValueData";
        private const string UrlValue = "Url";

        /// <summary> The title of the incident. </summary>
        public static AutomationRulePropertyConditionSupportedProperty IncidentTitle { get; } = new AutomationRulePropertyConditionSupportedProperty(IncidentTitleValue);
        /// <summary> The description of the incident. </summary>
        public static AutomationRulePropertyConditionSupportedProperty IncidentDescription { get; } = new AutomationRulePropertyConditionSupportedProperty(IncidentDescriptionValue);
        /// <summary> The severity of the incident. </summary>
        public static AutomationRulePropertyConditionSupportedProperty IncidentSeverity { get; } = new AutomationRulePropertyConditionSupportedProperty(IncidentSeverityValue);
        /// <summary> The status of the incident. </summary>
        public static AutomationRulePropertyConditionSupportedProperty IncidentStatus { get; } = new AutomationRulePropertyConditionSupportedProperty(IncidentStatusValue);
        /// <summary> The related Analytic rule ids of the incident. </summary>
        public static AutomationRulePropertyConditionSupportedProperty IncidentRelatedAnalyticRuleIds { get; } = new AutomationRulePropertyConditionSupportedProperty(IncidentRelatedAnalyticRuleIdsValue);
        /// <summary> The tactics of the incident. </summary>
        public static AutomationRulePropertyConditionSupportedProperty IncidentTactics { get; } = new AutomationRulePropertyConditionSupportedProperty(IncidentTacticsValue);
        /// <summary> The labels of the incident. </summary>
        public static AutomationRulePropertyConditionSupportedProperty IncidentLabel { get; } = new AutomationRulePropertyConditionSupportedProperty(IncidentLabelValue);
        /// <summary> The provider name of the incident. </summary>
        public static AutomationRulePropertyConditionSupportedProperty IncidentProviderName { get; } = new AutomationRulePropertyConditionSupportedProperty(IncidentProviderNameValue);
        /// <summary> The account Azure Active Directory tenant id. </summary>
        public static AutomationRulePropertyConditionSupportedProperty AccountAadTenantId { get; } = new AutomationRulePropertyConditionSupportedProperty(AccountAadTenantIdValue);
        /// <summary> The account Azure Active Directory user id. </summary>
        public static AutomationRulePropertyConditionSupportedProperty AccountAadUserId { get; } = new AutomationRulePropertyConditionSupportedProperty(AccountAadUserIdValue);
        /// <summary> The account name. </summary>
        public static AutomationRulePropertyConditionSupportedProperty AccountName { get; } = new AutomationRulePropertyConditionSupportedProperty(AccountNameValue);
        /// <summary> The account NetBIOS domain name. </summary>
        public static AutomationRulePropertyConditionSupportedProperty AccountNTDomain { get; } = new AutomationRulePropertyConditionSupportedProperty(AccountNTDomainValue);
        /// <summary> The account Azure Active Directory Passport User ID. </summary>
        public static AutomationRulePropertyConditionSupportedProperty AccountPuid { get; } = new AutomationRulePropertyConditionSupportedProperty(AccountPuidValue);
        /// <summary> The account security identifier. </summary>
        public static AutomationRulePropertyConditionSupportedProperty AccountSid { get; } = new AutomationRulePropertyConditionSupportedProperty(AccountSidValue);
        /// <summary> The account unique identifier. </summary>
        public static AutomationRulePropertyConditionSupportedProperty AccountObjectGuid { get; } = new AutomationRulePropertyConditionSupportedProperty(AccountObjectGuidValue);
        /// <summary> The account user principal name suffix. </summary>
        public static AutomationRulePropertyConditionSupportedProperty AccountUPNSuffix { get; } = new AutomationRulePropertyConditionSupportedProperty(AccountUPNSuffixValue);
        /// <summary> The name of the product of the alert. </summary>
        public static AutomationRulePropertyConditionSupportedProperty AlertProductNames { get; } = new AutomationRulePropertyConditionSupportedProperty(AlertProductNamesValue);
        /// <summary> The analytic rule ids of the alert. </summary>
        public static AutomationRulePropertyConditionSupportedProperty AlertAnalyticRuleIds { get; } = new AutomationRulePropertyConditionSupportedProperty(AlertAnalyticRuleIdsValue);
        /// <summary> The Azure resource id. </summary>
        public static AutomationRulePropertyConditionSupportedProperty AzureResourceResourceId { get; } = new AutomationRulePropertyConditionSupportedProperty(AzureResourceResourceIdValue);
        /// <summary> The Azure resource subscription id. </summary>
        public static AutomationRulePropertyConditionSupportedProperty AzureResourceSubscriptionId { get; } = new AutomationRulePropertyConditionSupportedProperty(AzureResourceSubscriptionIdValue);
        /// <summary> The cloud application identifier. </summary>
        public static AutomationRulePropertyConditionSupportedProperty CloudApplicationAppId { get; } = new AutomationRulePropertyConditionSupportedProperty(CloudApplicationAppIdValue);
        /// <summary> The cloud application name. </summary>
        public static AutomationRulePropertyConditionSupportedProperty CloudApplicationAppName { get; } = new AutomationRulePropertyConditionSupportedProperty(CloudApplicationAppNameValue);
        /// <summary> The dns record domain name. </summary>
        public static AutomationRulePropertyConditionSupportedProperty DnsDomainName { get; } = new AutomationRulePropertyConditionSupportedProperty(DnsDomainNameValue);
        /// <summary> The file directory full path. </summary>
        public static AutomationRulePropertyConditionSupportedProperty FileDirectory { get; } = new AutomationRulePropertyConditionSupportedProperty(FileDirectoryValue);
        /// <summary> The file name without path. </summary>
        public static AutomationRulePropertyConditionSupportedProperty FileName { get; } = new AutomationRulePropertyConditionSupportedProperty(FileNameValue);
        /// <summary> The file hash value. </summary>
        public static AutomationRulePropertyConditionSupportedProperty FileHashValue { get; } = new AutomationRulePropertyConditionSupportedProperty(FileHashValueValue);
        /// <summary> The host Azure resource id. </summary>
        public static AutomationRulePropertyConditionSupportedProperty HostAzureId { get; } = new AutomationRulePropertyConditionSupportedProperty(HostAzureIdValue);
        /// <summary> The host name without domain. </summary>
        public static AutomationRulePropertyConditionSupportedProperty HostName { get; } = new AutomationRulePropertyConditionSupportedProperty(HostNameValue);
        /// <summary> The host NetBIOS name. </summary>
        public static AutomationRulePropertyConditionSupportedProperty HostNetBiosName { get; } = new AutomationRulePropertyConditionSupportedProperty(HostNetBiosNameValue);
        /// <summary> The host NT domain. </summary>
        public static AutomationRulePropertyConditionSupportedProperty HostNTDomain { get; } = new AutomationRulePropertyConditionSupportedProperty(HostNTDomainValue);
        /// <summary> The host operating system. </summary>
        public static AutomationRulePropertyConditionSupportedProperty HostOSVersion { get; } = new AutomationRulePropertyConditionSupportedProperty(HostOSVersionValue);
        /// <summary> &quot;The IoT device id. </summary>
        public static AutomationRulePropertyConditionSupportedProperty IoTDeviceId { get; } = new AutomationRulePropertyConditionSupportedProperty(IoTDeviceIdValue);
        /// <summary> The IoT device name. </summary>
        public static AutomationRulePropertyConditionSupportedProperty IoTDeviceName { get; } = new AutomationRulePropertyConditionSupportedProperty(IoTDeviceNameValue);
        /// <summary> The IoT device type. </summary>
        public static AutomationRulePropertyConditionSupportedProperty IoTDeviceType { get; } = new AutomationRulePropertyConditionSupportedProperty(IoTDeviceTypeValue);
        /// <summary> The IoT device vendor. </summary>
        public static AutomationRulePropertyConditionSupportedProperty IoTDeviceVendor { get; } = new AutomationRulePropertyConditionSupportedProperty(IoTDeviceVendorValue);
        /// <summary> The IoT device model. </summary>
        public static AutomationRulePropertyConditionSupportedProperty IoTDeviceModel { get; } = new AutomationRulePropertyConditionSupportedProperty(IoTDeviceModelValue);
        /// <summary> The IoT device operating system. </summary>
        public static AutomationRulePropertyConditionSupportedProperty IoTDeviceOperatingSystem { get; } = new AutomationRulePropertyConditionSupportedProperty(IoTDeviceOperatingSystemValue);
        /// <summary> The IP address. </summary>
        public static AutomationRulePropertyConditionSupportedProperty IPAddress { get; } = new AutomationRulePropertyConditionSupportedProperty(IPAddressValue);
        /// <summary> The mailbox display name. </summary>
        public static AutomationRulePropertyConditionSupportedProperty MailboxDisplayName { get; } = new AutomationRulePropertyConditionSupportedProperty(MailboxDisplayNameValue);
        /// <summary> The mailbox primary address. </summary>
        public static AutomationRulePropertyConditionSupportedProperty MailboxPrimaryAddress { get; } = new AutomationRulePropertyConditionSupportedProperty(MailboxPrimaryAddressValue);
        /// <summary> The mailbox user principal name. </summary>
        public static AutomationRulePropertyConditionSupportedProperty MailboxUPN { get; } = new AutomationRulePropertyConditionSupportedProperty(MailboxUPNValue);
        /// <summary> The mail message delivery action. </summary>
        public static AutomationRulePropertyConditionSupportedProperty MailMessageDeliveryAction { get; } = new AutomationRulePropertyConditionSupportedProperty(MailMessageDeliveryActionValue);
        /// <summary> The mail message delivery location. </summary>
        public static AutomationRulePropertyConditionSupportedProperty MailMessageDeliveryLocation { get; } = new AutomationRulePropertyConditionSupportedProperty(MailMessageDeliveryLocationValue);
        /// <summary> The mail message recipient. </summary>
        public static AutomationRulePropertyConditionSupportedProperty MailMessageRecipient { get; } = new AutomationRulePropertyConditionSupportedProperty(MailMessageRecipientValue);
        /// <summary> The mail message sender IP address. </summary>
        public static AutomationRulePropertyConditionSupportedProperty MailMessageSenderIP { get; } = new AutomationRulePropertyConditionSupportedProperty(MailMessageSenderIPValue);
        /// <summary> The mail message subject. </summary>
        public static AutomationRulePropertyConditionSupportedProperty MailMessageSubject { get; } = new AutomationRulePropertyConditionSupportedProperty(MailMessageSubjectValue);
        /// <summary> The mail message P1 sender. </summary>
        public static AutomationRulePropertyConditionSupportedProperty MailMessageP1Sender { get; } = new AutomationRulePropertyConditionSupportedProperty(MailMessageP1SenderValue);
        /// <summary> The mail message P2 sender. </summary>
        public static AutomationRulePropertyConditionSupportedProperty MailMessageP2Sender { get; } = new AutomationRulePropertyConditionSupportedProperty(MailMessageP2SenderValue);
        /// <summary> The malware category. </summary>
        public static AutomationRulePropertyConditionSupportedProperty MalwareCategory { get; } = new AutomationRulePropertyConditionSupportedProperty(MalwareCategoryValue);
        /// <summary> The malware name. </summary>
        public static AutomationRulePropertyConditionSupportedProperty MalwareName { get; } = new AutomationRulePropertyConditionSupportedProperty(MalwareNameValue);
        /// <summary> The process execution command line. </summary>
        public static AutomationRulePropertyConditionSupportedProperty ProcessCommandLine { get; } = new AutomationRulePropertyConditionSupportedProperty(ProcessCommandLineValue);
        /// <summary> The process id. </summary>
        public static AutomationRulePropertyConditionSupportedProperty ProcessId { get; } = new AutomationRulePropertyConditionSupportedProperty(ProcessIdValue);
        /// <summary> The registry key path. </summary>
        public static AutomationRulePropertyConditionSupportedProperty RegistryKey { get; } = new AutomationRulePropertyConditionSupportedProperty(RegistryKeyValue);
        /// <summary> The registry key value in string formatted representation. </summary>
        public static AutomationRulePropertyConditionSupportedProperty RegistryValueData { get; } = new AutomationRulePropertyConditionSupportedProperty(RegistryValueDataValue);
        /// <summary> The url. </summary>
        public static AutomationRulePropertyConditionSupportedProperty Url { get; } = new AutomationRulePropertyConditionSupportedProperty(UrlValue);
        /// <summary> Determines if two <see cref="AutomationRulePropertyConditionSupportedProperty"/> values are the same. </summary>
        public static bool operator ==(AutomationRulePropertyConditionSupportedProperty left, AutomationRulePropertyConditionSupportedProperty right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AutomationRulePropertyConditionSupportedProperty"/> values are not the same. </summary>
        public static bool operator !=(AutomationRulePropertyConditionSupportedProperty left, AutomationRulePropertyConditionSupportedProperty right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AutomationRulePropertyConditionSupportedProperty"/>. </summary>
        public static implicit operator AutomationRulePropertyConditionSupportedProperty(string value) => new AutomationRulePropertyConditionSupportedProperty(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AutomationRulePropertyConditionSupportedProperty other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AutomationRulePropertyConditionSupportedProperty other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
