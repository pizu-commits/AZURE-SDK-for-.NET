// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.MySql.Models;

namespace Azure.ResourceManager.MySql
{
    /// <summary>
    /// A class representing the MySqlVirtualNetworkRule data model.
    /// A virtual network rule.
    /// </summary>
    public partial class MySqlVirtualNetworkRuleData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="MySqlVirtualNetworkRuleData"/>. </summary>
        public MySqlVirtualNetworkRuleData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MySqlVirtualNetworkRuleData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="virtualNetworkSubnetId"> The ARM resource id of the virtual network subnet. </param>
        /// <param name="ignoreMissingVnetServiceEndpoint"> Create firewall rule before the virtual network has vnet service endpoint enabled. </param>
        /// <param name="state"> Virtual Network Rule State. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MySqlVirtualNetworkRuleData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ResourceIdentifier virtualNetworkSubnetId, bool? ignoreMissingVnetServiceEndpoint, MySqlVirtualNetworkRuleState? state, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            VirtualNetworkSubnetId = virtualNetworkSubnetId;
            IgnoreMissingVnetServiceEndpoint = ignoreMissingVnetServiceEndpoint;
            State = state;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The ARM resource id of the virtual network subnet. </summary>
        [WirePath("properties.virtualNetworkSubnetId")]
        public ResourceIdentifier VirtualNetworkSubnetId { get; set; }
        /// <summary> Create firewall rule before the virtual network has vnet service endpoint enabled. </summary>
        [WirePath("properties.ignoreMissingVnetServiceEndpoint")]
        public bool? IgnoreMissingVnetServiceEndpoint { get; set; }
        /// <summary> Virtual Network Rule State. </summary>
        [WirePath("properties.state")]
        public MySqlVirtualNetworkRuleState? State { get; }
    }
}
