// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The IKE encryption algorithm (IKE phase 2). </summary>
    public readonly partial struct IkeEncryption : IEquatable<IkeEncryption>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IkeEncryption"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IkeEncryption(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DESValue = "DES";
        private const string DES3Value = "DES3";
        private const string AES128Value = "AES128";
        private const string AES192Value = "AES192";
        private const string AES256Value = "AES256";
        private const string Gcmaes256Value = "GCMAES256";
        private const string Gcmaes128Value = "GCMAES128";

        /// <summary> DES. </summary>
        public static IkeEncryption DES { get; } = new IkeEncryption(DESValue);
        /// <summary> DES3. </summary>
        public static IkeEncryption DES3 { get; } = new IkeEncryption(DES3Value);
        /// <summary> AES128. </summary>
        public static IkeEncryption AES128 { get; } = new IkeEncryption(AES128Value);
        /// <summary> AES192. </summary>
        public static IkeEncryption AES192 { get; } = new IkeEncryption(AES192Value);
        /// <summary> AES256. </summary>
        public static IkeEncryption AES256 { get; } = new IkeEncryption(AES256Value);
        /// <summary> GCMAES256. </summary>
        public static IkeEncryption Gcmaes256 { get; } = new IkeEncryption(Gcmaes256Value);
        /// <summary> GCMAES128. </summary>
        public static IkeEncryption Gcmaes128 { get; } = new IkeEncryption(Gcmaes128Value);
        /// <summary> Determines if two <see cref="IkeEncryption"/> values are the same. </summary>
        public static bool operator ==(IkeEncryption left, IkeEncryption right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IkeEncryption"/> values are not the same. </summary>
        public static bool operator !=(IkeEncryption left, IkeEncryption right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="IkeEncryption"/>. </summary>
        public static implicit operator IkeEncryption(string value) => new IkeEncryption(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IkeEncryption other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IkeEncryption other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
