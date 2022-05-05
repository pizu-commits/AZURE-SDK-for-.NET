// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The UrlSigningActionType. </summary>
    public readonly partial struct UrlSigningActionType : IEquatable<UrlSigningActionType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="UrlSigningActionType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public UrlSigningActionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UrlSigningActionValue = "DeliveryRuleUrlSigningActionParameters";

        /// <summary> DeliveryRuleUrlSigningActionParameters. </summary>
        public static UrlSigningActionType UrlSigningAction { get; } = new UrlSigningActionType(UrlSigningActionValue);
        /// <summary> Determines if two <see cref="UrlSigningActionType"/> values are the same. </summary>
        public static bool operator ==(UrlSigningActionType left, UrlSigningActionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="UrlSigningActionType"/> values are not the same. </summary>
        public static bool operator !=(UrlSigningActionType left, UrlSigningActionType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="UrlSigningActionType"/>. </summary>
        public static implicit operator UrlSigningActionType(string value) => new UrlSigningActionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is UrlSigningActionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(UrlSigningActionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
