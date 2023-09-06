// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.QuestionAnswering
{
    /// <summary> Answer span object of QnA. </summary>
    public partial class AnswerSpan
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AnswerSpan"/>. </summary>
        internal AnswerSpan()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AnswerSpan"/>. </summary>
        /// <param name="text"> Predicted text of answer span. </param>
        /// <param name="confidence"> Predicted score of answer span, value ranges from 0 to 1. </param>
        /// <param name="offset"> The answer span offset from the start of answer. </param>
        /// <param name="length"> The length of the answer span. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AnswerSpan(string text, double? confidence, int? offset, int? length, Dictionary<string, BinaryData> rawData)
        {
            Text = text;
            Confidence = confidence;
            Offset = offset;
            Length = length;
            _rawData = rawData;
        }

        /// <summary> Predicted text of answer span. </summary>
        public string Text { get; }
        /// <summary> Predicted score of answer span, value ranges from 0 to 1. </summary>
        public double? Confidence { get; }
        /// <summary> The answer span offset from the start of answer. </summary>
        public int? Offset { get; }
        /// <summary> The length of the answer span. </summary>
        public int? Length { get; }
    }
}
