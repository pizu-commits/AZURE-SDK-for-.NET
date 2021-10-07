// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Storage.Files.Shares.Models
{
    /// <summary> The Enum20. </summary>
    public readonly partial struct Enum20 : IEquatable<Enum20>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="Enum20"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Enum20(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CopyValue = "copy";

        /// <summary> copy. </summary>
        public static Enum20 Copy { get; } = new Enum20(CopyValue);
        /// <summary> Determines if two <see cref="Enum20"/> values are the same. </summary>
        public static bool operator ==(Enum20 left, Enum20 right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Enum20"/> values are not the same. </summary>
        public static bool operator !=(Enum20 left, Enum20 right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Enum20"/>. </summary>
        public static implicit operator Enum20(string value) => new Enum20(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Enum20 other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Enum20 other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
