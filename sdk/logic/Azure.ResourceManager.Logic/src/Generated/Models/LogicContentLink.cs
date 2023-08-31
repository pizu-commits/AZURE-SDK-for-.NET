// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The content link. </summary>
    public partial class LogicContentLink
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="LogicContentLink"/>. </summary>
        public LogicContentLink()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LogicContentLink"/>. </summary>
        /// <param name="uri"> The content link URI. </param>
        /// <param name="contentVersion"> The content version. </param>
        /// <param name="contentSize"> The content size. </param>
        /// <param name="contentHash"> The content hash. </param>
        /// <param name="metadata"> The metadata. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal LogicContentLink(Uri uri, string contentVersion, long? contentSize, LogicContentHash contentHash, BinaryData metadata, Dictionary<string, BinaryData> rawData)
        {
            Uri = uri;
            ContentVersion = contentVersion;
            ContentSize = contentSize;
            ContentHash = contentHash;
            Metadata = metadata;
            _rawData = rawData;
        }

        /// <summary> The content link URI. </summary>
        public Uri Uri { get; set; }
        /// <summary> The content version. </summary>
        public string ContentVersion { get; }
        /// <summary> The content size. </summary>
        public long? ContentSize { get; }
        /// <summary> The content hash. </summary>
        public LogicContentHash ContentHash { get; }
        /// <summary>
        /// The metadata.
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
        public BinaryData Metadata { get; }
    }
}
