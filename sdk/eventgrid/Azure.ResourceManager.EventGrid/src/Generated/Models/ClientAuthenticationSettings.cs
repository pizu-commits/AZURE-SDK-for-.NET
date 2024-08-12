// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Client authentication settings for namespace resource. </summary>
    public partial class ClientAuthenticationSettings
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

        /// <summary> Initializes a new instance of <see cref="ClientAuthenticationSettings"/>. </summary>
        public ClientAuthenticationSettings()
        {
            AlternativeAuthenticationNameSources = new ChangeTrackingList<AlternativeAuthenticationNameSource>();
        }

        /// <summary> Initializes a new instance of <see cref="ClientAuthenticationSettings"/>. </summary>
        /// <param name="alternativeAuthenticationNameSources"> Alternative authentication name sources related to client authentication settings for namespace resource. </param>
        /// <param name="customJwtAuthentication"> Custom JWT authentication settings for namespace resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ClientAuthenticationSettings(IList<AlternativeAuthenticationNameSource> alternativeAuthenticationNameSources, CustomJwtAuthenticationSettings customJwtAuthentication, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AlternativeAuthenticationNameSources = alternativeAuthenticationNameSources;
            CustomJwtAuthentication = customJwtAuthentication;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Alternative authentication name sources related to client authentication settings for namespace resource. </summary>
        public IList<AlternativeAuthenticationNameSource> AlternativeAuthenticationNameSources { get; }
        /// <summary> Custom JWT authentication settings for namespace resource. </summary>
        public CustomJwtAuthenticationSettings CustomJwtAuthentication { get; set; }
    }
}
