// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Layer4 protocol type that needs to be matched. </summary>
    public readonly partial struct Layer4Protocol : IEquatable<Layer4Protocol>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="Layer4Protocol"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Layer4Protocol(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TcpValue = "TCP";
        private const string UdpValue = "UDP";

        /// <summary> TCP. </summary>
        public static Layer4Protocol Tcp { get; } = new Layer4Protocol(TcpValue);
        /// <summary> UDP. </summary>
        public static Layer4Protocol Udp { get; } = new Layer4Protocol(UdpValue);
        /// <summary> Determines if two <see cref="Layer4Protocol"/> values are the same. </summary>
        public static bool operator ==(Layer4Protocol left, Layer4Protocol right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Layer4Protocol"/> values are not the same. </summary>
        public static bool operator !=(Layer4Protocol left, Layer4Protocol right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Layer4Protocol"/>. </summary>
        public static implicit operator Layer4Protocol(string value) => new Layer4Protocol(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Layer4Protocol other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Layer4Protocol other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
