// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The ExtendedErrorInfo. </summary>
    public partial class ExtendedErrorInfo
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

        /// <summary> Initializes a new instance of <see cref="ExtendedErrorInfo"/>. </summary>
        public ExtendedErrorInfo()
        {
            Details = new ChangeTrackingList<ExtendedErrorInfo>();
            AdditionalInfo = new ChangeTrackingList<TypedErrorInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="ExtendedErrorInfo"/>. </summary>
        /// <param name="code"></param>
        /// <param name="target"></param>
        /// <param name="message"></param>
        /// <param name="details"></param>
        /// <param name="additionalInfo"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ExtendedErrorInfo(string code, string target, string message, IList<ExtendedErrorInfo> details, IList<TypedErrorInfo> additionalInfo, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Code = code;
            Target = target;
            Message = message;
            Details = details;
            AdditionalInfo = additionalInfo;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the code. </summary>
        public string Code { get; set; }
        /// <summary> Gets or sets the target. </summary>
        public string Target { get; set; }
        /// <summary> Gets or sets the message. </summary>
        public string Message { get; set; }
        /// <summary> Gets the details. </summary>
        public IList<ExtendedErrorInfo> Details { get; }
        /// <summary> Gets the additional info. </summary>
        public IList<TypedErrorInfo> AdditionalInfo { get; }
    }
}
