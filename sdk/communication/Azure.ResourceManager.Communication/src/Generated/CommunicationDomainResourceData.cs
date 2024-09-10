// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Communication.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Communication
{
    /// <summary>
    /// A class representing the CommunicationDomainResource data model.
    /// A class representing a Domains resource.
    /// </summary>
    public partial class CommunicationDomainResourceData : TrackedResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CommunicationDomainResourceData"/>. </summary>
        /// <param name="location"> The location. </param>
        public CommunicationDomainResourceData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="CommunicationDomainResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="dataLocation"> The location where the Domains resource data is stored at rest. </param>
        /// <param name="fromSenderDomain"> P2 sender domain that is displayed to the email recipients [RFC 5322]. </param>
        /// <param name="mailFromSenderDomain"> P1 sender domain that is present on the email envelope [RFC 5321]. </param>
        /// <param name="domainManagement"> Describes how a Domains resource is being managed. </param>
        /// <param name="verificationStates"> List of VerificationStatusRecord. </param>
        /// <param name="verificationRecords"> List of DnsRecord. </param>
        /// <param name="userEngagementTracking"> Describes whether user engagement tracking is enabled or disabled. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CommunicationDomainResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, DomainProvisioningState? provisioningState, string dataLocation, string fromSenderDomain, string mailFromSenderDomain, DomainManagement? domainManagement, DomainPropertiesVerificationStates verificationStates, DomainPropertiesVerificationRecords verificationRecords, UserEngagementTracking? userEngagementTracking, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ProvisioningState = provisioningState;
            DataLocation = dataLocation;
            FromSenderDomain = fromSenderDomain;
            MailFromSenderDomain = mailFromSenderDomain;
            DomainManagement = domainManagement;
            VerificationStates = verificationStates;
            VerificationRecords = verificationRecords;
            UserEngagementTracking = userEngagementTracking;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CommunicationDomainResourceData"/> for deserialization. </summary>
        internal CommunicationDomainResourceData()
        {
        }

        /// <summary> Provisioning state of the resource. </summary>
        [WirePath("properties.provisioningState")]
        public DomainProvisioningState? ProvisioningState { get; }
        /// <summary> The location where the Domains resource data is stored at rest. </summary>
        [WirePath("properties.dataLocation")]
        public string DataLocation { get; }
        /// <summary> P2 sender domain that is displayed to the email recipients [RFC 5322]. </summary>
        [WirePath("properties.fromSenderDomain")]
        public string FromSenderDomain { get; }
        /// <summary> P1 sender domain that is present on the email envelope [RFC 5321]. </summary>
        [WirePath("properties.mailFromSenderDomain")]
        public string MailFromSenderDomain { get; }
        /// <summary> Describes how a Domains resource is being managed. </summary>
        [WirePath("properties.domainManagement")]
        public DomainManagement? DomainManagement { get; set; }
        /// <summary> List of VerificationStatusRecord. </summary>
        [WirePath("properties.verificationStates")]
        public DomainPropertiesVerificationStates VerificationStates { get; }
        /// <summary> List of DnsRecord. </summary>
        [WirePath("properties.verificationRecords")]
        public DomainPropertiesVerificationRecords VerificationRecords { get; }
        /// <summary> Describes whether user engagement tracking is enabled or disabled. </summary>
        [WirePath("properties.userEngagementTracking")]
        public UserEngagementTracking? UserEngagementTracking { get; set; }
    }
}
