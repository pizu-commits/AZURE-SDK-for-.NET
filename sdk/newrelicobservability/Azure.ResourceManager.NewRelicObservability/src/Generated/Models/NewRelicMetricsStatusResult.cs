// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    /// <summary> Response of get metrics status Operation. </summary>
    public partial class NewRelicMetricsStatusResult
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

        /// <summary> Initializes a new instance of <see cref="NewRelicMetricsStatusResult"/>. </summary>
        internal NewRelicMetricsStatusResult()
        {
            AzureResourceIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="NewRelicMetricsStatusResult"/>. </summary>
        /// <param name="azureResourceIds"> Azure resource IDs. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NewRelicMetricsStatusResult(IReadOnlyList<string> azureResourceIds, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AzureResourceIds = azureResourceIds;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Azure resource IDs. </summary>
        [WirePath("azureResourceIds")]
        public IReadOnlyList<string> AzureResourceIds { get; }
    }
}
