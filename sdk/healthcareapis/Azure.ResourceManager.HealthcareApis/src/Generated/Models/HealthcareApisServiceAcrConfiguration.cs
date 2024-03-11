// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.HealthcareApis;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    /// <summary> Azure container registry configuration information. </summary>
    public partial class HealthcareApisServiceAcrConfiguration
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

        /// <summary> Initializes a new instance of <see cref="HealthcareApisServiceAcrConfiguration"/>. </summary>
        public HealthcareApisServiceAcrConfiguration()
        {
            LoginServers = new ChangeTrackingList<string>();
            OciArtifacts = new ChangeTrackingList<HealthcareApisServiceOciArtifactEntry>();
        }

        /// <summary> Initializes a new instance of <see cref="HealthcareApisServiceAcrConfiguration"/>. </summary>
        /// <param name="loginServers"> The list of the ACR login servers. </param>
        /// <param name="ociArtifacts"> The list of Open Container Initiative (OCI) artifacts. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HealthcareApisServiceAcrConfiguration(IList<string> loginServers, IList<HealthcareApisServiceOciArtifactEntry> ociArtifacts, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            LoginServers = loginServers;
            OciArtifacts = ociArtifacts;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of the ACR login servers. </summary>
        public IList<string> LoginServers { get; }
        /// <summary> The list of Open Container Initiative (OCI) artifacts. </summary>
        public IList<HealthcareApisServiceOciArtifactEntry> OciArtifacts { get; }
    }
}
