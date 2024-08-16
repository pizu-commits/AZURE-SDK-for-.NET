// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Text
{
    /// <summary> An object representing the results for an Custom Abstractive Summarization task. </summary>
    public partial class CustomAbstractiveSummarizationOperationResult : AnalyzeTextOperationResult
    {
        /// <summary> Initializes a new instance of <see cref="CustomAbstractiveSummarizationOperationResult"/>. </summary>
        /// <param name="lastUpdateDateTime"> The last updated time in UTC for the task. </param>
        /// <param name="status"> The status of the task at the mentioned last update time. </param>
        /// <param name="results"> Results of the task. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="results"/> is null. </exception>
        internal CustomAbstractiveSummarizationOperationResult(DateTimeOffset lastUpdateDateTime, TextActionState status, CustomAbstractiveSummarizationResult results) : base(lastUpdateDateTime, status)
        {
            Argument.AssertNotNull(results, nameof(results));

            Kind = AnalyzeTextOperationResultsKind.CustomAbstractiveSummarizationOperationResults;
            Results = results;
        }

        /// <summary> Initializes a new instance of <see cref="CustomAbstractiveSummarizationOperationResult"/>. </summary>
        /// <param name="lastUpdateDateTime"> The last updated time in UTC for the task. </param>
        /// <param name="status"> The status of the task at the mentioned last update time. </param>
        /// <param name="name"> task name. </param>
        /// <param name="kind"> Kind of the task. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="results"> Results of the task. </param>
        internal CustomAbstractiveSummarizationOperationResult(DateTimeOffset lastUpdateDateTime, TextActionState status, string name, AnalyzeTextOperationResultsKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, CustomAbstractiveSummarizationResult results) : base(lastUpdateDateTime, status, name, kind, serializedAdditionalRawData)
        {
            Results = results;
        }

        /// <summary> Initializes a new instance of <see cref="CustomAbstractiveSummarizationOperationResult"/> for deserialization. </summary>
        internal CustomAbstractiveSummarizationOperationResult()
        {
        }

        /// <summary> Results of the task. </summary>
        public CustomAbstractiveSummarizationResult Results { get; }
    }
}
