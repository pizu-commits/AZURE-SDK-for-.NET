﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;

namespace Azure.AI.FormRecognizer.Models
{
    public class RawExtractedLine : RawExtractedItem
    {
        internal RawExtractedLine(TextLine_internal textLine)
        {
            Text = textLine.Text;
            BoundingBox = new BoundingBox(textLine.BoundingBox);
            Language = textLine.Language;
            Words = ConvertWords(textLine.Words);
        }

        /// <summary> Language code. </summary>
        public Language_internal? Language { get; internal set; }
        /// <summary> List of words in the text line. </summary>
        public IReadOnlyList<RawExtractedWord> Words { get; internal set; }

        public static implicit operator string(RawExtractedLine line) => line.Text;

        private static IReadOnlyList<RawExtractedWord> ConvertWords(ICollection<TextWord_internal> textWords)
        {
            List<RawExtractedWord> rawWords = new List<RawExtractedWord>();

            foreach (TextWord_internal textWord in textWords)
            {
                rawWords.Add(new RawExtractedWord(textWord));
            }

            return rawWords.AsReadOnly();
        }
    }
}
