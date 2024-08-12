// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Quantum.Jobs.Models
{
    /// <summary> Provider availability. </summary>
    public readonly partial struct ProviderAvailability : IEquatable<ProviderAvailability>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ProviderAvailability"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ProviderAvailability(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AvailableValue = "Available";
        private const string DegradedValue = "Degraded";
        private const string UnavailableValue = "Unavailable";

        /// <summary> Available. </summary>
        public static ProviderAvailability Available { get; } = new ProviderAvailability(AvailableValue);
        /// <summary> Degraded. </summary>
        public static ProviderAvailability Degraded { get; } = new ProviderAvailability(DegradedValue);
        /// <summary> Unavailable. </summary>
        public static ProviderAvailability Unavailable { get; } = new ProviderAvailability(UnavailableValue);
        /// <summary> Determines if two <see cref="ProviderAvailability"/> values are the same. </summary>
        public static bool operator ==(ProviderAvailability left, ProviderAvailability right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ProviderAvailability"/> values are not the same. </summary>
        public static bool operator !=(ProviderAvailability left, ProviderAvailability right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ProviderAvailability"/>. </summary>
        public static implicit operator ProviderAvailability(string value) => new ProviderAvailability(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ProviderAvailability other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ProviderAvailability other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
