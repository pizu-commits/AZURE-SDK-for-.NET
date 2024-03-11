// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> The custom resource function definition. </summary>
    public partial class DataManifestCustomResourceFunctionDefinition
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

        /// <summary> Initializes a new instance of <see cref="DataManifestCustomResourceFunctionDefinition"/>. </summary>
        internal DataManifestCustomResourceFunctionDefinition()
        {
            DefaultProperties = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="DataManifestCustomResourceFunctionDefinition"/>. </summary>
        /// <param name="name"> The function name as it will appear in the policy rule. eg - 'vault'. </param>
        /// <param name="fullyQualifiedResourceType"> The fully qualified control plane resource type that this function represents. eg - 'Microsoft.KeyVault/vaults'. </param>
        /// <param name="defaultProperties"> The top-level properties that can be selected on the function's output. eg - [ "name", "location" ] if vault().name and vault().location are supported. </param>
        /// <param name="allowCustomProperties"> A value indicating whether the custom properties within the property bag are allowed. Needs api-version to be specified in the policy rule eg - vault('2019-06-01'). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataManifestCustomResourceFunctionDefinition(string name, ResourceType? fullyQualifiedResourceType, IReadOnlyList<string> defaultProperties, bool? allowCustomProperties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            FullyQualifiedResourceType = fullyQualifiedResourceType;
            DefaultProperties = defaultProperties;
            AllowCustomProperties = allowCustomProperties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The function name as it will appear in the policy rule. eg - 'vault'. </summary>
        public string Name { get; }
        /// <summary> The fully qualified control plane resource type that this function represents. eg - 'Microsoft.KeyVault/vaults'. </summary>
        public ResourceType? FullyQualifiedResourceType { get; }
        /// <summary> The top-level properties that can be selected on the function's output. eg - [ "name", "location" ] if vault().name and vault().location are supported. </summary>
        public IReadOnlyList<string> DefaultProperties { get; }
        /// <summary> A value indicating whether the custom properties within the property bag are allowed. Needs api-version to be specified in the policy rule eg - vault('2019-06-01'). </summary>
        public bool? AllowCustomProperties { get; }
    }
}
