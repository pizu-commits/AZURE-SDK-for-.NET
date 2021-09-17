// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Policy for accessing the disk via network. </summary>
    public readonly partial struct NetworkAccessPolicy : IEquatable<NetworkAccessPolicy>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NetworkAccessPolicy"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NetworkAccessPolicy(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AllowAllValue = "AllowAll";
        private const string AllowPrivateValue = "AllowPrivate";
        private const string DenyAllValue = "DenyAll";

        /// <summary> The disk can be exported or uploaded to from any network. </summary>
        public static NetworkAccessPolicy AllowAll { get; } = new NetworkAccessPolicy(AllowAllValue);
        /// <summary> The disk can be exported or uploaded to using a DiskAccess resource&apos;s private endpoints. </summary>
        public static NetworkAccessPolicy AllowPrivate { get; } = new NetworkAccessPolicy(AllowPrivateValue);
        /// <summary> The disk cannot be exported. </summary>
        public static NetworkAccessPolicy DenyAll { get; } = new NetworkAccessPolicy(DenyAllValue);
        /// <summary> Determines if two <see cref="NetworkAccessPolicy"/> values are the same. </summary>
        public static bool operator ==(NetworkAccessPolicy left, NetworkAccessPolicy right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NetworkAccessPolicy"/> values are not the same. </summary>
        public static bool operator !=(NetworkAccessPolicy left, NetworkAccessPolicy right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="NetworkAccessPolicy"/>. </summary>
        public static implicit operator NetworkAccessPolicy(string value) => new NetworkAccessPolicy(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NetworkAccessPolicy other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NetworkAccessPolicy other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
