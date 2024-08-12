// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Communication.Models
{
    /// <summary> Type of verification. </summary>
    public readonly partial struct DomainRecordVerificationType : IEquatable<DomainRecordVerificationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DomainRecordVerificationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DomainRecordVerificationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DomainValue = "Domain";
        private const string SpfValue = "SPF";
        private const string DkimValue = "DKIM";
        private const string Dkim2Value = "DKIM2";
        private const string DmarcValue = "DMARC";

        /// <summary> Domain. </summary>
        public static DomainRecordVerificationType Domain { get; } = new DomainRecordVerificationType(DomainValue);
        /// <summary> SPF. </summary>
        public static DomainRecordVerificationType Spf { get; } = new DomainRecordVerificationType(SpfValue);
        /// <summary> DKIM. </summary>
        public static DomainRecordVerificationType Dkim { get; } = new DomainRecordVerificationType(DkimValue);
        /// <summary> DKIM2. </summary>
        public static DomainRecordVerificationType Dkim2 { get; } = new DomainRecordVerificationType(Dkim2Value);
        /// <summary> DMARC. </summary>
        public static DomainRecordVerificationType Dmarc { get; } = new DomainRecordVerificationType(DmarcValue);
        /// <summary> Determines if two <see cref="DomainRecordVerificationType"/> values are the same. </summary>
        public static bool operator ==(DomainRecordVerificationType left, DomainRecordVerificationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DomainRecordVerificationType"/> values are not the same. </summary>
        public static bool operator !=(DomainRecordVerificationType left, DomainRecordVerificationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DomainRecordVerificationType"/>. </summary>
        public static implicit operator DomainRecordVerificationType(string value) => new DomainRecordVerificationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DomainRecordVerificationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DomainRecordVerificationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
