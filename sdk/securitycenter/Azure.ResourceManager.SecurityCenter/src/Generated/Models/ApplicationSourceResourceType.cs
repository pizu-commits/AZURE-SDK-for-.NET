// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The application source, what it affects, e.g. Assessments. </summary>
    public readonly partial struct ApplicationSourceResourceType : IEquatable<ApplicationSourceResourceType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ApplicationSourceResourceType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ApplicationSourceResourceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AssessmentsValue = "Assessments";

        /// <summary> The source of the application is assessments. </summary>
        public static ApplicationSourceResourceType Assessments { get; } = new ApplicationSourceResourceType(AssessmentsValue);
        /// <summary> Determines if two <see cref="ApplicationSourceResourceType"/> values are the same. </summary>
        public static bool operator ==(ApplicationSourceResourceType left, ApplicationSourceResourceType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ApplicationSourceResourceType"/> values are not the same. </summary>
        public static bool operator !=(ApplicationSourceResourceType left, ApplicationSourceResourceType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ApplicationSourceResourceType"/>. </summary>
        public static implicit operator ApplicationSourceResourceType(string value) => new ApplicationSourceResourceType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ApplicationSourceResourceType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ApplicationSourceResourceType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
