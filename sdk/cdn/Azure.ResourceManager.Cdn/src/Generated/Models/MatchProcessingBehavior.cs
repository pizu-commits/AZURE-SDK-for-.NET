// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> If this rule is a match should the rules engine continue running the remaining rules or stop. If not present, defaults to Continue. </summary>
    public readonly partial struct MatchProcessingBehavior : IEquatable<MatchProcessingBehavior>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MatchProcessingBehavior"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MatchProcessingBehavior(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ContinueValue = "Continue";
        private const string StopValue = "Stop";

        /// <summary> Continue. </summary>
        public static MatchProcessingBehavior Continue { get; } = new MatchProcessingBehavior(ContinueValue);
        /// <summary> Stop. </summary>
        public static MatchProcessingBehavior Stop { get; } = new MatchProcessingBehavior(StopValue);
        /// <summary> Determines if two <see cref="MatchProcessingBehavior"/> values are the same. </summary>
        public static bool operator ==(MatchProcessingBehavior left, MatchProcessingBehavior right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MatchProcessingBehavior"/> values are not the same. </summary>
        public static bool operator !=(MatchProcessingBehavior left, MatchProcessingBehavior right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MatchProcessingBehavior"/>. </summary>
        public static implicit operator MatchProcessingBehavior(string value) => new MatchProcessingBehavior(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MatchProcessingBehavior other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MatchProcessingBehavior other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
