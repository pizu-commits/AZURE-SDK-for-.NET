// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.StackHCI.Models
{
    /// <summary> Desired level of diagnostic data emitted by the cluster. </summary>
    public readonly partial struct DiagnosticLevel : IEquatable<DiagnosticLevel>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DiagnosticLevel"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DiagnosticLevel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OffValue = "Off";
        private const string BasicValue = "Basic";
        private const string EnhancedValue = "Enhanced";

        /// <summary> Off. </summary>
        public static DiagnosticLevel Off { get; } = new DiagnosticLevel(OffValue);
        /// <summary> Basic. </summary>
        public static DiagnosticLevel Basic { get; } = new DiagnosticLevel(BasicValue);
        /// <summary> Enhanced. </summary>
        public static DiagnosticLevel Enhanced { get; } = new DiagnosticLevel(EnhancedValue);
        /// <summary> Determines if two <see cref="DiagnosticLevel"/> values are the same. </summary>
        public static bool operator ==(DiagnosticLevel left, DiagnosticLevel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DiagnosticLevel"/> values are not the same. </summary>
        public static bool operator !=(DiagnosticLevel left, DiagnosticLevel right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DiagnosticLevel"/>. </summary>
        public static implicit operator DiagnosticLevel(string value) => new DiagnosticLevel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DiagnosticLevel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DiagnosticLevel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
