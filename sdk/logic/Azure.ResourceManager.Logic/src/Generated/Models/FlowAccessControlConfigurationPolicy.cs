// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The access control configuration policy. </summary>
    public partial class FlowAccessControlConfigurationPolicy
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

        /// <summary> Initializes a new instance of <see cref="FlowAccessControlConfigurationPolicy"/>. </summary>
        public FlowAccessControlConfigurationPolicy()
        {
            AllowedCallerIPAddresses = new ChangeTrackingList<FlowAccessControlIPAddressRange>();
        }

        /// <summary> Initializes a new instance of <see cref="FlowAccessControlConfigurationPolicy"/>. </summary>
        /// <param name="allowedCallerIPAddresses"> The allowed caller IP address ranges. </param>
        /// <param name="openAuthenticationPolicies"> The authentication policies for workflow. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FlowAccessControlConfigurationPolicy(IList<FlowAccessControlIPAddressRange> allowedCallerIPAddresses, OpenAuthenticationAccessPolicies openAuthenticationPolicies, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AllowedCallerIPAddresses = allowedCallerIPAddresses;
            OpenAuthenticationPolicies = openAuthenticationPolicies;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The allowed caller IP address ranges. </summary>
        public IList<FlowAccessControlIPAddressRange> AllowedCallerIPAddresses { get; }
        /// <summary> The authentication policies for workflow. </summary>
        internal OpenAuthenticationAccessPolicies OpenAuthenticationPolicies { get; set; }
        /// <summary> Open authentication policies. </summary>
        public IDictionary<string, OpenAuthenticationAccessPolicy> AccessPolicies
        {
            get
            {
                if (OpenAuthenticationPolicies is null)
                    OpenAuthenticationPolicies = new OpenAuthenticationAccessPolicies();
                return OpenAuthenticationPolicies.AccessPolicies;
            }
        }
    }
}
