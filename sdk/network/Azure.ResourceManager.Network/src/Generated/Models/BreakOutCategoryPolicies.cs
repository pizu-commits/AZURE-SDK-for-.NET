// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Network Virtual Appliance Sku Properties. </summary>
    public partial class BreakOutCategoryPolicies
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

        /// <summary> Initializes a new instance of <see cref="BreakOutCategoryPolicies"/>. </summary>
        public BreakOutCategoryPolicies()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BreakOutCategoryPolicies"/>. </summary>
        /// <param name="allow"> Flag to control breakout of o365 allow category. </param>
        /// <param name="optimize"> Flag to control breakout of o365 optimize category. </param>
        /// <param name="default"> Flag to control breakout of o365 default category. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BreakOutCategoryPolicies(bool? allow, bool? optimize, bool? @default, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Allow = allow;
            Optimize = optimize;
            Default = @default;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Flag to control breakout of o365 allow category. </summary>
        public bool? Allow { get; set; }
        /// <summary> Flag to control breakout of o365 optimize category. </summary>
        public bool? Optimize { get; set; }
        /// <summary> Flag to control breakout of o365 default category. </summary>
        public bool? Default { get; set; }
    }
}
