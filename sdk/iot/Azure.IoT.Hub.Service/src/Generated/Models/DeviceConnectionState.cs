// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.IoT.Hub.Service.Models
{
    /// <summary> The state of the device. </summary>
    public readonly partial struct DeviceConnectionState : IEquatable<DeviceConnectionState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DeviceConnectionState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DeviceConnectionState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DisconnectedValue = "Disconnected";
        private const string ConnectedValue = "Connected";

        /// <summary> Disconnected. </summary>
        public static DeviceConnectionState Disconnected { get; } = new DeviceConnectionState(DisconnectedValue);
        /// <summary> Connected. </summary>
        public static DeviceConnectionState Connected { get; } = new DeviceConnectionState(ConnectedValue);
        /// <summary> Determines if two <see cref="DeviceConnectionState"/> values are the same. </summary>
        public static bool operator ==(DeviceConnectionState left, DeviceConnectionState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DeviceConnectionState"/> values are not the same. </summary>
        public static bool operator !=(DeviceConnectionState left, DeviceConnectionState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DeviceConnectionState"/>. </summary>
        public static implicit operator DeviceConnectionState(string value) => new DeviceConnectionState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DeviceConnectionState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DeviceConnectionState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
