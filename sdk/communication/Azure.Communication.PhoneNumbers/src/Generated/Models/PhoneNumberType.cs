// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.PhoneNumbers.Models
{
    /// <summary> The type of phone numbers to search for, e.g. geographic, or tollFree. </summary>
    public readonly partial struct PhoneNumberType : IEquatable<PhoneNumberType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="PhoneNumberType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PhoneNumberType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string GeographicValue = "geographic";
        private const string TollFreeValue = "tollFree";

        /// <summary> geographic. </summary>
        public static PhoneNumberType Geographic { get; } = new PhoneNumberType(GeographicValue);
        /// <summary> tollFree. </summary>
        public static PhoneNumberType TollFree { get; } = new PhoneNumberType(TollFreeValue);
        /// <summary> Determines if two <see cref="PhoneNumberType"/> values are the same. </summary>
        public static bool operator ==(PhoneNumberType left, PhoneNumberType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PhoneNumberType"/> values are not the same. </summary>
        public static bool operator !=(PhoneNumberType left, PhoneNumberType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PhoneNumberType"/>. </summary>
        public static implicit operator PhoneNumberType(string value) => new PhoneNumberType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PhoneNumberType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PhoneNumberType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
