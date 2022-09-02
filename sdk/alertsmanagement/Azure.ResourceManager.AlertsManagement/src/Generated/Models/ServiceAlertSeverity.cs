// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    /// <summary>
    /// The ServiceAlertSeverity.
    /// Serialized Name: Severity
    /// </summary>
    public readonly partial struct ServiceAlertSeverity : IEquatable<ServiceAlertSeverity>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ServiceAlertSeverity"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ServiceAlertSeverity(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string Sev0Value = "Sev0";
        private const string Sev1Value = "Sev1";
        private const string Sev2Value = "Sev2";
        private const string Sev3Value = "Sev3";
        private const string Sev4Value = "Sev4";

        /// <summary>
        /// Sev0
        /// Serialized Name: Severity.Sev0
        /// </summary>
        public static ServiceAlertSeverity Sev0 { get; } = new ServiceAlertSeverity(Sev0Value);
        /// <summary>
        /// Sev1
        /// Serialized Name: Severity.Sev1
        /// </summary>
        public static ServiceAlertSeverity Sev1 { get; } = new ServiceAlertSeverity(Sev1Value);
        /// <summary>
        /// Sev2
        /// Serialized Name: Severity.Sev2
        /// </summary>
        public static ServiceAlertSeverity Sev2 { get; } = new ServiceAlertSeverity(Sev2Value);
        /// <summary>
        /// Sev3
        /// Serialized Name: Severity.Sev3
        /// </summary>
        public static ServiceAlertSeverity Sev3 { get; } = new ServiceAlertSeverity(Sev3Value);
        /// <summary>
        /// Sev4
        /// Serialized Name: Severity.Sev4
        /// </summary>
        public static ServiceAlertSeverity Sev4 { get; } = new ServiceAlertSeverity(Sev4Value);
        /// <summary> Determines if two <see cref="ServiceAlertSeverity"/> values are the same. </summary>
        public static bool operator ==(ServiceAlertSeverity left, ServiceAlertSeverity right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ServiceAlertSeverity"/> values are not the same. </summary>
        public static bool operator !=(ServiceAlertSeverity left, ServiceAlertSeverity right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ServiceAlertSeverity"/>. </summary>
        public static implicit operator ServiceAlertSeverity(string value) => new ServiceAlertSeverity(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ServiceAlertSeverity other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ServiceAlertSeverity other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
