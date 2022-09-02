// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Basic network, or Standard features available to the volume. </summary>
    public readonly partial struct NetworkFeatures : IEquatable<NetworkFeatures>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NetworkFeatures"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NetworkFeatures(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BasicValue = "Basic";
        private const string StandardValue = "Standard";

        /// <summary> Basic network feature. </summary>
        public static NetworkFeatures Basic { get; } = new NetworkFeatures(BasicValue);
        /// <summary> Standard network feature. </summary>
        public static NetworkFeatures Standard { get; } = new NetworkFeatures(StandardValue);
        /// <summary> Determines if two <see cref="NetworkFeatures"/> values are the same. </summary>
        public static bool operator ==(NetworkFeatures left, NetworkFeatures right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NetworkFeatures"/> values are not the same. </summary>
        public static bool operator !=(NetworkFeatures left, NetworkFeatures right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="NetworkFeatures"/>. </summary>
        public static implicit operator NetworkFeatures(string value) => new NetworkFeatures(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NetworkFeatures other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NetworkFeatures other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
