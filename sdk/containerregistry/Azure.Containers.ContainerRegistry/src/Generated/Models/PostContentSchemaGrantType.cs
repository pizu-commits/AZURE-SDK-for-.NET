// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> Can take a value of access_token_refresh_token, or access_token, or refresh_token. </summary>
    public readonly partial struct PostContentSchemaGrantType : IEquatable<PostContentSchemaGrantType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="PostContentSchemaGrantType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PostContentSchemaGrantType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AccessTokenRefreshTokenValue = "access_token_refresh_token";
        private const string AccessTokenValue = "access_token";
        private const string RefreshTokenValue = "refresh_token";

        /// <summary> access_token_refresh_token. </summary>
        public static PostContentSchemaGrantType AccessTokenRefreshToken { get; } = new PostContentSchemaGrantType(AccessTokenRefreshTokenValue);
        /// <summary> access_token. </summary>
        public static PostContentSchemaGrantType AccessToken { get; } = new PostContentSchemaGrantType(AccessTokenValue);
        /// <summary> refresh_token. </summary>
        public static PostContentSchemaGrantType RefreshToken { get; } = new PostContentSchemaGrantType(RefreshTokenValue);
        /// <summary> Determines if two <see cref="PostContentSchemaGrantType"/> values are the same. </summary>
        public static bool operator ==(PostContentSchemaGrantType left, PostContentSchemaGrantType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PostContentSchemaGrantType"/> values are not the same. </summary>
        public static bool operator !=(PostContentSchemaGrantType left, PostContentSchemaGrantType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PostContentSchemaGrantType"/>. </summary>
        public static implicit operator PostContentSchemaGrantType(string value) => new PostContentSchemaGrantType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PostContentSchemaGrantType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PostContentSchemaGrantType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
