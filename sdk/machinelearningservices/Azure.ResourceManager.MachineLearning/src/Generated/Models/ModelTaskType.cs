// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Model task type enum. </summary>
    public readonly partial struct ModelTaskType : IEquatable<ModelTaskType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ModelTaskType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ModelTaskType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ClassificationValue = "Classification";
        private const string RegressionValue = "Regression";

        /// <summary> Classification. </summary>
        public static ModelTaskType Classification { get; } = new ModelTaskType(ClassificationValue);
        /// <summary> Regression. </summary>
        public static ModelTaskType Regression { get; } = new ModelTaskType(RegressionValue);
        /// <summary> Determines if two <see cref="ModelTaskType"/> values are the same. </summary>
        public static bool operator ==(ModelTaskType left, ModelTaskType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ModelTaskType"/> values are not the same. </summary>
        public static bool operator !=(ModelTaskType left, ModelTaskType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ModelTaskType"/>. </summary>
        public static implicit operator ModelTaskType(string value) => new ModelTaskType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ModelTaskType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ModelTaskType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
