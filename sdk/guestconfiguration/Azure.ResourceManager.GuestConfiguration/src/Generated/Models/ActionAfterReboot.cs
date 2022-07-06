// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.GuestConfiguration.Models
{
    /// <summary> Specifies what happens after a reboot during the application of a configuration. The possible values are ContinueConfiguration and StopConfiguration. </summary>
    public readonly partial struct ActionAfterReboot : IEquatable<ActionAfterReboot>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ActionAfterReboot"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ActionAfterReboot(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ContinueConfigurationValue = "ContinueConfiguration";
        private const string StopConfigurationValue = "StopConfiguration";

        /// <summary> ContinueConfiguration. </summary>
        public static ActionAfterReboot ContinueConfiguration { get; } = new ActionAfterReboot(ContinueConfigurationValue);
        /// <summary> StopConfiguration. </summary>
        public static ActionAfterReboot StopConfiguration { get; } = new ActionAfterReboot(StopConfigurationValue);
        /// <summary> Determines if two <see cref="ActionAfterReboot"/> values are the same. </summary>
        public static bool operator ==(ActionAfterReboot left, ActionAfterReboot right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ActionAfterReboot"/> values are not the same. </summary>
        public static bool operator !=(ActionAfterReboot left, ActionAfterReboot right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ActionAfterReboot"/>. </summary>
        public static implicit operator ActionAfterReboot(string value) => new ActionAfterReboot(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ActionAfterReboot other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ActionAfterReboot other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
