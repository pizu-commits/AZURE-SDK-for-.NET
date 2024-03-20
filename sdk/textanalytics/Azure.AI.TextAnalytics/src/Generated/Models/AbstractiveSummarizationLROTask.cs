// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> An object representing the task definition for an Abstractive Summarization task. </summary>
    internal partial class AbstractiveSummarizationLROTask : AnalyzeTextLROTask
    {
        /// <summary> Initializes a new instance of <see cref="AbstractiveSummarizationLROTask"/>. </summary>
        /// <param name="parameters"> Supported parameters for the pre-build Abstractive Summarization task. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public AbstractiveSummarizationLROTask(AbstractiveSummarizationTaskParameters parameters)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            Parameters = parameters;
            Kind = AnalyzeTextLROTaskKind.AbstractiveSummarization;
        }

        /// <summary> Initializes a new instance of <see cref="AbstractiveSummarizationLROTask"/>. </summary>
        /// <param name="taskName"></param>
        /// <param name="kind"> Enumeration of supported long-running Text Analysis tasks. </param>
        /// <param name="parameters"> Supported parameters for the pre-build Abstractive Summarization task. </param>
        internal AbstractiveSummarizationLROTask(string taskName, AnalyzeTextLROTaskKind kind, AbstractiveSummarizationTaskParameters parameters) : base(taskName, kind)
        {
            Parameters = parameters;
            Kind = kind;
        }

        /// <summary> Supported parameters for the pre-build Abstractive Summarization task. </summary>
        public AbstractiveSummarizationTaskParameters Parameters { get; set; }
    }
}
