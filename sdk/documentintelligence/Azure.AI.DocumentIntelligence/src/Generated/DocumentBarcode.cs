// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.DocumentIntelligence
{
    /// <summary> A barcode object. </summary>
    public partial class DocumentBarcode
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

        /// <summary> Initializes a new instance of <see cref="DocumentBarcode"/>. </summary>
        /// <param name="kind"> Barcode kind. </param>
        /// <param name="value"> Barcode value. </param>
        /// <param name="span"> Location of the barcode in the reading order concatenated content. </param>
        /// <param name="confidence"> Confidence of correctly extracting the barcode. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> or <paramref name="span"/> is null. </exception>
        internal DocumentBarcode(DocumentBarcodeKind kind, string value, DocumentSpan span, float confidence)
        {
            Argument.AssertNotNull(value, nameof(value));
            Argument.AssertNotNull(span, nameof(span));

            Kind = kind;
            Value = value;
            Polygon = new ChangeTrackingList<float>();
            Span = span;
            Confidence = confidence;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentBarcode"/>. </summary>
        /// <param name="kind"> Barcode kind. </param>
        /// <param name="value"> Barcode value. </param>
        /// <param name="polygon">
        /// Bounding polygon of the barcode, with coordinates specified relative to the
        /// top-left of the page. The numbers represent the x, y values of the polygon
        /// vertices, clockwise from the left (-180 degrees inclusive) relative to the
        /// element orientation.
        /// </param>
        /// <param name="span"> Location of the barcode in the reading order concatenated content. </param>
        /// <param name="confidence"> Confidence of correctly extracting the barcode. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DocumentBarcode(DocumentBarcodeKind kind, string value, IReadOnlyList<float> polygon, DocumentSpan span, float confidence, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Kind = kind;
            Value = value;
            Polygon = polygon;
            Span = span;
            Confidence = confidence;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentBarcode"/> for deserialization. </summary>
        internal DocumentBarcode()
        {
        }

        /// <summary> Barcode kind. </summary>
        public DocumentBarcodeKind Kind { get; }
        /// <summary> Barcode value. </summary>
        public string Value { get; }
        /// <summary>
        /// Bounding polygon of the barcode, with coordinates specified relative to the
        /// top-left of the page. The numbers represent the x, y values of the polygon
        /// vertices, clockwise from the left (-180 degrees inclusive) relative to the
        /// element orientation.
        /// </summary>
        public IReadOnlyList<float> Polygon { get; }
        /// <summary> Location of the barcode in the reading order concatenated content. </summary>
        public DocumentSpan Span { get; }
        /// <summary> Confidence of correctly extracting the barcode. </summary>
        public float Confidence { get; }
    }
}
