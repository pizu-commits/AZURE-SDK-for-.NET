// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> The Enum7. </summary>
    public readonly partial struct Enum7 : IEquatable<Enum7>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="Enum7"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Enum7(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AccountValue = "account";

        /// <summary> account. </summary>
        public static Enum7 Account { get; } = new Enum7(AccountValue);
        /// <summary> Determines if two <see cref="Enum7"/> values are the same. </summary>
        public static bool operator ==(Enum7 left, Enum7 right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Enum7"/> values are not the same. </summary>
        public static bool operator !=(Enum7 left, Enum7 right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Enum7"/>. </summary>
        public static implicit operator Enum7(string value) => new Enum7(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Enum7 other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Enum7 other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
