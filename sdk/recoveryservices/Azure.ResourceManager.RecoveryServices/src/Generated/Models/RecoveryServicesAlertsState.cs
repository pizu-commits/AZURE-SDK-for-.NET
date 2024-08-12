// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> The RecoveryServicesAlertsState. </summary>
    public readonly partial struct RecoveryServicesAlertsState : IEquatable<RecoveryServicesAlertsState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RecoveryServicesAlertsState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RecoveryServicesAlertsState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static RecoveryServicesAlertsState Enabled { get; } = new RecoveryServicesAlertsState(EnabledValue);
        /// <summary> Disabled. </summary>
        public static RecoveryServicesAlertsState Disabled { get; } = new RecoveryServicesAlertsState(DisabledValue);
        /// <summary> Determines if two <see cref="RecoveryServicesAlertsState"/> values are the same. </summary>
        public static bool operator ==(RecoveryServicesAlertsState left, RecoveryServicesAlertsState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RecoveryServicesAlertsState"/> values are not the same. </summary>
        public static bool operator !=(RecoveryServicesAlertsState left, RecoveryServicesAlertsState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RecoveryServicesAlertsState"/>. </summary>
        public static implicit operator RecoveryServicesAlertsState(string value) => new RecoveryServicesAlertsState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RecoveryServicesAlertsState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RecoveryServicesAlertsState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
