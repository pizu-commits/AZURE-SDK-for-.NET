// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> An enum describing the unit of measurement. </summary>
    public readonly partial struct FrontDoorUsageUnit : IEquatable<FrontDoorUsageUnit>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FrontDoorUsageUnit"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FrontDoorUsageUnit(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CountValue = "Count";

        /// <summary> Count. </summary>
        public static FrontDoorUsageUnit Count { get; } = new FrontDoorUsageUnit(CountValue);
        /// <summary> Determines if two <see cref="FrontDoorUsageUnit"/> values are the same. </summary>
        public static bool operator ==(FrontDoorUsageUnit left, FrontDoorUsageUnit right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FrontDoorUsageUnit"/> values are not the same. </summary>
        public static bool operator !=(FrontDoorUsageUnit left, FrontDoorUsageUnit right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="FrontDoorUsageUnit"/>. </summary>
        public static implicit operator FrontDoorUsageUnit(string value) => new FrontDoorUsageUnit(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FrontDoorUsageUnit other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FrontDoorUsageUnit other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
