// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> The type of the parameter. </summary>
    public readonly partial struct ParameterType : IEquatable<ParameterType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ParameterType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ParameterType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StringValue = "string";
        private const string SecretStringValue = "secretString";
        private const string IntValue = "int";
        private const string DoubleValue = "double";
        private const string BoolValue = "bool";

        /// <summary> A string parameter value. </summary>
        public static ParameterType String { get; } = new ParameterType(StringValue);
        /// <summary> A string to hold sensitive information as parameter value. </summary>
        public static ParameterType SecretString { get; } = new ParameterType(SecretStringValue);
        /// <summary> A 32-bit signed integer as parameter value. </summary>
        public static ParameterType Int { get; } = new ParameterType(IntValue);
        /// <summary> A 64-bit double-precision floating point type as parameter value. </summary>
        public static ParameterType Double { get; } = new ParameterType(DoubleValue);
        /// <summary> A boolean value that is either true or false. </summary>
        public static ParameterType Bool { get; } = new ParameterType(BoolValue);
        /// <summary> Determines if two <see cref="ParameterType"/> values are the same. </summary>
        public static bool operator ==(ParameterType left, ParameterType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ParameterType"/> values are not the same. </summary>
        public static bool operator !=(ParameterType left, ParameterType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ParameterType"/>. </summary>
        public static implicit operator ParameterType(string value) => new ParameterType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ParameterType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ParameterType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
