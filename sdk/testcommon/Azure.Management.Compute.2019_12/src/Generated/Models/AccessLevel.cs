// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Management.Compute.Models
{
    /// <summary> The AccessLevel. </summary>
    public readonly partial struct AccessLevel : IEquatable<AccessLevel>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="AccessLevel"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AccessLevel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string ReadValue = "Read";
        private const string WriteValue = "Write";

        /// <summary> None. </summary>
        public static AccessLevel None { get; } = new AccessLevel(NoneValue);
        /// <summary> Read. </summary>
        public static AccessLevel Read { get; } = new AccessLevel(ReadValue);
        /// <summary> Write. </summary>
        public static AccessLevel Write { get; } = new AccessLevel(WriteValue);
        /// <summary> Determines if two <see cref="AccessLevel"/> values are the same. </summary>
        public static bool operator ==(AccessLevel left, AccessLevel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AccessLevel"/> values are not the same. </summary>
        public static bool operator !=(AccessLevel left, AccessLevel right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AccessLevel"/>. </summary>
        public static implicit operator AccessLevel(string value) => new AccessLevel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AccessLevel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AccessLevel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
