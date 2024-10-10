// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> Gets or sets admin action. </summary>
    public readonly partial struct MarketplaceAdminAction : IEquatable<MarketplaceAdminAction>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MarketplaceAdminAction"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MarketplaceAdminAction(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ApprovedValue = "Approved";
        private const string RejectedValue = "Rejected";

        /// <summary> Approved. </summary>
        public static MarketplaceAdminAction Approved { get; } = new MarketplaceAdminAction(ApprovedValue);
        /// <summary> Rejected. </summary>
        public static MarketplaceAdminAction Rejected { get; } = new MarketplaceAdminAction(RejectedValue);
        /// <summary> Determines if two <see cref="MarketplaceAdminAction"/> values are the same. </summary>
        public static bool operator ==(MarketplaceAdminAction left, MarketplaceAdminAction right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MarketplaceAdminAction"/> values are not the same. </summary>
        public static bool operator !=(MarketplaceAdminAction left, MarketplaceAdminAction right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="MarketplaceAdminAction"/>. </summary>
        public static implicit operator MarketplaceAdminAction(string value) => new MarketplaceAdminAction(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MarketplaceAdminAction other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MarketplaceAdminAction other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
