// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The type of the diagnostic settings category. </summary>
    public readonly partial struct MonitorCategoryType : IEquatable<MonitorCategoryType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MonitorCategoryType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MonitorCategoryType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MetricsValue = "Metrics";
        private const string LogsValue = "Logs";

        /// <summary> Metrics. </summary>
        public static MonitorCategoryType Metrics { get; } = new MonitorCategoryType(MetricsValue);
        /// <summary> Logs. </summary>
        public static MonitorCategoryType Logs { get; } = new MonitorCategoryType(LogsValue);
        /// <summary> Determines if two <see cref="MonitorCategoryType"/> values are the same. </summary>
        public static bool operator ==(MonitorCategoryType left, MonitorCategoryType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MonitorCategoryType"/> values are not the same. </summary>
        public static bool operator !=(MonitorCategoryType left, MonitorCategoryType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MonitorCategoryType"/>. </summary>
        public static implicit operator MonitorCategoryType(string value) => new MonitorCategoryType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MonitorCategoryType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MonitorCategoryType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
