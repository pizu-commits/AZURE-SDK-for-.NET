// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Purview.Models
{
    /// <summary> The state of the event streaming service. </summary>
    public readonly partial struct PurviewEventStreamingState : IEquatable<PurviewEventStreamingState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PurviewEventStreamingState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PurviewEventStreamingState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DisabledValue = "Disabled";
        private const string EnabledValue = "Enabled";

        /// <summary> Disabled. </summary>
        public static PurviewEventStreamingState Disabled { get; } = new PurviewEventStreamingState(DisabledValue);
        /// <summary> Enabled. </summary>
        public static PurviewEventStreamingState Enabled { get; } = new PurviewEventStreamingState(EnabledValue);
        /// <summary> Determines if two <see cref="PurviewEventStreamingState"/> values are the same. </summary>
        public static bool operator ==(PurviewEventStreamingState left, PurviewEventStreamingState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PurviewEventStreamingState"/> values are not the same. </summary>
        public static bool operator !=(PurviewEventStreamingState left, PurviewEventStreamingState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PurviewEventStreamingState"/>. </summary>
        public static implicit operator PurviewEventStreamingState(string value) => new PurviewEventStreamingState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PurviewEventStreamingState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PurviewEventStreamingState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
