// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.IoT.Hub.Service.Models
{
    /// <summary> The connection state of the device. </summary>
    public readonly partial struct TwinConnectionState : IEquatable<TwinConnectionState>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="TwinConnectionState"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TwinConnectionState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DisconnectedValue = "Disconnected";
        private const string ConnectedValue = "Connected";

        /// <summary> Disconnected. </summary>
        public static TwinConnectionState Disconnected { get; } = new TwinConnectionState(DisconnectedValue);
        /// <summary> Connected. </summary>
        public static TwinConnectionState Connected { get; } = new TwinConnectionState(ConnectedValue);
        /// <summary> Determines if two <see cref="TwinConnectionState"/> values are the same. </summary>
        public static bool operator ==(TwinConnectionState left, TwinConnectionState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TwinConnectionState"/> values are not the same. </summary>
        public static bool operator !=(TwinConnectionState left, TwinConnectionState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="TwinConnectionState"/>. </summary>
        public static implicit operator TwinConnectionState(string value) => new TwinConnectionState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TwinConnectionState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TwinConnectionState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
