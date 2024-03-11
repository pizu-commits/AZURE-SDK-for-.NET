// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.Vision.ImageAnalysis
{
    /// <summary> Represents a single line of text in the image. </summary>
    public partial class DetectedTextLine
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

        /// <summary> Initializes a new instance of <see cref="DetectedTextLine"/>. </summary>
        /// <param name="text"> Text content of the detected text line. </param>
        /// <param name="boundingPolygon"> A bounding polygon around the text line. At the moment only quadrilaterals are supported (represented by 4 image points). </param>
        /// <param name="words"> A list of words in this line. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="text"/>, <paramref name="boundingPolygon"/> or <paramref name="words"/> is null. </exception>
        internal DetectedTextLine(string text, IEnumerable<ImagePoint> boundingPolygon, IEnumerable<DetectedTextWord> words)
        {
            Argument.AssertNotNull(text, nameof(text));
            Argument.AssertNotNull(boundingPolygon, nameof(boundingPolygon));
            Argument.AssertNotNull(words, nameof(words));

            Text = text;
            BoundingPolygon = boundingPolygon.ToList();
            Words = words.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="DetectedTextLine"/>. </summary>
        /// <param name="text"> Text content of the detected text line. </param>
        /// <param name="boundingPolygon"> A bounding polygon around the text line. At the moment only quadrilaterals are supported (represented by 4 image points). </param>
        /// <param name="words"> A list of words in this line. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DetectedTextLine(string text, IReadOnlyList<ImagePoint> boundingPolygon, IReadOnlyList<DetectedTextWord> words, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Text = text;
            BoundingPolygon = boundingPolygon;
            Words = words;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DetectedTextLine"/> for deserialization. </summary>
        internal DetectedTextLine()
        {
        }

        /// <summary> Text content of the detected text line. </summary>
        public string Text { get; }
        /// <summary> A bounding polygon around the text line. At the moment only quadrilaterals are supported (represented by 4 image points). </summary>
        public IReadOnlyList<ImagePoint> BoundingPolygon { get; }
        /// <summary> A list of words in this line. </summary>
        public IReadOnlyList<DetectedTextWord> Words { get; }
    }
}
