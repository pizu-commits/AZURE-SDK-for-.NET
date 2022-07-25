// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary>
    /// The status annotation.
    /// Serialized Name: StatusAnnotation
    /// </summary>
    public readonly partial struct StatusAnnotation : IEquatable<StatusAnnotation>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="StatusAnnotation"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StatusAnnotation(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotSpecifiedValue = "NotSpecified";
        private const string PreviewValue = "Preview";
        private const string ProductionValue = "Production";

        /// <summary>
        /// NotSpecified
        /// Serialized Name: StatusAnnotation.NotSpecified
        /// </summary>
        public static StatusAnnotation NotSpecified { get; } = new StatusAnnotation(NotSpecifiedValue);
        /// <summary>
        /// Preview
        /// Serialized Name: StatusAnnotation.Preview
        /// </summary>
        public static StatusAnnotation Preview { get; } = new StatusAnnotation(PreviewValue);
        /// <summary>
        /// Production
        /// Serialized Name: StatusAnnotation.Production
        /// </summary>
        public static StatusAnnotation Production { get; } = new StatusAnnotation(ProductionValue);
        /// <summary> Determines if two <see cref="StatusAnnotation"/> values are the same. </summary>
        public static bool operator ==(StatusAnnotation left, StatusAnnotation right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StatusAnnotation"/> values are not the same. </summary>
        public static bool operator !=(StatusAnnotation left, StatusAnnotation right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="StatusAnnotation"/>. </summary>
        public static implicit operator StatusAnnotation(string value) => new StatusAnnotation(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StatusAnnotation other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StatusAnnotation other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
