// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Maintenance.Models
{
    /// <summary> Possible reboot preference as defined by the user based on which it would be decided to reboot the machine or not after the patch operation is completed. </summary>
    public readonly partial struct MaintenanceRebootOption : IEquatable<MaintenanceRebootOption>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MaintenanceRebootOption"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MaintenanceRebootOption(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IfRequiredValue = "IfRequired";
        private const string NeverValue = "Never";
        private const string AlwaysValue = "Always";

        /// <summary> IfRequired. </summary>
        public static MaintenanceRebootOption IfRequired { get; } = new MaintenanceRebootOption(IfRequiredValue);
        /// <summary> Never. </summary>
        public static MaintenanceRebootOption Never { get; } = new MaintenanceRebootOption(NeverValue);
        /// <summary> Always. </summary>
        public static MaintenanceRebootOption Always { get; } = new MaintenanceRebootOption(AlwaysValue);
        /// <summary> Determines if two <see cref="MaintenanceRebootOption"/> values are the same. </summary>
        public static bool operator ==(MaintenanceRebootOption left, MaintenanceRebootOption right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MaintenanceRebootOption"/> values are not the same. </summary>
        public static bool operator !=(MaintenanceRebootOption left, MaintenanceRebootOption right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MaintenanceRebootOption"/>. </summary>
        public static implicit operator MaintenanceRebootOption(string value) => new MaintenanceRebootOption(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MaintenanceRebootOption other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MaintenanceRebootOption other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
