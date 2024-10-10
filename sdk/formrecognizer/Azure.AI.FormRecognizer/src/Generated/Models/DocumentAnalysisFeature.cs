// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> The DocumentAnalysisFeature. </summary>
    public readonly partial struct DocumentAnalysisFeature : IEquatable<DocumentAnalysisFeature>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DocumentAnalysisFeature"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DocumentAnalysisFeature(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OcrHighResolutionValue = "ocrHighResolution";
        private const string LanguagesValue = "languages";
        private const string BarcodesValue = "barcodes";
        private const string FormulasValue = "formulas";
        private const string KeyValuePairsValue = "keyValuePairs";
        private const string FontStylingValue = "styleFont";

        /// <summary> Perform OCR at a higher resolution to handle documents with fine print. </summary>
        public static DocumentAnalysisFeature OcrHighResolution { get; } = new DocumentAnalysisFeature(OcrHighResolutionValue);
        /// <summary> Enable the detection of the text content language. </summary>
        public static DocumentAnalysisFeature Languages { get; } = new DocumentAnalysisFeature(LanguagesValue);
        /// <summary> Enable the detection of barcodes in the document. </summary>
        public static DocumentAnalysisFeature Barcodes { get; } = new DocumentAnalysisFeature(BarcodesValue);
        /// <summary> Enable the detection of mathematical expressions in the document. </summary>
        public static DocumentAnalysisFeature Formulas { get; } = new DocumentAnalysisFeature(FormulasValue);
        /// <summary> Enable the detection of general key value pairs (form fields) in the document. </summary>
        public static DocumentAnalysisFeature KeyValuePairs { get; } = new DocumentAnalysisFeature(KeyValuePairsValue);
        /// <summary> Determines if two <see cref="DocumentAnalysisFeature"/> values are the same. </summary>
        public static bool operator ==(DocumentAnalysisFeature left, DocumentAnalysisFeature right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DocumentAnalysisFeature"/> values are not the same. </summary>
        public static bool operator !=(DocumentAnalysisFeature left, DocumentAnalysisFeature right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DocumentAnalysisFeature"/>. </summary>
        public static implicit operator DocumentAnalysisFeature(string value) => new DocumentAnalysisFeature(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DocumentAnalysisFeature other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DocumentAnalysisFeature other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
