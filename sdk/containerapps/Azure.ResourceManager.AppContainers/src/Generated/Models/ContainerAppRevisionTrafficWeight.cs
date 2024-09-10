// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Traffic weight assigned to a revision. </summary>
    public partial class ContainerAppRevisionTrafficWeight
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

        /// <summary> Initializes a new instance of <see cref="ContainerAppRevisionTrafficWeight"/>. </summary>
        public ContainerAppRevisionTrafficWeight()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppRevisionTrafficWeight"/>. </summary>
        /// <param name="revisionName"> Name of a revision. </param>
        /// <param name="weight"> Traffic weight assigned to a revision. </param>
        /// <param name="isLatestRevision"> Indicates that the traffic weight belongs to a latest stable revision. </param>
        /// <param name="label"> Associates a traffic label with a revision. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerAppRevisionTrafficWeight(string revisionName, int? weight, bool? isLatestRevision, string label, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RevisionName = revisionName;
            Weight = weight;
            IsLatestRevision = isLatestRevision;
            Label = label;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name of a revision. </summary>
        [WirePath("revisionName")]
        public string RevisionName { get; set; }
        /// <summary> Traffic weight assigned to a revision. </summary>
        [WirePath("weight")]
        public int? Weight { get; set; }
        /// <summary> Indicates that the traffic weight belongs to a latest stable revision. </summary>
        [WirePath("latestRevision")]
        public bool? IsLatestRevision { get; set; }
        /// <summary> Associates a traffic label with a revision. </summary>
        [WirePath("label")]
        public string Label { get; set; }
    }
}
