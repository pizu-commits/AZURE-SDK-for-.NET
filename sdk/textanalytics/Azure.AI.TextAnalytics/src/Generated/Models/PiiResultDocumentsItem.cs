// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.AI.TextAnalytics;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The PiiResultDocumentsItem. </summary>
    internal partial class PiiResultDocumentsItem : PiiEntitiesDocumentResult
    {
        /// <summary> Initializes a new instance of PiiResultDocumentsItem. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        /// <param name="redactedText"> Returns redacted text. </param>
        /// <param name="entities"> Recognized entities in the document. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="warnings"/>, <paramref name="redactedText"/> or <paramref name="entities"/> is null. </exception>
        public PiiResultDocumentsItem(string id, IEnumerable<DocumentWarning> warnings, string redactedText, IEnumerable<Entity> entities) : base(id, warnings, redactedText, entities)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (warnings == null)
            {
                throw new ArgumentNullException(nameof(warnings));
            }
            if (redactedText == null)
            {
                throw new ArgumentNullException(nameof(redactedText));
            }
            if (entities == null)
            {
                throw new ArgumentNullException(nameof(entities));
            }
        }

        /// <summary> Initializes a new instance of PiiResultDocumentsItem. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        /// <param name="statistics"> if showStats=true was specified in the request this field will contain information about the document payload. </param>
        /// <param name="redactedText"> Returns redacted text. </param>
        /// <param name="entities"> Recognized entities in the document. </param>
        internal PiiResultDocumentsItem(string id, IList<DocumentWarning> warnings, TextDocumentStatistics? statistics, string redactedText, IList<Entity> entities) : base(id, warnings, statistics, redactedText, entities)
        {
        }
    }
}
