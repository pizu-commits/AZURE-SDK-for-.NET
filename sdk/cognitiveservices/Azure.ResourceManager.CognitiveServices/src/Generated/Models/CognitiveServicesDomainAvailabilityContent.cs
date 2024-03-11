// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CognitiveServices;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> Check Domain availability parameter. </summary>
    public partial class CognitiveServicesDomainAvailabilityContent
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

        /// <summary> Initializes a new instance of <see cref="CognitiveServicesDomainAvailabilityContent"/>. </summary>
        /// <param name="subdomainName"> The subdomain name to use. </param>
        /// <param name="resourceType"> The Type of the resource. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subdomainName"/> is null. </exception>
        public CognitiveServicesDomainAvailabilityContent(string subdomainName, ResourceType resourceType)
        {
            Argument.AssertNotNull(subdomainName, nameof(subdomainName));

            SubdomainName = subdomainName;
            ResourceType = resourceType;
        }

        /// <summary> Initializes a new instance of <see cref="CognitiveServicesDomainAvailabilityContent"/>. </summary>
        /// <param name="subdomainName"> The subdomain name to use. </param>
        /// <param name="resourceType"> The Type of the resource. </param>
        /// <param name="kind"> The Kind of the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CognitiveServicesDomainAvailabilityContent(string subdomainName, ResourceType resourceType, string kind, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SubdomainName = subdomainName;
            ResourceType = resourceType;
            Kind = kind;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CognitiveServicesDomainAvailabilityContent"/> for deserialization. </summary>
        internal CognitiveServicesDomainAvailabilityContent()
        {
        }

        /// <summary> The subdomain name to use. </summary>
        public string SubdomainName { get; }
        /// <summary> The Type of the resource. </summary>
        public ResourceType ResourceType { get; }
        /// <summary> The Kind of the resource. </summary>
        public string Kind { get; set; }
    }
}
