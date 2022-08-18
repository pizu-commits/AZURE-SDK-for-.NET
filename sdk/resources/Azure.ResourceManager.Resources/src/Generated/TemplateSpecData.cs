// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class representing the TemplateSpec data model. </summary>
    public partial class TemplateSpecData : ResourceData
    {
        /// <summary> Initializes a new instance of TemplateSpecData. </summary>
        /// <param name="location"> The location of the Template Spec. It cannot be changed after Template Spec creation. It must be one of the supported Azure locations. </param>
        public TemplateSpecData(AzureLocation location)
        {
            Location = location;
            Tags = new ChangeTrackingDictionary<string, string>();
            Versions = new ChangeTrackingDictionary<string, TemplateSpecVersionInfo>();
        }

        /// <summary> Initializes a new instance of TemplateSpecData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> The location of the Template Spec. It cannot be changed after Template Spec creation. It must be one of the supported Azure locations. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="description"> Template Spec description. </param>
        /// <param name="displayName"> Template Spec display name. </param>
        /// <param name="metadata"> The Template Spec metadata. Metadata is an open-ended object and is typically a collection of key-value pairs. </param>
        /// <param name="versions"> High-level information about the versions within this Template Spec. The keys are the version names. Only populated if the $expand query parameter is set to &apos;versions&apos;. </param>
        internal TemplateSpecData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation location, IDictionary<string, string> tags, string description, string displayName, BinaryData metadata, IReadOnlyDictionary<string, TemplateSpecVersionInfo> versions) : base(id, name, resourceType, systemData)
        {
            Location = location;
            Tags = tags;
            Description = description;
            DisplayName = displayName;
            Metadata = metadata;
            Versions = versions;
        }

        /// <summary> The location of the Template Spec. It cannot be changed after Template Spec creation. It must be one of the supported Azure locations. </summary>
        public AzureLocation Location { get; set; }
        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Template Spec description. </summary>
        public string Description { get; set; }
        /// <summary> Template Spec display name. </summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// The Template Spec metadata. Metadata is an open-ended object and is typically a collection of key-value pairs..
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
        public BinaryData Metadata { get; set; }
        /// <summary> High-level information about the versions within this Template Spec. The keys are the version names. Only populated if the $expand query parameter is set to &apos;versions&apos;. </summary>
        public IReadOnlyDictionary<string, TemplateSpecVersionInfo> Versions { get; }
    }
}
