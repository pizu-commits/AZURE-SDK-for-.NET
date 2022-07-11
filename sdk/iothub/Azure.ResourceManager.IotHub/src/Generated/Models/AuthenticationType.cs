// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> Specifies authentication type being used for connecting to the storage account. </summary>
    public readonly partial struct AuthenticationType : IEquatable<AuthenticationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AuthenticationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AuthenticationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string KeyBasedValue = "keyBased";
        private const string IdentityBasedValue = "identityBased";

        /// <summary> keyBased. </summary>
        public static AuthenticationType KeyBased { get; } = new AuthenticationType(KeyBasedValue);
        /// <summary> identityBased. </summary>
        public static AuthenticationType IdentityBased { get; } = new AuthenticationType(IdentityBasedValue);
        /// <summary> Determines if two <see cref="AuthenticationType"/> values are the same. </summary>
        public static bool operator ==(AuthenticationType left, AuthenticationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AuthenticationType"/> values are not the same. </summary>
        public static bool operator !=(AuthenticationType left, AuthenticationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AuthenticationType"/>. </summary>
        public static implicit operator AuthenticationType(string value) => new AuthenticationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AuthenticationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AuthenticationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
