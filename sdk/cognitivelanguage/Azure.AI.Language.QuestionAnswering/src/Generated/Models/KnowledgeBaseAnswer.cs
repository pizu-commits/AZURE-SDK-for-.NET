// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.Language.QuestionAnswering
{
    /// <summary> Represents knowledge base answer. </summary>
    public partial class KnowledgeBaseAnswer
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="KnowledgeBaseAnswer"/>. </summary>
        internal KnowledgeBaseAnswer()
        {
            Questions = new ChangeTrackingList<string>();
            Metadata = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="KnowledgeBaseAnswer"/>. </summary>
        /// <param name="questions"> List of questions associated with the answer. </param>
        /// <param name="answer"> Answer text. </param>
        /// <param name="confidence"> Answer confidence score, value ranges from 0 to 1. </param>
        /// <param name="qnaId"> ID of the QnA result. </param>
        /// <param name="source"> Source of QnA result. </param>
        /// <param name="metadata"> Metadata associated with the answer, useful to categorize or filter question answers. </param>
        /// <param name="dialog"> Dialog associated with Answer. </param>
        /// <param name="shortAnswer"> Answer span object of QnA with respect to user's question. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal KnowledgeBaseAnswer(IReadOnlyList<string> questions, string answer, double? confidence, int? qnaId, string source, IReadOnlyDictionary<string, string> metadata, KnowledgeBaseAnswerDialog dialog, AnswerSpan shortAnswer, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Questions = questions;
            Answer = answer;
            Confidence = confidence;
            QnaId = qnaId;
            Source = source;
            Metadata = metadata;
            Dialog = dialog;
            ShortAnswer = shortAnswer;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of questions associated with the answer. </summary>
        public IReadOnlyList<string> Questions { get; }
        /// <summary> Answer text. </summary>
        public string Answer { get; }
        /// <summary> Answer confidence score, value ranges from 0 to 1. </summary>
        public double? Confidence { get; }
        /// <summary> ID of the QnA result. </summary>
        public int? QnaId { get; }
        /// <summary> Source of QnA result. </summary>
        public string Source { get; }
        /// <summary> Metadata associated with the answer, useful to categorize or filter question answers. </summary>
        public IReadOnlyDictionary<string, string> Metadata { get; }
        /// <summary> Dialog associated with Answer. </summary>
        public KnowledgeBaseAnswerDialog Dialog { get; }
        /// <summary> Answer span object of QnA with respect to user's question. </summary>
        public AnswerSpan ShortAnswer { get; }
    }
}
