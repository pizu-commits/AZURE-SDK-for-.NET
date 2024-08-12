// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Datadog.Models
{
    /// <summary> Flag specifying if the resource monitoring is enabled or disabled. </summary>
    public readonly partial struct MonitoringStatus : IEquatable<MonitoringStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MonitoringStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MonitoringStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static MonitoringStatus Enabled { get; } = new MonitoringStatus(EnabledValue);
        /// <summary> Disabled. </summary>
        public static MonitoringStatus Disabled { get; } = new MonitoringStatus(DisabledValue);
        /// <summary> Determines if two <see cref="MonitoringStatus"/> values are the same. </summary>
        public static bool operator ==(MonitoringStatus left, MonitoringStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MonitoringStatus"/> values are not the same. </summary>
        public static bool operator !=(MonitoringStatus left, MonitoringStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MonitoringStatus"/>. </summary>
        public static implicit operator MonitoringStatus(string value) => new MonitoringStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MonitoringStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MonitoringStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
