// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> An object representing the task definition for a Sentiment Analysis task. </summary>
    internal partial class SentimentAnalysisLROTask : AnalyzeTextLROTask
    {
        /// <summary> Initializes a new instance of <see cref="SentimentAnalysisLROTask"/>. </summary>
        public SentimentAnalysisLROTask()
        {
            Kind = AnalyzeTextLROTaskKind.SentimentAnalysis;
        }

        /// <summary> Initializes a new instance of <see cref="SentimentAnalysisLROTask"/>. </summary>
        /// <param name="taskName"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="kind"> Enumeration of supported long-running Text Analysis tasks. </param>
        /// <param name="parameters"> Supported parameters for a Sentiment Analysis task. </param>
        internal SentimentAnalysisLROTask(string taskName, IDictionary<string, BinaryData> serializedAdditionalRawData, AnalyzeTextLROTaskKind kind, SentimentAnalysisTaskParameters parameters) : base(taskName, serializedAdditionalRawData, kind)
        {
            Parameters = parameters;
            Kind = kind;
        }

        /// <summary> Supported parameters for a Sentiment Analysis task. </summary>
        public SentimentAnalysisTaskParameters Parameters { get; set; }
    }
}
