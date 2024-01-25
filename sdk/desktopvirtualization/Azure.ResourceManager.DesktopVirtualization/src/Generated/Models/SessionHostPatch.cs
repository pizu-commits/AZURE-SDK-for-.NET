// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> SessionHost properties that can be patched. </summary>
    public partial class SessionHostPatch : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="SessionHostPatch"/>. </summary>
        public SessionHostPatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SessionHostPatch"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="allowNewSession"> Allow a new session. </param>
        /// <param name="assignedUser"> User assigned to SessionHost. </param>
        /// <param name="friendlyName"> Friendly name of SessionHost. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SessionHostPatch(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, bool? allowNewSession, string assignedUser, string friendlyName, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            AllowNewSession = allowNewSession;
            AssignedUser = assignedUser;
            FriendlyName = friendlyName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Allow a new session. </summary>
        public bool? AllowNewSession { get; set; }
        /// <summary> User assigned to SessionHost. </summary>
        public string AssignedUser { get; set; }
        /// <summary> Friendly name of SessionHost. </summary>
        public string FriendlyName { get; set; }
    }
}
