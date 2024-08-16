// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.Language.Text
{
    /// <summary> Contains the Dynamic Classification result. </summary>
    public partial class DynamicClassificationResult
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

        /// <summary> Initializes a new instance of <see cref="DynamicClassificationResult"/>. </summary>
        /// <param name="errors"> Errors by document id. </param>
        /// <param name="modelVersion"> This field indicates which model is used for scoring. </param>
        /// <param name="documents"> Response by document. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="errors"/>, <paramref name="modelVersion"/> or <paramref name="documents"/> is null. </exception>
        internal DynamicClassificationResult(IEnumerable<DocumentError> errors, string modelVersion, IEnumerable<DynamicClassificationDocumentResult> documents)
        {
            Argument.AssertNotNull(errors, nameof(errors));
            Argument.AssertNotNull(modelVersion, nameof(modelVersion));
            Argument.AssertNotNull(documents, nameof(documents));

            Errors = errors.ToList();
            ModelVersion = modelVersion;
            Documents = documents.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="DynamicClassificationResult"/>. </summary>
        /// <param name="errors"> Errors by document id. </param>
        /// <param name="statistics"> if showStats=true was specified in the request this field will contain information about the request payload. </param>
        /// <param name="modelVersion"> This field indicates which model is used for scoring. </param>
        /// <param name="documents"> Response by document. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DynamicClassificationResult(IReadOnlyList<DocumentError> errors, RequestStatistics statistics, string modelVersion, IReadOnlyList<DynamicClassificationDocumentResult> documents, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Errors = errors;
            Statistics = statistics;
            ModelVersion = modelVersion;
            Documents = documents;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DynamicClassificationResult"/> for deserialization. </summary>
        internal DynamicClassificationResult()
        {
        }

        /// <summary> Errors by document id. </summary>
        public IReadOnlyList<DocumentError> Errors { get; }
        /// <summary> if showStats=true was specified in the request this field will contain information about the request payload. </summary>
        public RequestStatistics Statistics { get; }
        /// <summary> This field indicates which model is used for scoring. </summary>
        public string ModelVersion { get; }
        /// <summary> Response by document. </summary>
        public IReadOnlyList<DynamicClassificationDocumentResult> Documents { get; }
    }
}
