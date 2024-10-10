// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Relay.Models
{
    /// <summary> Status of the connection. </summary>
    public readonly partial struct RelayPrivateLinkConnectionStatus : IEquatable<RelayPrivateLinkConnectionStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RelayPrivateLinkConnectionStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RelayPrivateLinkConnectionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingValue = "Pending";
        private const string ApprovedValue = "Approved";
        private const string RejectedValue = "Rejected";
        private const string DisconnectedValue = "Disconnected";

        /// <summary> Pending. </summary>
        public static RelayPrivateLinkConnectionStatus Pending { get; } = new RelayPrivateLinkConnectionStatus(PendingValue);
        /// <summary> Approved. </summary>
        public static RelayPrivateLinkConnectionStatus Approved { get; } = new RelayPrivateLinkConnectionStatus(ApprovedValue);
        /// <summary> Rejected. </summary>
        public static RelayPrivateLinkConnectionStatus Rejected { get; } = new RelayPrivateLinkConnectionStatus(RejectedValue);
        /// <summary> Disconnected. </summary>
        public static RelayPrivateLinkConnectionStatus Disconnected { get; } = new RelayPrivateLinkConnectionStatus(DisconnectedValue);
        /// <summary> Determines if two <see cref="RelayPrivateLinkConnectionStatus"/> values are the same. </summary>
        public static bool operator ==(RelayPrivateLinkConnectionStatus left, RelayPrivateLinkConnectionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RelayPrivateLinkConnectionStatus"/> values are not the same. </summary>
        public static bool operator !=(RelayPrivateLinkConnectionStatus left, RelayPrivateLinkConnectionStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="RelayPrivateLinkConnectionStatus"/>. </summary>
        public static implicit operator RelayPrivateLinkConnectionStatus(string value) => new RelayPrivateLinkConnectionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RelayPrivateLinkConnectionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RelayPrivateLinkConnectionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
