// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Role definition permissions. </summary>
    public partial class Permission
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

        /// <summary> Initializes a new instance of <see cref="Permission"/>. </summary>
        internal Permission()
        {
            AllowedActions = new ChangeTrackingList<string>();
            DeniedActions = new ChangeTrackingList<string>();
            AllowedDataActions = new ChangeTrackingList<string>();
            DeniedDataActions = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="Permission"/>. </summary>
        /// <param name="allowedActions"> Allowed actions. </param>
        /// <param name="deniedActions"> Denied actions. </param>
        /// <param name="allowedDataActions"> Allowed Data actions. </param>
        /// <param name="deniedDataActions"> Denied Data actions. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal Permission(IReadOnlyList<string> allowedActions, IReadOnlyList<string> deniedActions, IReadOnlyList<string> allowedDataActions, IReadOnlyList<string> deniedDataActions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AllowedActions = allowedActions;
            DeniedActions = deniedActions;
            AllowedDataActions = allowedDataActions;
            DeniedDataActions = deniedDataActions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Allowed actions. </summary>
        public IReadOnlyList<string> AllowedActions { get; }
        /// <summary> Denied actions. </summary>
        public IReadOnlyList<string> DeniedActions { get; }
        /// <summary> Allowed Data actions. </summary>
        public IReadOnlyList<string> AllowedDataActions { get; }
        /// <summary> Denied Data actions. </summary>
        public IReadOnlyList<string> DeniedDataActions { get; }
    }
}
