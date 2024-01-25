// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Action to be taken on a route matching a RouteMap criterion. </summary>
    public partial class RouteMapAction
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

        /// <summary> Initializes a new instance of <see cref="RouteMapAction"/>. </summary>
        public RouteMapAction()
        {
            Parameters = new ChangeTrackingList<RouteMapActionParameter>();
        }

        /// <summary> Initializes a new instance of <see cref="RouteMapAction"/>. </summary>
        /// <param name="actionType"> Type of action to be taken. Supported types are 'Remove', 'Add', 'Replace', and 'Drop.'. </param>
        /// <param name="parameters"> List of parameters relevant to the action.For instance if type is drop then parameters has list of prefixes to be dropped.If type is add, parameters would have list of ASN numbers to be added. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RouteMapAction(RouteMapActionType? actionType, IList<RouteMapActionParameter> parameters, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ActionType = actionType;
            Parameters = parameters;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Type of action to be taken. Supported types are 'Remove', 'Add', 'Replace', and 'Drop.'. </summary>
        public RouteMapActionType? ActionType { get; set; }
        /// <summary> List of parameters relevant to the action.For instance if type is drop then parameters has list of prefixes to be dropped.If type is add, parameters would have list of ASN numbers to be added. </summary>
        public IList<RouteMapActionParameter> Parameters { get; }
    }
}
