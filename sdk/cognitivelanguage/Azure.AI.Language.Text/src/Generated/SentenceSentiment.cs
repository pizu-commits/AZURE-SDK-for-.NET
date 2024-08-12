// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Text
{
    /// <summary> A document's sentence sentiment. </summary>
    public partial class SentenceSentiment
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

        /// <summary> Initializes a new instance of <see cref="SentenceSentiment"/>. </summary>
        /// <param name="text"> The sentence text. </param>
        /// <param name="sentiment"> The predicted Sentiment for the sentence. </param>
        /// <param name="confidenceScores"> The sentiment confidence score between 0 and 1 for the sentence for all classes. </param>
        /// <param name="offset"> The target offset from the start of the sentence. </param>
        /// <param name="length"> The length of the target. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="text"/> or <paramref name="confidenceScores"/> is null. </exception>
        internal SentenceSentiment(string text, SentenceSentimentValue sentiment, SentimentConfidenceScores confidenceScores, int offset, int length)
        {
            Argument.AssertNotNull(text, nameof(text));
            Argument.AssertNotNull(confidenceScores, nameof(confidenceScores));

            Text = text;
            Sentiment = sentiment;
            ConfidenceScores = confidenceScores;
            Offset = offset;
            Length = length;
            Targets = new ChangeTrackingList<SentenceTarget>();
            Assessments = new ChangeTrackingList<SentenceAssessment>();
        }

        /// <summary> Initializes a new instance of <see cref="SentenceSentiment"/>. </summary>
        /// <param name="text"> The sentence text. </param>
        /// <param name="sentiment"> The predicted Sentiment for the sentence. </param>
        /// <param name="confidenceScores"> The sentiment confidence score between 0 and 1 for the sentence for all classes. </param>
        /// <param name="offset"> The target offset from the start of the sentence. </param>
        /// <param name="length"> The length of the target. </param>
        /// <param name="targets"> The array of sentence targets for the sentence. </param>
        /// <param name="assessments"> The array of assessments for the sentence. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SentenceSentiment(string text, SentenceSentimentValue sentiment, SentimentConfidenceScores confidenceScores, int offset, int length, IReadOnlyList<SentenceTarget> targets, IReadOnlyList<SentenceAssessment> assessments, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Text = text;
            Sentiment = sentiment;
            ConfidenceScores = confidenceScores;
            Offset = offset;
            Length = length;
            Targets = targets;
            Assessments = assessments;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SentenceSentiment"/> for deserialization. </summary>
        internal SentenceSentiment()
        {
        }

        /// <summary> The sentence text. </summary>
        public string Text { get; }
        /// <summary> The predicted Sentiment for the sentence. </summary>
        public SentenceSentimentValue Sentiment { get; }
        /// <summary> The sentiment confidence score between 0 and 1 for the sentence for all classes. </summary>
        public SentimentConfidenceScores ConfidenceScores { get; }
        /// <summary> The target offset from the start of the sentence. </summary>
        public int Offset { get; }
        /// <summary> The length of the target. </summary>
        public int Length { get; }
        /// <summary> The array of sentence targets for the sentence. </summary>
        public IReadOnlyList<SentenceTarget> Targets { get; }
        /// <summary> The array of assessments for the sentence. </summary>
        public IReadOnlyList<SentenceAssessment> Assessments { get; }
    }
}
