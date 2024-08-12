// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Purview.Models
{
    /// <summary> The status. </summary>
    public readonly partial struct PurviewPrivateLinkServiceStatus : IEquatable<PurviewPrivateLinkServiceStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PurviewPrivateLinkServiceStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PurviewPrivateLinkServiceStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string PendingValue = "Pending";
        private const string ApprovedValue = "Approved";
        private const string RejectedValue = "Rejected";
        private const string DisconnectedValue = "Disconnected";

        /// <summary> Unknown. </summary>
        public static PurviewPrivateLinkServiceStatus Unknown { get; } = new PurviewPrivateLinkServiceStatus(UnknownValue);
        /// <summary> Pending. </summary>
        public static PurviewPrivateLinkServiceStatus Pending { get; } = new PurviewPrivateLinkServiceStatus(PendingValue);
        /// <summary> Approved. </summary>
        public static PurviewPrivateLinkServiceStatus Approved { get; } = new PurviewPrivateLinkServiceStatus(ApprovedValue);
        /// <summary> Rejected. </summary>
        public static PurviewPrivateLinkServiceStatus Rejected { get; } = new PurviewPrivateLinkServiceStatus(RejectedValue);
        /// <summary> Disconnected. </summary>
        public static PurviewPrivateLinkServiceStatus Disconnected { get; } = new PurviewPrivateLinkServiceStatus(DisconnectedValue);
        /// <summary> Determines if two <see cref="PurviewPrivateLinkServiceStatus"/> values are the same. </summary>
        public static bool operator ==(PurviewPrivateLinkServiceStatus left, PurviewPrivateLinkServiceStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PurviewPrivateLinkServiceStatus"/> values are not the same. </summary>
        public static bool operator !=(PurviewPrivateLinkServiceStatus left, PurviewPrivateLinkServiceStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PurviewPrivateLinkServiceStatus"/>. </summary>
        public static implicit operator PurviewPrivateLinkServiceStatus(string value) => new PurviewPrivateLinkServiceStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PurviewPrivateLinkServiceStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PurviewPrivateLinkServiceStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
