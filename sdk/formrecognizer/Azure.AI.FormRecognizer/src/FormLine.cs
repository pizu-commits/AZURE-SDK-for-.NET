﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// Represents a line of text recognized from the input document.
    /// </summary>
    public class FormLine : FormElement
    {
        internal FormLine(TextLine_internal textLine, int pageNumber)
            : base(new BoundingBox(textLine.BoundingBox), pageNumber, textLine.Text)
        {
            Words = ConvertWords(textLine.Words, pageNumber);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormLine"/> class.
        /// </summary>
        /// <param name="boundingBox">The quadrilateral bounding box that outlines the text of this element.</param>
        /// <param name="pageNumber">The 1-based number of the page in which this element is present.</param>
        /// <param name="text">The text of this form element.</param>
        /// <param name="words">A list of the words that make up the line.</param>
        internal FormLine(BoundingBox boundingBox, int pageNumber, string text, IReadOnlyList<FormWord> words)
            : base(boundingBox, pageNumber, text)
        {
            Words = words;
        }

        /// <summary>
        /// A list of the words that make up the line.
        /// </summary>
        public IReadOnlyList<FormWord> Words { get; }

        private static IReadOnlyList<FormWord> ConvertWords(IReadOnlyList<TextWord_internal> textWords, int pageNumber)
        {
            List<FormWord> rawWords = new List<FormWord>();

            foreach (TextWord_internal textWord in textWords)
            {
                rawWords.Add(new FormWord(textWord, pageNumber));
            }

            return rawWords;
        }
    }
}
