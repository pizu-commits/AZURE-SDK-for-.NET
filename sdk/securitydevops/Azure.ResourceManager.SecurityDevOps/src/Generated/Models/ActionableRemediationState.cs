// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityDevOps.Models
{
    /// <summary> The ActionableRemediationState. </summary>
    public readonly partial struct ActionableRemediationState : IEquatable<ActionableRemediationState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ActionableRemediationState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ActionableRemediationState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string DisabledValue = "Disabled";
        private const string EnabledValue = "Enabled";

        /// <summary> None. </summary>
        public static ActionableRemediationState None { get; } = new ActionableRemediationState(NoneValue);
        /// <summary> Disabled. </summary>
        public static ActionableRemediationState Disabled { get; } = new ActionableRemediationState(DisabledValue);
        /// <summary> Enabled. </summary>
        public static ActionableRemediationState Enabled { get; } = new ActionableRemediationState(EnabledValue);
        /// <summary> Determines if two <see cref="ActionableRemediationState"/> values are the same. </summary>
        public static bool operator ==(ActionableRemediationState left, ActionableRemediationState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ActionableRemediationState"/> values are not the same. </summary>
        public static bool operator !=(ActionableRemediationState left, ActionableRemediationState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ActionableRemediationState"/>. </summary>
        public static implicit operator ActionableRemediationState(string value) => new ActionableRemediationState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ActionableRemediationState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ActionableRemediationState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
