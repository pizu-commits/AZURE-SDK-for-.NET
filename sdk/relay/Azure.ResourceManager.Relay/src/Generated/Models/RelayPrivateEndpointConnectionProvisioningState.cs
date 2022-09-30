// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Relay.Models
{
    /// <summary> Provisioning state of the Private Endpoint Connection. </summary>
    public readonly partial struct RelayPrivateEndpointConnectionProvisioningState : IEquatable<RelayPrivateEndpointConnectionProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RelayPrivateEndpointConnectionProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RelayPrivateEndpointConnectionProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string UpdatingValue = "Updating";
        private const string DeletingValue = "Deleting";
        private const string SucceededValue = "Succeeded";
        private const string CanceledValue = "Canceled";
        private const string FailedValue = "Failed";

        /// <summary> Creating. </summary>
        public static RelayPrivateEndpointConnectionProvisioningState Creating { get; } = new RelayPrivateEndpointConnectionProvisioningState(CreatingValue);
        /// <summary> Updating. </summary>
        public static RelayPrivateEndpointConnectionProvisioningState Updating { get; } = new RelayPrivateEndpointConnectionProvisioningState(UpdatingValue);
        /// <summary> Deleting. </summary>
        public static RelayPrivateEndpointConnectionProvisioningState Deleting { get; } = new RelayPrivateEndpointConnectionProvisioningState(DeletingValue);
        /// <summary> Succeeded. </summary>
        public static RelayPrivateEndpointConnectionProvisioningState Succeeded { get; } = new RelayPrivateEndpointConnectionProvisioningState(SucceededValue);
        /// <summary> Canceled. </summary>
        public static RelayPrivateEndpointConnectionProvisioningState Canceled { get; } = new RelayPrivateEndpointConnectionProvisioningState(CanceledValue);
        /// <summary> Failed. </summary>
        public static RelayPrivateEndpointConnectionProvisioningState Failed { get; } = new RelayPrivateEndpointConnectionProvisioningState(FailedValue);
        /// <summary> Determines if two <see cref="RelayPrivateEndpointConnectionProvisioningState"/> values are the same. </summary>
        public static bool operator ==(RelayPrivateEndpointConnectionProvisioningState left, RelayPrivateEndpointConnectionProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RelayPrivateEndpointConnectionProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(RelayPrivateEndpointConnectionProvisioningState left, RelayPrivateEndpointConnectionProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RelayPrivateEndpointConnectionProvisioningState"/>. </summary>
        public static implicit operator RelayPrivateEndpointConnectionProvisioningState(string value) => new RelayPrivateEndpointConnectionProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RelayPrivateEndpointConnectionProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RelayPrivateEndpointConnectionProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
