// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing the TenantAccessInfo data model.
    /// Tenant Settings.
    /// </summary>
    public partial class TenantAccessInfoData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="TenantAccessInfoData"/>. </summary>
        public TenantAccessInfoData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TenantAccessInfoData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="accessInfoType"> Access Information type ('access' or 'gitAccess'). </param>
        /// <param name="principalId"> Principal (User) Identifier. </param>
        /// <param name="isDirectAccessEnabled"> Determines whether direct access is enabled. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TenantAccessInfoData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string accessInfoType, string principalId, bool? isDirectAccessEnabled, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            AccessInfoType = accessInfoType;
            PrincipalId = principalId;
            IsDirectAccessEnabled = isDirectAccessEnabled;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Access Information type ('access' or 'gitAccess'). </summary>
        public string AccessInfoType { get; set; }
        /// <summary> Principal (User) Identifier. </summary>
        public string PrincipalId { get; set; }
        /// <summary> Determines whether direct access is enabled. </summary>
        public bool? IsDirectAccessEnabled { get; set; }
    }
}
