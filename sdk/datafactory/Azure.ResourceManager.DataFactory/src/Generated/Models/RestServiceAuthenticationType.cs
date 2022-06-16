// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Type of authentication used to connect to the REST service. </summary>
    public readonly partial struct RestServiceAuthenticationType : IEquatable<RestServiceAuthenticationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RestServiceAuthenticationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RestServiceAuthenticationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AnonymousValue = "Anonymous";
        private const string BasicValue = "Basic";
        private const string AadServicePrincipalValue = "AadServicePrincipal";
        private const string ManagedServiceIdentityValue = "ManagedServiceIdentity";
        private const string OAuth2Value = "OAuth2ClientCredential";

        /// <summary> Anonymous. </summary>
        public static RestServiceAuthenticationType Anonymous { get; } = new RestServiceAuthenticationType(AnonymousValue);
        /// <summary> Basic. </summary>
        public static RestServiceAuthenticationType Basic { get; } = new RestServiceAuthenticationType(BasicValue);
        /// <summary> AadServicePrincipal. </summary>
        public static RestServiceAuthenticationType AadServicePrincipal { get; } = new RestServiceAuthenticationType(AadServicePrincipalValue);
        /// <summary> ManagedServiceIdentity. </summary>
        public static RestServiceAuthenticationType ManagedServiceIdentity { get; } = new RestServiceAuthenticationType(ManagedServiceIdentityValue);
        /// <summary> OAuth2ClientCredential. </summary>
        public static RestServiceAuthenticationType OAuth2 { get; } = new RestServiceAuthenticationType(OAuth2Value);
        /// <summary> Determines if two <see cref="RestServiceAuthenticationType"/> values are the same. </summary>
        public static bool operator ==(RestServiceAuthenticationType left, RestServiceAuthenticationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RestServiceAuthenticationType"/> values are not the same. </summary>
        public static bool operator !=(RestServiceAuthenticationType left, RestServiceAuthenticationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RestServiceAuthenticationType"/>. </summary>
        public static implicit operator RestServiceAuthenticationType(string value) => new RestServiceAuthenticationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RestServiceAuthenticationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RestServiceAuthenticationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
