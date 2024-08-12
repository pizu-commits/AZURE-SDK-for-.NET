// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> The network function type. </summary>
    internal readonly partial struct NetworkFunctionType : IEquatable<NetworkFunctionType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NetworkFunctionType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NetworkFunctionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string VirtualNetworkFunctionValue = "VirtualNetworkFunction";
        private const string ContainerizedNetworkFunctionValue = "ContainerizedNetworkFunction";

        /// <summary> Unknown. </summary>
        public static NetworkFunctionType Unknown { get; } = new NetworkFunctionType(UnknownValue);
        /// <summary> VirtualNetworkFunction. </summary>
        public static NetworkFunctionType VirtualNetworkFunction { get; } = new NetworkFunctionType(VirtualNetworkFunctionValue);
        /// <summary> ContainerizedNetworkFunction. </summary>
        public static NetworkFunctionType ContainerizedNetworkFunction { get; } = new NetworkFunctionType(ContainerizedNetworkFunctionValue);
        /// <summary> Determines if two <see cref="NetworkFunctionType"/> values are the same. </summary>
        public static bool operator ==(NetworkFunctionType left, NetworkFunctionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NetworkFunctionType"/> values are not the same. </summary>
        public static bool operator !=(NetworkFunctionType left, NetworkFunctionType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="NetworkFunctionType"/>. </summary>
        public static implicit operator NetworkFunctionType(string value) => new NetworkFunctionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NetworkFunctionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NetworkFunctionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
