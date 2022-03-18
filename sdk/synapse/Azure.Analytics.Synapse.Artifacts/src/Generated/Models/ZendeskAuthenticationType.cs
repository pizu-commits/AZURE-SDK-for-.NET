// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The authentication type to use. </summary>
    public readonly partial struct ZendeskAuthenticationType : IEquatable<ZendeskAuthenticationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ZendeskAuthenticationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ZendeskAuthenticationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BasicValue = "Basic";
        private const string TokenValue = "Token";

        /// <summary> Basic. </summary>
        public static ZendeskAuthenticationType Basic { get; } = new ZendeskAuthenticationType(BasicValue);
        /// <summary> Token. </summary>
        public static ZendeskAuthenticationType Token { get; } = new ZendeskAuthenticationType(TokenValue);
        /// <summary> Determines if two <see cref="ZendeskAuthenticationType"/> values are the same. </summary>
        public static bool operator ==(ZendeskAuthenticationType left, ZendeskAuthenticationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ZendeskAuthenticationType"/> values are not the same. </summary>
        public static bool operator !=(ZendeskAuthenticationType left, ZendeskAuthenticationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ZendeskAuthenticationType"/>. </summary>
        public static implicit operator ZendeskAuthenticationType(string value) => new ZendeskAuthenticationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ZendeskAuthenticationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ZendeskAuthenticationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
