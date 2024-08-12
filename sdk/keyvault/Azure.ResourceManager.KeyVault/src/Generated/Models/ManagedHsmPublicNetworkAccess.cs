// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> Control permission to the managed HSM from public networks. </summary>
    public readonly partial struct ManagedHsmPublicNetworkAccess : IEquatable<ManagedHsmPublicNetworkAccess>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ManagedHsmPublicNetworkAccess"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ManagedHsmPublicNetworkAccess(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static ManagedHsmPublicNetworkAccess Enabled { get; } = new ManagedHsmPublicNetworkAccess(EnabledValue);
        /// <summary> Disabled. </summary>
        public static ManagedHsmPublicNetworkAccess Disabled { get; } = new ManagedHsmPublicNetworkAccess(DisabledValue);
        /// <summary> Determines if two <see cref="ManagedHsmPublicNetworkAccess"/> values are the same. </summary>
        public static bool operator ==(ManagedHsmPublicNetworkAccess left, ManagedHsmPublicNetworkAccess right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ManagedHsmPublicNetworkAccess"/> values are not the same. </summary>
        public static bool operator !=(ManagedHsmPublicNetworkAccess left, ManagedHsmPublicNetworkAccess right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ManagedHsmPublicNetworkAccess"/>. </summary>
        public static implicit operator ManagedHsmPublicNetworkAccess(string value) => new ManagedHsmPublicNetworkAccess(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ManagedHsmPublicNetworkAccess other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ManagedHsmPublicNetworkAccess other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
