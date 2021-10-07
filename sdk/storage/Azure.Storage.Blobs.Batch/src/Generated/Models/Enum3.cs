// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Storage.Blobs.Batch.Models
{
    /// <summary> The Enum3. </summary>
    public readonly partial struct Enum3 : IEquatable<Enum3>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="Enum3"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Enum3(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TierValue = "tier";

        /// <summary> tier. </summary>
        public static Enum3 Tier { get; } = new Enum3(TierValue);
        /// <summary> Determines if two <see cref="Enum3"/> values are the same. </summary>
        public static bool operator ==(Enum3 left, Enum3 right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Enum3"/> values are not the same. </summary>
        public static bool operator !=(Enum3 left, Enum3 right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Enum3"/>. </summary>
        public static implicit operator Enum3(string value) => new Enum3(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Enum3 other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Enum3 other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
