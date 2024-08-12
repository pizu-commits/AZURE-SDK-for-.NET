// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Vision.Face
{
    /// <summary> Indicates level of exposure. </summary>
    public readonly partial struct ExposureLevel : IEquatable<ExposureLevel>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ExposureLevel"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ExposureLevel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnderExposureValue = "underExposure";
        private const string GoodExposureValue = "goodExposure";
        private const string OverExposureValue = "overExposure";

        /// <summary> Low exposure level. </summary>
        public static ExposureLevel UnderExposure { get; } = new ExposureLevel(UnderExposureValue);
        /// <summary> Good exposure level. </summary>
        public static ExposureLevel GoodExposure { get; } = new ExposureLevel(GoodExposureValue);
        /// <summary> High exposure level. </summary>
        public static ExposureLevel OverExposure { get; } = new ExposureLevel(OverExposureValue);
        /// <summary> Determines if two <see cref="ExposureLevel"/> values are the same. </summary>
        public static bool operator ==(ExposureLevel left, ExposureLevel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ExposureLevel"/> values are not the same. </summary>
        public static bool operator !=(ExposureLevel left, ExposureLevel right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ExposureLevel"/>. </summary>
        public static implicit operator ExposureLevel(string value) => new ExposureLevel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ExposureLevel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ExposureLevel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
