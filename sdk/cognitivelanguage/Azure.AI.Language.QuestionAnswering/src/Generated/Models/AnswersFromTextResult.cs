// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.Language.QuestionAnswering
{
    /// <summary> Represents the answer results. </summary>
    public partial class AnswersFromTextResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AnswersFromTextResult"/>. </summary>
        internal AnswersFromTextResult()
        {
            Answers = new ChangeTrackingList<TextAnswer>();
        }

        /// <summary> Initializes a new instance of <see cref="AnswersFromTextResult"/>. </summary>
        /// <param name="answers"> Represents the answer results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AnswersFromTextResult(IReadOnlyList<TextAnswer> answers, Dictionary<string, BinaryData> rawData)
        {
            Answers = answers;
            _rawData = rawData;
        }

        /// <summary> Represents the answer results. </summary>
        public IReadOnlyList<TextAnswer> Answers { get; }
    }
}
