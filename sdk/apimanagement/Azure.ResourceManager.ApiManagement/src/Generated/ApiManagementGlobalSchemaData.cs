// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.ApiManagement.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary> A class representing the ApiManagementGlobalSchema data model. </summary>
    public partial class ApiManagementGlobalSchemaData : ResourceData
    {
        /// <summary> Initializes a new instance of ApiManagementGlobalSchemaData. </summary>
        public ApiManagementGlobalSchemaData()
        {
        }

        /// <summary> Initializes a new instance of ApiManagementGlobalSchemaData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="schemaType"> Schema Type. Immutable. </param>
        /// <param name="description"> Free-form schema entity description. </param>
        /// <param name="value"> Json-encoded string for non json-based schema. </param>
        /// <param name="document"> Global Schema document object for json-based schema formats(e.g. json schema). </param>
        internal ApiManagementGlobalSchemaData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ApiSchemaType? schemaType, string description, BinaryData value, BinaryData document) : base(id, name, resourceType, systemData)
        {
            SchemaType = schemaType;
            Description = description;
            Value = value;
            Document = document;
        }

        /// <summary> Schema Type. Immutable. </summary>
        public ApiSchemaType? SchemaType { get; set; }
        /// <summary> Free-form schema entity description. </summary>
        public string Description { get; set; }
        /// <summary>
        /// Json-encoded string for non json-based schema..
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public BinaryData Value { get; set; }
        /// <summary>
        /// Global Schema document object for json-based schema formats(e.g. json schema)..
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public BinaryData Document { get; set; }
    }
}
