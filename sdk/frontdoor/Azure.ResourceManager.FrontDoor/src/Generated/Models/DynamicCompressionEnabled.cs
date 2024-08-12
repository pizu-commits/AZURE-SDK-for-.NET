// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> Whether to use dynamic compression for cached content. </summary>
    public readonly partial struct DynamicCompressionEnabled : IEquatable<DynamicCompressionEnabled>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DynamicCompressionEnabled"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DynamicCompressionEnabled(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static DynamicCompressionEnabled Enabled { get; } = new DynamicCompressionEnabled(EnabledValue);
        /// <summary> Disabled. </summary>
        public static DynamicCompressionEnabled Disabled { get; } = new DynamicCompressionEnabled(DisabledValue);
        /// <summary> Determines if two <see cref="DynamicCompressionEnabled"/> values are the same. </summary>
        public static bool operator ==(DynamicCompressionEnabled left, DynamicCompressionEnabled right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DynamicCompressionEnabled"/> values are not the same. </summary>
        public static bool operator !=(DynamicCompressionEnabled left, DynamicCompressionEnabled right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DynamicCompressionEnabled"/>. </summary>
        public static implicit operator DynamicCompressionEnabled(string value) => new DynamicCompressionEnabled(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DynamicCompressionEnabled other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DynamicCompressionEnabled other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
