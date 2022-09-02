// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    /// <summary>
    /// The InformationIdentifier.
    /// Serialized Name: Identifier
    /// </summary>
    public readonly partial struct InformationIdentifier : IEquatable<InformationIdentifier>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="InformationIdentifier"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public InformationIdentifier(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MonitorServiceListValue = "MonitorServiceList";

        /// <summary>
        /// MonitorServiceList
        /// Serialized Name: Identifier.MonitorServiceList
        /// </summary>
        public static InformationIdentifier MonitorServiceList { get; } = new InformationIdentifier(MonitorServiceListValue);
        /// <summary> Determines if two <see cref="InformationIdentifier"/> values are the same. </summary>
        public static bool operator ==(InformationIdentifier left, InformationIdentifier right) => left.Equals(right);
        /// <summary> Determines if two <see cref="InformationIdentifier"/> values are not the same. </summary>
        public static bool operator !=(InformationIdentifier left, InformationIdentifier right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="InformationIdentifier"/>. </summary>
        public static implicit operator InformationIdentifier(string value) => new InformationIdentifier(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InformationIdentifier other && Equals(other);
        /// <inheritdoc />
        public bool Equals(InformationIdentifier other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
