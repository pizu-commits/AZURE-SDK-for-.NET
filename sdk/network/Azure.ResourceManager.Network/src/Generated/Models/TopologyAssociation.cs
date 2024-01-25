// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Resources that have an association with the parent resource. </summary>
    public partial class TopologyAssociation
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

        /// <summary> Initializes a new instance of <see cref="TopologyAssociation"/>. </summary>
        internal TopologyAssociation()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TopologyAssociation"/>. </summary>
        /// <param name="name"> The name of the resource that is associated with the parent resource. </param>
        /// <param name="resourceId"> The ID of the resource that is associated with the parent resource. </param>
        /// <param name="associationType"> The association type of the child resource to the parent resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TopologyAssociation(string name, ResourceIdentifier resourceId, AssociationType? associationType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            ResourceId = resourceId;
            AssociationType = associationType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the resource that is associated with the parent resource. </summary>
        public string Name { get; }
        /// <summary> The ID of the resource that is associated with the parent resource. </summary>
        public ResourceIdentifier ResourceId { get; }
        /// <summary> The association type of the child resource to the parent resource. </summary>
        public AssociationType? AssociationType { get; }
    }
}
