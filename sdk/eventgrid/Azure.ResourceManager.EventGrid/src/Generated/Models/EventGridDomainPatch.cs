// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Properties of the Domain update. </summary>
    public partial class EventGridDomainPatch
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

        /// <summary> Initializes a new instance of <see cref="EventGridDomainPatch"/>. </summary>
        public EventGridDomainPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            InboundIPRules = new ChangeTrackingList<EventGridInboundIPRule>();
        }

        /// <summary> Initializes a new instance of <see cref="EventGridDomainPatch"/>. </summary>
        /// <param name="tags"> Tags of the domains resource. </param>
        /// <param name="identity"> Identity information for the resource. </param>
        /// <param name="sku"> The Sku pricing tier for the domain. </param>
        /// <param name="publicNetworkAccess">
        /// This determines if traffic is allowed over public network. By default it is enabled.
        /// You can further restrict to specific IPs by configuring &lt;seealso cref="P:Microsoft.Azure.Events.ResourceProvider.Common.Contracts.DomainUpdateParameterProperties.InboundIpRules" /&gt;
        /// </param>
        /// <param name="inboundIPRules"> This can be used to restrict traffic from specific IPs instead of all IPs. Note: These are considered only if PublicNetworkAccess is enabled. </param>
        /// <param name="minimumTlsVersionAllowed"> Minimum TLS version of the publisher allowed to publish to this domain. </param>
        /// <param name="isLocalAuthDisabled"> This boolean is used to enable or disable local auth. Default value is false. When the property is set to true, only AAD token will be used to authenticate if user is allowed to publish to the domain. </param>
        /// <param name="autoCreateTopicWithFirstSubscription">
        /// This Boolean is used to specify the creation mechanism for 'all' the Event Grid Domain Topics associated with this Event Grid Domain resource.
        /// In this context, creation of domain topic can be auto-managed (when true) or self-managed (when false). The default value for this property is true.
        /// When this property is null or set to true, Event Grid is responsible of automatically creating the domain topic when the first event subscription is
        /// created at the scope of the domain topic. If this property is set to false, then creating the first event subscription will require creating a domain topic
        /// by the user. The self-management mode can be used if the user wants full control of when the domain topic is created, while auto-managed mode provides the
        /// flexibility to perform less operations and manage fewer resources by the user. Also, note that in auto-managed creation mode, user is allowed to create the
        /// domain topic on demand if needed.
        /// </param>
        /// <param name="autoDeleteTopicWithLastSubscription">
        /// This Boolean is used to specify the deletion mechanism for 'all' the Event Grid Domain Topics associated with this Event Grid Domain resource.
        /// In this context, deletion of domain topic can be auto-managed (when true) or self-managed (when false). The default value for this property is true.
        /// When this property is set to true, Event Grid is responsible of automatically deleting the domain topic when the last event subscription at the scope
        /// of the domain topic is deleted. If this property is set to false, then the user needs to manually delete the domain topic when it is no longer needed
        /// (e.g., when last event subscription is deleted and the resource needs to be cleaned up). The self-management mode can be used if the user wants full
        /// control of when the domain topic needs to be deleted, while auto-managed mode provides the flexibility to perform less operations and manage fewer
        /// resources by the user.
        /// </param>
        /// <param name="dataResidencyBoundary"> The data residency boundary for the domain. </param>
        /// <param name="eventTypeInfo"> The eventTypeInfo for the domain. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EventGridDomainPatch(IDictionary<string, string> tags, ManagedServiceIdentity identity, ResourceSku sku, EventGridPublicNetworkAccess? publicNetworkAccess, IList<EventGridInboundIPRule> inboundIPRules, TlsVersion? minimumTlsVersionAllowed, bool? isLocalAuthDisabled, bool? autoCreateTopicWithFirstSubscription, bool? autoDeleteTopicWithLastSubscription, DataResidencyBoundary? dataResidencyBoundary, PartnerTopicEventTypeInfo eventTypeInfo, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Tags = tags;
            Identity = identity;
            Sku = sku;
            PublicNetworkAccess = publicNetworkAccess;
            InboundIPRules = inboundIPRules;
            MinimumTlsVersionAllowed = minimumTlsVersionAllowed;
            IsLocalAuthDisabled = isLocalAuthDisabled;
            AutoCreateTopicWithFirstSubscription = autoCreateTopicWithFirstSubscription;
            AutoDeleteTopicWithLastSubscription = autoDeleteTopicWithLastSubscription;
            DataResidencyBoundary = dataResidencyBoundary;
            EventTypeInfo = eventTypeInfo;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Tags of the domains resource. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Identity information for the resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The Sku pricing tier for the domain. </summary>
        internal ResourceSku Sku { get; set; }
        /// <summary> The Sku name of the resource. The possible values are: Basic or Premium. </summary>
        public EventGridSku? SkuName
        {
            get => Sku is null ? default : Sku.Name;
            set
            {
                if (Sku is null)
                    Sku = new ResourceSku();
                Sku.Name = value;
            }
        }

        /// <summary>
        /// This determines if traffic is allowed over public network. By default it is enabled.
        /// You can further restrict to specific IPs by configuring &lt;seealso cref="P:Microsoft.Azure.Events.ResourceProvider.Common.Contracts.DomainUpdateParameterProperties.InboundIpRules" /&gt;
        /// </summary>
        public EventGridPublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> This can be used to restrict traffic from specific IPs instead of all IPs. Note: These are considered only if PublicNetworkAccess is enabled. </summary>
        public IList<EventGridInboundIPRule> InboundIPRules { get; }
        /// <summary> Minimum TLS version of the publisher allowed to publish to this domain. </summary>
        public TlsVersion? MinimumTlsVersionAllowed { get; set; }
        /// <summary> This boolean is used to enable or disable local auth. Default value is false. When the property is set to true, only AAD token will be used to authenticate if user is allowed to publish to the domain. </summary>
        public bool? IsLocalAuthDisabled { get; set; }
        /// <summary>
        /// This Boolean is used to specify the creation mechanism for 'all' the Event Grid Domain Topics associated with this Event Grid Domain resource.
        /// In this context, creation of domain topic can be auto-managed (when true) or self-managed (when false). The default value for this property is true.
        /// When this property is null or set to true, Event Grid is responsible of automatically creating the domain topic when the first event subscription is
        /// created at the scope of the domain topic. If this property is set to false, then creating the first event subscription will require creating a domain topic
        /// by the user. The self-management mode can be used if the user wants full control of when the domain topic is created, while auto-managed mode provides the
        /// flexibility to perform less operations and manage fewer resources by the user. Also, note that in auto-managed creation mode, user is allowed to create the
        /// domain topic on demand if needed.
        /// </summary>
        public bool? AutoCreateTopicWithFirstSubscription { get; set; }
        /// <summary>
        /// This Boolean is used to specify the deletion mechanism for 'all' the Event Grid Domain Topics associated with this Event Grid Domain resource.
        /// In this context, deletion of domain topic can be auto-managed (when true) or self-managed (when false). The default value for this property is true.
        /// When this property is set to true, Event Grid is responsible of automatically deleting the domain topic when the last event subscription at the scope
        /// of the domain topic is deleted. If this property is set to false, then the user needs to manually delete the domain topic when it is no longer needed
        /// (e.g., when last event subscription is deleted and the resource needs to be cleaned up). The self-management mode can be used if the user wants full
        /// control of when the domain topic needs to be deleted, while auto-managed mode provides the flexibility to perform less operations and manage fewer
        /// resources by the user.
        /// </summary>
        public bool? AutoDeleteTopicWithLastSubscription { get; set; }
        /// <summary> The data residency boundary for the domain. </summary>
        public DataResidencyBoundary? DataResidencyBoundary { get; set; }
        /// <summary> The eventTypeInfo for the domain. </summary>
        public PartnerTopicEventTypeInfo EventTypeInfo { get; set; }
    }
}
