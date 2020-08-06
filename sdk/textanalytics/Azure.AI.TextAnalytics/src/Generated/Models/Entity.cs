// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The Entity. </summary>
    internal partial class Entity
    {
        /// <summary> Initializes a new instance of Entity. </summary>
        /// <param name="text"> Entity text as appears in the request. </param>
        /// <param name="category"> Entity type, such as Person/Location/Org/SSN etc. </param>
        /// <param name="offset"> Start position for the entity text. </param>
        /// <param name="length"> Length for the entity text. </param>
        /// <param name="confidenceScore"> Confidence score between 0 and 1 of the extracted entity. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="text"/> or <paramref name="category"/> is null. </exception>
        internal Entity(string text, string category, int offset, int length, double confidenceScore)
        {
            if (text == null)
            {
                throw new ArgumentNullException(nameof(text));
            }
            if (category == null)
            {
                throw new ArgumentNullException(nameof(category));
            }

            Text = text;
            Category = category;
            Offset = offset;
            Length = length;
            ConfidenceScore = confidenceScore;
        }

        /// <summary> Initializes a new instance of Entity. </summary>
        /// <param name="text"> Entity text as appears in the request. </param>
        /// <param name="category"> Entity type, such as Person/Location/Org/SSN etc. </param>
        /// <param name="subcategory"> Entity sub type, such as Age/Year/TimeRange etc. </param>
        /// <param name="offset"> Start position for the entity text. </param>
        /// <param name="length"> Length for the entity text. </param>
        /// <param name="confidenceScore"> Confidence score between 0 and 1 of the extracted entity. </param>
        internal Entity(string text, string category, string subcategory, int offset, int length, double confidenceScore)
        {
            Text = text;
            Category = category;
            Subcategory = subcategory;
            Offset = offset;
            Length = length;
            ConfidenceScore = confidenceScore;
        }

        /// <summary> Entity text as appears in the request. </summary>
        public string Text { get; }
        /// <summary> Entity type, such as Person/Location/Org/SSN etc. </summary>
        public string Category { get; }
        /// <summary> Entity sub type, such as Age/Year/TimeRange etc. </summary>
        public string Subcategory { get; }
        /// <summary> Start position for the entity text. </summary>
        public int Offset { get; }
        /// <summary> Length for the entity text. </summary>
        public int Length { get; }
        /// <summary> Confidence score between 0 and 1 of the extracted entity. </summary>
        public double ConfidenceScore { get; }
    }
}
