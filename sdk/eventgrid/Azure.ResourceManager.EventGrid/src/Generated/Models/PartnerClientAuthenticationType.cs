// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Type of client authentication. </summary>
    internal readonly partial struct PartnerClientAuthenticationType : IEquatable<PartnerClientAuthenticationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PartnerClientAuthenticationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PartnerClientAuthenticationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AzureADValue = "AzureAD";

        /// <summary> AzureAD. </summary>
        public static PartnerClientAuthenticationType AzureAD { get; } = new PartnerClientAuthenticationType(AzureADValue);
        /// <summary> Determines if two <see cref="PartnerClientAuthenticationType"/> values are the same. </summary>
        public static bool operator ==(PartnerClientAuthenticationType left, PartnerClientAuthenticationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PartnerClientAuthenticationType"/> values are not the same. </summary>
        public static bool operator !=(PartnerClientAuthenticationType left, PartnerClientAuthenticationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PartnerClientAuthenticationType"/>. </summary>
        public static implicit operator PartnerClientAuthenticationType(string value) => new PartnerClientAuthenticationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PartnerClientAuthenticationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PartnerClientAuthenticationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
