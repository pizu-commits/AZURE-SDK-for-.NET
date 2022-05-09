// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The FHIR Spec version that the result will use to format the fhirBundle. For additional information see https://www.hl7.org/fhir/overview.html. </summary>
    public readonly partial struct HealthcareTaskParametersFhirVersion : IEquatable<HealthcareTaskParametersFhirVersion>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HealthcareTaskParametersFhirVersion"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HealthcareTaskParametersFhirVersion(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string Four01Value = "4.0.1";

        /// <summary> 4.0.1. </summary>
        public static HealthcareTaskParametersFhirVersion Four01 { get; } = new HealthcareTaskParametersFhirVersion(Four01Value);
        /// <summary> Determines if two <see cref="HealthcareTaskParametersFhirVersion"/> values are the same. </summary>
        public static bool operator ==(HealthcareTaskParametersFhirVersion left, HealthcareTaskParametersFhirVersion right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HealthcareTaskParametersFhirVersion"/> values are not the same. </summary>
        public static bool operator !=(HealthcareTaskParametersFhirVersion left, HealthcareTaskParametersFhirVersion right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="HealthcareTaskParametersFhirVersion"/>. </summary>
        public static implicit operator HealthcareTaskParametersFhirVersion(string value) => new HealthcareTaskParametersFhirVersion(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HealthcareTaskParametersFhirVersion other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HealthcareTaskParametersFhirVersion other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
