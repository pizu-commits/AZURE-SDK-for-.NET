// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ElasticSan.Models
{
    /// <summary> Allow or disallow public network access to ElasticSan. Value is optional but if passed in, must be 'Enabled' or 'Disabled'. </summary>
    public readonly partial struct ElasticSanPublicNetworkAccess : IEquatable<ElasticSanPublicNetworkAccess>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ElasticSanPublicNetworkAccess"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ElasticSanPublicNetworkAccess(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static ElasticSanPublicNetworkAccess Enabled { get; } = new ElasticSanPublicNetworkAccess(EnabledValue);
        /// <summary> Disabled. </summary>
        public static ElasticSanPublicNetworkAccess Disabled { get; } = new ElasticSanPublicNetworkAccess(DisabledValue);
        /// <summary> Determines if two <see cref="ElasticSanPublicNetworkAccess"/> values are the same. </summary>
        public static bool operator ==(ElasticSanPublicNetworkAccess left, ElasticSanPublicNetworkAccess right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ElasticSanPublicNetworkAccess"/> values are not the same. </summary>
        public static bool operator !=(ElasticSanPublicNetworkAccess left, ElasticSanPublicNetworkAccess right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ElasticSanPublicNetworkAccess"/>. </summary>
        public static implicit operator ElasticSanPublicNetworkAccess(string value) => new ElasticSanPublicNetworkAccess(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ElasticSanPublicNetworkAccess other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ElasticSanPublicNetworkAccess other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
