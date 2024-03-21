// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Details of PrepareNetworkPolicies for Subnet. </summary>
    public partial class PrepareNetworkPoliciesContent
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

        /// <summary> Initializes a new instance of <see cref="PrepareNetworkPoliciesContent"/>. </summary>
        public PrepareNetworkPoliciesContent()
        {
            NetworkIntentPolicyConfigurations = new ChangeTrackingList<NetworkIntentPolicyConfiguration>();
        }

        /// <summary> Initializes a new instance of <see cref="PrepareNetworkPoliciesContent"/>. </summary>
        /// <param name="serviceName"> The name of the service for which subnet is being prepared for. </param>
        /// <param name="networkIntentPolicyConfigurations"> A list of NetworkIntentPolicyConfiguration. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PrepareNetworkPoliciesContent(string serviceName, IList<NetworkIntentPolicyConfiguration> networkIntentPolicyConfigurations, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ServiceName = serviceName;
            NetworkIntentPolicyConfigurations = networkIntentPolicyConfigurations;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the service for which subnet is being prepared for. </summary>
        public string ServiceName { get; set; }
        /// <summary> A list of NetworkIntentPolicyConfiguration. </summary>
        public IList<NetworkIntentPolicyConfiguration> NetworkIntentPolicyConfigurations { get; }
    }
}
