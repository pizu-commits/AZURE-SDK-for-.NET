// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes the nature of the policy violation. </summary>
    public readonly partial struct PolicyViolationCategory : IEquatable<PolicyViolationCategory>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PolicyViolationCategory"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PolicyViolationCategory(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OtherValue = "Other";
        private const string ImageFlaggedUnsafeValue = "ImageFlaggedUnsafe";
        private const string CopyrightValidationValue = "CopyrightValidation";
        private const string IPTheftValue = "IpTheft";

        /// <summary> Other. </summary>
        public static PolicyViolationCategory Other { get; } = new PolicyViolationCategory(OtherValue);
        /// <summary> ImageFlaggedUnsafe. </summary>
        public static PolicyViolationCategory ImageFlaggedUnsafe { get; } = new PolicyViolationCategory(ImageFlaggedUnsafeValue);
        /// <summary> CopyrightValidation. </summary>
        public static PolicyViolationCategory CopyrightValidation { get; } = new PolicyViolationCategory(CopyrightValidationValue);
        /// <summary> IpTheft. </summary>
        public static PolicyViolationCategory IPTheft { get; } = new PolicyViolationCategory(IPTheftValue);
        /// <summary> Determines if two <see cref="PolicyViolationCategory"/> values are the same. </summary>
        public static bool operator ==(PolicyViolationCategory left, PolicyViolationCategory right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PolicyViolationCategory"/> values are not the same. </summary>
        public static bool operator !=(PolicyViolationCategory left, PolicyViolationCategory right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PolicyViolationCategory"/>. </summary>
        public static implicit operator PolicyViolationCategory(string value) => new PolicyViolationCategory(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PolicyViolationCategory other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PolicyViolationCategory other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
