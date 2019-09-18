﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ComponentModel;

namespace Azure.Security.KeyVault.Keys.Cryptography
{
    /// <summary>
    /// An algorithm used for encryption and decryption
    /// </summary>
    public readonly struct EncryptionAlgorithm : IEquatable<EncryptionAlgorithm>
    {
        internal const string RSAOAEPValue = "RSA-OAEP";
        internal const string RSA15Value = "RSA-15";
        internal const string RSAOAEP256Value = "RSA-OAEP-256";

        private readonly string _value;

        /// <summary>
        /// Initializes a new instance of the <see cref="EncryptionAlgorithm"/> structure.
        /// </summary>
        /// <param name="value"></param>
        public EncryptionAlgorithm(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// RSA-OAEP
        /// </summary>
        public static readonly EncryptionAlgorithm RSAOAEP = new EncryptionAlgorithm(RSAOAEPValue);

        /// <summary>
        /// RSA-15
        /// </summary>
        public static readonly EncryptionAlgorithm RSA15 = new EncryptionAlgorithm(RSA15Value);

        /// <summary>
        /// RSA-OAEP256
        /// </summary>
        public static readonly EncryptionAlgorithm RSAOAEP256 = new EncryptionAlgorithm(RSAOAEP256Value);

        /// <summary>
        /// Determines if two <see cref="EncryptionAlgorithm"/> values are the same.
        /// </summary>
        /// <param name="a">The first <see cref="EncryptionAlgorithm"/> to compare.</param>
        /// <param name="b">The second <see cref="EncryptionAlgorithm"/> to compare.</param>
        /// <returns>True if <paramref name="a"/> and <paramref name="b"/> are the same; otherwise, false.</returns>
        public static bool operator ==(EncryptionAlgorithm a, EncryptionAlgorithm b) => a.Equals(b);

        /// <summary>
        /// Determines if two <see cref="EncryptionAlgorithm"/> values are different.
        /// </summary>
        /// <param name="a">The first <see cref="EncryptionAlgorithm"/> to compare.</param>
        /// <param name="b">The second <see cref="EncryptionAlgorithm"/> to compare.</param>
        /// <returns>True if <paramref name="a"/> and <paramref name="b"/> are different; otherwise, false.</returns>
        public static bool operator !=(EncryptionAlgorithm a, EncryptionAlgorithm b) => !a.Equals(b);

        /// <summary>
        /// Converts a string to a <see cref="EncryptionAlgorithm"/>.
        /// </summary>
        /// <param name="value">The string value to convert.</param>
        public static implicit operator EncryptionAlgorithm(string value) => new EncryptionAlgorithm(value);

        /// <inheritdoc/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EncryptionAlgorithm other && Equals(other);

        /// <inheritdoc/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool Equals(EncryptionAlgorithm other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        /// <inheritdoc/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        /// <inheritdoc/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToString() => _value;
    }
}
