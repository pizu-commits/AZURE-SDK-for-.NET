// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> The mode of acceptance for an agreement. </summary>
    public readonly partial struct AgreementAcceptanceMode : IEquatable<AgreementAcceptanceMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AgreementAcceptanceMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AgreementAcceptanceMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OtherValue = "Other";
        private const string ClickToAcceptValue = "ClickToAccept";
        private const string ESignEmbeddedValue = "ESignEmbedded";
        private const string ESignOfflineValue = "ESignOffline";
        private const string ImplicitValue = "Implicit";
        private const string OfflineValue = "Offline";
        private const string PhysicalSignValue = "PhysicalSign";

        /// <summary> Other. </summary>
        public static AgreementAcceptanceMode Other { get; } = new AgreementAcceptanceMode(OtherValue);
        /// <summary> ClickToAccept. </summary>
        public static AgreementAcceptanceMode ClickToAccept { get; } = new AgreementAcceptanceMode(ClickToAcceptValue);
        /// <summary> ESignEmbedded. </summary>
        public static AgreementAcceptanceMode ESignEmbedded { get; } = new AgreementAcceptanceMode(ESignEmbeddedValue);
        /// <summary> ESignOffline. </summary>
        public static AgreementAcceptanceMode ESignOffline { get; } = new AgreementAcceptanceMode(ESignOfflineValue);
        /// <summary> Implicit. </summary>
        public static AgreementAcceptanceMode Implicit { get; } = new AgreementAcceptanceMode(ImplicitValue);
        /// <summary> Offline. </summary>
        public static AgreementAcceptanceMode Offline { get; } = new AgreementAcceptanceMode(OfflineValue);
        /// <summary> PhysicalSign. </summary>
        public static AgreementAcceptanceMode PhysicalSign { get; } = new AgreementAcceptanceMode(PhysicalSignValue);
        /// <summary> Determines if two <see cref="AgreementAcceptanceMode"/> values are the same. </summary>
        public static bool operator ==(AgreementAcceptanceMode left, AgreementAcceptanceMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AgreementAcceptanceMode"/> values are not the same. </summary>
        public static bool operator !=(AgreementAcceptanceMode left, AgreementAcceptanceMode right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AgreementAcceptanceMode"/>. </summary>
        public static implicit operator AgreementAcceptanceMode(string value) => new AgreementAcceptanceMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AgreementAcceptanceMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AgreementAcceptanceMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
