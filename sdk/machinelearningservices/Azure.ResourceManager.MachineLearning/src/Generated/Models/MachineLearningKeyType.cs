// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningKeyType. </summary>
    public readonly partial struct MachineLearningKeyType : IEquatable<MachineLearningKeyType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MachineLearningKeyType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MachineLearningKeyType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PrimaryValue = "Primary";
        private const string SecondaryValue = "Secondary";

        /// <summary> Primary. </summary>
        public static MachineLearningKeyType Primary { get; } = new MachineLearningKeyType(PrimaryValue);
        /// <summary> Secondary. </summary>
        public static MachineLearningKeyType Secondary { get; } = new MachineLearningKeyType(SecondaryValue);
        /// <summary> Determines if two <see cref="MachineLearningKeyType"/> values are the same. </summary>
        public static bool operator ==(MachineLearningKeyType left, MachineLearningKeyType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MachineLearningKeyType"/> values are not the same. </summary>
        public static bool operator !=(MachineLearningKeyType left, MachineLearningKeyType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="MachineLearningKeyType"/>. </summary>
        public static implicit operator MachineLearningKeyType(string value) => new MachineLearningKeyType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MachineLearningKeyType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MachineLearningKeyType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
