// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> Represent the billing plans. </summary>
    public readonly partial struct ReservationBillingPlan : IEquatable<ReservationBillingPlan>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ReservationBillingPlan"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ReservationBillingPlan(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UpfrontValue = "Upfront";
        private const string MonthlyValue = "Monthly";

        /// <summary> Upfront. </summary>
        public static ReservationBillingPlan Upfront { get; } = new ReservationBillingPlan(UpfrontValue);
        /// <summary> Monthly. </summary>
        public static ReservationBillingPlan Monthly { get; } = new ReservationBillingPlan(MonthlyValue);
        /// <summary> Determines if two <see cref="ReservationBillingPlan"/> values are the same. </summary>
        public static bool operator ==(ReservationBillingPlan left, ReservationBillingPlan right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ReservationBillingPlan"/> values are not the same. </summary>
        public static bool operator !=(ReservationBillingPlan left, ReservationBillingPlan right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ReservationBillingPlan"/>. </summary>
        public static implicit operator ReservationBillingPlan(string value) => new ReservationBillingPlan(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ReservationBillingPlan other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ReservationBillingPlan other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
