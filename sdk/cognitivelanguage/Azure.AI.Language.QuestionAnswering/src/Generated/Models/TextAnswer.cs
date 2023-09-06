// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.QuestionAnswering
{
    /// <summary> Represents answer result. </summary>
    public partial class TextAnswer
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="TextAnswer"/>. </summary>
        internal TextAnswer()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TextAnswer"/>. </summary>
        /// <param name="answer"> Answer. </param>
        /// <param name="confidence"> answer confidence score, value ranges from 0 to 1. </param>
        /// <param name="id"> record ID. </param>
        /// <param name="shortAnswer"> Answer span object with respect to user's question. </param>
        /// <param name="offset"> The sentence offset from the start of the document. </param>
        /// <param name="length"> The length of the sentence. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal TextAnswer(string answer, double? confidence, string id, AnswerSpan shortAnswer, int? offset, int? length, Dictionary<string, BinaryData> rawData)
        {
            Answer = answer;
            Confidence = confidence;
            Id = id;
            ShortAnswer = shortAnswer;
            Offset = offset;
            Length = length;
            _rawData = rawData;
        }

        /// <summary> Answer. </summary>
        public string Answer { get; }
        /// <summary> answer confidence score, value ranges from 0 to 1. </summary>
        public double? Confidence { get; }
        /// <summary> record ID. </summary>
        public string Id { get; }
        /// <summary> Answer span object with respect to user's question. </summary>
        public AnswerSpan ShortAnswer { get; }
        /// <summary> The sentence offset from the start of the document. </summary>
        public int? Offset { get; }
        /// <summary> The length of the sentence. </summary>
        public int? Length { get; }
    }
}
