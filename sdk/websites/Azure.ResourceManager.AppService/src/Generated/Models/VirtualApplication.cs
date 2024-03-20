// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Virtual application in an app. </summary>
    public partial class VirtualApplication
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

        /// <summary> Initializes a new instance of <see cref="VirtualApplication"/>. </summary>
        public VirtualApplication()
        {
            VirtualDirectories = new ChangeTrackingList<VirtualDirectory>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualApplication"/>. </summary>
        /// <param name="virtualPath"> Virtual path. </param>
        /// <param name="physicalPath"> Physical path. </param>
        /// <param name="isPreloadEnabled"> &lt;code&gt;true&lt;/code&gt; if preloading is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="virtualDirectories"> Virtual directories for virtual application. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualApplication(string virtualPath, string physicalPath, bool? isPreloadEnabled, IList<VirtualDirectory> virtualDirectories, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            VirtualPath = virtualPath;
            PhysicalPath = physicalPath;
            IsPreloadEnabled = isPreloadEnabled;
            VirtualDirectories = virtualDirectories;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Virtual path. </summary>
        public string VirtualPath { get; set; }
        /// <summary> Physical path. </summary>
        public string PhysicalPath { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if preloading is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? IsPreloadEnabled { get; set; }
        /// <summary> Virtual directories for virtual application. </summary>
        public IList<VirtualDirectory> VirtualDirectories { get; }
    }
}
