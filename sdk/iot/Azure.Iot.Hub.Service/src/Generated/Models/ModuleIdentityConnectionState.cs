// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Iot.Hub.Service.Models
{
    /// <summary> Tells whether the module is connected or not. </summary>
    public readonly partial struct ModuleIdentityConnectionState : IEquatable<ModuleIdentityConnectionState>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ModuleIdentityConnectionState"/> values are the same. </summary>
        public ModuleIdentityConnectionState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DisconnectedValue = "Disconnected";
        private const string ConnectedValue = "Connected";

        /// <summary> Disconnected. </summary>
        public static ModuleIdentityConnectionState Disconnected { get; } = new ModuleIdentityConnectionState(DisconnectedValue);
        /// <summary> Connected. </summary>
        public static ModuleIdentityConnectionState Connected { get; } = new ModuleIdentityConnectionState(ConnectedValue);
        /// <summary> Determines if two <see cref="ModuleIdentityConnectionState"/> values are the same. </summary>
        public static bool operator ==(ModuleIdentityConnectionState left, ModuleIdentityConnectionState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ModuleIdentityConnectionState"/> values are not the same. </summary>
        public static bool operator !=(ModuleIdentityConnectionState left, ModuleIdentityConnectionState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ModuleIdentityConnectionState"/>. </summary>
        public static implicit operator ModuleIdentityConnectionState(string value) => new ModuleIdentityConnectionState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ModuleIdentityConnectionState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ModuleIdentityConnectionState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
