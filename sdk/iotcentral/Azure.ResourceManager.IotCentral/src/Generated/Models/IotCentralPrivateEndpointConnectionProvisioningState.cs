// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.IotCentral.Models
{
    /// <summary> The current provisioning state. </summary>
    public readonly partial struct IotCentralPrivateEndpointConnectionProvisioningState : IEquatable<IotCentralPrivateEndpointConnectionProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IotCentralPrivateEndpointConnectionProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IotCentralPrivateEndpointConnectionProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string CreatingValue = "Creating";
        private const string DeletingValue = "Deleting";
        private const string FailedValue = "Failed";

        /// <summary> Succeeded. </summary>
        public static IotCentralPrivateEndpointConnectionProvisioningState Succeeded { get; } = new IotCentralPrivateEndpointConnectionProvisioningState(SucceededValue);
        /// <summary> Creating. </summary>
        public static IotCentralPrivateEndpointConnectionProvisioningState Creating { get; } = new IotCentralPrivateEndpointConnectionProvisioningState(CreatingValue);
        /// <summary> Deleting. </summary>
        public static IotCentralPrivateEndpointConnectionProvisioningState Deleting { get; } = new IotCentralPrivateEndpointConnectionProvisioningState(DeletingValue);
        /// <summary> Failed. </summary>
        public static IotCentralPrivateEndpointConnectionProvisioningState Failed { get; } = new IotCentralPrivateEndpointConnectionProvisioningState(FailedValue);
        /// <summary> Determines if two <see cref="IotCentralPrivateEndpointConnectionProvisioningState"/> values are the same. </summary>
        public static bool operator ==(IotCentralPrivateEndpointConnectionProvisioningState left, IotCentralPrivateEndpointConnectionProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IotCentralPrivateEndpointConnectionProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(IotCentralPrivateEndpointConnectionProvisioningState left, IotCentralPrivateEndpointConnectionProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="IotCentralPrivateEndpointConnectionProvisioningState"/>. </summary>
        public static implicit operator IotCentralPrivateEndpointConnectionProvisioningState(string value) => new IotCentralPrivateEndpointConnectionProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IotCentralPrivateEndpointConnectionProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IotCentralPrivateEndpointConnectionProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
