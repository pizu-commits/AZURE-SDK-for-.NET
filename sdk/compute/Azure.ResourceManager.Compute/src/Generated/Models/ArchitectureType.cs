// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies the Architecture Type. </summary>
    public readonly partial struct ArchitectureType : IEquatable<ArchitectureType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ArchitectureType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ArchitectureType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string X64Value = "x64";
        private const string Arm64Value = "Arm64";

        /// <summary> x64. </summary>
        public static ArchitectureType X64 { get; } = new ArchitectureType(X64Value);
        /// <summary> Arm64. </summary>
        public static ArchitectureType Arm64 { get; } = new ArchitectureType(Arm64Value);
        /// <summary> Determines if two <see cref="ArchitectureType"/> values are the same. </summary>
        public static bool operator ==(ArchitectureType left, ArchitectureType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ArchitectureType"/> values are not the same. </summary>
        public static bool operator !=(ArchitectureType left, ArchitectureType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ArchitectureType"/>. </summary>
        public static implicit operator ArchitectureType(string value) => new ArchitectureType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ArchitectureType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ArchitectureType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
