// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Represents a mail cluster entity. </summary>
    public partial class SecurityInsightsMailClusterEntity : SecurityInsightsEntity
    {
        /// <summary> Initializes a new instance of <see cref="SecurityInsightsMailClusterEntity"/>. </summary>
        public SecurityInsightsMailClusterEntity()
        {
            AdditionalData = new ChangeTrackingDictionary<string, BinaryData>();
            NetworkMessageIds = new ChangeTrackingList<string>();
            Threats = new ChangeTrackingList<string>();
            Kind = SecurityInsightsEntityKind.MailCluster;
        }

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsMailClusterEntity"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> The kind of the entity. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="additionalData"> A bag of custom fields that should be part of the entity and will be presented to the user. </param>
        /// <param name="friendlyName"> The graph item display name which is a short humanly readable description of the graph item instance. This property is optional and might be system generated. </param>
        /// <param name="networkMessageIds"> The mail message IDs that are part of the mail cluster. </param>
        /// <param name="countByDeliveryStatus"> Count of mail messages by DeliveryStatus string representation. </param>
        /// <param name="countByThreatType"> Count of mail messages by ThreatType string representation. </param>
        /// <param name="countByProtectionStatus"> Count of mail messages by ProtectionStatus string representation. </param>
        /// <param name="threats"> The threats of mail messages that are part of the mail cluster. </param>
        /// <param name="query"> The query that was used to identify the messages of the mail cluster. </param>
        /// <param name="queryOn"> The query time. </param>
        /// <param name="mailCount"> The number of mail messages that are part of the mail cluster. </param>
        /// <param name="isVolumeAnomaly"> Is this a volume anomaly mail cluster. </param>
        /// <param name="source"> The source of the mail cluster (default is 'O365 ATP'). </param>
        /// <param name="clusterSourceIdentifier"> The id of the cluster source. </param>
        /// <param name="clusterSourceType"> The type of the cluster source. </param>
        /// <param name="clusterQueryStartOn"> The cluster query start time. </param>
        /// <param name="clusterQueryEndOn"> The cluster query end time. </param>
        /// <param name="clusterGroup"> The cluster group. </param>
        internal SecurityInsightsMailClusterEntity(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SecurityInsightsEntityKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, IReadOnlyDictionary<string, BinaryData> additionalData, string friendlyName, IReadOnlyList<string> networkMessageIds, BinaryData countByDeliveryStatus, BinaryData countByThreatType, BinaryData countByProtectionStatus, IReadOnlyList<string> threats, string query, DateTimeOffset? queryOn, int? mailCount, bool? isVolumeAnomaly, string source, string clusterSourceIdentifier, string clusterSourceType, DateTimeOffset? clusterQueryStartOn, DateTimeOffset? clusterQueryEndOn, string clusterGroup) : base(id, name, resourceType, systemData, kind, serializedAdditionalRawData)
        {
            AdditionalData = additionalData;
            FriendlyName = friendlyName;
            NetworkMessageIds = networkMessageIds;
            CountByDeliveryStatus = countByDeliveryStatus;
            CountByThreatType = countByThreatType;
            CountByProtectionStatus = countByProtectionStatus;
            Threats = threats;
            Query = query;
            QueryOn = queryOn;
            MailCount = mailCount;
            IsVolumeAnomaly = isVolumeAnomaly;
            Source = source;
            ClusterSourceIdentifier = clusterSourceIdentifier;
            ClusterSourceType = clusterSourceType;
            ClusterQueryStartOn = clusterQueryStartOn;
            ClusterQueryEndOn = clusterQueryEndOn;
            ClusterGroup = clusterGroup;
            Kind = kind;
        }

        /// <summary>
        /// A bag of custom fields that should be part of the entity and will be presented to the user.
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
        [WirePath("properties.additionalData")]
        public IReadOnlyDictionary<string, BinaryData> AdditionalData { get; }
        /// <summary> The graph item display name which is a short humanly readable description of the graph item instance. This property is optional and might be system generated. </summary>
        [WirePath("properties.friendlyName")]
        public string FriendlyName { get; }
        /// <summary> The mail message IDs that are part of the mail cluster. </summary>
        [WirePath("properties.networkMessageIds")]
        public IReadOnlyList<string> NetworkMessageIds { get; }
        /// <summary>
        /// Count of mail messages by DeliveryStatus string representation
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        [WirePath("properties.countByDeliveryStatus")]
        public BinaryData CountByDeliveryStatus { get; }
        /// <summary>
        /// Count of mail messages by ThreatType string representation
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        [WirePath("properties.countByThreatType")]
        public BinaryData CountByThreatType { get; }
        /// <summary>
        /// Count of mail messages by ProtectionStatus string representation
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        [WirePath("properties.countByProtectionStatus")]
        public BinaryData CountByProtectionStatus { get; }
        /// <summary> The threats of mail messages that are part of the mail cluster. </summary>
        [WirePath("properties.threats")]
        public IReadOnlyList<string> Threats { get; }
        /// <summary> The query that was used to identify the messages of the mail cluster. </summary>
        [WirePath("properties.query")]
        public string Query { get; }
        /// <summary> The query time. </summary>
        [WirePath("properties.queryTime")]
        public DateTimeOffset? QueryOn { get; }
        /// <summary> The number of mail messages that are part of the mail cluster. </summary>
        [WirePath("properties.mailCount")]
        public int? MailCount { get; }
        /// <summary> Is this a volume anomaly mail cluster. </summary>
        [WirePath("properties.isVolumeAnomaly")]
        public bool? IsVolumeAnomaly { get; }
        /// <summary> The source of the mail cluster (default is 'O365 ATP'). </summary>
        [WirePath("properties.source")]
        public string Source { get; }
        /// <summary> The id of the cluster source. </summary>
        [WirePath("properties.clusterSourceIdentifier")]
        public string ClusterSourceIdentifier { get; }
        /// <summary> The type of the cluster source. </summary>
        [WirePath("properties.clusterSourceType")]
        public string ClusterSourceType { get; }
        /// <summary> The cluster query start time. </summary>
        [WirePath("properties.clusterQueryStartTime")]
        public DateTimeOffset? ClusterQueryStartOn { get; }
        /// <summary> The cluster query end time. </summary>
        [WirePath("properties.clusterQueryEndTime")]
        public DateTimeOffset? ClusterQueryEndOn { get; }
        /// <summary> The cluster group. </summary>
        [WirePath("properties.clusterGroup")]
        public string ClusterGroup { get; }
    }
}
