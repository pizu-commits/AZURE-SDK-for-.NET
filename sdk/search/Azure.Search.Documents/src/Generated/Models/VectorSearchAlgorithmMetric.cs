// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> The similarity metric to use for vector comparisons. It is recommended to choose the same similarity metric as the embedding model was trained on. </summary>
    public readonly partial struct VectorSearchAlgorithmMetric : IEquatable<VectorSearchAlgorithmMetric>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VectorSearchAlgorithmMetric"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VectorSearchAlgorithmMetric(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CosineValue = "cosine";
        private const string EuclideanValue = "euclidean";
        private const string DotProductValue = "dotProduct";
        private const string HammingValue = "hamming";

        /// <summary> Measures the angle between vectors to quantify their similarity, disregarding magnitude. The smaller the angle, the closer the similarity. </summary>
        public static VectorSearchAlgorithmMetric Cosine { get; } = new VectorSearchAlgorithmMetric(CosineValue);
        /// <summary> Computes the straight-line distance between vectors in a multi-dimensional space. The smaller the distance, the closer the similarity. </summary>
        public static VectorSearchAlgorithmMetric Euclidean { get; } = new VectorSearchAlgorithmMetric(EuclideanValue);
        /// <summary> Calculates the sum of element-wise products to gauge alignment and magnitude similarity. The larger and more positive, the closer the similarity. </summary>
        public static VectorSearchAlgorithmMetric DotProduct { get; } = new VectorSearchAlgorithmMetric(DotProductValue);
        /// <summary> Only applicable to bit-packed binary data types. Determines dissimilarity by counting differing positions in binary vectors. The fewer differences, the closer the similarity. </summary>
        public static VectorSearchAlgorithmMetric Hamming { get; } = new VectorSearchAlgorithmMetric(HammingValue);
        /// <summary> Determines if two <see cref="VectorSearchAlgorithmMetric"/> values are the same. </summary>
        public static bool operator ==(VectorSearchAlgorithmMetric left, VectorSearchAlgorithmMetric right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VectorSearchAlgorithmMetric"/> values are not the same. </summary>
        public static bool operator !=(VectorSearchAlgorithmMetric left, VectorSearchAlgorithmMetric right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="VectorSearchAlgorithmMetric"/>. </summary>
        public static implicit operator VectorSearchAlgorithmMetric(string value) => new VectorSearchAlgorithmMetric(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VectorSearchAlgorithmMetric other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VectorSearchAlgorithmMetric other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
