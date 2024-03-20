// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Result of AmlCompute Nodes. </summary>
    internal partial class AmlComputeNodesInformation
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

        /// <summary> Initializes a new instance of <see cref="AmlComputeNodesInformation"/>. </summary>
        internal AmlComputeNodesInformation()
        {
            Nodes = new ChangeTrackingList<AmlComputeNodeInformation>();
        }

        /// <summary> Initializes a new instance of <see cref="AmlComputeNodesInformation"/>. </summary>
        /// <param name="nodes"> The collection of returned AmlCompute nodes details. </param>
        /// <param name="nextLink"> The continuation token. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AmlComputeNodesInformation(IReadOnlyList<AmlComputeNodeInformation> nodes, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Nodes = nodes;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The collection of returned AmlCompute nodes details. </summary>
        public IReadOnlyList<AmlComputeNodeInformation> Nodes { get; }
        /// <summary> The continuation token. </summary>
        public string NextLink { get; }
    }
}
