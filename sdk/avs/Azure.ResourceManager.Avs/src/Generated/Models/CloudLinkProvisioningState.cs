// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> cloud link provisioning state. </summary>
    public readonly partial struct CloudLinkProvisioningState : IEquatable<CloudLinkProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CloudLinkProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CloudLinkProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";

        /// <summary> Resource has been created. </summary>
        public static CloudLinkProvisioningState Succeeded { get; } = new CloudLinkProvisioningState(SucceededValue);
        /// <summary> Resource creation failed. </summary>
        public static CloudLinkProvisioningState Failed { get; } = new CloudLinkProvisioningState(FailedValue);
        /// <summary> Resource creation was canceled. </summary>
        public static CloudLinkProvisioningState Canceled { get; } = new CloudLinkProvisioningState(CanceledValue);
        /// <summary> Determines if two <see cref="CloudLinkProvisioningState"/> values are the same. </summary>
        public static bool operator ==(CloudLinkProvisioningState left, CloudLinkProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CloudLinkProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(CloudLinkProvisioningState left, CloudLinkProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="CloudLinkProvisioningState"/>. </summary>
        public static implicit operator CloudLinkProvisioningState(string value) => new CloudLinkProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CloudLinkProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CloudLinkProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
