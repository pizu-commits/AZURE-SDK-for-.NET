// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    /// <summary>
    /// Days of week.
    /// Serialized Name: DaysOfWeek
    /// </summary>
    public readonly partial struct AlertsManagementDayOfWeek : IEquatable<AlertsManagementDayOfWeek>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AlertsManagementDayOfWeek"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AlertsManagementDayOfWeek(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SundayValue = "Sunday";
        private const string MondayValue = "Monday";
        private const string TuesdayValue = "Tuesday";
        private const string WednesdayValue = "Wednesday";
        private const string ThursdayValue = "Thursday";
        private const string FridayValue = "Friday";
        private const string SaturdayValue = "Saturday";

        /// <summary>
        /// Sunday
        /// Serialized Name: DaysOfWeek.Sunday
        /// </summary>
        public static AlertsManagementDayOfWeek Sunday { get; } = new AlertsManagementDayOfWeek(SundayValue);
        /// <summary>
        /// Monday
        /// Serialized Name: DaysOfWeek.Monday
        /// </summary>
        public static AlertsManagementDayOfWeek Monday { get; } = new AlertsManagementDayOfWeek(MondayValue);
        /// <summary>
        /// Tuesday
        /// Serialized Name: DaysOfWeek.Tuesday
        /// </summary>
        public static AlertsManagementDayOfWeek Tuesday { get; } = new AlertsManagementDayOfWeek(TuesdayValue);
        /// <summary>
        /// Wednesday
        /// Serialized Name: DaysOfWeek.Wednesday
        /// </summary>
        public static AlertsManagementDayOfWeek Wednesday { get; } = new AlertsManagementDayOfWeek(WednesdayValue);
        /// <summary>
        /// Thursday
        /// Serialized Name: DaysOfWeek.Thursday
        /// </summary>
        public static AlertsManagementDayOfWeek Thursday { get; } = new AlertsManagementDayOfWeek(ThursdayValue);
        /// <summary>
        /// Friday
        /// Serialized Name: DaysOfWeek.Friday
        /// </summary>
        public static AlertsManagementDayOfWeek Friday { get; } = new AlertsManagementDayOfWeek(FridayValue);
        /// <summary>
        /// Saturday
        /// Serialized Name: DaysOfWeek.Saturday
        /// </summary>
        public static AlertsManagementDayOfWeek Saturday { get; } = new AlertsManagementDayOfWeek(SaturdayValue);
        /// <summary> Determines if two <see cref="AlertsManagementDayOfWeek"/> values are the same. </summary>
        public static bool operator ==(AlertsManagementDayOfWeek left, AlertsManagementDayOfWeek right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AlertsManagementDayOfWeek"/> values are not the same. </summary>
        public static bool operator !=(AlertsManagementDayOfWeek left, AlertsManagementDayOfWeek right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AlertsManagementDayOfWeek"/>. </summary>
        public static implicit operator AlertsManagementDayOfWeek(string value) => new AlertsManagementDayOfWeek(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AlertsManagementDayOfWeek other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AlertsManagementDayOfWeek other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
