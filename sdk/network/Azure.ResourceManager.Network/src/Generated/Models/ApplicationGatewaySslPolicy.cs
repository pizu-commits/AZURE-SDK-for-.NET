// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Application Gateway Ssl policy. </summary>
    public partial class ApplicationGatewaySslPolicy
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

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewaySslPolicy"/>. </summary>
        public ApplicationGatewaySslPolicy()
        {
            DisabledSslProtocols = new ChangeTrackingList<ApplicationGatewaySslProtocol>();
            CipherSuites = new ChangeTrackingList<ApplicationGatewaySslCipherSuite>();
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewaySslPolicy"/>. </summary>
        /// <param name="disabledSslProtocols"> Ssl protocols to be disabled on application gateway. </param>
        /// <param name="policyType"> Type of Ssl Policy. </param>
        /// <param name="policyName"> Name of Ssl predefined policy. </param>
        /// <param name="cipherSuites"> Ssl cipher suites to be enabled in the specified order to application gateway. </param>
        /// <param name="minProtocolVersion"> Minimum version of Ssl protocol to be supported on application gateway. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplicationGatewaySslPolicy(IList<ApplicationGatewaySslProtocol> disabledSslProtocols, ApplicationGatewaySslPolicyType? policyType, ApplicationGatewaySslPolicyName? policyName, IList<ApplicationGatewaySslCipherSuite> cipherSuites, ApplicationGatewaySslProtocol? minProtocolVersion, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DisabledSslProtocols = disabledSslProtocols;
            PolicyType = policyType;
            PolicyName = policyName;
            CipherSuites = cipherSuites;
            MinProtocolVersion = minProtocolVersion;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Ssl protocols to be disabled on application gateway. </summary>
        public IList<ApplicationGatewaySslProtocol> DisabledSslProtocols { get; }
        /// <summary> Type of Ssl Policy. </summary>
        public ApplicationGatewaySslPolicyType? PolicyType { get; set; }
        /// <summary> Name of Ssl predefined policy. </summary>
        public ApplicationGatewaySslPolicyName? PolicyName { get; set; }
        /// <summary> Ssl cipher suites to be enabled in the specified order to application gateway. </summary>
        public IList<ApplicationGatewaySslCipherSuite> CipherSuites { get; }
        /// <summary> Minimum version of Ssl protocol to be supported on application gateway. </summary>
        public ApplicationGatewaySslProtocol? MinProtocolVersion { get; set; }
    }
}
