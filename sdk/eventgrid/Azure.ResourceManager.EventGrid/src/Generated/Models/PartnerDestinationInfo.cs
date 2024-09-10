// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary>
    /// Properties of the corresponding partner destination of a Channel.
    /// Please note <see cref="PartnerDestinationInfo"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="WebhookPartnerDestinationInfo"/>.
    /// </summary>
    public abstract partial class PartnerDestinationInfo
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PartnerDestinationInfo"/>. </summary>
        protected PartnerDestinationInfo()
        {
            ResourceMoveChangeHistory = new ChangeTrackingList<ResourceMoveChangeHistory>();
        }

        /// <summary> Initializes a new instance of <see cref="PartnerDestinationInfo"/>. </summary>
        /// <param name="azureSubscriptionId">
        /// Azure subscription ID of the subscriber. The partner destination associated with the channel will be
        /// created under this Azure subscription.
        /// </param>
        /// <param name="resourceGroupName">
        /// Azure Resource Group of the subscriber. The partner destination associated with the channel will be
        /// created under this resource group.
        /// </param>
        /// <param name="name"> Name of the partner destination associated with the channel. </param>
        /// <param name="endpointType"> Type of the endpoint for the partner destination. </param>
        /// <param name="endpointServiceContext"> Additional context of the partner destination endpoint. </param>
        /// <param name="resourceMoveChangeHistory"> Change history of the resource move. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PartnerDestinationInfo(string azureSubscriptionId, string resourceGroupName, string name, PartnerEndpointType endpointType, string endpointServiceContext, IList<ResourceMoveChangeHistory> resourceMoveChangeHistory, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AzureSubscriptionId = azureSubscriptionId;
            ResourceGroupName = resourceGroupName;
            Name = name;
            EndpointType = endpointType;
            EndpointServiceContext = endpointServiceContext;
            ResourceMoveChangeHistory = resourceMoveChangeHistory;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Azure subscription ID of the subscriber. The partner destination associated with the channel will be
        /// created under this Azure subscription.
        /// </summary>
        [WirePath("azureSubscriptionId")]
        public string AzureSubscriptionId { get; set; }
        /// <summary>
        /// Azure Resource Group of the subscriber. The partner destination associated with the channel will be
        /// created under this resource group.
        /// </summary>
        [WirePath("resourceGroupName")]
        public string ResourceGroupName { get; set; }
        /// <summary> Name of the partner destination associated with the channel. </summary>
        [WirePath("name")]
        public string Name { get; set; }
        /// <summary> Type of the endpoint for the partner destination. </summary>
        internal PartnerEndpointType EndpointType { get; set; }
        /// <summary> Additional context of the partner destination endpoint. </summary>
        [WirePath("endpointServiceContext")]
        public string EndpointServiceContext { get; set; }
        /// <summary> Change history of the resource move. </summary>
        [WirePath("resourceMoveChangeHistory")]
        public IList<ResourceMoveChangeHistory> ResourceMoveChangeHistory { get; }
    }
}
