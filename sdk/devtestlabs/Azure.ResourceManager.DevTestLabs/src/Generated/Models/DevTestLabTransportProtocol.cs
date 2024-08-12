// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> The transport protocol for the endpoint. </summary>
    public readonly partial struct DevTestLabTransportProtocol : IEquatable<DevTestLabTransportProtocol>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DevTestLabTransportProtocol"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DevTestLabTransportProtocol(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TcpValue = "Tcp";
        private const string UdpValue = "Udp";

        /// <summary> Tcp. </summary>
        public static DevTestLabTransportProtocol Tcp { get; } = new DevTestLabTransportProtocol(TcpValue);
        /// <summary> Udp. </summary>
        public static DevTestLabTransportProtocol Udp { get; } = new DevTestLabTransportProtocol(UdpValue);
        /// <summary> Determines if two <see cref="DevTestLabTransportProtocol"/> values are the same. </summary>
        public static bool operator ==(DevTestLabTransportProtocol left, DevTestLabTransportProtocol right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DevTestLabTransportProtocol"/> values are not the same. </summary>
        public static bool operator !=(DevTestLabTransportProtocol left, DevTestLabTransportProtocol right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DevTestLabTransportProtocol"/>. </summary>
        public static implicit operator DevTestLabTransportProtocol(string value) => new DevTestLabTransportProtocol(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DevTestLabTransportProtocol other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DevTestLabTransportProtocol other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
