// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Properties of a private link resource. </summary>
    public partial class AppServicePrivateLinkResourceProperties
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

        /// <summary> Initializes a new instance of <see cref="AppServicePrivateLinkResourceProperties"/>. </summary>
        internal AppServicePrivateLinkResourceProperties()
        {
            RequiredMembers = new ChangeTrackingList<string>();
            RequiredZoneNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="AppServicePrivateLinkResourceProperties"/>. </summary>
        /// <param name="groupId"> GroupId of a private link resource. </param>
        /// <param name="requiredMembers"> RequiredMembers of a private link resource. </param>
        /// <param name="requiredZoneNames"> RequiredZoneNames of a private link resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppServicePrivateLinkResourceProperties(string groupId, IReadOnlyList<string> requiredMembers, IReadOnlyList<string> requiredZoneNames, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            GroupId = groupId;
            RequiredMembers = requiredMembers;
            RequiredZoneNames = requiredZoneNames;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> GroupId of a private link resource. </summary>
        public string GroupId { get; }
        /// <summary> RequiredMembers of a private link resource. </summary>
        public IReadOnlyList<string> RequiredMembers { get; }
        /// <summary> RequiredZoneNames of a private link resource. </summary>
        public IReadOnlyList<string> RequiredZoneNames { get; }
    }
}
