// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary>
    /// The signing or hashing algorithm.
    /// Serialized Name: HashingAlgorithm
    /// </summary>
    public readonly partial struct HashingAlgorithm : IEquatable<HashingAlgorithm>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HashingAlgorithm"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HashingAlgorithm(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotSpecifiedValue = "NotSpecified";
        private const string NoneValue = "None";
        private const string MD5Value = "MD5";
        private const string SHA1Value = "SHA1";
        private const string SHA2256Value = "SHA2256";
        private const string SHA2384Value = "SHA2384";
        private const string SHA2512Value = "SHA2512";

        /// <summary>
        /// NotSpecified
        /// Serialized Name: HashingAlgorithm.NotSpecified
        /// </summary>
        public static HashingAlgorithm NotSpecified { get; } = new HashingAlgorithm(NotSpecifiedValue);
        /// <summary>
        /// None
        /// Serialized Name: HashingAlgorithm.None
        /// </summary>
        public static HashingAlgorithm None { get; } = new HashingAlgorithm(NoneValue);
        /// <summary>
        /// MD5
        /// Serialized Name: HashingAlgorithm.MD5
        /// </summary>
        public static HashingAlgorithm MD5 { get; } = new HashingAlgorithm(MD5Value);
        /// <summary>
        /// SHA1
        /// Serialized Name: HashingAlgorithm.SHA1
        /// </summary>
        public static HashingAlgorithm SHA1 { get; } = new HashingAlgorithm(SHA1Value);
        /// <summary>
        /// SHA2256
        /// Serialized Name: HashingAlgorithm.SHA2256
        /// </summary>
        public static HashingAlgorithm SHA2256 { get; } = new HashingAlgorithm(SHA2256Value);
        /// <summary>
        /// SHA2384
        /// Serialized Name: HashingAlgorithm.SHA2384
        /// </summary>
        public static HashingAlgorithm SHA2384 { get; } = new HashingAlgorithm(SHA2384Value);
        /// <summary>
        /// SHA2512
        /// Serialized Name: HashingAlgorithm.SHA2512
        /// </summary>
        public static HashingAlgorithm SHA2512 { get; } = new HashingAlgorithm(SHA2512Value);
        /// <summary> Determines if two <see cref="HashingAlgorithm"/> values are the same. </summary>
        public static bool operator ==(HashingAlgorithm left, HashingAlgorithm right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HashingAlgorithm"/> values are not the same. </summary>
        public static bool operator !=(HashingAlgorithm left, HashingAlgorithm right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="HashingAlgorithm"/>. </summary>
        public static implicit operator HashingAlgorithm(string value) => new HashingAlgorithm(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HashingAlgorithm other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HashingAlgorithm other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
