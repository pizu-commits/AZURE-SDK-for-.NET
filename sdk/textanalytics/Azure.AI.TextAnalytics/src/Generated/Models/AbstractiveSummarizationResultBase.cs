// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> An object representing the summarization results of each document. </summary>
    internal partial class AbstractiveSummarizationResultBase
    {
        /// <summary> Initializes a new instance of <see cref="AbstractiveSummarizationResultBase"/>. </summary>
        /// <param name="documents"> Response by document. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="documents"/> is null. </exception>
        public AbstractiveSummarizationResultBase(IEnumerable<AbstractiveSummaryDocumentResult> documents)
        {
            Argument.AssertNotNull(documents, nameof(documents));

            Documents = documents.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="AbstractiveSummarizationResultBase"/>. </summary>
        /// <param name="documents"> Response by document. </param>
        internal AbstractiveSummarizationResultBase(IList<AbstractiveSummaryDocumentResult> documents)
        {
            Documents = documents;
        }

        /// <summary> Response by document. </summary>
        public IList<AbstractiveSummaryDocumentResult> Documents { get; }
    }
}
