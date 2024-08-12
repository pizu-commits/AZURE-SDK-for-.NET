// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Attestation.Models
{
    /// <summary> The private endpoint connection status. </summary>
    public readonly partial struct AttestationPrivateEndpointServiceConnectionStatus : IEquatable<AttestationPrivateEndpointServiceConnectionStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AttestationPrivateEndpointServiceConnectionStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AttestationPrivateEndpointServiceConnectionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingValue = "Pending";
        private const string ApprovedValue = "Approved";
        private const string RejectedValue = "Rejected";

        /// <summary> Pending. </summary>
        public static AttestationPrivateEndpointServiceConnectionStatus Pending { get; } = new AttestationPrivateEndpointServiceConnectionStatus(PendingValue);
        /// <summary> Approved. </summary>
        public static AttestationPrivateEndpointServiceConnectionStatus Approved { get; } = new AttestationPrivateEndpointServiceConnectionStatus(ApprovedValue);
        /// <summary> Rejected. </summary>
        public static AttestationPrivateEndpointServiceConnectionStatus Rejected { get; } = new AttestationPrivateEndpointServiceConnectionStatus(RejectedValue);
        /// <summary> Determines if two <see cref="AttestationPrivateEndpointServiceConnectionStatus"/> values are the same. </summary>
        public static bool operator ==(AttestationPrivateEndpointServiceConnectionStatus left, AttestationPrivateEndpointServiceConnectionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AttestationPrivateEndpointServiceConnectionStatus"/> values are not the same. </summary>
        public static bool operator !=(AttestationPrivateEndpointServiceConnectionStatus left, AttestationPrivateEndpointServiceConnectionStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AttestationPrivateEndpointServiceConnectionStatus"/>. </summary>
        public static implicit operator AttestationPrivateEndpointServiceConnectionStatus(string value) => new AttestationPrivateEndpointServiceConnectionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AttestationPrivateEndpointServiceConnectionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AttestationPrivateEndpointServiceConnectionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
