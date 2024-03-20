// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> A set of rules governing the network accessibility of a vault. </summary>
    public partial class KeyVaultNetworkRuleSet
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

        /// <summary> Initializes a new instance of <see cref="KeyVaultNetworkRuleSet"/>. </summary>
        public KeyVaultNetworkRuleSet()
        {
            IPRules = new ChangeTrackingList<KeyVaultIPRule>();
            VirtualNetworkRules = new ChangeTrackingList<KeyVaultVirtualNetworkRule>();
        }

        /// <summary> Initializes a new instance of <see cref="KeyVaultNetworkRuleSet"/>. </summary>
        /// <param name="bypass"> Tells what traffic can bypass network rules. This can be 'AzureServices' or 'None'.  If not specified the default is 'AzureServices'. </param>
        /// <param name="defaultAction"> The default action when no rule from ipRules and from virtualNetworkRules match. This is only used after the bypass property has been evaluated. </param>
        /// <param name="ipRules"> The list of IP address rules. </param>
        /// <param name="virtualNetworkRules"> The list of virtual network rules. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal KeyVaultNetworkRuleSet(KeyVaultNetworkRuleBypassOption? bypass, KeyVaultNetworkRuleAction? defaultAction, IList<KeyVaultIPRule> ipRules, IList<KeyVaultVirtualNetworkRule> virtualNetworkRules, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Bypass = bypass;
            DefaultAction = defaultAction;
            IPRules = ipRules;
            VirtualNetworkRules = virtualNetworkRules;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Tells what traffic can bypass network rules. This can be 'AzureServices' or 'None'.  If not specified the default is 'AzureServices'. </summary>
        public KeyVaultNetworkRuleBypassOption? Bypass { get; set; }
        /// <summary> The default action when no rule from ipRules and from virtualNetworkRules match. This is only used after the bypass property has been evaluated. </summary>
        public KeyVaultNetworkRuleAction? DefaultAction { get; set; }
        /// <summary> The list of IP address rules. </summary>
        public IList<KeyVaultIPRule> IPRules { get; }
        /// <summary> The list of virtual network rules. </summary>
        public IList<KeyVaultVirtualNetworkRule> VirtualNetworkRules { get; }
    }
}
