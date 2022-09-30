// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The value type of the items in the list. </summary>
    public readonly partial struct ValueType : IEquatable<ValueType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ValueType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ValueType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IPCidrValue = "IpCidr";
        private const string StringValue = "String";

        /// <summary> An IP range in CIDR format (e.g. &apos;192.168.0.1/8&apos;). </summary>
        public static ValueType IPCidr { get; } = new ValueType(IPCidrValue);
        /// <summary> Any string value. </summary>
        public static ValueType String { get; } = new ValueType(StringValue);
        /// <summary> Determines if two <see cref="ValueType"/> values are the same. </summary>
        public static bool operator ==(ValueType left, ValueType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ValueType"/> values are not the same. </summary>
        public static bool operator !=(ValueType left, ValueType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ValueType"/>. </summary>
        public static implicit operator ValueType(string value) => new ValueType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ValueType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ValueType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
