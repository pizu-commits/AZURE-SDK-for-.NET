// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;

namespace Azure.ResourceManager.DataLakeStore.Models
{
    /// <summary> The parameters used to create a new firewall rule. </summary>
    public partial class DataLakeStoreFirewallRuleCreateOrUpdateContent
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

        /// <summary> Initializes a new instance of <see cref="DataLakeStoreFirewallRuleCreateOrUpdateContent"/>. </summary>
        /// <param name="startIPAddress"> The start IP address for the firewall rule. This can be either ipv4 or ipv6. Start and End should be in the same protocol. </param>
        /// <param name="endIPAddress"> The end IP address for the firewall rule. This can be either ipv4 or ipv6. Start and End should be in the same protocol. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="startIPAddress"/> or <paramref name="endIPAddress"/> is null. </exception>
        public DataLakeStoreFirewallRuleCreateOrUpdateContent(IPAddress startIPAddress, IPAddress endIPAddress)
        {
            Argument.AssertNotNull(startIPAddress, nameof(startIPAddress));
            Argument.AssertNotNull(endIPAddress, nameof(endIPAddress));

            StartIPAddress = startIPAddress;
            EndIPAddress = endIPAddress;
        }

        /// <summary> Initializes a new instance of <see cref="DataLakeStoreFirewallRuleCreateOrUpdateContent"/>. </summary>
        /// <param name="startIPAddress"> The start IP address for the firewall rule. This can be either ipv4 or ipv6. Start and End should be in the same protocol. </param>
        /// <param name="endIPAddress"> The end IP address for the firewall rule. This can be either ipv4 or ipv6. Start and End should be in the same protocol. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataLakeStoreFirewallRuleCreateOrUpdateContent(IPAddress startIPAddress, IPAddress endIPAddress, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            StartIPAddress = startIPAddress;
            EndIPAddress = endIPAddress;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataLakeStoreFirewallRuleCreateOrUpdateContent"/> for deserialization. </summary>
        internal DataLakeStoreFirewallRuleCreateOrUpdateContent()
        {
        }

        /// <summary> The start IP address for the firewall rule. This can be either ipv4 or ipv6. Start and End should be in the same protocol. </summary>
        public IPAddress StartIPAddress { get; }
        /// <summary> The end IP address for the firewall rule. This can be either ipv4 or ipv6. Start and End should be in the same protocol. </summary>
        public IPAddress EndIPAddress { get; }
    }
}
