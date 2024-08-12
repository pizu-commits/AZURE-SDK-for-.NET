// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Address prefix type. </summary>
    public readonly partial struct AddressPrefixType : IEquatable<AddressPrefixType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AddressPrefixType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AddressPrefixType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IPPrefixValue = "IPPrefix";
        private const string ServiceTagValue = "ServiceTag";

        /// <summary> IPPrefix. </summary>
        public static AddressPrefixType IPPrefix { get; } = new AddressPrefixType(IPPrefixValue);
        /// <summary> ServiceTag. </summary>
        public static AddressPrefixType ServiceTag { get; } = new AddressPrefixType(ServiceTagValue);
        /// <summary> Determines if two <see cref="AddressPrefixType"/> values are the same. </summary>
        public static bool operator ==(AddressPrefixType left, AddressPrefixType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AddressPrefixType"/> values are not the same. </summary>
        public static bool operator !=(AddressPrefixType left, AddressPrefixType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AddressPrefixType"/>. </summary>
        public static implicit operator AddressPrefixType(string value) => new AddressPrefixType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AddressPrefixType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AddressPrefixType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
