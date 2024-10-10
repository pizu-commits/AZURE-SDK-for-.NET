// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> When enabled, the cluster is deployed into the configured subnet, when disabled it will be removed from the subnet. </summary>
    public readonly partial struct KustoClusterVnetState : IEquatable<KustoClusterVnetState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="KustoClusterVnetState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public KustoClusterVnetState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static KustoClusterVnetState Enabled { get; } = new KustoClusterVnetState(EnabledValue);
        /// <summary> Disabled. </summary>
        public static KustoClusterVnetState Disabled { get; } = new KustoClusterVnetState(DisabledValue);
        /// <summary> Determines if two <see cref="KustoClusterVnetState"/> values are the same. </summary>
        public static bool operator ==(KustoClusterVnetState left, KustoClusterVnetState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="KustoClusterVnetState"/> values are not the same. </summary>
        public static bool operator !=(KustoClusterVnetState left, KustoClusterVnetState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="KustoClusterVnetState"/>. </summary>
        public static implicit operator KustoClusterVnetState(string value) => new KustoClusterVnetState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is KustoClusterVnetState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(KustoClusterVnetState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
