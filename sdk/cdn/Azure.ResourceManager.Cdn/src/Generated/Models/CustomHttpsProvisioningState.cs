// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Provisioning status of the custom domain. </summary>
    public readonly partial struct CustomHttpsProvisioningState : IEquatable<CustomHttpsProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CustomHttpsProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CustomHttpsProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnablingValue = "Enabling";
        private const string EnabledValue = "Enabled";
        private const string DisablingValue = "Disabling";
        private const string DisabledValue = "Disabled";
        private const string FailedValue = "Failed";

        /// <summary> Enabling. </summary>
        public static CustomHttpsProvisioningState Enabling { get; } = new CustomHttpsProvisioningState(EnablingValue);
        /// <summary> Enabled. </summary>
        public static CustomHttpsProvisioningState Enabled { get; } = new CustomHttpsProvisioningState(EnabledValue);
        /// <summary> Disabling. </summary>
        public static CustomHttpsProvisioningState Disabling { get; } = new CustomHttpsProvisioningState(DisablingValue);
        /// <summary> Disabled. </summary>
        public static CustomHttpsProvisioningState Disabled { get; } = new CustomHttpsProvisioningState(DisabledValue);
        /// <summary> Failed. </summary>
        public static CustomHttpsProvisioningState Failed { get; } = new CustomHttpsProvisioningState(FailedValue);
        /// <summary> Determines if two <see cref="CustomHttpsProvisioningState"/> values are the same. </summary>
        public static bool operator ==(CustomHttpsProvisioningState left, CustomHttpsProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CustomHttpsProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(CustomHttpsProvisioningState left, CustomHttpsProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CustomHttpsProvisioningState"/>. </summary>
        public static implicit operator CustomHttpsProvisioningState(string value) => new CustomHttpsProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CustomHttpsProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CustomHttpsProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
