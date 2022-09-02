// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ConfidentialLedger.Models
{
    /// <summary> The reason why the given name is not available. </summary>
    public readonly partial struct ConfidentialLedgerNameUnavailableReason : IEquatable<ConfidentialLedgerNameUnavailableReason>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ConfidentialLedgerNameUnavailableReason"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ConfidentialLedgerNameUnavailableReason(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidValue = "Invalid";
        private const string AlreadyExistsValue = "AlreadyExists";

        /// <summary> Invalid. </summary>
        public static ConfidentialLedgerNameUnavailableReason Invalid { get; } = new ConfidentialLedgerNameUnavailableReason(InvalidValue);
        /// <summary> AlreadyExists. </summary>
        public static ConfidentialLedgerNameUnavailableReason AlreadyExists { get; } = new ConfidentialLedgerNameUnavailableReason(AlreadyExistsValue);
        /// <summary> Determines if two <see cref="ConfidentialLedgerNameUnavailableReason"/> values are the same. </summary>
        public static bool operator ==(ConfidentialLedgerNameUnavailableReason left, ConfidentialLedgerNameUnavailableReason right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ConfidentialLedgerNameUnavailableReason"/> values are not the same. </summary>
        public static bool operator !=(ConfidentialLedgerNameUnavailableReason left, ConfidentialLedgerNameUnavailableReason right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ConfidentialLedgerNameUnavailableReason"/>. </summary>
        public static implicit operator ConfidentialLedgerNameUnavailableReason(string value) => new ConfidentialLedgerNameUnavailableReason(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ConfidentialLedgerNameUnavailableReason other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ConfidentialLedgerNameUnavailableReason other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
