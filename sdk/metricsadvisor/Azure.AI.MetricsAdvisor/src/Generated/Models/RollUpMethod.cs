// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> roll up method. </summary>
    public readonly partial struct RollUpMethod : IEquatable<RollUpMethod>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="RollUpMethod"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RollUpMethod(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string SumValue = "Sum";
        private const string MaxValue = "Max";
        private const string MinValue = "Min";
        private const string AvgValue = "Avg";
        private const string CountValue = "Count";

        /// <summary> None. </summary>
        public static RollUpMethod None { get; } = new RollUpMethod(NoneValue);
        /// <summary> Sum. </summary>
        public static RollUpMethod Sum { get; } = new RollUpMethod(SumValue);
        /// <summary> Max. </summary>
        public static RollUpMethod Max { get; } = new RollUpMethod(MaxValue);
        /// <summary> Min. </summary>
        public static RollUpMethod Min { get; } = new RollUpMethod(MinValue);
        /// <summary> Avg. </summary>
        public static RollUpMethod Avg { get; } = new RollUpMethod(AvgValue);
        /// <summary> Count. </summary>
        public static RollUpMethod Count { get; } = new RollUpMethod(CountValue);
        /// <summary> Determines if two <see cref="RollUpMethod"/> values are the same. </summary>
        public static bool operator ==(RollUpMethod left, RollUpMethod right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RollUpMethod"/> values are not the same. </summary>
        public static bool operator !=(RollUpMethod left, RollUpMethod right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RollUpMethod"/>. </summary>
        public static implicit operator RollUpMethod(string value) => new RollUpMethod(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RollUpMethod other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RollUpMethod other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
