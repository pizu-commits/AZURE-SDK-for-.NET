// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The encryption type of the SSH keys to be generated. See SshEncryptionTypes for possible set of values. If not provided, will default to RSA. </summary>
    public readonly partial struct SshEncryptionType : IEquatable<SshEncryptionType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SshEncryptionType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SshEncryptionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RSAValue = "RSA";
        private const string Ed25519Value = "Ed25519";

        /// <summary> RSA. </summary>
        public static SshEncryptionType RSA { get; } = new SshEncryptionType(RSAValue);
        /// <summary> Ed25519. </summary>
        public static SshEncryptionType Ed25519 { get; } = new SshEncryptionType(Ed25519Value);
        /// <summary> Determines if two <see cref="SshEncryptionType"/> values are the same. </summary>
        public static bool operator ==(SshEncryptionType left, SshEncryptionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SshEncryptionType"/> values are not the same. </summary>
        public static bool operator !=(SshEncryptionType left, SshEncryptionType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SshEncryptionType"/>. </summary>
        public static implicit operator SshEncryptionType(string value) => new SshEncryptionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SshEncryptionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SshEncryptionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
