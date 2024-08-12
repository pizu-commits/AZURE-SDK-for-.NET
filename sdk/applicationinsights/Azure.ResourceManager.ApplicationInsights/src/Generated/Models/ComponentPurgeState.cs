// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> Status of the operation represented by the requested Id. </summary>
    public readonly partial struct ComponentPurgeState : IEquatable<ComponentPurgeState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ComponentPurgeState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ComponentPurgeState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingValue = "pending";
        private const string CompletedValue = "completed";

        /// <summary> pending. </summary>
        public static ComponentPurgeState Pending { get; } = new ComponentPurgeState(PendingValue);
        /// <summary> completed. </summary>
        public static ComponentPurgeState Completed { get; } = new ComponentPurgeState(CompletedValue);
        /// <summary> Determines if two <see cref="ComponentPurgeState"/> values are the same. </summary>
        public static bool operator ==(ComponentPurgeState left, ComponentPurgeState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ComponentPurgeState"/> values are not the same. </summary>
        public static bool operator !=(ComponentPurgeState left, ComponentPurgeState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ComponentPurgeState"/>. </summary>
        public static implicit operator ComponentPurgeState(string value) => new ComponentPurgeState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ComponentPurgeState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ComponentPurgeState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
