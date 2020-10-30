// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Security.Attestation.Models
{
    /// <summary> Type of the report payload. </summary>
    public readonly partial struct SevSnpReportType : IEquatable<SevSnpReportType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="SevSnpReportType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SevSnpReportType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string HclHyperVValue = "HclHyperV";

        /// <summary> SEV SNP report generated by HCL running on HyperV platform. </summary>
        public static SevSnpReportType HclHyperV { get; } = new SevSnpReportType(HclHyperVValue);
        /// <summary> Determines if two <see cref="SevSnpReportType"/> values are the same. </summary>
        public static bool operator ==(SevSnpReportType left, SevSnpReportType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SevSnpReportType"/> values are not the same. </summary>
        public static bool operator !=(SevSnpReportType left, SevSnpReportType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SevSnpReportType"/>. </summary>
        public static implicit operator SevSnpReportType(string value) => new SevSnpReportType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SevSnpReportType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SevSnpReportType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
