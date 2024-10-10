// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Network Rack SKU name. </summary>
    public readonly partial struct NetworkRackType : IEquatable<NetworkRackType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NetworkRackType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NetworkRackType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AggregateValue = "Aggregate";
        private const string ComputeValue = "Compute";
        private const string CombinedValue = "Combined";

        /// <summary> Aggregate. </summary>
        public static NetworkRackType Aggregate { get; } = new NetworkRackType(AggregateValue);
        /// <summary> Compute. </summary>
        public static NetworkRackType Compute { get; } = new NetworkRackType(ComputeValue);
        /// <summary> Combined. </summary>
        public static NetworkRackType Combined { get; } = new NetworkRackType(CombinedValue);
        /// <summary> Determines if two <see cref="NetworkRackType"/> values are the same. </summary>
        public static bool operator ==(NetworkRackType left, NetworkRackType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NetworkRackType"/> values are not the same. </summary>
        public static bool operator !=(NetworkRackType left, NetworkRackType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="NetworkRackType"/>. </summary>
        public static implicit operator NetworkRackType(string value) => new NetworkRackType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NetworkRackType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NetworkRackType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
