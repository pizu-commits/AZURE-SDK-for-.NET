// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> Enabled allows this resource to be accessed from both public and private networks, Disabled allows this resource to only be accessed via private endpoints. </summary>
    public readonly partial struct HostPoolPublicNetworkAccess : IEquatable<HostPoolPublicNetworkAccess>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HostPoolPublicNetworkAccess"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HostPoolPublicNetworkAccess(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";
        private const string EnabledForSessionHostsOnlyValue = "EnabledForSessionHostsOnly";
        private const string EnabledForClientsOnlyValue = "EnabledForClientsOnly";

        /// <summary> Enabled. </summary>
        public static HostPoolPublicNetworkAccess Enabled { get; } = new HostPoolPublicNetworkAccess(EnabledValue);
        /// <summary> Disabled. </summary>
        public static HostPoolPublicNetworkAccess Disabled { get; } = new HostPoolPublicNetworkAccess(DisabledValue);
        /// <summary> EnabledForSessionHostsOnly. </summary>
        public static HostPoolPublicNetworkAccess EnabledForSessionHostsOnly { get; } = new HostPoolPublicNetworkAccess(EnabledForSessionHostsOnlyValue);
        /// <summary> EnabledForClientsOnly. </summary>
        public static HostPoolPublicNetworkAccess EnabledForClientsOnly { get; } = new HostPoolPublicNetworkAccess(EnabledForClientsOnlyValue);
        /// <summary> Determines if two <see cref="HostPoolPublicNetworkAccess"/> values are the same. </summary>
        public static bool operator ==(HostPoolPublicNetworkAccess left, HostPoolPublicNetworkAccess right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HostPoolPublicNetworkAccess"/> values are not the same. </summary>
        public static bool operator !=(HostPoolPublicNetworkAccess left, HostPoolPublicNetworkAccess right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="HostPoolPublicNetworkAccess"/>. </summary>
        public static implicit operator HostPoolPublicNetworkAccess(string value) => new HostPoolPublicNetworkAccess(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HostPoolPublicNetworkAccess other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HostPoolPublicNetworkAccess other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
