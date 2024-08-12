// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary>
    /// Specifies the behavior when monthly free limits are exhausted for the free database.
    ///
    /// AutoPause: The database will be auto paused upon exhaustion of free limits for remainder of the month.
    ///
    /// BillForUsage: The database will continue to be online upon exhaustion of free limits and any overage will be billed.
    /// </summary>
    public readonly partial struct FreeLimitExhaustionBehavior : IEquatable<FreeLimitExhaustionBehavior>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FreeLimitExhaustionBehavior"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FreeLimitExhaustionBehavior(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AutoPauseValue = "AutoPause";
        private const string BillOverUsageValue = "BillOverUsage";

        /// <summary> AutoPause. </summary>
        public static FreeLimitExhaustionBehavior AutoPause { get; } = new FreeLimitExhaustionBehavior(AutoPauseValue);
        /// <summary> BillOverUsage. </summary>
        public static FreeLimitExhaustionBehavior BillOverUsage { get; } = new FreeLimitExhaustionBehavior(BillOverUsageValue);
        /// <summary> Determines if two <see cref="FreeLimitExhaustionBehavior"/> values are the same. </summary>
        public static bool operator ==(FreeLimitExhaustionBehavior left, FreeLimitExhaustionBehavior right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FreeLimitExhaustionBehavior"/> values are not the same. </summary>
        public static bool operator !=(FreeLimitExhaustionBehavior left, FreeLimitExhaustionBehavior right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FreeLimitExhaustionBehavior"/>. </summary>
        public static implicit operator FreeLimitExhaustionBehavior(string value) => new FreeLimitExhaustionBehavior(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FreeLimitExhaustionBehavior other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FreeLimitExhaustionBehavior other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
